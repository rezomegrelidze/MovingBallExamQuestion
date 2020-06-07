namespace MovingBallExamQuestion
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panel1 = new System.Windows.Forms.Panel();
            this.basketball = new System.Windows.Forms.PictureBox();
            this.upPb = new System.Windows.Forms.PictureBox();
            this.leftPb = new System.Windows.Forms.PictureBox();
            this.rightPb = new System.Windows.Forms.PictureBox();
            this.downPb = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.basketball)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.upPb)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.leftPb)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rightPb)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.downPb)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.basketball);
            this.panel1.Location = new System.Drawing.Point(637, 128);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(676, 508);
            this.panel1.TabIndex = 4;
            // 
            // basketball
            // 
            this.basketball.Image = ((System.Drawing.Image)(resources.GetObject("basketball.Image")));
            this.basketball.Location = new System.Drawing.Point(100, 103);
            this.basketball.Name = "basketball";
            this.basketball.Size = new System.Drawing.Size(113, 95);
            this.basketball.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.basketball.TabIndex = 0;
            this.basketball.TabStop = false;
            // 
            // upPb
            // 
            this.upPb.Image = ((System.Drawing.Image)(resources.GetObject("upPb.Image")));
            this.upPb.Location = new System.Drawing.Point(214, 146);
            this.upPb.Name = "upPb";
            this.upPb.Size = new System.Drawing.Size(144, 142);
            this.upPb.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.upPb.TabIndex = 5;
            this.upPb.TabStop = false;
            this.upPb.Click += new System.EventHandler(this.upPb_Click);
            // 
            // leftPb
            // 
            this.leftPb.Image = ((System.Drawing.Image)(resources.GetObject("leftPb.Image")));
            this.leftPb.Location = new System.Drawing.Point(52, 307);
            this.leftPb.Name = "leftPb";
            this.leftPb.Size = new System.Drawing.Size(143, 141);
            this.leftPb.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.leftPb.TabIndex = 6;
            this.leftPb.TabStop = false;
            this.leftPb.Click += new System.EventHandler(this.leftPb_Click);
            // 
            // rightPb
            // 
            this.rightPb.Image = ((System.Drawing.Image)(resources.GetObject("rightPb.Image")));
            this.rightPb.Location = new System.Drawing.Point(375, 305);
            this.rightPb.Name = "rightPb";
            this.rightPb.Size = new System.Drawing.Size(143, 143);
            this.rightPb.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.rightPb.TabIndex = 7;
            this.rightPb.TabStop = false;
            this.rightPb.Click += new System.EventHandler(this.rightPb_Click);
            // 
            // downPb
            // 
            this.downPb.Image = ((System.Drawing.Image)(resources.GetObject("downPb.Image")));
            this.downPb.Location = new System.Drawing.Point(210, 464);
            this.downPb.Name = "downPb";
            this.downPb.Size = new System.Drawing.Size(145, 141);
            this.downPb.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.downPb.TabIndex = 8;
            this.downPb.TabStop = false;
            this.downPb.Click += new System.EventHandler(this.downPb_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1396, 1012);
            this.Controls.Add(this.downPb);
            this.Controls.Add(this.rightPb);
            this.Controls.Add(this.leftPb);
            this.Controls.Add(this.upPb);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.basketball)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.upPb)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.leftPb)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rightPb)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.downPb)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox basketball;
        private System.Windows.Forms.PictureBox upPb;
        private System.Windows.Forms.PictureBox leftPb;
        private System.Windows.Forms.PictureBox rightPb;
        private System.Windows.Forms.PictureBox downPb;
    }
}

