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
                try
                {
                    int.Parse(uusiLukuTB.Text);
                    if (uusiLukuTB.Text == "-999") //tällöin listataan luvut
                    {
                        vastausLB.Text = "";
                        int[] arr = jono.ToArray();
                        Array.Sort(arr);
                        foreach (var i in arr)
                        {
                            vastausLB.Text += i + " "; //lisätään välilyönnit
                        }
                        vastausLB.ForeColor = System.Drawing.Color.DarkSlateBlue;
                        vastausLB.Visible = true;
                        ohje2LB.Visible = true;
                    }
                    else
                    {
                        vastausLB.Text = "";
                        vastausLB.Visible = false;
                        jono.Add(int.Parse(uusiLukuTB.Text));
                        uusiLukuTB.Text = "";
                    }
                }
                catch
                {
                    vastausLB.Text = "Virhe!";
                    vastausLB.Visible = true;
                    vastausLB.ForeColor = Color.Red;
                }
            }
            if (e.KeyChar == (char)Keys.Escape)
            {
                uusiLukuTB.Text = "";
            }
        }
    }
}

