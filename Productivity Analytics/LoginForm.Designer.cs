namespace Productivity_Analytics
{
    partial class LoginForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginForm));
            button1 = new Button();
            usernameLogin = new TextBox();
            passwordLogin = new TextBox();
            pictureBox1 = new PictureBox();
            button2 = new Button();
            label4 = new Label();
            linkLabel1 = new LinkLabel();
            button3 = new Button();
            button4 = new Button();
            label5 = new Label();
            linkLabel2 = new LinkLabel();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 10F);
            button1.Location = new Point(185, 369);
            button1.Name = "button1";
            button1.Size = new Size(79, 29);
            button1.TabIndex = 0;
            button1.Tag = "LoginBtn";
            button1.Text = "Login";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // usernameLogin
            // 
            usernameLogin.Font = new Font("Segoe UI", 10F);
            usernameLogin.ForeColor = SystemColors.WindowFrame;
            usernameLogin.Location = new Point(106, 258);
            usernameLogin.Name = "usernameLogin";
            usernameLogin.PlaceholderText = "Username";
            usernameLogin.Size = new Size(274, 25);
            usernameLogin.TabIndex = 1;
            usernameLogin.TextChanged += textBox1_TextChanged;
            // 
            // passwordLogin
            // 
            passwordLogin.Font = new Font("Segoe UI", 10F);
            passwordLogin.ForeColor = SystemColors.WindowFrame;
            passwordLogin.Location = new Point(106, 302);
            passwordLogin.Name = "passwordLogin";
            passwordLogin.PlaceholderText = "Password";
            passwordLogin.Size = new Size(274, 25);
            passwordLogin.TabIndex = 2;
            passwordLogin.UseSystemPasswordChar = true;
            passwordLogin.TextChanged += passwordLogin_TextChanged;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.mascot;
            pictureBox1.Location = new Point(131, 29);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(231, 175);
            pictureBox1.TabIndex = 5;
            pictureBox1.TabStop = false;
            // 
            // button2
            // 
            button2.Location = new Point(169, 335);
            button2.Name = "button2";
            button2.Size = new Size(25, 19);
            button2.TabIndex = 7;
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 10F);
            label4.ForeColor = SystemColors.ButtonFace;
            label4.Location = new Point(200, 335);
            label4.Name = "label4";
            label4.Size = new Size(99, 19);
            label4.TabIndex = 8;
            label4.Text = "Remember Me";
            label4.Click += label4_Click;
            // 
            // linkLabel1
            // 
            linkLabel1.AutoSize = true;
            linkLabel1.Font = new Font("Segoe UI", 10F);
            linkLabel1.ForeColor = SystemColors.ActiveCaptionText;
            linkLabel1.Location = new Point(181, 413);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(118, 19);
            linkLabel1.TabIndex = 9;
            linkLabel1.TabStop = true;
            linkLabel1.Text = "Forgot Password?";
            // 
            // button3
            // 
            button3.Image = Properties.Resources.image8;
            button3.Location = new Point(233, 449);
            button3.Name = "button3";
            button3.Size = new Size(52, 41);
            button3.TabIndex = 10;
            button3.TextImageRelation = TextImageRelation.ImageBeforeText;
            button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            button4.Image = (Image)resources.GetObject("button4.Image");
            button4.Location = new Point(164, 449);
            button4.Name = "button4";
            button4.Size = new Size(52, 41);
            button4.TabIndex = 11;
            button4.TextImageRelation = TextImageRelation.ImageBeforeText;
            button4.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 10F);
            label5.ForeColor = SystemColors.ButtonFace;
            label5.Location = new Point(114, 521);
            label5.Name = "label5";
            label5.Size = new Size(150, 19);
            label5.TabIndex = 12;
            label5.Text = "Dont have an account?";
            // 
            // linkLabel2
            // 
            linkLabel2.AutoSize = true;
            linkLabel2.Font = new Font("Segoe UI", 10F);
            linkLabel2.ForeColor = SystemColors.ActiveCaptionText;
            linkLabel2.Location = new Point(265, 521);
            linkLabel2.Name = "linkLabel2";
            linkLabel2.Size = new Size(103, 19);
            linkLabel2.TabIndex = 13;
            linkLabel2.TabStop = true;
            linkLabel2.Text = "Create Account";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(23, 207);
            label1.Name = "label1";
            label1.Size = new Size(406, 29);
            label1.TabIndex = 14;
            label1.Text = "Welcome to Productivity Analytics";
            label1.Click += label1_Click;
            // 
            // LoginForm
            // 
            AccessibleRole = AccessibleRole.TitleBar;
            AllowDrop = true;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            BackColor = Color.Fuchsia;
            BackgroundImageLayout = ImageLayout.Zoom;
            ClientSize = new Size(451, 624);
            Controls.Add(label1);
            Controls.Add(linkLabel2);
            Controls.Add(label5);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(linkLabel1);
            Controls.Add(label4);
            Controls.Add(button2);
            Controls.Add(pictureBox1);
            Controls.Add(passwordLogin);
            Controls.Add(usernameLogin);
            Controls.Add(button1);
            ForeColor = SystemColors.ActiveCaptionText;
            Name = "LoginForm";
            Text = "Login ";
            Load += Form1_Load_1;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private TextBox usernameLogin;
        private TextBox passwordLogin;
        private PictureBox pictureBox1;
        private Button button2;
        private Label label4;
        private LinkLabel linkLabel1;
        private Button button3;
        private Button button4;
        private Label label5;
        private LinkLabel linkLabel2;
        private Label label1;
    }
}
