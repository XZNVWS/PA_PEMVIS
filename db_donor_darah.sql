-- phpMyAdmin SQL Dump
-- version 5.2.1
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Generation Time: May 19, 2026 at 04:07 PM
-- Server version: 10.4.32-MariaDB
-- PHP Version: 8.2.12

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `db_donor_darah`
--

-- --------------------------------------------------------

--
-- Table structure for table `donasi`
--

CREATE TABLE `donasi` (
  `id_donasi` int(11) NOT NULL,
  `id_user` int(11) NOT NULL,
  `jumlah_donasi` int(11) NOT NULL,
  `tanggal_donasi` date NOT NULL,
  `is_anonim` tinyint(1) DEFAULT 0,
  `status_verifikasi` enum('Pending','Terverifikasi','Ditolak') NOT NULL DEFAULT 'Pending',
  `hasil_konsultasi` text DEFAULT NULL,
  `jadwal_kembali` date DEFAULT NULL,
  `created_at` timestamp NOT NULL DEFAULT current_timestamp()
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_unicode_ci;

--
-- Dumping data for table `donasi`
--

INSERT INTO `donasi` (`id_donasi`, `id_user`, `jumlah_donasi`, `tanggal_donasi`, `is_anonim`, `status_verifikasi`, `hasil_konsultasi`, `jadwal_kembali`, `created_at`) VALUES
(1, 2, 2, '2026-05-10', 0, 'Terverifikasi', 'Kondisi stabil, hemoglobin normal.', '2026-07-15', '2026-05-19 08:34:31'),
(2, 3, 1, '2026-05-15', 1, 'Pending', NULL, NULL, '2026-05-19 08:34:31'),
(3, 4, 3, '2026-05-16', 0, 'Pending', NULL, NULL, '2026-05-19 08:34:31'),
(4, 5, 2, '2026-05-17', 0, 'Ditolak', 'Tekanan darah terlalu tinggi.', NULL, '2026-05-19 08:34:31'),
(5, 6, 2, '2026-05-18', 0, 'Pending', NULL, NULL, '2026-05-19 08:46:11'),
(6, 7, 1, '2026-05-18', 1, 'Pending', NULL, NULL, '2026-05-19 08:46:11'),
(7, 2, 2, '2026-05-15', 0, 'Terverifikasi', 'Kondisi sangat baik, siap donor kembali 8 minggu lagi.', '2026-07-10', '2026-05-19 08:46:11'),
(8, 4, 1, '2026-05-16', 0, 'Terverifikasi', 'Donor pertama kali, tidak ada keluhan.', '2026-07-11', '2026-05-19 08:46:11'),
(9, 5, 3, '2026-05-17', 0, 'Ditolak', 'Kadar hemoglobin terlalu rendah (Anemia).', NULL, '2026-05-19 08:46:11'),
(10, 8, 5, '2026-05-19', 0, 'Terverifikasi', NULL, NULL, '2026-05-19 09:29:21');

-- --------------------------------------------------------

--
-- Table structure for table `log_sirkulasi_darah`
--

CREATE TABLE `log_sirkulasi_darah` (
  `id_log` int(11) NOT NULL,
  `golongan_darah` varchar(5) NOT NULL,
  `jenis_aksi` enum('Masuk','Keluar') NOT NULL,
  `jumlah` int(11) NOT NULL,
  `keterangan` text DEFAULT NULL,
  `created_at` timestamp NOT NULL DEFAULT current_timestamp()
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_unicode_ci;

--
-- Dumping data for table `log_sirkulasi_darah`
--

INSERT INTO `log_sirkulasi_darah` (`id_log`, `golongan_darah`, `jenis_aksi`, `jumlah`, `keterangan`, `created_at`) VALUES
(1, 'A', 'Masuk', 2, 'Verifikasi donasi Budi Santoso (ID #1)', '2026-05-19 08:34:31'),
(2, 'B', 'Masuk', 5, 'Stok awal', '2026-05-19 08:34:31'),
(3, 'AB', 'Masuk', 10, 'Stok awal', '2026-05-19 08:34:31'),
(4, 'O', 'Masuk', 3, 'Stok awal', '2026-05-19 08:34:31'),
(5, 'AB', 'Keluar', 2, 'Distribusi ke RS Umum Daerah', '2026-05-19 08:34:31'),
(6, 'A', 'Masuk', 5, 'Donasi ID #10 terverifikasi oleh Admin', '2026-05-19 09:30:35');

-- --------------------------------------------------------

--
-- Table structure for table `stok_darah`
--

CREATE TABLE `stok_darah` (
  `golongan_darah` varchar(5) NOT NULL,
  `total_stok` int(11) NOT NULL DEFAULT 0,
  `updated_at` timestamp NOT NULL DEFAULT current_timestamp() ON UPDATE current_timestamp()
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_unicode_ci;

--
-- Dumping data for table `stok_darah`
--

INSERT INTO `stok_darah` (`golongan_darah`, `total_stok`, `updated_at`) VALUES
('A', 9, '2026-05-19 09:30:35'),
('AB', 11, '2026-05-19 08:46:11'),
('B', 5, '2026-05-19 08:34:31'),
('O', 3, '2026-05-19 08:34:31');

-- --------------------------------------------------------

--
-- Table structure for table `users`
--

CREATE TABLE `users` (
  `id_user` int(11) NOT NULL,
  `username` varchar(50) NOT NULL,
  `password` varchar(255) NOT NULL,
  `nama_lengkap` varchar(100) NOT NULL,
  `email` varchar(100) NOT NULL,
  `golongan_darah` varchar(5) NOT NULL,
  `no_telepon` varchar(15) NOT NULL,
  `role` enum('Admin','User') NOT NULL DEFAULT 'User',
  `created_at` timestamp NOT NULL DEFAULT current_timestamp()
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_unicode_ci;

--
-- Dumping data for table `users`
--

INSERT INTO `users` (`id_user`, `username`, `password`, `nama_lengkap`, `email`, `golongan_darah`, `no_telepon`, `role`, `created_at`) VALUES
(1, 'admin', 'admin123', 'Administrator', 'admin@donor.com', 'O', '081234567890', 'Admin', '2026-05-19 08:14:23'),
(2, 'user1', 'user123', 'Budi Santoso', 'budi@email.com', 'A', '081298765432', 'User', '2026-05-19 08:14:23'),
(3, 'siti_darah', 'siti123', 'Siti Aminah', 'siti@email.com', 'B', '085711223344', 'User', '2026-05-19 08:34:31'),
(4, 'bambang_donor', 'joko123', 'Bambang Pamungkas', 'joko@email.com', 'AB', '081399887766', 'User', '2026-05-19 08:34:31'),
(5, 'ari_o', 'ari123', 'Ari Lasso', 'ari@email.com', 'O', '089912345678', 'User', '2026-05-19 08:34:31'),
(6, 'andi_donor', 'andi123', 'Andi Wijaya', 'andi@email.com', 'O', '081211112222', 'User', '2026-05-19 08:46:11'),
(7, 'bunga_darah', 'bunga123', 'Bunga Lestari', 'bunga@email.com', 'AB', '081233334444', 'User', '2026-05-19 08:46:11'),
(8, 'dina_na', 'dina123', 'Dina Diana', 'dina@email.com', 'A', '082122553766', 'User', '2026-05-19 09:27:51');

--
-- Indexes for dumped tables
--

--
-- Indexes for table `donasi`
--
ALTER TABLE `donasi`
  ADD PRIMARY KEY (`id_donasi`),
  ADD KEY `fk_donasi_user` (`id_user`);

--
-- Indexes for table `log_sirkulasi_darah`
--
ALTER TABLE `log_sirkulasi_darah`
  ADD PRIMARY KEY (`id_log`);

--
-- Indexes for table `stok_darah`
--
ALTER TABLE `stok_darah`
  ADD PRIMARY KEY (`golongan_darah`);

--
-- Indexes for table `users`
--
ALTER TABLE `users`
  ADD PRIMARY KEY (`id_user`),
  ADD UNIQUE KEY `username` (`username`);

--
-- AUTO_INCREMENT for dumped tables
--

--
-- AUTO_INCREMENT for table `donasi`
--
ALTER TABLE `donasi`
  MODIFY `id_donasi` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=11;

--
-- AUTO_INCREMENT for table `log_sirkulasi_darah`
--
ALTER TABLE `log_sirkulasi_darah`
  MODIFY `id_log` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=7;

--
-- AUTO_INCREMENT for table `users`
--
ALTER TABLE `users`
  MODIFY `id_user` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=9;

--
-- Constraints for dumped tables
--

--
-- Constraints for table `donasi`
--
ALTER TABLE `donasi`
  ADD CONSTRAINT `fk_donasi_user` FOREIGN KEY (`id_user`) REFERENCES `users` (`id_user`) ON DELETE CASCADE ON UPDATE CASCADE;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
