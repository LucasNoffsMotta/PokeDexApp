namespace PokeDexApp
{
    partial class LogIn
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
            txtExistentUserName = new TextBox();
            label1 = new Label();
            label2 = new Label();
            btnSignIn = new Button();
            btnCreateUser = new Button();
            label3 = new Label();
            lblSignUp = new Label();
            txtNewUserName = new TextBox();
            SuspendLayout();
            // 
            // txtExistentUserName
            // 
            txtExistentUserName.Location = new Point(38, 127);
            txtExistentUserName.Name = "txtExistentUserName";
            txtExistentUserName.Size = new Size(188, 27);
            txtExistentUserName.TabIndex = 0;
            txtExistentUserName.TextChanged += txtUserName_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(36, 45);
            label1.Name = "label1";
            label1.Size = new Size(109, 33);
            label1.TabIndex = 1;
            label1.Text = "Sign In";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(38, 94);
            label2.Name = "label2";
            label2.Size = new Size(107, 21);
            label2.TabIndex = 2;
            label2.Text = "User Name";
            // 
            // btnSignIn
            // 
            btnSignIn.Location = new Point(82, 169);
            btnSignIn.Name = "btnSignIn";
            btnSignIn.Size = new Size(94, 29);
            btnSignIn.TabIndex = 3;
            btnSignIn.Text = "Sign In";
            btnSignIn.UseVisualStyleBackColor = true;
            btnSignIn.Click += btnSignIn_Click;
            // 
            // btnCreateUser
            // 
            btnCreateUser.Location = new Point(362, 169);
            btnCreateUser.Name = "btnCreateUser";
            btnCreateUser.Size = new Size(94, 29);
            btnCreateUser.TabIndex = 7;
            btnCreateUser.Text = "Sign Up";
            btnCreateUser.UseVisualStyleBackColor = true;
            btnCreateUser.Click += btnCreateUser_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Arial", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(318, 94);
            label3.Name = "label3";
            label3.Size = new Size(107, 21);
            label3.TabIndex = 6;
            label3.Text = "User Name";
            // 
            // lblSignUp
            // 
            lblSignUp.AutoSize = true;
            lblSignUp.Font = new Font("Arial", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblSignUp.Location = new Point(316, 45);
            lblSignUp.Name = "lblSignUp";
            lblSignUp.Size = new Size(121, 33);
            lblSignUp.TabIndex = 5;
            lblSignUp.Text = "Sign Up";
            // 
            // txtNewUserName
            // 
            txtNewUserName.Location = new Point(318, 127);
            txtNewUserName.Name = "txtNewUserName";
            txtNewUserName.Size = new Size(188, 27);
            txtNewUserName.TabIndex = 4;
            // 
            // LogIn
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(562, 250);
            Controls.Add(btnCreateUser);
            Controls.Add(label3);
            Controls.Add(lblSignUp);
            Controls.Add(txtNewUserName);
            Controls.Add(btnSignIn);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtExistentUserName);
            Name = "LogIn";
            Text = "LogIn";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtExistentUserName;
        private Label label1;
        private Label label2;
        private Button btnSignIn;
        private Button btnCreateUser;
        private Label label3;
        private Label lblSignUp;
        private TextBox txtNewUserName;
    }
}