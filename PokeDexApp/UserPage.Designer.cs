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
            btnMyTeams = new Button();
            button1 = new Button();
            button2 = new Button();
            SuspendLayout();
            // 
            // btnMyTeams
            // 
            btnMyTeams.Location = new Point(294, 122);
            btnMyTeams.Name = "btnMyTeams";
            btnMyTeams.Size = new Size(176, 51);
            btnMyTeams.TabIndex = 0;
            btnMyTeams.Text = "My Teams";
            btnMyTeams.UseVisualStyleBackColor = true;
            btnMyTeams.Click += btnMyTeams_Click;
            // 
            // button1
            // 
            button1.Location = new Point(294, 198);
            button1.Name = "button1";
            button1.Size = new Size(176, 51);
            button1.TabIndex = 1;
            button1.Text = "Pokedex";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(294, 277);
            button2.Name = "button2";
            button2.Size = new Size(176, 51);
            button2.TabIndex = 2;
            button2.Text = "Log Out";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // UserPage
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(btnMyTeams);
            Name = "UserPage";
            Text = "UserPage";
            ResumeLayout(false);
        }

        #endregion

        private Button btnMyTeams;
        private Button button1;
        private Button button2;
    }
}