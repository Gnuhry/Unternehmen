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
        List<NachrichtAnzeige> nachrichtAnzeiges;
        bool Chef;
        public Messenger(Verwaltung verwaltung, bool Chef)
        {
            this.Chef = Chef;
            nachrichtAnzeiges = new List<NachrichtAnzeige>();
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
                    for (int f = 0; f < verwaltung.GetFirma().GetMitarbeiterAnzahl(); f++)
                        if (verwaltung.GetFirma().GetMitarbeiter(f) == verwaltung.GetAngemeldetePerson().GetSender(lBoxNachrichten.IndexFromPoint(e.Location)))
                            comBEmpfanger.SelectedIndex = f;
        }

        private void LBoxNachrichten_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (lBoxNachrichten.IndexFromPoint(e.Location) != ListBox.NoMatches)
            {
                nachrichtAnzeiges.Add(new NachrichtAnzeige(lBoxNachrichten.IndexFromPoint(e.Location), verwaltung,Chef));
                nachrichtAnzeiges[nachrichtAnzeiges.Count - 1].Show();
                nachrichtAnzeiges[nachrichtAnzeiges.Count - 1].FormClosing += NachrichtAnzeiges_FormClosing;

            }
        }

        private void NachrichtAnzeiges_FormClosing(object sender, FormClosingEventArgs e)
        {
            lBoxNachrichten.Items.Clear();
            NachrichtenLaden();
        }

        private void btnSenden_Click(object sender, EventArgs e)
        {

            txBNachricht.Text = txBNachricht.Text.Trim();
            if(txBNachricht.Text != "" && txBNachricht.Text != null && comBEmpfanger.SelectedIndex == 0)
            {
                verwaltung.GetFirma().ReciveAdminNachricht(txBNachricht.Text, pcBAnhang.Image, verwaltung.GetAngemeldetePerson());
                txBNachricht.Text = null;
            }
            else if (txBNachricht.Text != "" && txBNachricht.Text != null && comBEmpfanger.SelectedIndex > -1)
            {
                verwaltung.GetFirma().GetMitarbeiter(comBEmpfanger.SelectedIndex+1).ReciveNachricht(txBNachricht.Text, pcBAnhang.Image, verwaltung.GetAngemeldetePerson());
                txBNachricht.Text = null;
            }
        }

        private void Messenger_FormClosing(object sender, FormClosingEventArgs e)
        {
            for (int f = 0; f < nachrichtAnzeiges.Count; f++) nachrichtAnzeiges[f].Close();
        }

        private void btnBildHochladen_Click(object sender, EventArgs e)
        {
            Stream myStream = null;
            OpenFileDialog openFileDialog1 = new OpenFileDialog
            {
                InitialDirectory = "c:\\",
                Filter = "Image Files(*.BMP;*.JPG;*.GIF;*.PNG)|*.BMP;*.JPG;*.GIF;*.PNG",
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
    }
}
