using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace roomalaisetNumerot
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void kaannaBT_Click(object sender, EventArgs e)
        {
            try
            {
                vastausLB.Text = "";
                vastausLB.ForeColor = Color.Peru;
                vastausLB.Visible = false;
                Int32.Parse(numeroTB.Text);
            }
            catch {
                vastausLB.Text = "Virhe! Syötä kokonaisluku.";
                vastausLB.Visible = true;
                vastausLB.ForeColor = Color.Red; 
            }
            

        }
    }
}
