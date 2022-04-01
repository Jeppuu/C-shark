using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace nopat
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonHeita_Click(object sender, EventArgs e)
        {
            heitaNoppaa(noppa1);    //pyydetään ohjelmaa heittämään noppia
            heitaNoppaa(noppa2);
        }

        private void heitaNoppaa(PictureBox NoppaBox)
        {
            Random satunnainen = new Random();
            int noppa = satunnainen.Next(1, 7);
            switch(noppa)   //satunnainen numero 1-6 määrittää nopan arvon
            {
                case 1:
                    NoppaBox.Image = Properties.Resources.dice01;
                    break;
                case 2:
                    NoppaBox.Image = Properties.Resources.dice02;
                    break;
                case 3:
                    NoppaBox.Image = Properties.Resources.dice03;
                    break;
                case 4:
                    NoppaBox.Image = Properties.Resources.dice04;
                    break;
                case 5:
                    NoppaBox.Image = Properties.Resources.dice05;
                    break;
                case 6:
                    NoppaBox.Image = Properties.Resources.dice06;
                    break;
            }
        }
    }
}
