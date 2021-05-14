using Appplication.Controller;
using Appplication.Controller.Documents;
using Appplication.Statics;
using Aton.Views.Save;
using Domain.Domain.Entities;
using Domain.Domain.Entities.Documents;
using Domain.Domain.Entities.ProductStock;

using Domain.Domain.Entities.Temp;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Aton.Views.General.product.StockUI
{

    public partial class FrmProductTransition : Form
    {
        StorageController storageController = new StorageController();
        SerieController serieController = new SerieController();
        ProductEntryController preoductEntry = new ProductEntryController();
        StockController stockController = new StockController();
        ProductsSelectedSellController productSelectedSellController = new ProductsSelectedSellController();
        List<ProductsSelectedSell> productsSelectedTransition = new List<ProductsSelectedSell>();
        Stock stock = new Stock();

        SerieController _serieController = new SerieController();
        StockTransitonTypeController _stockTypeController = new StockTransitonTypeController();
        StockTransitionController _StockTransitionController = new StockTransitionController();

        InvoiceTypeController _invoiceTypeController = new InvoiceTypeController();
        StockController _stock = new StockController();
        ProductController _products = new ProductController();
        InvoiceController _invoiceController = new InvoiceController();


        ConstructStockControl construct;
        Invoice lastInvoice;

        int idSerie;
        int _codigoFaturaAtual;
        int rowHandle, productRemoveId;

        string obs;
        decimal totDescontoProducts = 0;
        decimal TotalIva = 0;
        decimal TotalIncidencia;

        string idTipoDocumento = "0";


        public FrmProductTransition(ConstructStockControl constructControl)
        {
            InitializeComponent();
            construct = constructControl;

            storageController.ListAllAsNoTracking().ForEach(c => cmbArmazem.Properties.Items.Add(c.Armazem));
            serieController.ListALLAsNoTracking().ForEach(c => cmbSerie.Properties.Items.Add(c.Serie));

            if (construct != ConstructStockControl.transference)
            {
                cmbArmazemDestino.Visible = false;
                lblStDestino.Visible = false;
            }

            if (cmbArmazem.Properties.Items.Count > 0)
                cmbArmazem.SelectedIndex = 0;
            if (cmbSerie.Properties.Items.Count > 0)
                cmbSerie.SelectedIndex = 0;
            initilize();

        }

        public void initilize()
        {
            cmbInvoiceType.Properties.Items.Clear();
            foreach (var item in ListInvoiceType())
            {
                cmbInvoiceType.Properties.Items.Add(item.Tipo);
                cbInvoiceName.Items.Add(item.Descricao);
            }
            if (cmbInvoiceType.Properties.Items.Count > 0)
            {
                switch (construct)
                {
                    case ConstructStockControl.productEntry:
                        this.Text = "Entrada de Produto";
                        cmbInvoiceType.Text = "EST";
                        break;
                    case ConstructStockControl.productOut:
                        Text = "Saida de Produto";
                        cmbInvoiceType.Text = "SST";
                        break;
                    case ConstructStockControl.transference:
                        Text = "Transferência de produto";
                        cmbInvoiceType.Text = "TST";
                        break;
                }
                cbInvoiceName.SelectedIndex = cmbInvoiceType.SelectedIndex;
            }
            if (cmbSerie.Properties.Items.Count > 0)
                cmbSerie.SelectedIndex = 0;
        }

        public List<Storage> storageWithout_storageQuery(string storageQuery)
        {
            return storageController.ListAllAsNoTracking().Where(c => !c.Armazem.Equals(storageQuery)).ToList();
        }

        private void panelControl1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void FrmEntryProduct_Load(object sender, EventArgs e)
        {

        }

        public void addProductGrid(int idStock)
        {
            stock = stockController.getOne(idStock);
            bool productsAlreadSelected = false;
            int indice = 0;

            foreach (var item in productsSelectedTransition)
            {
                if (item.ProdutoId == stock.ProdutoId)
                {
                    productsAlreadSelected = true;
                    break;
                }
                indice++;
            }
            
            if (!productsAlreadSelected)
            {
                Product product = new ProductController().getOne(stock.ProdutoId);
                productsSelectedTransition.Add(new ProductsSelectedSell() {
                    Preco = product.Preco1,
                    Desconto = 0,
                    Quantidade = 1,
                    ProdutoId = product.Id,
                    StockId = stock.Id,
                    Produto = product,
                    Stock = stock
                });

            }
            else
            {
                productsSelectedTransition[indice].Quantidade++;
            }

            refreshGrid();

        }

        public void refreshGrid()
        {
            gdvControlProducts.DataSource = productsSelectedTransition;
            gridProducts.RefreshData();
            updateTots();
        }

        private void cmbArmazem_SelectedIndexChanged(object sender, EventArgs e)
        {
            storageWithout_storageQuery(cmbArmazem.Text).ForEach(c => cmbArmazemDestino.Properties.Items.Add(c.Armazem));
            if (cmbArmazemDestino.Properties.Items.Count > 0)
                cmbArmazemDestino.SelectedIndex = 0;

        }

        public void CalcCodigoFaturaAtual()
        {
          //  lblFirstDoc.Visible = false;
            if (cmbSerie.SelectedIndex != -1)
                idSerie = _serieController.ListALLAsNoTracking()[cmbSerie.SelectedIndex].Id;
            if (cmbInvoiceType.SelectedIndex != -1)
                idTipoDocumento = getInvoiceTypeType();

            _codigoFaturaAtual = 1;
            lastInvoice = _invoiceController.lastInvoiceInSerieAndType(idSerie, idTipoDocumento);

            if (lastInvoice != null)
            {
                _codigoFaturaAtual += lastInvoice.Codigo;
            }
        }

        public List<InvoiceType> ListInvoiceType()
        {
            return _invoiceTypeController.ListALLAsNoTracking().Where(c => c.Stock).ToList();
        }

        public string getInvoiceTypeType()
        {
            return ListInvoiceType()[cmbInvoiceType.SelectedIndex].Tipo;
        }

        public void salvar()
        {
            //Series serie = _serieController.ListALLAsNoTracking()[cmbSerie.SelectedIndex];
            
            CalcCodigoFaturaAtual();
            obs = txtDescricao.Text;
            string documentNo = getInvoiceTypeType() + " " + _serieController.ListALLAsNoTracking()[cmbSerie.SelectedIndex].Serie + "/" + _codigoFaturaAtual;
                
            Invoice document = new Invoice()
            {
                InvoiceDate = DateTime.Now.ToString("yyyy-MM-dd"),
                Codigo = _codigoFaturaAtual,
                SeriesId = idSerie,
                InvoiceNo = documentNo,
                TipoDocumentoId = idTipoDocumento,
                Desconto = totDescontoProducts,
                Observacao = obs,
                TotalImposto = TotalIva,
                TotalIncidencia = TotalIncidencia,
                TotalLiquidar = 0,
                UserId = UserCurrent.getCurrentUser().Id,
                DataCadastro = DateTime.Now,
            };
            _invoiceController.insert(document);

            document = _invoiceController.getForInvoiceNo(documentNo);
            int idFatura = document != null ? document.Id : 0;

            if (idFatura == 0)
                MessageBox.Show("Fatura Nula");
            _invoiceController.Dispose();
            _invoiceController = new InvoiceController();

            StockTransition stockTransitionForSave;
            Stock stockOrigin;
            Stock stockDestino;

            foreach (var item in productsSelectedTransition)
            {
                stockOrigin = _stock.getStockArmazemProduct(item.ProdutoId, item.Stock.ArmazemId);
                
                if (construct == ConstructStockControl.productEntry)
                {
                    stockOrigin.Quantidade += item.Quantidade;
                    _stock.update(stockOrigin);
                }else if(construct == ConstructStockControl.productOut || construct == ConstructStockControl.transference)
                {
                    stockOrigin.Quantidade -= item.Quantidade;
                    _stock.update(stockOrigin);

                    if(construct == ConstructStockControl.transference)
                    {
                        int storageDestinId = storageWithout_storageQuery(cmbArmazem.Text)[cmbArmazemDestino.SelectedIndex].Id;
                        stockDestino = _stock.getStockArmazemProduct(item.ProdutoId, storageDestinId);

                        if (stockDestino == null)
                        {
                            stockController.insert(stockDestino = new Stock()
                            {
                                ArmazemId = storageDestinId,
                                ProdutoId = item.ProdutoId,
                                Quantidade = item.Quantidade,
                                MaxStock = 1000000000,
                                MinStock = 0,
                                PrecoMedio = stockOrigin.PrecoMedio,
                                UltimoPreco = stockOrigin.UltimoPreco,
                            });
                        }
                        else
                        {
                            stockDestino.Quantidade += item.Quantidade;
                            _stock.update(stockDestino);
                        }
                    }
                }
                

                string movitoISE = null;
                Product product = _products.getOne(item.ProdutoId);
                if (product.MotivoISEId != null)
                    movitoISE = product.MotivoISE.MencaoFatura;

                stockTransitionForSave = new StockTransition()
                {
                    Custo = item.Preco,
                    Quantidade = item.Quantidade,
                    ProdutoId = item.ProdutoId,
                    Taxa = item.Taxa,
                    DocumentId = document.Id,
                    StockTransitionTypeId = _stockTypeController.getOneForInvoiceType(document.TipoDocumentoId).Id
                };

                _StockTransitionController.insert(stockTransitionForSave);
             
            }

            productsSelectedTransition.Clear();
            refreshGrid();
            CalcCodigoFaturaAtual();
            //   print(idFatura);

        }

        private void btnAddProduct_Click(object sender, EventArgs e)
        {
            new FrmProdutoView(this).ShowDialog();
        }

        private void btnRemoveProduct_Click(object sender, EventArgs e)
        {
            if (gridProducts.RowCount>0)
            {
                rowHandle = gridProducts.GetSelectedRows()[0];
                productRemoveId = Convert.ToInt16(gridProducts.GetRowCellValue(rowHandle, gridProducts.Columns["ProdutoId"]).ToString());

                productsSelectedTransition.Remove(productsSelectedTransition.Where(p => p.ProdutoId == productRemoveId).FirstOrDefault());


                refreshGrid();
               
            }
            else
            {
                  MessageBox.Show("Nenhum produto na lista...");
            }

        }

        decimal descontoFatura;
        string oldValue = "0";
        private void txtDesconto_EditValueChanged(object sender, EventArgs e)
        {

            descontoFatura = decimal.Parse(txtDesconto.Text.Replace("%", ""));
            if (descontoFatura <= 100 && descontoFatura >= 0)
            {
                oldValue = descontoFatura.ToString();
                /*for (int i = 0; i < __listaSelected.Count; i++)
                {
                    __listaSelected[i].Desconto = descontoFatura;
                }*/
                foreach (var item in productsSelectedTransition)
                {
                    item.Desconto = descontoFatura;
                    //totDescontoProducts += item.ValorDesconto;
                    //TotalIva += item.TotalTaxa;
                }
                refreshGrid();
            }

            else
            {
                descontoFatura = decimal.Parse(oldValue);
                txtDesconto.Text = oldValue;
                //  updateTots();
            }

        }
        decimal total = 0;
        public void updateTots()
        {
            TotalIva = productsSelectedTransition.Sum(p => p.TotalTaxa);
            totDescontoProducts = productsSelectedTransition.Sum(p => p.ValorDesconto);
            TotalIncidencia = productsSelectedTransition.Sum(p => p.TotalIncidencia);
            total = productsSelectedTransition.Sum(p => p.Total);
            lblIncid.Text = TotalIncidencia.ToString("F2");
            lblImposto.Text = TotalIva.ToString("F2");
            lblTotDesconto.Text = totDescontoProducts.ToString("F2");
            lblTotal.Text = total.ToString("F2");
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            salvar();

            clearFields();
        }
        public void clearFields()
        {
            productsSelectedTransition.Clear();
            refreshGrid();
             
        }

        private void lblTotal_Click(object sender, EventArgs e)
        {

        }

        private void obs_TextChanged(object sender, EventArgs e)
        {

        }

        private void gridProducts_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            updateTots();
        }

        // Não esquecer de tirar o 1 do stockController -- Depois apaga esse comentario, está feio....
        // Não borra o código kkkkkkkkkkkkk
    }
}
