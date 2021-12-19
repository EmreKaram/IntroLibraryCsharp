
namespace _010_Array_Metodlar
{
    partial class On
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
            this.btn_Clear = new System.Windows.Forms.Button();
            this.btn_Copy = new System.Windows.Forms.Button();
            this.btn_IndexOf = new System.Windows.Forms.Button();
            this.btn_LastIndexOf = new System.Windows.Forms.Button();
            this.btn_Resize = new System.Windows.Forms.Button();
            this.btn_Sıralama = new System.Windows.Forms.Button();
            this.btn_TersCevir = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btn_Clear
            // 
            this.btn_Clear.Location = new System.Drawing.Point(12, 12);
            this.btn_Clear.Name = "btn_Clear";
            this.btn_Clear.Size = new System.Drawing.Size(75, 59);
            this.btn_Clear.TabIndex = 0;
            this.btn_Clear.Text = "Temizle";
            this.btn_Clear.UseVisualStyleBackColor = true;
            this.btn_Clear.Click += new System.EventHandler(this.btn_Clear_Click);
            // 
            // btn_Copy
            // 
            this.btn_Copy.Location = new System.Drawing.Point(93, 12);
            this.btn_Copy.Name = "btn_Copy";
            this.btn_Copy.Size = new System.Drawing.Size(75, 59);
            this.btn_Copy.TabIndex = 1;
            this.btn_Copy.Text = "Kopyala";
            this.btn_Copy.UseVisualStyleBackColor = true;
            this.btn_Copy.Click += new System.EventHandler(this.btn_Copy_Click);
            // 
            // btn_IndexOf
            // 
            this.btn_IndexOf.Location = new System.Drawing.Point(174, 12);
            this.btn_IndexOf.Name = "btn_IndexOf";
            this.btn_IndexOf.Size = new System.Drawing.Size(75, 59);
            this.btn_IndexOf.TabIndex = 2;
            this.btn_IndexOf.Text = "IndexOf";
            this.btn_IndexOf.UseVisualStyleBackColor = true;
            this.btn_IndexOf.Click += new System.EventHandler(this.btn_IndexOf_Click);
            // 
            // btn_LastIndexOf
            // 
            this.btn_LastIndexOf.Location = new System.Drawing.Point(12, 77);
            this.btn_LastIndexOf.Name = "btn_LastIndexOf";
            this.btn_LastIndexOf.Size = new System.Drawing.Size(75, 59);
            this.btn_LastIndexOf.TabIndex = 3;
            this.btn_LastIndexOf.Text = "LastIndexOf";
            this.btn_LastIndexOf.UseVisualStyleBackColor = true;
            this.btn_LastIndexOf.Click += new System.EventHandler(this.btn_LastIndexOf_Click);
            // 
            // btn_Resize
            // 
            this.btn_Resize.Location = new System.Drawing.Point(93, 77);
            this.btn_Resize.Name = "btn_Resize";
            this.btn_Resize.Size = new System.Drawing.Size(75, 59);
            this.btn_Resize.TabIndex = 4;
            this.btn_Resize.Text = "Resize";
            this.btn_Resize.UseVisualStyleBackColor = true;
            this.btn_Resize.Click += new System.EventHandler(this.btn_Resize_Click);
            // 
            // btn_Sıralama
            // 
            this.btn_Sıralama.Location = new System.Drawing.Point(174, 77);
            this.btn_Sıralama.Name = "btn_Sıralama";
            this.btn_Sıralama.Size = new System.Drawing.Size(75, 59);
            this.btn_Sıralama.TabIndex = 5;
            this.btn_Sıralama.Text = "Sıralama";
            this.btn_Sıralama.UseVisualStyleBackColor = true;
            this.btn_Sıralama.Click += new System.EventHandler(this.btn_Sıralama_Click);
            // 
            // btn_TersCevir
            // 
            this.btn_TersCevir.Location = new System.Drawing.Point(12, 142);
            this.btn_TersCevir.Name = "btn_TersCevir";
            this.btn_TersCevir.Size = new System.Drawing.Size(75, 59);
            this.btn_TersCevir.TabIndex = 6;
            this.btn_TersCevir.Text = "Ters Çevirme";
            this.btn_TersCevir.UseVisualStyleBackColor = true;
            this.btn_TersCevir.Click += new System.EventHandler(this.btn_TersCevir_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(93, 142);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(156, 20);
            this.textBox1.TabIndex = 7;
            // 
            // On
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(265, 219);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.btn_TersCevir);
            this.Controls.Add(this.btn_Sıralama);
            this.Controls.Add(this.btn_Resize);
            this.Controls.Add(this.btn_LastIndexOf);
            this.Controls.Add(this.btn_IndexOf);
            this.Controls.Add(this.btn_Copy);
            this.Controls.Add(this.btn_Clear);
            this.Name = "On";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_Clear;
        private System.Windows.Forms.Button btn_Copy;
        private System.Windows.Forms.Button btn_IndexOf;
        private System.Windows.Forms.Button btn_LastIndexOf;
        private System.Windows.Forms.Button btn_Resize;
        private System.Windows.Forms.Button btn_Sıralama;
        private System.Windows.Forms.Button btn_TersCevir;
        private System.Windows.Forms.TextBox textBox1;
    }
}

