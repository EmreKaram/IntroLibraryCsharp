
namespace _018_TryCatch
{
    partial class Try_Catch
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
            this.btnOnay = new System.Windows.Forms.Button();
            this.btnFinally = new System.Windows.Forms.Button();
            this.btnHataTipler = new System.Windows.Forms.Button();
            this.btnHata = new System.Windows.Forms.Button();
            this.btnDetaylıOnay = new System.Windows.Forms.Button();
            this.txtGirisAlani = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnOnay
            // 
            this.btnOnay.Location = new System.Drawing.Point(12, 39);
            this.btnOnay.Name = "btnOnay";
            this.btnOnay.Size = new System.Drawing.Size(75, 52);
            this.btnOnay.TabIndex = 0;
            this.btnOnay.Text = "Onay";
            this.btnOnay.UseVisualStyleBackColor = true;
            this.btnOnay.Click += new System.EventHandler(this.btnOnay_Click);
            // 
            // btnFinally
            // 
            this.btnFinally.Location = new System.Drawing.Point(93, 97);
            this.btnFinally.Name = "btnFinally";
            this.btnFinally.Size = new System.Drawing.Size(75, 52);
            this.btnFinally.TabIndex = 1;
            this.btnFinally.Text = "Finally";
            this.btnFinally.UseVisualStyleBackColor = true;
            this.btnFinally.Click += new System.EventHandler(this.btnFinally_Click);
            // 
            // btnHataTipler
            // 
            this.btnHataTipler.Location = new System.Drawing.Point(174, 39);
            this.btnHataTipler.Name = "btnHataTipler";
            this.btnHataTipler.Size = new System.Drawing.Size(75, 110);
            this.btnHataTipler.TabIndex = 2;
            this.btnHataTipler.Text = "Hata Tipleri";
            this.btnHataTipler.UseVisualStyleBackColor = true;
            this.btnHataTipler.Click += new System.EventHandler(this.btnHataTipler_Click);
            // 
            // btnHata
            // 
            this.btnHata.Location = new System.Drawing.Point(12, 97);
            this.btnHata.Name = "btnHata";
            this.btnHata.Size = new System.Drawing.Size(75, 52);
            this.btnHata.TabIndex = 3;
            this.btnHata.Text = "Hata Yönetimli";
            this.btnHata.UseVisualStyleBackColor = true;
            this.btnHata.Click += new System.EventHandler(this.btnHata_Click);
            // 
            // btnDetaylıOnay
            // 
            this.btnDetaylıOnay.Location = new System.Drawing.Point(93, 39);
            this.btnDetaylıOnay.Name = "btnDetaylıOnay";
            this.btnDetaylıOnay.Size = new System.Drawing.Size(75, 52);
            this.btnDetaylıOnay.TabIndex = 4;
            this.btnDetaylıOnay.Text = "Detaylı Onay";
            this.btnDetaylıOnay.UseVisualStyleBackColor = true;
            this.btnDetaylıOnay.Click += new System.EventHandler(this.btnDetaylıOnay_Click);
            // 
            // txtGirisAlani
            // 
            this.txtGirisAlani.Location = new System.Drawing.Point(13, 13);
            this.txtGirisAlani.Name = "txtGirisAlani";
            this.txtGirisAlani.Size = new System.Drawing.Size(236, 20);
            this.txtGirisAlani.TabIndex = 5;
            // 
            // Try_Catch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(261, 182);
            this.Controls.Add(this.txtGirisAlani);
            this.Controls.Add(this.btnDetaylıOnay);
            this.Controls.Add(this.btnHata);
            this.Controls.Add(this.btnHataTipler);
            this.Controls.Add(this.btnFinally);
            this.Controls.Add(this.btnOnay);
            this.Name = "Try_Catch";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnOnay;
        private System.Windows.Forms.Button btnFinally;
        private System.Windows.Forms.Button btnHataTipler;
        private System.Windows.Forms.Button btnHata;
        private System.Windows.Forms.Button btnDetaylıOnay;
        private System.Windows.Forms.TextBox txtGirisAlani;
    }
}

