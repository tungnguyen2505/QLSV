namespace QLSV
{
    partial class StudentInClassForm
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.panelMain = new System.Windows.Forms.Panel();
            this.panelContent = new System.Windows.Forms.Panel();
            this.labelClassInfo = new System.Windows.Forms.Label();
            this.dataGridViewStudents = new System.Windows.Forms.DataGridView();
            this.panelPagination = new System.Windows.Forms.Panel();
            this.labelRowsPerPage = new System.Windows.Forms.Label();
            this.comboBoxPageSize = new System.Windows.Forms.ComboBox();
            this.buttonFirstPage = new System.Windows.Forms.Button();
            this.buttonPreviousPage = new System.Windows.Forms.Button();
            this.labelPageInfo = new System.Windows.Forms.Label();
            this.buttonNextPage = new System.Windows.Forms.Button();
            this.buttonLastPage = new System.Windows.Forms.Button();
            this.labelPageStatus = new System.Windows.Forms.Label();
            this.panelMain.SuspendLayout();
            this.panelContent.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewStudents)).BeginInit();
            this.panelPagination.SuspendLayout();
            this.SuspendLayout();

            // panelMain
            this.panelMain.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(250)))), ((int)(((byte)(252)))));
            this.panelMain.Controls.Add(this.panelContent);
            this.panelMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelMain.Location = new System.Drawing.Point(0, 0);
            this.panelMain.Name = "panelMain";
            this.panelMain.Size = new System.Drawing.Size(1000, 600);
            this.panelMain.TabIndex = 0;

            // panelContent
            this.panelContent.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(250)))), ((int)(((byte)(252)))));
            this.panelContent.Controls.Add(this.panelPagination);
            this.panelContent.Controls.Add(this.dataGridViewStudents);
            this.panelContent.Controls.Add(this.labelClassInfo);
            this.panelContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelContent.Location = new System.Drawing.Point(0, 0);
            this.panelContent.Name = "panelContent";
            this.panelContent.Padding = new System.Windows.Forms.Padding(20);
            this.panelContent.Size = new System.Drawing.Size(1000, 600);
            this.panelContent.TabIndex = 1;

            // labelClassInfo
            this.labelClassInfo.AutoSize = true;
            this.labelClassInfo.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.labelClassInfo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(116)))), ((int)(((byte)(144)))));
            this.labelClassInfo.Location = new System.Drawing.Point(20, 20);
            this.labelClassInfo.Name = "labelClassInfo";
            this.labelClassInfo.Size = new System.Drawing.Size(150, 25);
            this.labelClassInfo.TabIndex = 0;
            this.labelClassInfo.Text = "Danh sach sinh vien";

            // dataGridViewStudents
            this.dataGridViewStudents.AllowUserToAddRows = false;
            this.dataGridViewStudents.AllowUserToDeleteRows = false;
            this.dataGridViewStudents.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewStudents.BackgroundColor = System.Drawing.Color.White;
            this.dataGridViewStudents.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dataGridViewStudents.Location = new System.Drawing.Point(20, 60);
            this.dataGridViewStudents.Name = "dataGridViewStudents";
            this.dataGridViewStudents.ReadOnly = true;
            this.dataGridViewStudents.Size = new System.Drawing.Size(960, 480);
            this.dataGridViewStudents.TabIndex = 1;

            // panelPagination
            this.panelPagination.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelPagination.BackColor = System.Drawing.Color.White;
            this.panelPagination.Controls.Add(this.labelRowsPerPage);
            this.panelPagination.Controls.Add(this.comboBoxPageSize);
            this.panelPagination.Controls.Add(this.buttonFirstPage);
            this.panelPagination.Controls.Add(this.buttonPreviousPage);
            this.panelPagination.Controls.Add(this.labelPageInfo);
            this.panelPagination.Controls.Add(this.buttonNextPage);
            this.panelPagination.Controls.Add(this.buttonLastPage);
            this.panelPagination.Controls.Add(this.labelPageStatus);
            this.panelPagination.Location = new System.Drawing.Point(20, 548);
            this.panelPagination.Name = "panelPagination";
            this.panelPagination.Size = new System.Drawing.Size(960, 32);
            this.panelPagination.TabIndex = 2;

            // labelRowsPerPage
            this.labelRowsPerPage.AutoSize = true;
            this.labelRowsPerPage.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.labelRowsPerPage.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(85)))), ((int)(((byte)(105)))));
            this.labelRowsPerPage.Location = new System.Drawing.Point(6, 8);
            this.labelRowsPerPage.Name = "labelRowsPerPage";
            this.labelRowsPerPage.Size = new System.Drawing.Size(67, 15);
            this.labelRowsPerPage.TabIndex = 0;
            this.labelRowsPerPage.Text = "Dong/trang";

            // comboBoxPageSize
            this.comboBoxPageSize.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxPageSize.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.comboBoxPageSize.FormattingEnabled = true;
            this.comboBoxPageSize.Location = new System.Drawing.Point(79, 4);
            this.comboBoxPageSize.Name = "comboBoxPageSize";
            this.comboBoxPageSize.Size = new System.Drawing.Size(58, 23);
            this.comboBoxPageSize.TabIndex = 1;
            this.comboBoxPageSize.SelectedIndexChanged += new System.EventHandler(this.comboBoxPageSize_SelectedIndexChanged);

            // buttonFirstPage
            this.buttonFirstPage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(232)))), ((int)(((byte)(240)))));
            this.buttonFirstPage.FlatAppearance.BorderSize = 0;
            this.buttonFirstPage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonFirstPage.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.buttonFirstPage.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(41)))), ((int)(((byte)(59)))));
            this.buttonFirstPage.Location = new System.Drawing.Point(168, 3);
            this.buttonFirstPage.Name = "buttonFirstPage";
            this.buttonFirstPage.Size = new System.Drawing.Size(42, 25);
            this.buttonFirstPage.TabIndex = 2;
            this.buttonFirstPage.Text = "<<";
            this.buttonFirstPage.UseVisualStyleBackColor = false;
            this.buttonFirstPage.Click += new System.EventHandler(this.buttonFirstPage_Click);

            // buttonPreviousPage
            this.buttonPreviousPage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(232)))), ((int)(((byte)(240)))));
            this.buttonPreviousPage.FlatAppearance.BorderSize = 0;
            this.buttonPreviousPage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonPreviousPage.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.buttonPreviousPage.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(41)))), ((int)(((byte)(59)))));
            this.buttonPreviousPage.Location = new System.Drawing.Point(216, 3);
            this.buttonPreviousPage.Name = "buttonPreviousPage";
            this.buttonPreviousPage.Size = new System.Drawing.Size(42, 25);
            this.buttonPreviousPage.TabIndex = 3;
            this.buttonPreviousPage.Text = "<";
            this.buttonPreviousPage.UseVisualStyleBackColor = false;
            this.buttonPreviousPage.Click += new System.EventHandler(this.buttonPreviousPage_Click);

            // labelPageInfo
            this.labelPageInfo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(251)))), ((int)(((byte)(241)))));
            this.labelPageInfo.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.labelPageInfo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(116)))), ((int)(((byte)(144)))));
            this.labelPageInfo.Location = new System.Drawing.Point(264, 3);
            this.labelPageInfo.Name = "labelPageInfo";
            this.labelPageInfo.Size = new System.Drawing.Size(104, 25);
            this.labelPageInfo.TabIndex = 4;
            this.labelPageInfo.Text = "Trang 0/0";
            this.labelPageInfo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;

            // buttonNextPage
            this.buttonNextPage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(232)))), ((int)(((byte)(240)))));
            this.buttonNextPage.FlatAppearance.BorderSize = 0;
            this.buttonNextPage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonNextPage.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.buttonNextPage.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(41)))), ((int)(((byte)(59)))));
            this.buttonNextPage.Location = new System.Drawing.Point(374, 3);
            this.buttonNextPage.Name = "buttonNextPage";
            this.buttonNextPage.Size = new System.Drawing.Size(42, 25);
            this.buttonNextPage.TabIndex = 5;
            this.buttonNextPage.Text = ">";
            this.buttonNextPage.UseVisualStyleBackColor = false;
            this.buttonNextPage.Click += new System.EventHandler(this.buttonNextPage_Click);

            // buttonLastPage
            this.buttonLastPage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(232)))), ((int)(((byte)(240)))));
            this.buttonLastPage.FlatAppearance.BorderSize = 0;
            this.buttonLastPage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonLastPage.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.buttonLastPage.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(41)))), ((int)(((byte)(59)))));
            this.buttonLastPage.Location = new System.Drawing.Point(422, 3);
            this.buttonLastPage.Name = "buttonLastPage";
            this.buttonLastPage.Size = new System.Drawing.Size(42, 25);
            this.buttonLastPage.TabIndex = 6;
            this.buttonLastPage.Text = ">>";
            this.buttonLastPage.UseVisualStyleBackColor = false;
            this.buttonLastPage.Click += new System.EventHandler(this.buttonLastPage_Click);

            // labelPageStatus
            this.labelPageStatus.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelPageStatus.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.labelPageStatus.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(85)))), ((int)(((byte)(105)))));
            this.labelPageStatus.Location = new System.Drawing.Point(740, 6);
            this.labelPageStatus.Name = "labelPageStatus";
            this.labelPageStatus.Size = new System.Drawing.Size(220, 18);
            this.labelPageStatus.TabIndex = 7;
            this.labelPageStatus.Text = "0-0 / 0 sinh vien";
            this.labelPageStatus.TextAlign = System.Drawing.ContentAlignment.MiddleRight;

            // StudentInClassForm
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1000, 600);
            this.Controls.Add(this.panelMain);
            this.MinimumSize = new System.Drawing.Size(1000, 600);
            this.Name = "StudentInClassForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Danh sach sinh vien";
            this.panelMain.ResumeLayout(false);
            this.panelContent.ResumeLayout(false);
            this.panelContent.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewStudents)).EndInit();
            this.panelPagination.ResumeLayout(false);
            this.panelPagination.PerformLayout();
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.Panel panelMain;
        private System.Windows.Forms.Panel panelContent;
        private System.Windows.Forms.Label labelClassInfo;
        private System.Windows.Forms.DataGridView dataGridViewStudents;
        private System.Windows.Forms.Panel panelPagination;
        private System.Windows.Forms.Label labelRowsPerPage;
        private System.Windows.Forms.ComboBox comboBoxPageSize;
        private System.Windows.Forms.Button buttonFirstPage;
        private System.Windows.Forms.Button buttonPreviousPage;
        private System.Windows.Forms.Label labelPageInfo;
        private System.Windows.Forms.Button buttonNextPage;
        private System.Windows.Forms.Button buttonLastPage;
        private System.Windows.Forms.Label labelPageStatus;
    }
}
