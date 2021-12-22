
namespace _027_System_IO
{
    partial class ıo
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
            this.btnDrive = new System.Windows.Forms.Button();
            this.btnOrnek2 = new System.Windows.Forms.Button();
            this.btnFile = new System.Windows.Forms.Button();
            this.btnCreateFile = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnDrive
            // 
            this.btnDrive.Location = new System.Drawing.Point(22, 24);
            this.btnDrive.Name = "btnDrive";
            this.btnDrive.Size = new System.Drawing.Size(75, 67);
            this.btnDrive.TabIndex = 0;
            this.btnDrive.Text = "Drive İnfo";
            this.btnDrive.UseVisualStyleBackColor = true;
            this.btnDrive.Click += new System.EventHandler(this.btnDrive_Click);
            // 
            // btnOrnek2
            // 
            this.btnOrnek2.Location = new System.Drawing.Point(103, 97);
            this.btnOrnek2.Name = "btnOrnek2";
            this.btnOrnek2.Size = new System.Drawing.Size(75, 67);
            this.btnOrnek2.TabIndex = 1;
            this.btnOrnek2.Text = "Ornek 2";
            this.btnOrnek2.UseVisualStyleBackColor = true;
            this.btnOrnek2.Click += new System.EventHandler(this.btnOrnek2_Click);
            // 
            // btnFile
            // 
            this.btnFile.Location = new System.Drawing.Point(22, 97);
            this.btnFile.Name = "btnFile";
            this.btnFile.Size = new System.Drawing.Size(75, 67);
            this.btnFile.TabIndex = 2;
            this.btnFile.Text = "File İşlemleri";
            this.btnFile.UseVisualStyleBackColor = true;
            this.btnFile.Click += new System.EventHandler(this.btnFile_Click);
            // 
            // btnCreateFile
            // 
            this.btnCreateFile.Location = new System.Drawing.Point(103, 24);
            this.btnCreateFile.Name = "btnCreateFile";
            this.btnCreateFile.Size = new System.Drawing.Size(75, 67);
            this.btnCreateFile.TabIndex = 3;
            this.btnCreateFile.Text = "CreateFile";
            this.btnCreateFile.UseVisualStyleBackColor = true;
            this.btnCreateFile.Click += new System.EventHandler(this.btnCreateFile_Click);
            // 
            // ıo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(201, 189);
            this.Controls.Add(this.btnCreateFile);
            this.Controls.Add(this.btnFile);
            this.Controls.Add(this.btnOrnek2);
            this.Controls.Add(this.btnDrive);
            this.Name = "ıo";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnDrive;
        private System.Windows.Forms.Button btnOrnek2;
        private System.Windows.Forms.Button btnFile;
        private System.Windows.Forms.Button btnCreateFile;
    }
}

