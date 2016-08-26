namespace MonteCarloForecastWin
{
    partial class frmTestUserControl
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
            this.forecastCtl1 = new MonteCarloForecastWin.ForecastCtl();
            this.SuspendLayout();
            // 
            // forecastCtl1
            // 
            this.forecastCtl1.Location = new System.Drawing.Point(12, 12);
            this.forecastCtl1.Name = "forecastCtl1";
            this.forecastCtl1.Size = new System.Drawing.Size(804, 586);
            this.forecastCtl1.TabIndex = 0;
            this.forecastCtl1.OnGetHistoricSamples += new MonteCarloForecastWin.ForecastCtl.GetHistoricSamplesDelegate(this.forecastCtl1_OnGetHistoricSamples);
            // 
            // frmTestUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1128, 683);
            this.Controls.Add(this.forecastCtl1);
            this.Name = "frmTestUserControl";
            this.Text = "frmTestUserControl";
            this.ResumeLayout(false);

        }

        #endregion

        private ForecastCtl forecastCtl1;
    }
}