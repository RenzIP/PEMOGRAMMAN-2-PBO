using P9_714240042.controller;
using P9_714240042.lib;
using System;
using System.Data;
using System.Windows.Forms;

namespace P9_714240042.view
{
    public partial class FormTransaksiBarang : Form
    {
        private Transaksi transaksiController = new Transaksi();
        private Barang barangController = new Barang();
        private int selectedTransaksiId = 0;
        private int selectedBarangId = 0;
        private int hargaBarang = 0;

        public FormTransaksiBarang()
        {
            InitializeComponent();
        }

        private void FormTransaksiBarang_Load(object sender, EventArgs e)
        {
            LoadComboBarang();
            Tampil();
        }

        private void LoadComboBarang()
        {
            DataTable dt = barangController.GetComboBarang();
            groupBoxIdBarang.DataSource = dt;
            groupBoxIdBarang.DisplayMember = "id_barang";
            groupBoxIdBarang.ValueMember = "id_barang";
            groupBoxIdBarang.SelectedIndex = -1;
        }

        private void Tampil()
        {
            DataBarang.DataSource = transaksiController.GetAll();
        }

        private void ResetForm()
        {
            groupBoxIdBarang.SelectedIndex = -1;
            textBoxNamaBarang.Text = "";
            textBoxHargaBarang.Text = "";
            textBox1.Text = ""; // Quantity
            textBox2.Text = ""; // Total
            selectedTransaksiId = 0;
            selectedBarangId = 0;
            hargaBarang = 0;
        }

        private void groupBoxIdBarang_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (groupBoxIdBarang.SelectedIndex >= 0 && groupBoxIdBarang.SelectedValue != null)
            {
                int idBarang;
                if (int.TryParse(groupBoxIdBarang.SelectedValue.ToString(), out idBarang))
                {
                    selectedBarangId = idBarang;
                    DataRow row = barangController.GetBarangById(idBarang);
                    if (row != null)
                    {
                        textBoxNamaBarang.Text = row["nama_barang"].ToString();
                        hargaBarang = Convert.ToInt32(row["harga"]);
                        textBoxHargaBarang.Text = hargaBarang.ToString();
                        HitungTotal();
                    }
                }
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            HitungTotal();
        }

        private void HitungTotal()
        {
            int qty;
            if (int.TryParse(textBox1.Text, out qty) && hargaBarang > 0)
            {
                int total = qty * hargaBarang;
                textBox2.Text = total.ToString();
            }
            else
            {
                textBox2.Text = "";
            }
        }

        private void btnSimpan_Click(object sender, EventArgs e)
        {
            if (selectedBarangId == 0 || string.IsNullOrWhiteSpace(textBox1.Text))
            {
                MessageBox.Show("Pilih barang dan isi quantity!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int qty;
            if (!int.TryParse(textBox1.Text, out qty) || qty <= 0)
            {
                MessageBox.Show("Quantity harus berupa angka positif!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int total = qty * hargaBarang;

            try
            {
                transaksiController.Insert(selectedBarangId, qty, total);
                MessageBox.Show("Transaksi berhasil disimpan!", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Tampil();
                ResetForm();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Gagal Simpan", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnUbah_Click(object sender, EventArgs e)
        {
            if (selectedTransaksiId == 0)
            {
                MessageBox.Show("Pilih transaksi yang akan diubah!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (selectedBarangId == 0 || string.IsNullOrWhiteSpace(textBox1.Text))
            {
                MessageBox.Show("Pilih barang dan isi quantity!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int qty;
            if (!int.TryParse(textBox1.Text, out qty) || qty <= 0)
            {
                MessageBox.Show("Quantity harus berupa angka positif!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int total = qty * hargaBarang;

            try
            {
                transaksiController.Update(selectedTransaksiId, selectedBarangId, qty, total);
                MessageBox.Show("Transaksi berhasil diubah!", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
            if (selectedTransaksiId == 0)
            {
                MessageBox.Show("Pilih transaksi yang akan dihapus!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DialogResult result = MessageBox.Show("Apakah yakin akan menghapus transaksi ini?", "Konfirmasi", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                try
                {
                    transaksiController.Delete(selectedTransaksiId);
                    MessageBox.Show("Transaksi berhasil dihapus!", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
            LoadComboBarang();
            Tampil();
            ResetForm();
        }

        private void DataBarang_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = DataBarang.Rows[e.RowIndex];
                selectedTransaksiId = Convert.ToInt32(row.Cells[0].Value);
                int idBarang = Convert.ToInt32(row.Cells[1].Value);
                
                // Set combo to selected barang
                groupBoxIdBarang.SelectedValue = idBarang;
                
                textBox1.Text = row.Cells[4].Value.ToString(); // Qty
                textBox2.Text = row.Cells[5].Value.ToString(); // Total
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
                DataBarang.DataSource = transaksiController.Search(textBoxCariData.Text);
            }
        }

        private void checkBoxKategori_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void label3_Click(object sender, EventArgs e)
        {
        }

        private void btnExport_Click(object sender, EventArgs e)
        {
            // Mengecek apakah ada data yang bisa di-export
            if (DataBarang.Rows.Count == 0)
            {
                MessageBox.Show("Tidak ada data untuk di-export!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Membuat SaveFileDialog untuk memilih lokasi penyimpanan file Excel
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "Excel Files|*.xlsx";
            saveFileDialog.Title = "Export Data Transaksi Barang";
            saveFileDialog.FileName = "Data_Transaksi_Barang_" + DateTime.Now.ToString("yyyyMMdd_HHmmss");

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    // Memanggil method ExportToExcel dari class Excel
                    Excel excel = new Excel();
                    excel.ExportToExcel(DataBarang, saveFileDialog.FileName);

                    MessageBox.Show("Data berhasil di-export ke Excel!", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Gagal export data: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
