using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace randots
{
    public partial class SplashScreenWindow : Form
    {
        public SplashScreenWindow()
        {
            InitializeComponent();
        }

        private void SplashScreenWindow_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.DrawRectangle(Pens.DarkGray, new Rectangle(0, 0, this.Width - 1, this.Height - 1));
        }

        private void SplashScreenWindow_Load(object sender, EventArgs e)
        {

        }

        private void SplashScreenWindow_Shown(object sender, EventArgs e)
        {
            tmrSplashScreenCounter.Start();
        }

        private void tmrSplashScreenCounter_Tick(object sender, EventArgs e)
        {
            new MainWindow().Show();
            this.Close();
        }
    }
}
