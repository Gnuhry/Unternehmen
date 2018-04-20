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
    public partial class NachrichtAnzeige : Form
    { 
        Verwaltung verwaltung;
        int index;
        public NachrichtAnzeige(int index,Verwaltung verwaltung)
        {
            this.verwaltung = verwaltung;
            this.index = index;
            InitializeComponent();
            lbSender.Text = verwaltung.GetAngemeldetePerson().GetAnzeige()[index];
            lbAnzeige.Text = verwaltung.GetAngemeldetePerson().GetNachricht(index) ;
        }

        private void btnLoschen_Click(object sender, EventArgs e)
        {
            verwaltung.GetAngemeldetePerson().RemoveNachricht(index);
            Close();
        }
    }
}
