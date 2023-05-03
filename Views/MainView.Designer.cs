namespace Supermarket_mvp.Views
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainView));
            panel1 = new Panel();
            BtnExit = new Button();
            BtnPayMode = new Button();
            pictureBox1 = new PictureBox();
            BtnProviders = new Button();
            BtnProducts = new Button();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(BtnProducts);
            panel1.Controls.Add(BtnProviders);
            panel1.Controls.Add(BtnExit);
            panel1.Controls.Add(BtnPayMode);
            panel1.Controls.Add(pictureBox1);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(250, 501);
            panel1.TabIndex = 0;
            // 
            // BtnExit
            // 
            BtnExit.BackgroundImage = Properties.Resources.cerrar1;
            BtnExit.BackgroundImageLayout = ImageLayout.Zoom;
            BtnExit.Dock = DockStyle.Bottom;
            BtnExit.Location = new Point(0, 424);
            BtnExit.Name = "BtnExit";
            BtnExit.Size = new Size(250, 77);
            BtnExit.TabIndex = 2;
            BtnExit.UseVisualStyleBackColor = true;
            // 
            // BtnPayMode
            // 
            BtnPayMode.BackgroundImage = Properties.Resources.buy2;
            BtnPayMode.BackgroundImageLayout = ImageLayout.Zoom;
            BtnPayMode.Location = new Point(3, 106);
            BtnPayMode.Name = "BtnPayMode";
            BtnPayMode.Size = new Size(247, 88);
            BtnPayMode.TabIndex = 1;
            BtnPayMode.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.sell;
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(250, 91);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // BtnProviders
            // 
            BtnProviders.BackgroundImage = (Image)resources.GetObject("BtnProviders.BackgroundImage");
            BtnProviders.BackgroundImageLayout = ImageLayout.Zoom;
            BtnProviders.Location = new Point(3, 215);
            BtnProviders.Name = "BtnProviders";
            BtnProviders.Size = new Size(247, 88);
            BtnProviders.TabIndex = 3;
            BtnProviders.UseVisualStyleBackColor = true;
            // 
            // BtnProducts
            // 
            BtnProducts.BackgroundImage = (Image)resources.GetObject("BtnProducts.BackgroundImage");
            BtnProducts.BackgroundImageLayout = ImageLayout.Zoom;
            BtnProducts.Location = new Point(3, 309);
            BtnProducts.Name = "BtnProducts";
            BtnProducts.Size = new Size(247, 88);
            BtnProducts.TabIndex = 4;
            BtnProducts.UseVisualStyleBackColor = true;
            // 
            // MainView
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1257, 501);
            Controls.Add(panel1);
            IsMdiContainer = true;
            Name = "MainView";
            Text = "Supermarker";
            WindowState = FormWindowState.Maximized;
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Button BtnPayMode;
        private PictureBox pictureBox1;
        private Button BtnExit;
        private Button BtnProducts;
        private Button BtnProviders;
    }
}