namespace PokeDexApp
{
    partial class UserTeams
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
            lblTitle = new Label();
            btnAddTeam = new Button();
            btnPoke1 = new Button();
            button1 = new Button();
            button2 = new Button();
            SuspendLayout();
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI", 22.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblTitle.Location = new Point(33, 28);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(107, 50);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "Team";
            // 
            // btnAddTeam
            // 
            btnAddTeam.Location = new Point(585, 387);
            btnAddTeam.Name = "btnAddTeam";
            btnAddTeam.Size = new Size(203, 41);
            btnAddTeam.TabIndex = 1;
            btnAddTeam.Text = "Add Pokemon";
            btnAddTeam.UseVisualStyleBackColor = true;
            btnAddTeam.Click += btnAddTeam_Click;
            // 
            // btnPoke1
            // 
            btnPoke1.Location = new Point(46, 121);
            btnPoke1.Name = "btnPoke1";
            btnPoke1.Size = new Size(94, 29);
            btnPoke1.TabIndex = 2;
            btnPoke1.Text = "Poke One";
            btnPoke1.UseVisualStyleBackColor = true;
            btnPoke1.Click += btnPoke1_Click;
            // 
            // button1
            // 
            button1.Location = new Point(222, 121);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 3;
            button1.Text = "Poke Two";
            button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Location = new Point(399, 121);
            button2.Name = "button2";
            button2.Size = new Size(94, 29);
            button2.TabIndex = 4;
            button2.Text = "Poke Three";
            button2.UseVisualStyleBackColor = true;
            // 
            // UserTeams
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(btnPoke1);
            Controls.Add(btnAddTeam);
            Controls.Add(lblTitle);
            Name = "UserTeams";
            Text = "UserTeams";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTitle;
        private Button btnAddTeam;
        private Button btnPoke1;
        private Button button1;
        private Button button2;
    }
}