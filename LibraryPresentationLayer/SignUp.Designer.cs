namespace LibraryManagementSystem.LibraryPresentationLayer
{
    partial class SignUp
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
            tb_name = new TextBox();
            tb_uname = new TextBox();
            tb_phone = new TextBox();
            tb_pass = new TextBox();
            tb_confpass = new TextBox();
            btn_signUp = new Button();
            label1 = new Label();
            checkbxShowPass = new CheckBox();
            tb_email = new TextBox();
            cb_membershipType = new ComboBox();
            label2 = new Label();
            btn_login = new Button();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // tb_name
            // 
            tb_name.Location = new Point(19, 106);
            tb_name.Name = "tb_name";
            tb_name.PlaceholderText = "Name";
            tb_name.Size = new Size(300, 27);
            tb_name.TabIndex = 0;
            // 
            // tb_uname
            // 
            tb_uname.Location = new Point(19, 144);
            tb_uname.Name = "tb_uname";
            tb_uname.PlaceholderText = "User Name";
            tb_uname.Size = new Size(300, 27);
            tb_uname.TabIndex = 1;
            // 
            // tb_phone
            // 
            tb_phone.Location = new Point(19, 221);
            tb_phone.Name = "tb_phone";
            tb_phone.PlaceholderText = "Phone";
            tb_phone.Size = new Size(300, 27);
            tb_phone.TabIndex = 3;
            // 
            // tb_pass
            // 
            tb_pass.Location = new Point(19, 297);
            tb_pass.Name = "tb_pass";
            tb_pass.PlaceholderText = "Password";
            tb_pass.Size = new Size(300, 27);
            tb_pass.TabIndex = 4;
            tb_pass.TextChanged += tb_pass_TextChanged;
            // 
            // tb_confpass
            // 
            tb_confpass.Location = new Point(19, 335);
            tb_confpass.Name = "tb_confpass";
            tb_confpass.PlaceholderText = "Confirmation Password";
            tb_confpass.Size = new Size(300, 27);
            tb_confpass.TabIndex = 5;
            // 
            // btn_signUp
            // 
            btn_signUp.BackColor = Color.Tan;
            btn_signUp.Cursor = Cursors.Hand;
            btn_signUp.FlatStyle = FlatStyle.Flat;
            btn_signUp.Font = new Font("Maiandra GD", 13.8F);
            btn_signUp.ForeColor = SystemColors.Control;
            btn_signUp.Location = new Point(86, 407);
            btn_signUp.Name = "btn_signUp";
            btn_signUp.Size = new Size(144, 50);
            btn_signUp.TabIndex = 7;
            btn_signUp.Text = "Sign Up";
            btn_signUp.UseVisualStyleBackColor = false;
            btn_signUp.Click += btn_signUp_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Microsoft YaHei", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(19, 465);
            label1.Name = "label1";
            label1.Size = new Size(197, 20);
            label1.TabIndex = 8;
            label1.Text = "Already have an account ?";
            // 
            // checkbxShowPass
            // 
            checkbxShowPass.AutoSize = true;
            checkbxShowPass.BackColor = Color.Transparent;
            checkbxShowPass.Cursor = Cursors.Hand;
            checkbxShowPass.FlatStyle = FlatStyle.Flat;
            checkbxShowPass.Location = new Point(191, 378);
            checkbxShowPass.Margin = new Padding(2);
            checkbxShowPass.Name = "checkbxShowPass";
            checkbxShowPass.Size = new Size(128, 24);
            checkbxShowPass.TabIndex = 10;
            checkbxShowPass.Text = "Show Password";
            checkbxShowPass.UseVisualStyleBackColor = false;
            checkbxShowPass.CheckedChanged += checkbxShowPass_CheckedChanged;
            // 
            // tb_email
            // 
            tb_email.Location = new Point(17, 259);
            tb_email.Name = "tb_email";
            tb_email.PlaceholderText = "Email";
            tb_email.Size = new Size(300, 27);
            tb_email.TabIndex = 11;
            tb_email.TextChanged += tb_email_TextChanged;
            // 
            // cb_membershipType
            // 
            cb_membershipType.FormattingEnabled = true;
            cb_membershipType.Location = new Point(19, 182);
            cb_membershipType.Margin = new Padding(2);
            cb_membershipType.Name = "cb_membershipType";
            cb_membershipType.Size = new Size(300, 28);
            cb_membershipType.TabIndex = 12;
            cb_membershipType.SelectedIndexChanged += cb_membershipType_SelectedIndexChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.ForeColor = Color.Tan;
            label2.Location = new Point(214, 410);
            label2.Name = "label2";
            label2.Size = new Size(0, 20);
            label2.TabIndex = 9;
            // 
            // btn_login
            // 
            btn_login.BackColor = Color.Ivory;
            btn_login.Cursor = Cursors.Hand;
            btn_login.FlatAppearance.BorderSize = 0;
            btn_login.FlatStyle = FlatStyle.Flat;
            btn_login.ForeColor = Color.Tan;
            btn_login.Location = new Point(214, 462);
            btn_login.Margin = new Padding(2);
            btn_login.Name = "btn_login";
            btn_login.Size = new Size(90, 27);
            btn_login.TabIndex = 13;
            btn_login.Text = "LOGIN";
            btn_login.UseVisualStyleBackColor = false;
            btn_login.Click += btn_login_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.BackgroundImage = Properties.Resources._736f16a5248246f5f648146c4305134b_removebg_preview;
            pictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox1.Location = new Point(798, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(46, 43);
            pictureBox1.TabIndex = 14;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // SignUp
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.Welcome__1_;
            ClientSize = new Size(929, 523);
            Controls.Add(pictureBox1);
            Controls.Add(btn_login);
            Controls.Add(cb_membershipType);
            Controls.Add(tb_email);
            Controls.Add(checkbxShowPass);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btn_signUp);
            Controls.Add(tb_confpass);
            Controls.Add(tb_pass);
            Controls.Add(tb_phone);
            Controls.Add(tb_uname);
            Controls.Add(tb_name);
            FormBorderStyle = FormBorderStyle.None;
            Name = "SignUp";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "SignUp";
            Load += SignUp_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox tb_name;
        private TextBox tb_uname;
        private TextBox tb_phone;
        private TextBox tb_pass;
        private TextBox tb_confpass;
        private Button btn_signUp;
        private Label label1;
        private CheckBox checkbxShowPass;
        private TextBox tb_email;
        private ComboBox cb_membershipType;
        private Label label2;
        private Button btn_login;
        private PictureBox pictureBox1;
    }
}