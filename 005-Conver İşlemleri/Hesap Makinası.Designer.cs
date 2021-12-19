
namespace _005_Conver_İşlemleri
{
    partial class Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_BirGelenMetin = new System.Windows.Forms.TextBox();
            this.txt_İkiGelenMetin = new System.Windows.Forms.TextBox();
            this.btn_Toplama = new System.Windows.Forms.Button();
            this.btn_Cıkartma = new System.Windows.Forms.Button();
            this.btn_Carpma = new System.Windows.Forms.Button();
            this.btn_Bolme = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "1.Sayi";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "2.Sayi";
            // 
            // txt_BirGelenMetin
            // 
            this.txt_BirGelenMetin.Location = new System.Drawing.Point(55, 13);
            this.txt_BirGelenMetin.Name = "txt_BirGelenMetin";
            this.txt_BirGelenMetin.Size = new System.Drawing.Size(118, 20);
            this.txt_BirGelenMetin.TabIndex = 2;
            // 
            // txt_İkiGelenMetin
            // 
            this.txt_İkiGelenMetin.Location = new System.Drawing.Point(55, 49);
            this.txt_İkiGelenMetin.Name = "txt_İkiGelenMetin";
            this.txt_İkiGelenMetin.Size = new System.Drawing.Size(118, 20);
            this.txt_İkiGelenMetin.TabIndex = 3;
            // 
            // btn_Toplama
            // 
            this.btn_Toplama.Location = new System.Drawing.Point(16, 86);
            this.btn_Toplama.Name = "btn_Toplama";
            this.btn_Toplama.Size = new System.Drawing.Size(75, 23);
            this.btn_Toplama.TabIndex = 4;
            this.btn_Toplama.Text = "+";
            this.btn_Toplama.UseVisualStyleBackColor = true;
            this.btn_Toplama.Click += new System.EventHandler(this.btn_Toplama_Click);
            // 
            // btn_Cıkartma
            // 
            this.btn_Cıkartma.Location = new System.Drawing.Point(98, 85);
            this.btn_Cıkartma.Name = "btn_Cıkartma";
            this.btn_Cıkartma.Size = new System.Drawing.Size(75, 23);
            this.btn_Cıkartma.TabIndex = 5;
            this.btn_Cıkartma.Text = "-";
            this.btn_Cıkartma.UseVisualStyleBackColor = true;
            this.btn_Cıkartma.Click += new System.EventHandler(this.btn_Cıkartma_Click);
            // 
            // btn_Carpma
            // 
            this.btn_Carpma.Location = new System.Drawing.Point(16, 116);
            this.btn_Carpma.Name = "btn_Carpma";
            this.btn_Carpma.Size = new System.Drawing.Size(75, 23);
            this.btn_Carpma.TabIndex = 6;
            this.btn_Carpma.Text = "*";
            this.btn_Carpma.UseVisualStyleBackColor = true;
            this.btn_Carpma.Click += new System.EventHandler(this.btn_Carpma_Click);
            // 
            // btn_Bolme
            // 
            this.btn_Bolme.Location = new System.Drawing.Point(98, 115);
            this.btn_Bolme.Name = "btn_Bolme";
            this.btn_Bolme.Size = new System.Drawing.Size(75, 23);
            this.btn_Bolme.TabIndex = 7;
            this.btn_Bolme.Text = "/";
            this.btn_Bolme.UseVisualStyleBackColor = true;
            this.btn_Bolme.Click += new System.EventHandler(this.btn_Bolme_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(191, 164);
            this.Controls.Add(this.btn_Bolme);
            this.Controls.Add(this.btn_Carpma);
            this.Controls.Add(this.btn_Cıkartma);
            this.Controls.Add(this.btn_Toplama);
            this.Controls.Add(this.txt_İkiGelenMetin);
            this.Controls.Add(this.txt_BirGelenMetin);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_BirGelenMetin;
        private System.Windows.Forms.TextBox txt_İkiGelenMetin;
        private System.Windows.Forms.Button btn_Toplama;
        private System.Windows.Forms.Button btn_Cıkartma;
        private System.Windows.Forms.Button btn_Carpma;
        private System.Windows.Forms.Button btn_Bolme;
    }
}

