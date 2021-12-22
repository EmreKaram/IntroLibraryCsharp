
namespace _027_Timer_App
{
    partial class Timer
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Timer));
            this.imglist = new System.Windows.Forms.ImageList(this.components);
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.btnFirst = new System.Windows.Forms.Button();
            this.btnPrevius = new System.Windows.Forms.Button();
            this.btnLast = new System.Windows.Forms.Button();
            this.btnStartStop = new System.Windows.Forms.Button();
            this.btnNext = new System.Windows.Forms.Button();
            this.pcbResim = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pcbResim)).BeginInit();
            this.SuspendLayout();
            // 
            // imglist
            // 
            this.imglist.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imglist.ImageStream")));
            this.imglist.TransparentColor = System.Drawing.Color.Transparent;
            this.imglist.Images.SetKeyName(0, "Wonderful-Car-Wallpaper.jpeg");
            this.imglist.Images.SetKeyName(1, "techrules-promises-revolutionary-propulsion-system-has-nice-cars-to-show-it_4.jpg" +
        "");
            this.imglist.Images.SetKeyName(2, "c8bcca214e9744aea204d718c058eb2f.jpg");
            this.imglist.Images.SetKeyName(3, "272941-Dodge_Viper-car-sports_car-orange.jpg");
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // btnFirst
            // 
            this.btnFirst.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnFirst.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnFirst.Location = new System.Drawing.Point(12, 317);
            this.btnFirst.Name = "btnFirst";
            this.btnFirst.Size = new System.Drawing.Size(148, 47);
            this.btnFirst.TabIndex = 0;
            this.btnFirst.Text = "|<";
            this.btnFirst.UseVisualStyleBackColor = false;
            this.btnFirst.Click += new System.EventHandler(this.btnFirst_Click);
            // 
            // btnPrevius
            // 
            this.btnPrevius.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnPrevius.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnPrevius.Location = new System.Drawing.Point(166, 317);
            this.btnPrevius.Name = "btnPrevius";
            this.btnPrevius.Size = new System.Drawing.Size(148, 47);
            this.btnPrevius.TabIndex = 1;
            this.btnPrevius.Text = "<<";
            this.btnPrevius.UseVisualStyleBackColor = false;
            this.btnPrevius.Click += new System.EventHandler(this.btnPrevius_Click);
            // 
            // btnLast
            // 
            this.btnLast.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnLast.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnLast.Location = new System.Drawing.Point(628, 317);
            this.btnLast.Name = "btnLast";
            this.btnLast.Size = new System.Drawing.Size(148, 47);
            this.btnLast.TabIndex = 2;
            this.btnLast.Text = ">|";
            this.btnLast.UseVisualStyleBackColor = false;
            this.btnLast.Click += new System.EventHandler(this.btnLast_Click);
            // 
            // btnStartStop
            // 
            this.btnStartStop.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnStartStop.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnStartStop.Location = new System.Drawing.Point(320, 317);
            this.btnStartStop.Name = "btnStartStop";
            this.btnStartStop.Size = new System.Drawing.Size(148, 47);
            this.btnStartStop.TabIndex = 3;
            this.btnStartStop.Text = "Start Stop";
            this.btnStartStop.UseVisualStyleBackColor = false;
            this.btnStartStop.Click += new System.EventHandler(this.btnStartStop_Click);
            // 
            // btnNext
            // 
            this.btnNext.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnNext.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnNext.Location = new System.Drawing.Point(474, 317);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(148, 47);
            this.btnNext.TabIndex = 4;
            this.btnNext.Text = ">>";
            this.btnNext.UseVisualStyleBackColor = false;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // pcbResim
            // 
            this.pcbResim.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.pcbResim.Location = new System.Drawing.Point(12, 12);
            this.pcbResim.Name = "pcbResim";
            this.pcbResim.Size = new System.Drawing.Size(764, 299);
            this.pcbResim.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pcbResim.TabIndex = 5;
            this.pcbResim.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(786, 369);
            this.Controls.Add(this.pcbResim);
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.btnStartStop);
            this.Controls.Add(this.btnLast);
            this.Controls.Add(this.btnPrevius);
            this.Controls.Add(this.btnFirst);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pcbResim)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ImageList imglist;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button btnFirst;
        private System.Windows.Forms.Button btnPrevius;
        private System.Windows.Forms.Button btnLast;
        private System.Windows.Forms.Button btnStartStop;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.PictureBox pcbResim;
    }
}

