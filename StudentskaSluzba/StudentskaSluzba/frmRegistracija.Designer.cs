namespace StudentskaSluzba
{
    partial class frmRegistracija
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmRegistracija));
            this.txtIme = new System.Windows.Forms.TextBox();
            this.txtPrezime = new System.Windows.Forms.TextBox();
            this.lblIme = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.btnSnimi = new System.Windows.Forms.Button();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.chkAktivan = new System.Windows.Forms.CheckBox();
            this.clbUloge = new System.Windows.Forms.CheckedListBox();
            this.cmbGrad = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cmbSpol = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // txtIme
            // 
            this.txtIme.Location = new System.Drawing.Point(40, 42);
            this.txtIme.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtIme.Name = "txtIme";
            this.txtIme.Size = new System.Drawing.Size(207, 22);
            this.txtIme.TabIndex = 0;
            // 
            // txtPrezime
            // 
            this.txtPrezime.Location = new System.Drawing.Point(311, 41);
            this.txtPrezime.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtPrezime.Name = "txtPrezime";
            this.txtPrezime.Size = new System.Drawing.Size(240, 22);
            this.txtPrezime.TabIndex = 1;
            // 
            // lblIme
            // 
            this.lblIme.AutoSize = true;
            this.lblIme.Location = new System.Drawing.Point(40, 18);
            this.lblIme.Name = "lblIme";
            this.lblIme.Size = new System.Drawing.Size(34, 17);
            this.lblIme.TabIndex = 2;
            this.lblIme.Text = "Ime:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(311, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "Prezime:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(43, 89);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 17);
            this.label2.TabIndex = 5;
            this.label2.Text = "Username:";
            // 
            // txtUsername
            // 
            this.txtUsername.Location = new System.Drawing.Point(40, 111);
            this.txtUsername.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(207, 22);
            this.txtUsername.TabIndex = 4;
            this.txtUsername.Validating += new System.ComponentModel.CancelEventHandler(this.txtUsername_Validating);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(311, 89);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 17);
            this.label3.TabIndex = 7;
            this.label3.Text = "Password:";
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(311, 111);
            this.txtPassword.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(240, 22);
            this.txtPassword.TabIndex = 6;
            this.txtPassword.Validating += new System.ComponentModel.CancelEventHandler(this.txtPassword_Validating);
            // 
            // btnSnimi
            // 
            this.btnSnimi.Location = new System.Drawing.Point(387, 389);
            this.btnSnimi.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSnimi.Name = "btnSnimi";
            this.btnSnimi.Size = new System.Drawing.Size(165, 23);
            this.btnSnimi.TabIndex = 8;
            this.btnSnimi.Text = "Snimi";
            this.btnSnimi.UseVisualStyleBackColor = true;
            this.btnSnimi.Click += new System.EventHandler(this.btnSnimi_Click);
            // 
            // errorProvider
            // 
            this.errorProvider.ContainerControl = this;
            this.errorProvider.Icon = ((System.Drawing.Icon)(resources.GetObject("errorProvider.Icon")));
            // 
            // chkAktivan
            // 
            this.chkAktivan.AutoSize = true;
            this.chkAktivan.Location = new System.Drawing.Point(40, 165);
            this.chkAktivan.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.chkAktivan.Name = "chkAktivan";
            this.chkAktivan.Size = new System.Drawing.Size(84, 21);
            this.chkAktivan.TabIndex = 9;
            this.chkAktivan.Text = "Aktivan?";
            this.chkAktivan.UseVisualStyleBackColor = true;
            // 
            // clbUloge
            // 
            this.clbUloge.FormattingEnabled = true;
            this.clbUloge.Location = new System.Drawing.Point(40, 214);
            this.clbUloge.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.clbUloge.Name = "clbUloge";
            this.clbUloge.Size = new System.Drawing.Size(207, 123);
            this.clbUloge.TabIndex = 10;
            // 
            // cmbGrad
            // 
            this.cmbGrad.FormattingEnabled = true;
            this.cmbGrad.Location = new System.Drawing.Point(311, 214);
            this.cmbGrad.Name = "cmbGrad";
            this.cmbGrad.Size = new System.Drawing.Size(240, 24);
            this.cmbGrad.TabIndex = 11;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(308, 194);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 17);
            this.label4.TabIndex = 12;
            this.label4.Text = "Grad:";
            // 
            // cmbSpol
            // 
            this.cmbSpol.FormattingEnabled = true;
            this.cmbSpol.Location = new System.Drawing.Point(311, 264);
            this.cmbSpol.Name = "cmbSpol";
            this.cmbSpol.Size = new System.Drawing.Size(241, 24);
            this.cmbSpol.TabIndex = 13;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(311, 244);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(40, 17);
            this.label5.TabIndex = 14;
            this.label5.Text = "Spol:";
            // 
            // frmRegistracija
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(597, 448);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cmbSpol);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cmbGrad);
            this.Controls.Add(this.clbUloge);
            this.Controls.Add(this.chkAktivan);
            this.Controls.Add(this.btnSnimi);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtUsername);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblIme);
            this.Controls.Add(this.txtPrezime);
            this.Controls.Add(this.txtIme);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "frmRegistracija";
            this.Text = "frmRegistracija";
            this.Load += new System.EventHandler(this.frmRegistracija_Load);
            this.MouseClick += new System.Windows.Forms.MouseEventHandler(this.frmRegistracija_MouseClick);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtIme;
        private System.Windows.Forms.TextBox txtPrezime;
        private System.Windows.Forms.Label lblIme;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Button btnSnimi;
        private System.Windows.Forms.ErrorProvider errorProvider;
        private System.Windows.Forms.CheckBox chkAktivan;
        private System.Windows.Forms.CheckedListBox clbUloge;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cmbGrad;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cmbSpol;
    }
}