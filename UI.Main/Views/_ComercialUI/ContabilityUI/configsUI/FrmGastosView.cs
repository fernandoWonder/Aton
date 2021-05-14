using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Aton.Views._ComercialUI.ContabilityUI.configsUI
{
    public partial class FrmGastosView : Form
    {
        public FrmGastosView()
        {
            InitializeComponent();
            fillData();
        }

        private void bunifuThinButton21_Click(object sender, EventArgs e)
        {
            FrmGastos frmGastos = new FrmGastos();
            frmGastos.ShowDialog();
        }

        public void fillData()
        {

        }

        public void toGridUpdate(int idGasto)
        {

        }
    }
}
