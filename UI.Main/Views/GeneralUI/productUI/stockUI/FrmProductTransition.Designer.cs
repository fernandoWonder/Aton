namespace Aton.Views.General.product.StockUI
{
    partial class FrmProductTransition
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmProductTransition));
            this.panel2 = new System.Windows.Forms.Panel();
            this.txtDescricao = new System.Windows.Forms.RichTextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.lblTotDesconto = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txtDesconto = new DevExpress.XtraEditors.TextEdit();
            this.label4 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnSave = new Bunifu.Framework.UI.BunifuThinButton2();
            this.lblTotal = new System.Windows.Forms.Label();
            this.lblImposto = new System.Windows.Forms.Label();
            this.lblIncid = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.gdvControlProducts = new DevExpress.XtraGrid.GridControl();
            this.gridProducts = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn3 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn4 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn5 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn6 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn7 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn8 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn9 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn10 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn12 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn11 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnRemoveProduct = new DevExpress.XtraEditors.SimpleButton();
            this.btnAddProduct = new DevExpress.XtraEditors.SimpleButton();
            this.panel4 = new System.Windows.Forms.Panel();
            this.cbInvoiceName = new System.Windows.Forms.ComboBox();
            this.cmbInvoiceType = new DevExpress.XtraEditors.ComboBoxEdit();
            this.label10 = new System.Windows.Forms.Label();
            this.cmbArmazemDestino = new DevExpress.XtraEditors.ComboBoxEdit();
            this.lblStDestino = new System.Windows.Forms.Label();
            this.cmbSerie = new DevExpress.XtraEditors.ComboBoxEdit();
            this.label1 = new System.Windows.Forms.Label();
            this.dtDataEtntrada = new System.Windows.Forms.DateTimePicker();
            this.cmbArmazem = new DevExpress.XtraEditors.ComboBoxEdit();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtDesconto.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gdvControlProducts)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridProducts)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cmbInvoiceType.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbArmazemDestino.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbSerie.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbArmazem.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Transparent;
            this.panel2.Controls.Add(this.txtDescricao);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.lblTotDesconto);
            this.panel2.Controls.Add(this.label9);
            this.panel2.Controls.Add(this.txtDesconto);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Controls.Add(this.btnSave);
            this.panel2.Controls.Add(this.lblTotal);
            this.panel2.Controls.Add(this.lblImposto);
            this.panel2.Controls.Add(this.lblIncid);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 455);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1008, 141);
            this.panel2.TabIndex = 1;
            // 
            // txtDescricao
            // 
            this.txtDescricao.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtDescricao.Location = new System.Drawing.Point(439, 9);
            this.txtDescricao.Name = "txtDescricao";
            this.txtDescricao.Size = new System.Drawing.Size(250, 70);
            this.txtDescricao.TabIndex = 159;
            this.txtDescricao.Text = "";
            this.txtDescricao.TextChanged += new System.EventHandler(this.obs_TextChanged);
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Tahoma", 10F);
            this.label6.Location = new System.Drawing.Point(356, 9);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(87, 17);
            this.label6.TabIndex = 160;
            this.label6.Text = "Observações";
            // 
            // lblTotDesconto
            // 
            this.lblTotDesconto.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblTotDesconto.AutoSize = true;
            this.lblTotDesconto.Font = new System.Drawing.Font("Tahoma", 10F);
            this.lblTotDesconto.Location = new System.Drawing.Point(115, 9);
            this.lblTotDesconto.Name = "lblTotDesconto";
            this.lblTotDesconto.Size = new System.Drawing.Size(36, 17);
            this.lblTotDesconto.TabIndex = 158;
            this.lblTotDesconto.Text = "0,00";
            // 
            // label9
            // 
            this.label9.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Tahoma", 10F);
            this.label9.Location = new System.Drawing.Point(8, 9);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(101, 17);
            this.label9.TabIndex = 157;
            this.label9.Text = "Total Desconto";
            // 
            // txtDesconto
            // 
            this.txtDesconto.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.txtDesconto.EditValue = "0";
            this.txtDesconto.Location = new System.Drawing.Point(247, 57);
            this.txtDesconto.Name = "txtDesconto";
            this.txtDesconto.Properties.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.txtDesconto.Properties.Appearance.ForeColor = System.Drawing.Color.Red;
            this.txtDesconto.Properties.Appearance.Options.UseFont = true;
            this.txtDesconto.Properties.Appearance.Options.UseForeColor = true;
            this.txtDesconto.Properties.Mask.BeepOnError = true;
            this.txtDesconto.Properties.Mask.EditMask = "P";
            this.txtDesconto.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.txtDesconto.Size = new System.Drawing.Size(137, 22);
            this.txtDesconto.TabIndex = 155;
            this.txtDesconto.EditValueChanged += new System.EventHandler(this.txtDesconto_EditValueChanged);
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label4.ForeColor = System.Drawing.Color.Gray;
            this.label4.Location = new System.Drawing.Point(157, 61);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(84, 17);
            this.label4.TabIndex = 156;
            this.label4.Text = "Desconto %";
            // 
            // panel3
            // 
            this.panel3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(115)))), ((int)(((byte)(199)))));
            this.panel3.Location = new System.Drawing.Point(4, 92);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1000, 5);
            this.panel3.TabIndex = 154;
            // 
            // btnSave
            // 
            this.btnSave.ActiveBorderThickness = 1;
            this.btnSave.ActiveCornerRadius = 20;
            this.btnSave.ActiveFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(76)))), ((int)(((byte)(132)))));
            this.btnSave.ActiveForecolor = System.Drawing.Color.White;
            this.btnSave.ActiveLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(115)))), ((int)(((byte)(199)))));
            this.btnSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSave.BackColor = System.Drawing.Color.Transparent;
            this.btnSave.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnSave.BackgroundImage")));
            this.btnSave.ButtonText = "Salvar";
            this.btnSave.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSave.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.ForeColor = System.Drawing.Color.White;
            this.btnSave.IdleBorderThickness = 1;
            this.btnSave.IdleCornerRadius = 20;
            this.btnSave.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(115)))), ((int)(((byte)(199)))));
            this.btnSave.IdleForecolor = System.Drawing.Color.White;
            this.btnSave.IdleLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(76)))), ((int)(((byte)(132)))));
            this.btnSave.Location = new System.Drawing.Point(883, 97);
            this.btnSave.Margin = new System.Windows.Forms.Padding(5);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(116, 40);
            this.btnSave.TabIndex = 153;
            this.btnSave.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // lblTotal
            // 
            this.lblTotal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTotal.Font = new System.Drawing.Font("Tahoma", 26F);
            this.lblTotal.Location = new System.Drawing.Point(695, 42);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblTotal.Size = new System.Drawing.Size(301, 42);
            this.lblTotal.TabIndex = 152;
            this.lblTotal.Text = "0,00";
            this.lblTotal.Click += new System.EventHandler(this.lblTotal_Click);
            // 
            // lblImposto
            // 
            this.lblImposto.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblImposto.AutoSize = true;
            this.lblImposto.Font = new System.Drawing.Font("Tahoma", 10F);
            this.lblImposto.Location = new System.Drawing.Point(78, 64);
            this.lblImposto.Name = "lblImposto";
            this.lblImposto.Size = new System.Drawing.Size(36, 17);
            this.lblImposto.TabIndex = 150;
            this.lblImposto.Text = "0,00";
            // 
            // lblIncid
            // 
            this.lblIncid.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblIncid.AutoSize = true;
            this.lblIncid.Font = new System.Drawing.Font("Tahoma", 10F);
            this.lblIncid.Location = new System.Drawing.Point(78, 37);
            this.lblIncid.Name = "lblIncid";
            this.lblIncid.Size = new System.Drawing.Size(36, 17);
            this.lblIncid.TabIndex = 149;
            this.lblIncid.Text = "0,00";
            // 
            // label8
            // 
            this.label8.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Tahoma", 10F);
            this.label8.Location = new System.Drawing.Point(951, 9);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(38, 17);
            this.label8.TabIndex = 148;
            this.label8.Text = "Total";
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Tahoma", 10F);
            this.label7.Location = new System.Drawing.Point(8, 64);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(65, 17);
            this.label7.TabIndex = 147;
            this.label7.Text = "Impostos";
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Tahoma", 10F);
            this.label5.Location = new System.Drawing.Point(8, 37);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(68, 17);
            this.label5.TabIndex = 146;
            this.label5.Text = "Incidencia";
            // 
            // gdvControlProducts
            // 
            this.gdvControlProducts.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gdvControlProducts.Location = new System.Drawing.Point(3, 3);
            this.gdvControlProducts.MainView = this.gridProducts;
            this.gdvControlProducts.Name = "gdvControlProducts";
            this.gdvControlProducts.Size = new System.Drawing.Size(1005, 369);
            this.gdvControlProducts.TabIndex = 0;
            this.gdvControlProducts.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridProducts});
            // 
            // gridProducts
            // 
            this.gridProducts.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn2,
            this.gridColumn3,
            this.gridColumn4,
            this.gridColumn5,
            this.gridColumn6,
            this.gridColumn7,
            this.gridColumn8,
            this.gridColumn9,
            this.gridColumn10,
            this.gridColumn12,
            this.gridColumn11});
            this.gridProducts.GridControl = this.gdvControlProducts;
            this.gridProducts.Name = "gridProducts";
            this.gridProducts.OptionsView.ShowFooter = true;
            this.gridProducts.OptionsView.ShowGroupPanel = false;
            this.gridProducts.CellValueChanged += new DevExpress.XtraGrid.Views.Base.CellValueChangedEventHandler(this.gridProducts_CellValueChanged);
            // 
            // gridColumn2
            // 
            this.gridColumn2.Caption = "StockId";
            this.gridColumn2.FieldName = "StockId";
            this.gridColumn2.Name = "gridColumn2";
            this.gridColumn2.Width = 82;
            // 
            // gridColumn3
            // 
            this.gridColumn3.Caption = "ProdutoId";
            this.gridColumn3.FieldName = "ProdutoId";
            this.gridColumn3.Name = "gridColumn3";
            this.gridColumn3.Width = 82;
            // 
            // gridColumn4
            // 
            this.gridColumn4.Caption = "Descricao Produto";
            this.gridColumn4.FieldName = "DescricaoProduto";
            this.gridColumn4.Name = "gridColumn4";
            this.gridColumn4.OptionsColumn.AllowEdit = false;
            this.gridColumn4.OptionsColumn.ShowInExpressionEditor = false;
            this.gridColumn4.Visible = true;
            this.gridColumn4.VisibleIndex = 0;
            this.gridColumn4.Width = 301;
            // 
            // gridColumn5
            // 
            this.gridColumn5.AppearanceHeader.BackColor = System.Drawing.Color.SteelBlue;
            this.gridColumn5.AppearanceHeader.Options.UseBackColor = true;
            this.gridColumn5.Caption = "Quantidade";
            this.gridColumn5.FieldName = "Quantidade";
            this.gridColumn5.Name = "gridColumn5";
            this.gridColumn5.Visible = true;
            this.gridColumn5.VisibleIndex = 1;
            this.gridColumn5.Width = 106;
            // 
            // gridColumn6
            // 
            this.gridColumn6.AppearanceHeader.BackColor = System.Drawing.Color.SteelBlue;
            this.gridColumn6.AppearanceHeader.Options.UseBackColor = true;
            this.gridColumn6.Caption = "Preço";
            this.gridColumn6.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.gridColumn6.FieldName = "Preco";
            this.gridColumn6.Name = "gridColumn6";
            this.gridColumn6.Visible = true;
            this.gridColumn6.VisibleIndex = 2;
            this.gridColumn6.Width = 69;
            // 
            // gridColumn7
            // 
            this.gridColumn7.AppearanceHeader.BackColor = System.Drawing.Color.SteelBlue;
            this.gridColumn7.AppearanceHeader.Options.UseBackColor = true;
            this.gridColumn7.Caption = "Desconto %";
            this.gridColumn7.FieldName = "Desconto";
            this.gridColumn7.Name = "gridColumn7";
            this.gridColumn7.Visible = true;
            this.gridColumn7.VisibleIndex = 3;
            this.gridColumn7.Width = 72;
            // 
            // gridColumn8
            // 
            this.gridColumn8.Caption = "Valor Desconto";
            this.gridColumn8.DisplayFormat.FormatString = "F3";
            this.gridColumn8.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.gridColumn8.FieldName = "ValorDesconto";
            this.gridColumn8.Name = "gridColumn8";
            this.gridColumn8.OptionsColumn.AllowEdit = false;
            this.gridColumn8.OptionsColumn.ShowInExpressionEditor = false;
            this.gridColumn8.Visible = true;
            this.gridColumn8.VisibleIndex = 4;
            this.gridColumn8.Width = 103;
            // 
            // gridColumn9
            // 
            this.gridColumn9.Caption = "Total Incidencia";
            this.gridColumn9.DisplayFormat.FormatString = "F3";
            this.gridColumn9.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.gridColumn9.FieldName = "TotalIncidencia";
            this.gridColumn9.Name = "gridColumn9";
            this.gridColumn9.OptionsColumn.AllowEdit = false;
            this.gridColumn9.OptionsColumn.ShowInExpressionEditor = false;
            this.gridColumn9.Visible = true;
            this.gridColumn9.VisibleIndex = 5;
            this.gridColumn9.Width = 93;
            // 
            // gridColumn10
            // 
            this.gridColumn10.Caption = "Taxa %";
            this.gridColumn10.FieldName = "Taxa";
            this.gridColumn10.Name = "gridColumn10";
            this.gridColumn10.OptionsColumn.AllowEdit = false;
            this.gridColumn10.OptionsColumn.ShowInExpressionEditor = false;
            this.gridColumn10.Visible = true;
            this.gridColumn10.VisibleIndex = 6;
            // 
            // gridColumn12
            // 
            this.gridColumn12.Caption = "Imposto";
            this.gridColumn12.DisplayFormat.FormatString = "F3";
            this.gridColumn12.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.gridColumn12.FieldName = "TotalTaxa";
            this.gridColumn12.Name = "gridColumn12";
            this.gridColumn12.OptionsColumn.AllowEdit = false;
            this.gridColumn12.OptionsColumn.ShowInExpressionEditor = false;
            this.gridColumn12.Visible = true;
            this.gridColumn12.VisibleIndex = 7;
            this.gridColumn12.Width = 69;
            // 
            // gridColumn11
            // 
            this.gridColumn11.Caption = "Total";
            this.gridColumn11.DisplayFormat.FormatString = "F3";
            this.gridColumn11.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.gridColumn11.FieldName = "Total";
            this.gridColumn11.Name = "gridColumn11";
            this.gridColumn11.OptionsColumn.AllowEdit = false;
            this.gridColumn11.OptionsColumn.ShowInExpressionEditor = false;
            this.gridColumn11.Visible = true;
            this.gridColumn11.VisibleIndex = 8;
            this.gridColumn11.Width = 96;
            // 
            // panelControl1
            // 
            this.panelControl1.Appearance.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panelControl1.Appearance.Options.UseBackColor = true;
            this.panelControl1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.panelControl1.Controls.Add(this.panel1);
            this.panelControl1.Controls.Add(this.panel4);
            this.panelControl1.Controls.Add(this.panel2);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelControl1.Location = new System.Drawing.Point(0, 0);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(1008, 596);
            this.panelControl1.TabIndex = 1;
            this.panelControl1.Paint += new System.Windows.Forms.PaintEventHandler(this.panelControl1_Paint);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.btnRemoveProduct);
            this.panel1.Controls.Add(this.btnAddProduct);
            this.panel1.Controls.Add(this.gdvControlProducts);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 80);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1008, 375);
            this.panel1.TabIndex = 3;
            // 
            // btnRemoveProduct
            // 
            this.btnRemoveProduct.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnRemoveProduct.Location = new System.Drawing.Point(88, 346);
            this.btnRemoveProduct.Name = "btnRemoveProduct";
            this.btnRemoveProduct.Size = new System.Drawing.Size(67, 23);
            this.btnRemoveProduct.TabIndex = 1;
            this.btnRemoveProduct.Text = "Remover";
            this.btnRemoveProduct.Click += new System.EventHandler(this.btnRemoveProduct_Click);
            // 
            // btnAddProduct
            // 
            this.btnAddProduct.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnAddProduct.Location = new System.Drawing.Point(9, 346);
            this.btnAddProduct.Name = "btnAddProduct";
            this.btnAddProduct.Size = new System.Drawing.Size(67, 23);
            this.btnAddProduct.TabIndex = 1;
            this.btnAddProduct.Text = "Add";
            this.btnAddProduct.Click += new System.EventHandler(this.btnAddProduct_Click);
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.Transparent;
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel4.Controls.Add(this.cbInvoiceName);
            this.panel4.Controls.Add(this.cmbInvoiceType);
            this.panel4.Controls.Add(this.label10);
            this.panel4.Controls.Add(this.cmbArmazemDestino);
            this.panel4.Controls.Add(this.lblStDestino);
            this.panel4.Controls.Add(this.cmbSerie);
            this.panel4.Controls.Add(this.label1);
            this.panel4.Controls.Add(this.dtDataEtntrada);
            this.panel4.Controls.Add(this.cmbArmazem);
            this.panel4.Controls.Add(this.label3);
            this.panel4.Controls.Add(this.label2);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1008, 80);
            this.panel4.TabIndex = 2;
            // 
            // cbInvoiceName
            // 
            this.cbInvoiceName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.Simple;
            this.cbInvoiceName.DropDownWidth = 254;
            this.cbInvoiceName.Enabled = false;
            this.cbInvoiceName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.cbInvoiceName.ForeColor = System.Drawing.Color.Black;
            this.cbInvoiceName.FormattingEnabled = true;
            this.cbInvoiceName.IntegralHeight = false;
            this.cbInvoiceName.Location = new System.Drawing.Point(162, 50);
            this.cbInvoiceName.Name = "cbInvoiceName";
            this.cbInvoiceName.Size = new System.Drawing.Size(239, 23);
            this.cbInvoiceName.TabIndex = 33;
            // 
            // cmbInvoiceType
            // 
            this.cmbInvoiceType.Enabled = false;
            this.cmbInvoiceType.Location = new System.Drawing.Point(53, 49);
            this.cmbInvoiceType.Name = "cmbInvoiceType";
            this.cmbInvoiceType.Properties.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.cmbInvoiceType.Properties.Appearance.Options.UseFont = true;
            this.cmbInvoiceType.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cmbInvoiceType.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.cmbInvoiceType.Size = new System.Drawing.Size(101, 22);
            this.cmbInvoiceType.TabIndex = 31;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label10.ForeColor = System.Drawing.Color.Black;
            this.label10.Location = new System.Drawing.Point(17, 54);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(36, 17);
            this.label10.TabIndex = 32;
            this.label10.Text = "Tipo";
            // 
            // cmbArmazemDestino
            // 
            this.cmbArmazemDestino.Location = new System.Drawing.Point(762, 16);
            this.cmbArmazemDestino.Name = "cmbArmazemDestino";
            this.cmbArmazemDestino.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 10F);
            this.cmbArmazemDestino.Properties.Appearance.Options.UseFont = true;
            this.cmbArmazemDestino.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cmbArmazemDestino.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.cmbArmazemDestino.Size = new System.Drawing.Size(130, 22);
            this.cmbArmazemDestino.TabIndex = 27;
            // 
            // lblStDestino
            // 
            this.lblStDestino.AutoSize = true;
            this.lblStDestino.Font = new System.Drawing.Font("Tahoma", 10F);
            this.lblStDestino.Location = new System.Drawing.Point(622, 19);
            this.lblStDestino.Name = "lblStDestino";
            this.lblStDestino.Size = new System.Drawing.Size(134, 17);
            this.lblStDestino.TabIndex = 26;
            this.lblStDestino.Text = "Armazem de Destino";
            // 
            // cmbSerie
            // 
            this.cmbSerie.Location = new System.Drawing.Point(53, 16);
            this.cmbSerie.Name = "cmbSerie";
            this.cmbSerie.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 10F);
            this.cmbSerie.Properties.Appearance.Options.UseFont = true;
            this.cmbSerie.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cmbSerie.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.cmbSerie.Size = new System.Drawing.Size(101, 22);
            this.cmbSerie.TabIndex = 25;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 10F);
            this.label1.Location = new System.Drawing.Point(12, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 17);
            this.label1.TabIndex = 24;
            this.label1.Text = "Serie";
            // 
            // dtDataEtntrada
            // 
            this.dtDataEtntrada.CalendarFont = new System.Drawing.Font("Tahoma", 10F);
            this.dtDataEtntrada.Font = new System.Drawing.Font("Tahoma", 9F);
            this.dtDataEtntrada.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtDataEtntrada.Location = new System.Drawing.Point(271, 16);
            this.dtDataEtntrada.Name = "dtDataEtntrada";
            this.dtDataEtntrada.Size = new System.Drawing.Size(130, 22);
            this.dtDataEtntrada.TabIndex = 23;
            // 
            // cmbArmazem
            // 
            this.cmbArmazem.Location = new System.Drawing.Point(480, 16);
            this.cmbArmazem.Name = "cmbArmazem";
            this.cmbArmazem.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 10F);
            this.cmbArmazem.Properties.Appearance.Options.UseFont = true;
            this.cmbArmazem.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cmbArmazem.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.cmbArmazem.Size = new System.Drawing.Size(130, 22);
            this.cmbArmazem.TabIndex = 22;
            this.cmbArmazem.SelectedIndexChanged += new System.EventHandler(this.cmbArmazem_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 10F);
            this.label3.Location = new System.Drawing.Point(408, 19);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 17);
            this.label3.TabIndex = 21;
            this.label3.Text = "Armazem";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 10F);
            this.label2.Location = new System.Drawing.Point(159, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(108, 17);
            this.label2.TabIndex = 20;
            this.label2.Text = "Data de Entrada";
            // 
            // FrmProductTransition
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1008, 596);
            this.Controls.Add(this.panelControl1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmProductTransition";
            this.Text = "Entrada de Produtos";
            this.Load += new System.EventHandler(this.FrmEntryProduct_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtDesconto.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gdvControlProducts)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridProducts)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cmbInvoiceType.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbArmazemDestino.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbSerie.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbArmazem.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraGrid.GridControl gdvControlProducts;
        private DevExpress.XtraGrid.Views.Grid.GridView gridProducts;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private Bunifu.Framework.UI.BunifuThinButton2 btnSave;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Label lblImposto;
        private System.Windows.Forms.Label lblIncid;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel4;
        private DevExpress.XtraEditors.ComboBoxEdit cmbArmazemDestino;
        private System.Windows.Forms.Label lblStDestino;
        private DevExpress.XtraEditors.ComboBoxEdit cmbSerie;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dtDataEtntrada;
        private DevExpress.XtraEditors.ComboBoxEdit cmbArmazem;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private DevExpress.XtraEditors.SimpleButton btnRemoveProduct;
        private DevExpress.XtraEditors.SimpleButton btnAddProduct;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn2;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn3;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn4;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn5;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn6;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn7;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn8;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn9;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn10;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn11;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn12;
        private DevExpress.XtraEditors.TextEdit txtDesconto;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblTotDesconto;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.RichTextBox txtDescricao;
        private System.Windows.Forms.Label label6;
        private DevExpress.XtraEditors.ComboBoxEdit cmbInvoiceType;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox cbInvoiceName;
    }
}