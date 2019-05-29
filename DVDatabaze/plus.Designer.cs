namespace DVDatabaze
{
    partial class plus
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
            this.lbl1 = new System.Windows.Forms.Label();
            this.name = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.country = new System.Windows.Forms.TextBox();
            this.year = new System.Windows.Forms.NumericUpDown();
            this.box = new System.Windows.Forms.GroupBox();
            this.trvani = new System.Windows.Forms.TextBox();
            this.type = new System.Windows.Forms.TextBox();
            this.lbl2 = new System.Windows.Forms.Label();
            this.lbl3 = new System.Windows.Forms.Label();
            this.lbl4 = new System.Windows.Forms.Label();
            this.accept = new System.Windows.Forms.Button();
            this.seen = new System.Windows.Forms.CheckBox();
            this.hand = new System.Windows.Forms.RadioButton();
            this.dvd = new System.Windows.Forms.CheckBox();
            this.page = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.rate = new System.Windows.Forms.TextBox();
            this.csfd = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.edit = new System.Windows.Forms.Button();
            this.cancel = new System.Windows.Forms.Button();
            this.refresh = new System.Windows.Forms.Button();
            this.net = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.year)).BeginInit();
            this.box.SuspendLayout();
            this.csfd.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbl1
            // 
            this.lbl1.AutoSize = true;
            this.lbl1.Location = new System.Drawing.Point(12, 23);
            this.lbl1.Name = "lbl1";
            this.lbl1.Size = new System.Drawing.Size(62, 13);
            this.lbl1.TabIndex = 19;
            this.lbl1.Text = "Název filmu";
            // 
            // name
            // 
            this.name.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.name.Location = new System.Drawing.Point(80, 20);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(317, 20);
            this.name.TabIndex = 1;
            this.name.TextChanged += new System.EventHandler(this.ochrana);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 105);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 13);
            this.label1.TabIndex = 15;
            this.label1.Text = "Délka filmu";
            // 
            // country
            // 
            this.country.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.country.Location = new System.Drawing.Point(74, 50);
            this.country.Name = "country";
            this.country.Size = new System.Drawing.Size(317, 20);
            this.country.TabIndex = 5;
            // 
            // year
            // 
            this.year.Location = new System.Drawing.Point(74, 76);
            this.year.Maximum = new decimal(new int[] {
            3000,
            0,
            0,
            0});
            this.year.Minimum = new decimal(new int[] {
            1500,
            0,
            0,
            0});
            this.year.Name = "year";
            this.year.Size = new System.Drawing.Size(317, 20);
            this.year.TabIndex = 6;
            this.year.Value = new decimal(new int[] {
            2014,
            0,
            0,
            0});
            // 
            // box
            // 
            this.box.Controls.Add(this.year);
            this.box.Controls.Add(this.trvani);
            this.box.Controls.Add(this.country);
            this.box.Controls.Add(this.type);
            this.box.Controls.Add(this.lbl2);
            this.box.Controls.Add(this.lbl3);
            this.box.Controls.Add(this.label1);
            this.box.Controls.Add(this.lbl4);
            this.box.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.box.Location = new System.Drawing.Point(11, 83);
            this.box.Name = "box";
            this.box.Size = new System.Drawing.Size(403, 155);
            this.box.TabIndex = 16;
            this.box.TabStop = false;
            this.box.Text = "Ruční vyplnění";
            // 
            // trvani
            // 
            this.trvani.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.trvani.Location = new System.Drawing.Point(74, 102);
            this.trvani.Name = "trvani";
            this.trvani.Size = new System.Drawing.Size(317, 20);
            this.trvani.TabIndex = 6;
            // 
            // type
            // 
            this.type.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.type.Location = new System.Drawing.Point(74, 24);
            this.type.Name = "type";
            this.type.Size = new System.Drawing.Size(317, 20);
            this.type.TabIndex = 4;
            // 
            // lbl2
            // 
            this.lbl2.AutoSize = true;
            this.lbl2.Location = new System.Drawing.Point(6, 27);
            this.lbl2.Name = "lbl2";
            this.lbl2.Size = new System.Drawing.Size(25, 13);
            this.lbl2.TabIndex = 17;
            this.lbl2.Text = "Typ";
            // 
            // lbl3
            // 
            this.lbl3.AutoSize = true;
            this.lbl3.Location = new System.Drawing.Point(6, 53);
            this.lbl3.Name = "lbl3";
            this.lbl3.Size = new System.Drawing.Size(34, 13);
            this.lbl3.TabIndex = 18;
            this.lbl3.Text = "Země";
            // 
            // lbl4
            // 
            this.lbl4.AutoSize = true;
            this.lbl4.Location = new System.Drawing.Point(6, 79);
            this.lbl4.Name = "lbl4";
            this.lbl4.Size = new System.Drawing.Size(61, 13);
            this.lbl4.TabIndex = 15;
            this.lbl4.Text = "Rok výroby";
            // 
            // accept
            // 
            this.accept.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.accept.Enabled = false;
            this.accept.Location = new System.Drawing.Point(11, 369);
            this.accept.Name = "accept";
            this.accept.Size = new System.Drawing.Size(122, 38);
            this.accept.TabIndex = 8;
            this.accept.Text = "Přidat";
            this.accept.UseVisualStyleBackColor = true;
            this.accept.Click += new System.EventHandler(this.accept_Click);
            // 
            // seen
            // 
            this.seen.AutoSize = true;
            this.seen.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.seen.Location = new System.Drawing.Point(15, 340);
            this.seen.Name = "seen";
            this.seen.Size = new System.Drawing.Size(118, 17);
            this.seen.TabIndex = 7;
            this.seen.Text = "Viděli jste tento film?";
            this.seen.UseVisualStyleBackColor = true;
            // 
            // hand
            // 
            this.hand.AutoSize = true;
            this.hand.Checked = true;
            this.hand.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.hand.Location = new System.Drawing.Point(15, 51);
            this.hand.Name = "hand";
            this.hand.Size = new System.Drawing.Size(87, 17);
            this.hand.TabIndex = 2;
            this.hand.TabStop = true;
            this.hand.Text = "Doplnit ručně";
            this.hand.UseVisualStyleBackColor = true;
            this.hand.CheckedChanged += new System.EventHandler(this.zmena);
            // 
            // dvd
            // 
            this.dvd.AutoSize = true;
            this.dvd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.dvd.Location = new System.Drawing.Point(155, 340);
            this.dvd.Name = "dvd";
            this.dvd.Size = new System.Drawing.Size(190, 17);
            this.dvd.TabIndex = 7;
            this.dvd.Text = "Máte tento film na DVD či Blu-Ray?";
            this.dvd.UseVisualStyleBackColor = true;
            // 
            // page
            // 
            this.page.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.page.Location = new System.Drawing.Point(76, 22);
            this.page.Name = "page";
            this.page.ReadOnly = true;
            this.page.Size = new System.Drawing.Size(317, 20);
            this.page.TabIndex = 19;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(8, 50);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 13);
            this.label3.TabIndex = 22;
            this.label3.Text = "Hodnocení";
            // 
            // rate
            // 
            this.rate.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.rate.Location = new System.Drawing.Point(76, 47);
            this.rate.Name = "rate";
            this.rate.ReadOnly = true;
            this.rate.Size = new System.Drawing.Size(115, 20);
            this.rate.TabIndex = 21;
            // 
            // csfd
            // 
            this.csfd.Controls.Add(this.rate);
            this.csfd.Controls.Add(this.label3);
            this.csfd.Controls.Add(this.page);
            this.csfd.Controls.Add(this.label2);
            this.csfd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.csfd.Location = new System.Drawing.Point(11, 244);
            this.csfd.Name = "csfd";
            this.csfd.Size = new System.Drawing.Size(403, 90);
            this.csfd.TabIndex = 19;
            this.csfd.TabStop = false;
            this.csfd.Text = "CSFD.cz";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 13);
            this.label2.TabIndex = 20;
            this.label2.Text = "URL";
            // 
            // edit
            // 
            this.edit.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.edit.Location = new System.Drawing.Point(11, 369);
            this.edit.Name = "edit";
            this.edit.Size = new System.Drawing.Size(122, 38);
            this.edit.TabIndex = 20;
            this.edit.Text = "Upravit";
            this.edit.UseVisualStyleBackColor = true;
            this.edit.Visible = false;
            // 
            // cancel
            // 
            this.cancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.cancel.Location = new System.Drawing.Point(139, 369);
            this.cancel.Name = "cancel";
            this.cancel.Size = new System.Drawing.Size(117, 38);
            this.cancel.TabIndex = 9;
            this.cancel.Text = "Zrušit";
            this.cancel.UseVisualStyleBackColor = true;
            // 
            // refresh
            // 
            this.refresh.Location = new System.Drawing.Point(262, 369);
            this.refresh.Name = "refresh";
            this.refresh.Size = new System.Drawing.Size(122, 38);
            this.refresh.TabIndex = 8;
            this.refresh.Text = "Obnovit hodnocení";
            this.refresh.UseVisualStyleBackColor = true;
            this.refresh.Visible = false;
            this.refresh.Click += new System.EventHandler(this.obnov_Click);
            // 
            // net
            // 
            this.net.AutoSize = true;
            this.net.Enabled = false;
            this.net.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.net.Location = new System.Drawing.Point(134, 51);
            this.net.Name = "net";
            this.net.Size = new System.Drawing.Size(262, 17);
            this.net.TabIndex = 3;
            this.net.Text = "Doplnit pomocí česko-slovenské filmové databáze";
            this.net.UseVisualStyleBackColor = true;
            this.net.CheckedChanged += new System.EventHandler(this.zmena);
            this.net.EnabledChanged += new System.EventHandler(this.net_prepnuti);
            // 
            // plus
            // 
            this.AcceptButton = this.accept;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.cancel;
            this.ClientSize = new System.Drawing.Size(427, 379);
            this.Controls.Add(this.edit);
            this.Controls.Add(this.csfd);
            this.Controls.Add(this.dvd);
            this.Controls.Add(this.seen);
            this.Controls.Add(this.net);
            this.Controls.Add(this.hand);
            this.Controls.Add(this.cancel);
            this.Controls.Add(this.refresh);
            this.Controls.Add(this.accept);
            this.Controls.Add(this.box);
            this.Controls.Add(this.name);
            this.Controls.Add(this.lbl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "plus";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "plus";
            ((System.ComponentModel.ISupportInitialize)(this.year)).EndInit();
            this.box.ResumeLayout(false);
            this.box.PerformLayout();
            this.csfd.ResumeLayout(false);
            this.csfd.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.Label lbl1;
        internal System.Windows.Forms.TextBox name;
        internal System.Windows.Forms.Label label1;
        internal System.Windows.Forms.TextBox country;
        internal System.Windows.Forms.NumericUpDown year;
        internal System.Windows.Forms.GroupBox box;
        internal System.Windows.Forms.TextBox trvani;
        internal System.Windows.Forms.TextBox type;
        internal System.Windows.Forms.Label lbl2;
        internal System.Windows.Forms.Label lbl3;
        internal System.Windows.Forms.Label lbl4;
        internal System.Windows.Forms.Button accept;
        internal System.Windows.Forms.CheckBox seen;
        internal System.Windows.Forms.RadioButton hand;
        internal System.Windows.Forms.CheckBox dvd;
        internal System.Windows.Forms.TextBox page;
        internal System.Windows.Forms.Label label3;
        internal System.Windows.Forms.TextBox rate;
        internal System.Windows.Forms.GroupBox csfd;
        internal System.Windows.Forms.Label label2;
        internal System.Windows.Forms.Button edit;
        internal System.Windows.Forms.Button cancel;
        internal System.Windows.Forms.Button refresh;
        internal System.Windows.Forms.RadioButton net;

    }
}