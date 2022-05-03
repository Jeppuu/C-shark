using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudyPoint
{
    public partial class StudyPointForm : Form
    {
        public StudyPointForm()
        {
            InitializeComponent();
        }

        private void browseBtn_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog
            {
                InitialDirectory = @"C:\",
                Title = "Browse Image Files",

                CheckFileExists = true,
                CheckPathExists = true,

                Filter = "Image Files (*.bmp;*.png;*.jpg)|*.bmp;*.png;*.jpg",
                FilterIndex = 2,
                RestoreDirectory = true,

                ReadOnlyChecked = true,
                ShowReadOnly = true
            };
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                ProfilepicTxb.Text = openFileDialog1.FileName;
            }
        }
    }
}
