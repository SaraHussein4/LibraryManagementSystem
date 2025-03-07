namespace LibraryManagementSystem.LibraryPresentationLayer
{
    partial class Welcome
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
            button1 = new Button();
            button2 = new Button();
            SuspendLayout();
            // 
            // button1
            // 
            button1.BackColor = Color.Tan;
            button1.Cursor = Cursors.Hand;
            button1.Font = new Font("Maiandra GD", 13.8F);
            button1.ForeColor = SystemColors.Control;
            button1.Location = new Point(35, 439);
            button1.Margin = new Padding(4, 4, 4, 4);
            button1.Name = "button1";
            button1.Size = new Size(165, 59);
            button1.TabIndex = 0;
            button1.Text = "Sign Up";
            button1.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            button2.BackColor = Color.Tan;
            button2.Cursor = Cursors.Hand;
            button2.Font = new Font("Maiandra GD", 13.8F);
            button2.ForeColor = SystemColors.Control;
            button2.Location = new Point(220, 439);
            button2.Margin = new Padding(4, 4, 4, 4);
            button2.Name = "button2";
            button2.Size = new Size(165, 59);
            button2.TabIndex = 1;
            button2.Text = "Log In";
            button2.UseVisualStyleBackColor = false;
            // 
            // Welcome
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Snow;
            BackgroundImage = Properties.Resources.Welcome;
            ClientSize = new Size(930, 519);
            Controls.Add(button2);
            Controls.Add(button1);
            Margin = new Padding(4, 4, 4, 4);
            Name = "Welcome";
            Text = "Welcome";
            ResumeLayout(false);
        }

        #endregion

        private Button button1;
        private Button button2;
    }
}