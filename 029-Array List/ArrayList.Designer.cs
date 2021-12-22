
namespace _029_Array_List
{
    partial class ArrayList
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
            this.btnMetod = new System.Windows.Forms.Button();
            this.btnObject = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // btnMetod
            // 
            this.btnMetod.Location = new System.Drawing.Point(12, 12);
            this.btnMetod.Name = "btnMetod";
            this.btnMetod.Size = new System.Drawing.Size(75, 123);
            this.btnMetod.TabIndex = 0;
            this.btnMetod.Text = "Metodlar";
            this.btnMetod.UseVisualStyleBackColor = true;
            this.btnMetod.Click += new System.EventHandler(this.btnMetod_Click);
            // 
            // btnObject
            // 
            this.btnObject.Location = new System.Drawing.Point(12, 153);
            this.btnObject.Name = "btnObject";
            this.btnObject.Size = new System.Drawing.Size(75, 123);
            this.btnObject.TabIndex = 1;
            this.btnObject.Text = "Obje";
            this.btnObject.UseVisualStyleBackColor = true;
            this.btnObject.Click += new System.EventHandler(this.btnObject_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(109, 12);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(338, 264);
            this.listBox1.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(477, 299);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.btnObject);
            this.Controls.Add(this.btnMetod);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnMetod;
        private System.Windows.Forms.Button btnObject;
        private System.Windows.Forms.ListBox listBox1;
    }
}

