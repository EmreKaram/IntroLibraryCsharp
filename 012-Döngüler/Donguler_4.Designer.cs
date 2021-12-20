
namespace _012_Döngüler
{
    partial class Donguler_4
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
            this.btn_OrnekBir = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // btn_OrnekBir
            // 
            this.btn_OrnekBir.Location = new System.Drawing.Point(7, 12);
            this.btn_OrnekBir.Name = "btn_OrnekBir";
            this.btn_OrnekBir.Size = new System.Drawing.Size(75, 160);
            this.btn_OrnekBir.TabIndex = 0;
            this.btn_OrnekBir.Text = "Ornek";
            this.btn_OrnekBir.UseVisualStyleBackColor = true;
            this.btn_OrnekBir.Click += new System.EventHandler(this.btn_OrnekBir_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(88, 12);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(178, 160);
            this.listBox1.TabIndex = 1;
            // 
            // Donguler_4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 193);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.btn_OrnekBir);
            this.Name = "Donguler_4";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_OrnekBir;
        private System.Windows.Forms.ListBox listBox1;
    }
}