
namespace _019_Void_Metodlari
{
    partial class Void
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
            this.btnArkaPlan = new System.Windows.Forms.Button();
            this.btnSaydir = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // btnArkaPlan
            // 
            this.btnArkaPlan.Location = new System.Drawing.Point(12, 191);
            this.btnArkaPlan.Name = "btnArkaPlan";
            this.btnArkaPlan.Size = new System.Drawing.Size(118, 65);
            this.btnArkaPlan.TabIndex = 0;
            this.btnArkaPlan.Text = "Arka Plan";
            this.btnArkaPlan.UseVisualStyleBackColor = true;
            this.btnArkaPlan.Click += new System.EventHandler(this.btnArkaPlan_Click);
            // 
            // btnSaydir
            // 
            this.btnSaydir.Location = new System.Drawing.Point(139, 191);
            this.btnSaydir.Name = "btnSaydir";
            this.btnSaydir.Size = new System.Drawing.Size(118, 65);
            this.btnSaydir.TabIndex = 1;
            this.btnSaydir.Text = "Saydir";
            this.btnSaydir.UseVisualStyleBackColor = true;
            this.btnSaydir.Click += new System.EventHandler(this.btnSaydir_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(12, 12);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(245, 173);
            this.listBox1.TabIndex = 2;
            // 
            // Void
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(272, 281);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.btnSaydir);
            this.Controls.Add(this.btnArkaPlan);
            this.Name = "Void";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnArkaPlan;
        private System.Windows.Forms.Button btnSaydir;
        private System.Windows.Forms.ListBox listBox1;
    }
}

