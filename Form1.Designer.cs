namespace HY
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.gunaGradient2Panel1 = new Guna.UI.WinForms.GunaGradient2Panel();
            this.btncls = new Guna.UI.WinForms.GunaImageButton();
            this.gunaLabel5 = new Guna.UI.WinForms.GunaLabel();
            this.gunaLabel4 = new Guna.UI.WinForms.GunaLabel();
            this.gunaLabel3 = new Guna.UI.WinForms.GunaLabel();
            this.gunaLabel2 = new Guna.UI.WinForms.GunaLabel();
            this.gunaLabel1 = new Guna.UI.WinForms.GunaLabel();
            this.gunaPictureBox1 = new Guna.UI.WinForms.GunaPictureBox();
            this.btncategory = new Guna.UI.WinForms.GunaImageButton();
            this.btnmoney = new Guna.UI.WinForms.GunaImageButton();
            this.btnmembre = new Guna.UI.WinForms.GunaImageButton();
            this.btnreservation = new Guna.UI.WinForms.GunaImageButton();
            this.btnbook = new Guna.UI.WinForms.GunaImageButton();
            this.livre1 = new HY.Livre();
            this.prete1 = new HY.Prete();
            this.reservation1 = new HY.Reservation();
            this.membre1 = new HY.Membre();
            this.categorie1 = new HY.Categorie();
            this.gunaGradient2Panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gunaPictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // gunaGradient2Panel1
            // 
            this.gunaGradient2Panel1.BackColor = System.Drawing.Color.Transparent;
            this.gunaGradient2Panel1.Controls.Add(this.btncls);
            this.gunaGradient2Panel1.Controls.Add(this.gunaLabel5);
            this.gunaGradient2Panel1.Controls.Add(this.gunaLabel4);
            this.gunaGradient2Panel1.Controls.Add(this.gunaLabel3);
            this.gunaGradient2Panel1.Controls.Add(this.gunaLabel2);
            this.gunaGradient2Panel1.Controls.Add(this.gunaLabel1);
            this.gunaGradient2Panel1.Controls.Add(this.gunaPictureBox1);
            this.gunaGradient2Panel1.Controls.Add(this.btncategory);
            this.gunaGradient2Panel1.Controls.Add(this.btnmoney);
            this.gunaGradient2Panel1.Controls.Add(this.btnmembre);
            this.gunaGradient2Panel1.Controls.Add(this.btnreservation);
            this.gunaGradient2Panel1.Controls.Add(this.btnbook);
            this.gunaGradient2Panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.gunaGradient2Panel1.GradientColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(70)))));
            this.gunaGradient2Panel1.GradientColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(181)))), ((int)(((byte)(224)))));
            this.gunaGradient2Panel1.Location = new System.Drawing.Point(0, 0);
            this.gunaGradient2Panel1.Name = "gunaGradient2Panel1";
            this.gunaGradient2Panel1.Size = new System.Drawing.Size(1004, 122);
            this.gunaGradient2Panel1.TabIndex = 0;
            this.gunaGradient2Panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.gunaGradient2Panel1_Paint);
            // 
            // btncls
            // 
            this.btncls.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btncls.Image = ((System.Drawing.Image)(resources.GetObject("btncls.Image")));
            this.btncls.ImageSize = new System.Drawing.Size(24, 24);
            this.btncls.Location = new System.Drawing.Point(961, 12);
            this.btncls.Name = "btncls";
            this.btncls.OnHoverImage = null;
            this.btncls.OnHoverImageOffset = new System.Drawing.Point(0, 0);
            this.btncls.Size = new System.Drawing.Size(31, 38);
            this.btncls.TabIndex = 12;
            this.btncls.Click += new System.EventHandler(this.btncls_Click);
            // 
            // gunaLabel5
            // 
            this.gunaLabel5.AutoSize = true;
            this.gunaLabel5.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel5.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.gunaLabel5.Location = new System.Drawing.Point(672, 56);
            this.gunaLabel5.Name = "gunaLabel5";
            this.gunaLabel5.Size = new System.Drawing.Size(99, 22);
            this.gunaLabel5.TabIndex = 11;
            this.gunaLabel5.Text = "Categories";
            // 
            // gunaLabel4
            // 
            this.gunaLabel4.AutoSize = true;
            this.gunaLabel4.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.gunaLabel4.Location = new System.Drawing.Point(600, 56);
            this.gunaLabel4.Name = "gunaLabel4";
            this.gunaLabel4.Size = new System.Drawing.Size(45, 22);
            this.gunaLabel4.TabIndex = 10;
            this.gunaLabel4.Text = "Prêt";
            // 
            // gunaLabel3
            // 
            this.gunaLabel3.AutoSize = true;
            this.gunaLabel3.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.gunaLabel3.Location = new System.Drawing.Point(497, 56);
            this.gunaLabel3.Name = "gunaLabel3";
            this.gunaLabel3.Size = new System.Drawing.Size(79, 22);
            this.gunaLabel3.TabIndex = 9;
            this.gunaLabel3.Text = "Membre";
            // 
            // gunaLabel2
            // 
            this.gunaLabel2.AutoSize = true;
            this.gunaLabel2.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.gunaLabel2.Location = new System.Drawing.Point(381, 56);
            this.gunaLabel2.Name = "gunaLabel2";
            this.gunaLabel2.Size = new System.Drawing.Size(108, 22);
            this.gunaLabel2.TabIndex = 8;
            this.gunaLabel2.Text = "Reservation";
            // 
            // gunaLabel1
            // 
            this.gunaLabel1.AutoSize = true;
            this.gunaLabel1.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.gunaLabel1.Location = new System.Drawing.Point(308, 56);
            this.gunaLabel1.Name = "gunaLabel1";
            this.gunaLabel1.Size = new System.Drawing.Size(53, 22);
            this.gunaLabel1.TabIndex = 7;
            this.gunaLabel1.Text = "Livre";
            // 
            // gunaPictureBox1
            // 
            this.gunaPictureBox1.BaseColor = System.Drawing.Color.White;
            this.gunaPictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("gunaPictureBox1.Image")));
            this.gunaPictureBox1.Location = new System.Drawing.Point(3, -20);
            this.gunaPictureBox1.Name = "gunaPictureBox1";
            this.gunaPictureBox1.Size = new System.Drawing.Size(120, 120);
            this.gunaPictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.gunaPictureBox1.TabIndex = 6;
            this.gunaPictureBox1.TabStop = false;
            // 
            // btncategory
            // 
            this.btncategory.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btncategory.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btncategory.Image = ((System.Drawing.Image)(resources.GetObject("btncategory.Image")));
            this.btncategory.ImageSize = new System.Drawing.Size(44, 44);
            this.btncategory.Location = new System.Drawing.Point(689, 0);
            this.btncategory.Name = "btncategory";
            this.btncategory.OnHoverImage = null;
            this.btncategory.OnHoverImageOffset = new System.Drawing.Point(0, 0);
            this.btncategory.Size = new System.Drawing.Size(65, 62);
            this.btncategory.TabIndex = 5;
            this.btncategory.Click += new System.EventHandler(this.btncategory_Click);
            // 
            // btnmoney
            // 
            this.btnmoney.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnmoney.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnmoney.Image = ((System.Drawing.Image)(resources.GetObject("btnmoney.Image")));
            this.btnmoney.ImageSize = new System.Drawing.Size(44, 44);
            this.btnmoney.Location = new System.Drawing.Point(588, -10);
            this.btnmoney.Name = "btnmoney";
            this.btnmoney.OnHoverImage = null;
            this.btnmoney.OnHoverImageOffset = new System.Drawing.Point(0, 0);
            this.btnmoney.Size = new System.Drawing.Size(65, 74);
            this.btnmoney.TabIndex = 4;
            this.btnmoney.Click += new System.EventHandler(this.btnmoney_Click);
            // 
            // btnmembre
            // 
            this.btnmembre.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnmembre.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnmembre.Image = ((System.Drawing.Image)(resources.GetObject("btnmembre.Image")));
            this.btnmembre.ImageSize = new System.Drawing.Size(44, 44);
            this.btnmembre.Location = new System.Drawing.Point(500, -10);
            this.btnmembre.Name = "btnmembre";
            this.btnmembre.OnHoverImage = null;
            this.btnmembre.OnHoverImageOffset = new System.Drawing.Point(0, 0);
            this.btnmembre.Size = new System.Drawing.Size(65, 74);
            this.btnmembre.TabIndex = 3;
            this.btnmembre.Click += new System.EventHandler(this.btnmembre_Click);
            // 
            // btnreservation
            // 
            this.btnreservation.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnreservation.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnreservation.Image = ((System.Drawing.Image)(resources.GetObject("btnreservation.Image")));
            this.btnreservation.ImageSize = new System.Drawing.Size(44, 44);
            this.btnreservation.Location = new System.Drawing.Point(397, -10);
            this.btnreservation.Name = "btnreservation";
            this.btnreservation.OnHoverImage = null;
            this.btnreservation.OnHoverImageOffset = new System.Drawing.Point(0, 0);
            this.btnreservation.Size = new System.Drawing.Size(65, 74);
            this.btnreservation.TabIndex = 2;
            this.btnreservation.Click += new System.EventHandler(this.btnreservation_Click);
            // 
            // btnbook
            // 
            this.btnbook.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnbook.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnbook.Image = ((System.Drawing.Image)(resources.GetObject("btnbook.Image")));
            this.btnbook.ImageSize = new System.Drawing.Size(44, 44);
            this.btnbook.Location = new System.Drawing.Point(303, -10);
            this.btnbook.Name = "btnbook";
            this.btnbook.OnHoverImage = null;
            this.btnbook.OnHoverImageOffset = new System.Drawing.Point(0, 0);
            this.btnbook.Size = new System.Drawing.Size(65, 74);
            this.btnbook.TabIndex = 1;
            this.btnbook.Click += new System.EventHandler(this.btnbook_Click);
            // 
            // livre1
            // 
            this.livre1.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.livre1.Location = new System.Drawing.Point(0, 93);
            this.livre1.Name = "livre1";
            this.livre1.Size = new System.Drawing.Size(1004, 492);
            this.livre1.TabIndex = 1;
            // 
            // prete1
            // 
            this.prete1.Location = new System.Drawing.Point(0, 99);
            this.prete1.Name = "prete1";
            this.prete1.Size = new System.Drawing.Size(1004, 504);
            this.prete1.TabIndex = 5;
            // 
            // reservation1
            // 
            this.reservation1.Location = new System.Drawing.Point(4, 94);
            this.reservation1.Name = "reservation1";
            this.reservation1.Size = new System.Drawing.Size(1000, 492);
            this.reservation1.TabIndex = 4;
            // 
            // membre1
            // 
            this.membre1.Location = new System.Drawing.Point(0, 96);
            this.membre1.Name = "membre1";
            this.membre1.Size = new System.Drawing.Size(1004, 492);
            this.membre1.TabIndex = 3;
            // 
            // categorie1
            // 
            this.categorie1.Location = new System.Drawing.Point(3, 94);
            this.categorie1.Name = "categorie1";
            this.categorie1.Size = new System.Drawing.Size(1004, 492);
            this.categorie1.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1004, 577);
            this.Controls.Add(this.livre1);
            this.Controls.Add(this.gunaGradient2Panel1);
            this.Controls.Add(this.prete1);
            this.Controls.Add(this.reservation1);
            this.Controls.Add(this.membre1);
            this.Controls.Add(this.categorie1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.gunaGradient2Panel1.ResumeLayout(false);
            this.gunaGradient2Panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gunaPictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI.WinForms.GunaGradient2Panel gunaGradient2Panel1;
        private Guna.UI.WinForms.GunaPictureBox gunaPictureBox1;
        private Guna.UI.WinForms.GunaImageButton btncategory;
        private Guna.UI.WinForms.GunaImageButton btnmoney;
        private Guna.UI.WinForms.GunaImageButton btnmembre;
        private Guna.UI.WinForms.GunaImageButton btnreservation;
        private Guna.UI.WinForms.GunaImageButton btnbook;
        private Guna.UI.WinForms.GunaLabel gunaLabel5;
        private Guna.UI.WinForms.GunaLabel gunaLabel4;
        private Guna.UI.WinForms.GunaLabel gunaLabel3;
        private Guna.UI.WinForms.GunaLabel gunaLabel2;
        private Guna.UI.WinForms.GunaLabel gunaLabel1;
        private Guna.UI.WinForms.GunaImageButton btncls;
        private Livre livre1;
        private Categorie categorie1;
        private Membre membre1;
        private Reservation reservation1;
        private Prete prete1;
    }
}

