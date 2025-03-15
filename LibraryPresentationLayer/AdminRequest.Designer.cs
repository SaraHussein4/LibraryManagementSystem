namespace LibraryManagementSystem.LibraryPresentationLayer
{
    partial class AdminRequest
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
            dgvRequests = new DataGridView();
            gobackinARequest = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvRequests).BeginInit();
            SuspendLayout();
            // 
            // dgvRequests
            // 
            dgvRequests.BackgroundColor = Color.White;
            dgvRequests.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvRequests.Location = new Point(10, 9);
            dgvRequests.Margin = new Padding(3, 2, 3, 2);
            dgvRequests.Name = "dgvRequests";
            dgvRequests.ReadOnly = true;
            dgvRequests.RowHeadersWidth = 51;
            dgvRequests.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvRequests.Size = new Size(679, 300);
            dgvRequests.TabIndex = 0;
            dgvRequests.CellClick += dgvRequests_CellClick;
            // 
            // gobackinARequest
            // 
            gobackinARequest.AutoSize = true;
            gobackinARequest.BackColor = Color.White;
            gobackinARequest.ForeColor = Color.Tan;
            gobackinARequest.Location = new Point(639, 316);
            gobackinARequest.Name = "gobackinARequest";
            gobackinARequest.Size = new Size(49, 15);
            gobackinARequest.TabIndex = 1;
            gobackinARequest.Text = "go back";
            gobackinARequest.MouseDoubleClick += gobackinARequest_MouseDoubleClick;
            // 
            // AdminRequest
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Tan;
            ClientSize = new Size(700, 338);
            Controls.Add(gobackinARequest);
            Controls.Add(dgvRequests);
            Margin = new Padding(3, 2, 3, 2);
            Name = "AdminRequest";
            Text = "AdminRequest";
            ((System.ComponentModel.ISupportInitialize)dgvRequests).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvRequests;
        private Label gobackinARequest;
    }
}