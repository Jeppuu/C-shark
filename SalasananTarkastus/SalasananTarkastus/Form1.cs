using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SalasananTarkastus
{
    public partial class SalasanaForm : Form
    {
        public SalasanaForm()
        {
            InitializeComponent();
        }

        private void salasanaOikeinPanel_Paint(object sender, PaintEventArgs e)
        {
            //tämä tuli tänne vahingossa XD
        }

        private void tarkistaBT_Click(object sender, EventArgs e)
        {
            if (kayttajaTB.Text == "Jyri" && salasanaTB.Text == "Ja@kk0Ku1ta")
            {
                SalasanaPanel.Visible = false;
                salasanaOikeinPanel.Visible = true;

            } else
            {
                virheLB.Text = "Väärät kirjautumistiedot!";
                virheLB.Visible = true;
            }
        }
    }
}
