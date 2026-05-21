# 🩸 Sistem Informasi Manajemen Donor Darah (SIMDD)

Sistem Informasi Manajemen Donor Darah (SIMDD) adalah aplikasi desktop berbasis **Windows Forms (WinForms)** yang dibangun menggunakan **Visual Studio (VB.NET)** dan diintegrasikan dengan basis data relasional **MySQL (XAMPP)**. 

Aplikasi ini mengimplementasikan arsitektur *Role-Based Access Control* (RBAC) yang memisahkan hak akses antara **Admin** (kontrol penuh, verifikasi CRUD, dan pemantauan stok) serta **User/Pendonor** (pendaftaran, pengisian form donasi minimalis *Auto-Fill*, dan pencetakan kuitansi mandiri).

---

## 👥 Anggota Kelompok (Informatics B - Batch 2026)

Berikut adalah anggota kelompok pengembang sistem:

* **Devon Falen Pasae** (NIM. 2409106055)
* **Anindtya Puji Astari** (NIM. 2409106063)
* **Andi Nurfadillah Hasan** (NIM. 2409106087)
* **Fachlevi Muhammad** (NIM. 2409106059) 

---

## 🔐 Kredensial Akun Pengujian (Login Session)

Untuk memudahkan dosen atau asisten praktikum saat melakukan pengujian sistem, berikut adalah akun bawaan (*default*) yang telah disediakan di dalam database:

### 🛠️ Akun Dashboard Admin
* **Username:** `admin`
* **Password:** `admin123`
* **Hak Akses:** Kontrol CRUD Global, Verifikasi/Approval Donasi, Monitoring Log Sirkulasi, dan *Low Stock Alert*.

### 👤 Akun Dashboard User / Pendonor
* **Username:** `user1`
* **Password:** `user123`
* **Hak Akses:** Riwayat Donasi Pribadi, Form Pengajuan Donasi, dan Cetak Kuitansi Resmi.

---

## 🚀 Fitur Utama Sistem

1.  **Multi-Role Authentication:** Pemisahan dashboard dinamis berdasarkan peran akun saat login.
2.  **Auto-Fill Framework:** Pengisian form donasi secara otomatis menarik profil akun aktif untuk efisiensi input.
3.  **Automated Stock Trigger:** Verifikasi donasi oleh admin secara otomatis menambah kuantitas tabel `stok_darah` dan mencatatnya pada `log_sirkulasi_darah`.
4.  **Low Stock Alert:** Sistem peringatan dini visual di dashboard admin jika stok golongan darah tertentu berada di bawah batas minimum (10 kantung).
5.  **Anonymous Donor Option:** Fitur penyamaran nama pendonor menjadi *"Hamba Allah / Anonim"* pada lembar cetak kuitansi.
6.  **Native Document Printing:** Implementasi komponen `PrintDocument` untuk mencetak kuitansi dan lembar hasil konsultasi secara langsung.

---

## 🔄 Pembaruan & Fitur Hasil Revisi Sistem (Pasca-Konsultasi)

Berdasarkan hasil evaluasi dan konsultasi, alur sistem telah dirombak total menjadi lebih efisien dan aman:
1. **Single Registration & Auto-Fill Framework:** Proses registrasi kini langsung terhubung sebagai form data pendonor dasar. Saat user login dan membuka form donasi, sistem secara otomatis menarik data profil dari *session* aktif secara *Read-Only*. User tidak perlu mengisi ulang nama/email, melainkan cukup menginput **Jumlah Donasi** dan opsi checkbox.
2. **Form Donasi Minimalis:** Form pendonor kini digabung langsung dengan form donasi demi menyederhanakan *User Experience*.
3. **Pusat Kontrol di Admin (Anti-Anomali):** Hak akses CRUD (Tambah, Edit, Hapus) sepenuhnya dipindahkan ke Admin. User biasa dikunci total dan tidak dapat memanipulasi data master/orang lain untuk menghindari manipulasi data stok darah global.
4. **Halaman Monitoring Dual-View:** Halaman monitoring bertindak sebagai pusat informasi bersama. User hanya dapat melihat riwayat donasi pribadinya sendiri, sedangkan Admin dapat memantau, memverifikasi seluruh data yang masuk, serta menginput hasil konsultasi medis.

---

## 🧠 Fitur Pintar & Logika Bisnis Lanjutan (Advanced Features)

Sistem ini dirancang dengan logika backend yang "pintar" di luar fungsi CRUD standar untuk memastikan kelayakan nilai tinggi:

* **Approval Workflow:** Stok darah global **tidak akan bertambah** saat user mengirim (*submit*) data donasi (status default: `Pending`). Kuantitas stok hanya akan bertambah secara otomatis setelah Admin melakukan verifikasi (`Terverifikasi`).
* **Sistem Peringatan Dini (Low Stock Alert):** Dashboard Admin dilengkapi fitur pengecekan otomatis yang akan memicu indikator peringatan/pop-up jika kuantitas stok darah golongan tertentu (A/B/AB/O) turun di bawah ambang batas minimum (**10 kantung**).
* **Audit Trail (Log Sirkulasi Darah):** Penambahan tabel khusus `log_sirkulasi_darah` yang merekam setiap aksi masuk (dari donasi disetujui) dan keluar (distribusi) secara otomatis untuk transparansi data jika terjadi selisih stok.
* **Manajemen Konsultasi Terintegrasi:** Admin dapat menginput catatan medis hasil konsultasi serta jadwal donor kembali, yang datanya otomatis tersinkronisasi ke monitoring user untuk dicetak.
* **Validasi Input User-Friendly:** Menggunakan komponen `ErrorProvider` untuk mendeteksi *field* kosong/format email secara *real-time*, serta penanganan event `KeyPress` untuk membatasi input jumlah donasi hanya menerima karakter numerik (angka).
* **Pencegahan Orphan Data:** Penerapan referensial *Integrity Constraints* (`CASCADE/RESTRICT`) pada relasi *Foreign Key* di database MySQL agar tidak ada data transaksi yang kehilangan relasi induk saat data user dikelola.

---

## 🛠️ Prasyarat & Lingkungan Pengembangan

* **IDE:** Visual Studio 2022-2026 (atau versi kompatibel yang mendukung .NET Framework / .NET Desktop Development).
* **DBMS:** MySQL Server via XAMPP Control Panel (port 3306/3307).
* **Driver Konektor:** `MySql.Data.MySqlClient` atau `MySqlConnector` terpasang pada *References* proyek.

---

## 💡 Pemberitahuan Penting untuk Anggota Tim (Git Workflow)

> ⚠️ **PENTING SEBELUM CODING:** > Untuk mencegah terjadinya *Merge Conflict* atau penimpaan kode yang merusak sistem, **WAJIB** menjalankan perintah `git pull origin main` di terminal/CMD masing-masing sebelum mulai menulis kode baru. Pastikan database lokal di XAMPP kalian sudah tersinkronisasi dengan file kueri SQL terbaru yang ada di repositori ini.

---

## 🔥 Kalimat Penyemangat

> *"Koding itu seperti mendonorkan darah: setiap baris logika yang kita ketik dengan teliti hari ini mungkin akan menyelamatkan nilai praktikum kelompok kita di akhir semester nanti! Tetap semangat, jaga komunikasi, dan mari kita selesaikan Project Akhir Pemrograman Visual ini dengan hasil terbaik! B 2024, Menyala! 🚀"*
