# Pemrograman 2 (PBO) — Kumpulan Praktikum & Tugas

## Identitas

- Nama: Bagas
- NIM: 714240042
- Mata kuliah: Pemrograman 2 (PBO)

Repositori ini berisi kumpulan praktikum dan tugas mata kuliah Pemrograman 2 (PBO) menggunakan C# (.NET Framework 4.7.2). Setiap pertemuan memiliki solusi/ proyek tersendiri beserta output (screenshot) dan, pada beberapa bagian, file jawaban analisis.

## Struktur Proyek

- Pertemuan03
  - `Pratikum/P3_1_714240042` — Aplikasi konsol penentu indeks prestasi mahasiswa (grade A–E) beserta deskripsi prestasi.
  - `Tugas/P3_2_714240042` — Menu persegi panjang: hitung luas atau keliling berdasarkan input panjang dan lebar.
  - `Pratikum/Gambar` — Gambar/diagram pendukung praktikum pertemuan 3.
- Pertemuan04
  - `Praktikum/P4_1_714240042` — Demo OOP (abstraksi & pewarisan) dengan kelas `Product`, `Book`, dan `DVD` + tester.
  - `Tugas/P4_2_714240042` — Demo OOP (enkapsulasi, abstraksi, polimorfisme) dengan kelas `Meme`, `MemeLucu`, `MemeBaper`.
  - `Praktikum/answer.txt` — Jawaban/analisis singkat terkait praktikum pertemuan 4.
- Pertemuan05
  - `Pratikum/P5_1_714240042` — Aplikasi Windows Forms sederhana (tombol “Say Hello” dan “Exit”).
- Output
  - `Pertemuan04/Output/...` dan `Pertemuan05/Output/...` — Kumpulan screenshot hasil eksekusi.

> Catatan penamaan: pada beberapa folder digunakan `Pratikum` dan pada lainnya `Praktikum` (mengikuti struktur asli tugas).

## Prasyarat

- Windows + Visual Studio 2019/2022
- .NET Framework 4.7.2 Developer Pack

Semua proyek menggunakan format klasik (.csproj non-SDK) dan menargetkan .NET Framework 4.7.2, sehingga lebih nyaman dibuka lewat Visual Studio. Perintah `dotnet run` tidak disarankan untuk proyek-proyek ini.

## Cara Menjalankan

Umum (semua pertemuan):

1. Buka solusi (`.sln`) pada folder proyek yang ingin dijalankan, misalnya:
   - `Pertemuan03/Pratikum/P3_1_714240042/P3_1_714240042.sln`
   - `Pertemuan03/Tugas/P3_2_714240042/P3_2_714240042.sln`
   - `Pertemuan04/Praktikum/P4_1_714240042/P4_1_714240042.sln`
   - `Pertemuan04/Tugas/P4_2_714240042/P4_2_714240042.sln`
   - `Pertemuan05/Pratikum/P5_1_714240042/P5_1_714240042.sln`
2. Set project aktif sebagai Startup Project (jika diminta, biasanya otomatis).
3. Jalankan dengan `Start` (F5) atau `Start Without Debugging` (Ctrl+F5).

## Ringkas Fitur per Proyek

- Pertemuan 03 — Praktikum (`P3_1_714240042`)
  - Input: nama mahasiswa dan nilai (0–100).
  - Output: indeks nilai (A/B/C/D) dan deskripsi prestasi berdasar input indeks yang diminta.
- Pertemuan 03 — Tugas (`P3_2_714240042`)
  - Menu: 1) Hitung Luas, 2) Hitung Keliling, 3) Keluar.
  - Input: `panjang` dan `lebar`, hasil sesuai menu.
- Pertemuan 04 — Praktikum (`P4_1_714240042`)
  - Kelas abstrak `Product_714240042` diturunkan oleh `Book_714240042` dan `DVD_714240042`.
  - Menampilkan info produk (judul, tipe, atribut khusus seperti halaman/durasi).
- Pertemuan 04 — Tugas (`P4_2_714240042`)
  - Kelas abstrak `Meme` dengan turunan `MemeLucu` dan `MemeBaper`.
  - Menunjukkan enkapsulasi (property), abstraksi (method abstrak), dan polimorfisme (override `DisplayInfo`).
- Pertemuan 05 — Praktikum (`P5_1_714240042`)
  - Windows Forms: tombol “Say Hello” menampilkan teks “Hello World!” pada label, tombol “Exit” menutup aplikasi.

## Output (Screenshot)

Contoh hasil dan gambar pendukung dapat dilihat pada folder `Pertemuan03/Pratikum/Gambar/...`, `Pertemuan04/Output/...`, dan `Pertemuan05/Output/...`, misalnya:

- `Pertemuan03/Pratikum/Gambar/image.png`
- `Pertemuan05/Output/P5_1_714240042/Screenshot 2025-11-10 132239.png`
- `Pertemuan04/Output/Output_1_714240042/Screenshot 2025-11-03 151353.png`

## Lisensi

Proyek ini dirilis di bawah lisensi MIT. Lihat berkas `LICENSE` untuk detailnya.
