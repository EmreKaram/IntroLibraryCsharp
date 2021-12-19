
namespace _009_Date_Time_Metodlari
{
    partial class Time
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
            this.label1 = new System.Windows.Forms.Label();
            this.btn_DateTime = new System.Windows.Forms.Button();
            this.btn_TimeSpan = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(34, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Time";
            // 
            // btn_DateTime
            // 
            this.btn_DateTime.Location = new System.Drawing.Point(29, 61);
            this.btn_DateTime.Name = "btn_DateTime";
            this.btn_DateTime.Size = new System.Drawing.Size(75, 45);
            this.btn_DateTime.TabIndex = 1;
            this.btn_DateTime.Text = "Date Time";
            this.btn_DateTime.UseVisualStyleBackColor = true;
            this.btn_DateTime.Click += new System.EventHandler(this.btn_DateTime_Click);
            // 
            // btn_TimeSpan
            // 
            this.btn_TimeSpan.Location = new System.Drawing.Point(29, 112);
            this.btn_TimeSpan.Name = "btn_TimeSpan";
            this.btn_TimeSpan.Size = new System.Drawing.Size(75, 45);
            this.btn_TimeSpan.TabIndex = 2;
            this.btn_TimeSpan.Text = "Time Span";
            this.btn_TimeSpan.UseVisualStyleBackColor = true;
            this.btn_TimeSpan.Click += new System.EventHandler(this.btn_TimeSpan_Click);
            // 
            // Time
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(138, 188);
            this.Controls.Add(this.btn_TimeSpan);
            this.Controls.Add(this.btn_DateTime);
            this.Controls.Add(this.label1);
            this.Name = "Time";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_DateTime;
        private System.Windows.Forms.Button btn_TimeSpan;
    }
}

