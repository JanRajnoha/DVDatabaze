using System;
using System.Data.OleDb;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using HtmlAgilityPack;

namespace DVDatabaze
{
    public partial class databaze : Form
    {
        public databaze()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'filmsDataSet.filmy' table. You can move, or remove it, as needed.
            this.filmyTableAdapter.Fill(this.filmsDataSet.filmy);
            uprava(stav.Text);
        }

        private void konec(object sender, FormClosedEventArgs e)
        {
            
        }

        private void URL(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                System.Diagnostics.Process.Start(DGV.CurrentCell.Value.ToString());
                DGV.CurrentCell = null;
            }
            catch
            { }
        }

        private void add_Click(object sender, EventArgs e)
        {
            stav.Text = "Vytváření nového záznamu je zapnuto";
            plus pridej = new plus();
            if (pridej.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                stav.Text = "Přidávám záznam";
                string rate = "";
                string url = "";
                if (pridej.rate.Text != "")
                {
                    rate = pridej.rate.Text;
                    url = pridej.page.Text;
                }
                if (DGV.Rows.Count - 1 > -1)
                    filmyTableAdapter.Insert(pridej.name.Text, pridej.type.Text, pridej.country.Text, (int)pridej.year.Value, pridej.trvani.Text, url, rate, pridej.seen.Checked.ToString(), pridej.dvd.Checked.ToString());
                else
                    filmyTableAdapter.Insert(pridej.name.Text, pridej.type.Text, pridej.country.Text, (int)pridej.year.Value, pridej.trvani.Text, url, rate, pridej.seen.Checked.ToString(), pridej.dvd.Checked.ToString());
                stav.Text = "Záznam přidán";     
            }
            else
            {
                stav.Text = "Uživatel zrušil akci";     
            }
            this.DGV.EndEdit();
            this.filmyTableAdapter.Fill(this.filmsDataSet.filmy);
            this.DGV.Refresh();
            uprava(stav.Text);       
        }

        private void uprava (string prubeh)
        {
            stav.Text = "Pracuji";
            status.Refresh();
            for (int i = 0; i < DGV.Rows.Count; i++)
            {
                try
                {
                    if ((DGV[6, i].Value != null) && ((DGV[6, i].Value.ToString())[0] != '\"'))
                    {
                        string s = DGV[6, i].Value.ToString();
                        if (s[0] == '#')
                            DGV[6, i].Value = DGV[6, i].Value.ToString().Substring(1, DGV[6, i].Value.ToString().Length - 2);
                    }
                }
                catch { }
                
                try
                {
                    if ((DGV[8, i].Value.ToString() == "False") && (DGV[8, i].Value != null))
                    {
                        DGV[8, i].Value = "Ne";
                    }
                    else
                        if (DGV[8, i].Value.ToString() == "True")
                            DGV[8, i].Value = "Ano";

                    if ((DGV[9, i].Value.ToString() == "False") && (DGV[9, i].Value != null))
                    {
                        DGV[9, i].Value = "Ne";
                    }
                    else
                        if (DGV[9, i].Value.ToString() == "True")
                            DGV[9, i].Value = "Ano";
                }
                catch
                { }
            }
            stav.Text = prubeh;
            status.Refresh();
        }

        private void edit_Click(object sender, EventArgs e)
        {
            if (showing.Visible)
            {
                for (int i = 0; i < DGV.RowCount; i++)
                {
                    if (showing[1, showing.CurrentCell.RowIndex].Value.ToString() == DGV[1, i].Value.ToString())
                        DGV.CurrentCell = DGV[1, i];
                }
            }

            if (DGV.CurrentCell != null)
            {
                stav.Text = "Edituji položku: " + DGV[1, DGV.CurrentCell.RowIndex].Value.ToString();
                status.Refresh();
                plus edituj = new plus();
                edituj.year.Value = Convert.ToDecimal(DGV[4, DGV.CurrentCell.RowIndex].Value);
                edituj.name.Text = DGV[1, DGV.CurrentCell.RowIndex].Value.ToString();
                edituj.trvani.Text = DGV[5, DGV.CurrentCell.RowIndex].Value.ToString();
                edituj.country.Text = DGV[3, DGV.CurrentCell.RowIndex].Value.ToString();
                edituj.type.Text = DGV[2, DGV.CurrentCell.RowIndex].Value.ToString();
                edituj.page.Text = DGV[6, DGV.CurrentCell.RowIndex].Value.ToString();
                edituj.rate.Text = DGV[7, DGV.CurrentCell.RowIndex].Value.ToString();
                if (DGV[8, DGV.CurrentCell.RowIndex].Value.ToString() == "Ne")
                    edituj.seen.Checked = false;
                else
                    edituj.seen.Checked = true;

                if (DGV[9, DGV.CurrentCell.RowIndex].Value.ToString() == "Ne")
                    edituj.dvd.Checked = false;
                else
                    edituj.dvd.Checked = true;
                edituj.hand.Enabled = false;
                edituj.net.Enabled = false;
                edituj.AcceptButton = edituj.edit;
                edituj.edit.Visible = true;
                edituj.accept.Visible = false;
                edituj.refresh.Visible = true;
                if (edituj.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    DGV[1, DGV.CurrentCell.RowIndex].Value = edituj.name.Text;
                    DGV[2, DGV.CurrentCell.RowIndex].Value = edituj.type.Text;
                    DGV[3, DGV.CurrentCell.RowIndex].Value = edituj.country.Text;
                    DGV[4, DGV.CurrentCell.RowIndex].Value = edituj.year.Text;
                    DGV[5, DGV.CurrentCell.RowIndex].Value = edituj.trvani.Text;
                    DGV[6, DGV.CurrentCell.RowIndex].Value = edituj.page.Text;
                    DGV[7, DGV.CurrentCell.RowIndex].Value = edituj.rate.Text;
                    DGV[8, DGV.CurrentCell.RowIndex].Value = edituj.seen.Checked;
                    DGV[9, DGV.CurrentCell.RowIndex].Value = edituj.dvd.Checked;
                    filmyTableAdapter.Update(DGV[1, DGV.CurrentCell.RowIndex].Value.ToString(), DGV[2, DGV.CurrentCell.RowIndex].Value.ToString(), DGV[3, DGV.CurrentCell.RowIndex].Value.ToString(),
                        (int)DGV[4, DGV.CurrentCell.RowIndex].Value, DGV[5, DGV.CurrentCell.RowIndex].Value.ToString(), DGV[6, DGV.CurrentCell.RowIndex].Value.ToString(), DGV[7, DGV.CurrentCell.RowIndex].Value.ToString(),
                        DGV[8, DGV.CurrentCell.RowIndex].Value.ToString(), DGV[9, DGV.CurrentCell.RowIndex].Value.ToString(), (int)DGV[0, DGV.CurrentCell.RowIndex].Value, (int)DGV[4, DGV.CurrentCell.RowIndex].Value);
                    this.DGV.EndEdit();
                    this.filmyTableAdapter.Fill(this.filmsDataSet.filmy);
                    DGV.Refresh();
                    stav.Text = "Záznam byl změněn";
                }
                else
                    stav.Text = "Záznam zůstal beze změny";
                uprava(stav.Text);
                status.Refresh();
            }
        }

        private void delete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Chcete vymazat záznam?", "Smazat", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                filmyTableAdapter.Delete((int)DGV[0, DGV.CurrentCell.RowIndex].Value, (int)DGV[4, DGV.CurrentCell.RowIndex].Value);
                stav.Text = "Záznam byl odebrán";
            }
            else
                stav.Text = "Záznam byl ponechán";
            status.Refresh();
            this.DGV.EndEdit();
            this.filmyTableAdapter.Fill(this.filmsDataSet.filmy);
            this.DGV.Refresh();
            uprava(stav.Text);
        }

        private void refresh_Click(object sender, EventArgs e)
        {
            stav.Text = "Pracuji";
            status.Refresh();
            System.Threading.Thread.Sleep(1000);
            for (int i = 0; i < DGV.Rows.Count; i++)
            {
                if ((DGV[6, i].Value != null) && (DGV[6, i].Value.ToString() != ""))
                {
                    var webget = new HtmlWeb();
                    var doc = webget.Load("http://www.seznam.cz");
                    doc = webget.Load(DGV[6, i].Value.ToString());
                    DGV[7, i].Value = doc.DocumentNode.SelectSingleNode("//*[@id='rating']/h2").InnerHtml;
                    filmyTableAdapter.Update(DGV[1, i].Value.ToString(), DGV[2, i].Value.ToString(), DGV[3, i].Value.ToString(),
                                (int)DGV[4, i].Value, DGV[5, i].Value.ToString(), DGV[6, i].Value.ToString(), DGV[7, i].Value.ToString(),
                                DGV[8, i].Value.ToString(), DGV[9, i].Value.ToString(), (int)DGV[0, i].Value, (int)DGV[4, i].Value);
                }
            }   
            this.DGV.EndEdit();
            this.filmyTableAdapter.Fill(this.filmsDataSet.filmy);
            this.DGV.Refresh();
            stav.Text = "Operace hotova -> Hodnocení obnovena";
            status.Refresh();
            uprava(stav.Text);
        }

        private void search_Click(object sender, EventArgs e)
        {
            find_box.Visible = true;
            find_btn.Visible = true;
            close_btn.Visible = true;
            search.Visible = false;
            this.AcceptButton = find_btn;
            this.CancelButton = close_btn;
            stav.Text = "Vyhledávání je zapnuto";
            status.Refresh();
        }

        private void close_btn_Click(object sender, EventArgs e)
        {
            find_box.Visible = false;
            find_btn.Visible = false;
            close_btn.Visible = false;
            search.Visible = true;
            this.AcceptButton = add;
            this.CancelButton = null;
            stav.Text = "Vyhledávání je vypnuto";
            status.Refresh();
        }

        private void find_btn_Click(object sender, EventArgs e)
        {
            try
            {
                stav.Text = "Program zobrazuje výsledky hledání";
                status.Refresh();
                result res = new result();
                var webget = new HtmlWeb();
                string advanced = "";
                HtmlNode film;
                var doc = webget.Load("http://www.csfd.cz/hledat/?q=" + find_box.Text);
                for (int i = 1; i <= 4; i++)
                {
                    try
                    {
                        film = doc.DocumentNode.SelectSingleNode("//*[@id='page-wrapper']/div[2]/div[2]/div[1]/ul[1]/li[" + i + "]/p[1]");
                        string[] rok = film.InnerHtml.Split(',');
                        if (doc.DocumentNode.SelectSingleNode("//*[@id='page-wrapper']/div[2]/div[2]/div[1]/ul[1]/li[" + i + "]/h3/span") != null)
                            advanced = " " + doc.DocumentNode.SelectSingleNode("//*[@id='page-wrapper']/div[2]/div[2]/div[1]/ul[1]/li[" + i + "]/h3/span").InnerHtml;
                        res.DGV.Rows.Add(doc.DocumentNode.SelectSingleNode("//*[@id='page-wrapper']/div[2]/div[2]/div[1]/ul[1]/li[" + i + "]/h3/a").InnerHtml + advanced, rok[2]);
                    }
                    catch
                    { }
                }
                profil prof = new profil();
                string[] mezi, link, info;
                while (res.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    doc = webget.Load("http://www.csfd.cz/hledat/?q=" + find_box.Text);                    
                    stav.Text = "Byl vybrán film: " + res.DGV[0, res.DGV.CurrentCell.RowIndex].Value.ToString() + " (" + res.DGV[1, res.DGV.CurrentCell.RowIndex].Value.ToString() + ") -> Prosím, počkejte, program vytváří kartu filmu";
                    status.Refresh();
                    mezi = Regex.Split(doc.DocumentNode.SelectSingleNode("//*[@id='page-wrapper']/div[2]/div[2]/div[1]/ul[1]/li[" + (res.DGV.CurrentCell.RowIndex + 1) + "]").InnerHtml, "<a href=\"");
                    link = Regex.Split(mezi[1], "\">");
                    doc = webget.Load("http://www.csfd.cz" + link[0]);
                    prof.Type.Text = doc.DocumentNode.SelectSingleNode("//*[@id='profile']/div[1]/div[2]/p[1]").InnerHtml;
                    try
                    {
                        info = Regex.Split(doc.DocumentNode.SelectSingleNode("//*[@id='profile']/div[1]/div[2]/p[2]").InnerHtml, ", ");
                        prof.State.Text = info[0];
                        prof.Year.Text = info[1];
                        prof.Length.Text = info[2];
                    }
                    catch { }
                    prof.name.Text = res.DGV.CurrentCell.Value.ToString();
                    prof.dvde = false;
                    prof.seene = false;
                    if (doc.DocumentNode.SelectSingleNode("//*[@id='rating']/h2").InnerHtml != null)
                        prof.Rate.Text = doc.DocumentNode.SelectSingleNode("//*[@id='rating']/h2").InnerHtml;
                    try
                    {
                        int i = 1;
                        while (true)
                        {
                            switch (doc.DocumentNode.SelectSingleNode("//*[@id='profile']/div[1]/div[2]/div[1]/div[" + i + "]/h4[1]").InnerHtml)
                            {
                                case "Režie:":
                                    prof.Director.Text = doc.DocumentNode.SelectSingleNode("//*[@id='profile']/div[1]/div[2]/div[1]/div[" + i + "]/span[1]/a[1]").InnerHtml;
                                    break;

                                case "Kamera:":
                                    prof.Camera.Text = doc.DocumentNode.SelectSingleNode("//*[@id='profile']/div[1]/div[2]/div[1]/div[" + i + "]/span[1]/a[1]").InnerHtml;
                                    break;

                                case "Scénář:":
                                    prof.Script.Text = doc.DocumentNode.SelectSingleNode("//*[@id='profile']/div[1]/div[2]/div[1]/div[" + i + "]/span[1]/a[1]").InnerHtml;
                                    break;

                                case "Hudba:":
                                    prof.Music.Text = doc.DocumentNode.SelectSingleNode("//*[@id='profile']/div[1]/div[2]/div[1]/div[" + i + "]/span[1]/a[1]").InnerHtml;
                                    break;

                                case "Hrají:":
                                    try
                                    {
                                        int j = 1;
                                        while (true)
                                        {
                                            prof.Actors.Text += doc.DocumentNode.SelectSingleNode("//*[@id='profile']/div[1]/div[2]/div[1]/div[" + i + "]/span[1]/a[" + j + "]").InnerHtml;
                                            prof.Actors.Text += ", ";
                                            j++;
                                        }
                                    }
                                    catch { }
                                    break;
                            }
                            i++;
                        }
                    }
                    catch { }
                    try
                    {
                        prof.Content.Text = Regex.Split(Regex.Split(doc.DocumentNode.SelectSingleNode("//*[@id='plots']/div[2]/ul[1]/li[1]/div[1]").InnerHtml, "\">")[1], "<span")[0].Replace('\n', ' ').Replace('\t', ' ').Replace("<em>", "\"").Replace("</em>", "\"").Replace("<strong>", "\"").Replace("</strong>", "\"").Replace("<br>", "\r\n");
                    }
                    catch { }
                    string url;
                    if (!Regex.Split(Regex.Split(doc.DocumentNode.SelectSingleNode("//*[@id='profile']/div[1]/div[1]").InnerHtml, "src=\"")[1], "\"")[0].Contains("http:"))
                        url = "http:" + Regex.Split(Regex.Split(doc.DocumentNode.SelectSingleNode("//*[@id='profile']/div[1]/div[1]").InnerHtml, "src=\"")[1], "\"")[0];
                    else
                        url = Regex.Split(Regex.Split(doc.DocumentNode.SelectSingleNode("//*[@id='profile']/div[1]/div[1]").InnerHtml, "src=\"")[1], "\"")[0];
                    prof.pic.Load(url);
                    url = "http://www.csfd.cz" + link[0];
                    if (prof.ShowDialog(this) == System.Windows.Forms.DialogResult.OK)
                    {
                        if (DGV.Rows.Count - 1 > -1)
                            filmyTableAdapter.Insert(prof.name.Text, prof.Type.Text, prof.State.Text, Convert.ToInt32(prof.Year.Text), prof.Length.Text, url, prof.Rate.Text, prof.seen.Checked.ToString(), prof.dvd.Checked.ToString());
                        else
                            filmyTableAdapter.Insert(prof.name.Text, prof.Type.Text, prof.State.Text, Convert.ToInt32(prof.Year.Text), prof.Length.Text, url, prof.Rate.Text, prof.seen.Checked.ToString(), prof.dvd.Checked.ToString());

                        stav.Text = "Film byl přidán do databáze";
                        status.Refresh();
                        break;
                    }
                    else
                    {
                        stav.Text = "Film nebyl přidán do databáze, vyhledávání je zapnuté";
                    }
                }
                if (stav.Text == "Program zobrazuje výsledky hledání")
                    stav.Text = "Film nebyl vybrán, vyhledávání je zapnuté";
                this.DGV.EndEdit();
                this.filmyTableAdapter.Fill(this.filmsDataSet.filmy);
                this.DGV.Refresh();
                uprava(stav.Text);
            }

            catch { }
        }

        private void profil_Click(object sender, EventArgs e)
        {
            stav.Text = "Program vytváří kartu filmu";
            status.Refresh();
            profil prof = new profil();
            prof.add.Text = "Zavřít";
            prof.canccel.Visible = false;
            prof.dvd.Visible = true;
            prof.seen.Visible = true;
            prof.search = false;
            if ((DGV[6, DGV.CurrentCell.RowIndex].Value.ToString().Length > 1) && (pripojeni()))
                nactinet(ref prof);
            else
            {
                if (DGV[6, DGV.CurrentCell.RowIndex].Value.ToString().Length != 0)
                    prof.Rate.Text = DGV[7, DGV.CurrentCell.RowIndex].Value.ToString();
                prof.name.Text = DGV[1, DGV.CurrentCell.RowIndex].Value.ToString();
                prof.Type.Text = DGV[2, DGV.CurrentCell.RowIndex].Value.ToString();
                prof.State.Text = DGV[3, DGV.CurrentCell.RowIndex].Value.ToString();
                prof.Year.Text = DGV[4, DGV.CurrentCell.RowIndex].Value.ToString();
                prof.Length.Text = DGV[5, DGV.CurrentCell.RowIndex].Value.ToString();
            }
            if (DGV[8, DGV.CurrentCell.RowIndex].Value.ToString() == "Ano")
                prof.seene = true;
            if (DGV[9, DGV.CurrentCell.RowIndex].Value.ToString() == "Ano")
                prof.dvde = true;
            stav.Text = "Program zobrazuje kartu filmu";
            status.Refresh();
            prof.CancelButton = prof.add;
            prof.ShowDialog();
            stav.Text = "Spuštěn";
            status.Refresh();
        }

        private bool pripojeni()
        {
            try
            {
                var webget = new HtmlWeb();
                var doc = webget.Load("http://www.csfd.cz");
                return true;
            }
            catch
            {
                return false;
            }
        }

        private void nactinet(ref profil prof)
        {
            var webget = new HtmlWeb();
            var doc = webget.Load(DGV[6, DGV.CurrentCell.RowIndex].Value.ToString());
            prof.Type.Text = doc.DocumentNode.SelectSingleNode("//*[@id='profile']/div[1]/div[2]/p[1]").InnerHtml;
            string[] info = Regex.Split(doc.DocumentNode.SelectSingleNode("//*[@id='profile']/div[1]/div[2]/p[2]").InnerHtml, ", ");
            prof.State.Text = info[0];
            prof.name.Text = DGV[1, DGV.CurrentCell.RowIndex].Value.ToString();
            prof.Year.Text = info[1];
            prof.Length.Text = info[2];
            prof.Rate.Text = doc.DocumentNode.SelectSingleNode("//*[@id='rating']/h2").InnerHtml;
            try
            {
                int i = 1;
                while (true)
                {
                    switch (doc.DocumentNode.SelectSingleNode("//*[@id='profile']/div[1]/div[2]/div[1]/div[" + i + "]/h4[1]").InnerHtml)
                    {
                        case "Režie:":
                            prof.Director.Text = doc.DocumentNode.SelectSingleNode("//*[@id='profile']/div[1]/div[2]/div[1]/div[" + i + "]/span[1]/a[1]").InnerHtml;
                            break;

                        case "Kamera:":
                            prof.Camera.Text = doc.DocumentNode.SelectSingleNode("//*[@id='profile']/div[1]/div[2]/div[1]/div[" + i + "]/span[1]/a[1]").InnerHtml;
                            break;

                        case "Scénář:":
                            prof.Script.Text = doc.DocumentNode.SelectSingleNode("//*[@id='profile']/div[1]/div[2]/div[1]/div[" + i + "]/span[1]/a[1]").InnerHtml;
                            break;

                        case "Hudba:":
                            prof.Music.Text = doc.DocumentNode.SelectSingleNode("//*[@id='profile']/div[1]/div[2]/div[1]/div[" + i + "]/span[1]/a[1]").InnerHtml;
                            break;

                        case "Hrají:":
                            try
                            {
                                int j = 1;
                                while (true)
                                {
                                    prof.Actors.Text += doc.DocumentNode.SelectSingleNode("//*[@id='profile']/div[1]/div[2]/div[1]/div[" + i + "]/span[1]/a[" + j + "]").InnerHtml;
                                    prof.Actors.Text += ", ";
                                    j++;
                                }
                            }
                            catch { }
                            break;
                    }
                    i++;
                }
            }
            catch { }
            try
            {
                prof.Content.Text = Regex.Split(Regex.Split(doc.DocumentNode.SelectSingleNode("//*[@id='plots']/div[2]/ul[1]/li[1]/div[1]").InnerHtml, "\">")[1], "<span")[0].Replace('\n', ' ').Replace('\t', ' ').Replace("<em>", "\"").Replace("</em>", "\"").Replace("<strong>", "\"").Replace("</strong>", "\"").Replace("<br>", "\r\n");
            }
            catch { }
            prof.pic.Load("http:" + Regex.Split(Regex.Split(doc.DocumentNode.SelectSingleNode("//*[@id='profile']/div[1]/div[1]").InnerHtml, "src=\"")[1], "\"")[0]);            
        }

        private void dgv_find_Click(object sender, EventArgs e)
        {
            stav.Text = "Zobrazuji hledání v databázi";
            status.Refresh();
            find hledej = new find();
            hledej.text.Focus();
            if (hledej.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                TSSL.Visible = TSSPB.Visible = true;
                TSSPB.Maximum = DGV.Rows.Count;
                TSSPB.Value = 0;
                stav.Text = "Hledám ...";
                status.Refresh();
                this.DGV.EndEdit();
                this.filmyTableAdapter.Fill(this.filmsDataSet.filmy);
                this.DGV.Refresh();
                uprava(stav.Text);
                int[] vysledek = new int[0];
                switch (hledej.volba)
                {
                    case 1:
                        for (int i = 0; i < DGV.Rows.Count; i++)
                        {
                            if (DGV[1, i].Value.ToString().ToLower().Contains(hledej.text.Text.ToLower()))
                            {
                                Array.Resize(ref vysledek, vysledek.Length + 1);
                                vysledek[vysledek.Length - 1] = i;
                                TSSPB.Increment(1);
                            }
                        }
                        break;

                    case 2:
                        for (int i = 0; i < DGV.Rows.Count; i++)
                        {
                            if (DGV[2, i].Value.ToString().ToLower().Contains(hledej.text.Text.ToLower()))
                            {
                                Array.Resize(ref vysledek, vysledek.Length + 1);
                                vysledek[vysledek.Length - 1] = i;
                                TSSPB.Increment(1);
                            }
                        }
                        break;

                    case 3:
                        for (int i = 0; i < DGV.Rows.Count; i++)
                        {
                            if (DGV[3, i].Value.ToString().ToLower().Contains(hledej.text.Text.ToLower()))
                            {
                                Array.Resize(ref vysledek, vysledek.Length + 1);
                                vysledek[vysledek.Length - 1] = i;
                                TSSPB.Increment(1);
                            }
                        }
                        break;

                    case 4:
                        for (int i = 0; i < DGV.Rows.Count; i++)
                        {
                            if (Convert.ToInt32(DGV[4, i].Value.ToString().ToLower()) >= Convert.ToInt32(hledej.text.Text.ToLower()))
                            {
                                Array.Resize(ref vysledek, vysledek.Length + 1);
                                vysledek[vysledek.Length - 1] = i;
                                TSSPB.Increment(1);
                            }
                        }
                        break;

                    case 5:
                        for (int i = 0; i < DGV.Rows.Count; i++)
                        {
                            string[] porovnej = DGV[5, i].Value.ToString().Split('*');
                            if (porovnej.Length == 1)
                                porovnej[0] = DGV[5, i].Value.ToString().Split(' ')[0];
                            if (Convert.ToInt32(porovnej[0]) >= Convert.ToInt32(hledej.text.Text.ToLower()))
                            {
                                Array.Resize(ref vysledek, vysledek.Length + 1);
                                vysledek[vysledek.Length - 1] = i;
                                TSSPB.Increment(1);
                            }
                        }
                        break;

                    case 7:
                        for (int i = 0; i < DGV.Rows.Count; i++)
                        {
                            string[] porovnej = DGV[7, i].Value.ToString().Split('%');
                            if ((DGV[7, i].Value.ToString().Length != 0) && (Convert.ToInt32(porovnej[0]) != 1))
                                if (Convert.ToInt32(porovnej[0]) >= Convert.ToInt32(hledej.text.Text.ToLower()))
                                {
                                    Array.Resize(ref vysledek, vysledek.Length + 1);
                                    vysledek[vysledek.Length - 1] = i;
                                    TSSPB.Increment(1);
                                }
                        }
                        break;

                    case 8:
                        for (int i = 0; i < DGV.Rows.Count; i++)
                        {
                            if (DGV[8, i].Value.ToString().ToLower() == "ne")
                            {
                                Array.Resize(ref vysledek, vysledek.Length + 1);
                                vysledek[vysledek.Length - 1] = i;
                                TSSPB.Increment(1);
                            }
                        }
                        break;

                    case 9:
                        for (int i = 0; i < DGV.Rows.Count; i++)
                        {
                            if (DGV[9, i].Value.ToString().ToLower() == "ano")
                            {
                                Array.Resize(ref vysledek, vysledek.Length + 1);
                                vysledek[vysledek.Length - 1] = i;
                                TSSPB.Increment(1);
                            }
                        }
                        break;
                }

                if (vysledek.Length != 0)
                {
                    TSSPB.Value = 0;
                    TSSPB.Maximum = vysledek.Length;
                    find_cancel.Visible = true;
                    showing.DataSource = null;
                    showing.Rows.Clear();
                    showing.Visible = true;
                    DGV.Visible = true;
                    for (int i = 0; i < vysledek.Length; i++)
                    {
                        showing.Rows.Add(1);
                        TSSPB.Increment(1);
                        showing[0, i].Value = DGV[0, vysledek[i]].Value.ToString();
                        showing[1, i].Value = DGV[1, vysledek[i]].Value.ToString();
                        showing[2, i].Value = DGV[2, vysledek[i]].Value.ToString();
                        showing[3, i].Value = DGV[3, vysledek[i]].Value.ToString();
                        showing[4, i].Value = DGV[4, vysledek[i]].Value.ToString();
                        showing[5, i].Value = DGV[5, vysledek[i]].Value.ToString();
                        showing[6, i].Value = DGV[6, vysledek[i]].Value.ToString();
                        showing[7, i].Value = DGV[7, vysledek[i]].Value.ToString();
                        showing[8, i].Value = DGV[8, vysledek[i]].Value.ToString();
                        showing[9, i].Value = DGV[9, vysledek[i]].Value.ToString();
                    }
                    showing.Update();
                    stav.Text = "Zobrazuji výsledky hledání";
                    status.Refresh();
                }
                else
                {
                    stav.Text = "Pro vaše zadané paramtery neodpovídá žádný film";
                    status.Refresh();
                }
            }
            else
            {
                stav.Text = "Vyhledávání bylo zrušeno";
                status.Refresh();
            }
        }

        private void hotkeys(object sender, KeyEventArgs e)
        {
            if (e.Control)
            {
                switch (e.KeyCode)
                {
                    case Keys.F:
                        dgv_find_Click(sender, e);
                        break;
                }
            }

            switch (e.KeyCode)
            {
                case Keys.F3:
                    if (!find_box.Visible)
                    {
                        search_Click(sender, e);
                        find_box.Focus();
                    }
                    else
                    {
                        close_btn_Click(sender, e);
                    }
                    break;

                case Keys.Enter:
                    if ((DGV.CurrentCell != null) && (DGV.CurrentCell.RowIndex != DGV.RowCount - 1))
                    {
                        profil_Click(sender, e);
                        try
                        {
                            DGV.CurrentCell = DGV[DGV.CurrentCell.ColumnIndex, DGV.CurrentCell.RowIndex - 1];
                        }
                        catch { }
                    }
                    break;

                case Keys.Escape:
                    if (showing.Rows.Count >= 1)
                        storno_Click(sender, e);
                    break;

                case Keys.Delete:
                    if ((DGV.CurrentCell != null) && (DGV.CurrentCell.RowIndex != DGV.Rows.Count))
                        delete_Click(sender, e);
                    break;

                case Keys.Add:
                    add_Click(sender, e);
                    break;
            }
        }

        private void storno_Click(object sender, EventArgs e)
        {
            showing.Visible = false;
            DGV.Visible = true;
            find_cancel.Visible = false;
            stav.Text = "Výsledky hledání byly zrušeny";
            status.Refresh();
            TSSL.Visible = TSSPB.Visible = false;
        }

        private void Karta(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                profil_Click(sender, e);
            }

            catch { }
        }
    }
}
