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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            lblHP = new Label();
            lblATK = new Label();
            lblSPATK = new Label();
            lblDEF = new Label();
            lblSPDEF = new Label();
            lblSPD = new Label();
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
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(34, 263);
            label1.Name = "label1";
            label1.Size = new Size(114, 28);
            label1.TabIndex = 8;
            label1.Text = "Base Stats:";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(74, 322);
            label2.Name = "label2";
            label2.Size = new Size(39, 28);
            label2.TabIndex = 9;
            label2.Text = "HP";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(63, 375);
            label3.Name = "label3";
            label3.Size = new Size(50, 28);
            label3.TabIndex = 10;
            label3.Text = "ATK";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(34, 425);
            label4.Name = "label4";
            label4.Size = new Size(79, 28);
            label4.TabIndex = 11;
            label4.Text = "SP ATK";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(65, 471);
            label5.Name = "label5";
            label5.Size = new Size(48, 28);
            label5.TabIndex = 12;
            label5.Text = "DEF";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(36, 522);
            label6.Name = "label6";
            label6.Size = new Size(77, 28);
            label6.TabIndex = 13;
            label6.Text = "SP DEF";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.Location = new Point(63, 576);
            label7.Name = "label7";
            label7.Size = new Size(50, 28);
            label7.TabIndex = 14;
            label7.Text = "SPD";
            // 
            // lblHP
            // 
            lblHP.AutoSize = true;
            lblHP.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblHP.Location = new Point(135, 322);
            lblHP.Name = "lblHP";
            lblHP.Size = new Size(21, 28);
            lblHP.TabIndex = 15;
            lblHP.Text = "*";
            // 
            // lblATK
            // 
            lblATK.AutoSize = true;
            lblATK.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblATK.Location = new Point(135, 375);
            lblATK.Name = "lblATK";
            lblATK.Size = new Size(21, 28);
            lblATK.TabIndex = 16;
            lblATK.Text = "*";
            // 
            // lblSPATK
            // 
            lblSPATK.AutoSize = true;
            lblSPATK.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblSPATK.Location = new Point(135, 425);
            lblSPATK.Name = "lblSPATK";
            lblSPATK.Size = new Size(21, 28);
            lblSPATK.TabIndex = 17;
            lblSPATK.Text = "*";
            // 
            // lblDEF
            // 
            lblDEF.AutoSize = true;
            lblDEF.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblDEF.Location = new Point(135, 471);
            lblDEF.Name = "lblDEF";
            lblDEF.Size = new Size(21, 28);
            lblDEF.TabIndex = 18;
            lblDEF.Text = "*";
            // 
            // lblSPDEF
            // 
            lblSPDEF.AutoSize = true;
            lblSPDEF.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblSPDEF.Location = new Point(135, 522);
            lblSPDEF.Name = "lblSPDEF";
            lblSPDEF.Size = new Size(21, 28);
            lblSPDEF.TabIndex = 19;
            lblSPDEF.Text = "*";
            // 
            // lblSPD
            // 
            lblSPD.AutoSize = true;
            lblSPD.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblSPD.Location = new Point(135, 576);
            lblSPD.Name = "lblSPD";
            lblSPD.Size = new Size(21, 28);
            lblSPD.TabIndex = 20;
            lblSPD.Text = "*";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1072, 814);
            Controls.Add(lblSPD);
            Controls.Add(lblSPDEF);
            Controls.Add(lblDEF);
            Controls.Add(lblSPATK);
            Controls.Add(lblATK);
            Controls.Add(lblHP);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
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
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label lblHP;
        private Label lblATK;
        private Label lblSPATK;
        private Label lblDEF;
        private Label lblSPDEF;
        private Label lblSPD;
    }
}
