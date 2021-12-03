
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.grpDisplay = new System.Windows.Forms.GroupBox();
            this.btnEnd = new System.Windows.Forms.Button();
            this.txtOut = new System.Windows.Forms.TextBox();
            this.chtMain = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.lblSortName = new System.Windows.Forms.Label();
            this.grpSetup = new System.Windows.Forms.GroupBox();
            this.txtArray = new System.Windows.Forms.TextBox();
            this.btnGenArray = new System.Windows.Forms.Button();
            this.grpSortSelect = new System.Windows.Forms.GroupBox();
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
            this.grpSortSelect.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtMin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMax)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtArraySize)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpDisplay
            // 
            this.grpDisplay.Controls.Add(this.btnEnd);
            this.grpDisplay.Controls.Add(this.txtOut);
            this.grpDisplay.Controls.Add(this.chtMain);
            this.grpDisplay.Controls.Add(this.lblSortName);
            this.grpDisplay.Location = new System.Drawing.Point(0, 27);
            this.grpDisplay.Name = "grpDisplay";
            this.grpDisplay.Size = new System.Drawing.Size(466, 592);
            this.grpDisplay.TabIndex = 5;
            this.grpDisplay.TabStop = false;
            // 
            // btnEnd
            // 
            this.btnEnd.Location = new System.Drawing.Point(184, 438);
            this.btnEnd.Name = "btnEnd";
            this.btnEnd.Size = new System.Drawing.Size(84, 29);
            this.btnEnd.TabIndex = 6;
            this.btnEnd.Text = "End";
            this.btnEnd.UseVisualStyleBackColor = true;
            // 
            // txtOut
            // 
            this.txtOut.Location = new System.Drawing.Point(6, 331);
            this.txtOut.Multiline = true;
            this.txtOut.Name = "txtOut";
            this.txtOut.Size = new System.Drawing.Size(448, 81);
            this.txtOut.TabIndex = 5;
            // 
            // chtMain
            // 
            chartArea2.Name = "ChartArea1";
            this.chtMain.ChartAreas.Add(chartArea2);
            this.chtMain.Location = new System.Drawing.Point(6, 23);
            this.chtMain.Name = "chtMain";
            series2.ChartArea = "ChartArea1";
            series2.Name = "Series1";
            this.chtMain.Series.Add(series2);
            this.chtMain.Size = new System.Drawing.Size(448, 301);
            this.chtMain.TabIndex = 3;
            // 
            // lblSortName
            // 
            this.lblSortName.AutoSize = true;
            this.lblSortName.Location = new System.Drawing.Point(333, 23);
            this.lblSortName.Name = "lblSortName";
            this.lblSortName.Size = new System.Drawing.Size(0, 15);
            this.lblSortName.TabIndex = 4;
            this.lblSortName.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // grpSetup
            // 
            this.grpSetup.Controls.Add(this.txtArray);
            this.grpSetup.Controls.Add(this.btnGenArray);
            this.grpSetup.Controls.Add(this.grpSortSelect);
            this.grpSetup.Controls.Add(this.label3);
            this.grpSetup.Controls.Add(this.txtMin);
            this.grpSetup.Controls.Add(this.txtMax);
            this.grpSetup.Controls.Add(this.txtArraySize);
            this.grpSetup.Controls.Add(this.label5);
            this.grpSetup.Controls.Add(this.label4);
            this.grpSetup.Controls.Add(this.label1);
            this.grpSetup.Location = new System.Drawing.Point(32, 33);
            this.grpSetup.Name = "grpSetup";
            this.grpSetup.Size = new System.Drawing.Size(651, 461);
            this.grpSetup.TabIndex = 8;
            this.grpSetup.TabStop = false;
            // 
            // txtArray
            // 
            this.txtArray.Location = new System.Drawing.Point(321, 113);
            this.txtArray.Multiline = true;
            this.txtArray.Name = "txtArray";
            this.txtArray.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtArray.Size = new System.Drawing.Size(302, 161);
            this.txtArray.TabIndex = 12;
            // 
            // btnGenArray
            // 
            this.btnGenArray.Location = new System.Drawing.Point(36, 255);
            this.btnGenArray.Name = "btnGenArray";
            this.btnGenArray.Size = new System.Drawing.Size(168, 35);
            this.btnGenArray.TabIndex = 11;
            this.btnGenArray.Text = "Generate Array";
            this.btnGenArray.UseVisualStyleBackColor = true;
            this.btnGenArray.Click += new System.EventHandler(this.btnGenArray_Click);
            // 
            // grpSortSelect
            // 
            this.grpSortSelect.Controls.Add(this.radShell);
            this.grpSortSelect.Controls.Add(this.label2);
            this.grpSortSelect.Controls.Add(this.radQuick);
            this.grpSortSelect.Controls.Add(this.btnSort);
            this.grpSortSelect.Controls.Add(this.radMerge);
            this.grpSortSelect.Controls.Add(this.radInsertion);
            this.grpSortSelect.Location = new System.Drawing.Point(6, 309);
            this.grpSortSelect.Name = "grpSortSelect";
            this.grpSortSelect.Size = new System.Drawing.Size(635, 137);
            this.grpSortSelect.TabIndex = 10;
            this.grpSortSelect.TabStop = false;
            // 
            // radShell
            // 
            this.radShell.AutoSize = true;
            this.radShell.Location = new System.Drawing.Point(512, 58);
            this.radShell.Name = "radShell";
            this.radShell.Size = new System.Drawing.Size(51, 19);
            this.radShell.TabIndex = 9;
            this.radShell.TabStop = true;
            this.radShell.Text = "Shell";
            this.radShell.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(277, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "Select Sort:";
            // 
            // radQuick
            // 
            this.radQuick.AutoSize = true;
            this.radQuick.Location = new System.Drawing.Point(359, 58);
            this.radQuick.Name = "radQuick";
            this.radQuick.Size = new System.Drawing.Size(56, 19);
            this.radQuick.TabIndex = 9;
            this.radQuick.TabStop = true;
            this.radQuick.Text = "Quick";
            this.radQuick.UseVisualStyleBackColor = true;
            // 
            // btnSort
            // 
            this.btnSort.Location = new System.Drawing.Point(249, 103);
            this.btnSort.Name = "btnSort";
            this.btnSort.Size = new System.Drawing.Size(138, 28);
            this.btnSort.TabIndex = 7;
            this.btnSort.Text = "Sort!";
            this.btnSort.UseVisualStyleBackColor = true;
            this.btnSort.Click += new System.EventHandler(this.btnSort_Click_1);
            // 
            // radMerge
            // 
            this.radMerge.AutoSize = true;
            this.radMerge.Location = new System.Drawing.Point(189, 58);
            this.radMerge.Name = "radMerge";
            this.radMerge.Size = new System.Drawing.Size(59, 19);
            this.radMerge.TabIndex = 9;
            this.radMerge.TabStop = true;
            this.radMerge.Text = "Merge";
            this.radMerge.UseVisualStyleBackColor = true;
            // 
            // radInsertion
            // 
            this.radInsertion.AutoSize = true;
            this.radInsertion.Location = new System.Drawing.Point(13, 58);
            this.radInsertion.Name = "radInsertion";
            this.radInsertion.Size = new System.Drawing.Size(72, 19);
            this.radInsertion.TabIndex = 9;
            this.radInsertion.TabStop = true;
            this.radInsertion.Text = "Insertion";
            this.radInsertion.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(232, 23);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(157, 15);
            this.label3.TabIndex = 8;
            this.label3.Text = "Sorting Algorithm Visualizer";
            // 
            // txtMin
            // 
            this.txtMin.Location = new System.Drawing.Point(226, 209);
            this.txtMin.Maximum = new decimal(new int[] {
            999,
            0,
            0,
            0});
            this.txtMin.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.txtMin.Name = "txtMin";
            this.txtMin.Size = new System.Drawing.Size(71, 23);
            this.txtMin.TabIndex = 1;
            this.txtMin.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // txtMax
            // 
            this.txtMax.Location = new System.Drawing.Point(226, 159);
            this.txtMax.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.txtMax.Name = "txtMax";
            this.txtMax.Size = new System.Drawing.Size(71, 23);
            this.txtMax.TabIndex = 1;
            this.txtMax.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // txtArraySize
            // 
            this.txtArraySize.Location = new System.Drawing.Point(226, 113);
            this.txtArraySize.Minimum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.txtArraySize.Name = "txtArraySize";
            this.txtArraySize.Size = new System.Drawing.Size(71, 23);
            this.txtArraySize.TabIndex = 1;
            this.txtArraySize.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(14, 209);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(146, 15);
            this.label5.TabIndex = 0;
            this.label5.Text = "Enter Min Value (at least 1)";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(15, 161);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(153, 15);
            this.label4.TabIndex = 0;
            this.label4.Text = "Enter Max Value (up to 100)";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 116);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(135, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Enter Array Size (5-100):";
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1058, 24);
            this.menuStrip1.TabIndex = 6;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem,
            this.exitToolStripMenuItem1});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(110, 22);
            this.exitToolStripMenuItem.Text = "Restart";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem1
            // 
            this.exitToolStripMenuItem1.Name = "exitToolStripMenuItem1";
            this.exitToolStripMenuItem1.Size = new System.Drawing.Size(110, 22);
            this.exitToolStripMenuItem1.Text = "Exit";
            this.exitToolStripMenuItem1.Click += new System.EventHandler(this.exitToolStripMenuItem1_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1058, 687);
            this.Controls.Add(this.grpSetup);
            this.Controls.Add(this.menuStrip1);
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
            this.grpSortSelect.ResumeLayout(false);
            this.grpSortSelect.PerformLayout();
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
        private System.Windows.Forms.GroupBox grpSortSelect;
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
        private System.Windows.Forms.Button btnEnd;
        public System.Windows.Forms.DataVisualization.Charting.Chart chtMain;
    }
}

