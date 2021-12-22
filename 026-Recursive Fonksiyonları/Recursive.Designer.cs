
namespace _026_Recursive_Fonksiyonları
{
    partial class Recursive
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
            this.btnFak = new System.Windows.Forms.Button();
            this.btnRecursive = new System.Windows.Forms.Button();
            this.btnClean = new System.Windows.Forms.Button();
            this.btnTemizle = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnFak
            // 
            this.btnFak.Location = new System.Drawing.Point(12, 12);
            this.btnFak.Name = "btnFak";
            this.btnFak.Size = new System.Drawing.Size(115, 38);
            this.btnFak.TabIndex = 0;
            this.btnFak.Text = "Faktoriyel";
            this.btnFak.UseVisualStyleBackColor = true;
            this.btnFak.Click += new System.EventHandler(this.btnFak_Click);
            // 
            // btnRecursive
            // 
            this.btnRecursive.Location = new System.Drawing.Point(145, 12);
            this.btnRecursive.Name = "btnRecursive";
            this.btnRecursive.Size = new System.Drawing.Size(115, 38);
            this.btnRecursive.TabIndex = 1;
            this.btnRecursive.Text = "Recursive";
            this.btnRecursive.UseVisualStyleBackColor = true;
            this.btnRecursive.Click += new System.EventHandler(this.btnRecursive_Click);
            // 
            // btnClean
            // 
            this.btnClean.Location = new System.Drawing.Point(12, 181);
            this.btnClean.Name = "btnClean";
            this.btnClean.Size = new System.Drawing.Size(103, 44);
            this.btnClean.TabIndex = 2;
            this.btnClean.Text = "Clean";
            this.btnClean.UseVisualStyleBackColor = true;
            this.btnClean.Click += new System.EventHandler(this.btnClean_Click);
            // 
            // btnTemizle
            // 
            this.btnTemizle.Location = new System.Drawing.Point(157, 181);
            this.btnTemizle.Name = "btnTemizle";
            this.btnTemizle.Size = new System.Drawing.Size(103, 44);
            this.btnTemizle.TabIndex = 3;
            this.btnTemizle.Text = "Temizle";
            this.btnTemizle.UseVisualStyleBackColor = true;
            this.btnTemizle.Click += new System.EventHandler(this.btnTemizle_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Location = new System.Drawing.Point(12, 75);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(248, 100);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(44, 42);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(189, 20);
            this.textBox1.TabIndex = 0;
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Items.AddRange(new object[] {
            "Example explained",
            "Statement 1 sets a variable before the loop starts (int i = 0).",
            "",
            "Statement 2 defines the condition for the loop to run (i must be less than 5). If" +
                " the condition is true, the loop will start over again, if it is false, the loop" +
                " will end.",
            "",
            "Statement 3 increases a value (i++) each time the code block in the loop has been" +
                " executed."});
            this.listBox1.Location = new System.Drawing.Point(284, 12);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(188, 212);
            this.listBox1.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(493, 258);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnTemizle);
            this.Controls.Add(this.btnClean);
            this.Controls.Add(this.btnRecursive);
            this.Controls.Add(this.btnFak);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnFak;
        private System.Windows.Forms.Button btnRecursive;
        private System.Windows.Forms.Button btnClean;
        private System.Windows.Forms.Button btnTemizle;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ListBox listBox1;
    }
}

