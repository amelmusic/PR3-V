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
            this.clmIme = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmPrezime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmUsername = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvKorisniciList)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgvKorisniciList);
            this.groupBox1.Location = new System.Drawing.Point(12, 99);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(785, 339);
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
            this.clmPrezime,
            this.clmUsername});
            this.dgvKorisniciList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvKorisniciList.Location = new System.Drawing.Point(3, 18);
            this.dgvKorisniciList.Name = "dgvKorisniciList";
            this.dgvKorisniciList.ReadOnly = true;
            this.dgvKorisniciList.RowHeadersWidth = 51;
            this.dgvKorisniciList.RowTemplate.Height = 24;
            this.dgvKorisniciList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvKorisniciList.Size = new System.Drawing.Size(779, 318);
            this.dgvKorisniciList.TabIndex = 0;
            this.dgvKorisniciList.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvKorisniciList_CellDoubleClick);
            // 
            // btnPrikazi
            // 
            this.btnPrikazi.Location = new System.Drawing.Point(631, 70);
            this.btnPrikazi.Name = "btnPrikazi";
            this.btnPrikazi.Size = new System.Drawing.Size(140, 23);
            this.btnPrikazi.TabIndex = 1;
            this.btnPrikazi.Text = "Prikaži";
            this.btnPrikazi.UseVisualStyleBackColor = true;
            this.btnPrikazi.Click += new System.EventHandler(this.btnPrikazi_Click);
            // 
            // clmIme
            // 
            this.clmIme.DataPropertyName = "Ime";
            this.clmIme.HeaderText = "Ime korisnika";
            this.clmIme.MinimumWidth = 6;
            this.clmIme.Name = "clmIme";
            this.clmIme.ReadOnly = true;
            this.clmIme.Width = 125;
            // 
            // clmPrezime
            // 
            this.clmPrezime.DataPropertyName = "Prezime";
            this.clmPrezime.HeaderText = "Prezime";
            this.clmPrezime.MinimumWidth = 6;
            this.clmPrezime.Name = "clmPrezime";
            this.clmPrezime.ReadOnly = true;
            this.clmPrezime.Width = 125;
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
            // frmKorisniciLista
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnPrikazi);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmKorisniciLista";
            this.Text = "frmKorisniciLista";
            this.Load += new System.EventHandler(this.frmKorisniciLista_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvKorisniciList)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dgvKorisniciList;
        private System.Windows.Forms.Button btnPrikazi;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmIme;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmPrezime;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmUsername;
    }
}