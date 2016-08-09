namespace MonteCarloForecastWin
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label8 = new System.Windows.Forms.Label();
            this.dtStartDt = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.numPermutations = new System.Windows.Forms.NumericUpDown();
            this.numRemainingLowGuess = new System.Windows.Forms.NumericUpDown();
            this.numSplitRateHigh = new System.Windows.Forms.NumericUpDown();
            this.numRemainingHighGuess = new System.Windows.Forms.NumericUpDown();
            this.numSplitRateLow = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.numLowVelocityGuess = new System.Windows.Forms.NumericUpDown();
            this.numHighVelocityGuess = new System.Windows.Forms.NumericUpDown();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.cmdHighLowGuessForecast = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.txtSamples = new System.Windows.Forms.TextBox();
            this.cmdSamplesForecast = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.rtbResults = new System.Windows.Forms.RichTextBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numPermutations)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numRemainingLowGuess)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numSplitRateHigh)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numRemainingHighGuess)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numSplitRateLow)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numLowVelocityGuess)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numHighVelocityGuess)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
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
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(269, 181);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Forecast Parameters";
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
            // numRemainingHighGuess
            // 
            this.numRemainingHighGuess.Location = new System.Drawing.Point(170, 98);
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
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 74);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(157, 13);
            this.label3.TabIndex = 29;
            this.label3.Text = "Remaining Stories (Low Guess):";
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
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(61, 52);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(105, 13);
            this.label6.TabIndex = 32;
            this.label6.Text = "Guess High Velocity:";
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
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.cmdHighLowGuessForecast);
            this.groupBox2.Controls.Add(this.numHighVelocityGuess);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.numLowVelocityGuess);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Location = new System.Drawing.Point(12, 199);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(269, 110);
            this.groupBox2.TabIndex = 33;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Parameters - Forecast Based on High/Low Guess";
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
            this.cmdHighLowGuessForecast.Click += new System.EventHandler(this.cmdHighLowGuessForecast_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.txtSamples);
            this.groupBox3.Controls.Add(this.cmdSamplesForecast);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Location = new System.Drawing.Point(9, 315);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(269, 110);
            this.groupBox3.TabIndex = 34;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Parameters - Forecast Based on Historic Samples";
            // 
            // txtSamples
            // 
            this.txtSamples.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtSamples.Location = new System.Drawing.Point(3, 29);
            this.txtSamples.Multiline = true;
            this.txtSamples.Name = "txtSamples";
            this.txtSamples.Size = new System.Drawing.Size(263, 55);
            this.txtSamples.TabIndex = 34;
            // 
            // cmdSamplesForecast
            // 
            this.cmdSamplesForecast.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.cmdSamplesForecast.Location = new System.Drawing.Point(3, 84);
            this.cmdSamplesForecast.Name = "cmdSamplesForecast";
            this.cmdSamplesForecast.Size = new System.Drawing.Size(263, 23);
            this.cmdSamplesForecast.TabIndex = 33;
            this.cmdSamplesForecast.Text = "Create Forecast";
            this.cmdSamplesForecast.UseVisualStyleBackColor = true;
            this.cmdSamplesForecast.Click += new System.EventHandler(this.cmdSamplesForecast_Click);
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
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.rtbResults);
            this.groupBox4.Location = new System.Drawing.Point(302, 12);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(484, 410);
            this.groupBox4.TabIndex = 35;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Forecast Results";
            // 
            // rtbResults
            // 
            this.rtbResults.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rtbResults.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtbResults.Location = new System.Drawing.Point(3, 16);
            this.rtbResults.Name = "rtbResults";
            this.rtbResults.Size = new System.Drawing.Size(478, 391);
            this.rtbResults.TabIndex = 0;
            this.rtbResults.Text = "";
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(798, 435);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmMain";
            this.Text = "Forecast";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numPermutations)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numRemainingLowGuess)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numSplitRateHigh)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numRemainingHighGuess)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numSplitRateLow)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numLowVelocityGuess)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numHighVelocityGuess)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.NumericUpDown numSplitRateHigh;
        private System.Windows.Forms.NumericUpDown numSplitRateLow;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown numPermutations;
        private System.Windows.Forms.NumericUpDown numLowVelocityGuess;
        private System.Windows.Forms.NumericUpDown numHighVelocityGuess;
        private System.Windows.Forms.NumericUpDown numRemainingHighGuess;
        private System.Windows.Forms.NumericUpDown numRemainingLowGuess;
        private System.Windows.Forms.DateTimePicker dtStartDt;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button cmdHighLowGuessForecast;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox txtSamples;
        private System.Windows.Forms.Button cmdSamplesForecast;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.RichTextBox rtbResults;
    }
}