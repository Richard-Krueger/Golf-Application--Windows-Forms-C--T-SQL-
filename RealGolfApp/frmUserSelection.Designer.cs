namespace RealGolfApp
{
    partial class frmUserSelection
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmUserSelection));
            this.picSaintsLogo = new System.Windows.Forms.PictureBox();
            this.lblWelcomeMessage = new System.Windows.Forms.Label();
            this.lblSelection = new System.Windows.Forms.Label();
            this.cboSelection = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.picSaintsLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // picSaintsLogo
            // 
            this.picSaintsLogo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.picSaintsLogo.Image = ((System.Drawing.Image)(resources.GetObject("picSaintsLogo.Image")));
            this.picSaintsLogo.Location = new System.Drawing.Point(103, 91);
            this.picSaintsLogo.Name = "picSaintsLogo";
            this.picSaintsLogo.Size = new System.Drawing.Size(395, 341);
            this.picSaintsLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.picSaintsLogo.TabIndex = 7;
            this.picSaintsLogo.TabStop = false;
            // 
            // lblWelcomeMessage
            // 
            this.lblWelcomeMessage.AutoSize = true;
            this.lblWelcomeMessage.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWelcomeMessage.Location = new System.Drawing.Point(17, 33);
            this.lblWelcomeMessage.Name = "lblWelcomeMessage";
            this.lblWelcomeMessage.Size = new System.Drawing.Size(567, 37);
            this.lblWelcomeMessage.TabIndex = 8;
            this.lblWelcomeMessage.Text = "Welcome, (Coach) [User\'s First Name]";
            // 
            // lblSelection
            // 
            this.lblSelection.AutoSize = true;
            this.lblSelection.Location = new System.Drawing.Point(157, 457);
            this.lblSelection.Name = "lblSelection";
            this.lblSelection.Size = new System.Drawing.Size(107, 13);
            this.lblSelection.TabIndex = 9;
            this.lblSelection.Text = "Make your Selection:";
            // 
            // cboSelection
            // 
            this.cboSelection.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboSelection.FormattingEnabled = true;
            this.cboSelection.Items.AddRange(new object[] {
            "What would you like to do?",
            "Course:",
            "\tAdd",
            "\tEdit",
            "Round:",
            "\tAdd",
            "\tEdit",
            "Statistics:",
            "\tView (by Course)",
            "\tView (by Round Type)",
            "\tView Overall",
            "Logout",
            "Exit"});
            this.cboSelection.Location = new System.Drawing.Point(323, 453);
            this.cboSelection.Name = "cboSelection";
            this.cboSelection.Size = new System.Drawing.Size(121, 21);
            this.cboSelection.TabIndex = 10;
            this.cboSelection.SelectedIndexChanged += new System.EventHandler(this.cboSelection_SelectedIndexChanged);
            // 
            // frmUserSelection
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(601, 489);
            this.Controls.Add(this.cboSelection);
            this.Controls.Add(this.lblSelection);
            this.Controls.Add(this.lblWelcomeMessage);
            this.Controls.Add(this.picSaintsLogo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmUserSelection";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "UserSelectionForm";
            ((System.ComponentModel.ISupportInitialize)(this.picSaintsLogo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picSaintsLogo;
        private System.Windows.Forms.Label lblWelcomeMessage;
        private System.Windows.Forms.Label lblSelection;
        private System.Windows.Forms.ComboBox cboSelection;
    }
}