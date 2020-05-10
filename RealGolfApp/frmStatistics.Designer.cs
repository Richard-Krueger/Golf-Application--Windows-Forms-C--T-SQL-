namespace RealGolfApp
{
    partial class frmStatistics
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
            this.lblTeamStats = new System.Windows.Forms.Label();
            this.cartScoringAverage = new LiveCharts.WinForms.CartesianChart();
            this.cartPuttsPerHole = new LiveCharts.WinForms.CartesianChart();
            this.cartFairwaysHit = new LiveCharts.WinForms.CartesianChart();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cartesianChart1 = new LiveCharts.WinForms.CartesianChart();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cartesianChart2 = new LiveCharts.WinForms.CartesianChart();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTeamStats
            // 
            this.lblTeamStats.AutoSize = true;
            this.lblTeamStats.Font = new System.Drawing.Font("Microsoft Sans Serif", 45F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTeamStats.Location = new System.Drawing.Point(180, 19);
            this.lblTeamStats.Name = "lblTeamStats";
            this.lblTeamStats.Size = new System.Drawing.Size(441, 69);
            this.lblTeamStats.TabIndex = 0;
            this.lblTeamStats.Text = "Team Statistics";
            // 
            // cartScoringAverage
            // 
            this.cartScoringAverage.Location = new System.Drawing.Point(41, 105);
            this.cartScoringAverage.Name = "cartScoringAverage";
            this.cartScoringAverage.Size = new System.Drawing.Size(233, 121);
            this.cartScoringAverage.TabIndex = 1;
            this.cartScoringAverage.Text = "cartesianChart1";
            // 
            // cartPuttsPerHole
            // 
            this.cartPuttsPerHole.Location = new System.Drawing.Point(41, 262);
            this.cartPuttsPerHole.Name = "cartPuttsPerHole";
            this.cartPuttsPerHole.Size = new System.Drawing.Size(233, 121);
            this.cartPuttsPerHole.TabIndex = 2;
            this.cartPuttsPerHole.Text = "cartesianChart1";
            // 
            // cartFairwaysHit
            // 
            this.cartFairwaysHit.Location = new System.Drawing.Point(527, 105);
            this.cartFairwaysHit.Name = "cartFairwaysHit";
            this.cartFairwaysHit.Size = new System.Drawing.Size(233, 121);
            this.cartFairwaysHit.TabIndex = 3;
            this.cartFairwaysHit.Text = "Fariways Hit";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(114, 238);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Scoring Average";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(611, 238);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Fairways Hit";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(104, 395);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(106, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Greens in Regulation";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(607, 395);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(74, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Putts per Hole";
            // 
            // cartesianChart1
            // 
            this.cartesianChart1.Location = new System.Drawing.Point(527, 262);
            this.cartesianChart1.Name = "cartesianChart1";
            this.cartesianChart1.Size = new System.Drawing.Size(233, 121);
            this.cartesianChart1.TabIndex = 7;
            this.cartesianChart1.Text = "cartesianChart1";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::RealGolfApp.Properties.Resources.SaintsLogo;
            this.pictureBox1.Location = new System.Drawing.Point(53, 19);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 69);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::RealGolfApp.Properties.Resources.SaintsLogo;
            this.pictureBox2.Location = new System.Drawing.Point(648, 19);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(100, 69);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 10;
            this.pictureBox2.TabStop = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(371, 330);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(78, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "Up and Downs";
            // 
            // cartesianChart2
            // 
            this.cartesianChart2.Location = new System.Drawing.Point(284, 196);
            this.cartesianChart2.Name = "cartesianChart2";
            this.cartesianChart2.Size = new System.Drawing.Size(233, 121);
            this.cartesianChart2.TabIndex = 11;
            this.cartesianChart2.Text = "cartesianChart2";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(284, 415);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 13;
            this.button1.Text = "&Return";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(442, 415);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 14;
            this.button2.Text = "E&xit";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(612, 238);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(64, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Fairways Hit";
            // 
            // Statistics
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cartesianChart2);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cartesianChart1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cartFairwaysHit);
            this.Controls.Add(this.cartPuttsPerHole);
            this.Controls.Add(this.cartScoringAverage);
            this.Controls.Add(this.lblTeamStats);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Statistics";
            this.Text = "Statistics";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTeamStats;
        private LiveCharts.WinForms.CartesianChart cartScoringAverage;
        private LiveCharts.WinForms.CartesianChart cartPuttsPerHole;
        private LiveCharts.WinForms.CartesianChart cartFairwaysHit;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private LiveCharts.WinForms.CartesianChart cartesianChart1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label5;
        private LiveCharts.WinForms.CartesianChart cartesianChart2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label6;
    }
}