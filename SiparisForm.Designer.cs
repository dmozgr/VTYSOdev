
namespace odev
{
    partial class SiparisForm
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
            this.Musteri = new System.Windows.Forms.Button();
            this.Siparis = new System.Windows.Forms.Button();
            this.Kisi = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnGuncelle = new System.Windows.Forms.Button();
            this.btnSil = new System.Windows.Forms.Button();
            this.btnEkle = new System.Windows.Forms.Button();
            this.siparisNo = new System.Windows.Forms.Label();
            this.txtSiparisno = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtSiparistarih = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtFatura = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtPcb = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtKargo = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // Musteri
            // 
            this.Musteri.BackColor = System.Drawing.Color.DarkOrange;
            this.Musteri.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.Musteri.Location = new System.Drawing.Point(460, 12);
            this.Musteri.Name = "Musteri";
            this.Musteri.Size = new System.Drawing.Size(93, 31);
            this.Musteri.TabIndex = 5;
            this.Musteri.Text = "Musteri";
            this.Musteri.UseVisualStyleBackColor = false;
            this.Musteri.Click += new System.EventHandler(this.Musteri_Click);
            // 
            // Siparis
            // 
            this.Siparis.BackColor = System.Drawing.Color.DarkOrange;
            this.Siparis.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.Siparis.Location = new System.Drawing.Point(335, 12);
            this.Siparis.Name = "Siparis";
            this.Siparis.Size = new System.Drawing.Size(93, 31);
            this.Siparis.TabIndex = 4;
            this.Siparis.Text = "Siparis";
            this.Siparis.UseVisualStyleBackColor = false;
            // 
            // Kisi
            // 
            this.Kisi.BackColor = System.Drawing.Color.DarkOrange;
            this.Kisi.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.Kisi.Location = new System.Drawing.Point(214, 12);
            this.Kisi.Name = "Kisi";
            this.Kisi.Size = new System.Drawing.Size(93, 31);
            this.Kisi.TabIndex = 3;
            this.Kisi.Text = "Kisi";
            this.Kisi.UseVisualStyleBackColor = false;
            this.Kisi.Click += new System.EventHandler(this.Kisi_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(96, 356);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 29;
            this.dataGridView1.Size = new System.Drawing.Size(674, 332);
            this.dataGridView1.TabIndex = 13;
            // 
            // btnGuncelle
            // 
            this.btnGuncelle.Font = new System.Drawing.Font("Segoe UI", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.btnGuncelle.Location = new System.Drawing.Point(83, 190);
            this.btnGuncelle.Name = "btnGuncelle";
            this.btnGuncelle.Size = new System.Drawing.Size(106, 29);
            this.btnGuncelle.TabIndex = 12;
            this.btnGuncelle.Text = "GUNCELLE";
            this.btnGuncelle.UseVisualStyleBackColor = true;
            this.btnGuncelle.Click += new System.EventHandler(this.btnGuncelle_Click);
            // 
            // btnSil
            // 
            this.btnSil.Font = new System.Drawing.Font("Segoe UI", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.btnSil.Location = new System.Drawing.Point(83, 139);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(106, 29);
            this.btnSil.TabIndex = 11;
            this.btnSil.Text = "SİL";
            this.btnSil.UseVisualStyleBackColor = true;
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
            // 
            // btnEkle
            // 
            this.btnEkle.Font = new System.Drawing.Font("Segoe UI", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.btnEkle.Location = new System.Drawing.Point(83, 86);
            this.btnEkle.Name = "btnEkle";
            this.btnEkle.Size = new System.Drawing.Size(106, 29);
            this.btnEkle.TabIndex = 10;
            this.btnEkle.Text = "EKLE";
            this.btnEkle.UseVisualStyleBackColor = true;
            this.btnEkle.Click += new System.EventHandler(this.btnEkle_Click);
            // 
            // siparisNo
            // 
            this.siparisNo.AutoSize = true;
            this.siparisNo.BackColor = System.Drawing.Color.Transparent;
            this.siparisNo.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.siparisNo.Location = new System.Drawing.Point(271, 117);
            this.siparisNo.Name = "siparisNo";
            this.siparisNo.Size = new System.Drawing.Size(75, 20);
            this.siparisNo.TabIndex = 17;
            this.siparisNo.Text = "siparisNo";
            // 
            // txtSiparisno
            // 
            this.txtSiparisno.Location = new System.Drawing.Point(460, 114);
            this.txtSiparisno.Name = "txtSiparisno";
            this.txtSiparisno.Size = new System.Drawing.Size(125, 27);
            this.txtSiparisno.TabIndex = 16;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(271, 156);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 20);
            this.label2.TabIndex = 19;
            this.label2.Text = "siparisTarihi";
            // 
            // txtSiparistarih
            // 
            this.txtSiparistarih.Location = new System.Drawing.Point(460, 156);
            this.txtSiparistarih.Name = "txtSiparistarih";
            this.txtSiparistarih.Size = new System.Drawing.Size(125, 27);
            this.txtSiparistarih.TabIndex = 18;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(271, 199);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 20);
            this.label3.TabIndex = 21;
            this.label3.Text = "fatura";
            // 
            // txtFatura
            // 
            this.txtFatura.Location = new System.Drawing.Point(460, 199);
            this.txtFatura.Name = "txtFatura";
            this.txtFatura.Size = new System.Drawing.Size(125, 27);
            this.txtFatura.TabIndex = 20;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(271, 243);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(34, 20);
            this.label4.TabIndex = 23;
            this.label4.Text = "pcb";
            // 
            // txtPcb
            // 
            this.txtPcb.Location = new System.Drawing.Point(460, 243);
            this.txtPcb.Name = "txtPcb";
            this.txtPcb.Size = new System.Drawing.Size(125, 27);
            this.txtPcb.TabIndex = 22;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(271, 286);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(87, 20);
            this.label5.TabIndex = 25;
            this.label5.Text = "kargofirma";
            // 
            // txtKargo
            // 
            this.txtKargo.Location = new System.Drawing.Point(460, 286);
            this.txtKargo.Name = "txtKargo";
            this.txtKargo.Size = new System.Drawing.Size(125, 27);
            this.txtKargo.TabIndex = 24;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Segoe UI", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.button1.Location = new System.Drawing.Point(82, 283);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(107, 29);
            this.button1.TabIndex = 27;
            this.button1.Text = "LİSTELE";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Segoe UI", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.button2.Location = new System.Drawing.Point(82, 234);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(107, 29);
            this.button2.TabIndex = 26;
            this.button2.Text = "ARA";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // SiparisForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(882, 753);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtKargo);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtPcb);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtFatura);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtSiparistarih);
            this.Controls.Add(this.siparisNo);
            this.Controls.Add(this.txtSiparisno);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnGuncelle);
            this.Controls.Add(this.btnSil);
            this.Controls.Add(this.btnEkle);
            this.Controls.Add(this.Musteri);
            this.Controls.Add(this.Siparis);
            this.Controls.Add(this.Kisi);
            this.Name = "SiparisForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Musteri;
        private System.Windows.Forms.Button Siparis;
        private System.Windows.Forms.Button Kisi;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnGuncelle;
        private System.Windows.Forms.Button btnSil;
        private System.Windows.Forms.Button btnEkle;
        private System.Windows.Forms.Label siparisNo;
        private System.Windows.Forms.TextBox txtSiparisno;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtSiparistarih;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtFatura;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtPcb;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtKargo;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}