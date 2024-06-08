-- phpMyAdmin SQL Dump
-- version 5.2.1
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1:3306
-- Generation Time: May 19, 2024 at 03:06 PM
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
-- Database: `kostify`
--

-- --------------------------------------------------------

--
-- Table structure for table `detailtagihan`
--

CREATE TABLE `detailtagihan` (
  `ID_Detail` int(50) NOT NULL,
  `ID_Tagihan` int(50) NOT NULL,
  `TglBayar` date NOT NULL,
  `Bayar` int(100) NOT NULL,
  `SisaBayar` int(100) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `detailtagihan`
--

INSERT INTO `detailtagihan` (`ID_Detail`, `ID_Tagihan`, `TglBayar`, `Bayar`, `SisaBayar`) VALUES
(3, 14, '2024-05-19', 200000, 0),
(9, 16, '2024-05-19', 200000, 50000),
(10, 16, '2024-05-19', 50000, 0);

-- --------------------------------------------------------

--
-- Table structure for table `fasilitas`
--

CREATE TABLE `fasilitas` (
  `ID_Fasilitas` int(11) NOT NULL,
  `Nama_Fasilitas` varchar(50) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `fasilitas`
--

INSERT INTO `fasilitas` (`ID_Fasilitas`, `Nama_Fasilitas`) VALUES
(1, 'Kamar Mandi Dalam'),
(2, 'AC'),
(3, 'Jaringan Internet'),
(4, 'Dapur Bersama'),
(5, 'Fasilitas Keamanan'),
(6, 'Parkir Kendaraan'),
(7, 'Fasilitas Olahraga'),
(8, 'Fasilitas Rooftop');

-- --------------------------------------------------------

--
-- Table structure for table `fasilitaskamarkost`
--

CREATE TABLE `fasilitaskamarkost` (
  `ID_Kamar` varchar(5) NOT NULL,
  `ID_Fasilitas` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `fasilitaskamarkost`
--

INSERT INTO `fasilitaskamarkost` (`ID_Kamar`, `ID_Fasilitas`) VALUES
('A11', 3),
('A11', 4),
('A11', 5),
('A11', 6),
('A11', 7),
('A11', 8),
('A21', 3),
('A21', 4),
('A21', 5),
('A21', 6),
('A21', 7),
('A21', 8),
('B12', 1),
('B12', 2),
('B12', 3),
('B12', 4),
('B12', 5),
('B12', 6),
('B12', 7),
('B12', 8),
('B22', 8),
('A341', 1),
('A341', 2),
('A341', 4),
('B31', 2),
('B31', 3),
('C324', 1),
('C324', 2),
('C324', 5),
('c675', 1),
('c675', 2),
('c675', 3),
('c675', 4),
('AS123', 6),
('AS123', 7),
('AS123', 8),
('A12', 3),
('A12', 4),
('A12', 5),
('A12', 6),
('A12', 7),
('B22', 1),
('B22', 2),
('B22', 3),
('B22', 4),
('B22', 5),
('B22', 6),
('B22', 7),
('B22', 8),
('B21', 1),
('B21', 2),
('B21', 3),
('B21', 4),
('B21', 5),
('B11', 1),
('B11', 2),
('B11', 3),
('Z12', 1),
('Z12', 7),
('A34', 1),
('A34', 2),
('A34', 3),
('A14', 1),
('A14', 2),
('A14', 3),
('A14', 4),
('C11', 1),
('C11', 2),
('C11', 3);

-- --------------------------------------------------------

--
-- Table structure for table `kamarkost`
--

CREATE TABLE `kamarkost` (
  `ID_Kamar` varchar(5) NOT NULL,
  `Lantai` int(2) NOT NULL,
  `UkuranKamar` text NOT NULL,
  `Harga` int(50) NOT NULL,
  `Status` tinyint(1) NOT NULL,
  `fasilitas` varchar(50) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `kamarkost`
--

INSERT INTO `kamarkost` (`ID_Kamar`, `Lantai`, `UkuranKamar`, `Harga`, `Status`, `fasilitas`) VALUES
('A11', 1, '4x5 m', 850000, 1, ''),
('A14', 1, '3x4 m', 900000, 0, ''),
('A34', 3, '4x3 m', 1200000, 1, ''),
('B11', 1, '6x6 m', 1250000, 1, ''),
('B21', 2, '6x6 m', 1250000, 0, ''),
('C11', 2, '6x6 m', 1250000, 1, '');

-- --------------------------------------------------------

--
-- Table structure for table `penghunikost`
--

CREATE TABLE `penghunikost` (
  `ID_Penghuni` int(50) NOT NULL,
  `ID_Kamar` varchar(5) NOT NULL,
  `TglMasuk` date DEFAULT NULL,
  `TglKeluar` date DEFAULT NULL,
  `NoTelp` int(20) NOT NULL,
  `NamaPenghuni` varchar(50) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `penghunikost`
--

INSERT INTO `penghunikost` (`ID_Penghuni`, `ID_Kamar`, `TglMasuk`, `TglKeluar`, `NoTelp`, `NamaPenghuni`) VALUES
(1, 'A11', '2024-03-21', '2024-04-21', 8213555, 'Fidef'),
(8, 'B11', '2024-04-04', '2024-05-11', 98367475, 'evan'),
(18, 'C11', '2024-04-16', '2024-05-16', 123456789, 'Bagas'),
(19, 'A34', '2024-05-19', '2024-05-25', 2147483647, 'justine');

-- --------------------------------------------------------

--
-- Table structure for table `tagihan`
--

CREATE TABLE `tagihan` (
  `ID_Tagihan` int(50) NOT NULL,
  `ID_Penghuni` int(50) NOT NULL,
  `ID_Kamar` varchar(5) NOT NULL,
  `Harga` int(50) NOT NULL,
  `tglBayar` date DEFAULT NULL,
  `Biaya` int(50) NOT NULL,
  `Keterangan` text NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `tagihan`
--

INSERT INTO `tagihan` (`ID_Tagihan`, `ID_Penghuni`, `ID_Kamar`, `Harga`, `tglBayar`, `Biaya`, `Keterangan`) VALUES
(14, 19, 'A34', 1200000, '2024-05-19', 1000000, 'kurang 200k'),
(16, 18, 'C11', 1250000, '2024-05-19', 1000000, 'masih kurang 250k'),
(17, 1, 'A11', 850000, '2024-05-19', 850000, 'Lunas');

-- --------------------------------------------------------

--
-- Table structure for table `users`
--

CREATE TABLE `users` (
  `username` varchar(50) NOT NULL,
  `password` varchar(12) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `users`
--

INSERT INTO `users` (`username`, `password`) VALUES
('admin', 'admin');

--
-- Indexes for dumped tables
--

--
-- Indexes for table `detailtagihan`
--
ALTER TABLE `detailtagihan`
  ADD PRIMARY KEY (`ID_Detail`),
  ADD KEY `ID_Tagihan` (`ID_Tagihan`);

--
-- Indexes for table `fasilitas`
--
ALTER TABLE `fasilitas`
  ADD PRIMARY KEY (`ID_Fasilitas`);

--
-- Indexes for table `fasilitaskamarkost`
--
ALTER TABLE `fasilitaskamarkost`
  ADD KEY `fk_fasilitaskamar_kamarkost` (`ID_Fasilitas`);

--
-- Indexes for table `kamarkost`
--
ALTER TABLE `kamarkost`
  ADD PRIMARY KEY (`ID_Kamar`);

--
-- Indexes for table `penghunikost`
--
ALTER TABLE `penghunikost`
  ADD PRIMARY KEY (`ID_Penghuni`),
  ADD KEY `fk_penghunikost_kamar_kost` (`ID_Kamar`);

--
-- Indexes for table `tagihan`
--
ALTER TABLE `tagihan`
  ADD PRIMARY KEY (`ID_Tagihan`),
  ADD KEY `fk_tagihan_penghunikost` (`ID_Penghuni`);

--
-- AUTO_INCREMENT for dumped tables
--

--
-- AUTO_INCREMENT for table `detailtagihan`
--
ALTER TABLE `detailtagihan`
  MODIFY `ID_Detail` int(50) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=11;

--
-- AUTO_INCREMENT for table `fasilitas`
--
ALTER TABLE `fasilitas`
  MODIFY `ID_Fasilitas` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=9;

--
-- AUTO_INCREMENT for table `penghunikost`
--
ALTER TABLE `penghunikost`
  MODIFY `ID_Penghuni` int(50) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=20;

--
-- AUTO_INCREMENT for table `tagihan`
--
ALTER TABLE `tagihan`
  MODIFY `ID_Tagihan` int(50) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=18;

--
-- Constraints for dumped tables
--

--
-- Constraints for table `detailtagihan`
--
ALTER TABLE `detailtagihan`
  ADD CONSTRAINT `detailtagihan_ibfk_1` FOREIGN KEY (`ID_Tagihan`) REFERENCES `tagihan` (`ID_Tagihan`);

--
-- Constraints for table `fasilitaskamarkost`
--
ALTER TABLE `fasilitaskamarkost`
  ADD CONSTRAINT `fk_fasilitaskamar_kamarkost` FOREIGN KEY (`ID_Fasilitas`) REFERENCES `fasilitas` (`ID_Fasilitas`);

--
-- Constraints for table `penghunikost`
--
ALTER TABLE `penghunikost`
  ADD CONSTRAINT `fk_penghunikost_kamar_kost` FOREIGN KEY (`ID_Kamar`) REFERENCES `kamarkost` (`ID_Kamar`);

--
-- Constraints for table `tagihan`
--
ALTER TABLE `tagihan`
  ADD CONSTRAINT `fk_tagihan_penghunikost` FOREIGN KEY (`ID_Penghuni`) REFERENCES `penghunikost` (`ID_Penghuni`);
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
