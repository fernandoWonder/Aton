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
using DevExpress.XtraBars.ToastNotifications;

namespace UI.Main.Views
{
    public partial class Frm : DevExpress.XtraEditors.XtraForm
    {
        public Frm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ToastNotification toast = new ToastNotification("9d02cd69-0ae8-42c4-a928-fff10aa90ed5", UI.Main.Properties.Resources.img, "Aton Alerta", textBox1.Text, "", ToastNotificationTemplate.Text01);
            toastNotificationsManager1.ShowNotification(toast);
        }
    }
}