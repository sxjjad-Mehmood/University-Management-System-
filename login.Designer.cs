namespace universitymangementsystem
{
    partial class login
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(login));
            bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(components);
            bunifuElipse2 = new Bunifu.Framework.UI.BunifuElipse(components);
            panel1 = new Panel();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label20 = new Label();
            label1 = new Label();
            usernametb = new TextBox();
            label2 = new Label();
            passwordtb = new TextBox();
            Loginbtn = new Bunifu.Framework.UI.BunifuThinButton2();
            resetlbl = new Label();
            pictureBox1 = new PictureBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // bunifuElipse1
            // 
            bunifuElipse1.ElipseRadius = 30;
            bunifuElipse1.TargetControl = this;
            // 
            // bunifuElipse2
            // 
            bunifuElipse2.ElipseRadius = 30;
            bunifuElipse2.TargetControl = panel1;
            // 
            // panel1
            // 
            panel1.BackColor = Color.Black;
            panel1.Controls.Add(label6);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(label4);
            panel1.Location = new Point(-1, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(304, 470);
            panel1.TabIndex = 0;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Times New Roman", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label6.ForeColor = Color.DarkKhaki;
            label6.Location = new Point(73, 272);
            label6.Name = "label6";
            label6.Size = new Size(85, 21);
            label6.TabIndex = 27;
            label6.Text = "Discipline";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Times New Roman", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label5.ForeColor = Color.DarkKhaki;
            label5.Location = new Point(73, 179);
            label5.Name = "label5";
            label5.Size = new Size(51, 21);
            label5.TabIndex = 26;
            label5.Text = "Faith";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Times New Roman", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label4.ForeColor = Color.DarkKhaki;
            label4.Location = new Point(73, 99);
            label4.Name = "label4";
            label4.Size = new Size(51, 21);
            label4.TabIndex = 25;
            label4.Text = "Unity";
            // 
            // label20
            // 
            label20.AutoSize = true;
            label20.Font = new Font("Times New Roman", 14F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label20.ForeColor = Color.FromArgb(192, 192, 0);
            label20.Location = new Point(462, 9);
            label20.Name = "label20";
            label20.Size = new Size(375, 32);
            label20.TabIndex = 23;
            label20.Text = "University Management System";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label1.ForeColor = Color.DarkKhaki;
            label1.Location = new Point(343, 102);
            label1.Name = "label1";
            label1.Size = new Size(90, 21);
            label1.TabIndex = 24;
            label1.Text = "UserName\r\n";
            label1.Click += label1_Click;
            // 
            // usernametb
            // 
            usernametb.Location = new Point(380, 153);
            usernametb.Name = "usernametb";
            usernametb.Size = new Size(309, 35);
            usernametb.TabIndex = 25;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Times New Roman", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label2.ForeColor = Color.DarkKhaki;
            label2.Location = new Point(343, 217);
            label2.Name = "label2";
            label2.Size = new Size(82, 21);
            label2.TabIndex = 26;
            label2.Text = "Password";
            // 
            // passwordtb
            // 
            passwordtb.HideSelection = false;
            passwordtb.Location = new Point(380, 261);
            passwordtb.Name = "passwordtb";
            passwordtb.PasswordChar = '*';
            passwordtb.Size = new Size(309, 35);
            passwordtb.TabIndex = 27;
            // 
            // Loginbtn
            // 
            Loginbtn.ActiveBorderThickness = 1;
            Loginbtn.ActiveCornerRadius = 20;
            Loginbtn.ActiveFillColor = Color.DarkKhaki;
            Loginbtn.ActiveForecolor = Color.White;
            Loginbtn.ActiveLineColor = Color.Gold;
            Loginbtn.BackColor = Color.White;
            Loginbtn.BackgroundImage = (Image)resources.GetObject("Loginbtn.BackgroundImage");
            Loginbtn.ButtonText = "Login";
            Loginbtn.Font = new Font("Arial Rounded MT Bold", 9F, FontStyle.Regular, GraphicsUnit.Point);
            Loginbtn.ForeColor = Color.SeaGreen;
            Loginbtn.IdleBorderThickness = 1;
            Loginbtn.IdleCornerRadius = 20;
            Loginbtn.IdleFillColor = Color.White;
            Loginbtn.IdleForecolor = Color.FromArgb(192, 192, 0);
            Loginbtn.IdleLineColor = Color.Khaki;
            Loginbtn.Location = new Point(437, 329);
            Loginbtn.Margin = new Padding(4, 4, 4, 4);
            Loginbtn.Name = "Loginbtn";
            Loginbtn.Size = new Size(178, 40);
            Loginbtn.TabIndex = 191;
            Loginbtn.TextAlign = ContentAlignment.MiddleCenter;
            Loginbtn.Click += Loginbtn_Click;
            // 
            // resetlbl
            // 
            resetlbl.AutoSize = true;
            resetlbl.Font = new Font("Times New Roman", 9F, FontStyle.Bold | FontStyle.Italic | FontStyle.Underline, GraphicsUnit.Point);
            resetlbl.ForeColor = Color.DarkKhaki;
            resetlbl.Location = new Point(494, 393);
            resetlbl.Name = "resetlbl";
            resetlbl.Size = new Size(50, 21);
            resetlbl.TabIndex = 192;
            resetlbl.Text = "Reset";
            resetlbl.Click += resetlbl_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Khaki;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(819, 71);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(194, 203);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 193;
            pictureBox1.TabStop = false;
            // 
            // login
            // 
            AutoScaleDimensions = new SizeF(14F, 26F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1120, 468);
            Controls.Add(pictureBox1);
            Controls.Add(resetlbl);
            Controls.Add(Loginbtn);
            Controls.Add(passwordtb);
            Controls.Add(label2);
            Controls.Add(usernametb);
            Controls.Add(label1);
            Controls.Add(label20);
            Controls.Add(panel1);
            Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point);
            ForeColor = Color.White;
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(4, 3, 4, 3);
            Name = "login";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "login";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse2;
        private Panel panel1;
        private Label label20;
        private Label label1;
        private TextBox usernametb;
        private TextBox passwordtb;
        private Label label2;
        private Bunifu.Framework.UI.BunifuThinButton2 Loginbtn;
        private Label resetlbl;
        private PictureBox pictureBox1;
        private Label label6;
        private Label label5;
        private Label label4;
    }
}