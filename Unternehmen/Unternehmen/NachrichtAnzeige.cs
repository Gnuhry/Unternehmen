using System;
using System.Windows.Forms;

namespace Unternehmen
{
    public partial class NachrichtAnzeige : Form
    { 
        Verwaltung verwaltung;
        int index;
        bool Chef;
        public NachrichtAnzeige(int index,Verwaltung verwaltung,bool Chef)
        {
            this.Chef = Chef;
            this.verwaltung = verwaltung;
            this.index = index;
            InitializeComponent();
            if (Chef)
            {
                lbSender.Text ="Von :"+ verwaltung.GetFirma().GetAdminNachrichtSender(index).GetKontoInhaber();
                lbAnzeige.Text = verwaltung.GetFirma().GetAdminNachricht(index);
                lbSendeDatum.Text = verwaltung.GetFirma().GetSendeDatum(index).ToShortDateString();
                pcBAnhang.Image = verwaltung.GetFirma().GetAdminAnhang(index);
                return;
            }
            lbSender.Text = verwaltung.GetAngemeldetePerson().GetSender(index).GetKontoInhaber();
            lbAnzeige.Text = verwaltung.GetAngemeldetePerson().GetNachricht(index) ;
            lbSendeDatum.Text = verwaltung.GetAngemeldetePerson().GetSendeDatum(index).ToShortDateString();
            pcBAnhang.Image = verwaltung.GetAngemeldetePerson().GetAnhang(index);

        }

        private void btnLoschen_Click(object sender, EventArgs e)
        {
            if (Chef)
                verwaltung.GetFirma().RemoveNachricht(index);
            else
                verwaltung.GetAngemeldetePerson().RemoveNachricht(index);
            Close();
        }
    }
}
