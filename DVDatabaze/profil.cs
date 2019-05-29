using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DVDatabaze
{
    public partial class profil : Form
    {
        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams cp = base.CreateParams;
                cp.Style &= ~0x00C00000 /* WS_CAPTION */;
                return cp;
            }
        }

        internal bool dvde;
        internal bool seene;
        internal bool search = true;
        public profil()
        {
            InitializeComponent();
        }

        private void profil_Load(object sender, EventArgs e)
        {
            name.Focus();
            dvd.Checked = dvde;
            seen.Checked = seene;
        }

        private void zmena(object sender, EventArgs e)
        {
            if (!search)
            {
                dvd.Checked = dvde;
                seen.Checked = seene;
            }
        }
    }
}
