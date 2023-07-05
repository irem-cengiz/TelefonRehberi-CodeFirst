namespace TelefonRehberi_CodeFirst
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            groupBox1 = new GroupBox();
            txtTelefon = new TextBox();
            btnGuncelle = new Button();
            txtSoyad = new TextBox();
            txtAd = new TextBox();
            btnRehbereEkle = new Button();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            groupBox2 = new GroupBox();
            txtAdSoyad = new TextBox();
            btnKisiAra = new Button();
            label4 = new Label();
            dgvRehber = new DataGridView();
            label5 = new Label();
            btnSil = new Button();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvRehber).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(txtTelefon);
            groupBox1.Controls.Add(btnGuncelle);
            groupBox1.Controls.Add(txtSoyad);
            groupBox1.Controls.Add(txtAd);
            groupBox1.Controls.Add(btnRehbereEkle);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(373, 188);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "OLUŞTUR VE GÜNCELLE";
            // 
            // txtTelefon
            // 
            txtTelefon.Location = new Point(99, 84);
            txtTelefon.Name = "txtTelefon";
            txtTelefon.Size = new Size(197, 23);
            txtTelefon.TabIndex = 6;
            // 
            // btnGuncelle
            // 
            btnGuncelle.BackColor = Color.PaleGoldenrod;
            btnGuncelle.Location = new Point(99, 155);
            btnGuncelle.Name = "btnGuncelle";
            btnGuncelle.Size = new Size(197, 23);
            btnGuncelle.TabIndex = 2;
            btnGuncelle.Text = "GÜNCELLE";
            btnGuncelle.UseVisualStyleBackColor = false;
            btnGuncelle.Click += btnGuncelle_Click;
            // 
            // txtSoyad
            // 
            txtSoyad.Location = new Point(99, 53);
            txtSoyad.Name = "txtSoyad";
            txtSoyad.Size = new Size(197, 23);
            txtSoyad.TabIndex = 5;
            // 
            // txtAd
            // 
            txtAd.Location = new Point(99, 22);
            txtAd.Name = "txtAd";
            txtAd.Size = new Size(197, 23);
            txtAd.TabIndex = 4;
            // 
            // btnRehbereEkle
            // 
            btnRehbereEkle.BackColor = Color.PaleGoldenrod;
            btnRehbereEkle.Location = new Point(99, 126);
            btnRehbereEkle.Name = "btnRehbereEkle";
            btnRehbereEkle.Size = new Size(197, 23);
            btnRehbereEkle.TabIndex = 3;
            btnRehbereEkle.Text = "REHBERE EKLE";
            btnRehbereEkle.UseVisualStyleBackColor = false;
            btnRehbereEkle.Click += btnRehbereEkle_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(18, 92);
            label3.Name = "label3";
            label3.Size = new Size(48, 15);
            label3.TabIndex = 2;
            label3.Text = "Telefon:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(18, 61);
            label2.Name = "label2";
            label2.Size = new Size(45, 15);
            label2.TabIndex = 1;
            label2.Text = "Soyadı:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(17, 30);
            label1.Name = "label1";
            label1.Size = new Size(28, 15);
            label1.TabIndex = 0;
            label1.Text = "Adı:";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(txtAdSoyad);
            groupBox2.Controls.Add(btnKisiAra);
            groupBox2.Controls.Add(label4);
            groupBox2.Location = new Point(417, 12);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(389, 188);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "BUL";
            // 
            // txtAdSoyad
            // 
            txtAdSoyad.Location = new Point(25, 61);
            txtAdSoyad.Name = "txtAdSoyad";
            txtAdSoyad.Size = new Size(182, 23);
            txtAdSoyad.TabIndex = 3;
            // 
            // btnKisiAra
            // 
            btnKisiAra.BackColor = Color.PaleGoldenrod;
            btnKisiAra.Location = new Point(275, 48);
            btnKisiAra.Name = "btnKisiAra";
            btnKisiAra.Size = new Size(75, 39);
            btnKisiAra.TabIndex = 1;
            btnKisiAra.Text = "KİŞİ ARA";
            btnKisiAra.UseVisualStyleBackColor = false;
            btnKisiAra.Click += btnKisiAra_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(25, 37);
            label4.Name = "label4";
            label4.Size = new Size(93, 15);
            label4.TabIndex = 0;
            label4.Text = "Adı veya Soyadı:";
            // 
            // dgvRehber
            // 
            dgvRehber.AllowUserToAddRows = false;
            dgvRehber.AllowUserToDeleteRows = false;
            dgvRehber.BackgroundColor = SystemColors.Control;
            dgvRehber.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvRehber.Dock = DockStyle.Bottom;
            dgvRehber.GridColor = SystemColors.ButtonHighlight;
            dgvRehber.Location = new Point(0, 239);
            dgvRehber.MultiSelect = false;
            dgvRehber.Name = "dgvRehber";
            dgvRehber.ReadOnly = true;
            dgvRehber.RowTemplate.Height = 25;
            dgvRehber.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvRehber.Size = new Size(818, 228);
            dgvRehber.TabIndex = 2;
            dgvRehber.SelectionChanged += dgvRehber_SelectionChanged_1;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(0, 221);
            label5.Name = "label5";
            label5.Size = new Size(49, 15);
            label5.TabIndex = 3;
            label5.Text = "REHBER";
            // 
            // btnSil
            // 
            btnSil.BackColor = Color.PaleGoldenrod;
            btnSil.Location = new Point(710, 210);
            btnSil.Name = "btnSil";
            btnSil.Size = new Size(96, 23);
            btnSil.TabIndex = 7;
            btnSil.Text = "SİL";
            btnSil.UseVisualStyleBackColor = false;
            btnSil.Click += btnSil_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DarkCyan;
            ClientSize = new Size(818, 467);
            Controls.Add(btnSil);
            Controls.Add(label5);
            Controls.Add(dgvRehber);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "Form1";
            Text = "Telefon Rehberi";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvRehber).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox groupBox1;
        private TextBox txtTelefon;
        private TextBox txtSoyad;
        private TextBox txtAd;
        private Button btnRehbereEkle;
        private Label label3;
        private Label label2;
        private Label label1;
        private GroupBox groupBox2;
        private Button btnGuncelle;
        private Button btnKisiAra;
        private Label label4;
        private DataGridView dgvRehber;
        private Label label5;
        private TextBox txtAdSoyad;
        private Button btnSil;
    }
}