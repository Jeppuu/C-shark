using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lukujenJarjestys
{
    public partial class LukujenJarjestys : Form
    {
        List<int> jono = new List<int>();
        public LukujenJarjestys()
        {
            InitializeComponent();
        }

        private void uusiLukuTB_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(e.KeyChar == (char)Keys.Enter) //kun painetaan enteriä
            {
                if(uusiLukuTB.Text == "-999") //tällöin listataan luvut
                {
                    vastausLB.Text = "";
                    int [] arr = jono.ToArray();
                    Array.Sort(arr);
                    foreach(var i in arr)
                    {
                        vastausLB.Text += i + " "; //lisätään välilyönnit
                    }
                    vastausLB.Visible = true;
                    ohje2LB.Visible = true;
                }
                else
                {
                    jono.Add(int.Parse(uusiLukuTB.Text));
                    uusiLukuTB.Text = "";
                }
            }
            if (e.KeyChar == (char)Keys.Escape)
            {
                uusiLukuTB.Text = "";
            }
        }
    }
}

