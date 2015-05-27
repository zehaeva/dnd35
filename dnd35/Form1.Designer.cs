namespace dnd35
{
    partial class Form1
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.buttonClose = new System.Windows.Forms.Button();
            this.buttonRoll = new System.Windows.Forms.Button();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.classesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.featsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.racesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.menuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonClose
            // 
            this.buttonClose.Location = new System.Drawing.Point(513, 73);
            this.buttonClose.Name = "buttonClose";
            this.buttonClose.Size = new System.Drawing.Size(75, 23);
            this.buttonClose.TabIndex = 0;
            this.buttonClose.Text = "Close";
            this.buttonClose.UseVisualStyleBackColor = true;
            this.buttonClose.MouseClick += new System.Windows.Forms.MouseEventHandler(this.buttonClose_MouseClick);
            // 
            // buttonRoll
            // 
            this.buttonRoll.Location = new System.Drawing.Point(644, 58);
            this.buttonRoll.Name = "buttonRoll";
            this.buttonRoll.Size = new System.Drawing.Size(75, 23);
            this.buttonRoll.TabIndex = 1;
            this.buttonRoll.Text = "Roll";
            this.buttonRoll.UseVisualStyleBackColor = true;
            this.buttonRoll.Click += new System.EventHandler(this.buttonRoll_Click);
            // 
            // chart1
            // 
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(483, 111);
            this.chart1.Name = "chart1";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chart1.Series.Add(series1);
            this.chart1.Size = new System.Drawing.Size(298, 125);
            this.chart1.TabIndex = 2;
            this.chart1.Text = "chart1";
            // 
            // menuStrip
            // 
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.classesToolStripMenuItem,
            this.featsToolStripMenuItem,
            this.racesToolStripMenuItem});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(818, 24);
            this.menuStrip.TabIndex = 3;
            this.menuStrip.Text = "menuStrip1";
            // 
            // classesToolStripMenuItem
            // 
            this.classesToolStripMenuItem.Name = "classesToolStripMenuItem";
            this.classesToolStripMenuItem.Size = new System.Drawing.Size(57, 20);
            this.classesToolStripMenuItem.Text = "Classes";
            // 
            // featsToolStripMenuItem
            // 
            this.featsToolStripMenuItem.Name = "featsToolStripMenuItem";
            this.featsToolStripMenuItem.Size = new System.Drawing.Size(46, 20);
            this.featsToolStripMenuItem.Text = "Feats";
            // 
            // racesToolStripMenuItem
            // 
            this.racesToolStripMenuItem.Name = "racesToolStripMenuItem";
            this.racesToolStripMenuItem.Size = new System.Drawing.Size(49, 20);
            this.racesToolStripMenuItem.Text = "Races";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(818, 606);
            this.Controls.Add(this.chart1);
            this.Controls.Add(this.buttonRoll);
            this.Controls.Add(this.buttonClose);
            this.Controls.Add(this.menuStrip);
            this.MainMenuStrip = this.menuStrip;
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonClose;
        private System.Windows.Forms.Button buttonRoll;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem classesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem featsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem racesToolStripMenuItem;
    }
}

