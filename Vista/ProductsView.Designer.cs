namespace Supermarket_mvp.Vista
{
    partial class ProductsView
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
            pictureBox1 = new PictureBox();
            label1 = new Label();
            panel1 = new Panel();
            tabControl1 = new TabControl();
            tabPageProductsList = new TabPage();
            BtnExit = new Button();
            BtnDelete = new Button();
            BtnEdit = new Button();
            BtnNew = new Button();
            DgProducts = new DataGridView();
            BtnSearch = new Button();
            TxtSearch = new TextBox();
            label2 = new Label();
            tabPageProductsDetails = new TabPage();
            CBoxIdCategory = new ComboBox();
            pictureBox2 = new PictureBox();
            BtnCancel = new Button();
            BtnSave = new Button();
            label7 = new Label();
            TxtStock = new TextBox();
            label6 = new Label();
            TxtPrice = new TextBox();
            label5 = new Label();
            TxtProductsName = new TextBox();
            label4 = new Label();
            TxtProductsId = new TextBox();
            label3 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel1.SuspendLayout();
            tabControl1.SuspendLayout();
            tabPageProductsList.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)DgProducts).BeginInit();
            tabPageProductsDetails.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.producto;
            pictureBox1.Location = new Point(12, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(196, 125);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.Font = new Font("Segoe UI", 26F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(224, 12);
            label1.Name = "label1";
            label1.Size = new Size(269, 125);
            label1.TabIndex = 0;
            label1.Text = "PRODUCTS";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ControlLight;
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1099, 147);
            panel1.TabIndex = 1;
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPageProductsList);
            tabControl1.Controls.Add(tabPageProductsDetails);
            tabControl1.Location = new Point(0, 153);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(1107, 548);
            tabControl1.TabIndex = 2;
            // 
            // tabPageProductsList
            // 
            tabPageProductsList.Controls.Add(BtnExit);
            tabPageProductsList.Controls.Add(BtnDelete);
            tabPageProductsList.Controls.Add(BtnEdit);
            tabPageProductsList.Controls.Add(BtnNew);
            tabPageProductsList.Controls.Add(DgProducts);
            tabPageProductsList.Controls.Add(BtnSearch);
            tabPageProductsList.Controls.Add(TxtSearch);
            tabPageProductsList.Controls.Add(label2);
            tabPageProductsList.Location = new Point(4, 29);
            tabPageProductsList.Name = "tabPageProductsList";
            tabPageProductsList.Padding = new Padding(3);
            tabPageProductsList.Size = new Size(1099, 515);
            tabPageProductsList.TabIndex = 0;
            tabPageProductsList.Text = "Pay Mode List";
            tabPageProductsList.UseVisualStyleBackColor = true;
            // 
            // BtnExit
            // 
            BtnExit.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            BtnExit.Image = Properties.Resources.cerrar;
            BtnExit.Location = new Point(835, 412);
            BtnExit.Name = "BtnExit";
            BtnExit.Size = new Size(147, 78);
            BtnExit.TabIndex = 15;
            BtnExit.UseVisualStyleBackColor = true;
            // 
            // BtnDelete
            // 
            BtnDelete.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            BtnDelete.Image = Properties.Resources.delete;
            BtnDelete.Location = new Point(835, 307);
            BtnDelete.Name = "BtnDelete";
            BtnDelete.Size = new Size(147, 78);
            BtnDelete.TabIndex = 14;
            BtnDelete.UseVisualStyleBackColor = true;
            // 
            // BtnEdit
            // 
            BtnEdit.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            BtnEdit.Image = Properties.Resources.edit;
            BtnEdit.Location = new Point(835, 201);
            BtnEdit.Name = "BtnEdit";
            BtnEdit.Size = new Size(147, 78);
            BtnEdit.TabIndex = 13;
            BtnEdit.UseVisualStyleBackColor = true;
            // 
            // BtnNew
            // 
            BtnNew.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            BtnNew.Image = Properties.Resources._new;
            BtnNew.Location = new Point(835, 85);
            BtnNew.Name = "BtnNew";
            BtnNew.Size = new Size(147, 78);
            BtnNew.TabIndex = 12;
            BtnNew.UseVisualStyleBackColor = true;
            // 
            // DgProducts
            // 
            DgProducts.AllowUserToAddRows = false;
            DgProducts.AllowUserToDeleteRows = false;
            DgProducts.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            DgProducts.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            DgProducts.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DgProducts.Location = new Point(8, 85);
            DgProducts.Name = "DgProducts";
            DgProducts.ReadOnly = true;
            DgProducts.RowHeadersWidth = 51;
            DgProducts.RowTemplate.Height = 29;
            DgProducts.Size = new Size(766, 405);
            DgProducts.TabIndex = 11;
            // 
            // BtnSearch
            // 
            BtnSearch.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            BtnSearch.BackColor = Color.Silver;
            BtnSearch.BackgroundImage = Properties.Resources.search;
            BtnSearch.BackgroundImageLayout = ImageLayout.Stretch;
            BtnSearch.Location = new Point(723, 30);
            BtnSearch.Name = "BtnSearch";
            BtnSearch.Size = new Size(51, 50);
            BtnSearch.TabIndex = 10;
            BtnSearch.UseVisualStyleBackColor = false;
            // 
            // TxtSearch
            // 
            TxtSearch.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            TxtSearch.Location = new Point(8, 42);
            TxtSearch.Name = "TxtSearch";
            TxtSearch.PlaceholderText = "Data to search";
            TxtSearch.Size = new Size(709, 27);
            TxtSearch.TabIndex = 9;
            // 
            // label2
            // 
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(8, 17);
            label2.Name = "label2";
            label2.Size = new Size(136, 22);
            label2.TabIndex = 8;
            label2.Text = "Search Product";
            // 
            // tabPageProductsDetails
            // 
            tabPageProductsDetails.Controls.Add(CBoxIdCategory);
            tabPageProductsDetails.Controls.Add(pictureBox2);
            tabPageProductsDetails.Controls.Add(BtnCancel);
            tabPageProductsDetails.Controls.Add(BtnSave);
            tabPageProductsDetails.Controls.Add(label7);
            tabPageProductsDetails.Controls.Add(TxtStock);
            tabPageProductsDetails.Controls.Add(label6);
            tabPageProductsDetails.Controls.Add(TxtPrice);
            tabPageProductsDetails.Controls.Add(label5);
            tabPageProductsDetails.Controls.Add(TxtProductsName);
            tabPageProductsDetails.Controls.Add(label4);
            tabPageProductsDetails.Controls.Add(TxtProductsId);
            tabPageProductsDetails.Controls.Add(label3);
            tabPageProductsDetails.Location = new Point(4, 29);
            tabPageProductsDetails.Name = "tabPageProductsDetails";
            tabPageProductsDetails.Padding = new Padding(3);
            tabPageProductsDetails.Size = new Size(1099, 515);
            tabPageProductsDetails.TabIndex = 1;
            tabPageProductsDetails.Text = "Pay Mode Details";
            tabPageProductsDetails.UseVisualStyleBackColor = true;
            // 
            // CBoxIdCategory
            // 
            CBoxIdCategory.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            CBoxIdCategory.FormattingEnabled = true;
            CBoxIdCategory.Location = new Point(62, 394);
            CBoxIdCategory.Name = "CBoxIdCategory";
            CBoxIdCategory.Size = new Size(410, 28);
            CBoxIdCategory.TabIndex = 18;
            // 
            // pictureBox2
            // 
            pictureBox2.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            pictureBox2.Image = Properties.Resources.seguro_de_calidad;
            pictureBox2.Location = new Point(569, 68);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(405, 271);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 2;
            pictureBox2.TabStop = false;
            // 
            // BtnCancel
            // 
            BtnCancel.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            BtnCancel.Image = Properties.Resources.cancel;
            BtnCancel.ImageAlign = ContentAlignment.TopCenter;
            BtnCancel.Location = new Point(792, 361);
            BtnCancel.Name = "BtnCancel";
            BtnCancel.Size = new Size(125, 62);
            BtnCancel.TabIndex = 17;
            BtnCancel.Text = "Cancel";
            BtnCancel.TextAlign = ContentAlignment.BottomCenter;
            BtnCancel.UseVisualStyleBackColor = true;
            // 
            // BtnSave
            // 
            BtnSave.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            BtnSave.Image = Properties.Resources.save;
            BtnSave.ImageAlign = ContentAlignment.TopCenter;
            BtnSave.Location = new Point(617, 361);
            BtnSave.Name = "BtnSave";
            BtnSave.Size = new Size(125, 62);
            BtnSave.TabIndex = 16;
            BtnSave.Text = "Save";
            BtnSave.TextAlign = ContentAlignment.BottomCenter;
            BtnSave.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label7.Location = new Point(66, 361);
            label7.Name = "label7";
            label7.Size = new Size(91, 20);
            label7.TabIndex = 14;
            label7.Text = "Id Category";
            // 
            // TxtStock
            // 
            TxtStock.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            TxtStock.Location = new Point(62, 297);
            TxtStock.Name = "TxtStock";
            TxtStock.PlaceholderText = "Stock";
            TxtStock.Size = new Size(410, 27);
            TxtStock.TabIndex = 13;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label6.Location = new Point(64, 269);
            label6.Name = "label6";
            label6.Size = new Size(47, 20);
            label6.TabIndex = 12;
            label6.Text = "Stock";
            // 
            // TxtPrice
            // 
            TxtPrice.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            TxtPrice.Location = new Point(62, 219);
            TxtPrice.Name = "TxtPrice";
            TxtPrice.PlaceholderText = "Price";
            TxtPrice.Size = new Size(410, 27);
            TxtPrice.TabIndex = 11;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(64, 191);
            label5.Name = "label5";
            label5.Size = new Size(43, 20);
            label5.TabIndex = 10;
            label5.Text = "Price";
            // 
            // TxtProductsName
            // 
            TxtProductsName.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            TxtProductsName.Location = new Point(62, 137);
            TxtProductsName.Name = "TxtProductsName";
            TxtProductsName.PlaceholderText = "Product Name";
            TxtProductsName.Size = new Size(410, 27);
            TxtProductsName.TabIndex = 9;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(64, 109);
            label4.Name = "label4";
            label4.Size = new Size(110, 20);
            label4.TabIndex = 8;
            label4.Text = "Product Name";
            // 
            // TxtProductsId
            // 
            TxtProductsId.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            TxtProductsId.Location = new Point(62, 68);
            TxtProductsId.Name = "TxtProductsId";
            TxtProductsId.ReadOnly = true;
            TxtProductsId.Size = new Size(220, 27);
            TxtProductsId.TabIndex = 7;
            TxtProductsId.Text = "0";
            TxtProductsId.TextAlign = HorizontalAlignment.Right;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(62, 43);
            label3.Name = "label3";
            label3.Size = new Size(82, 20);
            label3.TabIndex = 6;
            label3.Text = "Product Id";
            // 
            // ProductsView
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1099, 699);
            Controls.Add(tabControl1);
            Controls.Add(panel1);
            Name = "ProductsView";
            Text = "ProductsView";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel1.ResumeLayout(false);
            tabControl1.ResumeLayout(false);
            tabPageProductsList.ResumeLayout(false);
            tabPageProductsList.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)DgProducts).EndInit();
            tabPageProductsDetails.ResumeLayout(false);
            tabPageProductsDetails.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox pictureBox1;
        private Label label1;
        private Panel panel1;
        private TabControl tabControl1;
        private TabPage tabPageProductsList;
        private TabPage tabPageProductsDetails;
        private Button BtnExit;
        private Button BtnDelete;
        private Button BtnEdit;
        private Button BtnNew;
        private DataGridView DgProducts;
        private Button BtnSearch;
        private TextBox TxtSearch;
        private Label label2;
        private TextBox TxtProductsId;
        private Label label3;
        private TextBox TxtStock;
        private Label label6;
        private TextBox TxtPrice;
        private Label label5;
        private TextBox TxtProductsName;
        private Label label4;
        private Label label7;
        private Button BtnCancel;
        private Button BtnSave;
        private PictureBox pictureBox2;
        public static ComboBox CBoxIdCategory;
    }
}