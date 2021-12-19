
namespace _008_Switch_Case
{
    partial class Karar
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
            this.btn_Onayla = new System.Windows.Forms.Button();
            this.btn_Kontrol = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txt_GirisAlani
            // 
            this.txt_GirisAlani.Location = new System.Drawing.Point(12, 12);
            this.txt_GirisAlani.Name = "txt_GirisAlani";
            this.txt_GirisAlani.Size = new System.Drawing.Size(152, 20);
            this.txt_GirisAlani.TabIndex = 0;
            // 
            // btn_Onayla
            // 
            this.btn_Onayla.Location = new System.Drawing.Point(13, 44);
            this.btn_Onayla.Name = "btn_Onayla";
            this.btn_Onayla.Size = new System.Drawing.Size(152, 36);
            this.btn_Onayla.TabIndex = 1;
            this.btn_Onayla.Text = "Onayla";
            this.btn_Onayla.UseVisualStyleBackColor = true;
            this.btn_Onayla.Click += new System.EventHandler(this.btn_Onayla_Click);
            // 
            // btn_Kontrol
            // 
            this.btn_Kontrol.Location = new System.Drawing.Point(13, 86);
            this.btn_Kontrol.Name = "btn_Kontrol";
            this.btn_Kontrol.Size = new System.Drawing.Size(151, 36);
            this.btn_Kontrol.TabIndex = 2;
            this.btn_Kontrol.Text = "Kullanici Kontrol";
            this.btn_Kontrol.UseVisualStyleBackColor = true;
            this.btn_Kontrol.Click += new System.EventHandler(this.btn_Kontrol_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(176, 134);
            this.Controls.Add(this.btn_Kontrol);
            this.Controls.Add(this.btn_Onayla);
            this.Controls.Add(this.txt_GirisAlani);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_GirisAlani;
        private System.Windows.Forms.Button btn_Onayla;
        private System.Windows.Forms.Button btn_Kontrol;
    }
}

