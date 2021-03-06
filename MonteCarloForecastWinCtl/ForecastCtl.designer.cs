﻿namespace MonteCarloForecastWinCtl
{
    partial class ForecastCtl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.cmdHighLowGuessForecast = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.dtStartDt = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.numPermutations = new System.Windows.Forms.NumericUpDown();
            this.numRemainingLowGuess = new System.Windows.Forms.NumericUpDown();
            this.numSplitRateHigh = new System.Windows.Forms.NumericUpDown();
            this.txtSamples = new System.Windows.Forms.TextBox();
            this.cmdSamplesForecastWeighted = new System.Windows.Forms.Button();
            this.cmdSamplesForecast = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.numRemainingHighGuess = new System.Windows.Forms.NumericUpDown();
            this.numSplitRateLow = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.cmdGetHistoricSamples = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.rtbResults = new System.Windows.Forms.RichTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.numHighVelocityGuess = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.numLowVelocityGuess = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.gbReleaseBurndown = new System.Windows.Forms.GroupBox();
            this.cmdReleaseBurndown = new System.Windows.Forms.Button();
            this.chkBurndown_SimpleAverage = new System.Windows.Forms.CheckBox();
            this.chkBurndown_WeightedAverage = new System.Windows.Forms.CheckBox();
            this.chkBurndown_HighLowGuess = new System.Windows.Forms.CheckBox();
            this.dtEndDt = new System.Windows.Forms.DateTimePicker();
            this.label10 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numPermutations)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numRemainingLowGuess)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numSplitRateHigh)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numRemainingHighGuess)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numSplitRateLow)).BeginInit();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numHighVelocityGuess)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numLowVelocityGuess)).BeginInit();
            this.groupBox4.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.gbReleaseBurndown.SuspendLayout();
            this.SuspendLayout();
            // 
            // cmdHighLowGuessForecast
            // 
            this.cmdHighLowGuessForecast.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.cmdHighLowGuessForecast.Location = new System.Drawing.Point(3, 84);
            this.cmdHighLowGuessForecast.Name = "cmdHighLowGuessForecast";
            this.cmdHighLowGuessForecast.Size = new System.Drawing.Size(263, 23);
            this.cmdHighLowGuessForecast.TabIndex = 33;
            this.cmdHighLowGuessForecast.Text = "Create Forecast";
            this.cmdHighLowGuessForecast.UseVisualStyleBackColor = true;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(43, 152);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(121, 13);
            this.label8.TabIndex = 36;
            this.label8.Text = "Split Rate (High Bound):";
            // 
            // dtStartDt
            // 
            this.dtStartDt.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtStartDt.Location = new System.Drawing.Point(170, 19);
            this.dtStartDt.Name = "dtStartDt";
            this.dtStartDt.Size = new System.Drawing.Size(82, 20);
            this.dtStartDt.TabIndex = 21;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(61, 47);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(103, 13);
            this.label2.TabIndex = 28;
            this.label2.Text = "Model Permutations:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(43, 126);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(119, 13);
            this.label9.TabIndex = 35;
            this.label9.Text = "Split Rate (Low Bound):";
            // 
            // numPermutations
            // 
            this.numPermutations.Location = new System.Drawing.Point(170, 45);
            this.numPermutations.Maximum = new decimal(new int[] {
            10000000,
            0,
            0,
            0});
            this.numPermutations.Minimum = new decimal(new int[] {
            500,
            0,
            0,
            0});
            this.numPermutations.Name = "numPermutations";
            this.numPermutations.Size = new System.Drawing.Size(82, 20);
            this.numPermutations.TabIndex = 26;
            this.numPermutations.ThousandsSeparator = true;
            this.numPermutations.Value = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            // 
            // numRemainingLowGuess
            // 
            this.numRemainingLowGuess.Location = new System.Drawing.Point(170, 72);
            this.numRemainingLowGuess.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.numRemainingLowGuess.Name = "numRemainingLowGuess";
            this.numRemainingLowGuess.Size = new System.Drawing.Size(82, 20);
            this.numRemainingLowGuess.TabIndex = 22;
            // 
            // numSplitRateHigh
            // 
            this.numSplitRateHigh.DecimalPlaces = 2;
            this.numSplitRateHigh.Location = new System.Drawing.Point(170, 150);
            this.numSplitRateHigh.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numSplitRateHigh.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numSplitRateHigh.Name = "numSplitRateHigh";
            this.numSplitRateHigh.Size = new System.Drawing.Size(82, 20);
            this.numSplitRateHigh.TabIndex = 34;
            this.numSplitRateHigh.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // txtSamples
            // 
            this.txtSamples.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtSamples.Location = new System.Drawing.Point(3, 52);
            this.txtSamples.Multiline = true;
            this.txtSamples.Name = "txtSamples";
            this.txtSamples.Size = new System.Drawing.Size(263, 60);
            this.txtSamples.TabIndex = 34;
            this.txtSamples.DoubleClick += new System.EventHandler(this.txtSamples_DoubleClick);
            // 
            // cmdSamplesForecastWeighted
            // 
            this.cmdSamplesForecastWeighted.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.cmdSamplesForecastWeighted.Location = new System.Drawing.Point(3, 112);
            this.cmdSamplesForecastWeighted.Name = "cmdSamplesForecastWeighted";
            this.cmdSamplesForecastWeighted.Size = new System.Drawing.Size(263, 23);
            this.cmdSamplesForecastWeighted.TabIndex = 35;
            this.cmdSamplesForecastWeighted.Text = "Create Forecast (Weighted Average)";
            this.cmdSamplesForecastWeighted.UseVisualStyleBackColor = true;
            this.cmdSamplesForecastWeighted.Click += new System.EventHandler(this.cmdSamplesForecastWeighted_Click_1);
            // 
            // cmdSamplesForecast
            // 
            this.cmdSamplesForecast.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.cmdSamplesForecast.Location = new System.Drawing.Point(3, 135);
            this.cmdSamplesForecast.Name = "cmdSamplesForecast";
            this.cmdSamplesForecast.Size = new System.Drawing.Size(263, 23);
            this.cmdSamplesForecast.TabIndex = 33;
            this.cmdSamplesForecast.Text = "Create Forecast (Simple Average)";
            this.cmdSamplesForecast.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            this.label7.Dock = System.Windows.Forms.DockStyle.Top;
            this.label7.Location = new System.Drawing.Point(3, 16);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(263, 13);
            this.label7.TabIndex = 32;
            this.label7.Text = "Enter 7 or more historic samples (e.g. 3,5,6,5,8,11,9)";
            // 
            // numRemainingHighGuess
            // 
            this.numRemainingHighGuess.Location = new System.Drawing.Point(170, 98);
            this.numRemainingHighGuess.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.numRemainingHighGuess.Name = "numRemainingHighGuess";
            this.numRemainingHighGuess.Size = new System.Drawing.Size(82, 20);
            this.numRemainingHighGuess.TabIndex = 23;
            // 
            // numSplitRateLow
            // 
            this.numSplitRateLow.DecimalPlaces = 2;
            this.numSplitRateLow.Location = new System.Drawing.Point(170, 124);
            this.numSplitRateLow.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numSplitRateLow.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numSplitRateLow.Name = "numSplitRateLow";
            this.numSplitRateLow.Size = new System.Drawing.Size(82, 20);
            this.numSplitRateLow.TabIndex = 33;
            this.numSplitRateLow.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(118, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 13);
            this.label1.TabIndex = 27;
            this.label1.Text = "Start Dt:";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.txtSamples);
            this.groupBox3.Controls.Add(this.cmdGetHistoricSamples);
            this.groupBox3.Controls.Add(this.cmdSamplesForecastWeighted);
            this.groupBox3.Controls.Add(this.cmdSamplesForecast);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Location = new System.Drawing.Point(5, 315);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(269, 161);
            this.groupBox3.TabIndex = 38;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Parameters - Forecast Based on Historic Samples";
            // 
            // cmdGetHistoricSamples
            // 
            this.cmdGetHistoricSamples.Dock = System.Windows.Forms.DockStyle.Top;
            this.cmdGetHistoricSamples.Location = new System.Drawing.Point(3, 29);
            this.cmdGetHistoricSamples.Name = "cmdGetHistoricSamples";
            this.cmdGetHistoricSamples.Size = new System.Drawing.Size(263, 23);
            this.cmdGetHistoricSamples.TabIndex = 37;
            this.cmdGetHistoricSamples.Text = "Get Historic Samples";
            this.cmdGetHistoricSamples.UseVisualStyleBackColor = true;
            this.cmdGetHistoricSamples.Click += new System.EventHandler(this.cmdGetHistoricSamples_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 74);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(157, 13);
            this.label3.TabIndex = 29;
            this.label3.Text = "Remaining Stories (Low Guess):";
            // 
            // rtbResults
            // 
            this.rtbResults.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rtbResults.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtbResults.Location = new System.Drawing.Point(3, 16);
            this.rtbResults.Name = "rtbResults";
            this.rtbResults.Size = new System.Drawing.Size(505, 633);
            this.rtbResults.TabIndex = 0;
            this.rtbResults.Text = "";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(5, 100);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(159, 13);
            this.label4.TabIndex = 30;
            this.label4.Text = "Remaining Stories (High Guess):";
            // 
            // numHighVelocityGuess
            // 
            this.numHighVelocityGuess.Location = new System.Drawing.Point(170, 50);
            this.numHighVelocityGuess.Name = "numHighVelocityGuess";
            this.numHighVelocityGuess.Size = new System.Drawing.Size(82, 20);
            this.numHighVelocityGuess.TabIndex = 24;
            this.numHighVelocityGuess.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(61, 52);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(105, 13);
            this.label6.TabIndex = 32;
            this.label6.Text = "Guess High Velocity:";
            // 
            // numLowVelocityGuess
            // 
            this.numLowVelocityGuess.Location = new System.Drawing.Point(170, 24);
            this.numLowVelocityGuess.Name = "numLowVelocityGuess";
            this.numLowVelocityGuess.Size = new System.Drawing.Size(82, 20);
            this.numLowVelocityGuess.TabIndex = 25;
            this.numLowVelocityGuess.Value = new decimal(new int[] {
            6,
            0,
            0,
            0});
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(61, 26);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(103, 13);
            this.label5.TabIndex = 31;
            this.label5.Text = "Guess Low Velocity:";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.rtbResults);
            this.groupBox4.Dock = System.Windows.Forms.DockStyle.Right;
            this.groupBox4.Location = new System.Drawing.Point(280, 0);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(511, 652);
            this.groupBox4.TabIndex = 39;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Forecast Results";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.cmdHighLowGuessForecast);
            this.groupBox2.Controls.Add(this.numHighVelocityGuess);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.numLowVelocityGuess);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Location = new System.Drawing.Point(8, 199);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(269, 110);
            this.groupBox2.TabIndex = 37;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Parameters - Forecast Based on High/Low Guess";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.dtStartDt);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.numPermutations);
            this.groupBox1.Controls.Add(this.numRemainingLowGuess);
            this.groupBox1.Controls.Add(this.numSplitRateHigh);
            this.groupBox1.Controls.Add(this.numRemainingHighGuess);
            this.groupBox1.Controls.Add(this.numSplitRateLow);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Location = new System.Drawing.Point(8, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(269, 181);
            this.groupBox1.TabIndex = 36;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Forecast Parameters";
            // 
            // gbReleaseBurndown
            // 
            this.gbReleaseBurndown.Controls.Add(this.cmdReleaseBurndown);
            this.gbReleaseBurndown.Controls.Add(this.chkBurndown_SimpleAverage);
            this.gbReleaseBurndown.Controls.Add(this.chkBurndown_WeightedAverage);
            this.gbReleaseBurndown.Controls.Add(this.chkBurndown_HighLowGuess);
            this.gbReleaseBurndown.Controls.Add(this.dtEndDt);
            this.gbReleaseBurndown.Controls.Add(this.label10);
            this.gbReleaseBurndown.Location = new System.Drawing.Point(5, 482);
            this.gbReleaseBurndown.Name = "gbReleaseBurndown";
            this.gbReleaseBurndown.Size = new System.Drawing.Size(266, 160);
            this.gbReleaseBurndown.TabIndex = 40;
            this.gbReleaseBurndown.TabStop = false;
            this.gbReleaseBurndown.Text = "Release Burndown";
            this.gbReleaseBurndown.Visible = false;
            // 
            // cmdReleaseBurndown
            // 
            this.cmdReleaseBurndown.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.cmdReleaseBurndown.Location = new System.Drawing.Point(3, 134);
            this.cmdReleaseBurndown.Name = "cmdReleaseBurndown";
            this.cmdReleaseBurndown.Size = new System.Drawing.Size(260, 23);
            this.cmdReleaseBurndown.TabIndex = 34;
            this.cmdReleaseBurndown.Text = "Create Release Burndown";
            this.cmdReleaseBurndown.UseVisualStyleBackColor = true;
            this.cmdReleaseBurndown.Click += new System.EventHandler(this.cmdReleaseBurndown_Click);
            // 
            // chkBurndown_SimpleAverage
            // 
            this.chkBurndown_SimpleAverage.AutoSize = true;
            this.chkBurndown_SimpleAverage.Location = new System.Drawing.Point(13, 96);
            this.chkBurndown_SimpleAverage.Name = "chkBurndown_SimpleAverage";
            this.chkBurndown_SimpleAverage.Size = new System.Drawing.Size(144, 17);
            this.chkBurndown_SimpleAverage.TabIndex = 32;
            this.chkBurndown_SimpleAverage.Text = "Historic Samples - Simple";
            this.chkBurndown_SimpleAverage.UseVisualStyleBackColor = true;
            this.chkBurndown_SimpleAverage.CheckedChanged += new System.EventHandler(this.chkBurndown_SimpleAverage_CheckedChanged);
            // 
            // chkBurndown_WeightedAverage
            // 
            this.chkBurndown_WeightedAverage.AutoSize = true;
            this.chkBurndown_WeightedAverage.Location = new System.Drawing.Point(13, 73);
            this.chkBurndown_WeightedAverage.Name = "chkBurndown_WeightedAverage";
            this.chkBurndown_WeightedAverage.Size = new System.Drawing.Size(159, 17);
            this.chkBurndown_WeightedAverage.TabIndex = 31;
            this.chkBurndown_WeightedAverage.Text = "Historic Samples - Weighted";
            this.chkBurndown_WeightedAverage.UseVisualStyleBackColor = true;
            this.chkBurndown_WeightedAverage.CheckedChanged += new System.EventHandler(this.chkBurndown_WeightedAverage_CheckedChanged);
            // 
            // chkBurndown_HighLowGuess
            // 
            this.chkBurndown_HighLowGuess.AutoSize = true;
            this.chkBurndown_HighLowGuess.Location = new System.Drawing.Point(13, 50);
            this.chkBurndown_HighLowGuess.Name = "chkBurndown_HighLowGuess";
            this.chkBurndown_HighLowGuess.Size = new System.Drawing.Size(106, 17);
            this.chkBurndown_HighLowGuess.TabIndex = 30;
            this.chkBurndown_HighLowGuess.Text = "High/Low Guess";
            this.chkBurndown_HighLowGuess.UseVisualStyleBackColor = true;
            this.chkBurndown_HighLowGuess.CheckedChanged += new System.EventHandler(this.chkBurndown_HighLowGuess_CheckedChanged);
            // 
            // dtEndDt
            // 
            this.dtEndDt.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtEndDt.Location = new System.Drawing.Point(173, 19);
            this.dtEndDt.Name = "dtEndDt";
            this.dtEndDt.Size = new System.Drawing.Size(82, 20);
            this.dtEndDt.TabIndex = 28;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(121, 21);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(43, 13);
            this.label10.TabIndex = 29;
            this.label10.Text = "End Dt:";
            // 
            // ForecastCtl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.gbReleaseBurndown);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "ForecastCtl";
            this.Size = new System.Drawing.Size(791, 652);
            ((System.ComponentModel.ISupportInitialize)(this.numPermutations)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numRemainingLowGuess)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numSplitRateHigh)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numRemainingHighGuess)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numSplitRateLow)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numHighVelocityGuess)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numLowVelocityGuess)).EndInit();
            this.groupBox4.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.gbReleaseBurndown.ResumeLayout(false);
            this.gbReleaseBurndown.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button cmdHighLowGuessForecast;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DateTimePicker dtStartDt;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.NumericUpDown numPermutations;
        private System.Windows.Forms.NumericUpDown numRemainingLowGuess;
        private System.Windows.Forms.NumericUpDown numSplitRateHigh;
        private System.Windows.Forms.TextBox txtSamples;
        private System.Windows.Forms.Button cmdSamplesForecastWeighted;
        private System.Windows.Forms.Button cmdSamplesForecast;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.NumericUpDown numRemainingHighGuess;
        private System.Windows.Forms.NumericUpDown numSplitRateLow;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RichTextBox rtbResults;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown numHighVelocityGuess;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.NumericUpDown numLowVelocityGuess;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button cmdGetHistoricSamples;
        private System.Windows.Forms.GroupBox gbReleaseBurndown;
        private System.Windows.Forms.Button cmdReleaseBurndown;
        private System.Windows.Forms.CheckBox chkBurndown_SimpleAverage;
        private System.Windows.Forms.CheckBox chkBurndown_WeightedAverage;
        private System.Windows.Forms.CheckBox chkBurndown_HighLowGuess;
        private System.Windows.Forms.DateTimePicker dtEndDt;
        private System.Windows.Forms.Label label10;
    }
}
