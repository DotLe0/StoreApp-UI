using System;
using System.Windows.Forms;

namespace StoreApp
{
    public partial class ShopingCard : UserControl
    {
        public ShopingCard()
        {
            InitializeComponent();
            price.Text = Global.Sum.ToString();
            itemsCount.Text = Global.selectedItems.ToString();
            lstB_items.Items.Clear();
            for (int i = 0; i < Global.stuffs.Count; i++)
            {
                lstB_items.Items.Add(Global.stuffs[i]);
            }
        }

        private void lstB_items_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Don't know how that happend. :^)
        }

        private void bnt_purchase_Click(object sender, EventArgs e)
        {
            //this Method will chech if all nesesery information is writen
            //if not will display error message

            bool fName = false;
            bool sName = false;
            bool cardN = false;
            bool cvv = false;
            bool adres = false;

            if (txt_firstName.Text.Length > 3)
            {
                fName = true;
            }
            if (txt_secondName.Text.Length > 3)
            {
                sName = true;
            }
            if (txt_cardNum.Text.Length >= 16)
            {
                cardN = true;
            }
            if (txt_cvv.Text.Length == 3)
            {
                cvv = true;
            }
            if (txt_adres.Text.Length != 0)
            {
                adres = true;
            }

            if (fName && sName && cardN && cvv && adres)
            {
                MessageBox.Show("Purchase complate.");
            }
            else
            {
                MessageBox.Show("Missing important information!\nPlease enter the missinf information.");
                return;
            }

            Global.Sum = 0;
            Global.selectedItems = 0;
            price.Text = Global.Sum.ToString();
            itemsCount.Text = Global.selectedItems.ToString();
            lstB_items.Items.Clear();
            Global.stuffs.Clear();
        }
    }
}
