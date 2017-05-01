using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace randots.Core
{
    /// <summary>
    /// Stellt das Raster für die Zufallsverteilung als Objekt dar
    /// </summary>
    public class Grid
    {
        #region Variablen
        /// <summary>
        /// Zweidimensionales Array zum Zuweisen der Treffer je nach Zeile (x) bzw. Spalte (y)
        /// </summary>
        protected int[,] _allocatedProbabilities;

        /// <summary>
        /// Zuweisung der Wahrscheinlichkeit bei Zeile n
        /// </summary>
        protected Dictionary<int, int> _allocatedRowProbabilities;

        /// <summary>
        /// Zuweisung der Wahrscheinlichkeit bei Spalte n
        /// </summary>
        protected Dictionary<int, int> _allocatedColProbabilities;

        /// <summary>
        /// Zufallsgenerator
        /// </summary>
        protected Random _random;

        /// <summary>
        /// Liste der Wahrscheinlichkeiten (Urne mit n-fachen Zeilenzuordnungen)
        /// </summary>
        protected Dictionary<int, int> _rowRange;

        /// <summary>
        /// Liste der Wahrscheinlichkeiten (Urne mit n-fachen Spaltenzuordnungen)
        /// </summary>
        protected Dictionary<int, int> _colRange;

        /// <summary>
        /// Globaler Zeilenzähler
        /// </summary>
        protected int _rowIterator = 0;

        /// <summary>
        /// Globaler Spaltenzähler
        /// </summary>
        protected int _colIterator = 0;

        /// <summary>
        /// Bereits gerenderte Passes
        /// </summary>
        protected int _finishedPasses;

        /// <summary>
        /// Zyklen pro Schritt
        /// </summary>
        protected int _step;

        /// <summary>
        /// Timer für Diashow
        /// </summary>
        protected System.Windows.Forms.Timer timer;


        #endregion

        #region Properties
        /// <summary>
        /// Intervall bei der Diashow
        /// </summary>
        public int Interval
        {
            get; set;
        }

        /// <summary>
        /// Zyklen
        /// </summary>
        public int Passes
        {
            get; set;
        }

        #endregion

        #region Logik

        /// <summary>
        /// Instanzieren des Rasters
        /// </summary>
        /// <param name="rows">Anzahl der Zeilen</param>
        /// <param name="cols">Anzahl der Spalten</param>
        public Grid(int rows, int cols)
        {
            _allocatedProbabilities = new int[rows, cols];

            _allocatedRowProbabilities = new Dictionary<int, int>();
            _allocatedColProbabilities = new Dictionary<int, int>();

            _rowRange = new Dictionary<int, int>();
            _colRange = new Dictionary<int, int>();

            _random = new Random();

        }



        /// <summary>
        /// Erzeugen der Liste in Abhängigkeit der Wahrscheinlichkeit für Zeilen bzw. Spalten
        /// </summary>
        public void GenerateRange()
        {
            // Alle Zeilen geben lassen
            var rowList = _allocatedRowProbabilities.Keys.ToList();

            // Absteigend sortieren
            rowList.Sort();

            // Jede Zeile durchlaufen
            foreach (var row in rowList)
            {
                if (!_allocatedRowProbabilities.ContainsKey(row)) continue;

                // Jede Zeile n-Mal in die Range hinzufügen
                for (int iterator = 0; iterator < _allocatedRowProbabilities[row]; iterator++)
                {
                    _rowRange.Add(_rowIterator, row);

                    _rowIterator++;
                }

            }

            // Alle Spalten geben lassen
            var colList = _allocatedColProbabilities.Keys.ToList();

            // Absteigend sortieren
            colList.Sort();

            // Jede Spalte durchlaufen
            foreach (var col in colList)
            {
                if (!_allocatedColProbabilities.ContainsKey(col)) continue;

                // Jede Spalte n-Mal in die Range hinzufügen
                for (int iterator = 0; iterator < _allocatedColProbabilities[col]; iterator++)
                {
                    _colRange.Add(_colIterator, col);

                    _colIterator++;
                }

            }



        }

        /// <summary>
        /// Berechnen der Wahrscheinlichkeit für eine einzelne Zelle
        /// </summary>
        protected async Task CalculateProbability(bool fire = true)
        {
            int rowRangeNo = _random.Next(0, _rowRange.Count);
            int colRangeNo = _random.Next(0, _colRange.Count);

            int row = _rowRange[rowRangeNo];
            int col = _colRange[colRangeNo];

            _allocatedProbabilities[row, col]++;

            if (fire) ProbabilityCalculated(this, new ProbabilityCalculatedEventArgs() { Row = row, Col = col });
        }

        /// <summary>
        /// Grid zurückgeben lassen
        /// </summary>
        /// <returns>Zweidimensionales Array mit den Hits</returns>
        public int[,] GetGrid()
        {
            return _allocatedProbabilities;
        }

        /// <summary>
        /// GridSize zurückgeben lassen
        /// </summary>
        /// <returns>Size</returns>
        public Size GetGridSize()
        {
            return new Size(_allocatedRowProbabilities.Count, _allocatedColProbabilities.Count);
        }

        /// <summary>
        /// Liefert die kombinierten Hits in einer Zelle
        /// </summary>
        /// <param name="row">Zeile</param>
        /// <param name="col">Spalte</param>
        /// <returns>int</returns>
        public int GetCombinedHits(int row, int col)
        {
            return _allocatedProbabilities[row, col]; //_allocatedRowProbabilities[row] + _allocatedColProbabilities[col];
        }

        /// <summary>
        /// Einer Zeile eine Wahrscheinlichkeit zuweisen
        /// </summary>
        /// <param name="row">Zeile</param>
        /// <param name="probability">Wahrscheinlichkeit</param>
        public void AllocateRowProbabilities(int row, int probability)
        {
            _allocatedRowProbabilities.Add(row, probability);
        }

        /// <summary>
        /// Einer Spalte eine Wahrscheinlichkeit zuweisen
        /// </summary>
        /// <param name="col">Spalte</param>
        /// <param name="probability">Wahrscheinlichkeit</param>
        public void AllocateColProbabilities(int col, int probability)
        {
            _allocatedColProbabilities.Add(col, probability);
        }

        #endregion

        #region ProbabilityCalculatedAsync

        /// <summary>
        /// EventArgs für die Wahrscheinlichkeitsberechnung eines Durchlaufs
        /// </summary>
        public class ProbabilityCalculatedEventArgs : EventArgs
        {
            public int Row { get; set; }
            public int Col { get; set; }
        }

        /// <summary>
        /// Delegat für ProbabilityCalculatedEvent
        /// </summary>
        /// <param name="sender">Sender</param>
        /// <param name="e">Parameter für Zyklus</param>
        public delegate void ProbabilityCalculatedEventHandler(object sender, ProbabilityCalculatedEventArgs e);

        /// <summary>
        /// Event ProbabilityCalculatedEvent
        /// </summary>
        public event ProbabilityCalculatedEventHandler ProbabilityCalculated;

        #endregion

        #region ExecuteFunktionen
        /// <summary>
        /// Berechnen der Wahrscheinlichkeit für Raster
        /// </summary>
        /// <param name="passes">Anzahl der Durchläufe</param>
        /// <returns>Raster</returns>
        public async Task<int[,]> Execute()
        {
            for (int iterator = 0; iterator < Passes; iterator++)
            {
                await CalculateProbability(false);
            }

            return this._allocatedProbabilities;
        }

        /// <summary>
        /// Wahrscheinlichkeit im Schritt step berechnen
        /// </summary>
        /// <param name="step">Zyklen pro Schritt</param>
        /// <returns>int[,]</returns>
        public async Task<int[,]> ExecuteStep(int step)
        {
           

            for (int iterator = 0; iterator < step; iterator++)
            {
                await CalculateProbability(false);

                _finishedPasses++;
            }

            return this._allocatedProbabilities;
        }

        /// <summary>
        /// Tick-Event für Diashow
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public async void DiashowTick (object sender, EventArgs e)
        {
            if (_finishedPasses >= Passes) timer.Stop();

            await ExecuteStep(_step);

            ProbabilityCalculated(this, new ProbabilityCalculatedEventArgs());
        }

        /// <summary>
        /// Diashow ausführen im Schritt step
        /// </summary>
        /// <param name="step">Zyklen pro Schritt</param>
        /// <returns>void</returns>
        public async Task ExecuteDiashow(int step)
        {
            _step = step;

            timer = new System.Windows.Forms.Timer();

            timer.Interval = Interval;
            timer.Tick += new EventHandler(DiashowTick);

            timer.Start();
        }

        #endregion

    }
}
