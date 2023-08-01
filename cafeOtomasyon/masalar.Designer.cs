
namespace cafeOtomasyon
{
    partial class masalar
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtMasaAdi = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtMasaHesabi = new System.Windows.Forms.TextBox();
            this.button6 = new System.Windows.Forms.Button();
            this.lblMasaid = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(190, 89);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(598, 349);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellDoubleClick);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(667, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(121, 49);
            this.button1.TabIndex = 7;
            this.button1.Text = "GERİ";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(506, 9);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(121, 75);
            this.button2.TabIndex = 6;
            this.button2.Text = "YENİ MASA EKLE";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(12, 377);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(121, 49);
            this.button3.TabIndex = 3;
            this.button3.Text = "MASAYI SİL";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(379, 11);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(121, 73);
            this.button4.TabIndex = 5;
            this.button4.Text = "MASAYA ÜRÜN EKLE";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(12, 198);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(172, 40);
            this.button5.TabIndex = 2;
            this.button5.Text = "Masayı Düzenle";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(152, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "Giriş Yapılan Kullanıcı: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 89);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "Masa Adı:";
            // 
            // txtMasaAdi
            // 
            this.txtMasaAdi.Location = new System.Drawing.Point(15, 110);
            this.txtMasaAdi.Name = "txtMasaAdi";
            this.txtMasaAdi.Size = new System.Drawing.Size(169, 22);
            this.txtMasaAdi.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 149);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(94, 17);
            this.label3.TabIndex = 4;
            this.label3.Text = "Masa Hesabı:";
            // 
            // txtMasaHesabi
            // 
            this.txtMasaHesabi.Location = new System.Drawing.Point(15, 170);
            this.txtMasaHesabi.Name = "txtMasaHesabi";
            this.txtMasaHesabi.Size = new System.Drawing.Size(169, 22);
            this.txtMasaHesabi.TabIndex = 1;
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(257, 10);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(116, 74);
            this.button6.TabIndex = 4;
            this.button6.Text = "MASA HESABINI KAPAT";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // lblMasaid
            // 
            this.lblMasaid.AutoSize = true;
            this.lblMasaid.Enabled = false;
            this.lblMasaid.Location = new System.Drawing.Point(128, 89);
            this.lblMasaid.Name = "lblMasaid";
            this.lblMasaid.Size = new System.Drawing.Size(46, 17);
            this.lblMasaid.TabIndex = 6;
            this.lblMasaid.Text = "label4";
            this.lblMasaid.Visible = false;
            // 
            // masalar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblMasaid);
            this.Controls.Add(this.txtMasaHesabi);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtMasaAdi);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "masalar";
            this.Text = "masalar";
            this.Load += new System.EventHandler(this.masalar_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtMasaAdi;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtMasaHesabi;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Label lblMasaid;
    }
}