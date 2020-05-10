namespace RealGolfApp
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.picSaintsLogo = new System.Windows.Forms.PictureBox();
            this.cboMainSelection = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.picSaintsLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // picSaintsLogo
            // 
            this.picSaintsLogo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.picSaintsLogo.Image = ((System.Drawing.Image)(resources.GetObject("picSaintsLogo.Image")));
            this.picSaintsLogo.Location = new System.Drawing.Point(95, 47);
            this.picSaintsLogo.Name = "picSaintsLogo";
            this.picSaintsLogo.Size = new System.Drawing.Size(395, 341);
            this.picSaintsLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.picSaintsLogo.TabIndex = 7;
            this.picSaintsLogo.TabStop = false;
            // 
            // cboMainSelection
            // 
            this.cboMainSelection.FormattingEnabled = true;
            this.cboMainSelection.Items.AddRange(new object[] {
            "",
            "Register",
            "Login",
            "Exit"});
            this.cboMainSelection.Location = new System.Drawing.Point(289, 421);
            this.cboMainSelection.Name = "cboMainSelection";
            this.cboMainSelection.Size = new System.Drawing.Size(121, 21);
            this.cboMainSelection.TabIndex = 10;
            this.cboMainSelection.SelectedIndexChanged += new System.EventHandler(this.cboMainSelection_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(174, 424);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 13);
            this.label1.TabIndex = 11;
            this.label1.Text = "Make Your Selection:";
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(601, 489);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cboMainSelection);
            this.Controls.Add(this.picSaintsLogo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmMain";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MainForm";
            ((System.ComponentModel.ISupportInitialize)(this.picSaintsLogo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picSaintsLogo;
        private System.Windows.Forms.ComboBox cboMainSelection;
        private System.Windows.Forms.Label label1;
    }
}