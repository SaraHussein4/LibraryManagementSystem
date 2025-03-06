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
            SuspendLayout();
            // 
            // tb_name
            // 
            tb_name.Location = new Point(38, 120);
            tb_name.Name = "tb_name";
            tb_name.PlaceholderText = "Name";
            tb_name.Size = new Size(300, 27);
            tb_name.TabIndex = 0;
            // 
            // tb_uname
            // 
            tb_uname.Location = new Point(38, 165);
            tb_uname.Name = "tb_uname";
            tb_uname.PlaceholderText = "User Name";
            tb_uname.Size = new Size(300, 27);
            tb_uname.TabIndex = 1;
            // 
            // tb_phone
            // 
            tb_phone.Location = new Point(38, 210);
            tb_phone.Name = "tb_phone";
            tb_phone.PlaceholderText = "Phone";
            tb_phone.Size = new Size(300, 27);
            tb_phone.TabIndex = 3;
            // 
            // tb_pass
            // 
            tb_pass.Location = new Point(38, 255);
            tb_pass.Name = "tb_pass";
            tb_pass.PlaceholderText = "Password";
            tb_pass.Size = new Size(300, 27);
            tb_pass.TabIndex = 4;
            // 
            // tb_confpass
            // 
            tb_confpass.Location = new Point(38, 300);
            tb_confpass.Name = "tb_confpass";
            tb_confpass.PlaceholderText = "Confirmation Password";
            tb_confpass.Size = new Size(300, 27);
            tb_confpass.TabIndex = 5;
            // 
            // btn_signUp
            // 
            btn_signUp.BackColor = Color.Tan;
            btn_signUp.Cursor = Cursors.Hand;
            btn_signUp.Font = new Font("Maiandra GD", 13.8F);
            btn_signUp.ForeColor = SystemColors.Control;
            btn_signUp.Location = new Point(38, 350);
            btn_signUp.Name = "btn_signUp";
            btn_signUp.Size = new Size(132, 47);
            btn_signUp.TabIndex = 7;
            btn_signUp.Text = "Sign Up";
            btn_signUp.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Microsoft YaHei", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(38, 413);
            label1.Name = "label1";
            label1.Size = new Size(197, 20);
            label1.TabIndex = 8;
            label1.Text = "Already have an account ?";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.ForeColor = Color.Tan;
            label2.Location = new Point(233, 413);
            label2.Name = "label2";
            label2.Size = new Size(50, 20);
            label2.TabIndex = 9;
            label2.Text = "Log In";
            // 
            // SignUp
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.Welcome__1_;
            ClientSize = new Size(912, 483);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btn_signUp);
            Controls.Add(tb_confpass);
            Controls.Add(tb_pass);
            Controls.Add(tb_phone);
            Controls.Add(tb_uname);
            Controls.Add(tb_name);
            Name = "SignUp";
            Text = "SignUp";
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
    }
}