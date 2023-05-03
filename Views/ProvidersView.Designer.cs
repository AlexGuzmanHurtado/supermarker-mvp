namespace Supermarket_mvp.Views
{
    partial class ProvidersView
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ProvidersView));
            panel1 = new Panel();
            pictureBox2 = new PictureBox();
            label1 = new Label();
            tabControl1 = new TabControl();
            TabProvidersList = new TabPage();
            tabProvidersDetail = new TabPage();
            BtnSearch = new Button();
            textBox1 = new TextBox();
            label2 = new Label();
            BtnClose = new Button();
            BtnDelete = new Button();
            BtnEdit = new Button();
            BtnNew = new Button();
            DgProducts = new DataGridView();
            BtnCancel = new Button();
            BtnSave = new Button();
            TxtProvidersAnnotation = new TextBox();
            label5 = new Label();
            TxtProvidersName = new TextBox();
            label4 = new Label();
            TxtProvidersId = new TextBox();
            label3 = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            tabControl1.SuspendLayout();
            TabProvidersList.SuspendLayout();
            tabProvidersDetail.SuspendLayout();
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
            panel1.TabIndex = 4;
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
            label1.Size = new Size(151, 29);
            label1.TabIndex = 0;
            label1.Text = "PROVIDERS";
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(TabProvidersList);
            tabControl1.Controls.Add(tabProvidersDetail);
            tabControl1.Dock = DockStyle.Fill;
            tabControl1.Location = new Point(0, 125);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(800, 325);
            tabControl1.TabIndex = 5;
            // 
            // TabProvidersList
            // 
            TabProvidersList.Controls.Add(BtnSearch);
            TabProvidersList.Controls.Add(textBox1);
            TabProvidersList.Controls.Add(label2);
            TabProvidersList.Controls.Add(BtnClose);
            TabProvidersList.Controls.Add(BtnDelete);
            TabProvidersList.Controls.Add(BtnEdit);
            TabProvidersList.Controls.Add(BtnNew);
            TabProvidersList.Controls.Add(DgProducts);
            TabProvidersList.Location = new Point(4, 29);
            TabProvidersList.Name = "TabProvidersList";
            TabProvidersList.Padding = new Padding(3);
            TabProvidersList.Size = new Size(792, 292);
            TabProvidersList.TabIndex = 0;
            TabProvidersList.Text = "Providers List";
            TabProvidersList.UseVisualStyleBackColor = true;
            // 
            // tabProvidersDetail
            // 
            tabProvidersDetail.Controls.Add(BtnCancel);
            tabProvidersDetail.Controls.Add(BtnSave);
            tabProvidersDetail.Controls.Add(TxtProvidersAnnotation);
            tabProvidersDetail.Controls.Add(label5);
            tabProvidersDetail.Controls.Add(TxtProvidersName);
            tabProvidersDetail.Controls.Add(label4);
            tabProvidersDetail.Controls.Add(TxtProvidersId);
            tabProvidersDetail.Controls.Add(label3);
            tabProvidersDetail.Location = new Point(4, 29);
            tabProvidersDetail.Name = "tabProvidersDetail";
            tabProvidersDetail.Padding = new Padding(3);
            tabProvidersDetail.Size = new Size(792, 292);
            tabProvidersDetail.TabIndex = 1;
            tabProvidersDetail.Text = "Providers Detail";
            tabProvidersDetail.UseVisualStyleBackColor = true;
            // 
            // BtnSearch
            // 
            BtnSearch.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            BtnSearch.Image = Properties.Resources.search_small;
            BtnSearch.Location = new Point(346, 19);
            BtnSearch.Name = "BtnSearch";
            BtnSearch.Size = new Size(47, 41);
            BtnSearch.TabIndex = 21;
            BtnSearch.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(30, 33);
            textBox1.Name = "textBox1";
            textBox1.PlaceholderText = "Data Providers Search";
            textBox1.Size = new Size(297, 27);
            textBox1.TabIndex = 20;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Showcard Gothic", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(25, 4);
            label2.Name = "label2";
            label2.Size = new Size(250, 29);
            label2.TabIndex = 19;
            label2.Text = "Search Providers";
            // 
            // BtnClose
            // 
            BtnClose.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            BtnClose.Image = Properties.Resources.cerrar;
            BtnClose.Location = new Point(594, 216);
            BtnClose.Name = "BtnClose";
            BtnClose.Size = new Size(174, 49);
            BtnClose.TabIndex = 18;
            BtnClose.UseVisualStyleBackColor = true;
            // 
            // BtnDelete
            // 
            BtnDelete.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            BtnDelete.Image = Properties.Resources.delete;
            BtnDelete.Location = new Point(594, 163);
            BtnDelete.Name = "BtnDelete";
            BtnDelete.Size = new Size(174, 47);
            BtnDelete.TabIndex = 17;
            BtnDelete.UseVisualStyleBackColor = true;
            // 
            // BtnEdit
            // 
            BtnEdit.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            BtnEdit.Image = Properties.Resources.edit;
            BtnEdit.Location = new Point(594, 102);
            BtnEdit.Name = "BtnEdit";
            BtnEdit.Size = new Size(174, 55);
            BtnEdit.TabIndex = 16;
            BtnEdit.UseVisualStyleBackColor = true;
            // 
            // BtnNew
            // 
            BtnNew.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            BtnNew.Image = Properties.Resources._new;
            BtnNew.Location = new Point(594, 45);
            BtnNew.Name = "BtnNew";
            BtnNew.Size = new Size(174, 51);
            BtnNew.TabIndex = 15;
            BtnNew.UseVisualStyleBackColor = true;
            // 
            // DgProducts
            // 
            DgProducts.AllowUserToAddRows = false;
            DgProducts.AllowUserToDeleteRows = false;
            DgProducts.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            DgProducts.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            DgProducts.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DgProducts.Location = new Point(30, 66);
            DgProducts.Name = "DgProducts";
            DgProducts.ReadOnly = true;
            DgProducts.RowHeadersWidth = 51;
            DgProducts.RowTemplate.Height = 29;
            DgProducts.Size = new Size(523, 222);
            DgProducts.TabIndex = 14;
            // 
            // BtnCancel
            // 
            BtnCancel.Image = Properties.Resources.cancel;
            BtnCancel.Location = new Point(611, 51);
            BtnCancel.Name = "BtnCancel";
            BtnCancel.Size = new Size(94, 47);
            BtnCancel.TabIndex = 23;
            BtnCancel.UseVisualStyleBackColor = true;
            // 
            // BtnSave
            // 
            BtnSave.Image = Properties.Resources.save;
            BtnSave.Location = new Point(476, 51);
            BtnSave.Name = "BtnSave";
            BtnSave.Size = new Size(94, 47);
            BtnSave.TabIndex = 22;
            BtnSave.UseVisualStyleBackColor = true;
            // 
            // TxtProvidersAnnotation
            // 
            TxtProvidersAnnotation.Location = new Point(88, 204);
            TxtProvidersAnnotation.Multiline = true;
            TxtProvidersAnnotation.Name = "TxtProvidersAnnotation";
            TxtProvidersAnnotation.PlaceholderText = "Providers Annotation";
            TxtProvidersAnnotation.Size = new Size(268, 67);
            TxtProvidersAnnotation.TabIndex = 21;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(88, 181);
            label5.Name = "label5";
            label5.Size = new Size(148, 20);
            label5.TabIndex = 20;
            label5.Text = "Providers Annotation";
            // 
            // TxtProvidersName
            // 
            TxtProvidersName.Location = new Point(88, 139);
            TxtProvidersName.Name = "TxtProvidersName";
            TxtProvidersName.PlaceholderText = "Providers Name";
            TxtProvidersName.Size = new Size(268, 27);
            TxtProvidersName.TabIndex = 19;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(88, 102);
            label4.Name = "label4";
            label4.Size = new Size(114, 20);
            label4.TabIndex = 18;
            label4.Text = "Providers Name";
            // 
            // TxtProvidersId
            // 
            TxtProvidersId.Location = new Point(88, 53);
            TxtProvidersId.Name = "TxtProvidersId";
            TxtProvidersId.ReadOnly = true;
            TxtProvidersId.Size = new Size(182, 27);
            TxtProvidersId.TabIndex = 17;
            TxtProvidersId.Text = "0";
            TxtProvidersId.TextAlign = HorizontalAlignment.Right;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(88, 21);
            label3.Name = "label3";
            label3.Size = new Size(87, 20);
            label3.TabIndex = 16;
            label3.Text = "Providers Id";
            // 
            // ProvidersView
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(tabControl1);
            Controls.Add(panel1);
            Name = "ProvidersView";
            Text = "ProvidersView";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            tabControl1.ResumeLayout(false);
            TabProvidersList.ResumeLayout(false);
            TabProvidersList.PerformLayout();
            tabProvidersDetail.ResumeLayout(false);
            tabProvidersDetail.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)DgProducts).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private PictureBox pictureBox2;
        private Label label1;
        private TabControl tabControl1;
        private TabPage TabProvidersList;
        private TabPage tabProvidersDetail;
        private Button BtnSearch;
        private TextBox textBox1;
        private Label label2;
        private Button BtnClose;
        private Button BtnDelete;
        private Button BtnEdit;
        private Button BtnNew;
        private DataGridView DgProducts;
        private Button BtnCancel;
        private Button BtnSave;
        private TextBox TxtProvidersAnnotation;
        private Label label5;
        private TextBox TxtProvidersName;
        private Label label4;
        private TextBox TxtProvidersId;
        private Label label3;
    }
}