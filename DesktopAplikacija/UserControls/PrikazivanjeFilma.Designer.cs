
namespace DesktopAplikacija.UserControls
{
    partial class PrikazivanjeFilma
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
            this.dataGridViewKarte = new System.Windows.Forms.DataGridView();
            this.NazivFilma = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NazivSale = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DatumOdrzavanja = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.VremeOdrzavanja = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BrojProdatih = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Kapacitet = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tableLayoutPanel6 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel5 = new System.Windows.Forms.TableLayoutPanel();
            this.btnDodaj = new System.Windows.Forms.Button();
            this.btnIzmeni = new System.Windows.Forms.Button();
            this.btnObrisi = new System.Windows.Forms.Button();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel7 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.txtBrojProdatih = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBoxNazivFilma = new System.Windows.Forms.ComboBox();
            this.comboBoxNazivSale = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtVreme = new System.Windows.Forms.TextBox();
            this.txtDatumOdrzavanja = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.BrojSedista = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IdKarte = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewKarte)).BeginInit();
            this.tableLayoutPanel6.SuspendLayout();
            this.tableLayoutPanel5.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridViewKarte
            // 
            this.dataGridViewKarte.AllowUserToAddRows = false;
            this.dataGridViewKarte.AllowUserToDeleteRows = false;
            this.dataGridViewKarte.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewKarte.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.NazivFilma,
            this.NazivSale,
            this.DatumOdrzavanja,
            this.VremeOdrzavanja,
            this.BrojProdatih,
            this.Kapacitet});
            this.dataGridViewKarte.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewKarte.Location = new System.Drawing.Point(3, 3);
            this.dataGridViewKarte.Name = "dataGridViewKarte";
            this.dataGridViewKarte.ReadOnly = true;
            this.dataGridViewKarte.RowHeadersWidth = 51;
            this.dataGridViewKarte.Size = new System.Drawing.Size(792, 546);
            this.dataGridViewKarte.TabIndex = 0;
            this.dataGridViewKarte.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewKarte_CellClick);
            // 
            // NazivFilma
            // 
            this.NazivFilma.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.NazivFilma.HeaderText = "Naziv filma";
            this.NazivFilma.MinimumWidth = 6;
            this.NazivFilma.Name = "NazivFilma";
            this.NazivFilma.ReadOnly = true;
            // 
            // NazivSale
            // 
            this.NazivSale.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.NazivSale.HeaderText = "Naziv sale";
            this.NazivSale.MinimumWidth = 6;
            this.NazivSale.Name = "NazivSale";
            this.NazivSale.ReadOnly = true;
            // 
            // DatumOdrzavanja
            // 
            this.DatumOdrzavanja.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.DatumOdrzavanja.HeaderText = "Datum odrzavanja";
            this.DatumOdrzavanja.MinimumWidth = 6;
            this.DatumOdrzavanja.Name = "DatumOdrzavanja";
            this.DatumOdrzavanja.ReadOnly = true;
            // 
            // VremeOdrzavanja
            // 
            this.VremeOdrzavanja.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.VremeOdrzavanja.HeaderText = "Vreme odrzavanja";
            this.VremeOdrzavanja.MinimumWidth = 6;
            this.VremeOdrzavanja.Name = "VremeOdrzavanja";
            this.VremeOdrzavanja.ReadOnly = true;
            // 
            // BrojProdatih
            // 
            this.BrojProdatih.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.BrojProdatih.HeaderText = "Broj prodatih karata";
            this.BrojProdatih.MinimumWidth = 6;
            this.BrojProdatih.Name = "BrojProdatih";
            this.BrojProdatih.ReadOnly = true;
            // 
            // Kapacitet
            // 
            this.Kapacitet.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Kapacitet.HeaderText = "Kapacitet sale";
            this.Kapacitet.MinimumWidth = 6;
            this.Kapacitet.Name = "Kapacitet";
            this.Kapacitet.ReadOnly = true;
            // 
            // tableLayoutPanel6
            // 
            this.tableLayoutPanel6.ColumnCount = 1;
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel6.Controls.Add(this.dataGridViewKarte, 0, 0);
            this.tableLayoutPanel6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel6.Location = new System.Drawing.Point(3, 44);
            this.tableLayoutPanel6.Name = "tableLayoutPanel6";
            this.tableLayoutPanel6.RowCount = 1;
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel6.Size = new System.Drawing.Size(798, 552);
            this.tableLayoutPanel6.TabIndex = 0;
            // 
            // tableLayoutPanel5
            // 
            this.tableLayoutPanel5.ColumnCount = 4;
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20.004F));
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 26.66533F));
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 26.66533F));
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 26.66533F));
            this.tableLayoutPanel5.Controls.Add(this.btnDodaj, 1, 0);
            this.tableLayoutPanel5.Controls.Add(this.btnIzmeni, 2, 0);
            this.tableLayoutPanel5.Controls.Add(this.btnObrisi, 3, 0);
            this.tableLayoutPanel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel5.Location = new System.Drawing.Point(3, 414);
            this.tableLayoutPanel5.Name = "tableLayoutPanel5";
            this.tableLayoutPanel5.RowCount = 2;
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 23.4375F));
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 76.5625F));
            this.tableLayoutPanel5.Size = new System.Drawing.Size(201, 182);
            this.tableLayoutPanel5.TabIndex = 1;
            // 
            // btnDodaj
            // 
            this.btnDodaj.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDodaj.Location = new System.Drawing.Point(43, 6);
            this.btnDodaj.Name = "btnDodaj";
            this.btnDodaj.Size = new System.Drawing.Size(47, 29);
            this.btnDodaj.TabIndex = 1;
            this.btnDodaj.Text = "Dodaj";
            this.btnDodaj.UseVisualStyleBackColor = true;
            this.btnDodaj.Click += new System.EventHandler(this.btnDodaj_Click);
            // 
            // btnIzmeni
            // 
            this.btnIzmeni.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.btnIzmeni.Location = new System.Drawing.Point(96, 6);
            this.btnIzmeni.Name = "btnIzmeni";
            this.btnIzmeni.Size = new System.Drawing.Size(47, 29);
            this.btnIzmeni.TabIndex = 2;
            this.btnIzmeni.Text = "Izmeni";
            this.btnIzmeni.UseVisualStyleBackColor = true;
            this.btnIzmeni.Click += new System.EventHandler(this.btnIzmeni_Click);
            // 
            // btnObrisi
            // 
            this.btnObrisi.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.btnObrisi.Location = new System.Drawing.Point(149, 6);
            this.btnObrisi.Name = "btnObrisi";
            this.btnObrisi.Size = new System.Drawing.Size(49, 29);
            this.btnObrisi.TabIndex = 3;
            this.btnObrisi.Text = "Obrisi";
            this.btnObrisi.UseVisualStyleBackColor = true;
            this.btnObrisi.Click += new System.EventHandler(this.btnObrisi_Click);
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Controls.Add(this.tableLayoutPanel6, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.tableLayoutPanel7, 0, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(216, 3);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 2;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6.864275F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 93.13573F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(804, 599);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // tableLayoutPanel7
            // 
            this.tableLayoutPanel7.ColumnCount = 5;
            this.tableLayoutPanel7.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tableLayoutPanel7.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tableLayoutPanel7.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tableLayoutPanel7.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel7.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel7.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel7.Name = "tableLayoutPanel7";
            this.tableLayoutPanel7.RowCount = 1;
            this.tableLayoutPanel7.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel7.Size = new System.Drawing.Size(798, 35);
            this.tableLayoutPanel7.TabIndex = 1;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 1;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.Controls.Add(this.tableLayoutPanel4, 0, 1);
            this.tableLayoutPanel3.Controls.Add(this.tableLayoutPanel5, 0, 2);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 3;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6.208698F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 62.51018F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 31.28113F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(207, 599);
            this.tableLayoutPanel3.TabIndex = 1;
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.ColumnCount = 3;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 17.14286F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 37.61905F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 45F));
            this.tableLayoutPanel4.Controls.Add(this.txtBrojProdatih, 2, 4);
            this.tableLayoutPanel4.Controls.Add(this.label2, 1, 0);
            this.tableLayoutPanel4.Controls.Add(this.comboBoxNazivFilma, 2, 0);
            this.tableLayoutPanel4.Controls.Add(this.comboBoxNazivSale, 2, 1);
            this.tableLayoutPanel4.Controls.Add(this.label3, 1, 1);
            this.tableLayoutPanel4.Controls.Add(this.label7, 1, 2);
            this.tableLayoutPanel4.Controls.Add(this.label5, 1, 4);
            this.tableLayoutPanel4.Controls.Add(this.label1, 1, 3);
            this.tableLayoutPanel4.Controls.Add(this.txtVreme, 2, 3);
            this.tableLayoutPanel4.Controls.Add(this.txtDatumOdrzavanja, 2, 2);
            this.tableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel4.Location = new System.Drawing.Point(3, 40);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 6;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(201, 368);
            this.tableLayoutPanel4.TabIndex = 0;
            // 
            // txtBrojProdatih
            // 
            this.txtBrojProdatih.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtBrojProdatih.Location = new System.Drawing.Point(112, 261);
            this.txtBrojProdatih.Name = "txtBrojProdatih";
            this.txtBrojProdatih.Size = new System.Drawing.Size(86, 27);
            this.txtBrojProdatih.TabIndex = 13;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(37, 10);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 40);
            this.label2.TabIndex = 1;
            this.label2.Text = "Naziv filma *";
            // 
            // comboBoxNazivFilma
            // 
            this.comboBoxNazivFilma.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBoxNazivFilma.FormattingEnabled = true;
            this.comboBoxNazivFilma.Location = new System.Drawing.Point(112, 16);
            this.comboBoxNazivFilma.Name = "comboBoxNazivFilma";
            this.comboBoxNazivFilma.Size = new System.Drawing.Size(86, 28);
            this.comboBoxNazivFilma.TabIndex = 12;
            // 
            // comboBoxNazivSale
            // 
            this.comboBoxNazivSale.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBoxNazivSale.FormattingEnabled = true;
            this.comboBoxNazivSale.Location = new System.Drawing.Point(112, 77);
            this.comboBoxNazivSale.Name = "comboBoxNazivSale";
            this.comboBoxNazivSale.Size = new System.Drawing.Size(86, 28);
            this.comboBoxNazivSale.TabIndex = 11;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(37, 71);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 40);
            this.label3.TabIndex = 2;
            this.label3.Text = "Naziv sale*";
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(37, 122);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(62, 60);
            this.label7.TabIndex = 8;
            this.label7.Text = "Datum odrzavanja *";
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(37, 244);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(66, 60);
            this.label5.TabIndex = 6;
            this.label5.Text = "Broj prodatih karata*";
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(37, 183);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 60);
            this.label1.TabIndex = 14;
            this.label1.Text = "Vreme odrzavanja*";
            // 
            // txtVreme
            // 
            this.txtVreme.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtVreme.Location = new System.Drawing.Point(112, 200);
            this.txtVreme.Name = "txtVreme";
            this.txtVreme.Size = new System.Drawing.Size(86, 27);
            this.txtVreme.TabIndex = 15;
            // 
            // txtDatumOdrzavanja
            // 
            this.txtDatumOdrzavanja.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtDatumOdrzavanja.Location = new System.Drawing.Point(112, 139);
            this.txtDatumOdrzavanja.Name = "txtDatumOdrzavanja";
            this.txtDatumOdrzavanja.Size = new System.Drawing.Size(86, 27);
            this.txtDatumOdrzavanja.TabIndex = 16;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20.90909F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 79.09091F));
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel3, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1023, 605);
            this.tableLayoutPanel1.TabIndex = 2;
            // 
            // BrojSedista
            // 
            this.BrojSedista.HeaderText = "BrojSedista";
            this.BrojSedista.MinimumWidth = 6;
            this.BrojSedista.Name = "BrojSedista";
            this.BrojSedista.Width = 125;
            // 
            // IdKarte
            // 
            this.IdKarte.HeaderText = "IdKarte";
            this.IdKarte.MinimumWidth = 6;
            this.IdKarte.Name = "IdKarte";
            this.IdKarte.Width = 125;
            // 
            // PrikazivanjeFilma
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "PrikazivanjeFilma";
            this.Size = new System.Drawing.Size(1023, 605);
            this.Load += new System.EventHandler(this.PrikazivanjeFilma_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewKarte)).EndInit();
            this.tableLayoutPanel6.ResumeLayout(false);
            this.tableLayoutPanel5.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel4.ResumeLayout(false);
            this.tableLayoutPanel4.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewKarte;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel6;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel5;
        private System.Windows.Forms.Button btnDodaj;
        private System.Windows.Forms.Button btnIzmeni;
        private System.Windows.Forms.Button btnObrisi;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel7;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox comboBoxNazivSale;
        private System.Windows.Forms.ComboBox comboBoxNazivFilma;
        private System.Windows.Forms.TextBox txtBrojProdatih;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.DataGridViewTextBoxColumn BrojSedista;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdKarte;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtVreme;
        private System.Windows.Forms.DataGridViewTextBoxColumn NazivFilma;
        private System.Windows.Forms.DataGridViewTextBoxColumn NazivSale;
        private System.Windows.Forms.DataGridViewTextBoxColumn DatumOdrzavanja;
        private System.Windows.Forms.DataGridViewTextBoxColumn VremeOdrzavanja;
        private System.Windows.Forms.DataGridViewTextBoxColumn BrojProdatih;
        private System.Windows.Forms.DataGridViewTextBoxColumn Kapacitet;
        private System.Windows.Forms.TextBox txtDatumOdrzavanja;
    }
}
