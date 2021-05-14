using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace Aton.Views._ComercialUI.ContabilityUI.configsUI
{
    public partial class FrmGastos : DevExpress.XtraEditors.XtraForm
    {
        public FrmGastos()
        {
            InitializeComponent();
        }
        FrmGastosView frmGastos;
        public FrmGastos(FrmGastosView frmGastos)
        {
            InitializeComponent();
            this.frmGastos = frmGastos;
        }

        private void panelControl1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void bunifuImageButton2_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}