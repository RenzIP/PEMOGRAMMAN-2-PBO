using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace P6_4_714240042
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private bool IsLowercase(string text)
        {
            // hanya huruf kecil + angka
            return text.All(c => char.IsLower(c) || char.IsDigit(c));
        }

        private bool IsUppercase(string text)
        {
            // huruf besar + angka + '-'
            return text.All(c => char.IsUpper(c) || char.IsDigit(c) || c == '-');
        }

        private bool IsAlphabet(string text)
        {
            // hanya huruf
            return text.All(c => char.IsLetter(c));
        }

        private bool IsEmail(string text)
        {
            // regex email sederhana
            return Regex.IsMatch(text, @"^[^@\s]+@[^@\s]+\.[^@\s]+$");
        }

        private bool IsPlayerTag(string text)
        {
            // format: PLY-12345
            return Regex.IsMatch(text, @"^PLY-\d{3}$");
        }

        private void usnTxt_TextChanged(object sender, EventArgs e)
        {
            int pos = usnTxt.SelectionStart;
            usnTxt.Text = usnTxt.Text.ToLower();
            usnTxt.SelectionStart = pos;
        }

        private void nckTxt_TextChanged(object sender, EventArgs e)
        {
            int pos = nckTxt.SelectionStart;
            string onlyLetter = new string(nckTxt.Text.Where(char.IsLetter).ToArray());
            nckTxt.Text = onlyLetter;
            nckTxt.SelectionStart = pos;
        }

        private void emlTxt_TextChanged(object sender, EventArgs e)
        {

        }

        private void ageTxt_TextChanged(object sender, EventArgs e)
        {
            int pos = ageTxt.SelectionStart;
            string onlyDigit = new string(ageTxt.Text.Where(char.IsDigit).ToArray());
            ageTxt.Text = onlyDigit;
            ageTxt.SelectionStart = pos;
        }

        private void pswdTxt_TextChanged(object sender, EventArgs e)
        {

        }

        private void cpswdTxt_TextChanged(object sender, EventArgs e)
        {

        }

        private void ptagTxt_TextChanged(object sender, EventArgs e)
        {
            int pos = ptagTxt.SelectionStart;
            ptagTxt.Text = ptagTxt.Text.ToUpper();
            ptagTxt.SelectionStart = pos;
        }

        private void btnShow_Click(object sender, EventArgs e)
        {
            errorProvider1.Clear();
            bool valid = true;

            // USERNAME (required + lowercase + length)
            if (string.IsNullOrWhiteSpace(usnTxt.Text))
            {
                errorProvider1.SetError(usnTxt, "Username wajib diisi");
                valid = false;
            }
            else if (usnTxt.Text.Length < 4 || usnTxt.Text.Length > 12)
            {
                errorProvider1.SetError(usnTxt, "Username 4 - 12 karakter");
                valid = false;
            }
            else if (!IsLowercase(usnTxt.Text))
            {
                errorProvider1.SetError(usnTxt, "Username harus huruf kecil dan angka saja");
                valid = false;
            }

            // NICKNAME (char textbox + required)
            if (string.IsNullOrWhiteSpace(nckTxt.Text))
            {
                errorProvider1.SetError(nckTxt, "Nickname wajib diisi");
                valid = false;
            }
            else if (!IsAlphabet(nckTxt.Text))
            {
                errorProvider1.SetError(nckTxt, "Nickname hanya boleh huruf");
                valid = false;
            }

            // EMAIL (required + regex)
            if (string.IsNullOrWhiteSpace(emlTxt.Text))
            {
                errorProvider1.SetError(emlTxt, "Email wajib diisi");
                valid = false;
            }
            else if (!IsEmail(emlTxt.Text))
            {
                errorProvider1.SetError(emlTxt, "Format email tidak valid");
                valid = false;
            }

            // AGE (numeric textbox + comparison)
            if (string.IsNullOrWhiteSpace(ageTxt.Text))
            {
                errorProvider1.SetError(ageTxt, "Age wajib diisi");
                valid = false;
            }
            else if (!int.TryParse(ageTxt.Text, out int age))
            {
                errorProvider1.SetError(ageTxt, "Age harus angka");
                valid = false;
            }
            else if (age < 12)
            {
                errorProvider1.SetError(ageTxt, "Minimal age 12 tahun");
                valid = false;
            }

            // PASSWORD (required + length validator)
            if (string.IsNullOrWhiteSpace(pswdTxt.Text))
            {
                errorProvider1.SetError(pswdTxt, "Password wajib diisi");
                valid = false;
            }
            else if (pswdTxt.Text.Length < 8)
            {
                errorProvider1.SetError(pswdTxt, "Password minimal 8 karakter");
                valid = false;
            }

            // CONFIRM PASSWORD (comparison)
            if (pswdTxt.Text != cpswdTxt.Text)
            {
                errorProvider1.SetError(cpswdTxt, "Konfirmasi password tidak sama");
                valid = false;
            }

            // PLAYER TAG (uppercase textbox + regex + required)
            if (string.IsNullOrWhiteSpace(ptagTxt.Text))
            {
                errorProvider1.SetError(ptagTxt, "Player Tag wajib diisi");
                valid = false;
            }
            else if (!IsUppercase(ptagTxt.Text))
            {
                errorProvider1.SetError(ptagTxt, "Player Tag harus huruf BESAR");
                valid = false;
            }
            else if (!IsPlayerTag(ptagTxt.Text))
            {
                errorProvider1.SetError(ptagTxt, "Format harus PLY-123");
                valid = false;
            }

            if (!valid) return;   // kalau masih ada error, jangan tampilkan message box

            // ========= MESSAGE BOX (seperti contoh tugas) =========
            string info =
                "Username        : " + usnTxt.Text + Environment.NewLine +
                "Nickname        : " + nckTxt.Text + Environment.NewLine +
                "Email           : " + emlTxt.Text + Environment.NewLine +
                "Age             : " + ageTxt.Text + Environment.NewLine +
                "Player Tag      : " + ptagTxt.Text;

            MessageBox.Show(
                info,
                "Informasi Pendaftaran Akun Game",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information
            );
        }

        private void btnQuit_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
