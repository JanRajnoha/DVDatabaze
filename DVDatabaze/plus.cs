using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using HtmlAgilityPack;

namespace DVDatabaze
{
    public partial class plus : Form
    {
        HtmlNode film;
        int stop = 0;

        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams cp = base.CreateParams;
                cp.Style &= ~0x00C00000 /* WS_CAPTION */;
                return cp;
            }
        }

        public plus()
        {
            InitializeComponent();
        }

        private void zmena(object sender, EventArgs e)
        {
            try
            {
                var webget = new HtmlWeb();
                var doc = webget.Load("http://www.seznam.cz");
                string advanced = " ";

                if (hand.Checked)
                {
                    box.Enabled = true;
                    rate.Text = "";
                    page.Text = "";
                }
                else
                {
                    result res = new result();
                    box.Enabled = false;
                    doc = webget.Load("http://www.csfd.cz/hledat/?q=" + name.Text);
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
                    if (stop == 0)
                        if (res.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                        {
                            string[] mezi = Regex.Split(doc.DocumentNode.SelectSingleNode("//*[@id='page-wrapper']/div[2]/div[2]/div[1]/ul[1]/li[" + (res.DGV.CurrentCell.RowIndex + 1) + "]").InnerHtml, "<a href=\"");
                            string[] link = Regex.Split(mezi[1], "\">");
                            doc = webget.Load("http://www.csfd.cz" + link[0]);
                            type.Text = doc.DocumentNode.SelectSingleNode("//*[@id='profile']/div[1]/div[2]/p[1]").InnerHtml;
                            string[] info = Regex.Split(doc.DocumentNode.SelectSingleNode("//*[@id='profile']/div[1]/div[2]/p[2]").InnerHtml, ", ");
                            country.Text = info[0];
                            name.Text = res.DGV.CurrentCell.Value.ToString();
                            year.Value = Convert.ToDecimal(info[1]);
                            trvani.Text = info[2];
                            page.Text = "#http://www.csfd.cz" + link[0];
                            rate.Text = doc.DocumentNode.SelectSingleNode("//*[@id='rating']/h2").InnerHtml;
                        }
                    stop++;
                }
            }
            catch
            { hand.Checked = true;}
        }

        private void accept_Click(object sender, EventArgs e)
        {

        }

        private void ochrana(object sender, EventArgs e)
        {
            if (name.Text.Length == 0)
            {
                net.Enabled = false;
                accept.Enabled = false;
            }
            else
            {
                if (refresh.Visible)
                    net.Enabled = false;
                else
                    net.Enabled = true;
                accept.Enabled = true;
            }
            stop = 0;
        }

        private void net_prepnuti(object sender, EventArgs e)
        {
            if (!net.Enabled)
                hand.Checked = true;
        }

        private void obnov_Click(object sender, EventArgs e)
        {
            var webget = new HtmlWeb();
            var doc = webget.Load("I:/DATA_Programovani/database/httpwww.csfd.czhledatq=star+trek.htm");
            doc = webget.Load(page.Text);
            rate.Text = doc.DocumentNode.SelectSingleNode("//*[@id='rating']/h2").InnerHtml;
        }
    }
}
