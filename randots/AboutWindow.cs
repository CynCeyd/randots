using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace randots
{
    public partial class AboutWindow : Form
    {
        public AboutWindow()
        {
            InitializeComponent();
        }

        private void picLogo_Paint(object sender, PaintEventArgs e)
        {
            // Linie zeichnen
            e.Graphics.DrawLine(Pens.DarkGray, new Point(0, picLogo.Height - 1), new Point(picLogo.Width, picLogo.Height - 1));
        }
    }
}
