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
            label2 = new Label();
            checkbxShowPass = new CheckBox();
            tb_email = new TextBox();
            cb_membershipType = new ComboBox();
            SuspendLayout();
            // 
            // tb_name
            // 
            tb_name.Location = new Point(24, 111);
            tb_name.Margin = new Padding(4);
            tb_name.Name = "tb_name";
            tb_name.PlaceholderText = "Name";
            tb_name.Size = new Size(374, 31);
            tb_name.TabIndex = 0;
            // 
            // tb_uname
            // 
            tb_uname.Location = new Point(24, 150);
            tb_uname.Margin = new Padding(4);
            tb_uname.Name = "tb_uname";
            tb_uname.PlaceholderText = "User Name";
            tb_uname.Size = new Size(374, 31);
            tb_uname.TabIndex = 1;
            // 
            // tb_phone
            // 
            tb_phone.Location = new Point(24, 228);
            tb_phone.Margin = new Padding(4);
            tb_phone.Name = "tb_phone";
            tb_phone.PlaceholderText = "Phone";
            tb_phone.Size = new Size(374, 31);
            tb_phone.TabIndex = 3;
            // 
            // tb_pass
            // 
            tb_pass.Location = new Point(24, 306);
            tb_pass.Margin = new Padding(4);
            tb_pass.Name = "tb_pass";
            tb_pass.PlaceholderText = "Password";
            tb_pass.Size = new Size(374, 31);
            tb_pass.TabIndex = 4;
            tb_pass.TextChanged += tb_pass_TextChanged;
            // 
            // tb_confpass
            // 
            tb_confpass.Location = new Point(24, 345);
            tb_confpass.Margin = new Padding(4);
            tb_confpass.Name = "tb_confpass";
            tb_confpass.PlaceholderText = "Confirmation Password";
            tb_confpass.Size = new Size(374, 31);
            tb_confpass.TabIndex = 5;
            // 
            // btn_signUp
            // 
            btn_signUp.BackColor = Color.Tan;
            btn_signUp.Cursor = Cursors.Hand;
            btn_signUp.FlatStyle = FlatStyle.Flat;
            btn_signUp.Font = new Font("Maiandra GD", 13.8F);
            btn_signUp.ForeColor = SystemColors.Control;
            btn_signUp.Location = new Point(107, 446);
            btn_signUp.Margin = new Padding(4);
            btn_signUp.Name = "btn_signUp";
            btn_signUp.Size = new Size(165, 43);
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
            label1.Location = new Point(24, 513);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(235, 24);
            label1.TabIndex = 8;
            label1.Text = "Already have an account ?";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.ForeColor = Color.Tan;
            label2.Location = new Point(267, 512);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(62, 25);
            label2.TabIndex = 9;
            label2.Text = "Log In";
            // 
            // checkbxShowPass
            // 
            checkbxShowPass.AutoSize = true;
            checkbxShowPass.Cursor = Cursors.Hand;
            checkbxShowPass.FlatStyle = FlatStyle.Flat;
            checkbxShowPass.Location = new Point(241, 393);
            checkbxShowPass.Name = "checkbxShowPass";
            checkbxShowPass.Size = new Size(157, 29);
            checkbxShowPass.TabIndex = 10;
            checkbxShowPass.Text = "Show Password";
            checkbxShowPass.UseVisualStyleBackColor = true;
            checkbxShowPass.CheckedChanged += checkbxShowPass_CheckedChanged;
            // 
            // tb_email
            // 
            tb_email.Location = new Point(24, 267);
            tb_email.Margin = new Padding(4);
            tb_email.Name = "tb_email";
            tb_email.PlaceholderText = "Email";
            tb_email.Size = new Size(374, 31);
            tb_email.TabIndex = 11;
            tb_email.TextChanged += tb_email_TextChanged;
            // 
            // cb_membershipType
            // 
            cb_membershipType.FormattingEnabled = true;
            cb_membershipType.Location = new Point(24, 188);
            cb_membershipType.Name = "cb_membershipType";
            cb_membershipType.Size = new Size(374, 33);
            cb_membershipType.TabIndex = 12;
            cb_membershipType.SelectedIndexChanged += cb_membershipType_SelectedIndexChanged;
            // 
            // SignUp
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.Welcome__1_;
            ClientSize = new Size(915, 572);
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
            Margin = new Padding(4);
            Name = "SignUp";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "SignUp";
            Load += SignUp_Load;
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
        private Label label2;
        private CheckBox checkbxShowPass;
        private TextBox tb_email;
        private ComboBox cb_membershipType;
    }
}