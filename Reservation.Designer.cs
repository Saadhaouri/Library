namespace HY
{
    partial class Reservation
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Reservation));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.gunaLabel1 = new Guna.UI.WinForms.GunaLabel();
            this.MemberBox = new Guna.UI.WinForms.GunaComboBox();
            this.LivreBox = new Guna.UI.WinForms.GunaComboBox();
            this.DateR = new Guna.UI.WinForms.GunaDateTimePicker();
            this.StatusBox = new Guna.UI.WinForms.GunaComboBox();
            this.gunaLabel2 = new Guna.UI.WinForms.GunaLabel();
            this.gunaLabel3 = new Guna.UI.WinForms.GunaLabel();
            this.gunaLabel4 = new Guna.UI.WinForms.GunaLabel();
            this.gunaLabel5 = new Guna.UI.WinForms.GunaLabel();
            this.gunaLabel6 = new Guna.UI.WinForms.GunaLabel();
            this.btnclear = new Guna.UI.WinForms.GunaAdvenceButton();
            this.btndelete = new Guna.UI.WinForms.GunaAdvenceButton();
            this.btnupdate = new Guna.UI.WinForms.GunaAdvenceButton();
            this.btnadd = new Guna.UI.WinForms.GunaAdvenceButton();
            this.btnread = new Guna.UI.WinForms.GunaAdvenceButton();
            this.DGV = new Guna.UI.WinForms.GunaDataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Membere = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Livre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Date_res = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.DGV)).BeginInit();
            this.SuspendLayout();
            // 
            // gunaLabel1
            // 
            this.gunaLabel1.AutoSize = true;
            this.gunaLabel1.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel1.Location = new System.Drawing.Point(412, 0);
            this.gunaLabel1.Name = "gunaLabel1";
            this.gunaLabel1.Size = new System.Drawing.Size(113, 25);
            this.gunaLabel1.TabIndex = 1;
            this.gunaLabel1.Text = "Reservation";
            // 
            // MemberBox
            // 
            this.MemberBox.BackColor = System.Drawing.Color.Transparent;
            this.MemberBox.BaseColor = System.Drawing.Color.White;
            this.MemberBox.BorderColor = System.Drawing.Color.Silver;
            this.MemberBox.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.MemberBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.MemberBox.FocusedColor = System.Drawing.Color.Empty;
            this.MemberBox.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.MemberBox.ForeColor = System.Drawing.Color.Black;
            this.MemberBox.FormattingEnabled = true;
            this.MemberBox.Location = new System.Drawing.Point(137, 114);
            this.MemberBox.Name = "MemberBox";
            this.MemberBox.OnHoverItemBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.MemberBox.OnHoverItemForeColor = System.Drawing.Color.White;
            this.MemberBox.Size = new System.Drawing.Size(169, 26);
            this.MemberBox.TabIndex = 2;
            // 
            // LivreBox
            // 
            this.LivreBox.BackColor = System.Drawing.Color.Transparent;
            this.LivreBox.BaseColor = System.Drawing.Color.White;
            this.LivreBox.BorderColor = System.Drawing.Color.Silver;
            this.LivreBox.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.LivreBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.LivreBox.FocusedColor = System.Drawing.Color.Empty;
            this.LivreBox.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.LivreBox.ForeColor = System.Drawing.Color.Black;
            this.LivreBox.FormattingEnabled = true;
            this.LivreBox.Location = new System.Drawing.Point(137, 146);
            this.LivreBox.Name = "LivreBox";
            this.LivreBox.OnHoverItemBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.LivreBox.OnHoverItemForeColor = System.Drawing.Color.White;
            this.LivreBox.Size = new System.Drawing.Size(169, 26);
            this.LivreBox.TabIndex = 3;
            // 
            // DateR
            // 
            this.DateR.BaseColor = System.Drawing.Color.White;
            this.DateR.BorderColor = System.Drawing.Color.Silver;
            this.DateR.CustomFormat = null;
            this.DateR.DropDownAlign = System.Windows.Forms.LeftRightAlignment.Right;
            this.DateR.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.DateR.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.DateR.ForeColor = System.Drawing.Color.Black;
            this.DateR.Location = new System.Drawing.Point(137, 178);
            this.DateR.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.DateR.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.DateR.Name = "DateR";
            this.DateR.OnHoverBaseColor = System.Drawing.Color.White;
            this.DateR.OnHoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.DateR.OnHoverForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.DateR.OnPressedColor = System.Drawing.Color.Black;
            this.DateR.Size = new System.Drawing.Size(169, 30);
            this.DateR.TabIndex = 4;
            this.DateR.Text = "Friday, June 2, 2023";
            this.DateR.Value = new System.DateTime(2023, 6, 2, 16, 8, 24, 861);
            // 
            // StatusBox
            // 
            this.StatusBox.BackColor = System.Drawing.Color.Transparent;
            this.StatusBox.BaseColor = System.Drawing.Color.White;
            this.StatusBox.BorderColor = System.Drawing.Color.Silver;
            this.StatusBox.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.StatusBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.StatusBox.FocusedColor = System.Drawing.Color.Empty;
            this.StatusBox.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.StatusBox.ForeColor = System.Drawing.Color.Black;
            this.StatusBox.FormattingEnabled = true;
            this.StatusBox.Items.AddRange(new object[] {
            "Attende",
            "OK"});
            this.StatusBox.Location = new System.Drawing.Point(137, 214);
            this.StatusBox.Name = "StatusBox";
            this.StatusBox.OnHoverItemBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.StatusBox.OnHoverItemForeColor = System.Drawing.Color.White;
            this.StatusBox.Size = new System.Drawing.Size(169, 26);
            this.StatusBox.TabIndex = 5;
            // 
            // gunaLabel2
            // 
            this.gunaLabel2.AutoSize = true;
            this.gunaLabel2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel2.Location = new System.Drawing.Point(43, 114);
            this.gunaLabel2.Name = "gunaLabel2";
            this.gunaLabel2.Size = new System.Drawing.Size(67, 19);
            this.gunaLabel2.TabIndex = 6;
            this.gunaLabel2.Text = "Member";
            // 
            // gunaLabel3
            // 
            this.gunaLabel3.AutoSize = true;
            this.gunaLabel3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel3.Location = new System.Drawing.Point(43, 149);
            this.gunaLabel3.Name = "gunaLabel3";
            this.gunaLabel3.Size = new System.Drawing.Size(49, 19);
            this.gunaLabel3.TabIndex = 7;
            this.gunaLabel3.Text = "Livre ";
            // 
            // gunaLabel4
            // 
            this.gunaLabel4.AutoSize = true;
            this.gunaLabel4.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel4.Location = new System.Drawing.Point(43, 185);
            this.gunaLabel4.Name = "gunaLabel4";
            this.gunaLabel4.Size = new System.Drawing.Size(46, 19);
            this.gunaLabel4.TabIndex = 8;
            this.gunaLabel4.Text = "Date ";
            // 
            // gunaLabel5
            // 
            this.gunaLabel5.AutoSize = true;
            this.gunaLabel5.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel5.Location = new System.Drawing.Point(43, 217);
            this.gunaLabel5.Name = "gunaLabel5";
            this.gunaLabel5.Size = new System.Drawing.Size(51, 19);
            this.gunaLabel5.TabIndex = 9;
            this.gunaLabel5.Text = "Status";
            // 
            // gunaLabel6
            // 
            this.gunaLabel6.AutoSize = true;
            this.gunaLabel6.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel6.Location = new System.Drawing.Point(133, 74);
            this.gunaLabel6.Name = "gunaLabel6";
            this.gunaLabel6.Size = new System.Drawing.Size(207, 19);
            this.gunaLabel6.TabIndex = 10;
            this.gunaLabel6.Text = "Information de la reservation ";
            // 
            // btnclear
            // 
            this.btnclear.AnimationHoverSpeed = 0.07F;
            this.btnclear.AnimationSpeed = 0.03F;
            this.btnclear.BackColor = System.Drawing.Color.Transparent;
            this.btnclear.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.btnclear.BorderColor = System.Drawing.Color.Black;
            this.btnclear.CheckedBaseColor = System.Drawing.Color.Gray;
            this.btnclear.CheckedBorderColor = System.Drawing.Color.Black;
            this.btnclear.CheckedForeColor = System.Drawing.Color.White;
            this.btnclear.CheckedImage = ((System.Drawing.Image)(resources.GetObject("btnclear.CheckedImage")));
            this.btnclear.CheckedLineColor = System.Drawing.Color.DimGray;
            this.btnclear.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnclear.FocusedColor = System.Drawing.Color.Empty;
            this.btnclear.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnclear.ForeColor = System.Drawing.Color.White;
            this.btnclear.Image = ((System.Drawing.Image)(resources.GetObject("btnclear.Image")));
            this.btnclear.ImageSize = new System.Drawing.Size(20, 20);
            this.btnclear.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.btnclear.Location = new System.Drawing.Point(716, 265);
            this.btnclear.Name = "btnclear";
            this.btnclear.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.btnclear.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnclear.OnHoverForeColor = System.Drawing.Color.White;
            this.btnclear.OnHoverImage = null;
            this.btnclear.OnHoverLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.btnclear.OnPressedColor = System.Drawing.Color.Black;
            this.btnclear.Radius = 8;
            this.btnclear.Size = new System.Drawing.Size(40, 35);
            this.btnclear.TabIndex = 27;
            // 
            // btndelete
            // 
            this.btndelete.AnimationHoverSpeed = 0.07F;
            this.btndelete.AnimationSpeed = 0.03F;
            this.btndelete.BackColor = System.Drawing.Color.Transparent;
            this.btndelete.BaseColor = System.Drawing.Color.Red;
            this.btndelete.BorderColor = System.Drawing.Color.Black;
            this.btndelete.CheckedBaseColor = System.Drawing.Color.Gray;
            this.btndelete.CheckedBorderColor = System.Drawing.Color.Black;
            this.btndelete.CheckedForeColor = System.Drawing.Color.White;
            this.btndelete.CheckedImage = ((System.Drawing.Image)(resources.GetObject("btndelete.CheckedImage")));
            this.btndelete.CheckedLineColor = System.Drawing.Color.DimGray;
            this.btndelete.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btndelete.FocusedColor = System.Drawing.Color.Empty;
            this.btndelete.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btndelete.ForeColor = System.Drawing.Color.White;
            this.btndelete.Image = ((System.Drawing.Image)(resources.GetObject("btndelete.Image")));
            this.btndelete.ImageSize = new System.Drawing.Size(20, 20);
            this.btndelete.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.btndelete.Location = new System.Drawing.Point(589, 265);
            this.btndelete.Name = "btndelete";
            this.btndelete.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.btndelete.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btndelete.OnHoverForeColor = System.Drawing.Color.White;
            this.btndelete.OnHoverImage = null;
            this.btndelete.OnHoverLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.btndelete.OnPressedColor = System.Drawing.Color.Black;
            this.btndelete.Radius = 8;
            this.btndelete.Size = new System.Drawing.Size(119, 35);
            this.btndelete.TabIndex = 26;
            this.btndelete.Text = "Suprimmer";
            this.btndelete.Click += new System.EventHandler(this.btndelete_Click);
            // 
            // btnupdate
            // 
            this.btnupdate.AnimationHoverSpeed = 0.07F;
            this.btnupdate.AnimationSpeed = 0.03F;
            this.btnupdate.BackColor = System.Drawing.Color.Transparent;
            this.btnupdate.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.btnupdate.BorderColor = System.Drawing.Color.Black;
            this.btnupdate.CheckedBaseColor = System.Drawing.Color.Gray;
            this.btnupdate.CheckedBorderColor = System.Drawing.Color.Black;
            this.btnupdate.CheckedForeColor = System.Drawing.Color.White;
            this.btnupdate.CheckedImage = ((System.Drawing.Image)(resources.GetObject("btnupdate.CheckedImage")));
            this.btnupdate.CheckedLineColor = System.Drawing.Color.DimGray;
            this.btnupdate.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnupdate.FocusedColor = System.Drawing.Color.Empty;
            this.btnupdate.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnupdate.ForeColor = System.Drawing.Color.White;
            this.btnupdate.Image = ((System.Drawing.Image)(resources.GetObject("btnupdate.Image")));
            this.btnupdate.ImageSize = new System.Drawing.Size(20, 20);
            this.btnupdate.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.btnupdate.Location = new System.Drawing.Point(451, 265);
            this.btnupdate.Name = "btnupdate";
            this.btnupdate.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.btnupdate.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnupdate.OnHoverForeColor = System.Drawing.Color.White;
            this.btnupdate.OnHoverImage = null;
            this.btnupdate.OnHoverLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.btnupdate.OnPressedColor = System.Drawing.Color.Black;
            this.btnupdate.Radius = 8;
            this.btnupdate.Size = new System.Drawing.Size(119, 35);
            this.btnupdate.TabIndex = 25;
            this.btnupdate.Text = "Modifier";
            this.btnupdate.Click += new System.EventHandler(this.btnupdate_Click);
            // 
            // btnadd
            // 
            this.btnadd.AnimationHoverSpeed = 0.07F;
            this.btnadd.AnimationSpeed = 0.03F;
            this.btnadd.BackColor = System.Drawing.Color.Transparent;
            this.btnadd.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.btnadd.BorderColor = System.Drawing.Color.Black;
            this.btnadd.CheckedBaseColor = System.Drawing.Color.Gray;
            this.btnadd.CheckedBorderColor = System.Drawing.Color.Black;
            this.btnadd.CheckedForeColor = System.Drawing.Color.White;
            this.btnadd.CheckedImage = ((System.Drawing.Image)(resources.GetObject("btnadd.CheckedImage")));
            this.btnadd.CheckedLineColor = System.Drawing.Color.DimGray;
            this.btnadd.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnadd.FocusedColor = System.Drawing.Color.Empty;
            this.btnadd.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnadd.ForeColor = System.Drawing.Color.White;
            this.btnadd.Image = ((System.Drawing.Image)(resources.GetObject("btnadd.Image")));
            this.btnadd.ImageSize = new System.Drawing.Size(20, 20);
            this.btnadd.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.btnadd.Location = new System.Drawing.Point(313, 265);
            this.btnadd.Name = "btnadd";
            this.btnadd.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.btnadd.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnadd.OnHoverForeColor = System.Drawing.Color.White;
            this.btnadd.OnHoverImage = null;
            this.btnadd.OnHoverLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.btnadd.OnPressedColor = System.Drawing.Color.Black;
            this.btnadd.Radius = 8;
            this.btnadd.Size = new System.Drawing.Size(119, 35);
            this.btnadd.TabIndex = 24;
            this.btnadd.Text = "Ajeuter";
            this.btnadd.Click += new System.EventHandler(this.btnadd_Click);
            // 
            // btnread
            // 
            this.btnread.AnimationHoverSpeed = 0.07F;
            this.btnread.AnimationSpeed = 0.03F;
            this.btnread.BackColor = System.Drawing.Color.Transparent;
            this.btnread.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.btnread.BorderColor = System.Drawing.Color.Black;
            this.btnread.CheckedBaseColor = System.Drawing.Color.Gray;
            this.btnread.CheckedBorderColor = System.Drawing.Color.Black;
            this.btnread.CheckedForeColor = System.Drawing.Color.White;
            this.btnread.CheckedImage = ((System.Drawing.Image)(resources.GetObject("btnread.CheckedImage")));
            this.btnread.CheckedLineColor = System.Drawing.Color.DimGray;
            this.btnread.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnread.FocusedColor = System.Drawing.Color.Empty;
            this.btnread.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnread.ForeColor = System.Drawing.Color.White;
            this.btnread.Image = ((System.Drawing.Image)(resources.GetObject("btnread.Image")));
            this.btnread.ImageSize = new System.Drawing.Size(20, 20);
            this.btnread.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.btnread.Location = new System.Drawing.Point(170, 265);
            this.btnread.Name = "btnread";
            this.btnread.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.btnread.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnread.OnHoverForeColor = System.Drawing.Color.White;
            this.btnread.OnHoverImage = null;
            this.btnread.OnHoverLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.btnread.OnPressedColor = System.Drawing.Color.Black;
            this.btnread.Radius = 8;
            this.btnread.Size = new System.Drawing.Size(117, 35);
            this.btnread.TabIndex = 23;
            this.btnread.Text = "Liste";
            this.btnread.Click += new System.EventHandler(this.btnread_Click);
            // 
            // DGV
            // 
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            this.DGV.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            this.DGV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DGV.BackgroundColor = System.Drawing.Color.White;
            this.DGV.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DGV.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.DGV.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DGV.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.DGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGV.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.Membere,
            this.Livre,
            this.Date_res,
            this.Status});
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DGV.DefaultCellStyle = dataGridViewCellStyle6;
            this.DGV.EnableHeadersVisualStyles = false;
            this.DGV.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.DGV.Location = new System.Drawing.Point(322, 109);
            this.DGV.Name = "DGV";
            this.DGV.RowHeadersVisible = false;
            this.DGV.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DGV.Size = new System.Drawing.Size(629, 131);
            this.DGV.TabIndex = 28;
            this.DGV.Theme = Guna.UI.WinForms.GunaDataGridViewPresetThemes.Guna;
            this.DGV.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.DGV.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.DGV.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.DGV.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.DGV.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.DGV.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.DGV.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.DGV.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.DGV.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.DGV.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.DGV.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.DGV.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGV.ThemeStyle.HeaderStyle.Height = 21;
            this.DGV.ThemeStyle.ReadOnly = false;
            this.DGV.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.DGV.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.DGV.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.DGV.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.DGV.ThemeStyle.RowsStyle.Height = 22;
            this.DGV.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.DGV.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.DGV.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGV_CellClick);
            // 
            // ID
            // 
            this.ID.HeaderText = "ID";
            this.ID.Name = "ID";
            // 
            // Membere
            // 
            this.Membere.HeaderText = "Member";
            this.Membere.Name = "Membere";
            // 
            // Livre
            // 
            this.Livre.HeaderText = "Livre";
            this.Livre.Name = "Livre";
            // 
            // Date_res
            // 
            this.Date_res.HeaderText = "Date ";
            this.Date_res.Name = "Date_res";
            // 
            // Status
            // 
            this.Status.HeaderText = "Status";
            this.Status.Name = "Status";
            // 
            // Reservation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.DGV);
            this.Controls.Add(this.btnclear);
            this.Controls.Add(this.btndelete);
            this.Controls.Add(this.btnupdate);
            this.Controls.Add(this.btnadd);
            this.Controls.Add(this.btnread);
            this.Controls.Add(this.gunaLabel6);
            this.Controls.Add(this.gunaLabel5);
            this.Controls.Add(this.gunaLabel4);
            this.Controls.Add(this.gunaLabel3);
            this.Controls.Add(this.gunaLabel2);
            this.Controls.Add(this.StatusBox);
            this.Controls.Add(this.DateR);
            this.Controls.Add(this.LivreBox);
            this.Controls.Add(this.MemberBox);
            this.Controls.Add(this.gunaLabel1);
            this.Name = "Reservation";
            this.Size = new System.Drawing.Size(1004, 492);
            this.Load += new System.EventHandler(this.Reservation_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DGV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI.WinForms.GunaLabel gunaLabel1;
        private Guna.UI.WinForms.GunaComboBox MemberBox;
        private Guna.UI.WinForms.GunaComboBox LivreBox;
        private Guna.UI.WinForms.GunaDateTimePicker DateR;
        private Guna.UI.WinForms.GunaComboBox StatusBox;
        private Guna.UI.WinForms.GunaLabel gunaLabel2;
        private Guna.UI.WinForms.GunaLabel gunaLabel3;
        private Guna.UI.WinForms.GunaLabel gunaLabel4;
        private Guna.UI.WinForms.GunaLabel gunaLabel5;
        private Guna.UI.WinForms.GunaLabel gunaLabel6;
        private Guna.UI.WinForms.GunaAdvenceButton btnclear;
        private Guna.UI.WinForms.GunaAdvenceButton btndelete;
        private Guna.UI.WinForms.GunaAdvenceButton btnupdate;
        private Guna.UI.WinForms.GunaAdvenceButton btnadd;
        private Guna.UI.WinForms.GunaAdvenceButton btnread;
        private Guna.UI.WinForms.GunaDataGridView DGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Membere;
        private System.Windows.Forms.DataGridViewTextBoxColumn Livre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Date_res;
        private System.Windows.Forms.DataGridViewTextBoxColumn Status;
    }
}
