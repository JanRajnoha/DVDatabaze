namespace DVDatabaze
{
    partial class databaze
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(databaze));
            this.add = new System.Windows.Forms.Button();
            this.edit = new System.Windows.Forms.Button();
            this.delete = new System.Windows.Forms.Button();
            this.refresh = new System.Windows.Forms.Button();
            this.DGV = new System.Windows.Forms.DataGridView();
            this.iDDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.filmDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.typDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.zeměDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rokDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.délkaDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.adresaCSFDDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hodnoceníCSFDDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vidělDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dVDDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Data = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.zobrazitKartuFilmuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.přidatZáznamToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editovatZáznamToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.vymazatZáznamToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.obnovitHodnoceníToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.vTabulceToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.find_cancel = new System.Windows.Forms.ToolStripMenuItem();
            this.filmyBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.filmsDataSet = new DVDatabaze.FilmsDataSet();
            this.search = new System.Windows.Forms.Button();
            this.status = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.stav = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel3 = new System.Windows.Forms.ToolStripStatusLabel();
            this.TSSL = new System.Windows.Forms.ToolStripStatusLabel();
            this.TSSPB = new System.Windows.Forms.ToolStripProgressBar();
            this.find_box = new System.Windows.Forms.TextBox();
            this.close_btn = new System.Windows.Forms.Button();
            this.find_btn = new System.Windows.Forms.Button();
            this.showing = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Film = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Type = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.State = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Year = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Length = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Page = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Rate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Seen = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DVD = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.filmyTableAdapter = new DVDatabaze.FilmsDataSetTableAdapters.filmyTableAdapter();
            this.search_dgv = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DGV)).BeginInit();
            this.Data.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.filmyBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.filmsDataSet)).BeginInit();
            this.status.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.showing)).BeginInit();
            this.SuspendLayout();
            // 
            // add
            // 
            this.add.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.add.Location = new System.Drawing.Point(12, 12);
            this.add.Name = "add";
            this.add.Size = new System.Drawing.Size(125, 31);
            this.add.TabIndex = 1;
            this.add.Text = "Přidej záznam";
            this.add.UseVisualStyleBackColor = true;
            this.add.Click += new System.EventHandler(this.add_Click);
            this.add.KeyDown += new System.Windows.Forms.KeyEventHandler(this.hotkeys);
            // 
            // edit
            // 
            this.edit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.edit.Location = new System.Drawing.Point(143, 12);
            this.edit.Name = "edit";
            this.edit.Size = new System.Drawing.Size(125, 31);
            this.edit.TabIndex = 2;
            this.edit.Text = "Upravit záznam";
            this.edit.UseVisualStyleBackColor = true;
            this.edit.Click += new System.EventHandler(this.edit_Click);
            this.edit.KeyDown += new System.Windows.Forms.KeyEventHandler(this.hotkeys);
            // 
            // delete
            // 
            this.delete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.delete.Location = new System.Drawing.Point(274, 12);
            this.delete.Name = "delete";
            this.delete.Size = new System.Drawing.Size(125, 31);
            this.delete.TabIndex = 3;
            this.delete.Text = "Vymazat záznam";
            this.delete.UseVisualStyleBackColor = true;
            this.delete.Click += new System.EventHandler(this.delete_Click);
            this.delete.KeyDown += new System.Windows.Forms.KeyEventHandler(this.hotkeys);
            // 
            // refresh
            // 
            this.refresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.refresh.Location = new System.Drawing.Point(405, 12);
            this.refresh.Name = "refresh";
            this.refresh.Size = new System.Drawing.Size(125, 31);
            this.refresh.TabIndex = 4;
            this.refresh.Text = "Obnovit hodnocení";
            this.refresh.UseVisualStyleBackColor = true;
            this.refresh.Click += new System.EventHandler(this.refresh_Click);
            this.refresh.KeyDown += new System.Windows.Forms.KeyEventHandler(this.hotkeys);
            // 
            // DGV
            // 
            this.DGV.AllowUserToAddRows = false;
            this.DGV.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DGV.AutoGenerateColumns = false;
            this.DGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGV.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDDataGridViewTextBoxColumn1,
            this.filmDataGridViewTextBoxColumn1,
            this.typDataGridViewTextBoxColumn1,
            this.zeměDataGridViewTextBoxColumn1,
            this.rokDataGridViewTextBoxColumn1,
            this.délkaDataGridViewTextBoxColumn1,
            this.adresaCSFDDataGridViewTextBoxColumn1,
            this.hodnoceníCSFDDataGridViewTextBoxColumn1,
            this.vidělDataGridViewTextBoxColumn1,
            this.dVDDataGridViewTextBoxColumn1});
            this.DGV.ContextMenuStrip = this.Data;
            this.DGV.DataSource = this.filmyBindingSource;
            this.DGV.Location = new System.Drawing.Point(12, 51);
            this.DGV.Name = "DGV";
            this.DGV.ReadOnly = true;
            this.DGV.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.DGV.Size = new System.Drawing.Size(1125, 294);
            this.DGV.TabIndex = 0;
            this.DGV.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.URL);
            this.DGV.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Karta);
            this.DGV.KeyDown += new System.Windows.Forms.KeyEventHandler(this.hotkeys);
            // 
            // iDDataGridViewTextBoxColumn1
            // 
            this.iDDataGridViewTextBoxColumn1.DataPropertyName = "ID";
            this.iDDataGridViewTextBoxColumn1.HeaderText = "ID";
            this.iDDataGridViewTextBoxColumn1.Name = "iDDataGridViewTextBoxColumn1";
            this.iDDataGridViewTextBoxColumn1.ReadOnly = true;
            this.iDDataGridViewTextBoxColumn1.Visible = false;
            // 
            // filmDataGridViewTextBoxColumn1
            // 
            this.filmDataGridViewTextBoxColumn1.DataPropertyName = "Film";
            this.filmDataGridViewTextBoxColumn1.HeaderText = "Film";
            this.filmDataGridViewTextBoxColumn1.Name = "filmDataGridViewTextBoxColumn1";
            this.filmDataGridViewTextBoxColumn1.ReadOnly = true;
            this.filmDataGridViewTextBoxColumn1.Width = 250;
            // 
            // typDataGridViewTextBoxColumn1
            // 
            this.typDataGridViewTextBoxColumn1.DataPropertyName = "typ";
            this.typDataGridViewTextBoxColumn1.HeaderText = "Typ";
            this.typDataGridViewTextBoxColumn1.Name = "typDataGridViewTextBoxColumn1";
            this.typDataGridViewTextBoxColumn1.ReadOnly = true;
            this.typDataGridViewTextBoxColumn1.Width = 150;
            // 
            // zeměDataGridViewTextBoxColumn1
            // 
            this.zeměDataGridViewTextBoxColumn1.DataPropertyName = "Země";
            this.zeměDataGridViewTextBoxColumn1.HeaderText = "Země";
            this.zeměDataGridViewTextBoxColumn1.Name = "zeměDataGridViewTextBoxColumn1";
            this.zeměDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // rokDataGridViewTextBoxColumn1
            // 
            this.rokDataGridViewTextBoxColumn1.DataPropertyName = "Rok";
            this.rokDataGridViewTextBoxColumn1.HeaderText = "Rok";
            this.rokDataGridViewTextBoxColumn1.Name = "rokDataGridViewTextBoxColumn1";
            this.rokDataGridViewTextBoxColumn1.ReadOnly = true;
            this.rokDataGridViewTextBoxColumn1.Width = 75;
            // 
            // délkaDataGridViewTextBoxColumn1
            // 
            this.délkaDataGridViewTextBoxColumn1.DataPropertyName = "Délka";
            this.délkaDataGridViewTextBoxColumn1.HeaderText = "Délka";
            this.délkaDataGridViewTextBoxColumn1.Name = "délkaDataGridViewTextBoxColumn1";
            this.délkaDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // adresaCSFDDataGridViewTextBoxColumn1
            // 
            this.adresaCSFDDataGridViewTextBoxColumn1.DataPropertyName = "Adresa - CSFD";
            this.adresaCSFDDataGridViewTextBoxColumn1.HeaderText = "Adresa - CSFD";
            this.adresaCSFDDataGridViewTextBoxColumn1.Name = "adresaCSFDDataGridViewTextBoxColumn1";
            this.adresaCSFDDataGridViewTextBoxColumn1.ReadOnly = true;
            this.adresaCSFDDataGridViewTextBoxColumn1.Width = 150;
            // 
            // hodnoceníCSFDDataGridViewTextBoxColumn1
            // 
            this.hodnoceníCSFDDataGridViewTextBoxColumn1.DataPropertyName = "Hodnocení - CSFD";
            this.hodnoceníCSFDDataGridViewTextBoxColumn1.HeaderText = "Hodnocení - CSFD";
            this.hodnoceníCSFDDataGridViewTextBoxColumn1.Name = "hodnoceníCSFDDataGridViewTextBoxColumn1";
            this.hodnoceníCSFDDataGridViewTextBoxColumn1.ReadOnly = true;
            this.hodnoceníCSFDDataGridViewTextBoxColumn1.Width = 75;
            // 
            // vidělDataGridViewTextBoxColumn1
            // 
            this.vidělDataGridViewTextBoxColumn1.DataPropertyName = "Viděl?";
            this.vidělDataGridViewTextBoxColumn1.HeaderText = "Viděl?";
            this.vidělDataGridViewTextBoxColumn1.Name = "vidělDataGridViewTextBoxColumn1";
            this.vidělDataGridViewTextBoxColumn1.ReadOnly = true;
            this.vidělDataGridViewTextBoxColumn1.Width = 75;
            // 
            // dVDDataGridViewTextBoxColumn1
            // 
            this.dVDDataGridViewTextBoxColumn1.DataPropertyName = "DVD";
            this.dVDDataGridViewTextBoxColumn1.HeaderText = "DVD";
            this.dVDDataGridViewTextBoxColumn1.Name = "dVDDataGridViewTextBoxColumn1";
            this.dVDDataGridViewTextBoxColumn1.ReadOnly = true;
            this.dVDDataGridViewTextBoxColumn1.Width = 75;
            // 
            // Data
            // 
            this.Data.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.zobrazitKartuFilmuToolStripMenuItem,
            this.toolStripSeparator2,
            this.přidatZáznamToolStripMenuItem,
            this.editovatZáznamToolStripMenuItem,
            this.vymazatZáznamToolStripMenuItem,
            this.toolStripSeparator4,
            this.obnovitHodnoceníToolStripMenuItem,
            this.toolStripSeparator1,
            this.vTabulceToolStripMenuItem,
            this.find_cancel});
            this.Data.Name = "Data";
            this.Data.Size = new System.Drawing.Size(179, 176);
            // 
            // zobrazitKartuFilmuToolStripMenuItem
            // 
            this.zobrazitKartuFilmuToolStripMenuItem.Name = "zobrazitKartuFilmuToolStripMenuItem";
            this.zobrazitKartuFilmuToolStripMenuItem.Size = new System.Drawing.Size(178, 22);
            this.zobrazitKartuFilmuToolStripMenuItem.Text = "Zobrazit kartu filmu";
            this.zobrazitKartuFilmuToolStripMenuItem.Click += new System.EventHandler(this.profil_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(175, 6);
            // 
            // přidatZáznamToolStripMenuItem
            // 
            this.přidatZáznamToolStripMenuItem.Name = "přidatZáznamToolStripMenuItem";
            this.přidatZáznamToolStripMenuItem.Size = new System.Drawing.Size(178, 22);
            this.přidatZáznamToolStripMenuItem.Text = "Přidat záznam";
            this.přidatZáznamToolStripMenuItem.Click += new System.EventHandler(this.add_Click);
            // 
            // editovatZáznamToolStripMenuItem
            // 
            this.editovatZáznamToolStripMenuItem.Name = "editovatZáznamToolStripMenuItem";
            this.editovatZáznamToolStripMenuItem.Size = new System.Drawing.Size(178, 22);
            this.editovatZáznamToolStripMenuItem.Text = "Editovat záznam";
            this.editovatZáznamToolStripMenuItem.Click += new System.EventHandler(this.edit_Click);
            // 
            // vymazatZáznamToolStripMenuItem
            // 
            this.vymazatZáznamToolStripMenuItem.Name = "vymazatZáznamToolStripMenuItem";
            this.vymazatZáznamToolStripMenuItem.Size = new System.Drawing.Size(178, 22);
            this.vymazatZáznamToolStripMenuItem.Text = "Vymazat záznam";
            this.vymazatZáznamToolStripMenuItem.Click += new System.EventHandler(this.delete_Click);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(175, 6);
            // 
            // obnovitHodnoceníToolStripMenuItem
            // 
            this.obnovitHodnoceníToolStripMenuItem.Name = "obnovitHodnoceníToolStripMenuItem";
            this.obnovitHodnoceníToolStripMenuItem.Size = new System.Drawing.Size(178, 22);
            this.obnovitHodnoceníToolStripMenuItem.Text = "Obnovit hodnocení";
            this.obnovitHodnoceníToolStripMenuItem.Click += new System.EventHandler(this.refresh_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(175, 6);
            // 
            // vTabulceToolStripMenuItem
            // 
            this.vTabulceToolStripMenuItem.Name = "vTabulceToolStripMenuItem";
            this.vTabulceToolStripMenuItem.Size = new System.Drawing.Size(178, 22);
            this.vTabulceToolStripMenuItem.Text = "Vyhledat v tabulce";
            this.vTabulceToolStripMenuItem.Click += new System.EventHandler(this.dgv_find_Click);
            // 
            // find_cancel
            // 
            this.find_cancel.Name = "find_cancel";
            this.find_cancel.Size = new System.Drawing.Size(178, 22);
            this.find_cancel.Text = "Zrušit vyhledávání";
            this.find_cancel.Visible = false;
            this.find_cancel.Click += new System.EventHandler(this.storno_Click);
            // 
            // filmyBindingSource
            // 
            this.filmyBindingSource.DataMember = "filmy";
            this.filmyBindingSource.DataSource = this.filmsDataSet;
            // 
            // filmsDataSet
            // 
            this.filmsDataSet.DataSetName = "FilmsDataSet";
            this.filmsDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // search
            // 
            this.search.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.search.Location = new System.Drawing.Point(965, 12);
            this.search.Name = "search";
            this.search.Size = new System.Drawing.Size(172, 31);
            this.search.TabIndex = 5;
            this.search.Text = "Vyhledat na CSFD";
            this.search.UseVisualStyleBackColor = true;
            this.search.Click += new System.EventHandler(this.search_Click);
            this.search.KeyDown += new System.Windows.Forms.KeyEventHandler(this.hotkeys);
            // 
            // status
            // 
            this.status.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1,
            this.stav,
            this.toolStripStatusLabel3,
            this.TSSL,
            this.TSSPB});
            this.status.Location = new System.Drawing.Point(0, 350);
            this.status.Name = "status";
            this.status.Size = new System.Drawing.Size(1149, 22);
            this.status.TabIndex = 2;
            this.status.Text = "status";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(32, 17);
            this.toolStripStatusLabel1.Text = "Stav:";
            // 
            // stav
            // 
            this.stav.Name = "stav";
            this.stav.Size = new System.Drawing.Size(49, 17);
            this.stav.Text = "Spuštěn";
            // 
            // toolStripStatusLabel3
            // 
            this.toolStripStatusLabel3.Name = "toolStripStatusLabel3";
            this.toolStripStatusLabel3.Size = new System.Drawing.Size(16, 17);
            this.toolStripStatusLabel3.Text = "   ";
            // 
            // TSSL
            // 
            this.TSSL.Name = "TSSL";
            this.TSSL.Size = new System.Drawing.Size(74, 17);
            this.TSSL.Text = "Stav hledání:";
            this.TSSL.Visible = false;
            // 
            // TSSPB
            // 
            this.TSSPB.Name = "TSSPB";
            this.TSSPB.Size = new System.Drawing.Size(100, 16);
            this.TSSPB.Visible = false;
            // 
            // find_box
            // 
            this.find_box.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.find_box.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.find_box.Location = new System.Drawing.Point(536, 12);
            this.find_box.Name = "find_box";
            this.find_box.Size = new System.Drawing.Size(601, 31);
            this.find_box.TabIndex = 6;
            this.find_box.Visible = false;
            this.find_box.KeyDown += new System.Windows.Forms.KeyEventHandler(this.hotkeys);
            // 
            // close_btn
            // 
            this.close_btn.BackColor = System.Drawing.SystemColors.Window;
            this.close_btn.BackgroundImage = global::DVDatabaze.Properties.Resources.close;
            this.close_btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.close_btn.FlatAppearance.BorderSize = 0;
            this.close_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.close_btn.Location = new System.Drawing.Point(1069, 13);
            this.close_btn.Name = "close_btn";
            this.close_btn.Size = new System.Drawing.Size(30, 29);
            this.close_btn.TabIndex = 8;
            this.close_btn.UseVisualStyleBackColor = false;
            this.close_btn.Visible = false;
            this.close_btn.Click += new System.EventHandler(this.close_btn_Click);
            this.close_btn.KeyDown += new System.Windows.Forms.KeyEventHandler(this.hotkeys);
            // 
            // find_btn
            // 
            this.find_btn.BackColor = System.Drawing.Color.White;
            this.find_btn.BackgroundImage = global::DVDatabaze.Properties.Resources.search1;
            this.find_btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.find_btn.FlatAppearance.BorderSize = 0;
            this.find_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.find_btn.Location = new System.Drawing.Point(1105, 13);
            this.find_btn.Name = "find_btn";
            this.find_btn.Size = new System.Drawing.Size(30, 29);
            this.find_btn.TabIndex = 7;
            this.find_btn.UseVisualStyleBackColor = false;
            this.find_btn.Visible = false;
            this.find_btn.Click += new System.EventHandler(this.find_btn_Click);
            this.find_btn.KeyDown += new System.Windows.Forms.KeyEventHandler(this.hotkeys);
            // 
            // showing
            // 
            this.showing.AllowUserToAddRows = false;
            this.showing.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.showing.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.showing.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.Film,
            this.Type,
            this.State,
            this.Year,
            this.Length,
            this.Page,
            this.Rate,
            this.Seen,
            this.DVD});
            this.showing.ContextMenuStrip = this.Data;
            this.showing.Location = new System.Drawing.Point(12, 51);
            this.showing.Name = "showing";
            this.showing.ReadOnly = true;
            this.showing.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.showing.Size = new System.Drawing.Size(1125, 294);
            this.showing.TabIndex = 0;
            this.showing.Visible = false;
            this.showing.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.URL);
            this.showing.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Karta);
            this.showing.KeyDown += new System.Windows.Forms.KeyEventHandler(this.hotkeys);
            // 
            // ID
            // 
            this.ID.HeaderText = "ID";
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            this.ID.Visible = false;
            // 
            // Film
            // 
            this.Film.HeaderText = "Film";
            this.Film.Name = "Film";
            this.Film.ReadOnly = true;
            this.Film.Width = 250;
            // 
            // Type
            // 
            this.Type.HeaderText = "Typ";
            this.Type.Name = "Type";
            this.Type.ReadOnly = true;
            this.Type.Width = 150;
            // 
            // State
            // 
            this.State.HeaderText = "Země";
            this.State.Name = "State";
            this.State.ReadOnly = true;
            // 
            // Year
            // 
            this.Year.HeaderText = "Rok";
            this.Year.Name = "Year";
            this.Year.ReadOnly = true;
            this.Year.Width = 75;
            // 
            // Length
            // 
            this.Length.HeaderText = "Délka";
            this.Length.Name = "Length";
            this.Length.ReadOnly = true;
            // 
            // Page
            // 
            this.Page.HeaderText = "Adresa - CSFD";
            this.Page.Name = "Page";
            this.Page.ReadOnly = true;
            this.Page.Width = 150;
            // 
            // Rate
            // 
            this.Rate.HeaderText = "Hodnocení - CSFD";
            this.Rate.Name = "Rate";
            this.Rate.ReadOnly = true;
            this.Rate.Width = 75;
            // 
            // Seen
            // 
            this.Seen.HeaderText = "Viděl?";
            this.Seen.Name = "Seen";
            this.Seen.ReadOnly = true;
            this.Seen.Width = 75;
            // 
            // DVD
            // 
            this.DVD.HeaderText = "DVD";
            this.DVD.Name = "DVD";
            this.DVD.ReadOnly = true;
            this.DVD.Width = 75;
            // 
            // filmyTableAdapter
            // 
            this.filmyTableAdapter.ClearBeforeFill = true;
            // 
            // search_dgv
            // 
            this.search_dgv.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.search_dgv.Location = new System.Drawing.Point(787, 12);
            this.search_dgv.Name = "search_dgv";
            this.search_dgv.Size = new System.Drawing.Size(172, 31);
            this.search_dgv.TabIndex = 5;
            this.search_dgv.Text = "Vyhledat v tabulce";
            this.search_dgv.UseVisualStyleBackColor = true;
            this.search_dgv.Click += new System.EventHandler(this.dgv_find_Click);
            this.search_dgv.KeyDown += new System.Windows.Forms.KeyEventHandler(this.hotkeys);
            // 
            // databaze
            // 
            this.AcceptButton = this.add;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1149, 372);
            this.Controls.Add(this.close_btn);
            this.Controls.Add(this.find_btn);
            this.Controls.Add(this.status);
            this.Controls.Add(this.refresh);
            this.Controls.Add(this.search);
            this.Controls.Add(this.delete);
            this.Controls.Add(this.edit);
            this.Controls.Add(this.add);
            this.Controls.Add(this.find_box);
            this.Controls.Add(this.search_dgv);
            this.Controls.Add(this.showing);
            this.Controls.Add(this.DGV);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "databaze";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DVDatabaze";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.konec);
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DGV)).EndInit();
            this.Data.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.filmyBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.filmsDataSet)).EndInit();
            this.status.ResumeLayout(false);
            this.status.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.showing)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button add;
        private System.Windows.Forms.Button edit;
        private System.Windows.Forms.Button delete;
        private System.Windows.Forms.Button refresh;
        private System.Windows.Forms.DataGridView DGV;
        private System.Windows.Forms.Button search;
        private System.Windows.Forms.StatusStrip status;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripStatusLabel stav;
        private System.Windows.Forms.TextBox find_box;
        private System.Windows.Forms.Button find_btn;
        private System.Windows.Forms.Button close_btn;
        private System.Windows.Forms.ContextMenuStrip Data;
        private System.Windows.Forms.ToolStripMenuItem zobrazitKartuFilmuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editovatZáznamToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem vymazatZáznamToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem obnovitHodnoceníToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem přidatZáznamToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem vTabulceToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem find_cancel;
        private System.Windows.Forms.DataGridView showing;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel3;
        private System.Windows.Forms.ToolStripStatusLabel TSSL;
        private System.Windows.Forms.ToolStripProgressBar TSSPB;
        private FilmsDataSet filmsDataSet;
        private System.Windows.Forms.BindingSource filmyBindingSource;
        private FilmsDataSetTableAdapters.filmyTableAdapter filmyTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn filmDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn typDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn zeměDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn rokDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn délkaDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn adresaCSFDDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn hodnoceníCSFDDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn vidělDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dVDDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Film;
        private System.Windows.Forms.DataGridViewTextBoxColumn Type;
        private System.Windows.Forms.DataGridViewTextBoxColumn State;
        private System.Windows.Forms.DataGridViewTextBoxColumn Year;
        private System.Windows.Forms.DataGridViewTextBoxColumn Length;
        private System.Windows.Forms.DataGridViewTextBoxColumn Page;
        private System.Windows.Forms.DataGridViewTextBoxColumn Rate;
        private System.Windows.Forms.DataGridViewTextBoxColumn Seen;
        private System.Windows.Forms.DataGridViewTextBoxColumn DVD;
        private System.Windows.Forms.Button search_dgv;
    }
}

