namespace randots
{
    partial class MainWindow
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainWindow));
            this.mspMenu = new System.Windows.Forms.MenuStrip();
            this.dateiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.beendenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.überToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.scLayout = new System.Windows.Forms.SplitContainer();
            this.gbParameters = new System.Windows.Forms.GroupBox();
            this.btnRender = new System.Windows.Forms.Button();
            this.cbxInvertedMode = new System.Windows.Forms.CheckBox();
            this.numProbability = new System.Windows.Forms.NumericUpDown();
            this.lblCurrentItem = new System.Windows.Forms.Label();
            this.lblProbability = new System.Windows.Forms.Label();
            this.lblNavigationTip = new System.Windows.Forms.Label();
            this.numCols = new System.Windows.Forms.NumericUpDown();
            this.lblX = new System.Windows.Forms.Label();
            this.numRows = new System.Windows.Forms.NumericUpDown();
            this.numPasses = new System.Windows.Forms.NumericUpDown();
            this.lblGridSize = new System.Windows.Forms.Label();
            this.lblPasses = new System.Windows.Forms.Label();
            this.pnlGridPreview = new System.Windows.Forms.Panel();
            this.cbxPreview = new System.Windows.Forms.CheckBox();
            this.mspMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.scLayout)).BeginInit();
            this.scLayout.Panel1.SuspendLayout();
            this.scLayout.Panel2.SuspendLayout();
            this.scLayout.SuspendLayout();
            this.gbParameters.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numProbability)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numCols)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numRows)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numPasses)).BeginInit();
            this.SuspendLayout();
            // 
            // mspMenu
            // 
            this.mspMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dateiToolStripMenuItem,
            this.überToolStripMenuItem});
            this.mspMenu.Location = new System.Drawing.Point(0, 0);
            this.mspMenu.Name = "mspMenu";
            this.mspMenu.Size = new System.Drawing.Size(730, 24);
            this.mspMenu.TabIndex = 1;
            this.mspMenu.Text = "menuStrip1";
            // 
            // dateiToolStripMenuItem
            // 
            this.dateiToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.beendenToolStripMenuItem});
            this.dateiToolStripMenuItem.Name = "dateiToolStripMenuItem";
            this.dateiToolStripMenuItem.Size = new System.Drawing.Size(46, 20);
            this.dateiToolStripMenuItem.Text = "&Datei";
            // 
            // beendenToolStripMenuItem
            // 
            this.beendenToolStripMenuItem.Name = "beendenToolStripMenuItem";
            this.beendenToolStripMenuItem.Size = new System.Drawing.Size(120, 22);
            this.beendenToolStripMenuItem.Text = "Beenden";
            // 
            // überToolStripMenuItem
            // 
            this.überToolStripMenuItem.Name = "überToolStripMenuItem";
            this.überToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.überToolStripMenuItem.Text = "&Über";
            this.überToolStripMenuItem.Click += new System.EventHandler(this.überToolStripMenuItem_Click);
            // 
            // scLayout
            // 
            this.scLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.scLayout.Location = new System.Drawing.Point(0, 24);
            this.scLayout.Name = "scLayout";
            // 
            // scLayout.Panel1
            // 
            this.scLayout.Panel1.Controls.Add(this.gbParameters);
            this.scLayout.Panel1.Padding = new System.Windows.Forms.Padding(15);
            // 
            // scLayout.Panel2
            // 
            this.scLayout.Panel2.Controls.Add(this.pnlGridPreview);
            this.scLayout.Panel2.Padding = new System.Windows.Forms.Padding(15);
            this.scLayout.Size = new System.Drawing.Size(730, 469);
            this.scLayout.SplitterDistance = 207;
            this.scLayout.TabIndex = 2;
            // 
            // gbParameters
            // 
            this.gbParameters.Controls.Add(this.cbxPreview);
            this.gbParameters.Controls.Add(this.btnRender);
            this.gbParameters.Controls.Add(this.cbxInvertedMode);
            this.gbParameters.Controls.Add(this.numProbability);
            this.gbParameters.Controls.Add(this.lblCurrentItem);
            this.gbParameters.Controls.Add(this.lblProbability);
            this.gbParameters.Controls.Add(this.lblNavigationTip);
            this.gbParameters.Controls.Add(this.numCols);
            this.gbParameters.Controls.Add(this.lblX);
            this.gbParameters.Controls.Add(this.numRows);
            this.gbParameters.Controls.Add(this.numPasses);
            this.gbParameters.Controls.Add(this.lblGridSize);
            this.gbParameters.Controls.Add(this.lblPasses);
            this.gbParameters.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gbParameters.Location = new System.Drawing.Point(15, 15);
            this.gbParameters.Margin = new System.Windows.Forms.Padding(15);
            this.gbParameters.Name = "gbParameters";
            this.gbParameters.Padding = new System.Windows.Forms.Padding(15);
            this.gbParameters.Size = new System.Drawing.Size(177, 439);
            this.gbParameters.TabIndex = 3;
            this.gbParameters.TabStop = false;
            this.gbParameters.Text = "Einstellungen";
            // 
            // btnRender
            // 
            this.btnRender.Location = new System.Drawing.Point(21, 241);
            this.btnRender.Name = "btnRender";
            this.btnRender.Size = new System.Drawing.Size(120, 23);
            this.btnRender.TabIndex = 12;
            this.btnRender.Text = "Rendern";
            this.btnRender.UseVisualStyleBackColor = true;
            this.btnRender.Click += new System.EventHandler(this.btnRender_Click);
            // 
            // cbxInvertedMode
            // 
            this.cbxInvertedMode.AutoSize = true;
            this.cbxInvertedMode.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.cbxInvertedMode.Location = new System.Drawing.Point(21, 200);
            this.cbxInvertedMode.Name = "cbxInvertedMode";
            this.cbxInvertedMode.Size = new System.Drawing.Size(129, 17);
            this.cbxInvertedMode.TabIndex = 3;
            this.cbxInvertedMode.Text = "Invertierte Darstellung";
            this.cbxInvertedMode.UseVisualStyleBackColor = true;
            this.cbxInvertedMode.CheckedChanged += new System.EventHandler(this.cbxInvertedMode_CheckedChanged);
            // 
            // numProbability
            // 
            this.numProbability.InterceptArrowKeys = false;
            this.numProbability.Location = new System.Drawing.Point(28, 159);
            this.numProbability.Maximum = new decimal(new int[] {
            15,
            0,
            0,
            0});
            this.numProbability.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numProbability.Name = "numProbability";
            this.numProbability.Size = new System.Drawing.Size(114, 20);
            this.numProbability.TabIndex = 11;
            this.numProbability.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numProbability.ValueChanged += new System.EventHandler(this.numProbability_ValueChanged);
            // 
            // lblCurrentItem
            // 
            this.lblCurrentItem.AutoSize = true;
            this.lblCurrentItem.Location = new System.Drawing.Point(25, 143);
            this.lblCurrentItem.Name = "lblCurrentItem";
            this.lblCurrentItem.Size = new System.Drawing.Size(42, 13);
            this.lblCurrentItem.TabIndex = 10;
            this.lblCurrentItem.Text = "Zeile: 1";
            // 
            // lblProbability
            // 
            this.lblProbability.AutoSize = true;
            this.lblProbability.Location = new System.Drawing.Point(18, 121);
            this.lblProbability.Name = "lblProbability";
            this.lblProbability.Size = new System.Drawing.Size(100, 13);
            this.lblProbability.TabIndex = 9;
            this.lblProbability.Text = "Wahrscheinlichkeit:";
            // 
            // lblNavigationTip
            // 
            this.lblNavigationTip.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lblNavigationTip.Location = new System.Drawing.Point(15, 363);
            this.lblNavigationTip.Name = "lblNavigationTip";
            this.lblNavigationTip.Size = new System.Drawing.Size(147, 61);
            this.lblNavigationTip.TabIndex = 0;
            this.lblNavigationTip.Text = "Um zwischen Zeilen bzw. Spalten zu navigieren, benutzen Sie bitte die Pfeiltasten" +
    ".";
            // 
            // numCols
            // 
            this.numCols.InterceptArrowKeys = false;
            this.numCols.Location = new System.Drawing.Point(92, 83);
            this.numCols.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numCols.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numCols.Name = "numCols";
            this.numCols.Size = new System.Drawing.Size(49, 20);
            this.numCols.TabIndex = 8;
            this.numCols.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numCols.ValueChanged += new System.EventHandler(this.numCols_ValueChanged);
            // 
            // lblX
            // 
            this.lblX.AutoSize = true;
            this.lblX.Location = new System.Drawing.Point(76, 85);
            this.lblX.Name = "lblX";
            this.lblX.Size = new System.Drawing.Size(12, 13);
            this.lblX.TabIndex = 7;
            this.lblX.Text = "x";
            // 
            // numRows
            // 
            this.numRows.InterceptArrowKeys = false;
            this.numRows.Location = new System.Drawing.Point(21, 83);
            this.numRows.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numRows.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numRows.Name = "numRows";
            this.numRows.Size = new System.Drawing.Size(49, 20);
            this.numRows.TabIndex = 6;
            this.numRows.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numRows.ValueChanged += new System.EventHandler(this.numRows_ValueChanged);
            // 
            // numPasses
            // 
            this.numPasses.InterceptArrowKeys = false;
            this.numPasses.Location = new System.Drawing.Point(21, 44);
            this.numPasses.Maximum = new decimal(new int[] {
            100000000,
            0,
            0,
            0});
            this.numPasses.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numPasses.Name = "numPasses";
            this.numPasses.Size = new System.Drawing.Size(120, 20);
            this.numPasses.TabIndex = 5;
            this.numPasses.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numPasses.ValueChanged += new System.EventHandler(this.numPasses_ValueChanged);
            // 
            // lblGridSize
            // 
            this.lblGridSize.AutoSize = true;
            this.lblGridSize.Location = new System.Drawing.Point(18, 67);
            this.lblGridSize.Name = "lblGridSize";
            this.lblGridSize.Size = new System.Drawing.Size(124, 13);
            this.lblGridSize.TabIndex = 4;
            this.lblGridSize.Text = "Größe (Zeilen x Spalten):";
            // 
            // lblPasses
            // 
            this.lblPasses.AutoSize = true;
            this.lblPasses.Location = new System.Drawing.Point(18, 28);
            this.lblPasses.Name = "lblPasses";
            this.lblPasses.Size = new System.Drawing.Size(42, 13);
            this.lblPasses.TabIndex = 3;
            this.lblPasses.Text = "Zyklen:";
            // 
            // pnlGridPreview
            // 
            this.pnlGridPreview.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pnlGridPreview.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlGridPreview.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlGridPreview.Location = new System.Drawing.Point(15, 15);
            this.pnlGridPreview.Name = "pnlGridPreview";
            this.pnlGridPreview.Size = new System.Drawing.Size(489, 439);
            this.pnlGridPreview.TabIndex = 3;
            this.pnlGridPreview.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlGridPreview_Paint);
            // 
            // cbxPreview
            // 
            this.cbxPreview.AutoSize = true;
            this.cbxPreview.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.cbxPreview.Checked = true;
            this.cbxPreview.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbxPreview.Location = new System.Drawing.Point(21, 284);
            this.cbxPreview.Name = "cbxPreview";
            this.cbxPreview.Size = new System.Drawing.Size(117, 17);
            this.cbxPreview.TabIndex = 13;
            this.cbxPreview.Text = "Vorschau anzeigen";
            this.cbxPreview.UseVisualStyleBackColor = true;
            this.cbxPreview.CheckedChanged += new System.EventHandler(this.cbxPreview_CheckedChanged);
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(730, 493);
            this.Controls.Add(this.scLayout);
            this.Controls.Add(this.mspMenu);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.MainMenuStrip = this.mspMenu;
            this.Name = "MainWindow";
            this.Text = "randots";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MainWindow_FormClosed);
            this.Load += new System.EventHandler(this.MainWindow_Load);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.MainWindow_KeyUp);
            this.mspMenu.ResumeLayout(false);
            this.mspMenu.PerformLayout();
            this.scLayout.Panel1.ResumeLayout(false);
            this.scLayout.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.scLayout)).EndInit();
            this.scLayout.ResumeLayout(false);
            this.gbParameters.ResumeLayout(false);
            this.gbParameters.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numProbability)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numCols)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numRows)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numPasses)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip mspMenu;
        private System.Windows.Forms.ToolStripMenuItem überToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dateiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem beendenToolStripMenuItem;
        private System.Windows.Forms.SplitContainer scLayout;
        private System.Windows.Forms.GroupBox gbParameters;
        private System.Windows.Forms.Panel pnlGridPreview;
        private System.Windows.Forms.Label lblNavigationTip;
        private System.Windows.Forms.NumericUpDown numCols;
        private System.Windows.Forms.Label lblX;
        private System.Windows.Forms.NumericUpDown numRows;
        private System.Windows.Forms.NumericUpDown numPasses;
        private System.Windows.Forms.Label lblGridSize;
        private System.Windows.Forms.Label lblPasses;
        private System.Windows.Forms.Button btnRender;
        private System.Windows.Forms.CheckBox cbxInvertedMode;
        private System.Windows.Forms.NumericUpDown numProbability;
        private System.Windows.Forms.Label lblCurrentItem;
        private System.Windows.Forms.Label lblProbability;
        private System.Windows.Forms.CheckBox cbxPreview;
    }
}

