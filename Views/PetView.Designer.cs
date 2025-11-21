namespace MVP_Project.Views
{
    partial class PetView
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
            panel1 = new Panel();
            btnClose = new Button();
            tabControl1 = new TabControl();
            tabPagePetList = new TabPage();
            btnDelete = new Button();
            btnEdit = new Button();
            btnAddNew = new Button();
            dataGridView = new DataGridView();
            btnSearch = new Button();
            txtSearch = new TextBox();
            label6 = new Label();
            tabPagePetDetail = new TabPage();
            btnCancel = new Button();
            btnSave = new Button();
            txtPetColour = new TextBox();
            txtPetType = new TextBox();
            txtPetName = new TextBox();
            txtPetId = new TextBox();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            panel1.SuspendLayout();
            tabControl1.SuspendLayout();
            tabPagePetList.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView).BeginInit();
            tabPagePetDetail.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F);
            label1.Location = new Point(56, 20);
            label1.Name = "label1";
            label1.Size = new Size(54, 28);
            label1.TabIndex = 0;
            label1.Text = "PETS";
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(btnClose);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1048, 67);
            panel1.TabIndex = 1;
            // 
            // btnClose
            // 
            btnClose.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnClose.Location = new Point(985, 12);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(51, 43);
            btnClose.TabIndex = 10;
            btnClose.Text = "X";
            btnClose.UseVisualStyleBackColor = true;
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPagePetList);
            tabControl1.Controls.Add(tabPagePetDetail);
            tabControl1.Dock = DockStyle.Fill;
            tabControl1.Location = new Point(0, 67);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(1048, 494);
            tabControl1.TabIndex = 2;
            // 
            // tabPagePetList
            // 
            tabPagePetList.Controls.Add(btnDelete);
            tabPagePetList.Controls.Add(btnEdit);
            tabPagePetList.Controls.Add(btnAddNew);
            tabPagePetList.Controls.Add(dataGridView);
            tabPagePetList.Controls.Add(btnSearch);
            tabPagePetList.Controls.Add(txtSearch);
            tabPagePetList.Controls.Add(label6);
            tabPagePetList.Location = new Point(4, 29);
            tabPagePetList.Name = "tabPagePetList";
            tabPagePetList.Padding = new Padding(3);
            tabPagePetList.Size = new Size(1040, 461);
            tabPagePetList.TabIndex = 0;
            tabPagePetList.Text = "Pet list";
            tabPagePetList.UseVisualStyleBackColor = true;
            // 
            // btnDelete
            // 
            btnDelete.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnDelete.Location = new Point(912, 195);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(120, 30);
            btnDelete.TabIndex = 13;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            // 
            // btnEdit
            // 
            btnEdit.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnEdit.Location = new Point(912, 159);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(120, 30);
            btnEdit.TabIndex = 12;
            btnEdit.Text = "Edit";
            btnEdit.UseVisualStyleBackColor = true;
            // 
            // btnAddNew
            // 
            btnAddNew.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnAddNew.Location = new Point(912, 123);
            btnAddNew.Name = "btnAddNew";
            btnAddNew.Size = new Size(120, 30);
            btnAddNew.TabIndex = 11;
            btnAddNew.Text = "Add new";
            btnAddNew.UseVisualStyleBackColor = true;
            // 
            // dataGridView
            // 
            dataGridView.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView.Location = new Point(22, 81);
            dataGridView.Name = "dataGridView";
            dataGridView.RowHeadersWidth = 51;
            dataGridView.Size = new Size(884, 372);
            dataGridView.TabIndex = 10;
            // 
            // btnSearch
            // 
            btnSearch.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnSearch.Location = new Point(795, 45);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(120, 30);
            btnSearch.TabIndex = 9;
            btnSearch.Text = "Search";
            btnSearch.UseVisualStyleBackColor = true;
            // 
            // txtSearch
            // 
            txtSearch.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtSearch.Location = new Point(22, 45);
            txtSearch.Multiline = true;
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(767, 30);
            txtSearch.TabIndex = 8;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 10F);
            label6.Location = new Point(22, 19);
            label6.Name = "label6";
            label6.Size = new Size(94, 23);
            label6.TabIndex = 1;
            label6.Text = "Search Pet:";
            // 
            // tabPagePetDetail
            // 
            tabPagePetDetail.Controls.Add(btnCancel);
            tabPagePetDetail.Controls.Add(btnSave);
            tabPagePetDetail.Controls.Add(txtPetColour);
            tabPagePetDetail.Controls.Add(txtPetType);
            tabPagePetDetail.Controls.Add(txtPetName);
            tabPagePetDetail.Controls.Add(txtPetId);
            tabPagePetDetail.Controls.Add(label5);
            tabPagePetDetail.Controls.Add(label4);
            tabPagePetDetail.Controls.Add(label3);
            tabPagePetDetail.Controls.Add(label2);
            tabPagePetDetail.Location = new Point(4, 29);
            tabPagePetDetail.Name = "tabPagePetDetail";
            tabPagePetDetail.Padding = new Padding(3);
            tabPagePetDetail.Size = new Size(1040, 461);
            tabPagePetDetail.TabIndex = 1;
            tabPagePetDetail.Text = "Pet detail";
            tabPagePetDetail.UseVisualStyleBackColor = true;
            // 
            // btnCancel
            // 
            btnCancel.Location = new Point(291, 329);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(189, 47);
            btnCancel.TabIndex = 9;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            // 
            // btnSave
            // 
            btnSave.Location = new Point(71, 329);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(189, 47);
            btnSave.TabIndex = 8;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = true;
            // 
            // txtPetColour
            // 
            txtPetColour.Location = new Point(71, 269);
            txtPetColour.Multiline = true;
            txtPetColour.Name = "txtPetColour";
            txtPetColour.Size = new Size(409, 34);
            txtPetColour.TabIndex = 7;
            // 
            // txtPetType
            // 
            txtPetType.Location = new Point(291, 171);
            txtPetType.Multiline = true;
            txtPetType.Name = "txtPetType";
            txtPetType.Size = new Size(189, 34);
            txtPetType.TabIndex = 6;
            // 
            // txtPetName
            // 
            txtPetName.Location = new Point(71, 171);
            txtPetName.Multiline = true;
            txtPetName.Name = "txtPetName";
            txtPetName.Size = new Size(189, 34);
            txtPetName.TabIndex = 5;
            // 
            // txtPetId
            // 
            txtPetId.Location = new Point(71, 81);
            txtPetId.Multiline = true;
            txtPetId.Name = "txtPetId";
            txtPetId.Size = new Size(189, 34);
            txtPetId.TabIndex = 4;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 10F);
            label5.Location = new Point(291, 135);
            label5.Name = "label5";
            label5.Size = new Size(78, 23);
            label5.TabIndex = 3;
            label5.Text = "Pet Type:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 10F);
            label4.Location = new Point(71, 231);
            label4.Name = "label4";
            label4.Size = new Size(94, 23);
            label4.TabIndex = 2;
            label4.Text = "Pet Colour:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 10F);
            label3.Location = new Point(71, 135);
            label3.Name = "label3";
            label3.Size = new Size(89, 23);
            label3.TabIndex = 1;
            label3.Text = "Pet Name:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10F);
            label2.Location = new Point(71, 55);
            label2.Name = "label2";
            label2.Size = new Size(60, 23);
            label2.TabIndex = 0;
            label2.Text = "Pet ID:";
            // 
            // PetView
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1048, 561);
            Controls.Add(tabControl1);
            Controls.Add(panel1);
            Name = "PetView";
            Text = "PetView";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            tabControl1.ResumeLayout(false);
            tabPagePetList.ResumeLayout(false);
            tabPagePetList.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView).EndInit();
            tabPagePetDetail.ResumeLayout(false);
            tabPagePetDetail.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Label label1;
        private Panel panel1;
        private TabControl tabControl1;
        private TabPage tabPagePetList;
        private TabPage tabPagePetDetail;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label6;
        private Button btnCancel;
        private Button btnSave;
        private TextBox txtPetColour;
        private TextBox txtPetType;
        private TextBox txtPetName;
        private TextBox txtPetId;
        private Label label5;
        private Button btnEdit;
        private Button btnAddNew;
        private DataGridView dataGridView;
        private Button btnSearch;
        private TextBox txtSearch;
        private Button btnDelete;
        private Button btnClose;
    }
}