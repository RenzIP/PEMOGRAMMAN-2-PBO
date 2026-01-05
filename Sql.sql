-- --------------------------------------------------------
-- Host:                         139.59.111.220
-- Server version:               8.0.44-0ubuntu0.24.04.1 - (Ubuntu)
-- Server OS:                    Linux
-- HeidiSQL Version:             12.13.0.7147
-- --------------------------------------------------------

/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET NAMES utf8 */;
/*!50503 SET NAMES utf8mb4 */;
/*!40103 SET @OLD_TIME_ZONE=@@TIME_ZONE */;
/*!40103 SET TIME_ZONE='+00:00' */;
/*!40014 SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0 */;
/*!40101 SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='NO_AUTO_VALUE_ON_ZERO' */;
/*!40111 SET @OLD_SQL_NOTES=@@SQL_NOTES, SQL_NOTES=0 */;


-- Dumping database structure for pemrog2ulbi
DROP DATABASE IF EXISTS `pemrog2ulbi`;
CREATE DATABASE IF NOT EXISTS `pemrog2ulbi` /*!40100 DEFAULT CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci */ /*!80016 DEFAULT ENCRYPTION='N' */;
USE `pemrog2ulbi`;

-- Dumping structure for table pemrog2ulbi.t_barang
DROP TABLE IF EXISTS `t_barang`;
CREATE TABLE IF NOT EXISTS `t_barang` (
  `id_barang` int NOT NULL AUTO_INCREMENT,
  `nama_barang` varchar(255) CHARACTER SET utf8mb4 COLLATE utf8mb4_general_ci DEFAULT NULL,
  `harga` int DEFAULT NULL,
  PRIMARY KEY (`id_barang`) USING BTREE
) ENGINE=InnoDB AUTO_INCREMENT=9 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci ROW_FORMAT=DYNAMIC;

-- Dumping data for table pemrog2ulbi.t_barang: ~6 rows (approximately)
INSERT INTO `t_barang` (`id_barang`, `nama_barang`, `harga`) VALUES
	(1, 'Kulkas', 1000000),
	(2, 'Buku', 45000),
	(3, 'Tas', 800000),
	(4, 'Laptop', 25000000),
	(5, 'Headset', 750000),
	(6, 'Keyboard Mechanical', 1100000);

-- Dumping structure for table pemrog2ulbi.t_mahasiswa
DROP TABLE IF EXISTS `t_mahasiswa`;
CREATE TABLE IF NOT EXISTS `t_mahasiswa` (
  `npm` int NOT NULL,
  `nama` varchar(120) NOT NULL,
  `angkatan` int NOT NULL,
  `alamat` varchar(250) NOT NULL,
  `email` varchar(50) NOT NULL,
  `nohp` varchar(13) NOT NULL,
  PRIMARY KEY (`npm`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;

-- Dumping data for table pemrog2ulbi.t_mahasiswa: ~4 rows (approximately)
INSERT INTO `t_mahasiswa` (`npm`, `nama`, `angkatan`, `alamat`, `email`, `nohp`) VALUES
	(714220201, 'Dahlan Fernando', 2022, 'Bandung', 'dahlanfernando@ulbi.ac.id', '081222210909'),
	(714220202, 'Lionel Akbar', 2022, 'Banjarmasin', 'leoakbar@ulbi.ac.id', '081224544200'),
	(714220203, 'Karin Nurlaela', 2022, 'Bogor', 'inikarin@ulbi.ac.id', '085722900707'),
	(714220204, 'Fren Lee', 2023, 'Sariasih', 'fren@ulbi.ac.id', '088877776666');

-- Dumping structure for table pemrog2ulbi.t_nilai
DROP TABLE IF EXISTS `t_nilai`;
CREATE TABLE IF NOT EXISTS `t_nilai` (
  `id_nilai` int NOT NULL AUTO_INCREMENT,
  `matkul` varchar(255) CHARACTER SET utf8mb4 COLLATE utf8mb4_general_ci DEFAULT NULL,
  `kategori` varchar(255) CHARACTER SET utf8mb4 COLLATE utf8mb4_general_ci DEFAULT NULL,
  `npm` int DEFAULT NULL,
  `nilai` int DEFAULT NULL,
  PRIMARY KEY (`id_nilai`) USING BTREE
) ENGINE=InnoDB AUTO_INCREMENT=16 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci ROW_FORMAT=DYNAMIC;

-- Dumping data for table pemrog2ulbi.t_nilai: ~10 rows (approximately)
INSERT INTO `t_nilai` (`id_nilai`, `matkul`, `kategori`, `npm`, `nilai`) VALUES
	(1, 'Pemrograman II', 'ATS', 714220201, 90),
	(2, 'Pemrograman II', 'ATS', 714220202, 90),
	(3, 'Pemrograman II', 'ATS', 714220203, 93),
	(4, 'General English I', 'ATS', 714220201, 85),
	(6, 'General English I', 'ATS', 714220203, 90),
	(7, 'Pemrograman I', 'ATS', 714220201, 88),
	(8, 'Pemrograman I', 'ATS', 714220202, 90),
	(9, 'Pemrograman I', 'ATS', 714220203, 96),
	(11, 'Pemrograman IV', 'ATS', 714220202, 78),
	(14, 'Pemrograman II', 'ATS', 714220203, 100);

-- Dumping structure for table pemrog2ulbi.t_transaksi
DROP TABLE IF EXISTS `t_transaksi`;
CREATE TABLE IF NOT EXISTS `t_transaksi` (
  `id_transaksi` int NOT NULL AUTO_INCREMENT,
  `id_barang` int NOT NULL,
  `qty` int DEFAULT NULL,
  `total` int DEFAULT NULL,
  PRIMARY KEY (`id_transaksi`) USING BTREE,
  KEY `idx_id_barang` (`id_barang`) USING BTREE,
  CONSTRAINT `fk_t_transaksi_t_barang` FOREIGN KEY (`id_barang`) REFERENCES `t_barang` (`id_barang`) ON DELETE RESTRICT ON UPDATE CASCADE
) ENGINE=InnoDB AUTO_INCREMENT=4 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci ROW_FORMAT=DYNAMIC;

-- Dumping data for table pemrog2ulbi.t_transaksi: ~3 rows (approximately)
INSERT INTO `t_transaksi` (`id_transaksi`, `id_barang`, `qty`, `total`) VALUES
	(1, 1, 3, 3000000),
	(2, 5, 3, 2250000),
	(3, 4, 6, 150000000);

/*!40103 SET TIME_ZONE=IFNULL(@OLD_TIME_ZONE, 'system') */;
/*!40101 SET SQL_MODE=IFNULL(@OLD_SQL_MODE, '') */;
/*!40014 SET FOREIGN_KEY_CHECKS=IFNULL(@OLD_FOREIGN_KEY_CHECKS, 1) */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40111 SET SQL_NOTES=IFNULL(@OLD_SQL_NOTES, 1) */;
