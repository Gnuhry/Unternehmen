using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace Unternehmen
{
    public partial class Registrieren : Form
    {
        string Bild;
        Verwaltung verwaltung;
        public Registrieren(Verwaltung verwaltung)
        {
            this.verwaltung = verwaltung;
            InitializeComponent();
            InitComboBox();
            pcBProfilbild.Image = Properties.Resources.ic_android_black_24dp;
            Logo_Picturebox.Image =  verwaltung.GetFirma().GetFirmenLogo();
            Firmen_Motto.Text = verwaltung.GetFirma().GetFirmenstatus();
            lbFehlermeldung.Text = null;
        }
       

        private void InitComboBox()
        {
            for (int f = 0; f < 31; f++)
                cBoxTag.Items.Add(f + 1);
            for (int f = DateTime.Today.Year; f > DateTime.Today.Year - 100; f--)
                cBoxJahr.Items.Add(f);
            cBoxTag.SelectedIndex = cBoxMonat.SelectedIndex = cBoxJahr.SelectedIndex = 0;
        }

        private void btnRegistrieren_Click(object sender, EventArgs e)
        {
            if (!TermsandConditionsCheckbox.Checked)
            {
                lbFehlermeldung.Text="agree terms and condition";
                return;
            }
            if (!(rbtnMan.Checked || rbtnWoman.Checked))
            {
                lbFehlermeldung.Text = "no gender";
                return;
            }
            Konto angemeldet = new Konto();
            if (txBInhaber.Text.Trim() == null || txBInhaber.Text.Trim() == "") { lbFehlermeldung.Text="Missing name"; return; }
            if (txBBenutzername.Text.Trim() == null || txBBenutzername.Text.Trim() == "") { lbFehlermeldung.Text="Missing username"; return; }
            if (txBPasswort.Text.Trim() == null || txBPasswort.Text.Trim() == "") { lbFehlermeldung.Text="Missing password"; return; }
            if (txBPasswort.Text != txBPasswort2.Text) {lbFehlermeldung.Text="passwords aren't matching"; return; }
            string temp;
            try
            {
                //MessageBox.Show(new DateTime(DateTime.Today.Year - cBoxJahr.SelectedIndex, cBoxMonat.SelectedIndex + 1, cBoxTag.SelectedIndex + 1).ToShortDateString());
                temp = angemeldet.Registrieren(txBInhaber.Text, txBBenutzername.Text, txBPasswort.Text, new DateTime(DateTime.Today.Year - cBoxJahr.SelectedIndex, cBoxMonat.SelectedIndex + 1, cBoxTag.SelectedIndex + 1), Bild, rbtnMan.Checked, verwaltung.GetFirma().GetAutoRegistrieren());
            }
            catch (Exception) { temp = "Wrong date"; }
            if (temp == "")
            {
                if (verwaltung.GetFirma().AddMitarbeiter(angemeldet))
                    Close();
                else
                    lbFehlermeldung.Text="user name is already existing";
            }
            else
                lbFehlermeldung.Text=temp;       
        }

      
        private void Registrieren_DragEnter(object sender, DragEventArgs e)
        {
            string[] validExtensions = new string[] { ".png", ".jpg" };
            foreach (var ext in ((IEnumerable<string>)e.Data.GetData(DataFormats.FileDrop)).Select((f) => System.IO.Path.GetExtension(f)))
                if (!validExtensions.Contains(ext))
                    e.Effect = DragDropEffects.None;
            e.Effect = DragDropEffects.Copy;
        }

        private void Registrieren_DragDrop(object sender, DragEventArgs e)
        {
            pcBProfilbild.Image = new Bitmap(((string[])e.Data.GetData(DataFormats.FileDrop))[0]);
            Bild = ((string[])e.Data.GetData(DataFormats.FileDrop))[0];
        }

        private void cBoxMonat_SelectedIndexChanged(object sender, EventArgs e)
        {
            int temp = cBoxTag.SelectedIndex;
            cBoxTag.Items.Clear();
            for (int f = 0; f < DateTime.DaysInMonth(DateTime.Today.Year-cBoxJahr.SelectedIndex, cBoxMonat.SelectedIndex+1); f++)
                cBoxTag.Items.Add(f + 1);
            if (temp < DateTime.DaysInMonth(DateTime.Today.Year-cBoxJahr.SelectedIndex, cBoxMonat.SelectedIndex + 1))
                cBoxTag.SelectedIndex = temp;
            else
                cBoxTag.SelectedIndex = 0;
        }

        private void Beenden_Label_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnHochladen_Click(object sender, EventArgs e)
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
                        {
                            pcBProfilbild.Image = new Bitmap(myStream);
                            Bild = openFileDialog1.FileName;
                        }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: Could not read file from disk. Original error: " + ex.Message);
                }
        }

        private void Panel_Left_MouseDown(object sender, MouseEventArgs e)
        {
            Cursor = verwaltung.Bewegen_MouseDown(e);
        }

        private void Panel_Left_MouseMove(object sender, MouseEventArgs e)
        {
            verwaltung.Bewegen_MouseMove(this);
        }

        private void Panel_Left_MouseUp(object sender, MouseEventArgs e)
        {
            Cursor = verwaltung.Bewegen_MouseUp();
        }

        private void rbtnMan_CheckedChanged(object sender, EventArgs e)
        {
            if (rbtnMan.Checked)
                rbtnWoman.Checked = false;
        }

        private void rbtnWoman_CheckedChanged(object sender, EventArgs e)
        {
            if (rbtnWoman.Checked)
                rbtnMan.Checked = false;
        }

        private void txBInhaber_OnValueChanged(object sender, EventArgs e)
        {
            Console.WriteLine("Hey");
        }

        private void txBInhaber_OnValueChanged_1(object sender, EventArgs e)
        {
            
        }

        private void txBInhaber_KeyDown(object sender, KeyEventArgs e)
        {
        }

        private void txBInhaber_KeyPress(object sender, KeyPressEventArgs e)
        {
        }

        private void txBBenutzername_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsLetter(e.KeyChar)||txBBenutzername.Text.Trim()==null)) { txBBenutzername.BackColor = Color.Red; }
        }

        private void txBBenutzername_BackColorChanged(object sender, EventArgs e)
        {
            if (txBBenutzername.BackColor == Color.Red)
            {
                txBBenutzername.OnValueChanged += TxBBenutzername_OnValueChanged;
                txBBenutzername.Font = new Font(txBBenutzername.Font, FontStyle.Bold);
            }
            else
            {
                txBBenutzername.OnValueChanged -= TxBBenutzername_OnValueChanged;
                txBBenutzername.Font = new Font(txBBenutzername.Font, FontStyle.Regular);
            }
        }

        private void TxBBenutzername_OnValueChanged(object sender, EventArgs e)
        {
            char[] temp = txBBenutzername.Text.Trim().ToCharArray();
            if (temp.Length == 0) return;
            for (int f = 0; f < temp.Length; f++)
            {
                if (!char.IsLetter(temp[f]))
                    return;
            }
            txBBenutzername.BackColor = Color.White;
        }

        private void txBPasswort_OnValueChanged(object sender, EventArgs e)
        {
            bool GrB=false, KlB=false, Zahl=false;
            char[]x = txBPasswort.Text.ToCharArray();
            for (int f = 0; f < x.Length; f++)
            {
                if (x[f] > 64 && x[f] < 91) GrB = true;
                else if (x[f] > 96 && x[f] < 122) KlB = true;
                else if (x[f] > 47 && x[f] < 58) Zahl = true;
                else
                {
                    txBPasswort.BackColor = Color.Red; return;
                }
            }
            if (!GrB) { txBPasswort.BackColor = Color.Red; return; }
            if (!KlB) { txBPasswort.BackColor = Color.Red; return; }
            if (!Zahl) { txBPasswort.BackColor = Color.Red; return; }
            txBPasswort.BackColor = Color.White;
            if (txBPasswort.BackColor == Color.Red) txBPasswort.Font = new Font(txBPasswort.Font, FontStyle.Bold);
            else txBPasswort.Font = new Font(txBPasswort.Font, FontStyle.Regular);
        }

        private void txBPasswort_BackColorChanged(object sender, EventArgs e)
        {
            if(txBPasswort.BackColor==Color.Red) txBPasswort.Font = new Font(txBPasswort.Font, FontStyle.Bold);
            else txBPasswort.Font = new Font(txBPasswort.Font, FontStyle.Regular);
        }

        private void txBPasswort2_OnValueChanged(object sender, EventArgs e)
        {
            if (txBPasswort2.Text.Trim() == null||txBPasswort2.Text!=txBPasswort.Text) { txBPasswort2.BackColor = Color.Red; txBPasswort2.Font = new Font(txBPasswort2.Font, FontStyle.Bold); }
            else { txBPasswort2.BackColor = Color.White; txBPasswort2.Font = new Font(txBPasswort2.Font, FontStyle.Regular); }
        }
    }
}
