
namespace CSC_212_Final
{
    partial class frmMain
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.grpDisplay = new System.Windows.Forms.GroupBox();
            this.txtTime = new System.Windows.Forms.TextBox();
            this.txtOut = new System.Windows.Forms.TextBox();
            this.chtMain = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.lblSortName = new System.Windows.Forms.Label();
            this.grpSetup = new System.Windows.Forms.GroupBox();
            this.btnClear = new System.Windows.Forms.Button();
            this.chkVisual = new System.Windows.Forms.CheckBox();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.radReverse = new System.Windows.Forms.RadioButton();
            this.radSorted = new System.Windows.Forms.RadioButton();
            this.radRandom = new System.Windows.Forms.RadioButton();
            this.txtArray = new System.Windows.Forms.TextBox();
            this.btnGenArray = new System.Windows.Forms.Button();
            this.grpSort = new System.Windows.Forms.GroupBox();
            this.radShell = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.radQuick = new System.Windows.Forms.RadioButton();
            this.btnSort = new System.Windows.Forms.Button();
            this.radMerge = new System.Windows.Forms.RadioButton();
            this.radInsertion = new System.Windows.Forms.RadioButton();
            this.label3 = new System.Windows.Forms.Label();
            this.txtMin = new System.Windows.Forms.NumericUpDown();
            this.txtMax = new System.Windows.Forms.NumericUpDown();
            this.txtArraySize = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.grpDisplay.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chtMain)).BeginInit();
            this.grpSetup.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.grpSort.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtMin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMax)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtArraySize)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpDisplay
            // 
            this.grpDisplay.Controls.Add(this.txtTime);
            this.grpDisplay.Controls.Add(this.txtOut);
            this.grpDisplay.Controls.Add(this.chtMain);
            this.grpDisplay.Controls.Add(this.lblSortName);
            this.grpDisplay.Location = new System.Drawing.Point(55, 27);
            this.grpDisplay.Name = "grpDisplay";
            this.grpDisplay.Size = new System.Drawing.Size(684, 591);
            this.grpDisplay.TabIndex = 5;
            this.grpDisplay.TabStop = false;
            // 
            // txtTime
            // 
            this.txtTime.Location = new System.Drawing.Point(6, 59);
            this.txtTime.Name = "txtTime";
            this.txtTime.Size = new System.Drawing.Size(672, 27);
            this.txtTime.TabIndex = 14;
            // 
            // txtOut
            // 
            this.txtOut.Location = new System.Drawing.Point(6, 483);
            this.txtOut.Multiline = true;
            this.txtOut.Name = "txtOut";
            this.txtOut.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtOut.Size = new System.Drawing.Size(672, 81);
            this.txtOut.TabIndex = 5;
            // 
            // chtMain
            // 
            chartArea1.Name = "ChartArea1";
            this.chtMain.ChartAreas.Add(chartArea1);
            this.chtMain.Location = new System.Drawing.Point(6, 88);
            this.chtMain.Name = "chtMain";
            series1.ChartArea = "ChartArea1";
            series1.Name = "Series1";
            this.chtMain.Series.Add(series1);
            this.chtMain.Size = new System.Drawing.Size(672, 389);
            this.chtMain.TabIndex = 3;
            // 
            // lblSortName
            // 
            this.lblSortName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblSortName.AutoSize = true;
            this.lblSortName.Location = new System.Drawing.Point(325, 32);
            this.lblSortName.Name = "lblSortName";
            this.lblSortName.Size = new System.Drawing.Size(37, 20);
            this.lblSortName.TabIndex = 4;
            this.lblSortName.Text = "Text";
            this.lblSortName.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // grpSetup
            // 
            this.grpSetup.Controls.Add(this.btnClear);
            this.grpSetup.Controls.Add(this.chkVisual);
            this.grpSetup.Controls.Add(this.chart1);
            this.grpSetup.Controls.Add(this.radReverse);
            this.grpSetup.Controls.Add(this.radSorted);
            this.grpSetup.Controls.Add(this.radRandom);
            this.grpSetup.Controls.Add(this.txtArray);
            this.grpSetup.Controls.Add(this.btnGenArray);
            this.grpSetup.Controls.Add(this.grpSort);
            this.grpSetup.Controls.Add(this.label3);
            this.grpSetup.Controls.Add(this.txtMin);
            this.grpSetup.Controls.Add(this.txtMax);
            this.grpSetup.Controls.Add(this.txtArraySize);
            this.grpSetup.Controls.Add(this.label5);
            this.grpSetup.Controls.Add(this.label4);
            this.grpSetup.Controls.Add(this.label1);
            this.grpSetup.Location = new System.Drawing.Point(13, 33);
            this.grpSetup.Name = "grpSetup";
            this.grpSetup.Size = new System.Drawing.Size(772, 597);
            this.grpSetup.TabIndex = 8;
            this.grpSetup.TabStop = false;
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(156, 174);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(139, 34);
            this.btnClear.TabIndex = 7;
            this.btnClear.Text = "Clear Form";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // chkVisual
            // 
            this.chkVisual.AutoSize = true;
            this.chkVisual.Checked = true;
            this.chkVisual.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkVisual.Location = new System.Drawing.Point(317, 180);
            this.chkVisual.Name = "chkVisual";
            this.chkVisual.Size = new System.Drawing.Size(97, 24);
            this.chkVisual.TabIndex = 8;
            this.chkVisual.Text = "Visualizer";
            this.chkVisual.UseVisualStyleBackColor = true;
            // 
            // chart1
            // 
            chartArea2.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea2);
            this.chart1.Location = new System.Drawing.Point(11, 221);
            this.chart1.Name = "chart1";
            series2.ChartArea = "ChartArea1";
            series2.Name = "Series1";
            this.chart1.Series.Add(series2);
            this.chart1.Size = new System.Drawing.Size(741, 227);
            this.chart1.TabIndex = 16;
            this.chart1.Text = "chart1";
            // 
            // radReverse
            // 
            this.radReverse.AutoSize = true;
            this.radReverse.Location = new System.Drawing.Point(317, 140);
            this.radReverse.Name = "radReverse";
            this.radReverse.Size = new System.Drawing.Size(92, 24);
            this.radReverse.TabIndex = 5;
            this.radReverse.TabStop = true;
            this.radReverse.Text = "Reversed";
            this.radReverse.UseVisualStyleBackColor = true;
            // 
            // radSorted
            // 
            this.radSorted.AutoSize = true;
            this.radSorted.Location = new System.Drawing.Point(317, 108);
            this.radSorted.Name = "radSorted";
            this.radSorted.Size = new System.Drawing.Size(75, 24);
            this.radSorted.TabIndex = 4;
            this.radSorted.TabStop = true;
            this.radSorted.Text = "Sorted";
            this.radSorted.UseVisualStyleBackColor = true;
            // 
            // radRandom
            // 
            this.radRandom.AutoSize = true;
            this.radRandom.Location = new System.Drawing.Point(317, 72);
            this.radRandom.Name = "radRandom";
            this.radRandom.Size = new System.Drawing.Size(87, 24);
            this.radRandom.TabIndex = 3;
            this.radRandom.TabStop = true;
            this.radRandom.Text = "Random";
            this.radRandom.UseVisualStyleBackColor = true;
            // 
            // txtArray
            // 
            this.txtArray.Location = new System.Drawing.Point(430, 63);
            this.txtArray.Multiline = true;
            this.txtArray.Name = "txtArray";
            this.txtArray.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtArray.Size = new System.Drawing.Size(322, 152);
            this.txtArray.TabIndex = 12;
            // 
            // btnGenArray
            // 
            this.btnGenArray.Location = new System.Drawing.Point(11, 174);
            this.btnGenArray.Name = "btnGenArray";
            this.btnGenArray.Size = new System.Drawing.Size(139, 35);
            this.btnGenArray.TabIndex = 6;
            this.btnGenArray.Text = "Generate Array";
            this.btnGenArray.UseVisualStyleBackColor = true;
            this.btnGenArray.Click += new System.EventHandler(this.btnGenArray_Click);
            // 
            // grpSort
            // 
            this.grpSort.Controls.Add(this.radShell);
            this.grpSort.Controls.Add(this.label2);
            this.grpSort.Controls.Add(this.radQuick);
            this.grpSort.Controls.Add(this.btnSort);
            this.grpSort.Controls.Add(this.radMerge);
            this.grpSort.Controls.Add(this.radInsertion);
            this.grpSort.Location = new System.Drawing.Point(11, 452);
            this.grpSort.Name = "grpSort";
            this.grpSort.Size = new System.Drawing.Size(741, 133);
            this.grpSort.TabIndex = 9;
            this.grpSort.TabStop = false;
            // 
            // radShell
            // 
            this.radShell.AutoSize = true;
            this.radShell.Location = new System.Drawing.Point(213, 55);
            this.radShell.Name = "radShell";
            this.radShell.Size = new System.Drawing.Size(63, 24);
            this.radShell.TabIndex = 11;
            this.radShell.TabStop = true;
            this.radShell.Text = "Shell";
            this.radShell.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(313, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Select Sort:";
            // 
            // radQuick
            // 
            this.radQuick.AutoSize = true;
            this.radQuick.Location = new System.Drawing.Point(618, 55);
            this.radQuick.Name = "radQuick";
            this.radQuick.Size = new System.Drawing.Size(69, 24);
            this.radQuick.TabIndex = 13;
            this.radQuick.TabStop = true;
            this.radQuick.Text = "Quick";
            this.radQuick.UseVisualStyleBackColor = true;
            // 
            // btnSort
            // 
            this.btnSort.Location = new System.Drawing.Point(292, 99);
            this.btnSort.Name = "btnSort";
            this.btnSort.Size = new System.Drawing.Size(128, 28);
            this.btnSort.TabIndex = 14;
            this.btnSort.Text = "Sort!";
            this.btnSort.UseVisualStyleBackColor = true;
            this.btnSort.Click += new System.EventHandler(this.btnSort_Click_1);
            // 
            // radMerge
            // 
            this.radMerge.AutoSize = true;
            this.radMerge.Location = new System.Drawing.Point(419, 55);
            this.radMerge.Name = "radMerge";
            this.radMerge.Size = new System.Drawing.Size(75, 24);
            this.radMerge.TabIndex = 12;
            this.radMerge.TabStop = true;
            this.radMerge.Text = "Merge";
            this.radMerge.UseVisualStyleBackColor = true;
            // 
            // radInsertion
            // 
            this.radInsertion.AutoSize = true;
            this.radInsertion.Location = new System.Drawing.Point(15, 55);
            this.radInsertion.Name = "radInsertion";
            this.radInsertion.Size = new System.Drawing.Size(90, 24);
            this.radInsertion.TabIndex = 10;
            this.radInsertion.TabStop = true;
            this.radInsertion.Text = "Insertion";
            this.radInsertion.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(269, 26);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(202, 20);
            this.label3.TabIndex = 8;
            this.label3.Text = "Sorting Algorithm Visualizer";
            // 
            // txtMin
            // 
            this.txtMin.Location = new System.Drawing.Point(234, 137);
            this.txtMin.Maximum = new decimal(new int[] {
            99,
            0,
            0,
            0});
            this.txtMin.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.txtMin.Name = "txtMin";
            this.txtMin.Size = new System.Drawing.Size(71, 27);
            this.txtMin.TabIndex = 2;
            this.txtMin.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // txtMax
            // 
            this.txtMax.Location = new System.Drawing.Point(234, 105);
            this.txtMax.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.txtMax.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.txtMax.Name = "txtMax";
            this.txtMax.Size = new System.Drawing.Size(71, 27);
            this.txtMax.TabIndex = 1;
            this.txtMax.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // txtArraySize
            // 
            this.txtArraySize.Location = new System.Drawing.Point(234, 76);
            this.txtArraySize.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.txtArraySize.Minimum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.txtArraySize.Name = "txtArraySize";
            this.txtArraySize.Size = new System.Drawing.Size(71, 27);
            this.txtArraySize.TabIndex = 0;
            this.txtArraySize.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(7, 137);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(194, 20);
            this.label5.TabIndex = 0;
            this.label5.Text = "Enter Min Value (at least 1):";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(7, 105);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(221, 20);
            this.label4.TabIndex = 0;
            this.label4.Text = "Enter Max Value (up to 10,000):";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 76);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(192, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Enter Array Size (5-10,000):";
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(797, 30);
            this.menuStrip1.TabIndex = 6;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem,
            this.exitToolStripMenuItem1});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(46, 26);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(123, 26);
            this.exitToolStripMenuItem.Text = "Back";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem1
            // 
            this.exitToolStripMenuItem1.Name = "exitToolStripMenuItem1";
            this.exitToolStripMenuItem1.Size = new System.Drawing.Size(123, 26);
            this.exitToolStripMenuItem1.Text = "Exit";
            this.exitToolStripMenuItem1.Click += new System.EventHandler(this.exitToolStripMenuItem1_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(797, 642);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.grpSetup);
            this.Controls.Add(this.grpDisplay);
            this.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmMain";
            this.Text = "Sort Vizualizer";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.grpDisplay.ResumeLayout(false);
            this.grpDisplay.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chtMain)).EndInit();
            this.grpSetup.ResumeLayout(false);
            this.grpSetup.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.grpSort.ResumeLayout(false);
            this.grpSort.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtMin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMax)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtArraySize)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.GroupBox grpDisplay;
        private System.Windows.Forms.TextBox txtOut;
        private System.Windows.Forms.Label lblSortName;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem1;
        private System.Windows.Forms.GroupBox grpSetup;
        private System.Windows.Forms.TextBox txtArray;
        private System.Windows.Forms.Button btnGenArray;
        private System.Windows.Forms.GroupBox grpSort;
        private System.Windows.Forms.RadioButton radShell;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RadioButton radQuick;
        private System.Windows.Forms.Button btnSort;
        private System.Windows.Forms.RadioButton radMerge;
        private System.Windows.Forms.RadioButton radInsertion;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown txtMin;
        private System.Windows.Forms.NumericUpDown txtMax;
        private System.Windows.Forms.NumericUpDown txtArraySize;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Timer timer;
        public System.Windows.Forms.DataVisualization.Charting.Chart chtMain;
        private System.Windows.Forms.TextBox txtTime;
        private System.Windows.Forms.RadioButton radReverse;
        private System.Windows.Forms.RadioButton radSorted;
        private System.Windows.Forms.RadioButton radRandom;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.CheckBox chkVisual;
        private System.Windows.Forms.Button btnClear;
    }
}

