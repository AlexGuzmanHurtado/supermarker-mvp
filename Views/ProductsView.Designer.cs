namespace Supermarket_mvp.Views
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ProductsView));
            panel1 = new Panel();
            pictureBox2 = new PictureBox();
            label1 = new Label();
            tabControl1 = new TabControl();
            tabProductList = new TabPage();
            tabProductDetail = new TabPage();
            DgProducts = new DataGridView();
            BtnNew = new Button();
            BtnClose = new Button();
            BtnDelete = new Button();
            BtnEdit = new Button();
            label2 = new Label();
            textBox1 = new TextBox();
            BtnSearch = new Button();
            BtnCancel = new Button();
            BtnSave = new Button();
            TxtProductsAnnotation = new TextBox();
            label5 = new Label();
            TxtProductsName = new TextBox();
            label4 = new Label();
            TxtProductsId = new TextBox();
            label3 = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            tabControl1.SuspendLayout();
            tabProductList.SuspendLayout();
            tabProductDetail.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)DgProducts).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(pictureBox2);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(800, 125);
            panel1.TabIndex = 3;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(21, 33);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(125, 62);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 1;
            pictureBox2.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Showcard Gothic", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(161, 45);
            label1.Name = "label1";
            label1.Size = new Size(148, 29);
            label1.TabIndex = 0;
            label1.Text = "PRODUCTS ";
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabProductList);
            tabControl1.Controls.Add(tabProductDetail);
            tabControl1.Dock = DockStyle.Fill;
            tabControl1.Location = new Point(0, 125);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(800, 325);
            tabControl1.TabIndex = 4;
            // 
            // tabProductList
            // 
            tabProductList.Controls.Add(BtnSearch);
            tabProductList.Controls.Add(textBox1);
            tabProductList.Controls.Add(label2);
            tabProductList.Controls.Add(BtnClose);
            tabProductList.Controls.Add(BtnDelete);
            tabProductList.Controls.Add(BtnEdit);
            tabProductList.Controls.Add(BtnNew);
            tabProductList.Controls.Add(DgProducts);
            tabProductList.Location = new Point(4, 29);
            tabProductList.Name = "tabProductList";
            tabProductList.Padding = new Padding(3);
            tabProductList.Size = new Size(792, 292);
            tabProductList.TabIndex = 0;
            tabProductList.Text = "Products List";
            tabProductList.UseVisualStyleBackColor = true;
            // 
            // tabProductDetail
            // 
            tabProductDetail.Controls.Add(BtnCancel);
            tabProductDetail.Controls.Add(BtnSave);
            tabProductDetail.Controls.Add(TxtProductsAnnotation);
            tabProductDetail.Controls.Add(label5);
            tabProductDetail.Controls.Add(TxtProductsName);
            tabProductDetail.Controls.Add(label4);
            tabProductDetail.Controls.Add(TxtProductsId);
            tabProductDetail.Controls.Add(label3);
            tabProductDetail.Location = new Point(4, 29);
            tabProductDetail.Name = "tabProductDetail";
            tabProductDetail.Padding = new Padding(3);
            tabProductDetail.Size = new Size(792, 292);
            tabProductDetail.TabIndex = 1;
            tabProductDetail.Text = "Products Detail";
            tabProductDetail.UseVisualStyleBackColor = true;
            // 
            // DgProducts
            // 
            DgProducts.AllowUserToAddRows = false;
            DgProducts.AllowUserToDeleteRows = false;
            DgProducts.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            DgProducts.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            DgProducts.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DgProducts.Location = new Point(8, 65);
            DgProducts.Name = "DgProducts";
            DgProducts.ReadOnly = true;
            DgProducts.RowHeadersWidth = 51;
            DgProducts.RowTemplate.Height = 29;
            DgProducts.Size = new Size(523, 222);
            DgProducts.TabIndex = 4;
            // 
            // BtnNew
            // 
            BtnNew.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            BtnNew.Image = Properties.Resources._new;
            BtnNew.Location = new Point(572, 44);
            BtnNew.Name = "BtnNew";
            BtnNew.Size = new Size(174, 51);
            BtnNew.TabIndex = 5;
            BtnNew.UseVisualStyleBackColor = true;
            // 
            // BtnClose
            // 
            BtnClose.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            BtnClose.Image = Properties.Resources.cerrar;
            BtnClose.Location = new Point(572, 215);
            BtnClose.Name = "BtnClose";
            BtnClose.Size = new Size(174, 49);
            BtnClose.TabIndex = 10;
            BtnClose.UseVisualStyleBackColor = true;
            // 
            // BtnDelete
            // 
            BtnDelete.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            BtnDelete.Image = Properties.Resources.delete;
            BtnDelete.Location = new Point(572, 162);
            BtnDelete.Name = "BtnDelete";
            BtnDelete.Size = new Size(174, 47);
            BtnDelete.TabIndex = 9;
            BtnDelete.UseVisualStyleBackColor = true;
            // 
            // BtnEdit
            // 
            BtnEdit.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            BtnEdit.Image = Properties.Resources.edit;
            BtnEdit.Location = new Point(572, 101);
            BtnEdit.Name = "BtnEdit";
            BtnEdit.Size = new Size(174, 55);
            BtnEdit.TabIndex = 8;
            BtnEdit.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Showcard Gothic", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(3, 3);
            label2.Name = "label2";
            label2.Size = new Size(241, 29);
            label2.TabIndex = 11;
            label2.Text = "Search Products";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(8, 32);
            textBox1.Name = "textBox1";
            textBox1.PlaceholderText = "Data Products Search";
            textBox1.Size = new Size(297, 27);
            textBox1.TabIndex = 12;
            // 
            // BtnSearch
            // 
            BtnSearch.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            BtnSearch.Image = Properties.Resources.search_small;
            BtnSearch.Location = new Point(324, 18);
            BtnSearch.Name = "BtnSearch";
            BtnSearch.Size = new Size(47, 41);
            BtnSearch.TabIndex = 13;
            BtnSearch.UseVisualStyleBackColor = true;
            // 
            // BtnCancel
            // 
            BtnCancel.Image = Properties.Resources.cancel;
            BtnCancel.Location = new Point(556, 49);
            BtnCancel.Name = "BtnCancel";
            BtnCancel.Size = new Size(94, 47);
            BtnCancel.TabIndex = 15;
            BtnCancel.UseVisualStyleBackColor = true;
            // 
            // BtnSave
            // 
            BtnSave.Image = Properties.Resources.save;
            BtnSave.Location = new Point(421, 49);
            BtnSave.Name = "BtnSave";
            BtnSave.Size = new Size(94, 47);
            BtnSave.TabIndex = 14;
            BtnSave.UseVisualStyleBackColor = true;
            // 
            // TxtProductsAnnotation
            // 
            TxtProductsAnnotation.Location = new Point(33, 202);
            TxtProductsAnnotation.Multiline = true;
            TxtProductsAnnotation.Name = "TxtProductsAnnotation";
            TxtProductsAnnotation.PlaceholderText = "Products Annotation";
            TxtProductsAnnotation.Size = new Size(268, 67);
            TxtProductsAnnotation.TabIndex = 13;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(33, 179);
            label5.Name = "label5";
            label5.Size = new Size(144, 20);
            label5.TabIndex = 12;
            label5.Text = "Products Annotation";
            // 
            // TxtProductsName
            // 
            TxtProductsName.Location = new Point(33, 137);
            TxtProductsName.Name = "TxtProductsName";
            TxtProductsName.PlaceholderText = "Products Name";
            TxtProductsName.Size = new Size(268, 27);
            TxtProductsName.TabIndex = 11;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(33, 100);
            label4.Name = "label4";
            label4.Size = new Size(110, 20);
            label4.TabIndex = 10;
            label4.Text = "Products Name";
            // 
            // TxtProductsId
            // 
            TxtProductsId.Location = new Point(33, 51);
            TxtProductsId.Name = "TxtProductsId";
            TxtProductsId.ReadOnly = true;
            TxtProductsId.Size = new Size(182, 27);
            TxtProductsId.TabIndex = 9;
            TxtProductsId.Text = "0";
            TxtProductsId.TextAlign = HorizontalAlignment.Right;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(33, 19);
            label3.Name = "label3";
            label3.Size = new Size(83, 20);
            label3.TabIndex = 8;
            label3.Text = "Products Id";
            // 
            // ProductsView
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(tabControl1);
            Controls.Add(panel1);
            Name = "ProductsView";
            Text = "ProductsView";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            tabControl1.ResumeLayout(false);
            tabProductList.ResumeLayout(false);
            tabProductList.PerformLayout();
            tabProductDetail.ResumeLayout(false);
            tabProductDetail.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)DgProducts).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private PictureBox pictureBox2;
        private Label label1;
        private TabControl tabControl1;
        private TabPage tabProductList;
        private TabPage tabProductDetail;
        private DataGridView DgProducts;
        private Button BtnNew;
        private Button BtnClose;
        private Button BtnDelete;
        private Button BtnEdit;
        private Label label2;
        private TextBox textBox1;
        private Button BtnSearch;
        private Button BtnCancel;
        private Button BtnSave;
        private TextBox TxtProductsAnnotation;
        private Label label5;
        private TextBox TxtProductsName;
        private Label label4;
        private TextBox TxtProductsId;
        private Label label3;
    }
}