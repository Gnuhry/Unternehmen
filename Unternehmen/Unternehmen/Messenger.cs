using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace Unternehmen
{
    public partial class Messenger : Form
    {
        Verwaltung verwaltung;
        bool Chef;
        int aktiellesIndex;
        public Messenger(Verwaltung verwaltung, bool Chef)
        {
            aktiellesIndex = -1;
            this.Chef = Chef;
            InitializeComponent();
            this.verwaltung = verwaltung;
            comBEmpfanger.Items.Add("Admin");
            for(int f = 0; f < verwaltung.GetFirma().GetMitarbeiterAnzahl(); f++)
                    comBEmpfanger.Items.Add(verwaltung.GetFirma().GetMitarbeiter(f).GetKontoInhaber());
            NachrichtenLaden();
        }

        private void NachrichtenLaden()
        {
            if (Chef)
            {
                if (verwaltung.GetFirma().GetAdminNachrichtAnzahl() != 0)
                {
                    for (int f = 0; f < verwaltung.GetFirma().GetAdminNachrichtAnzahl(); f++)
                        lBoxNachrichten.Items.Add(verwaltung.GetFirma().GetAdminAnzeige()[f]);
                    lBoxNachrichten.MouseDown += LBoxNachrichten_MouseDown;
                    lBoxNachrichten.MouseDoubleClick += LBoxNachrichten_MouseDoubleClick;
                }
                else
                    lBoxNachrichten.Enabled = false;
                return;
            }
            if (verwaltung.GetAngemeldetePerson().GetNachrichtenAnzahl() != 0)
            {
                for (int f = 0; f < verwaltung.GetAngemeldetePerson().GetNachrichtenAnzahl(); f++)
                    lBoxNachrichten.Items.Add(verwaltung.GetAngemeldetePerson().GetAnzeige()[f]);
                lBoxNachrichten.MouseDown += LBoxNachrichten_MouseDown;
                lBoxNachrichten.MouseDoubleClick += LBoxNachrichten_MouseDoubleClick;
            }
            else
                lBoxNachrichten.Enabled = false;
        }

        private void LBoxNachrichten_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
                if (lBoxNachrichten.IndexFromPoint(e.Location) != ListBox.NoMatches)
                    if (!Chef)
                    {
                        if (verwaltung.GetAngemeldetePerson().GetSender(lBoxNachrichten.IndexFromPoint(e.Location)) != null)
                        {
                            for (int f = 0; f < verwaltung.GetFirma().GetMitarbeiterAnzahl(); f++)
                                if (verwaltung.GetFirma().GetMitarbeiter(f) == verwaltung.GetAngemeldetePerson().GetSender(lBoxNachrichten.IndexFromPoint(e.Location)))
                                    comBEmpfanger.SelectedIndex = f+1;
                        }
                        else
                        {
                            comBEmpfanger.SelectedIndex = 0;
                        }
                    }
                    else
                    {
                        if (verwaltung.GetFirma().GetAdminNachrichtSender(lBoxNachrichten.IndexFromPoint(e.Location)) != null)
                        {
                            for (int f = 0; f < verwaltung.GetFirma().GetMitarbeiterAnzahl(); f++)
                                if (verwaltung.GetFirma().GetMitarbeiter(f) == verwaltung.GetFirma().GetAdminNachrichtSender(lBoxNachrichten.IndexFromPoint(e.Location)))
                                    comBEmpfanger.SelectedIndex = f+1;
                        }
                        else
                        {
                            comBEmpfanger.SelectedIndex = 0;
                        }
                    }
        }

        private void LBoxNachrichten_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (lBoxNachrichten.IndexFromPoint(e.Location) != ListBox.NoMatches)
            {
                Nachricht_Anzeigen(lBoxNachrichten.IndexFromPoint(e.Location));
            }
        }

        private void Nachricht_Anzeigen(int index)
        {
            lbNachricht.Visible = lbSendeDatum.Visible = lbSender.Visible = btnLoschen.Visible = true;
            if (Chef)
            {
                lbNachricht.Text = verwaltung.GetFirma().GetAdminNachricht(index);
                if (verwaltung.GetFirma().GetAdminNachrichtSender(index).GetKontoInhaber() == null)
                    lbSender.Text = "From: Admin";
                else
                    lbSender.Text = "From: " + verwaltung.GetFirma().GetAdminNachrichtSender(index).GetKontoInhaber();
                lbSendeDatum.Text = verwaltung.GetFirma().GetSendeDatum(index).ToShortTimeString() + " "+verwaltung.GetFirma().GetSendeDatum(index).ToShortDateString();
                aktiellesIndex = index;
                pcBAnhangEingang.Image = verwaltung.GetFirma().GetAdminAnhang(index);
                return;
            }
            lbNachricht.Text = verwaltung.GetAngemeldetePerson().GetNachricht(index);
            if(verwaltung.GetAngemeldetePerson().GetSender(index)==null)
                lbSender.Text = "From: Admin";
            else
                lbSender.Text = "From: "+verwaltung.GetAngemeldetePerson().GetSender(index).GetKontoInhaber();
            lbSendeDatum.Text = verwaltung.GetAngemeldetePerson().GetSendeDatum(index).ToShortDateString();
            pcBAnhangEingang.Image = verwaltung.GetAngemeldetePerson().GetAnhang(index);
            aktiellesIndex = index;
        }

 

        private void btnSenden_Click(object sender, EventArgs e)
        {

            txBNachricht.Text = txBNachricht.Text.Trim();
            if (Chef) {
                if (txBNachricht.Text != "" && txBNachricht.Text != null && comBEmpfanger.SelectedIndex == 0)
                {
                    verwaltung.GetFirma().ReciveAdminNachricht(txBNachricht.Text, pcBAnhang.Image, null);
                    txBNachricht.Text = null;
                }
                else if (txBNachricht.Text != "" && txBNachricht.Text != null && comBEmpfanger.SelectedIndex > -1)
                {
                    verwaltung.GetFirma().GetMitarbeiter(comBEmpfanger.SelectedIndex - 1).ReciveNachricht(txBNachricht.Text, pcBAnhang.Image, null);
                    txBNachricht.Text = null;
                }
            }
            else
            {
                if (txBNachricht.Text != "" && txBNachricht.Text != null && comBEmpfanger.SelectedIndex == 0)
                {
                    verwaltung.GetFirma().ReciveAdminNachricht(txBNachricht.Text, pcBAnhang.Image, verwaltung.GetAngemeldetePerson());
                    txBNachricht.Text = null;
                }
                else if (txBNachricht.Text != "" && txBNachricht.Text != null && comBEmpfanger.SelectedIndex > -1)
                {
                    verwaltung.GetFirma().GetMitarbeiter(comBEmpfanger.SelectedIndex - 1).ReciveNachricht(txBNachricht.Text, pcBAnhang.Image, verwaltung.GetAngemeldetePerson());
                    txBNachricht.Text = null;
                }
            }
        }

        private void Messenger_FormClosing(object sender, FormClosingEventArgs e)
        {
        }

        private void btnBildHochladen_Click(object sender, EventArgs e)
        {
            Stream myStream = null;
            OpenFileDialog openFileDialog1 = new OpenFileDialog
            {
                InitialDirectory = "c:\\",
                Filter = "Image Files(*.BMP;*.JPG;*.GIF;*.PNG)|*.BMP;*.JPG;*.GIF;*.PNG",//Powerpoint Excel pdf word  |Dateien(*.ppt;*.pptx;*.xls;*.doc;.txt)|*.ppt;*.pptx;*.xls;*.doc;.txt"
                FilterIndex = 2,
                RestoreDirectory = true
            };

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
                try
                {
                    if ((myStream = openFileDialog1.OpenFile()) != null)
                        using (myStream) 
                            pcBAnhang.Image = new Bitmap(myStream);
                }
                catch (Exception ex)
                {                   
                        MessageBox.Show("Error: Could not read file from disk. Original error: " + ex.Message);
                }
        }

        private void Messenger_DragDrop(object sender, DragEventArgs e)
        {
            pcBAnhang.Image = new Bitmap(((string[])e.Data.GetData(DataFormats.FileDrop))[0]);
        }

        private void Messenger_DragEnter(object sender, DragEventArgs e)
        {
            string[] validExtensions = new string[] { ".png", ".jpg" };
            foreach (var ext in ((IEnumerable<string>)e.Data.GetData(DataFormats.FileDrop)).Select((f) => System.IO.Path.GetExtension(f)))
                if (!validExtensions.Contains(ext))
                    e.Effect = DragDropEffects.None;
            e.Effect = DragDropEffects.Copy;
        }

        private void btnLoschen_Click(object sender, EventArgs e)
        {
            if (Chef)
                verwaltung.GetFirma().RemoveNachricht(aktiellesIndex);
            else
            verwaltung.GetAngemeldetePerson().RemoveNachricht(aktiellesIndex);
            lbNachricht.Visible = lbSendeDatum.Visible = lbSender.Visible = btnLoschen.Visible = false;
            lbNachricht.Text = lbSendeDatum.Text = lbSender.Text = btnLoschen.Text= null;
            pcBAnhangEingang.Image = null;
            lBoxNachrichten.Items.Clear();
            NachrichtenLaden();
        }
    }
}
