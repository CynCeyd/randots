using randots.Core;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static randots.Core.Grid;

namespace randots
{
    public partial class RenderWindow : Form
    {
        public RenderWindow()
        {
            InitializeComponent();
        }

        protected Grid _grid;
        protected int _passes;
        protected bool _inverted;

        public RenderWindow(Grid grid, int passes, bool inverted = false)
        {
            _grid = grid;
            _passes = passes;
            _inverted = inverted;

            InitializeComponent();

            typeof(Panel).InvokeMember("DoubleBuffered",
  BindingFlags.SetProperty | BindingFlags.Instance | BindingFlags.NonPublic,
  null, pnlRenderer, new object[] { true });
        }



        private void RenderWindow_Load(object sender, EventArgs e)
        {
            _grid.ProbabilityCalculated += new ProbabilityCalculatedEventHandler(Grid_ProbabilityCalculated);

            Size gridSize = _grid.GetGridSize();

            this.DoubleBuffered = true;

            _gridBuffer = new int[gridSize.Width, gridSize.Height];

            _step = Convert.ToInt32(Math.Ceiling((decimal)_passes / 10));

            txtRenderStep.Text = _step.ToString();

            
        }


        protected int[,] _gridBuffer;

        private void Grid_ProbabilityCalculated(object sender, ProbabilityCalculatedEventArgs e)
        {
            // _gridBuffer[e.Row, e.Col]++;
            _gridBuffer = _grid.GetGrid();

            pnlRenderer.Refresh();

        }

        protected const int _probabilityColorFactor = 9;

        private void pnlRenderer_Paint(object sender, PaintEventArgs e)
        {
            if (_inverted)
            {
                e.Graphics.Clear(Color.Black);
            }else
            {
                e.Graphics.Clear(Color.White);
            }

            Size gridSize = _grid.GetGridSize();

            try
            {
                int rowCellWidth = Convert.ToInt32(Math.Round((decimal)pnlRenderer.Height / (decimal)gridSize.Width));
                int colCellWidth = Convert.ToInt32(Math.Round((decimal)pnlRenderer.Width / (decimal)gridSize.Height));

                for (int col = 0; col < gridSize.Height; col++)
                {
                    for (int row = 0; row < gridSize.Width; row++)
                    {
                        int greyScale = _gridBuffer[row, col]; //_grid.GetCombinedHits(row, col);

                        greyScale *= _probabilityColorFactor;

                        //greyScale = 255 - greyScale;

                        if (!_inverted)
                        {
                            
                            greyScale = 255 - greyScale;
                        }

                        if (greyScale < 0) greyScale = 0;
                        if (greyScale > 255) greyScale = 255;

                        Color color = Color.FromArgb(greyScale, greyScale, greyScale);

                        e.Graphics.FillRectangle(new SolidBrush(color), new Rectangle(col * colCellWidth, row * rowCellWidth, colCellWidth, rowCellWidth));
                    }
                }


            }
            catch (Exception ex)
            {
                // Wenn hier angekommen, vermutlich Fehler, weil noch nicht initialisiert.
                MessageBox.Show(ex.Message);
            }
        }

        private async void RenderWindow_Shown(object sender, EventArgs e)
        {
            _grid.GenerateRange();
            _grid.Passes = _passes;

           // _gridBuffer = _grid.Execute(_passes);

            pnlRenderer.Refresh();
        }

        private void RenderWindow_Resize(object sender, EventArgs e)
        {
            pnlRenderer.Refresh();
        }

        private async void tsbRenderSingle_Click(object sender, EventArgs e)
        {


            _gridBuffer = await _grid.ExecuteStep(_step); // Convert.ToInt32(txtRenderStep.Text));

            pnlRenderer.Refresh();
        }

        private async void tsbRenderDiashow_Click(object sender, EventArgs e)
        {
            _grid.Interval = _interval;

            await _grid.ExecuteDiashow(_step); // Convert.ToInt32(txtRenderStep.Text));
        }

        private async void tsbRenderAll_Click(object sender, EventArgs e)
        {
            _gridBuffer = await _grid.Execute();

            pnlRenderer.Refresh();
        }

        private void txtInterval_Click(object sender, EventArgs e)
        {

        }

        protected int _interval = 100;

        private void txtInterval_TextChanged(object sender, EventArgs e)
        {
            epFieldValidator.Clear();

            if (!int.TryParse(txtInterval.Text, out _interval))
            {
                epFieldValidator.SetError(txtInterval.Control, "Bitte nur Ganzzahlen eingeben");
            }
        }

        protected int _step;

        private void txtRenderStep_TextChanged(object sender, EventArgs e)
        {
            epFieldValidator.Clear();

            if (!int.TryParse(txtRenderStep.Text, out _step))
            {
                epFieldValidator.SetError(txtRenderStep.Control, "Bitte nur Ganzzahlen eingeben");
            }
        }
    }
}
