using P9_714240042.controller;
using System;
using System.Data;
using System.Windows.Forms;

namespace P9_714240042.view
{
    public partial class FormDataMasterBarang : Form
    {
        private Barang barangController = new Barang();
        private int selectedId = 0;

        public FormDataMasterBarang()
        {
            InitializeComponent();
        }

        private void FormDataMasterBarang_Load(object sender, EventArgs e)
        {
            Tampil();
        }

        private void Tampil()
        {
            DataBarang.DataSource = barangController.GetAll();
        }

        private void ResetForm()
        {
            textBoxNamaBarang.Text = "";
            textBoxHarga.Text = "";
            selectedId = 0;
        }

        private void btnSimpan_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBoxNamaBarang.Text) || string.IsNullOrWhiteSpace(textBoxHarga.Text))
            {
                MessageBox.Show("Data tidak boleh kosong!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int harga;
            if (!int.TryParse(textBoxHarga.Text, out harga))
            {
                MessageBox.Show("Harga harus berupa angka!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                barangController.Insert(textBoxNamaBarang.Text, harga);
                MessageBox.Show("Data berhasil ditambahkan!", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Tampil();
                ResetForm();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Gagal Insert", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnUbah_Click(object sender, EventArgs e)
        {
            if (selectedId == 0)
            {
                MessageBox.Show("Pilih data yang akan diubah!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (string.IsNullOrWhiteSpace(textBoxNamaBarang.Text) || string.IsNullOrWhiteSpace(textBoxHarga.Text))
            {
                MessageBox.Show("Data tidak boleh kosong!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int harga;
            if (!int.TryParse(textBoxHarga.Text, out harga))
            {
                MessageBox.Show("Harga harus berupa angka!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                barangController.Update(selectedId, textBoxNamaBarang.Text, harga);
                MessageBox.Show("Data berhasil diubah!", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Tampil();
                ResetForm();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Gagal Update", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnHapus_Click(object sender, EventArgs e)
        {
            if (selectedId == 0)
            {
                MessageBox.Show("Pilih data yang akan dihapus!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DialogResult result = MessageBox.Show("Apakah yakin akan menghapus data ini?", "Konfirmasi", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                try
                {
                    barangController.Delete(selectedId);
                    MessageBox.Show("Data berhasil dihapus!", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Tampil();
                    ResetForm();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Gagal Hapus", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            Tampil();
            ResetForm();
        }

        private void DataBarang_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = DataBarang.Rows[e.RowIndex];
                selectedId = Convert.ToInt32(row.Cells[0].Value);
                textBoxNamaBarang.Text = row.Cells[1].Value.ToString();
                textBoxHarga.Text = row.Cells[2].Value.ToString();
            }
        }

        private void textBoxCariData_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBoxCariData.Text))
            {
                Tampil();
            }
            else
            {
                DataBarang.DataSource = barangController.Search(textBoxCariData.Text);
            }
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {
        }
    }
}
