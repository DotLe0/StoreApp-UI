using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StoreApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            HomeUC homeUC = new HomeUC();
            addUserControl(homeUC);
        }
        private void addUserControl(UserControl userControl)
        {
            userControl.Dock = DockStyle.Fill;
            controlPanel.Controls.Clear();
            controlPanel.Controls.Add(userControl);
            userControl.BringToFront();
        }
        private void bnt_Card_Click(object sender, EventArgs e)
        {
            ShopingCard card = new ShopingCard();
            addUserControl(card);
        }

        private void bnt_home_Click(object sender, EventArgs e)
        {
            HomeUC homeUC = new HomeUC();
            addUserControl(homeUC);
        }

        private void bnt_monitors_Click(object sender, EventArgs e)
        {
            MonitorsUC monitorsUC = new MonitorsUC();
            addUserControl(monitorsUC);
        }

        private void bnt_keyboards_Click(object sender, EventArgs e)
        {
            KayboardsUC kayboardsUC = new KayboardsUC();
            addUserControl(kayboardsUC);
        }

        private void bnt_mauses_Click(object sender, EventArgs e)
        {
            MausesUC mausesUC = new MausesUC();
            addUserControl(mausesUC);
        }

        private void bnt_chairs_Click(object sender, EventArgs e)
        {
            ChairsUC chairsUC = new ChairsUC();
            addUserControl(chairsUC);
        }
    }
}
