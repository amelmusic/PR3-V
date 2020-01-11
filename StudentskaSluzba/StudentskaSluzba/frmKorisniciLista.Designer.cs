namespace StudentskaSluzba
{
    partial class frmKorisniciLista
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
            this.dgvKorisniciList = new System.Windows.Forms.DataGridView();
            this.btnPrikazi = new System.Windows.Forms.Button();
            this.txtIme = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtPrezime = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.lblUkupno = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtSkip = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtLimit = new System.Windows.Forms.TextBox();
            this.clmIme = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Grad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Uloga = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmUsername = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IB = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.chkAktivan = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvKorisniciList)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgvKorisniciList);
            this.groupBox1.Location = new System.Drawing.Point(12, 98);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Size = new System.Drawing.Size(785, 338);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Lista korisnika";
            // 
            // dgvKorisniciList
            // 
            this.dgvKorisniciList.AllowUserToAddRows = false;
            this.dgvKorisniciList.AllowUserToDeleteRows = false;
            this.dgvKorisniciList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvKorisniciList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clmIme,
            this.Grad,
            this.Uloga,
            this.clmUsername,
            this.IB,
            this.chkAktivan});
            this.dgvKorisniciList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvKorisniciList.Location = new System.Drawing.Point(3, 17);
            this.dgvKorisniciList.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvKorisniciList.Name = "dgvKorisniciList";
            this.dgvKorisniciList.ReadOnly = true;
            this.dgvKorisniciList.RowHeadersWidth = 51;
            this.dgvKorisniciList.RowTemplate.Height = 24;
            this.dgvKorisniciList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvKorisniciList.Size = new System.Drawing.Size(779, 319);
            this.dgvKorisniciList.TabIndex = 0;
            this.dgvKorisniciList.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvKorisniciList_CellDoubleClick);
            // 
            // btnPrikazi
            // 
            this.btnPrikazi.Location = new System.Drawing.Point(648, 69);
            this.btnPrikazi.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnPrikazi.Name = "btnPrikazi";
            this.btnPrikazi.Size = new System.Drawing.Size(140, 23);
            this.btnPrikazi.TabIndex = 1;
            this.btnPrikazi.Text = "Prikaži";
            this.btnPrikazi.UseVisualStyleBackColor = true;
            this.btnPrikazi.Click += new System.EventHandler(this.btnPrikazi_Click);
            // 
            // txtIme
            // 
            this.txtIme.Location = new System.Drawing.Point(15, 70);
            this.txtIme.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtIme.Name = "txtIme";
            this.txtIme.Size = new System.Drawing.Size(207, 22);
            this.txtIme.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "Ime:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(227, 47);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 17);
            this.label2.TabIndex = 5;
            this.label2.Text = "Prezime:";
            // 
            // txtPrezime
            // 
            this.txtPrezime.Location = new System.Drawing.Point(227, 70);
            this.txtPrezime.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtPrezime.Name = "txtPrezime";
            this.txtPrezime.Size = new System.Drawing.Size(207, 22);
            this.txtPrezime.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 479);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 17);
            this.label3.TabIndex = 6;
            this.label3.Text = "Ukupno:";
            // 
            // lblUkupno
            // 
            this.lblUkupno.AutoSize = true;
            this.lblUkupno.Location = new System.Drawing.Point(79, 479);
            this.lblUkupno.Name = "lblUkupno";
            this.lblUkupno.Size = new System.Drawing.Size(0, 17);
            this.lblUkupno.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(504, 455);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(114, 17);
            this.label4.TabIndex = 9;
            this.label4.Text = "Preskoči redove:";
            // 
            // txtSkip
            // 
            this.txtSkip.Location = new System.Drawing.Point(504, 479);
            this.txtSkip.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtSkip.Name = "txtSkip";
            this.txtSkip.Size = new System.Drawing.Size(129, 22);
            this.txtSkip.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(648, 455);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(43, 17);
            this.label5.TabIndex = 11;
            this.label5.Text = "Uzmi:";
            // 
            // txtLimit
            // 
            this.txtLimit.Location = new System.Drawing.Point(648, 479);
            this.txtLimit.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtLimit.Name = "txtLimit";
            this.txtLimit.Size = new System.Drawing.Size(129, 22);
            this.txtLimit.TabIndex = 10;
            // 
            // clmIme
            // 
            this.clmIme.DataPropertyName = "Naziv";
            this.clmIme.HeaderText = "Ime korisnika";
            this.clmIme.MinimumWidth = 6;
            this.clmIme.Name = "clmIme";
            this.clmIme.ReadOnly = true;
            this.clmIme.Width = 125;
            // 
            // Grad
            // 
            this.Grad.DataPropertyName = "Grad.Naziv";
            this.Grad.HeaderText = "Grad";
            this.Grad.MinimumWidth = 6;
            this.Grad.Name = "Grad";
            this.Grad.ReadOnly = true;
            this.Grad.Width = 125;
            // 
            // Uloga
            // 
            this.Uloga.DataPropertyName = "UlogeStr";
            this.Uloga.HeaderText = "Uloga";
            this.Uloga.MinimumWidth = 6;
            this.Uloga.Name = "Uloga";
            this.Uloga.ReadOnly = true;
            this.Uloga.Width = 125;
            // 
            // clmUsername
            // 
            this.clmUsername.DataPropertyName = "Username";
            this.clmUsername.HeaderText = "Username";
            this.clmUsername.MinimumWidth = 6;
            this.clmUsername.Name = "clmUsername";
            this.clmUsername.ReadOnly = true;
            this.clmUsername.Width = 125;
            // 
            // IB
            // 
            this.IB.DataPropertyName = "IB";
            this.IB.HeaderText = "IB";
            this.IB.MinimumWidth = 6;
            this.IB.Name = "IB";
            this.IB.ReadOnly = true;
            this.IB.Width = 125;
            // 
            // chkAktivan
            // 
            this.chkAktivan.DataPropertyName = "Aktivan";
            this.chkAktivan.HeaderText = "Aktivan?";
            this.chkAktivan.MinimumWidth = 6;
            this.chkAktivan.Name = "chkAktivan";
            this.chkAktivan.ReadOnly = true;
            this.chkAktivan.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.chkAktivan.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.chkAktivan.Width = 125;
            // 
            // frmKorisniciLista
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(832, 572);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtLimit);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtSkip);
            this.Controls.Add(this.lblUkupno);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtPrezime);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtIme);
            this.Controls.Add(this.btnPrikazi);
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "frmKorisniciLista";
            this.Text = "frmKorisniciLista";
            this.Load += new System.EventHandler(this.frmKorisniciLista_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvKorisniciList)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dgvKorisniciList;
        private System.Windows.Forms.Button btnPrikazi;
        private System.Windows.Forms.TextBox txtIme;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtPrezime;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblUkupno;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtSkip;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtLimit;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmIme;
        private System.Windows.Forms.DataGridViewTextBoxColumn Grad;
        private System.Windows.Forms.DataGridViewTextBoxColumn Uloga;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmUsername;
        private System.Windows.Forms.DataGridViewTextBoxColumn IB;
        private System.Windows.Forms.DataGridViewCheckBoxColumn chkAktivan;
    }
}