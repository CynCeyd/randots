using randots.Core;
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
    public partial class MainWindow : Form
    {
        public MainWindow()
        {
            InitializeComponent();

            ResizeGrid();
        }

        #region WinForms

        /// <summary>
        /// AboutWindow anzeigen
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void überToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (var aboutWindow = new AboutWindow())
            {
                aboutWindow.ShowDialog();
            }
        }

        /// <summary>
        /// CurrentItem auf Default setzen
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MainWindow_Load(object sender, EventArgs e)
        {
            _currentItem = new Item() { Iterator = 0, Type = Item.ItemType.Row };
        }

        /// <summary>
        /// Bei FormClosed Anwendung beenden
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MainWindow_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        #endregion

        #region Variablen

        /// <summary>
        /// Aktuelle Zeile oder Spalte
        /// </summary>
        protected Item _currentItem;

        /// <summary>
        /// Zyklen
        /// </summary>
        protected int _passes;

        /// <summary>
        /// Zeilen
        /// </summary>
        protected int _rows = 1;

        /// <summary>
        /// Spalten
        /// </summary>
        protected int _cols = 1;

        /// <summary>
        /// Wahrscheinlichkeit pro Zeile
        /// </summary>
        protected Dictionary<int, int> _rowProbability = new Dictionary<int, int>();

        /// <summary>
        /// Wahrscheinlichkeit pro Spalte
        /// </summary>
        protected Dictionary<int, int> _colProbability = new Dictionary<int, int>();

        /// <summary>
        /// Invertierte Darstellung
        /// </summary>
        protected bool _invertedMode;

        // 255 / 30 (maximale Wahrscheinlichkeit)
        /// <summary>
        /// Faktor für den Preview zur Darstellung der Graustufe
        /// </summary>
        protected const int _probabilityColorFactor = 9;

        #endregion

        #region Logik

        /// <summary>
        /// Werte abrufen und Panel neu zeichnen
        /// </summary>
        private void RenderPreview()
        {
            _rows = Convert.ToInt32(numRows.Value);
            _cols = Convert.ToInt32(numCols.Value);

            _passes = Convert.ToInt32(numPasses.Value);
            _invertedMode = cbxInvertedMode.Checked;

            pnlGridPreview.Refresh();
        }

        /// <summary>
        /// Preview zeichnen
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void pnlGridPreview_Paint(object sender, PaintEventArgs e)
        {   
            try
            {
                int rowCellWidth = Convert.ToInt32(Math.Round((decimal)pnlGridPreview.Height / _rows));
                int colCellWidth = Convert.ToInt32(Math.Round((decimal)pnlGridPreview.Width / _cols));

                for (int col = 0; col < _cols; col++)
                {
                    for (int row = 0; row < _rows; row++)
                    {
                        int greyScale = _rowProbability[row] + _colProbability[col];

                        greyScale *= _probabilityColorFactor;

                        greyScale = 255 - greyScale;

                        if (greyScale < 0) greyScale = 0;

                        Color color = Color.FromArgb(greyScale, greyScale, greyScale);

                        e.Graphics.FillRectangle(new SolidBrush(color), new Rectangle(col * colCellWidth, row * rowCellWidth , colCellWidth, rowCellWidth));
                    }
                }

                Color overlayColor = Color.FromArgb(60, Color.Purple);

                switch (_currentItem.Type)
                {
                    case Item.ItemType.Col:
                        e.Graphics.FillRectangle(new SolidBrush(overlayColor), new Rectangle(colCellWidth*_currentItem.Iterator, 0, colCellWidth, pnlGridPreview.Height));
                        break;

                    case Item.ItemType.Row:

                        e.Graphics.FillRectangle(new SolidBrush(overlayColor), new Rectangle(0, rowCellWidth * _currentItem.Iterator, pnlGridPreview.Width, rowCellWidth));
                        break;
                }

            }catch(Exception ex)
            {
                // Wenn hier angekommen, vermutlich Fehler, weil noch nicht initialisiert.
                MessageBox.Show(ex.Message);
            }
           
        }

        /// <summary>
        /// Dient zur Festlegung von aktueller Zeile bzw. Spalte
        /// </summary>
        public class Item
        {
            public int Iterator { get; set; }
            public ItemType Type { get; set; }

            public enum ItemType
            {
                Row,
                Col
            }
        }

        #endregion


        /// <summary>
        /// Wahrscheinlichkeit für aktuelle Zeile oder Spalte festlegen
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void numProbability_ValueChanged(object sender, EventArgs e)
        {
            if(_currentItem.Type == Item.ItemType.Row)
            {
                _rowProbability[_currentItem.Iterator] = Convert.ToInt32(numProbability.Value);
            }else
            {
                _colProbability[_currentItem.Iterator] = Convert.ToInt32(numProbability.Value);
            }

            RenderPreview();
        }

        /// <summary>
        /// Wahrscheinlichkeitslisten neu initialisieren bei Veränderung der Größe des Grids
        /// </summary>
        private void ResizeGrid()
        {
            _rowProbability.Clear();

            for (int iterator = 0; iterator < numRows.Value; iterator++)
            {
                _rowProbability.Add(iterator, 1);
            }

            _colProbability.Clear();

            for (int iterator = 0; iterator < numCols.Value; iterator++)
            {
                _colProbability.Add(iterator, 1);
            }

            RenderPreview();

            _currentItem = new Item() { Iterator = 0, Type = Item.ItemType.Row };

            numProbability.Value = 1;
        }

        private void numRows_ValueChanged(object sender, EventArgs e)
        {
            ResizeGrid();
        }

        private void numCols_ValueChanged(object sender, EventArgs e)
        {
            ResizeGrid();
        }

        private void MainWindow_KeyUp(object sender, KeyEventArgs e)
        {
            int row;
            int col;

            switch (e.KeyCode)
            {
                case Keys.Up:

                    row = ((_currentItem.Iterator == 0) ? 0 : _currentItem.Iterator - 1);

                    _currentItem = new Item() { Iterator = row, Type = Item.ItemType.Row };

                    numProbability.Value = _rowProbability[_currentItem.Iterator];

                    lblCurrentItem.Text = string.Format("Zeile: {0}", _currentItem.Iterator+1);

                    break;

                case Keys.Down:

                    row = ((_currentItem.Iterator < _rows-1) ? _currentItem.Iterator + 1 : _rows-1);

                    _currentItem = new Item() { Iterator = row, Type = Item.ItemType.Row };

                    numProbability.Value = _rowProbability[_currentItem.Iterator];
                    lblCurrentItem.Text = string.Format("Zeile: {0}", _currentItem.Iterator+1);

                    break;

                case Keys.Left:

                    col = ((_currentItem.Iterator == 0) ? 0 : _currentItem.Iterator - 1);

                    _currentItem = new Item() { Iterator = col, Type = Item.ItemType.Col };

                    numProbability.Value = _colProbability[_currentItem.Iterator];
                    lblCurrentItem.Text = string.Format("Spalte: {0}", _currentItem.Iterator+1);

                    break;

                    
                case Keys.Right:

                    col = ((_currentItem.Iterator < _cols-1) ? _currentItem.Iterator + 1 : _cols-1);

                    _currentItem = new Item() { Iterator = col, Type = Item.ItemType.Col };

                    numProbability.Value = _colProbability[_currentItem.Iterator];
                    lblCurrentItem.Text = string.Format("Spalte: {0}", _currentItem.Iterator+1);
                    break;
            }

            RenderPreview();
        }

        private void btnRender_Click(object sender, EventArgs e)
        {
            Grid grid = new Grid(_rows, _cols);

            foreach(var row in _rowProbability.Keys)
            {
                grid.AllocateRowProbabilities(row, _rowProbability[row]);
            }
            
            foreach(var col in _colProbability.Keys)
            {
                grid.AllocateColProbabilities(col, _colProbability[col]);
            }

            new RenderWindow(grid, _passes, _invertedMode).ShowDialog();
        }

        private void cbxInvertedMode_CheckedChanged(object sender, EventArgs e)
        {
            RenderPreview();
        }

        private void numPasses_ValueChanged(object sender, EventArgs e)
        {
            RenderPreview();
        }

        protected bool _collapsed;
        protected int _panel2Width;

        private void cbxPreview_CheckedChanged(object sender, EventArgs e)
        {
            pnlGridPreview.Visible =  cbxPreview.Checked;
         
            if (cbxPreview.Checked)
            {
                if (_collapsed)
                {
                    this.Width += _panel2Width;
                    _collapsed = false;
                }
            }else
            {
                _panel2Width = scLayout.Panel2.Width;

                this.Width -= scLayout.Panel2.Width;
                _collapsed = true;
            }

            scLayout.Panel2Collapsed = !cbxPreview.Checked;

        }
    }
}
