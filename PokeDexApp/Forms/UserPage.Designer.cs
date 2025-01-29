namespace PokeDexApp
{
    partial class UserPage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserPage));
            btnMyTeams = new Button();
            button1 = new Button();
            button2 = new Button();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // btnMyTeams
            // 
            btnMyTeams.Location = new Point(71, 70);
            btnMyTeams.Name = "btnMyTeams";
            btnMyTeams.Size = new Size(176, 51);
            btnMyTeams.TabIndex = 0;
            btnMyTeams.Text = "My Teams";
            btnMyTeams.UseVisualStyleBackColor = true;
            btnMyTeams.Click += btnMyTeams_Click;
            // 
            // button1
            // 
            button1.Location = new Point(71, 192);
            button1.Name = "button1";
            button1.Size = new Size(176, 51);
            button1.TabIndex = 1;
            button1.Text = "Pokedex";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(71, 311);
            button2.Name = "button2";
            button2.Size = new Size(176, 51);
            button2.TabIndex = 2;
            button2.Text = "Log Out";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(253, 70);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(50, 61);
            pictureBox1.SizeMode = PictureBoxSizeMode.CenterImage;
            pictureBox1.TabIndex = 10;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(253, 192);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(50, 61);
            pictureBox2.SizeMode = PictureBoxSizeMode.CenterImage;
            pictureBox2.TabIndex = 11;
            pictureBox2.TabStop = false;
            // 
            // UserPage
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(btnMyTeams);
            Name = "UserPage";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "UserPage";
            Load += UserPage_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button btnMyTeams;
        private Button button1;
        private Button button2;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
    }
}