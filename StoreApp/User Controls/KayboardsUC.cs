using System;
using System.Windows.Forms;

namespace StoreApp
{
    public partial class KayboardsUC : UserControl
    {
        public KayboardsUC()
        {
            InitializeComponent();
        }

        private void keyboardBuy1_Click(object sender, EventArgs e)
        {
            Global.Buy(keyboardName1.Text,int.Parse(keyboardPrice1.Text));
        }

        private void keyboardBuy2_Click(object sender, EventArgs e)
        {
            Global.Buy(keyboardName2.Text,int.Parse(keyboardPrice2.Text));
        }

        private void keyboardBuy3_Click(object sender, EventArgs e)
        {
            Global.Buy(keyboardName3.Text, int.Parse(lblkeyboardPrice3.Text));
        }
    }
}
