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
           
            string vastaus = "";
            int luku;
            try
            {
                
                vastausLB.Text = "";
                vastausLB.ForeColor = Color.DimGray;
                vastausLB.Visible = false;
                luku = Int32.Parse(numeroTB.Text); //otetaan text boxin numero muuttujaan
                vastaus = ToRoman(luku);    //ajetaan metodi joka kääntää luvun
            }
            catch
            {
                vastausLB.Text = "Virhe! Syötä kokonaisluku.";  //tämä näy? mutta ainakaan ohjelma ei kaadu XD
                vastausLB.Visible = true;
                vastausLB.ForeColor = Color.Red;
            }

            vastausLB.Text = vastaus;
            vastausLB.Visible = true;   //näytetään vastaus aka roomalainen numero
            numeroTB.Text = ""; //tyhjentää textboxin käännöksen jälkeen
        }
        private static string ToRoman(int number)
        {
            if ((number < 0) || (number > 3999)) throw new ArgumentOutOfRangeException("Syötä luku 1-3999.");
            if (number < 1) return string.Empty;
            if (number >= 1000) return "M" + ToRoman(number - 1000);    // lasketaan luku ylhäältä alaspäin
            if (number >= 900) return "CM" + ToRoman(number - 900);     // ja miinustetaan, kunnes
            if (number >= 500) return "D" + ToRoman(number - 500);      // oikea luku on selvillä ja käännetty
            if (number >= 400) return "CD" + ToRoman(number - 400);
            if (number >= 100) return "C" + ToRoman(number - 100);
            if (number >= 90) return "XC" + ToRoman(number - 90);
            if (number >= 50) return "L" + ToRoman(number - 50);
            if (number >= 40) return "XL" + ToRoman(number - 40);
            if (number >= 10) return "X" + ToRoman(number - 10);
            if (number >= 9) return "IX" + ToRoman(number - 9);
            if (number >= 5) return "V" + ToRoman(number - 5);
            if (number >= 4) return "IV" + ToRoman(number - 4);
            if (number >= 1) return "I" + ToRoman(number - 1);
            throw new ArgumentOutOfRangeException("virhe!");
        }
    }
}
