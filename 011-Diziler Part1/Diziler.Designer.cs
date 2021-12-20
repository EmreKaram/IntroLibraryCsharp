
namespace _011_Diziler_Part1
{
    partial class Diziler
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
            this.btn_Ornek = new System.Windows.Forms.Button();
            this.btn_TimeSpan = new System.Windows.Forms.Button();
            this.txt_DegerGir = new System.Windows.Forms.TextBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // btn_Ornek
            // 
            this.btn_Ornek.Location = new System.Drawing.Point(12, 54);
            this.btn_Ornek.Name = "btn_Ornek";
            this.btn_Ornek.Size = new System.Drawing.Size(75, 59);
            this.btn_Ornek.TabIndex = 0;
            this.btn_Ornek.Text = "Ornek";
            this.btn_Ornek.UseVisualStyleBackColor = true;
            this.btn_Ornek.Click += new System.EventHandler(this.btn_Ornek_Click);
            // 
            // btn_TimeSpan
            // 
            this.btn_TimeSpan.Location = new System.Drawing.Point(12, 126);
            this.btn_TimeSpan.Name = "btn_TimeSpan";
            this.btn_TimeSpan.Size = new System.Drawing.Size(75, 59);
            this.btn_TimeSpan.TabIndex = 1;
            this.btn_TimeSpan.Text = "Time Span";
            this.btn_TimeSpan.UseVisualStyleBackColor = true;
            this.btn_TimeSpan.Click += new System.EventHandler(this.btn_TimeSpan_Click);
            // 
            // txt_DegerGir
            // 
            this.txt_DegerGir.Location = new System.Drawing.Point(12, 12);
            this.txt_DegerGir.Name = "txt_DegerGir";
            this.txt_DegerGir.Size = new System.Drawing.Size(206, 20);
            this.txt_DegerGir.TabIndex = 2;
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(93, 54);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(125, 134);
            this.listBox1.TabIndex = 3;
            // 
            // Diziler
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(238, 217);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.txt_DegerGir);
            this.Controls.Add(this.btn_TimeSpan);
            this.Controls.Add(this.btn_Ornek);
            this.Name = "Diziler";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Diziler_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_Ornek;
        private System.Windows.Forms.Button btn_TimeSpan;
        private System.Windows.Forms.TextBox txt_DegerGir;
        private System.Windows.Forms.ListBox listBox1;
    }
}

