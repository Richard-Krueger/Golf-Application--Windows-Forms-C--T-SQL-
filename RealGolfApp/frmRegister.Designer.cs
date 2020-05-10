namespace RealGolfApp
{
    partial class frmRegister
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmRegister));
            this.picSaintsLogo = new System.Windows.Forms.PictureBox();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnSaveRegister = new System.Windows.Forms.Button();
            this.lblSelectName = new System.Windows.Forms.Label();
            this.lblUserName = new System.Windows.Forms.Label();
            this.lblPassword = new System.Windows.Forms.Label();
            this.lblPasswordVerify = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.txtUserName = new System.Windows.Forms.TextBox();
            this.txtPassword1 = new System.Windows.Forms.TextBox();
            this.txtPassword2 = new System.Windows.Forms.TextBox();
            this.btnBack = new System.Windows.Forms.Button();
            this.unregisteredUsersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.unregisteredUsers = new RealGolfApp.UnregisteredUsers();
            this.unregisteredUsersBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.unregisteredUsersTableAdapter = new RealGolfApp.UnregisteredUsersTableAdapters.UnregisteredUsersTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.picSaintsLogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.unregisteredUsersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.unregisteredUsers)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.unregisteredUsersBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // picSaintsLogo
            // 
            this.picSaintsLogo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.picSaintsLogo.Image = ((System.Drawing.Image)(resources.GetObject("picSaintsLogo.Image")));
            this.picSaintsLogo.Location = new System.Drawing.Point(163, 29);
            this.picSaintsLogo.Name = "picSaintsLogo";
            this.picSaintsLogo.Size = new System.Drawing.Size(275, 222);
            this.picSaintsLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picSaintsLogo.TabIndex = 7;
            this.picSaintsLogo.TabStop = false;
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(363, 415);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 10;
            this.btnExit.Text = "E&xit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnSaveRegister
            // 
            this.btnSaveRegister.Location = new System.Drawing.Point(162, 415);
            this.btnSaveRegister.Name = "btnSaveRegister";
            this.btnSaveRegister.Size = new System.Drawing.Size(75, 23);
            this.btnSaveRegister.TabIndex = 8;
            this.btnSaveRegister.Text = "&Save";
            this.btnSaveRegister.UseVisualStyleBackColor = true;
            this.btnSaveRegister.Click += new System.EventHandler(this.btnSaveRegister_Click);
            // 
            // lblSelectName
            // 
            this.lblSelectName.AutoSize = true;
            this.lblSelectName.Location = new System.Drawing.Point(176, 280);
            this.lblSelectName.Name = "lblSelectName";
            this.lblSelectName.Size = new System.Drawing.Size(96, 13);
            this.lblSelectName.TabIndex = 0;
            this.lblSelectName.Text = "Select Your Name:";
            // 
            // lblUserName
            // 
            this.lblUserName.AutoSize = true;
            this.lblUserName.Location = new System.Drawing.Point(214, 312);
            this.lblUserName.Name = "lblUserName";
            this.lblUserName.Size = new System.Drawing.Size(58, 13);
            this.lblUserName.TabIndex = 2;
            this.lblUserName.Text = "Username:";
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Location = new System.Drawing.Point(216, 345);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(56, 13);
            this.lblPassword.TabIndex = 4;
            this.lblPassword.Text = "Password:";
            // 
            // lblPasswordVerify
            // 
            this.lblPasswordVerify.AutoSize = true;
            this.lblPasswordVerify.Location = new System.Drawing.Point(172, 380);
            this.lblPasswordVerify.Name = "lblPasswordVerify";
            this.lblPasswordVerify.Size = new System.Drawing.Size(100, 13);
            this.lblPasswordVerify.TabIndex = 6;
            this.lblPasswordVerify.Text = "Re-enter Password:";
            // 
            // comboBox1
            // 
            this.comboBox1.DataSource = this.unregisteredUsersBindingSource1;
            this.comboBox1.DisplayMember = "Name";
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(308, 277);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 1;
            // 
            // txtUserName
            // 
            this.txtUserName.Location = new System.Drawing.Point(308, 309);
            this.txtUserName.Name = "txtUserName";
            this.txtUserName.Size = new System.Drawing.Size(121, 20);
            this.txtUserName.TabIndex = 3;
            this.txtUserName.Tag = "Username";
            // 
            // txtPassword1
            // 
            this.txtPassword1.Location = new System.Drawing.Point(308, 342);
            this.txtPassword1.Name = "txtPassword1";
            this.txtPassword1.Size = new System.Drawing.Size(121, 20);
            this.txtPassword1.TabIndex = 5;
            this.txtPassword1.Tag = "Password";
            this.txtPassword1.UseSystemPasswordChar = true;
            // 
            // txtPassword2
            // 
            this.txtPassword2.Location = new System.Drawing.Point(308, 377);
            this.txtPassword2.Name = "txtPassword2";
            this.txtPassword2.Size = new System.Drawing.Size(121, 20);
            this.txtPassword2.TabIndex = 7;
            this.txtPassword2.Tag = "Password varifier";
            this.txtPassword2.UseSystemPasswordChar = true;
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(262, 415);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(75, 23);
            this.btnBack.TabIndex = 9;
            this.btnBack.Text = "&Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // unregisteredUsers
            // 
            this.unregisteredUsers.DataSetName = "UnregisteredUsers";
            this.unregisteredUsers.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // unregisteredUsersBindingSource1
            // 
            this.unregisteredUsersBindingSource1.DataMember = "UnregisteredUsers";
            this.unregisteredUsersBindingSource1.DataSource = this.unregisteredUsers;
            // 
            // unregisteredUsersTableAdapter
            // 
            this.unregisteredUsersTableAdapter.ClearBeforeFill = true;
            // 
            // frmRegister
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(601, 489);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.txtPassword2);
            this.Controls.Add(this.txtPassword1);
            this.Controls.Add(this.txtUserName);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.lblPasswordVerify);
            this.Controls.Add(this.lblPassword);
            this.Controls.Add(this.lblUserName);
            this.Controls.Add(this.lblSelectName);
            this.Controls.Add(this.btnSaveRegister);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.picSaintsLogo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmRegister";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Register Form";
            this.Load += new System.EventHandler(this.frmRegister_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picSaintsLogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.unregisteredUsersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.unregisteredUsers)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.unregisteredUsersBindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picSaintsLogo;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnSaveRegister;
        private System.Windows.Forms.Label lblSelectName;
        private System.Windows.Forms.Label lblUserName;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.Label lblPasswordVerify;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.TextBox txtUserName;
        private System.Windows.Forms.TextBox txtPassword1;
        private System.Windows.Forms.TextBox txtPassword2;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.BindingSource unregisteredUsersBindingSource;
        private UnregisteredUsers unregisteredUsers;
        private System.Windows.Forms.BindingSource unregisteredUsersBindingSource1;
        private UnregisteredUsersTableAdapters.UnregisteredUsersTableAdapter unregisteredUsersTableAdapter;
    }
}