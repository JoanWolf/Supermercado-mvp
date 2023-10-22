namespace Supermarket_mvp.Vista
{
    partial class MainView
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
            pictureBox2 = new PictureBox();
            panel1 = new Panel();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            BtnProducts = new Button();
            label1 = new Label();
            pictureBox3 = new PictureBox();
            BtnProviders = new Button();
            BtnCategory = new Button();
            BtnExit = new Button();
            BtnPayMode = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            SuspendLayout();
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = Color.OliveDrab;
            pictureBox2.Dock = DockStyle.Top;
            pictureBox2.Image = Properties.Resources.sell;
            pictureBox2.Location = new Point(0, 0);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(225, 127);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 3;
            pictureBox2.TabStop = false;
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.Control;
            panel1.Controls.Add(label5);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(BtnProducts);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(pictureBox3);
            panel1.Controls.Add(BtnProviders);
            panel1.Controls.Add(BtnCategory);
            panel1.Controls.Add(BtnExit);
            panel1.Controls.Add(BtnPayMode);
            panel1.Controls.Add(pictureBox2);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(225, 953);
            panel1.TabIndex = 4;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.YellowGreen;
            label5.Font = new Font("Segoe UI", 15F, FontStyle.Bold, GraphicsUnit.Point);
            label5.ForeColor = Color.White;
            label5.Location = new Point(38, 747);
            label5.Name = "label5";
            label5.Size = new Size(143, 35);
            label5.TabIndex = 16;
            label5.Text = "CATEGORY";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.YellowGreen;
            label4.Font = new Font("Segoe UI", 15F, FontStyle.Bold, GraphicsUnit.Point);
            label4.ForeColor = Color.White;
            label4.Location = new Point(38, 592);
            label4.Name = "label4";
            label4.Size = new Size(151, 35);
            label4.TabIndex = 15;
            label4.Text = "PROVIDERS";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.YellowGreen;
            label3.Font = new Font("Segoe UI", 15F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = Color.White;
            label3.Location = new Point(42, 440);
            label3.Name = "label3";
            label3.Size = new Size(146, 35);
            label3.TabIndex = 14;
            label3.Text = "PRODUCTS";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.YellowGreen;
            label2.Font = new Font("Segoe UI", 15F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.White;
            label2.Location = new Point(42, 291);
            label2.Name = "label2";
            label2.Size = new Size(141, 35);
            label2.TabIndex = 13;
            label2.Text = "PAY MODE";
            // 
            // BtnProducts
            // 
            BtnProducts.BackgroundImage = Properties.Resources.producto;
            BtnProducts.BackgroundImageLayout = ImageLayout.Zoom;
            BtnProducts.Location = new Point(0, 331);
            BtnProducts.Name = "BtnProducts";
            BtnProducts.Size = new Size(225, 127);
            BtnProducts.TabIndex = 9;
            BtnProducts.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.YellowGreen;
            label1.Font = new Font("Segoe UI", 17F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.Yellow;
            label1.Location = new Point(-1, 133);
            label1.Name = "label1";
            label1.Size = new Size(232, 40);
            label1.TabIndex = 12;
            label1.Text = "SUPER MARKET";
            // 
            // pictureBox3
            // 
            pictureBox3.BackColor = Color.YellowGreen;
            pictureBox3.Location = new Point(-3, 801);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(228, 11);
            pictureBox3.TabIndex = 11;
            pictureBox3.TabStop = false;
            // 
            // BtnProviders
            // 
            BtnProviders.BackgroundImage = Properties.Resources.Proveedores;
            BtnProviders.BackgroundImageLayout = ImageLayout.Zoom;
            BtnProviders.Location = new Point(0, 483);
            BtnProviders.Name = "BtnProviders";
            BtnProviders.Size = new Size(225, 127);
            BtnProviders.TabIndex = 8;
            BtnProviders.UseVisualStyleBackColor = true;
            // 
            // BtnCategory
            // 
            BtnCategory.BackgroundImage = Properties.Resources.categorias;
            BtnCategory.BackgroundImageLayout = ImageLayout.Zoom;
            BtnCategory.Location = new Point(-3, 634);
            BtnCategory.Name = "BtnCategory";
            BtnCategory.Size = new Size(225, 127);
            BtnCategory.TabIndex = 7;
            BtnCategory.UseVisualStyleBackColor = true;
            // 
            // BtnExit
            // 
            BtnExit.BackColor = Color.OliveDrab;
            BtnExit.BackgroundImage = Properties.Resources.salida;
            BtnExit.BackgroundImageLayout = ImageLayout.Zoom;
            BtnExit.Location = new Point(-3, 817);
            BtnExit.Name = "BtnExit";
            BtnExit.Size = new Size(230, 143);
            BtnExit.TabIndex = 6;
            BtnExit.UseVisualStyleBackColor = false;
            // 
            // BtnPayMode
            // 
            BtnPayMode.BackgroundImage = Properties.Resources.buy;
            BtnPayMode.BackgroundImageLayout = ImageLayout.Zoom;
            BtnPayMode.Location = new Point(0, 179);
            BtnPayMode.Name = "BtnPayMode";
            BtnPayMode.Size = new Size(225, 127);
            BtnPayMode.TabIndex = 5;
            BtnPayMode.UseVisualStyleBackColor = true;
            // 
            // MainView
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1182, 953);
            Controls.Add(panel1);
            IsMdiContainer = true;
            Name = "MainView";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Supermarket ";
            WindowState = FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private PictureBox pictureBox2;
        private Panel panel1;
        private Button BtnPayMode;
        private Button BtnExit;
        private Button BtnCategory;
        private Button BtnProviders;
        private Button BtnProducts;
        private PictureBox pictureBox3;
        private Label label1;
        private Label label3;
        private Label label2;
        private Label label4;
        private Label label5;
    }
}