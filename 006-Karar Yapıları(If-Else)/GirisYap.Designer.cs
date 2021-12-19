
namespace _006_Karar_Yapıları_If_Else_
{
    partial class GirisYap
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
            this.txt_GirisAlani = new System.Windows.Forms.TextBox();
            this.btn_AdminKontrol = new System.Windows.Forms.Button();
            this.btn_NotKontrol = new System.Windows.Forms.Button();
            this.brn_CiftOrTek = new System.Windows.Forms.Button();
            this.btn_DegerKontrolu = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txt_GirisAlani
            // 
            this.txt_GirisAlani.Location = new System.Drawing.Point(13, 13);
            this.txt_GirisAlani.Name = "txt_GirisAlani";
            this.txt_GirisAlani.Size = new System.Drawing.Size(156, 20);
            this.txt_GirisAlani.TabIndex = 0;
            // 
            // btn_AdminKontrol
            // 
            this.btn_AdminKontrol.Location = new System.Drawing.Point(13, 39);
            this.btn_AdminKontrol.Name = "btn_AdminKontrol";
            this.btn_AdminKontrol.Size = new System.Drawing.Size(156, 65);
            this.btn_AdminKontrol.TabIndex = 1;
            this.btn_AdminKontrol.Text = "Giriş Yap";
            this.btn_AdminKontrol.UseVisualStyleBackColor = true;
            this.btn_AdminKontrol.Click += new System.EventHandler(this.btn_AdminKontrol_Click);
            // 
            // btn_NotKontrol
            // 
            this.btn_NotKontrol.Location = new System.Drawing.Point(13, 110);
            this.btn_NotKontrol.Name = "btn_NotKontrol";
            this.btn_NotKontrol.Size = new System.Drawing.Size(156, 65);
            this.btn_NotKontrol.TabIndex = 2;
            this.btn_NotKontrol.Text = "Not Kontrol";
            this.btn_NotKontrol.UseVisualStyleBackColor = true;
            this.btn_NotKontrol.Click += new System.EventHandler(this.btn_NotKontrol_Click);
            // 
            // brn_CiftOrTek
            // 
            this.brn_CiftOrTek.Location = new System.Drawing.Point(13, 181);
            this.brn_CiftOrTek.Name = "brn_CiftOrTek";
            this.brn_CiftOrTek.Size = new System.Drawing.Size(156, 65);
            this.brn_CiftOrTek.TabIndex = 3;
            this.brn_CiftOrTek.Text = "Çiftmi Tekmi";
            this.brn_CiftOrTek.UseVisualStyleBackColor = true;
            this.brn_CiftOrTek.Click += new System.EventHandler(this.brn_CiftOrTek_Click);
            // 
            // btn_DegerKontrolu
            // 
            this.btn_DegerKontrolu.Location = new System.Drawing.Point(13, 252);
            this.btn_DegerKontrolu.Name = "btn_DegerKontrolu";
            this.btn_DegerKontrolu.Size = new System.Drawing.Size(156, 65);
            this.btn_DegerKontrolu.TabIndex = 4;
            this.btn_DegerKontrolu.Text = "Değer Kontrolü";
            this.btn_DegerKontrolu.UseVisualStyleBackColor = true;
            this.btn_DegerKontrolu.Click += new System.EventHandler(this.btn_DegerKontrolu_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(185, 347);
            this.Controls.Add(this.btn_DegerKontrolu);
            this.Controls.Add(this.brn_CiftOrTek);
            this.Controls.Add(this.btn_NotKontrol);
            this.Controls.Add(this.btn_AdminKontrol);
            this.Controls.Add(this.txt_GirisAlani);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_GirisAlani;
        private System.Windows.Forms.Button btn_AdminKontrol;
        private System.Windows.Forms.Button btn_NotKontrol;
        private System.Windows.Forms.Button brn_CiftOrTek;
        private System.Windows.Forms.Button btn_DegerKontrolu;
    }
}

