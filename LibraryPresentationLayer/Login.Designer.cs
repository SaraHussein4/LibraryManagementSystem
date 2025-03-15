namespace LibraryManagementSystem.LibraryPresentationLayer
{
    partial class Login
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
            label1 = new Label();
            label2 = new Label();
            txt_userName = new TextBox();
            txt_password = new TextBox();
            chkShowPassword = new CheckBox();
            btn_logIn = new Button();
            textBox3 = new TextBox();
            lblError = new Label();
            btn_create = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.ForeColor = Color.SaddleBrown;
            label1.Location = new Point(44, 78);
            label1.Name = "label1";
            label1.Size = new Size(171, 38);
            label1.TabIndex = 0;
            label1.Text = "Username";
            // 
            // label2
            // 
            label2.ForeColor = Color.SaddleBrown;
            label2.Location = new Point(44, 197);
            label2.Name = "label2";
            label2.Size = new Size(171, 38);
            label2.TabIndex = 1;
            label2.Text = "Password";
            label2.Click += label2_Click;
            // 
            // txt_userName
            // 
            txt_userName.Location = new Point(44, 133);
            txt_userName.Name = "txt_userName";
            txt_userName.Size = new Size(318, 34);
            txt_userName.TabIndex = 2;
            // 
            // txt_password
            // 
            txt_password.Location = new Point(44, 251);
            txt_password.Name = "txt_password";
            txt_password.Size = new Size(318, 34);
            txt_password.TabIndex = 3;
            // 
            // chkShowPassword
            // 
            chkShowPassword.AutoSize = true;
            chkShowPassword.ForeColor = Color.SaddleBrown;
            chkShowPassword.Location = new Point(179, 311);
            chkShowPassword.Name = "chkShowPassword";
            chkShowPassword.Size = new Size(183, 32);
            chkShowPassword.TabIndex = 4;
            chkShowPassword.Text = "Show Password";
            chkShowPassword.TextAlign = ContentAlignment.MiddleCenter;
            chkShowPassword.UseVisualStyleBackColor = true;
            chkShowPassword.CheckedChanged += chkShowPassword_CheckedChanged;
            // 
            // btn_logIn
            // 
            btn_logIn.BackColor = Color.SaddleBrown;
            btn_logIn.Cursor = Cursors.Hand;
            btn_logIn.ForeColor = Color.FloralWhite;
            btn_logIn.Location = new Point(44, 371);
            btn_logIn.Name = "btn_logIn";
            btn_logIn.Size = new Size(318, 56);
            btn_logIn.TabIndex = 5;
            btn_logIn.Text = "LOGIN";
            btn_logIn.UseVisualStyleBackColor = false;
            btn_logIn.Click += btn_logIn_Click;
            // 
            // textBox3
            // 
            textBox3.BackColor = Color.FloralWhite;
            textBox3.BorderStyle = BorderStyle.None;
            textBox3.Font = new Font("Nirmala UI", 8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            textBox3.ForeColor = Color.SaddleBrown;
            textBox3.Location = new Point(78, 447);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(249, 22);
            textBox3.TabIndex = 6;
            textBox3.Text = "Don't have an account?";
            textBox3.TextAlign = HorizontalAlignment.Center;
            textBox3.TextChanged += textBox3_TextChanged;
            // 
            // lblError
            // 
            lblError.AutoSize = true;
            lblError.Location = new Point(161, 251);
            lblError.Name = "lblError";
            lblError.Size = new Size(0, 28);
            lblError.TabIndex = 8;
            // 
            // btn_create
            // 
            btn_create.BackColor = Color.White;
            btn_create.Cursor = Cursors.Hand;
            btn_create.FlatAppearance.BorderColor = Color.SaddleBrown;
            btn_create.FlatStyle = FlatStyle.Flat;
            btn_create.Font = new Font("Nirmala UI", 8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_create.ForeColor = Color.SaddleBrown;
            btn_create.Location = new Point(44, 490);
            btn_create.Name = "btn_create";
            btn_create.Size = new Size(318, 51);
            btn_create.TabIndex = 9;
            btn_create.Text = "Create an account";
            btn_create.UseVisualStyleBackColor = false;
            btn_create.Click += btn_create_Click;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(12F, 28F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FloralWhite;
            ClientSize = new Size(410, 594);
            Controls.Add(btn_create);
            Controls.Add(lblError);
            Controls.Add(textBox3);
            Controls.Add(btn_logIn);
            Controls.Add(chkShowPassword);
            Controls.Add(txt_password);
            Controls.Add(txt_userName);
            Controls.Add(label2);
            Controls.Add(label1);
            Font = new Font("Nirmala UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Margin = new Padding(4, 3, 4, 3);
            Name = "Login";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Login";
            Load += Login_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox txt_userName;
        private TextBox txt_password;
        private CheckBox chkShowPassword;
        private Button btn_logIn;
        private TextBox textBox3;
        private Label lblError;
        private Button btn_create;
    }
}