
namespace _011_Diziler_Part1
{
    partial class Diziler2
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
            this.btn_Ornek2 = new System.Windows.Forms.Button();
            this.btn_Listele = new System.Windows.Forms.Button();
            this.ElemanListele = new System.Windows.Forms.ListBox();
            this.btn_Ornek1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_Ornek2
            // 
            this.btn_Ornek2.Location = new System.Drawing.Point(12, 69);
            this.btn_Ornek2.Name = "btn_Ornek2";
            this.btn_Ornek2.Size = new System.Drawing.Size(75, 59);
            this.btn_Ornek2.TabIndex = 1;
            this.btn_Ornek2.Text = "Ornek2";
            this.btn_Ornek2.UseVisualStyleBackColor = true;
            this.btn_Ornek2.Click += new System.EventHandler(this.btn_Ornek2_Click);
            // 
            // btn_Listele
            // 
            this.btn_Listele.Location = new System.Drawing.Point(12, 134);
            this.btn_Listele.Name = "btn_Listele";
            this.btn_Listele.Size = new System.Drawing.Size(75, 51);
            this.btn_Listele.TabIndex = 2;
            this.btn_Listele.Text = "Listele";
            this.btn_Listele.UseVisualStyleBackColor = true;
            this.btn_Listele.Click += new System.EventHandler(this.btn_Listele_Click);
            // 
            // ElemanListele
            // 
            this.ElemanListele.FormattingEnabled = true;
            this.ElemanListele.Location = new System.Drawing.Point(93, 12);
            this.ElemanListele.Name = "ElemanListele";
            this.ElemanListele.Size = new System.Drawing.Size(174, 173);
            this.ElemanListele.TabIndex = 3;
            // 
            // btn_Ornek1
            // 
            this.btn_Ornek1.Location = new System.Drawing.Point(12, 13);
            this.btn_Ornek1.Name = "btn_Ornek1";
            this.btn_Ornek1.Size = new System.Drawing.Size(75, 50);
            this.btn_Ornek1.TabIndex = 4;
            this.btn_Ornek1.Text = "Ornek1";
            this.btn_Ornek1.UseVisualStyleBackColor = true;
            this.btn_Ornek1.Click += new System.EventHandler(this.btn_Ornek1_Click);
            // 
            // Diziler2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(272, 193);
            this.Controls.Add(this.btn_Ornek1);
            this.Controls.Add(this.ElemanListele);
            this.Controls.Add(this.btn_Listele);
            this.Controls.Add(this.btn_Ornek2);
            this.Name = "Diziler2";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btn_Ornek2;
        private System.Windows.Forms.Button btn_Listele;
        private System.Windows.Forms.ListBox ElemanListele;
        private System.Windows.Forms.Button btn_Ornek1;
    }
}