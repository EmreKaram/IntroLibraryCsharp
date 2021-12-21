
namespace _021_Matematiksel_Operatörler
{
    partial class Math
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
            this.btnMod = new System.Windows.Forms.Button();
            this.btnCarpma = new System.Windows.Forms.Button();
            this.btnToplama = new System.Windows.Forms.Button();
            this.btnBirBir = new System.Windows.Forms.Button();
            this.btnBolme = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnMod
            // 
            this.btnMod.Location = new System.Drawing.Point(93, 80);
            this.btnMod.Name = "btnMod";
            this.btnMod.Size = new System.Drawing.Size(75, 62);
            this.btnMod.TabIndex = 0;
            this.btnMod.Text = "Mod Alma";
            this.btnMod.UseVisualStyleBackColor = true;
            this.btnMod.Click += new System.EventHandler(this.btnMod_Click);
            // 
            // btnCarpma
            // 
            this.btnCarpma.Location = new System.Drawing.Point(93, 12);
            this.btnCarpma.Name = "btnCarpma";
            this.btnCarpma.Size = new System.Drawing.Size(75, 62);
            this.btnCarpma.TabIndex = 1;
            this.btnCarpma.Text = "Carpma";
            this.btnCarpma.UseVisualStyleBackColor = true;
            this.btnCarpma.Click += new System.EventHandler(this.btnCarpma_Click);
            // 
            // btnToplama
            // 
            this.btnToplama.Location = new System.Drawing.Point(12, 12);
            this.btnToplama.Name = "btnToplama";
            this.btnToplama.Size = new System.Drawing.Size(75, 62);
            this.btnToplama.TabIndex = 2;
            this.btnToplama.Text = "Toplama";
            this.btnToplama.UseVisualStyleBackColor = true;
            this.btnToplama.Click += new System.EventHandler(this.btnToplama_Click);
            // 
            // btnBirBir
            // 
            this.btnBirBir.Location = new System.Drawing.Point(12, 148);
            this.btnBirBir.Name = "btnBirBir";
            this.btnBirBir.Size = new System.Drawing.Size(75, 62);
            this.btnBirBir.TabIndex = 3;
            this.btnBirBir.Text = "Bir Bir Arttır";
            this.btnBirBir.UseVisualStyleBackColor = true;
            this.btnBirBir.Click += new System.EventHandler(this.btnBirBir_Click);
            // 
            // btnBolme
            // 
            this.btnBolme.Location = new System.Drawing.Point(12, 80);
            this.btnBolme.Name = "btnBolme";
            this.btnBolme.Size = new System.Drawing.Size(75, 62);
            this.btnBolme.TabIndex = 4;
            this.btnBolme.Text = "Bolme";
            this.btnBolme.UseVisualStyleBackColor = true;
            this.btnBolme.Click += new System.EventHandler(this.btnBolme_Click);
            // 
            // Math
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(185, 222);
            this.Controls.Add(this.btnBolme);
            this.Controls.Add(this.btnBirBir);
            this.Controls.Add(this.btnToplama);
            this.Controls.Add(this.btnCarpma);
            this.Controls.Add(this.btnMod);
            this.Name = "Math";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Math_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnMod;
        private System.Windows.Forms.Button btnCarpma;
        private System.Windows.Forms.Button btnToplama;
        private System.Windows.Forms.Button btnBirBir;
        private System.Windows.Forms.Button btnBolme;
    }
}

