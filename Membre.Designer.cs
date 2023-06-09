namespace HY
{
    partial class Membre
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Membre));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.gunaLabel1 = new Guna.UI.WinForms.GunaLabel();
            this.IDtxt = new Guna.UI.WinForms.GunaTextBox();
            this.Member = new Guna.UI.WinForms.GunaTextBox();
            this.Phone = new Guna.UI.WinForms.GunaTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.memberships = new Guna.UI.WinForms.GunaComboBox();
            this.btnread = new Guna.UI.WinForms.GunaAdvenceButton();
            this.btnadd = new Guna.UI.WinForms.GunaAdvenceButton();
            this.btnupdate = new Guna.UI.WinForms.GunaAdvenceButton();
            this.btndelete = new Guna.UI.WinForms.GunaAdvenceButton();
            this.DGV = new Guna.UI.WinForms.GunaDataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Membr = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Telephone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.engager = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.libraryDataSet = new HY.LibraryDataSet();
            this.categoryBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.categoryTableAdapter = new HY.LibraryDataSetTableAdapters.CategoryTableAdapter();
            this.categoryBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.btnclear = new Guna.UI.WinForms.GunaAdvenceButton();
            ((System.ComponentModel.ISupportInitialize)(this.DGV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.libraryDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.categoryBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.categoryBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // gunaLabel1
            // 
            this.gunaLabel1.AutoSize = true;
            this.gunaLabel1.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel1.Location = new System.Drawing.Point(444, 0);
            this.gunaLabel1.Name = "gunaLabel1";
            this.gunaLabel1.Size = new System.Drawing.Size(85, 25);
            this.gunaLabel1.TabIndex = 2;
            this.gunaLabel1.Text = "Membre";
            // 
            // IDtxt
            // 
            this.IDtxt.BackColor = System.Drawing.Color.Transparent;
            this.IDtxt.BaseColor = System.Drawing.Color.White;
            this.IDtxt.BorderColor = System.Drawing.Color.Silver;
            this.IDtxt.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.IDtxt.FocusedBaseColor = System.Drawing.Color.White;
            this.IDtxt.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.IDtxt.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.IDtxt.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.IDtxt.Location = new System.Drawing.Point(113, 104);
            this.IDtxt.Name = "IDtxt";
            this.IDtxt.PasswordChar = '\0';
            this.IDtxt.Radius = 4;
            this.IDtxt.SelectedText = "";
            this.IDtxt.Size = new System.Drawing.Size(160, 30);
            this.IDtxt.TabIndex = 3;
            // 
            // Member
            // 
            this.Member.BackColor = System.Drawing.Color.Transparent;
            this.Member.BaseColor = System.Drawing.Color.White;
            this.Member.BorderColor = System.Drawing.Color.Silver;
            this.Member.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.Member.FocusedBaseColor = System.Drawing.Color.White;
            this.Member.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.Member.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.Member.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.Member.Location = new System.Drawing.Point(311, 104);
            this.Member.Name = "Member";
            this.Member.PasswordChar = '\0';
            this.Member.Radius = 4;
            this.Member.SelectedText = "";
            this.Member.Size = new System.Drawing.Size(160, 30);
            this.Member.TabIndex = 4;
            // 
            // Phone
            // 
            this.Phone.BackColor = System.Drawing.Color.Transparent;
            this.Phone.BaseColor = System.Drawing.Color.White;
            this.Phone.BorderColor = System.Drawing.Color.Silver;
            this.Phone.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.Phone.FocusedBaseColor = System.Drawing.Color.White;
            this.Phone.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.Phone.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.Phone.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.Phone.Location = new System.Drawing.Point(514, 104);
            this.Phone.Name = "Phone";
            this.Phone.PasswordChar = '\0';
            this.Phone.Radius = 4;
            this.Phone.SelectedText = "";
            this.Phone.Size = new System.Drawing.Size(160, 30);
            this.Phone.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(109, 82);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(27, 19);
            this.label1.TabIndex = 7;
            this.label1.Text = "ID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(307, 82);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 19);
            this.label2.TabIndex = 8;
            this.label2.Text = "Member";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(519, 82);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 19);
            this.label3.TabIndex = 9;
            this.label3.Text = "Telephone";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(720, 82);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 19);
            this.label4.TabIndex = 10;
            this.label4.Text = "engager";
            // 
            // memberships
            // 
            this.memberships.BackColor = System.Drawing.Color.Transparent;
            this.memberships.BaseColor = System.Drawing.Color.White;
            this.memberships.BorderColor = System.Drawing.Color.Silver;
            this.memberships.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.categoryBindingSource1, "category_name", true));
            this.memberships.DataSource = this.categoryBindingSource;
            this.memberships.DisplayMember = "category_name";
            this.memberships.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.memberships.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.memberships.FocusedColor = System.Drawing.Color.Empty;
            this.memberships.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.memberships.ForeColor = System.Drawing.Color.Black;
            this.memberships.FormattingEnabled = true;
            this.memberships.Location = new System.Drawing.Point(714, 104);
            this.memberships.Name = "memberships";
            this.memberships.OnHoverItemBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.memberships.OnHoverItemForeColor = System.Drawing.Color.White;
            this.memberships.Size = new System.Drawing.Size(131, 26);
            this.memberships.TabIndex = 11;
            this.memberships.ValueMember = "category_name";
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
            this.btnread.Location = new System.Drawing.Point(197, 191);
            this.btnread.Name = "btnread";
            this.btnread.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.btnread.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnread.OnHoverForeColor = System.Drawing.Color.White;
            this.btnread.OnHoverImage = null;
            this.btnread.OnHoverLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.btnread.OnPressedColor = System.Drawing.Color.Black;
            this.btnread.Radius = 8;
            this.btnread.Size = new System.Drawing.Size(117, 42);
            this.btnread.TabIndex = 12;
            this.btnread.Text = "Liste";
            this.btnread.Click += new System.EventHandler(this.btnread_Click);
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
            this.btnadd.Location = new System.Drawing.Point(340, 191);
            this.btnadd.Name = "btnadd";
            this.btnadd.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.btnadd.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnadd.OnHoverForeColor = System.Drawing.Color.White;
            this.btnadd.OnHoverImage = null;
            this.btnadd.OnHoverLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.btnadd.OnPressedColor = System.Drawing.Color.Black;
            this.btnadd.Radius = 8;
            this.btnadd.Size = new System.Drawing.Size(119, 42);
            this.btnadd.TabIndex = 13;
            this.btnadd.Text = "Ajeuter";
            this.btnadd.Click += new System.EventHandler(this.btnadd_Click);
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
            this.btnupdate.Location = new System.Drawing.Point(478, 191);
            this.btnupdate.Name = "btnupdate";
            this.btnupdate.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.btnupdate.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnupdate.OnHoverForeColor = System.Drawing.Color.White;
            this.btnupdate.OnHoverImage = null;
            this.btnupdate.OnHoverLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.btnupdate.OnPressedColor = System.Drawing.Color.Black;
            this.btnupdate.Radius = 8;
            this.btnupdate.Size = new System.Drawing.Size(119, 42);
            this.btnupdate.TabIndex = 14;
            this.btnupdate.Text = "Modifier";
            this.btnupdate.Click += new System.EventHandler(this.btnupdate_Click);
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
            this.btndelete.Location = new System.Drawing.Point(616, 191);
            this.btndelete.Name = "btndelete";
            this.btndelete.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.btndelete.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btndelete.OnHoverForeColor = System.Drawing.Color.White;
            this.btndelete.OnHoverImage = null;
            this.btndelete.OnHoverLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.btndelete.OnPressedColor = System.Drawing.Color.Black;
            this.btndelete.Radius = 8;
            this.btndelete.Size = new System.Drawing.Size(119, 42);
            this.btndelete.TabIndex = 15;
            this.btndelete.Text = "Suprimmer";
            this.btndelete.Click += new System.EventHandler(this.btndelete_Click);
            // 
            // DGV
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.DGV.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.DGV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DGV.BackgroundColor = System.Drawing.Color.White;
            this.DGV.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DGV.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.DGV.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DGV.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.DGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGV.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.Membr,
            this.Telephone,
            this.engager});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DGV.DefaultCellStyle = dataGridViewCellStyle3;
            this.DGV.EnableHeadersVisualStyles = false;
            this.DGV.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.DGV.Location = new System.Drawing.Point(117, 275);
            this.DGV.Name = "DGV";
            this.DGV.RowHeadersVisible = false;
            this.DGV.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DGV.Size = new System.Drawing.Size(696, 150);
            this.DGV.TabIndex = 16;
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
            // Membr
            // 
            this.Membr.HeaderText = "Member";
            this.Membr.Name = "Membr";
            // 
            // Telephone
            // 
            this.Telephone.HeaderText = "Telephone";
            this.Telephone.Name = "Telephone";
            // 
            // engager
            // 
            this.engager.HeaderText = "engager";
            this.engager.Name = "engager";
            // 
            // libraryDataSet
            // 
            this.libraryDataSet.DataSetName = "LibraryDataSet";
            this.libraryDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // categoryBindingSource
            // 
            this.categoryBindingSource.DataMember = "Category";
            this.categoryBindingSource.DataSource = this.libraryDataSet;
            // 
            // categoryTableAdapter
            // 
            this.categoryTableAdapter.ClearBeforeFill = true;
            // 
            // categoryBindingSource1
            // 
            this.categoryBindingSource1.DataMember = "Category";
            this.categoryBindingSource1.DataSource = this.libraryDataSet;
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
            this.btnclear.Location = new System.Drawing.Point(743, 191);
            this.btnclear.Name = "btnclear";
            this.btnclear.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.btnclear.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnclear.OnHoverForeColor = System.Drawing.Color.White;
            this.btnclear.OnHoverImage = null;
            this.btnclear.OnHoverLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.btnclear.OnPressedColor = System.Drawing.Color.Black;
            this.btnclear.Radius = 8;
            this.btnclear.Size = new System.Drawing.Size(40, 42);
            this.btnclear.TabIndex = 17;
            this.btnclear.Click += new System.EventHandler(this.btnclear_Click);
            // 
            // Membre
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnclear);
            this.Controls.Add(this.DGV);
            this.Controls.Add(this.btndelete);
            this.Controls.Add(this.btnupdate);
            this.Controls.Add(this.btnadd);
            this.Controls.Add(this.btnread);
            this.Controls.Add(this.memberships);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Phone);
            this.Controls.Add(this.Member);
            this.Controls.Add(this.IDtxt);
            this.Controls.Add(this.gunaLabel1);
            this.Name = "Membre";
            this.Size = new System.Drawing.Size(1004, 492);
            this.Load += new System.EventHandler(this.Membre_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DGV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.libraryDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.categoryBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.categoryBindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI.WinForms.GunaLabel gunaLabel1;
        private Guna.UI.WinForms.GunaTextBox IDtxt;
        private Guna.UI.WinForms.GunaTextBox Member;
        private Guna.UI.WinForms.GunaTextBox Phone;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private Guna.UI.WinForms.GunaComboBox memberships;
        private Guna.UI.WinForms.GunaAdvenceButton btnread;
        private Guna.UI.WinForms.GunaAdvenceButton btnadd;
        private Guna.UI.WinForms.GunaAdvenceButton btnupdate;
        private Guna.UI.WinForms.GunaAdvenceButton btndelete;
        private Guna.UI.WinForms.GunaDataGridView DGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Membr;
        private System.Windows.Forms.DataGridViewTextBoxColumn Telephone;
        private System.Windows.Forms.DataGridViewTextBoxColumn engager;
        private System.Windows.Forms.BindingSource categoryBindingSource;
        private LibraryDataSet libraryDataSet;
        private LibraryDataSetTableAdapters.CategoryTableAdapter categoryTableAdapter;
        private System.Windows.Forms.BindingSource categoryBindingSource1;
        private Guna.UI.WinForms.GunaAdvenceButton btnclear;
    }
}
