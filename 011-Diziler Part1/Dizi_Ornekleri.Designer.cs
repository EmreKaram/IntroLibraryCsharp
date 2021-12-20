
namespace _011_Diziler_Part1
{
    partial class Dizi_Ornekleri
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
            this.btn_En = new System.Windows.Forms.Button();
            this.btn_Kayıtlar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btn_En
            // 
            this.btn_En.Location = new System.Drawing.Point(12, 58);
            this.btn_En.Name = "btn_En";
            this.btn_En.Size = new System.Drawing.Size(75, 78);
            this.btn_En.TabIndex = 0;
            this.btn_En.Text = "En\'ler";
            this.btn_En.UseVisualStyleBackColor = true;
            this.btn_En.Click += new System.EventHandler(this.btn_En_Click);
            // 
            // btn_Kayıtlar
            // 
            this.btn_Kayıtlar.Location = new System.Drawing.Point(12, 153);
            this.btn_Kayıtlar.Name = "btn_Kayıtlar";
            this.btn_Kayıtlar.Size = new System.Drawing.Size(75, 78);
            this.btn_Kayıtlar.TabIndex = 1;
            this.btn_Kayıtlar.Text = "Kayıtlar";
            this.btn_Kayıtlar.UseVisualStyleBackColor = true;
            this.btn_Kayıtlar.Click += new System.EventHandler(this.btn_Kayıtlar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Kayıt Yazınız:";
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(93, 58);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(132, 173);
            this.listBox1.TabIndex = 3;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(93, 16);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(132, 20);
            this.textBox1.TabIndex = 4;
            // 
            // Dizi_Ornekleri
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(237, 245);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_Kayıtlar);
            this.Controls.Add(this.btn_En);
            this.Name = "Dizi_Ornekleri";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_En;
        private System.Windows.Forms.Button btn_Kayıtlar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.TextBox textBox1;
    }
}