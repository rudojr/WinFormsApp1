namespace WinFormsApp1
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            btnLoadImg = new Button();
            btnCompress = new Button();
            domainBlockSize = new DomainUpDown();
            domainThreshHold = new DomainUpDown();
            domainQrate = new DomainUpDown();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(273, 416);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Location = new Point(279, 0);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(271, 416);
            pictureBox2.TabIndex = 1;
            pictureBox2.TabStop = false;
            // 
            // btnLoadImg
            // 
            btnLoadImg.Location = new Point(0, 422);
            btnLoadImg.Name = "btnLoadImg";
            btnLoadImg.Size = new Size(75, 23);
            btnLoadImg.TabIndex = 2;
            btnLoadImg.Text = "Chọn hình";
            btnLoadImg.UseVisualStyleBackColor = true;
            btnLoadImg.Click += btnLoadImg_Click;
            // 
            // btnCompress
            // 
            btnCompress.Location = new Point(475, 422);
            btnCompress.Name = "btnCompress";
            btnCompress.Size = new Size(75, 23);
            btnCompress.TabIndex = 3;
            btnCompress.Text = "Nén";
            btnCompress.UseVisualStyleBackColor = true;
            btnCompress.Click += btnCompress_Click;
            // 
            // domainBlockSize
            // 
            domainBlockSize.Location = new Point(164, 422);
            domainBlockSize.Name = "domainBlockSize";
            domainBlockSize.Size = new Size(56, 23);
            domainBlockSize.TabIndex = 4;
            domainBlockSize.Text = "domainUpDown1";
            // 
            // domainThreshHold
            // 
            domainThreshHold.Location = new Point(300, 422);
            domainThreshHold.Name = "domainThreshHold";
            domainThreshHold.Size = new Size(56, 23);
            domainThreshHold.TabIndex = 5;
            domainThreshHold.Text = "domainUpDown2";
            // 
            // domainQrate
            // 
            domainQrate.Location = new Point(410, 422);
            domainQrate.Name = "domainQrate";
            domainQrate.Size = new Size(59, 23);
            domainQrate.TabIndex = 6;
            domainQrate.Text = "domainUpDown3";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(102, 426);
            label1.Name = "label1";
            label1.Size = new Size(56, 15);
            label1.TabIndex = 7;
            label1.Text = "BlockSize";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(226, 426);
            label2.Name = "label2";
            label2.Size = new Size(68, 15);
            label2.TabIndex = 8;
            label2.Text = "ThreshHold";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(362, 426);
            label3.Name = "label3";
            label3.Size = new Size(42, 15);
            label3.TabIndex = 9;
            label3.Text = "Q.Rate";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(549, 450);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(domainQrate);
            Controls.Add(domainThreshHold);
            Controls.Add(domainBlockSize);
            Controls.Add(btnCompress);
            Controls.Add(btnLoadImg);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private Button btnLoadImg;
        private Button btnCompress;
        private DomainUpDown domainBlockSize;
        private DomainUpDown domainThreshHold;
        private DomainUpDown domainQrate;
        private Label label1;
        private Label label2;
        private Label label3;
    }
}