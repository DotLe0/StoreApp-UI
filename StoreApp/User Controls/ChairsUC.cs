using System;
using System.Windows.Forms;

namespace StoreApp
{
    public partial class ChairsUC : UserControl
    {
        public ChairsUC()
        {
            InitializeComponent();
        }

        private void chairBuy1_Click(object sender, EventArgs e)
        {
            Global.Buy(chairName1.Text, int.Parse(chairPrice1.Text));
        }

        private void chairBuy2_Click(object sender, EventArgs e)
        {
            Global.Buy(chairName2.Text, int.Parse(chairPrice2.Text));
        }

        private void chairBuy3_Click(object sender, EventArgs e)
        {
            Global.Buy(chairName3.Text, int.Parse(chairPrice3.Text));
        }
    }
}
