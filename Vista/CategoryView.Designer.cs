namespace Supermarket_mvp.Vista
{
    partial class CategoryView
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
            panel1 = new Panel();
            pictureBox1 = new PictureBox();
            label1 = new Label();
            tabControl1 = new TabControl();
            tabPageCategoryList = new TabPage();
            BtnExit = new Button();
            BtnDelete = new Button();
            BtnEdit = new Button();
            BtnNew = new Button();
            DgCategory = new DataGridView();
            BtnSearch = new Button();
            TxtSearch = new TextBox();
            label2 = new Label();
            tabPageCategoryDetail = new TabPage();
            BtnCancel = new Button();
            TxtCategoryDescription = new TextBox();
            TxtCategoryName = new TextBox();
            TxtCategoryId = new TextBox();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            BtnSave = new Button();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            tabControl1.SuspendLayout();
            tabPageCategoryList.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)DgCategory).BeginInit();
            tabPageCategoryDetail.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ControlLight;
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(970, 147);
            panel1.TabIndex = 1;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.categorias;
            pictureBox1.Location = new Point(12, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(196, 125);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.Font = new Font("Segoe UI", 20F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(202, 0);
            label1.Name = "label1";
            label1.Size = new Size(269, 125);
            label1.TabIndex = 0;
            label1.Text = "CATEGORY";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPageCategoryList);
            tabControl1.Controls.Add(tabPageCategoryDetail);
            tabControl1.Dock = DockStyle.Fill;
            tabControl1.Location = new Point(0, 147);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(970, 515);
            tabControl1.TabIndex = 2;
            // 
            // tabPageCategoryList
            // 
            tabPageCategoryList.Controls.Add(BtnExit);
            tabPageCategoryList.Controls.Add(BtnDelete);
            tabPageCategoryList.Controls.Add(BtnEdit);
            tabPageCategoryList.Controls.Add(BtnNew);
            tabPageCategoryList.Controls.Add(DgCategory);
            tabPageCategoryList.Controls.Add(BtnSearch);
            tabPageCategoryList.Controls.Add(TxtSearch);
            tabPageCategoryList.Controls.Add(label2);
            tabPageCategoryList.Location = new Point(4, 29);
            tabPageCategoryList.Name = "tabPageCategoryList";
            tabPageCategoryList.Padding = new Padding(3);
            tabPageCategoryList.Size = new Size(962, 482);
            tabPageCategoryList.TabIndex = 0;
            tabPageCategoryList.Text = "Category List";
            tabPageCategoryList.UseVisualStyleBackColor = true;
            // 
            // BtnExit
            // 
            BtnExit.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            BtnExit.Image = Properties.Resources.cerrar;
            BtnExit.Location = new Point(803, 400);
            BtnExit.Name = "BtnExit";
            BtnExit.Size = new Size(147, 78);
            BtnExit.TabIndex = 15;
            BtnExit.UseVisualStyleBackColor = true;
            // 
            // BtnDelete
            // 
            BtnDelete.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            BtnDelete.Image = Properties.Resources.delete;
            BtnDelete.Location = new Point(803, 295);
            BtnDelete.Name = "BtnDelete";
            BtnDelete.Size = new Size(147, 78);
            BtnDelete.TabIndex = 14;
            BtnDelete.UseVisualStyleBackColor = true;
            // 
            // BtnEdit
            // 
            BtnEdit.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            BtnEdit.Image = Properties.Resources.edit;
            BtnEdit.Location = new Point(803, 189);
            BtnEdit.Name = "BtnEdit";
            BtnEdit.Size = new Size(147, 78);
            BtnEdit.TabIndex = 13;
            BtnEdit.UseVisualStyleBackColor = true;
            // 
            // BtnNew
            // 
            BtnNew.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            BtnNew.Image = Properties.Resources._new;
            BtnNew.Location = new Point(803, 73);
            BtnNew.Name = "BtnNew";
            BtnNew.Size = new Size(147, 78);
            BtnNew.TabIndex = 12;
            BtnNew.UseVisualStyleBackColor = true;
            // 
            // DgCategory
            // 
            DgCategory.AllowUserToAddRows = false;
            DgCategory.AllowUserToDeleteRows = false;
            DgCategory.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            DgCategory.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            DgCategory.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DgCategory.Location = new Point(12, 73);
            DgCategory.Name = "DgCategory";
            DgCategory.ReadOnly = true;
            DgCategory.RowHeadersWidth = 51;
            DgCategory.RowTemplate.Height = 29;
            DgCategory.Size = new Size(766, 405);
            DgCategory.TabIndex = 11;
            // 
            // BtnSearch
            // 
            BtnSearch.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            BtnSearch.BackColor = Color.Silver;
            BtnSearch.BackgroundImage = Properties.Resources.search;
            BtnSearch.BackgroundImageLayout = ImageLayout.Stretch;
            BtnSearch.Location = new Point(727, 18);
            BtnSearch.Name = "BtnSearch";
            BtnSearch.Size = new Size(51, 50);
            BtnSearch.TabIndex = 10;
            BtnSearch.UseVisualStyleBackColor = false;
            // 
            // TxtSearch
            // 
            TxtSearch.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            TxtSearch.Location = new Point(12, 30);
            TxtSearch.Name = "TxtSearch";
            TxtSearch.PlaceholderText = "Data to search";
            TxtSearch.Size = new Size(709, 27);
            TxtSearch.TabIndex = 9;
            // 
            // label2
            // 
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(12, 5);
            label2.Name = "label2";
            label2.Size = new Size(136, 22);
            label2.TabIndex = 8;
            label2.Text = "Search Category";
            // 
            // tabPageCategoryDetail
            // 
            tabPageCategoryDetail.Controls.Add(BtnCancel);
            tabPageCategoryDetail.Controls.Add(TxtCategoryDescription);
            tabPageCategoryDetail.Controls.Add(TxtCategoryName);
            tabPageCategoryDetail.Controls.Add(TxtCategoryId);
            tabPageCategoryDetail.Controls.Add(label5);
            tabPageCategoryDetail.Controls.Add(label4);
            tabPageCategoryDetail.Controls.Add(label3);
            tabPageCategoryDetail.Controls.Add(BtnSave);
            tabPageCategoryDetail.Location = new Point(4, 29);
            tabPageCategoryDetail.Name = "tabPageCategoryDetail";
            tabPageCategoryDetail.Padding = new Padding(3);
            tabPageCategoryDetail.Size = new Size(962, 482);
            tabPageCategoryDetail.TabIndex = 1;
            tabPageCategoryDetail.Text = "Category Detail";
            tabPageCategoryDetail.UseVisualStyleBackColor = true;
            // 
            // BtnCancel
            // 
            BtnCancel.Image = Properties.Resources.cancel;
            BtnCancel.ImageAlign = ContentAlignment.TopCenter;
            BtnCancel.Location = new Point(189, 382);
            BtnCancel.Name = "BtnCancel";
            BtnCancel.Size = new Size(125, 62);
            BtnCancel.TabIndex = 16;
            BtnCancel.Text = "Cancel";
            BtnCancel.TextAlign = ContentAlignment.BottomCenter;
            BtnCancel.UseVisualStyleBackColor = true;
            // 
            // TxtCategoryDescription
            // 
            TxtCategoryDescription.Location = new Point(21, 222);
            TxtCategoryDescription.Multiline = true;
            TxtCategoryDescription.Name = "TxtCategoryDescription";
            TxtCategoryDescription.PlaceholderText = "Category Description";
            TxtCategoryDescription.Size = new Size(408, 126);
            TxtCategoryDescription.TabIndex = 15;
            // 
            // TxtCategoryName
            // 
            TxtCategoryName.Location = new Point(19, 133);
            TxtCategoryName.Name = "TxtCategoryName";
            TxtCategoryName.PlaceholderText = "Category Name";
            TxtCategoryName.Size = new Size(410, 27);
            TxtCategoryName.TabIndex = 14;
            // 
            // TxtCategoryId
            // 
            TxtCategoryId.Location = new Point(19, 49);
            TxtCategoryId.Name = "TxtCategoryId";
            TxtCategoryId.ReadOnly = true;
            TxtCategoryId.Size = new Size(220, 27);
            TxtCategoryId.TabIndex = 13;
            TxtCategoryId.Text = "0";
            TxtCategoryId.TextAlign = HorizontalAlignment.Right;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(21, 195);
            label5.Name = "label5";
            label5.Size = new Size(157, 20);
            label5.TabIndex = 12;
            label5.Text = "Category Description";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(21, 105);
            label4.Name = "label4";
            label4.Size = new Size(119, 20);
            label4.TabIndex = 11;
            label4.Text = "Category Name";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(19, 24);
            label3.Name = "label3";
            label3.Size = new Size(91, 20);
            label3.TabIndex = 10;
            label3.Text = "Category Id";
            // 
            // BtnSave
            // 
            BtnSave.Image = Properties.Resources.save;
            BtnSave.ImageAlign = ContentAlignment.TopCenter;
            BtnSave.Location = new Point(19, 382);
            BtnSave.Name = "BtnSave";
            BtnSave.Size = new Size(125, 62);
            BtnSave.TabIndex = 9;
            BtnSave.Text = "Save";
            BtnSave.TextAlign = ContentAlignment.BottomCenter;
            BtnSave.UseVisualStyleBackColor = true;
            // 
            // CategoryView
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(970, 662);
            Controls.Add(tabControl1);
            Controls.Add(panel1);
            Name = "CategoryView";
            Text = "Category";
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            tabControl1.ResumeLayout(false);
            tabPageCategoryList.ResumeLayout(false);
            tabPageCategoryList.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)DgCategory).EndInit();
            tabPageCategoryDetail.ResumeLayout(false);
            tabPageCategoryDetail.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private PictureBox pictureBox1;
        private Label label1;
        private TabControl tabControl1;
        private TabPage tabPageCategoryList;
        private TabPage tabPageCategoryDetail;
        private Button BtnExit;
        private Button BtnDelete;
        private Button BtnEdit;
        private Button BtnNew;
        private DataGridView DgCategory;
        private Button BtnSearch;
        private TextBox TxtSearch;
        private Label label2;
        private Button BtnCancel;
        private TextBox TxtCategoryDescription;
        private TextBox TxtCategoryName;
        private TextBox TxtCategoryId;
        private Label label5;
        private Label label4;
        private Label label3;
        private Button BtnSave;
    }
}