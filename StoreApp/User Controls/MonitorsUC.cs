using System;
using System.Windows.Forms;

namespace StoreApp
{
    public partial class MonitorsUC : UserControl
    {
        public MonitorsUC()
        {
            InitializeComponent();
        }
        //monitor 1
        private void bnt_buy_Click(object sender, EventArgs e)
        {
            Global.Buy(lbl_name.Text,int.Parse(lbl_price.Text));
        }

        private void monitorBuy2_Click(object sender, EventArgs e)
        {
            Global.Buy(monitorName2.Text, int.Parse(monitorPrice2.Text));
        }

        private void monitorBuy3_Click(object sender, EventArgs e)
        {
            Global.Buy(monitorName3.Text, int.Parse(monitorPrice3.Text));
        }
    }
}
