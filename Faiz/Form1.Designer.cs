
namespace Faiz
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
            this.btnCalistir = new System.Windows.Forms.Button();
            this.txtGun = new System.Windows.Forms.TextBox();
            this.txtPara = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnCalistir
            // 
            this.btnCalistir.Location = new System.Drawing.Point(51, 75);
            this.btnCalistir.Name = "btnCalistir";
            this.btnCalistir.Size = new System.Drawing.Size(100, 23);
            this.btnCalistir.TabIndex = 0;
            this.btnCalistir.Text = "Çalıştır";
            this.btnCalistir.UseVisualStyleBackColor = true;
            this.btnCalistir.Click += new System.EventHandler(this.btnCalistir_Click);
            // 
            // txtGun
            // 
            this.txtGun.Location = new System.Drawing.Point(51, 12);
            this.txtGun.Name = "txtGun";
            this.txtGun.Size = new System.Drawing.Size(100, 20);
            this.txtGun.TabIndex = 1;
            // 
            // txtPara
            // 
            this.txtPara.Location = new System.Drawing.Point(51, 39);
            this.txtPara.Name = "txtPara";
            this.txtPara.Size = new System.Drawing.Size(100, 20);
            this.txtPara.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(16, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "yil";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Para";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(250, 142);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtPara);
            this.Controls.Add(this.txtGun);
            this.Controls.Add(this.btnCalistir);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCalistir;
        private System.Windows.Forms.TextBox txtGun;
        private System.Windows.Forms.TextBox txtPara;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}

