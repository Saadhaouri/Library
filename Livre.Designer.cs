namespace HY
{
    partial class Livre
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Livre));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle14 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle15 = new System.Windows.Forms.DataGridViewCellStyle();
            this.gunaLabel1 = new Guna.UI.WinForms.GunaLabel();
            this.idtxt = new Guna.UI.WinForms.GunaTextBox();
            this.titletxt = new Guna.UI.WinForms.GunaTextBox();
            this.autheurtxt = new Guna.UI.WinForms.GunaTextBox();
            this.gunaLabel2 = new Guna.UI.WinForms.GunaLabel();
            this.gunaLabel3 = new Guna.UI.WinForms.GunaLabel();
            this.gunaLabel4 = new Guna.UI.WinForms.GunaLabel();
            this.gunaLabel5 = new Guna.UI.WinForms.GunaLabel();
            this.gunaLabel6 = new Guna.UI.WinForms.GunaLabel();
            this.gunaLabel7 = new Guna.UI.WinForms.GunaLabel();
            this.btnclear = new Guna.UI.WinForms.GunaAdvenceButton();
            this.btndelete = new Guna.UI.WinForms.GunaAdvenceButton();
            this.btnupdate = new Guna.UI.WinForms.GunaAdvenceButton();
            this.btnadd = new Guna.UI.WinForms.GunaAdvenceButton();
            this.btnread = new Guna.UI.WinForms.GunaAdvenceButton();
            this.DGV = new Guna.UI.WinForms.GunaDataGridView();
            this.gunaLabel8 = new Guna.UI.WinForms.GunaLabel();
            this.Quantitetxt = new Guna.UI.WinForms.GunaTextBox();
            this.dateP = new Guna.UI.WinForms.GunaDateTimePicker();
            this.memberships = new Guna.UI.WinForms.GunaComboBox();
            this.Disponibletxt = new Guna.UI.WinForms.GunaComboBox();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Titre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Autheur = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Publication = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Genre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.disponibilité = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Qnt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.DGV)).BeginInit();
            this.SuspendLayout();
            // 
            // gunaLabel1
            // 
            this.gunaLabel1.AutoSize = true;
            this.gunaLabel1.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel1.Location = new System.Drawing.Point(450, 11);
            this.gunaLabel1.Name = "gunaLabel1";
            this.gunaLabel1.Size = new System.Drawing.Size(53, 25);
            this.gunaLabel1.TabIndex = 0;
            this.gunaLabel1.Text = "Livre";
            // 
            // idtxt
            // 
            this.idtxt.BaseColor = System.Drawing.Color.White;
            this.idtxt.BorderColor = System.Drawing.Color.Silver;
            this.idtxt.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.idtxt.FocusedBaseColor = System.Drawing.Color.White;
            this.idtxt.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.idtxt.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.idtxt.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.idtxt.Location = new System.Drawing.Point(136, 82);
            this.idtxt.Name = "idtxt";
            this.idtxt.PasswordChar = '\0';
            this.idtxt.SelectedText = "";
            this.idtxt.Size = new System.Drawing.Size(160, 30);
            this.idtxt.TabIndex = 1;
            // 
            // titletxt
            // 
            this.titletxt.BaseColor = System.Drawing.Color.White;
            this.titletxt.BorderColor = System.Drawing.Color.Silver;
            this.titletxt.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.titletxt.FocusedBaseColor = System.Drawing.Color.White;
            this.titletxt.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.titletxt.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.titletxt.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.titletxt.Location = new System.Drawing.Point(136, 118);
            this.titletxt.Name = "titletxt";
            this.titletxt.PasswordChar = '\0';
            this.titletxt.SelectedText = "";
            this.titletxt.Size = new System.Drawing.Size(160, 30);
            this.titletxt.TabIndex = 2;
            // 
            // autheurtxt
            // 
            this.autheurtxt.BaseColor = System.Drawing.Color.White;
            this.autheurtxt.BorderColor = System.Drawing.Color.Silver;
            this.autheurtxt.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.autheurtxt.FocusedBaseColor = System.Drawing.Color.White;
            this.autheurtxt.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.autheurtxt.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.autheurtxt.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.autheurtxt.Location = new System.Drawing.Point(136, 154);
            this.autheurtxt.Name = "autheurtxt";
            this.autheurtxt.PasswordChar = '\0';
            this.autheurtxt.SelectedText = "";
            this.autheurtxt.Size = new System.Drawing.Size(160, 30);
            this.autheurtxt.TabIndex = 3;
            // 
            // gunaLabel2
            // 
            this.gunaLabel2.AutoSize = true;
            this.gunaLabel2.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel2.Location = new System.Drawing.Point(35, 87);
            this.gunaLabel2.Name = "gunaLabel2";
            this.gunaLabel2.Size = new System.Drawing.Size(31, 22);
            this.gunaLabel2.TabIndex = 8;
            this.gunaLabel2.Text = "ID";
            // 
            // gunaLabel3
            // 
            this.gunaLabel3.AutoSize = true;
            this.gunaLabel3.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel3.Location = new System.Drawing.Point(27, 126);
            this.gunaLabel3.Name = "gunaLabel3";
            this.gunaLabel3.Size = new System.Drawing.Size(51, 22);
            this.gunaLabel3.TabIndex = 9;
            this.gunaLabel3.Text = "Titre";
            // 
            // gunaLabel4
            // 
            this.gunaLabel4.AutoSize = true;
            this.gunaLabel4.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel4.Location = new System.Drawing.Point(27, 162);
            this.gunaLabel4.Name = "gunaLabel4";
            this.gunaLabel4.Size = new System.Drawing.Size(76, 22);
            this.gunaLabel4.TabIndex = 10;
            this.gunaLabel4.Text = "Autheur";
            // 
            // gunaLabel5
            // 
            this.gunaLabel5.AutoSize = true;
            this.gunaLabel5.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel5.Location = new System.Drawing.Point(27, 198);
            this.gunaLabel5.Name = "gunaLabel5";
            this.gunaLabel5.Size = new System.Drawing.Size(107, 22);
            this.gunaLabel5.TabIndex = 11;
            this.gunaLabel5.Text = "Publication ";
            // 
            // gunaLabel6
            // 
            this.gunaLabel6.AutoSize = true;
            this.gunaLabel6.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel6.Location = new System.Drawing.Point(27, 234);
            this.gunaLabel6.Name = "gunaLabel6";
            this.gunaLabel6.Size = new System.Drawing.Size(61, 22);
            this.gunaLabel6.TabIndex = 12;
            this.gunaLabel6.Text = "Genre";
            // 
            // gunaLabel7
            // 
            this.gunaLabel7.AutoSize = true;
            this.gunaLabel7.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel7.Location = new System.Drawing.Point(27, 267);
            this.gunaLabel7.Name = "gunaLabel7";
            this.gunaLabel7.Size = new System.Drawing.Size(86, 22);
            this.gunaLabel7.TabIndex = 13;
            this.gunaLabel7.Text = "Avaibilty ";
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
            this.btnclear.Location = new System.Drawing.Point(704, 359);
            this.btnclear.Name = "btnclear";
            this.btnclear.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.btnclear.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnclear.OnHoverForeColor = System.Drawing.Color.White;
            this.btnclear.OnHoverImage = null;
            this.btnclear.OnHoverLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.btnclear.OnPressedColor = System.Drawing.Color.Black;
            this.btnclear.Radius = 8;
            this.btnclear.Size = new System.Drawing.Size(40, 42);
            this.btnclear.TabIndex = 22;
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
            this.btndelete.Location = new System.Drawing.Point(577, 359);
            this.btndelete.Name = "btndelete";
            this.btndelete.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.btndelete.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btndelete.OnHoverForeColor = System.Drawing.Color.White;
            this.btndelete.OnHoverImage = null;
            this.btndelete.OnHoverLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.btndelete.OnPressedColor = System.Drawing.Color.Black;
            this.btndelete.Radius = 8;
            this.btndelete.Size = new System.Drawing.Size(119, 42);
            this.btndelete.TabIndex = 21;
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
            this.btnupdate.Location = new System.Drawing.Point(439, 359);
            this.btnupdate.Name = "btnupdate";
            this.btnupdate.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.btnupdate.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnupdate.OnHoverForeColor = System.Drawing.Color.White;
            this.btnupdate.OnHoverImage = null;
            this.btnupdate.OnHoverLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.btnupdate.OnPressedColor = System.Drawing.Color.Black;
            this.btnupdate.Radius = 8;
            this.btnupdate.Size = new System.Drawing.Size(119, 42);
            this.btnupdate.TabIndex = 20;
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
            this.btnadd.Location = new System.Drawing.Point(301, 359);
            this.btnadd.Name = "btnadd";
            this.btnadd.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.btnadd.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnadd.OnHoverForeColor = System.Drawing.Color.White;
            this.btnadd.OnHoverImage = null;
            this.btnadd.OnHoverLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.btnadd.OnPressedColor = System.Drawing.Color.Black;
            this.btnadd.Radius = 8;
            this.btnadd.Size = new System.Drawing.Size(119, 42);
            this.btnadd.TabIndex = 19;
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
            this.btnread.Location = new System.Drawing.Point(158, 359);
            this.btnread.Name = "btnread";
            this.btnread.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.btnread.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnread.OnHoverForeColor = System.Drawing.Color.White;
            this.btnread.OnHoverImage = null;
            this.btnread.OnHoverLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.btnread.OnPressedColor = System.Drawing.Color.Black;
            this.btnread.Radius = 8;
            this.btnread.Size = new System.Drawing.Size(117, 42);
            this.btnread.TabIndex = 18;
            this.btnread.Text = "Liste";
            this.btnread.Click += new System.EventHandler(this.btnread_Click);
            // 
            // DGV
            // 
            dataGridViewCellStyle13.BackColor = System.Drawing.Color.White;
            this.DGV.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle13;
            this.DGV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DGV.BackgroundColor = System.Drawing.Color.White;
            this.DGV.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DGV.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.DGV.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle14.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle14.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle14.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle14.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle14.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle14.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DGV.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle14;
            this.DGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGV.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.Titre,
            this.Autheur,
            this.Publication,
            this.Genre,
            this.disponibilité,
            this.Qnt});
            dataGridViewCellStyle15.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle15.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle15.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle15.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle15.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle15.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle15.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DGV.DefaultCellStyle = dataGridViewCellStyle15;
            this.DGV.EnableHeadersVisualStyles = false;
            this.DGV.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.DGV.Location = new System.Drawing.Point(316, 82);
            this.DGV.Name = "DGV";
            this.DGV.RowHeadersVisible = false;
            this.DGV.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DGV.Size = new System.Drawing.Size(678, 210);
            this.DGV.TabIndex = 23;
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
            // gunaLabel8
            // 
            this.gunaLabel8.AutoSize = true;
            this.gunaLabel8.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel8.Location = new System.Drawing.Point(27, 303);
            this.gunaLabel8.Name = "gunaLabel8";
            this.gunaLabel8.Size = new System.Drawing.Size(81, 22);
            this.gunaLabel8.TabIndex = 25;
            this.gunaLabel8.Text = "Quantite";
            // 
            // Quantitetxt
            // 
            this.Quantitetxt.BaseColor = System.Drawing.Color.White;
            this.Quantitetxt.BorderColor = System.Drawing.Color.Silver;
            this.Quantitetxt.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.Quantitetxt.FocusedBaseColor = System.Drawing.Color.White;
            this.Quantitetxt.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.Quantitetxt.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.Quantitetxt.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.Quantitetxt.Location = new System.Drawing.Point(136, 298);
            this.Quantitetxt.Name = "Quantitetxt";
            this.Quantitetxt.PasswordChar = '\0';
            this.Quantitetxt.SelectedText = "";
            this.Quantitetxt.Size = new System.Drawing.Size(160, 30);
            this.Quantitetxt.TabIndex = 24;
            // 
            // dateP
            // 
            this.dateP.BaseColor = System.Drawing.Color.White;
            this.dateP.BorderColor = System.Drawing.Color.Silver;
            this.dateP.CustomFormat = null;
            this.dateP.DropDownAlign = System.Windows.Forms.LeftRightAlignment.Right;
            this.dateP.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dateP.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.dateP.ForeColor = System.Drawing.Color.Black;
            this.dateP.Location = new System.Drawing.Point(136, 190);
            this.dateP.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dateP.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dateP.Name = "dateP";
            this.dateP.OnHoverBaseColor = System.Drawing.Color.White;
            this.dateP.OnHoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dateP.OnHoverForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dateP.OnPressedColor = System.Drawing.Color.Black;
            this.dateP.Size = new System.Drawing.Size(160, 30);
            this.dateP.TabIndex = 26;
            this.dateP.Text = "Thursday, June 1, 2023";
            this.dateP.Value = new System.DateTime(2023, 6, 1, 19, 18, 44, 567);
            // 
            // memberships
            // 
            this.memberships.BackColor = System.Drawing.Color.Transparent;
            this.memberships.BaseColor = System.Drawing.Color.White;
            this.memberships.BorderColor = System.Drawing.Color.Silver;
            this.memberships.DisplayMember = "category_name";
            this.memberships.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.memberships.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.memberships.FocusedColor = System.Drawing.Color.Empty;
            this.memberships.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.memberships.ForeColor = System.Drawing.Color.Black;
            this.memberships.FormattingEnabled = true;
            this.memberships.Location = new System.Drawing.Point(136, 226);
            this.memberships.Name = "memberships";
            this.memberships.OnHoverItemBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.memberships.OnHoverItemForeColor = System.Drawing.Color.White;
            this.memberships.Size = new System.Drawing.Size(160, 26);
            this.memberships.TabIndex = 27;
            this.memberships.ValueMember = "category_name";
            // 
            // Disponibletxt
            // 
            this.Disponibletxt.BackColor = System.Drawing.Color.Transparent;
            this.Disponibletxt.BaseColor = System.Drawing.Color.White;
            this.Disponibletxt.BorderColor = System.Drawing.Color.Silver;
            this.Disponibletxt.DisplayMember = "category_name";
            this.Disponibletxt.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.Disponibletxt.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Disponibletxt.FocusedColor = System.Drawing.Color.Empty;
            this.Disponibletxt.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.Disponibletxt.ForeColor = System.Drawing.Color.Black;
            this.Disponibletxt.FormattingEnabled = true;
            this.Disponibletxt.Items.AddRange(new object[] {
            "True",
            "False"});
            this.Disponibletxt.Location = new System.Drawing.Point(136, 266);
            this.Disponibletxt.Name = "Disponibletxt";
            this.Disponibletxt.OnHoverItemBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.Disponibletxt.OnHoverItemForeColor = System.Drawing.Color.White;
            this.Disponibletxt.Size = new System.Drawing.Size(160, 26);
            this.Disponibletxt.TabIndex = 28;
            this.Disponibletxt.ValueMember = "category_name";
            // 
            // id
            // 
            this.id.HeaderText = "ID";
            this.id.Name = "id";
            // 
            // Titre
            // 
            this.Titre.HeaderText = "Titre";
            this.Titre.Name = "Titre";
            // 
            // Autheur
            // 
            this.Autheur.HeaderText = "Autheur";
            this.Autheur.Name = "Autheur";
            // 
            // Publication
            // 
            this.Publication.HeaderText = "D.publication";
            this.Publication.Name = "Publication";
            // 
            // Genre
            // 
            this.Genre.HeaderText = "Genre";
            this.Genre.Name = "Genre";
            // 
            // disponibilité
            // 
            this.disponibilité.HeaderText = "disponibilité";
            this.disponibilité.Name = "disponibilité";
            // 
            // Qnt
            // 
            this.Qnt.HeaderText = "Quantite";
            this.Qnt.Name = "Qnt";
            // 
            // Livre
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MintCream;
            this.Controls.Add(this.Disponibletxt);
            this.Controls.Add(this.memberships);
            this.Controls.Add(this.dateP);
            this.Controls.Add(this.gunaLabel8);
            this.Controls.Add(this.Quantitetxt);
            this.Controls.Add(this.DGV);
            this.Controls.Add(this.btnclear);
            this.Controls.Add(this.btndelete);
            this.Controls.Add(this.btnupdate);
            this.Controls.Add(this.btnadd);
            this.Controls.Add(this.btnread);
            this.Controls.Add(this.gunaLabel7);
            this.Controls.Add(this.gunaLabel6);
            this.Controls.Add(this.gunaLabel5);
            this.Controls.Add(this.gunaLabel4);
            this.Controls.Add(this.gunaLabel3);
            this.Controls.Add(this.gunaLabel2);
            this.Controls.Add(this.autheurtxt);
            this.Controls.Add(this.titletxt);
            this.Controls.Add(this.idtxt);
            this.Controls.Add(this.gunaLabel1);
            this.Name = "Livre";
            this.Size = new System.Drawing.Size(1004, 492);
            this.Load += new System.EventHandler(this.Livre_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DGV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI.WinForms.GunaLabel gunaLabel1;
        private Guna.UI.WinForms.GunaTextBox idtxt;
        private Guna.UI.WinForms.GunaTextBox titletxt;
        private Guna.UI.WinForms.GunaTextBox autheurtxt;
        private Guna.UI.WinForms.GunaLabel gunaLabel2;
        private Guna.UI.WinForms.GunaLabel gunaLabel3;
        private Guna.UI.WinForms.GunaLabel gunaLabel4;
        private Guna.UI.WinForms.GunaLabel gunaLabel5;
        private Guna.UI.WinForms.GunaLabel gunaLabel6;
        private Guna.UI.WinForms.GunaLabel gunaLabel7;
        private Guna.UI.WinForms.GunaAdvenceButton btnclear;
        private Guna.UI.WinForms.GunaAdvenceButton btndelete;
        private Guna.UI.WinForms.GunaAdvenceButton btnupdate;
        private Guna.UI.WinForms.GunaAdvenceButton btnadd;
        private Guna.UI.WinForms.GunaAdvenceButton btnread;
        private Guna.UI.WinForms.GunaDataGridView DGV;
        private Guna.UI.WinForms.GunaLabel gunaLabel8;
        private Guna.UI.WinForms.GunaTextBox Quantitetxt;
        private Guna.UI.WinForms.GunaDateTimePicker dateP;
        private Guna.UI.WinForms.GunaComboBox memberships;
        private Guna.UI.WinForms.GunaComboBox Disponibletxt;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Titre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Autheur;
        private System.Windows.Forms.DataGridViewTextBoxColumn Publication;
        private System.Windows.Forms.DataGridViewTextBoxColumn Genre;
        private System.Windows.Forms.DataGridViewTextBoxColumn disponibilité;
        private System.Windows.Forms.DataGridViewTextBoxColumn Qnt;
    }
}
