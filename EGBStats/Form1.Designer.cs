namespace EGBStats
{
    partial class F
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend3 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint5 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(0D, 0D);
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint6 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(100D, 100D);
            this.getEGBbtn = new System.Windows.Forms.Button();
            this.egb_mid_fromBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.egb_mid_toBox = new System.Windows.Forms.TextBox();
            this.loadEGB = new System.Windows.Forms.Button();
            this.drawEGB = new System.Windows.Forms.Button();
            this.egbBox = new System.Windows.Forms.GroupBox();
            this.EGBautosave = new System.Windows.Forms.CheckBox();
            this.EGBautodraw = new System.Windows.Forms.CheckBox();
            this.EGBlabel = new System.Windows.Forms.Label();
            this.saveEGB = new System.Windows.Forms.Button();
            this.csglBox = new System.Windows.Forms.GroupBox();
            this.CSGLlabel = new System.Windows.Forms.Label();
            this.saveCSGL = new System.Windows.Forms.Button();
            this.csgl_mid_fromBox = new System.Windows.Forms.TextBox();
            this.drawCSGL = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.loadCSGL = new System.Windows.Forms.Button();
            this.csgl_mid_toBox = new System.Windows.Forms.TextBox();
            this.getCSGLbtn = new System.Windows.Forms.Button();
            this.graph = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.cleanGraphBtn = new System.Windows.Forms.Button();
            this.drawDiffBtn = new System.Windows.Forms.Button();
            this.csglminodds = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.csglmaxodds = new System.Windows.Forms.TextBox();
            this.bo1 = new System.Windows.Forms.CheckBox();
            this.bo2 = new System.Windows.Forms.CheckBox();
            this.bo3 = new System.Windows.Forms.CheckBox();
            this.bo5 = new System.Windows.Forms.CheckBox();
            this.maxmatchid = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.minmatchid = new System.Windows.Forms.TextBox();
            this.kellyBtn = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.pairsLabel = new System.Windows.Forms.Label();
            this.kellyMultiplier = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.egbBox.SuspendLayout();
            this.csglBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.graph)).BeginInit();
            this.SuspendLayout();
            // 
            // getEGBbtn
            // 
            this.getEGBbtn.Location = new System.Drawing.Point(9, 72);
            this.getEGBbtn.Name = "getEGBbtn";
            this.getEGBbtn.Size = new System.Drawing.Size(104, 27);
            this.getEGBbtn.TabIndex = 0;
            this.getEGBbtn.Text = "Get stats from API";
            this.getEGBbtn.UseVisualStyleBackColor = true;
            this.getEGBbtn.Click += new System.EventHandler(this.getEGBbtn_Click);
            // 
            // egb_mid_fromBox
            // 
            this.egb_mid_fromBox.Location = new System.Drawing.Point(42, 19);
            this.egb_mid_fromBox.MaxLength = 5;
            this.egb_mid_fromBox.Name = "egb_mid_fromBox";
            this.egb_mid_fromBox.Size = new System.Drawing.Size(71, 20);
            this.egb_mid_fromBox.TabIndex = 1;
            this.egb_mid_fromBox.Text = "20000";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(30, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "From";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(20, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "To";
            // 
            // egb_mid_toBox
            // 
            this.egb_mid_toBox.Location = new System.Drawing.Point(42, 46);
            this.egb_mid_toBox.MaxLength = 5;
            this.egb_mid_toBox.Name = "egb_mid_toBox";
            this.egb_mid_toBox.Size = new System.Drawing.Size(71, 20);
            this.egb_mid_toBox.TabIndex = 4;
            this.egb_mid_toBox.Text = "87000";
            // 
            // loadEGB
            // 
            this.loadEGB.Location = new System.Drawing.Point(128, 19);
            this.loadEGB.Name = "loadEGB";
            this.loadEGB.Size = new System.Drawing.Size(104, 27);
            this.loadEGB.TabIndex = 5;
            this.loadEGB.Text = "Load from file";
            this.loadEGB.UseVisualStyleBackColor = true;
            this.loadEGB.Click += new System.EventHandler(this.loadEGB_Click);
            // 
            // drawEGB
            // 
            this.drawEGB.Enabled = false;
            this.drawEGB.Location = new System.Drawing.Point(10, 130);
            this.drawEGB.Name = "drawEGB";
            this.drawEGB.Size = new System.Drawing.Size(128, 23);
            this.drawEGB.TabIndex = 7;
            this.drawEGB.Text = "Graph: odds accuracy";
            this.drawEGB.UseVisualStyleBackColor = true;
            this.drawEGB.Click += new System.EventHandler(this.drawEGB_Click);
            // 
            // egbBox
            // 
            this.egbBox.Controls.Add(this.EGBautosave);
            this.egbBox.Controls.Add(this.EGBautodraw);
            this.egbBox.Controls.Add(this.EGBlabel);
            this.egbBox.Controls.Add(this.saveEGB);
            this.egbBox.Controls.Add(this.egb_mid_fromBox);
            this.egbBox.Controls.Add(this.drawEGB);
            this.egbBox.Controls.Add(this.label1);
            this.egbBox.Controls.Add(this.label2);
            this.egbBox.Controls.Add(this.loadEGB);
            this.egbBox.Controls.Add(this.egb_mid_toBox);
            this.egbBox.Controls.Add(this.getEGBbtn);
            this.egbBox.Location = new System.Drawing.Point(12, 12);
            this.egbBox.Name = "egbBox";
            this.egbBox.Size = new System.Drawing.Size(241, 163);
            this.egbBox.TabIndex = 8;
            this.egbBox.TabStop = false;
            this.egbBox.Text = "egamingbets.com";
            // 
            // EGBautosave
            // 
            this.EGBautosave.AutoSize = true;
            this.EGBautosave.Location = new System.Drawing.Point(128, 85);
            this.EGBautosave.Name = "EGBautosave";
            this.EGBautosave.Size = new System.Drawing.Size(71, 17);
            this.EGBautosave.TabIndex = 12;
            this.EGBautosave.Text = "Autosave";
            this.EGBautosave.UseVisualStyleBackColor = true;
            // 
            // EGBautodraw
            // 
            this.EGBautodraw.AutoSize = true;
            this.EGBautodraw.Location = new System.Drawing.Point(144, 134);
            this.EGBautodraw.Name = "EGBautodraw";
            this.EGBautodraw.Size = new System.Drawing.Size(74, 17);
            this.EGBautodraw.TabIndex = 11;
            this.EGBautodraw.Text = "Auto draw";
            this.EGBautodraw.UseVisualStyleBackColor = true;
            // 
            // EGBlabel
            // 
            this.EGBlabel.AutoSize = true;
            this.EGBlabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EGBlabel.ForeColor = System.Drawing.Color.Red;
            this.EGBlabel.Location = new System.Drawing.Point(6, 107);
            this.EGBlabel.Name = "EGBlabel";
            this.EGBlabel.Size = new System.Drawing.Size(86, 20);
            this.EGBlabel.TabIndex = 9;
            this.EGBlabel.Text = "Not loaded";
            // 
            // saveEGB
            // 
            this.saveEGB.Enabled = false;
            this.saveEGB.Location = new System.Drawing.Point(128, 52);
            this.saveEGB.Name = "saveEGB";
            this.saveEGB.Size = new System.Drawing.Size(104, 27);
            this.saveEGB.TabIndex = 8;
            this.saveEGB.Text = "Save to file";
            this.saveEGB.UseVisualStyleBackColor = true;
            this.saveEGB.Click += new System.EventHandler(this.saveEGB_Click);
            // 
            // csglBox
            // 
            this.csglBox.Controls.Add(this.CSGLlabel);
            this.csglBox.Controls.Add(this.saveCSGL);
            this.csglBox.Controls.Add(this.csgl_mid_fromBox);
            this.csglBox.Controls.Add(this.drawCSGL);
            this.csglBox.Controls.Add(this.label3);
            this.csglBox.Controls.Add(this.label4);
            this.csglBox.Controls.Add(this.loadCSGL);
            this.csglBox.Controls.Add(this.csgl_mid_toBox);
            this.csglBox.Controls.Add(this.getCSGLbtn);
            this.csglBox.Location = new System.Drawing.Point(259, 12);
            this.csglBox.Name = "csglBox";
            this.csglBox.Size = new System.Drawing.Size(241, 163);
            this.csglBox.TabIndex = 9;
            this.csglBox.TabStop = false;
            this.csglBox.Text = "csgolounge.com";
            // 
            // CSGLlabel
            // 
            this.CSGLlabel.AutoSize = true;
            this.CSGLlabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CSGLlabel.ForeColor = System.Drawing.Color.Red;
            this.CSGLlabel.Location = new System.Drawing.Point(6, 107);
            this.CSGLlabel.Name = "CSGLlabel";
            this.CSGLlabel.Size = new System.Drawing.Size(86, 20);
            this.CSGLlabel.TabIndex = 12;
            this.CSGLlabel.Text = "Not loaded";
            // 
            // saveCSGL
            // 
            this.saveCSGL.Enabled = false;
            this.saveCSGL.Location = new System.Drawing.Point(127, 52);
            this.saveCSGL.Name = "saveCSGL";
            this.saveCSGL.Size = new System.Drawing.Size(104, 27);
            this.saveCSGL.TabIndex = 8;
            this.saveCSGL.Text = "Save to file";
            this.saveCSGL.UseVisualStyleBackColor = true;
            this.saveCSGL.Click += new System.EventHandler(this.saveCSGL_Click);
            // 
            // csgl_mid_fromBox
            // 
            this.csgl_mid_fromBox.Location = new System.Drawing.Point(42, 19);
            this.csgl_mid_fromBox.MaxLength = 5;
            this.csgl_mid_fromBox.Name = "csgl_mid_fromBox";
            this.csgl_mid_fromBox.Size = new System.Drawing.Size(71, 20);
            this.csgl_mid_fromBox.TabIndex = 1;
            this.csgl_mid_fromBox.Text = "500";
            // 
            // drawCSGL
            // 
            this.drawCSGL.CausesValidation = false;
            this.drawCSGL.Enabled = false;
            this.drawCSGL.Location = new System.Drawing.Point(10, 130);
            this.drawCSGL.Name = "drawCSGL";
            this.drawCSGL.Size = new System.Drawing.Size(125, 23);
            this.drawCSGL.TabIndex = 7;
            this.drawCSGL.Text = "Graph: odds accuracy";
            this.drawCSGL.UseVisualStyleBackColor = true;
            this.drawCSGL.Click += new System.EventHandler(this.drawCSGL_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 22);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(30, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "From";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 49);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(20, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "To";
            // 
            // loadCSGL
            // 
            this.loadCSGL.Location = new System.Drawing.Point(127, 19);
            this.loadCSGL.Name = "loadCSGL";
            this.loadCSGL.Size = new System.Drawing.Size(104, 27);
            this.loadCSGL.TabIndex = 5;
            this.loadCSGL.Text = "Load from file";
            this.loadCSGL.UseVisualStyleBackColor = true;
            this.loadCSGL.Click += new System.EventHandler(this.loadCSGL_Click);
            // 
            // csgl_mid_toBox
            // 
            this.csgl_mid_toBox.Location = new System.Drawing.Point(42, 46);
            this.csgl_mid_toBox.MaxLength = 5;
            this.csgl_mid_toBox.Name = "csgl_mid_toBox";
            this.csgl_mid_toBox.Size = new System.Drawing.Size(71, 20);
            this.csgl_mid_toBox.TabIndex = 4;
            this.csgl_mid_toBox.Text = "9999";
            // 
            // getCSGLbtn
            // 
            this.getCSGLbtn.Location = new System.Drawing.Point(9, 72);
            this.getCSGLbtn.Name = "getCSGLbtn";
            this.getCSGLbtn.Size = new System.Drawing.Size(104, 27);
            this.getCSGLbtn.TabIndex = 0;
            this.getCSGLbtn.Text = "Get stats from API";
            this.getCSGLbtn.UseVisualStyleBackColor = true;
            this.getCSGLbtn.Click += new System.EventHandler(this.getCSGLbtn_Click);
            // 
            // graph
            // 
            this.graph.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            chartArea3.AxisX.MajorGrid.Enabled = false;
            chartArea3.AxisX.Maximum = 100D;
            chartArea3.AxisX.Minimum = 0D;
            chartArea3.AxisY.MajorGrid.Enabled = false;
            chartArea3.AxisY.Maximum = 100D;
            chartArea3.AxisY.Minimum = 0D;
            chartArea3.InnerPlotPosition.Auto = false;
            chartArea3.InnerPlotPosition.Height = 90F;
            chartArea3.InnerPlotPosition.Width = 90F;
            chartArea3.InnerPlotPosition.X = 10F;
            chartArea3.InnerPlotPosition.Y = 2.79255F;
            chartArea3.Name = "ChartArea1";
            this.graph.ChartAreas.Add(chartArea3);
            legend3.Name = "Legend1";
            this.graph.Legends.Add(legend3);
            this.graph.Location = new System.Drawing.Point(12, 348);
            this.graph.Name = "graph";
            this.graph.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Bright;
            series3.ChartArea = "ChartArea1";
            series3.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.FastLine;
            series3.Legend = "Legend1";
            series3.Name = "Mid";
            series3.Points.Add(dataPoint5);
            series3.Points.Add(dataPoint6);
            this.graph.Series.Add(series3);
            this.graph.Size = new System.Drawing.Size(488, 348);
            this.graph.TabIndex = 10;
            this.graph.Text = "chart1";
            // 
            // openFileDialog
            // 
            this.openFileDialog.FileName = "openFileDialog";
            // 
            // cleanGraphBtn
            // 
            this.cleanGraphBtn.Location = new System.Drawing.Point(396, 319);
            this.cleanGraphBtn.Name = "cleanGraphBtn";
            this.cleanGraphBtn.Size = new System.Drawing.Size(104, 23);
            this.cleanGraphBtn.TabIndex = 11;
            this.cleanGraphBtn.Text = "Clean the graph";
            this.cleanGraphBtn.UseVisualStyleBackColor = true;
            this.cleanGraphBtn.Click += new System.EventHandler(this.cleanGraphBtn_Click);
            // 
            // drawDiffBtn
            // 
            this.drawDiffBtn.CausesValidation = false;
            this.drawDiffBtn.Cursor = System.Windows.Forms.Cursors.Default;
            this.drawDiffBtn.Enabled = false;
            this.drawDiffBtn.Location = new System.Drawing.Point(12, 262);
            this.drawDiffBtn.Name = "drawDiffBtn";
            this.drawDiffBtn.Size = new System.Drawing.Size(135, 37);
            this.drawDiffBtn.TabIndex = 12;
            this.drawDiffBtn.Text = "Graph: odds difference";
            this.drawDiffBtn.UseVisualStyleBackColor = true;
            this.drawDiffBtn.Click += new System.EventHandler(this.drawDiffBtn_Click);
            // 
            // csglminodds
            // 
            this.csglminodds.Location = new System.Drawing.Point(269, 194);
            this.csglminodds.Name = "csglminodds";
            this.csglminodds.Size = new System.Drawing.Size(77, 20);
            this.csglminodds.TabIndex = 13;
            this.csglminodds.Text = "0.05";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(266, 178);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(50, 13);
            this.label5.TabIndex = 13;
            this.label5.Text = "Min odds";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(266, 217);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(53, 13);
            this.label6.TabIndex = 14;
            this.label6.Text = "Max odds";
            // 
            // csglmaxodds
            // 
            this.csglmaxodds.Location = new System.Drawing.Point(269, 233);
            this.csglmaxodds.Name = "csglmaxodds";
            this.csglmaxodds.Size = new System.Drawing.Size(77, 20);
            this.csglmaxodds.TabIndex = 15;
            this.csglmaxodds.Text = "0.95";
            // 
            // bo1
            // 
            this.bo1.AutoSize = true;
            this.bo1.Checked = true;
            this.bo1.CheckState = System.Windows.Forms.CheckState.Checked;
            this.bo1.Location = new System.Drawing.Point(446, 178);
            this.bo1.Name = "bo1";
            this.bo1.Size = new System.Drawing.Size(47, 17);
            this.bo1.TabIndex = 16;
            this.bo1.Text = "BO1";
            this.bo1.UseVisualStyleBackColor = true;
            // 
            // bo2
            // 
            this.bo2.AutoSize = true;
            this.bo2.Checked = true;
            this.bo2.CheckState = System.Windows.Forms.CheckState.Checked;
            this.bo2.Location = new System.Drawing.Point(446, 198);
            this.bo2.Name = "bo2";
            this.bo2.Size = new System.Drawing.Size(47, 17);
            this.bo2.TabIndex = 17;
            this.bo2.Text = "BO2";
            this.bo2.UseVisualStyleBackColor = true;
            // 
            // bo3
            // 
            this.bo3.AutoSize = true;
            this.bo3.Checked = true;
            this.bo3.CheckState = System.Windows.Forms.CheckState.Checked;
            this.bo3.Location = new System.Drawing.Point(446, 218);
            this.bo3.Name = "bo3";
            this.bo3.Size = new System.Drawing.Size(47, 17);
            this.bo3.TabIndex = 18;
            this.bo3.Text = "BO3";
            this.bo3.UseVisualStyleBackColor = true;
            // 
            // bo5
            // 
            this.bo5.AutoSize = true;
            this.bo5.Checked = true;
            this.bo5.CheckState = System.Windows.Forms.CheckState.Checked;
            this.bo5.Location = new System.Drawing.Point(446, 238);
            this.bo5.Name = "bo5";
            this.bo5.Size = new System.Drawing.Size(47, 17);
            this.bo5.TabIndex = 19;
            this.bo5.Text = "BO5";
            this.bo5.UseVisualStyleBackColor = true;
            // 
            // maxmatchid
            // 
            this.maxmatchid.Location = new System.Drawing.Point(358, 233);
            this.maxmatchid.Name = "maxmatchid";
            this.maxmatchid.Size = new System.Drawing.Size(77, 20);
            this.maxmatchid.TabIndex = 23;
            this.maxmatchid.Text = "5000";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(361, 217);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(70, 13);
            this.label7.TabIndex = 22;
            this.label7.Text = "Max match id";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(361, 178);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(67, 13);
            this.label8.TabIndex = 20;
            this.label8.Text = "Min match id";
            // 
            // minmatchid
            // 
            this.minmatchid.Location = new System.Drawing.Point(358, 194);
            this.minmatchid.Name = "minmatchid";
            this.minmatchid.Size = new System.Drawing.Size(77, 20);
            this.minmatchid.TabIndex = 21;
            this.minmatchid.Text = "2000";
            // 
            // kellyBtn
            // 
            this.kellyBtn.CausesValidation = false;
            this.kellyBtn.Cursor = System.Windows.Forms.Cursors.Default;
            this.kellyBtn.Enabled = false;
            this.kellyBtn.Location = new System.Drawing.Point(12, 305);
            this.kellyBtn.Name = "kellyBtn";
            this.kellyBtn.Size = new System.Drawing.Size(135, 37);
            this.kellyBtn.TabIndex = 28;
            this.kellyBtn.Text = "Graph: EGB Kelly criterion";
            this.kellyBtn.UseVisualStyleBackColor = true;
            this.kellyBtn.Click += new System.EventHandler(this.kellyBtn_Click);
            // 
            // button2
            // 
            this.button2.CausesValidation = false;
            this.button2.Cursor = System.Windows.Forms.Cursors.Default;
            this.button2.Location = new System.Drawing.Point(375, 259);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(118, 37);
            this.button2.TabIndex = 29;
            this.button2.Text = "Get pairs";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // pairsLabel
            // 
            this.pairsLabel.AutoSize = true;
            this.pairsLabel.Location = new System.Drawing.Point(266, 271);
            this.pairsLabel.Name = "pairsLabel";
            this.pairsLabel.Size = new System.Drawing.Size(72, 13);
            this.pairsLabel.TabIndex = 30;
            this.pairsLabel.Text = "Pairs found: 0";
            // 
            // kellyMultiplier
            // 
            this.kellyMultiplier.Location = new System.Drawing.Point(153, 321);
            this.kellyMultiplier.Name = "kellyMultiplier";
            this.kellyMultiplier.Size = new System.Drawing.Size(77, 20);
            this.kellyMultiplier.TabIndex = 31;
            this.kellyMultiplier.Text = "0.3";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(153, 305);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(93, 13);
            this.label9.TabIndex = 32;
            this.label9.Text = "Part of Kelly to bet";
            // 
            // button3
            // 
            this.button3.CausesValidation = false;
            this.button3.Cursor = System.Windows.Forms.Cursors.Default;
            this.button3.Location = new System.Drawing.Point(12, 181);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(135, 24);
            this.button3.TabIndex = 34;
            this.button3.Text = "Convert to average odds";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.CausesValidation = false;
            this.button4.Cursor = System.Windows.Forms.Cursors.Default;
            this.button4.Location = new System.Drawing.Point(12, 211);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(135, 24);
            this.button4.TabIndex = 35;
            this.button4.Text = "Convert to point odds";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // F
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(510, 708);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.kellyMultiplier);
            this.Controls.Add(this.pairsLabel);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.kellyBtn);
            this.Controls.Add(this.maxmatchid);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.minmatchid);
            this.Controls.Add(this.bo5);
            this.Controls.Add(this.bo3);
            this.Controls.Add(this.bo2);
            this.Controls.Add(this.bo1);
            this.Controls.Add(this.csglmaxodds);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.csglminodds);
            this.Controls.Add(this.drawDiffBtn);
            this.Controls.Add(this.cleanGraphBtn);
            this.Controls.Add(this.graph);
            this.Controls.Add(this.csglBox);
            this.Controls.Add(this.egbBox);
            this.Name = "F";
            this.Text = "BettingStats";
            this.egbBox.ResumeLayout(false);
            this.egbBox.PerformLayout();
            this.csglBox.ResumeLayout(false);
            this.csglBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.graph)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button getEGBbtn;
        private System.Windows.Forms.TextBox egb_mid_fromBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox egb_mid_toBox;
        private System.Windows.Forms.Button loadEGB;
        private System.Windows.Forms.Button drawEGB;
        private System.Windows.Forms.GroupBox egbBox;
        private System.Windows.Forms.Label EGBlabel;
        private System.Windows.Forms.Button saveEGB;
        private System.Windows.Forms.GroupBox csglBox;
        private System.Windows.Forms.Label CSGLlabel;
        private System.Windows.Forms.Button saveCSGL;
        private System.Windows.Forms.TextBox csgl_mid_fromBox;
        private System.Windows.Forms.Button drawCSGL;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button loadCSGL;
        private System.Windows.Forms.TextBox csgl_mid_toBox;
        private System.Windows.Forms.Button getCSGLbtn;
        private System.Windows.Forms.DataVisualization.Charting.Chart graph;
        private System.Windows.Forms.CheckBox EGBautodraw;
        private System.Windows.Forms.CheckBox EGBautosave;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.SaveFileDialog saveFileDialog;
        private System.Windows.Forms.Button cleanGraphBtn;
        private System.Windows.Forms.Button drawDiffBtn;
        private System.Windows.Forms.TextBox csglminodds;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox csglmaxodds;
        private System.Windows.Forms.CheckBox bo1;
        private System.Windows.Forms.CheckBox bo2;
        private System.Windows.Forms.CheckBox bo3;
        private System.Windows.Forms.CheckBox bo5;
        private System.Windows.Forms.TextBox maxmatchid;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox minmatchid;
        private System.Windows.Forms.Button kellyBtn;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label pairsLabel;
        private System.Windows.Forms.TextBox kellyMultiplier;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
    }
}

