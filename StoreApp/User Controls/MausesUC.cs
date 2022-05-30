using System;
using System.Windows.Forms;

namespace StoreApp
{
    public partial class MausesUC : UserControl
    {
        public MausesUC()
        {
            InitializeComponent();
        }

        private void mauseBuy1_Click(object sender, EventArgs e)
        {
            Global.Buy(mauseName1.Text, int.Parse(mausePrice1.Text));
        }

        private void meuseBuy2_Click(object sender, EventArgs e)
        {
            Global.Buy(mauseName2.Text, int.Parse(mausePrice2.Text));
        }

        private void mauseBuy3_Click(object sender, EventArgs e)
        {
            Global.Buy(mauseName3.Text, int.Parse(mausePrice3.Text));
        }
    }
}
