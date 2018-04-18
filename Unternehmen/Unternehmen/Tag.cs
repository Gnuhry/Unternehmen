using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Unternehmen
{
    public partial class Tag : Form
    {
        Verwaltung verwaltung;
        public Tag(Verwaltung verwaltung)
        {
            this.verwaltung = verwaltung;
            InitializeComponent();
        }

        private void btnVor_Click(object sender, EventArgs e)
        {

        }

        private void btnZuruck_Click(object sender, EventArgs e)
        {

        }
    }
}
