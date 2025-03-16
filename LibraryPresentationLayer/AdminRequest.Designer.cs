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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            dgvRequests = new DataGridView();
            gobackinARequest = new Label();
            label4 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvRequests).BeginInit();
            SuspendLayout();
            // 
            // dgvRequests
            // 
            dgvRequests.BackgroundColor = Color.Linen;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.Sienna;
            dataGridViewCellStyle1.Font = new Font("Times New Roman", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = Color.Linen;
            dataGridViewCellStyle1.SelectionBackColor = Color.Linen;
            dataGridViewCellStyle1.SelectionForeColor = Color.Sienna;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgvRequests.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvRequests.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.Linen;
            dataGridViewCellStyle2.Font = new Font("Times New Roman", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle2.ForeColor = Color.Sienna;
            dataGridViewCellStyle2.SelectionBackColor = Color.Sienna;
            dataGridViewCellStyle2.SelectionForeColor = Color.Linen;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dgvRequests.DefaultCellStyle = dataGridViewCellStyle2;
            dgvRequests.GridColor = Color.Linen;
            dgvRequests.Location = new Point(12, 70);
            dgvRequests.Name = "dgvRequests";
            dgvRequests.ReadOnly = true;
            dgvRequests.RowHeadersWidth = 70;
            dgvRequests.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvRequests.Size = new Size(883, 391);
            dgvRequests.TabIndex = 0;
            dgvRequests.CellClick += dgvRequests_CellClick;
            dgvRequests.DataBindingComplete += dgvRequests_DataBindingComplete;
            // 
            // gobackinARequest
            // 
            gobackinARequest.AutoSize = true;
            gobackinARequest.BackColor = Color.White;
            gobackinARequest.Font = new Font("Times New Roman", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            gobackinARequest.ForeColor = Color.Tan;
            gobackinARequest.Location = new Point(817, 498);
            gobackinARequest.Name = "gobackinARequest";
            gobackinARequest.Padding = new Padding(5);
            gobackinARequest.Size = new Size(78, 29);
            gobackinARequest.TabIndex = 1;
            gobackinARequest.Text = "Go Back";
            gobackinARequest.MouseDoubleClick += gobackinARequest_MouseDoubleClick;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Poor Richard", 16.2F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.Linen;
            label4.Location = new Point(12, 21);
            label4.Name = "label4";
            label4.Size = new Size(275, 31);
            label4.TabIndex = 2;
            label4.Text = "Handle Requested Books";
            // 
            // AdminRequest
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Tan;
            ClientSize = new Size(907, 547);
            Controls.Add(label4);
            Controls.Add(gobackinARequest);
            Controls.Add(dgvRequests);
            FormBorderStyle = FormBorderStyle.None;
            Name = "AdminRequest";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "AdminRequest";
            ((System.ComponentModel.ISupportInitialize)dgvRequests).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvRequests;
        private Label gobackinARequest;
        private Label label4;
    }
}