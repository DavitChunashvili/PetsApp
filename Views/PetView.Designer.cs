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
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            btnDelete = new Button();
            btnEdit = new Button();
            btnAddNew = new Button();
            dataGridView = new DataGridView();
            btnSearch = new Button();
            txtSearch = new TextBox();
            label6 = new Label();
            tabPagePetDetail = new TabPage();
            CancelButton = new Button();
            SaveButton = new Button();
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
            tabPage1.SuspendLayout();
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
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1048, 67);
            panel1.TabIndex = 1;
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPagePetDetail);
            tabControl1.Dock = DockStyle.Fill;
            tabControl1.Location = new Point(0, 67);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(1048, 494);
            tabControl1.TabIndex = 2;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(btnDelete);
            tabPage1.Controls.Add(btnEdit);
            tabPage1.Controls.Add(btnAddNew);
            tabPage1.Controls.Add(dataGridView);
            tabPage1.Controls.Add(btnSearch);
            tabPage1.Controls.Add(txtSearch);
            tabPage1.Controls.Add(label6);
            tabPage1.Location = new Point(4, 29);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(1040, 461);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Pet list";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(912, 195);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(120, 30);
            btnDelete.TabIndex = 13;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            // 
            // btnEdit
            // 
            btnEdit.Location = new Point(912, 159);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(120, 30);
            btnEdit.TabIndex = 12;
            btnEdit.Text = "Edit";
            btnEdit.UseVisualStyleBackColor = true;
            // 
            // btnAddNew
            // 
            btnAddNew.Location = new Point(912, 123);
            btnAddNew.Name = "btnAddNew";
            btnAddNew.Size = new Size(120, 30);
            btnAddNew.TabIndex = 11;
            btnAddNew.Text = "Add new";
            btnAddNew.UseVisualStyleBackColor = true;
            // 
            // dataGridView
            // 
            dataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView.Location = new Point(22, 81);
            dataGridView.Name = "dataGridView";
            dataGridView.RowHeadersWidth = 51;
            dataGridView.Size = new Size(884, 372);
            dataGridView.TabIndex = 10;
            // 
            // btnSearch
            // 
            btnSearch.Location = new Point(795, 45);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(120, 30);
            btnSearch.TabIndex = 9;
            btnSearch.Text = "Search";
            btnSearch.UseVisualStyleBackColor = true;
            // 
            // txtSearch
            // 
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
            tabPagePetDetail.Controls.Add(CancelButton);
            tabPagePetDetail.Controls.Add(SaveButton);
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
            // CancelButton
            // 
            CancelButton.Location = new Point(291, 329);
            CancelButton.Name = "CancelButton";
            CancelButton.Size = new Size(189, 47);
            CancelButton.TabIndex = 9;
            CancelButton.Text = "Cancel";
            CancelButton.UseVisualStyleBackColor = true;
            // 
            // SaveButton
            // 
            SaveButton.Location = new Point(71, 329);
            SaveButton.Name = "SaveButton";
            SaveButton.Size = new Size(189, 47);
            SaveButton.TabIndex = 8;
            SaveButton.Text = "Save";
            SaveButton.UseVisualStyleBackColor = true;
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
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView).EndInit();
            tabPagePetDetail.ResumeLayout(false);
            tabPagePetDetail.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Label label1;
        private Panel panel1;
        private TabControl tabControl1;
        private TabPage tabPage1;
        private TabPage tabPagePetDetail;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label6;
        private Button CancelButton;
        private Button SaveButton;
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
    }
}