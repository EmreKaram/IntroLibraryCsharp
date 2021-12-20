
namespace _012_Do_While
{
    partial class Do_While
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
            this.btn_While = new System.Windows.Forms.Button();
            this.btn_Do_While = new System.Windows.Forms.Button();
            this.btn_While2 = new System.Windows.Forms.Button();
            this.btn_DoWhile2 = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // btn_While
            // 
            this.btn_While.Location = new System.Drawing.Point(12, 12);
            this.btn_While.Name = "btn_While";
            this.btn_While.Size = new System.Drawing.Size(75, 23);
            this.btn_While.TabIndex = 0;
            this.btn_While.Text = "While";
            this.btn_While.UseVisualStyleBackColor = true;
            this.btn_While.Click += new System.EventHandler(this.btn_While_Click);
            // 
            // btn_Do_While
            // 
            this.btn_Do_While.Location = new System.Drawing.Point(12, 41);
            this.btn_Do_While.Name = "btn_Do_While";
            this.btn_Do_While.Size = new System.Drawing.Size(75, 23);
            this.btn_Do_While.TabIndex = 1;
            this.btn_Do_While.Text = "Do While";
            this.btn_Do_While.UseVisualStyleBackColor = true;
            this.btn_Do_While.Click += new System.EventHandler(this.btn_Do_While_Click);
            // 
            // btn_While2
            // 
            this.btn_While2.Location = new System.Drawing.Point(12, 70);
            this.btn_While2.Name = "btn_While2";
            this.btn_While2.Size = new System.Drawing.Size(75, 23);
            this.btn_While2.TabIndex = 2;
            this.btn_While2.Text = "While 2";
            this.btn_While2.UseVisualStyleBackColor = true;
            this.btn_While2.Click += new System.EventHandler(this.btn_While2_Click);
            // 
            // btn_DoWhile2
            // 
            this.btn_DoWhile2.Location = new System.Drawing.Point(12, 99);
            this.btn_DoWhile2.Name = "btn_DoWhile2";
            this.btn_DoWhile2.Size = new System.Drawing.Size(75, 23);
            this.btn_DoWhile2.TabIndex = 3;
            this.btn_DoWhile2.Text = "Do While 2";
            this.btn_DoWhile2.UseVisualStyleBackColor = true;
            this.btn_DoWhile2.Click += new System.EventHandler(this.btn_DoWhile2_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(93, 12);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(159, 108);
            this.listBox1.TabIndex = 4;
            // 
            // Do_While
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(274, 138);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.btn_DoWhile2);
            this.Controls.Add(this.btn_While2);
            this.Controls.Add(this.btn_Do_While);
            this.Controls.Add(this.btn_While);
            this.Name = "Do_While";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_While;
        private System.Windows.Forms.Button btn_Do_While;
        private System.Windows.Forms.Button btn_While2;
        private System.Windows.Forms.Button btn_DoWhile2;
        private System.Windows.Forms.ListBox listBox1;
    }
}

