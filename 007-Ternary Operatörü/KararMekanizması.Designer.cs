
namespace _007_Ternary_Operatörü
{
    partial class KararMekanizması
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
            this.btn_Ternary = new System.Windows.Forms.Button();
            this.txt_DegerAl = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btn_Ternary
            // 
            this.btn_Ternary.Location = new System.Drawing.Point(133, 10);
            this.btn_Ternary.Name = "btn_Ternary";
            this.btn_Ternary.Size = new System.Drawing.Size(75, 23);
            this.btn_Ternary.TabIndex = 1;
            this.btn_Ternary.Text = "Karar Ver";
            this.btn_Ternary.UseVisualStyleBackColor = true;
            this.btn_Ternary.Click += new System.EventHandler(this.btn_Ternary_Click);
            // 
            // txt_DegerAl
            // 
            this.txt_DegerAl.Location = new System.Drawing.Point(13, 13);
            this.txt_DegerAl.Name = "txt_DegerAl";
            this.txt_DegerAl.Size = new System.Drawing.Size(100, 20);
            this.txt_DegerAl.TabIndex = 2;
            // 
            // KararMekanizması
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(221, 49);
            this.Controls.Add(this.txt_DegerAl);
            this.Controls.Add(this.btn_Ternary);
            this.Name = "KararMekanizması";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.KararMekanizması_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_Ternary;
        private System.Windows.Forms.TextBox txt_DegerAl;
    }
}

