using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace Sekuntikello
{
    public partial class StopwatchForm : Form
    {
        private Stopwatch stopWatch;
        public StopwatchForm()
        {
            InitializeComponent();
        }

        private void buttonStart_Click(object sender, EventArgs e)
        {
            stopWatch.Start();
        }

        private void buttonStop_Click(object sender, EventArgs e)
        {
            stopWatch.Stop();
        }

        private void buttonReset_Click(object sender, EventArgs e)
        {
            stopWatch.Reset();
        }

        private void TimerForm_Load(object sender, EventArgs e)
        {
            stopWatch = new Stopwatch();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            labelTimer.Text = String.Format("{0:hh\\:mm\\:ss\\:fff}", stopWatch.Elapsed);
        }

       
    }
}
