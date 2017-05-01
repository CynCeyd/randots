namespace randots
{
    partial class RenderWindow
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RenderWindow));
            this.pnlRenderer = new System.Windows.Forms.Panel();
            this.tsTools = new System.Windows.Forms.ToolStrip();
            this.tsbRenderSingle = new System.Windows.Forms.ToolStripButton();
            this.tsbRenderDiashow = new System.Windows.Forms.ToolStripButton();
            this.txtRenderStep = new System.Windows.Forms.ToolStripTextBox();
            this.tsbRenderAll = new System.Windows.Forms.ToolStripButton();
            this.tslStep = new System.Windows.Forms.ToolStripLabel();
            this.tslInterval = new System.Windows.Forms.ToolStripLabel();
            this.txtInterval = new System.Windows.Forms.ToolStripTextBox();
            this.tssSeperator = new System.Windows.Forms.ToolStripSeparator();
            this.tssSeperator2 = new System.Windows.Forms.ToolStripSeparator();
            this.tssSeperator3 = new System.Windows.Forms.ToolStripSeparator();
            this.epFieldValidator = new System.Windows.Forms.ErrorProvider(this.components);
            this.tsTools.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.epFieldValidator)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlRenderer
            // 
            this.pnlRenderer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlRenderer.Location = new System.Drawing.Point(0, 25);
            this.pnlRenderer.Name = "pnlRenderer";
            this.pnlRenderer.Size = new System.Drawing.Size(724, 503);
            this.pnlRenderer.TabIndex = 0;
            this.pnlRenderer.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlRenderer_Paint);
            // 
            // tsTools
            // 
            this.tsTools.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.tsTools.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbRenderSingle,
            this.tsbRenderDiashow,
            this.tssSeperator3,
            this.tslStep,
            this.txtRenderStep,
            this.tssSeperator,
            this.tslInterval,
            this.txtInterval,
            this.tssSeperator2,
            this.tsbRenderAll});
            this.tsTools.Location = new System.Drawing.Point(0, 0);
            this.tsTools.Name = "tsTools";
            this.tsTools.Padding = new System.Windows.Forms.Padding(10, 0, 1, 0);
            this.tsTools.Size = new System.Drawing.Size(724, 25);
            this.tsTools.TabIndex = 1;
            this.tsTools.Text = "toolStrip1";
            // 
            // tsbRenderSingle
            // 
            this.tsbRenderSingle.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbRenderSingle.Image = ((System.Drawing.Image)(resources.GetObject("tsbRenderSingle.Image")));
            this.tsbRenderSingle.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbRenderSingle.Name = "tsbRenderSingle";
            this.tsbRenderSingle.Size = new System.Drawing.Size(23, 22);
            this.tsbRenderSingle.Text = "Schritt rendern";
            this.tsbRenderSingle.Click += new System.EventHandler(this.tsbRenderSingle_Click);
            // 
            // tsbRenderDiashow
            // 
            this.tsbRenderDiashow.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbRenderDiashow.Image = ((System.Drawing.Image)(resources.GetObject("tsbRenderDiashow.Image")));
            this.tsbRenderDiashow.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbRenderDiashow.Name = "tsbRenderDiashow";
            this.tsbRenderDiashow.Size = new System.Drawing.Size(23, 22);
            this.tsbRenderDiashow.Text = "Nacheinander rendern";
            this.tsbRenderDiashow.Click += new System.EventHandler(this.tsbRenderDiashow_Click);
            // 
            // txtRenderStep
            // 
            this.txtRenderStep.Margin = new System.Windows.Forms.Padding(1, 0, 15, 0);
            this.txtRenderStep.Name = "txtRenderStep";
            this.txtRenderStep.Size = new System.Drawing.Size(100, 25);
            this.txtRenderStep.Text = "1000";
            this.txtRenderStep.ToolTipText = "Zyklen pro Schritt";
            this.txtRenderStep.TextChanged += new System.EventHandler(this.txtRenderStep_TextChanged);
            // 
            // tsbRenderAll
            // 
            this.tsbRenderAll.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbRenderAll.Image = ((System.Drawing.Image)(resources.GetObject("tsbRenderAll.Image")));
            this.tsbRenderAll.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbRenderAll.Name = "tsbRenderAll";
            this.tsbRenderAll.Size = new System.Drawing.Size(23, 22);
            this.tsbRenderAll.Text = "Alle rendern";
            this.tsbRenderAll.Click += new System.EventHandler(this.tsbRenderAll_Click);
            // 
            // tslStep
            // 
            this.tslStep.Name = "tslStep";
            this.tslStep.Size = new System.Drawing.Size(100, 22);
            this.tslStep.Text = "Zyklen pro Schritt";
            // 
            // tslInterval
            // 
            this.tslInterval.Name = "tslInterval";
            this.tslInterval.Size = new System.Drawing.Size(76, 22);
            this.tslInterval.Text = "Intervall (ms)";
            // 
            // txtInterval
            // 
            this.txtInterval.Margin = new System.Windows.Forms.Padding(1, 0, 15, 0);
            this.txtInterval.Name = "txtInterval";
            this.txtInterval.Size = new System.Drawing.Size(100, 25);
            this.txtInterval.Text = "100";
            this.txtInterval.Click += new System.EventHandler(this.txtInterval_Click);
            this.txtInterval.TextChanged += new System.EventHandler(this.txtInterval_TextChanged);
            // 
            // tssSeperator
            // 
            this.tssSeperator.Name = "tssSeperator";
            this.tssSeperator.Size = new System.Drawing.Size(6, 25);
            // 
            // tssSeperator2
            // 
            this.tssSeperator2.Name = "tssSeperator2";
            this.tssSeperator2.Size = new System.Drawing.Size(6, 25);
            // 
            // tssSeperator3
            // 
            this.tssSeperator3.Name = "tssSeperator3";
            this.tssSeperator3.Size = new System.Drawing.Size(6, 25);
            // 
            // epFieldValidator
            // 
            this.epFieldValidator.ContainerControl = this;
            // 
            // RenderWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(724, 528);
            this.Controls.Add(this.pnlRenderer);
            this.Controls.Add(this.tsTools);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "RenderWindow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Rendern - [randots]";
            this.Load += new System.EventHandler(this.RenderWindow_Load);
            this.Shown += new System.EventHandler(this.RenderWindow_Shown);
            this.Resize += new System.EventHandler(this.RenderWindow_Resize);
            this.tsTools.ResumeLayout(false);
            this.tsTools.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.epFieldValidator)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlRenderer;
        private System.Windows.Forms.ToolStrip tsTools;
        private System.Windows.Forms.ToolStripButton tsbRenderSingle;
        private System.Windows.Forms.ToolStripButton tsbRenderDiashow;
        private System.Windows.Forms.ToolStripTextBox txtRenderStep;
        private System.Windows.Forms.ToolStripButton tsbRenderAll;
        private System.Windows.Forms.ToolStripSeparator tssSeperator3;
        private System.Windows.Forms.ToolStripLabel tslStep;
        private System.Windows.Forms.ToolStripSeparator tssSeperator;
        private System.Windows.Forms.ToolStripLabel tslInterval;
        private System.Windows.Forms.ToolStripTextBox txtInterval;
        private System.Windows.Forms.ToolStripSeparator tssSeperator2;
        private System.Windows.Forms.ErrorProvider epFieldValidator;
    }
}