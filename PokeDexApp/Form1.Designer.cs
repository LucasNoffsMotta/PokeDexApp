namespace PokeDexApp
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
            lblName = new Label();
            lblTypeOne = new Label();
            lblTypeTwo = new Label();
            btnNext = new Button();
            btnPrev = new Button();
            lblNumber = new Label();
            lblLbl = new Label();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.Font = new Font("Arial Black", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblName.Location = new Point(465, 80);
            lblName.Name = "lblName";
            lblName.Size = new Size(113, 42);
            lblName.TabIndex = 0;
            lblName.Text = "Name";
            lblName.Click += lblName_Click;
            // 
            // lblTypeOne
            // 
            lblTypeOne.AutoSize = true;
            lblTypeOne.Font = new Font("Arial Black", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTypeOne.Location = new Point(135, 152);
            lblTypeOne.Name = "lblTypeOne";
            lblTypeOne.Size = new Size(162, 42);
            lblTypeOne.TabIndex = 1;
            lblTypeOne.Text = "TypeOne";
            lblTypeOne.Click += lblTypeOne_Click;
            // 
            // lblTypeTwo
            // 
            lblTypeTwo.AutoSize = true;
            lblTypeTwo.Font = new Font("Arial Black", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTypeTwo.Location = new Point(788, 152);
            lblTypeTwo.Name = "lblTypeTwo";
            lblTypeTwo.Size = new Size(166, 42);
            lblTypeTwo.TabIndex = 2;
            lblTypeTwo.Text = "TypeTwo";
            // 
            // btnNext
            // 
            btnNext.Location = new Point(570, 730);
            btnNext.Name = "btnNext";
            btnNext.Size = new Size(94, 29);
            btnNext.TabIndex = 3;
            btnNext.Text = "Next";
            btnNext.UseVisualStyleBackColor = true;
            btnNext.Click += btnNext_Click;
            // 
            // btnPrev
            // 
            btnPrev.Location = new Point(430, 730);
            btnPrev.Name = "btnPrev";
            btnPrev.Size = new Size(94, 29);
            btnPrev.TabIndex = 4;
            btnPrev.Text = "Previous";
            btnPrev.UseVisualStyleBackColor = true;
            btnPrev.Click += btnPrev_Click;
            // 
            // lblNumber
            // 
            lblNumber.AutoSize = true;
            lblNumber.FlatStyle = FlatStyle.System;
            lblNumber.Font = new Font("Arial", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblNumber.Location = new Point(461, 27);
            lblNumber.Name = "lblNumber";
            lblNumber.Size = new Size(117, 35);
            lblNumber.TabIndex = 5;
            lblNumber.Text = "number";
            // 
            // lblLbl
            // 
            lblLbl.AutoSize = true;
            lblLbl.FlatStyle = FlatStyle.System;
            lblLbl.Font = new Font("Arial", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblLbl.Location = new Point(405, 27);
            lblLbl.Name = "lblLbl";
            lblLbl.Size = new Size(32, 35);
            lblLbl.TabIndex = 6;
            lblLbl.Text = "#";
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(312, 229);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(125, 62);
            pictureBox1.SizeMode = PictureBoxSizeMode.AutoSize;
            pictureBox1.TabIndex = 7;
            pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1072, 814);
            Controls.Add(pictureBox1);
            Controls.Add(lblLbl);
            Controls.Add(lblNumber);
            Controls.Add(btnPrev);
            Controls.Add(btnNext);
            Controls.Add(lblTypeTwo);
            Controls.Add(lblTypeOne);
            Controls.Add(lblName);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblName;
        private Label lblTypeOne;
        private Label lblTypeTwo;
        private Button btnNext;
        private Button btnPrev;
        private Label lblNumber;
        private Label lblLbl;
        private PictureBox pictureBox1;
    }
}
