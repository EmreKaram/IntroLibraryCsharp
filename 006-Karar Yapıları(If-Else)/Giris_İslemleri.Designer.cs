
namespace _006_Karar_Yapıları_If_Else_
{
    partial class Giris_İslemleri
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
            this.btn_GirisYap = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.lbl_RastgeleKarakterler = new System.Windows.Forms.Label();
            this.lbl_KalanHakkımız = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lbl_KalanHakkımız);
            this.groupBox1.Controls.Add(this.btn_GirisYap);
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Controls.Add(this.lbl_RastgeleKarakterler);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(188, 142);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Giris İşlemleri";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // btn_GirisYap
            // 
            this.btn_GirisYap.Location = new System.Drawing.Point(58, 79);
            this.btn_GirisYap.Name = "btn_GirisYap";
            this.btn_GirisYap.Size = new System.Drawing.Size(100, 23);
            this.btn_GirisYap.TabIndex = 2;
            this.btn_GirisYap.Text = "GirisYap";
            this.btn_GirisYap.UseVisualStyleBackColor = true;
            this.btn_GirisYap.Click += new System.EventHandler(this.btn_GirisYap_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(58, 39);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 1;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // lbl_RastgeleKarakterler
            // 
            this.lbl_RastgeleKarakterler.AutoSize = true;
            this.lbl_RastgeleKarakterler.Location = new System.Drawing.Point(18, 46);
            this.lbl_RastgeleKarakterler.Name = "lbl_RastgeleKarakterler";
            this.lbl_RastgeleKarakterler.Size = new System.Drawing.Size(16, 13);
            this.lbl_RastgeleKarakterler.TabIndex = 0;
            this.lbl_RastgeleKarakterler.Text = "...";
            // 
            // lbl_KalanHakkımız
            // 
            this.lbl_KalanHakkımız.AutoSize = true;
            this.lbl_KalanHakkımız.Location = new System.Drawing.Point(122, 16);
            this.lbl_KalanHakkımız.Name = "lbl_KalanHakkımız";
            this.lbl_KalanHakkımız.Size = new System.Drawing.Size(57, 13);
            this.lbl_KalanHakkımız.TabIndex = 3;
            this.lbl_KalanHakkımız.Text = "Kalan Hak";
            // 
            // Giris_İslemleri
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(225, 177);
            this.Controls.Add(this.groupBox1);
            this.Name = "Giris_İslemleri";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btn_GirisYap;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label lbl_RastgeleKarakterler;
        private System.Windows.Forms.Label lbl_KalanHakkımız;
    }
}