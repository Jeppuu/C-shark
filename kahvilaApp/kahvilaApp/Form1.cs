using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace kahvilaApp
{
    public partial class KavilaAppForm : Form
    {
        public KavilaAppForm()
        {
            InitializeComponent();
        }

        private void KavilaAppForm_Load(object sender, EventArgs e)
        {
            PanelAbout.Visible = true;  //kun formi latautuu näytetään tietoa meistä paneeli
        }

        private void AboutBtn_Click(object sender, EventArgs e)
        {
            PanelAbout.Visible = true;  //näytetään tietoa meistä paneeli
            PanelBasket.Visible = false;
            PanelDrinks.Visible = false;
            PanelFood.Visible = false;
            PanelSweets.Visible = false;
            PointerPanel.Location = new Point(9,58);
        }

        private void FoodBtn_Click(object sender, EventArgs e)
        {
            PanelAbout.Visible = false;
            PanelBasket.Visible = false;
            PanelDrinks.Visible = false;
            PanelFood.Visible = true;   //näytetään ruoat paneeli
            PanelSweets.Visible = false;
            PointerPanel.Location = new Point(9, 99);
        }

        private void DrinkBtn_Click(object sender, EventArgs e)
        {
            PanelAbout.Visible = false;
            PanelBasket.Visible = false;
            PanelDrinks.Visible = true; //näytetään juomat paneeli
            PanelFood.Visible = false;
            PanelSweets.Visible = false;
            PointerPanel.Location = new Point(9, 140);
        }

        private void SweetsBtn_Click(object sender, EventArgs e)
        {
            PanelAbout.Visible = false;
            PanelBasket.Visible = false;
            PanelDrinks.Visible = false;
            PanelFood.Visible = false;
            PanelSweets.Visible = true; //näytetään herkut paneeli
            PointerPanel.Location = new Point(9, 181);
        }

        private void basketBtn_Click(object sender, EventArgs e)
        {
            PanelAbout.Visible = false;
            PanelBasket.Visible = true; //näytetään ostoskori paneeli
            PanelDrinks.Visible = false;
            PanelFood.Visible = false;
            PanelSweets.Visible = false;
            PointerPanel.Location = new Point(9, 222);
        }

        private void CloseBtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
