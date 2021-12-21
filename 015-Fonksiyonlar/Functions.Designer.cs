
namespace _015_Fonksiyonlar
{
    partial class Functions
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
            this.btnTopla = new System.Windows.Forms.Button();
            this.btnDegerKontrol = new System.Windows.Forms.Button();
            this.btnAdSoyad = new System.Windows.Forms.Button();
            this.btnKarekok = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.lblDeger = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtAd = new System.Windows.Forms.TextBox();
            this.txtSoyad = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnTopla
            // 
            this.btnTopla.Location = new System.Drawing.Point(12, 12);
            this.btnTopla.Name = "btnTopla";
            this.btnTopla.Size = new System.Drawing.Size(174, 62);
            this.btnTopla.TabIndex = 0;
            this.btnTopla.Text = "Topla";
            this.btnTopla.UseVisualStyleBackColor = true;
            this.btnTopla.Click += new System.EventHandler(this.btnTopla_Click);
            // 
            // btnDegerKontrol
            // 
            this.btnDegerKontrol.Location = new System.Drawing.Point(86, 139);
            this.btnDegerKontrol.Name = "btnDegerKontrol";
            this.btnDegerKontrol.Size = new System.Drawing.Size(100, 45);
            this.btnDegerKontrol.TabIndex = 1;
            this.btnDegerKontrol.Text = "Değer Kontrol";
            this.btnDegerKontrol.UseVisualStyleBackColor = true;
            this.btnDegerKontrol.Click += new System.EventHandler(this.btnDegerKontrol_Click);
            // 
            // btnAdSoyad
            // 
            this.btnAdSoyad.Location = new System.Drawing.Point(247, 88);
            this.btnAdSoyad.Name = "btnAdSoyad";
            this.btnAdSoyad.Size = new System.Drawing.Size(100, 46);
            this.btnAdSoyad.TabIndex = 2;
            this.btnAdSoyad.Text = "Ad Soyad";
            this.btnAdSoyad.UseVisualStyleBackColor = true;
            this.btnAdSoyad.Click += new System.EventHandler(this.btnAdSoyad_Click);
            // 
            // btnKarekok
            // 
            this.btnKarekok.Location = new System.Drawing.Point(247, 150);
            this.btnKarekok.Name = "btnKarekok";
            this.btnKarekok.Size = new System.Drawing.Size(100, 34);
            this.btnKarekok.TabIndex = 3;
            this.btnKarekok.Text = "Karekök";
            this.btnKarekok.UseVisualStyleBackColor = true;
            this.btnKarekok.Click += new System.EventHandler(this.btnKarekok_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(12, 205);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(335, 62);
            this.button5.TabIndex = 4;
            this.button5.Text = "Arka Plan Yakalayıcı";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(86, 95);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 5;
            // 
            // lblDeger
            // 
            this.lblDeger.AutoSize = true;
            this.lblDeger.Location = new System.Drawing.Point(12, 98);
            this.lblDeger.Name = "lblDeger";
            this.lblDeger.Size = new System.Drawing.Size(70, 13);
            this.lblDeger.TabIndex = 6;
            this.lblDeger.Text = "Değer Giriniz:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(206, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(23, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Ad:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(206, 61);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Soyad:";
            // 
            // txtAd
            // 
            this.txtAd.Location = new System.Drawing.Point(247, 12);
            this.txtAd.Name = "txtAd";
            this.txtAd.Size = new System.Drawing.Size(100, 20);
            this.txtAd.TabIndex = 9;
            // 
            // txtSoyad
            // 
            this.txtSoyad.Location = new System.Drawing.Point(247, 54);
            this.txtSoyad.Name = "txtSoyad";
            this.txtSoyad.Size = new System.Drawing.Size(100, 20);
            this.txtSoyad.TabIndex = 10;
            // 
            // Functions
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(371, 294);
            this.Controls.Add(this.txtSoyad);
            this.Controls.Add(this.txtAd);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblDeger);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.btnKarekok);
            this.Controls.Add(this.btnAdSoyad);
            this.Controls.Add(this.btnDegerKontrol);
            this.Controls.Add(this.btnTopla);
            this.Name = "Functions";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnTopla;
        private System.Windows.Forms.Button btnDegerKontrol;
        private System.Windows.Forms.Button btnAdSoyad;
        private System.Windows.Forms.Button btnKarekok;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label lblDeger;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtAd;
        private System.Windows.Forms.TextBox txtSoyad;
    }
}

