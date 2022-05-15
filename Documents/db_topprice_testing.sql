-- phpMyAdmin SQL Dump
-- version 5.0.4
-- https://www.phpmyadmin.net/
--
-- Host: localhost
-- Generation Time: May 15, 2022 at 08:21 PM
-- Server version: 5.7.11
-- PHP Version: 8.0.1

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `db_topprice`
--

-- --------------------------------------------------------

--
-- Table structure for table `t_brand`
--

CREATE TABLE `t_brand` (
  `idBrand` int(11) NOT NULL,
  `braName` varchar(255) NOT NULL,
  `fkOS` int(11) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `t_brand`
--

INSERT INTO `t_brand` (`idBrand`, `braName`, `fkOS`) VALUES
(1, 'Apple Inc.', 1),
(2, 'Samsung', 2);

-- --------------------------------------------------------

--
-- Table structure for table `t_constructor`
--

CREATE TABLE `t_constructor` (
  `idConstructor` int(11) NOT NULL,
  `conName` varchar(255) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `t_constructor`
--

INSERT INTO `t_constructor` (`idConstructor`, `conName`) VALUES
(1, 'Foxconn');

-- --------------------------------------------------------

--
-- Table structure for table `t_os`
--

CREATE TABLE `t_os` (
  `idOS` int(11) NOT NULL,
  `osName` varchar(255) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `t_os`
--

INSERT INTO `t_os` (`idOS`, `osName`) VALUES
(1, 'iOS'),
(2, 'Android');

-- --------------------------------------------------------

--
-- Table structure for table `t_price`
--

CREATE TABLE `t_price` (
  `idPrice` int(11) NOT NULL,
  `priAmount` decimal(10,0) NOT NULL,
  `priDate` date NOT NULL,
  `fkSmartpone` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Table structure for table `t_provider`
--

CREATE TABLE `t_provider` (
  `idProvider` int(11) NOT NULL,
  `proName` varchar(255) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `t_provider`
--

INSERT INTO `t_provider` (`idProvider`, `proName`) VALUES
(1, 'Digitec Galaxus AG');

-- --------------------------------------------------------

--
-- Table structure for table `t_smartphone`
--

CREATE TABLE `t_smartphone` (
  `id` mediumint(8) UNSIGNED NOT NULL,
  `smaModel` text,
  `smaPrice` mediumint(9) DEFAULT NULL,
  `smaStorage` mediumint(9) DEFAULT NULL,
  `smaBatteryLife` mediumint(9) DEFAULT NULL,
  `smaScreenSize` mediumint(9) DEFAULT NULL,
  `smaResolution` text,
  `smaCPU` text,
  `smaClockSpeed` mediumint(9) DEFAULT NULL,
  `smaThreads` mediumint(9) DEFAULT NULL,
  `fkConstructor` mediumint(9) DEFAULT NULL,
  `fkOS` mediumint(9) DEFAULT NULL,
  `fkProvider` mediumint(9) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `t_smartphone`
--

INSERT INTO `t_smartphone` (`id`, `smaModel`, `smaPrice`, `smaStorage`, `smaBatteryLife`, `smaScreenSize`, `smaResolution`, `smaCPU`, `smaClockSpeed`, `smaThreads`, `fkConstructor`, `fkOS`, `fkProvider`) VALUES
(1, 'arcu.', 716, 95, 2, 7, 'fringilla', 'gravida', 4, 7, 2, 2, 1),
(2, 'nec', 850, 66, 42, 8, 'libero', 'tellus.', 3, 6, 2, 2, 1),
(3, 'porttitor', 898, 136, 37, 9, 'amet', 'vehicula', 2, 6, 2, 1, 1),
(4, 'at,', 537, 193, 18, 11, 'sed', 'consequat', 5, 6, 1, 2, 1),
(5, 'posuere', 854, 119, 38, 10, 'pharetra', 'Fusce', 4, 8, 2, 1, 1),
(6, 'Aliquam', 660, 237, 44, 9, 'vehicula', 'Cras', 2, 3, 2, 1, 1),
(7, 'orci', 264, 97, 5, 10, 'risus', 'est,', 4, 8, 1, 2, 1),
(8, 'Fusce', 696, 124, 48, 6, 'a', 'dui', 4, 4, 1, 1, 1),
(9, 'erat', 314, 85, 47, 8, 'sodales', 'a', 5, 8, 2, 2, 1),
(10, 'non', 726, 121, 29, 10, 'libero.', 'tellus', 4, 3, 1, 1, 1),
(11, 'egestas.', 866, 161, 49, 9, 'Nunc', 'consequat', 3, 5, 1, 2, 1),
(12, 'odio', 709, 105, 26, 11, 'at', 'parturient', 4, 4, 2, 1, 1),
(13, 'malesuada', 938, 135, 44, 10, 'parturient', 'aliquam,', 3, 3, 2, 1, 1),
(14, 'dolor.', 873, 134, 23, 7, 'purus.', 'nulla.', 3, 7, 2, 1, 1),
(15, 'Proin', 879, 205, 28, 6, 'orci,', 'dis', 4, 6, 1, 1, 1),
(16, 'elit,', 500, 96, 38, 7, 'nec', 'imperdiet', 3, 4, 2, 1, 1),
(17, 'felis.', 864, 117, 10, 5, 'fringilla,', 'vulputate', 3, 7, 2, 2, 1),
(18, 'porttitor', 506, 158, 38, 8, 'lacinia', 'cursus', 2, 4, 2, 1, 1),
(19, 'ornare', 652, 234, 7, 8, 'nulla.', 'Mauris', 3, 3, 1, 1, 1),
(20, 'mattis.', 550, 126, 2, 5, 'ligula.', 'ligula.', 3, 3, 2, 2, 1),
(21, 'nibh.', 349, 219, 49, 9, 'et', 'Nam', 2, 3, 1, 2, 1),
(22, 'fringilla', 898, 153, 45, 9, 'diam', 'lacus.', 2, 8, 2, 1, 1),
(23, 'Donec', 552, 119, 10, 8, 'enim', 'mus.', 4, 7, 1, 1, 1),
(24, 'ante,', 764, 186, 14, 9, 'ac', 'lectus,', 5, 6, 1, 2, 1),
(25, 'augue', 908, 172, 21, 10, 'elit,', 'venenatis', 5, 4, 1, 2, 1),
(26, 'Praesent', 905, 157, 47, 12, 'dui.', 'Fusce', 4, 7, 1, 2, 1),
(27, 'non', 271, 216, 9, 11, 'Sed', 'ipsum', 2, 7, 1, 2, 1),
(28, 'nisl', 971, 92, 24, 10, 'pede', 'lectus.', 3, 5, 1, 2, 1),
(29, 'pede', 754, 151, 41, 10, 'habitant', 'molestie', 2, 5, 1, 1, 1),
(30, 'ligula', 811, 64, 49, 8, 'senectus', 'eu,', 3, 6, 2, 2, 1),
(31, 'aliquam', 614, 239, 49, 12, 'commodo', 'aliquet.', 4, 2, 2, 1, 1),
(32, 'Fusce', 666, 172, 15, 11, 'senectus', 'elit.', 4, 5, 1, 1, 1),
(33, 'dolor.', 578, 129, 32, 7, 'interdum', 'nascetur', 5, 4, 1, 2, 1),
(34, 'Curabitur', 816, 185, 9, 7, 'per', 'pharetra,', 2, 7, 2, 2, 1),
(35, 'lacinia', 817, 210, 26, 10, 'velit.', 'In', 4, 3, 2, 2, 1),
(36, 'adipiscing', 445, 134, 23, 5, 'dapibus', 'et,', 4, 3, 1, 1, 1),
(37, 'In', 958, 251, 17, 7, 'commodo', 'elit', 4, 3, 2, 1, 1),
(38, 'dis', 373, 134, 36, 7, 'ut,', 'erat', 4, 5, 2, 2, 1),
(39, 'euismod', 859, 181, 19, 8, 'varius.', 'enim,', 4, 2, 1, 2, 1),
(40, 'Nam', 390, 240, 14, 6, 'lectus', 'nec', 4, 8, 1, 2, 1),
(41, 'Aenean', 213, 224, 19, 7, 'hendrerit', 'hendrerit', 2, 2, 2, 2, 1),
(42, 'luctus', 839, 80, 7, 5, 'senectus', 'feugiat', 3, 6, 1, 2, 1),
(43, 'ac', 416, 209, 2, 9, 'sollicitudin', 'Donec', 2, 3, 2, 2, 1),
(44, 'Curae', 218, 216, 5, 10, 'mi', 'Sed', 3, 4, 1, 2, 1),
(45, 'turpis', 737, 147, 24, 8, 'dui.', 'molestie', 3, 4, 2, 2, 1),
(46, 'sed', 247, 81, 2, 7, 'congue.', 'dui', 3, 4, 1, 1, 1),
(47, 'pede.', 814, 120, 46, 6, 'pellentesque,', 'iaculis', 3, 5, 1, 2, 1),
(48, 'egestas', 303, 240, 5, 7, 'nunc', 'auctor', 3, 8, 1, 2, 1),
(49, 'a,', 417, 148, 49, 8, 'rutrum', 'dui,', 4, 8, 1, 2, 1),
(50, 'et', 431, 99, 32, 6, 'nibh.', 'est', 4, 5, 1, 1, 1),
(51, 'nisl.', 261, 186, 41, 9, 'eleifend', 'eros', 3, 5, 1, 1, 1),
(52, 'Nunc', 637, 156, 7, 10, 'hendrerit', 'nec', 3, 5, 2, 2, 1),
(53, 'egestas.', 994, 250, 42, 7, 'tempus', 'Quisque', 3, 3, 2, 2, 1),
(54, 'congue', 363, 221, 44, 7, 'commodo', 'cursus.', 3, 7, 1, 1, 1),
(55, 'Phasellus', 803, 176, 23, 12, 'lectus.', 'pede.', 3, 4, 2, 2, 1),
(56, 'lobortis', 369, 183, 30, 9, 'ante.', 'arcu', 4, 2, 2, 1, 1),
(57, 'cursus', 884, 150, 34, 6, 'semper', 'id,', 2, 5, 1, 1, 1),
(58, 'convallis', 551, 200, 17, 10, 'purus.', 'montes,', 3, 8, 1, 2, 1),
(59, 'Donec', 722, 246, 40, 7, 'sem', 'at,', 3, 5, 1, 2, 1),
(60, 'iaculis', 290, 223, 31, 8, 'tellus', 'augue', 2, 3, 1, 2, 1),
(61, 'ante', 725, 125, 40, 8, 'elit.', 'pede', 4, 7, 1, 2, 1),
(62, 'quis', 859, 238, 30, 11, 'egestas', 'ipsum.', 4, 6, 2, 2, 1),
(63, 'vitae', 689, 162, 11, 6, 'at', 'magna,', 3, 4, 1, 1, 1),
(64, 'nulla.', 803, 183, 30, 5, 'ac', 'velit.', 3, 4, 1, 1, 1),
(65, 'ullamcorper', 292, 65, 15, 8, 'Maecenas', 'netus', 3, 2, 1, 2, 1),
(66, 'dolor,', 565, 179, 42, 8, 'egestas.', 'magnis', 4, 7, 2, 1, 1),
(67, 'ac', 720, 111, 26, 6, 'libero', 'suscipit', 4, 8, 1, 1, 1),
(68, 'dictum', 582, 139, 12, 12, 'convallis', 'Integer', 4, 4, 1, 1, 1),
(69, 'eget', 476, 186, 19, 5, 'commodo', 'eget', 3, 4, 2, 2, 1),
(70, 'tellus.', 428, 105, 26, 8, 'Vestibulum', 'vestibulum', 4, 4, 2, 2, 1),
(71, 'diam', 294, 153, 39, 11, 'velit.', 'eu', 5, 5, 2, 2, 1),
(72, 'arcu.', 426, 98, 10, 6, 'eros', 'orci', 3, 7, 2, 2, 1),
(73, 'In', 285, 128, 5, 12, 'nec', 'ipsum', 2, 6, 1, 2, 1),
(74, 'nec,', 273, 252, 31, 8, 'mauris,', 'nec', 3, 7, 2, 2, 1),
(75, 'Praesent', 740, 228, 6, 7, 'semper,', 'diam.', 5, 3, 1, 1, 1),
(76, 'Vestibulum', 996, 99, 8, 12, 'elit,', 'Praesent', 5, 8, 1, 1, 1),
(77, 'varius', 924, 107, 23, 10, 'at', 'ante', 4, 6, 2, 2, 1),
(78, 'aliquet', 715, 191, 9, 7, 'eu', 'volutpat.', 3, 7, 1, 2, 1),
(79, 'molestie', 519, 115, 21, 8, 'at', 'ut', 2, 5, 1, 1, 1),
(80, 'consectetuer', 392, 184, 30, 10, 'turpis', 'nisl.', 5, 5, 1, 2, 1),
(81, 'convallis', 992, 154, 31, 9, 'scelerisque', 'ut', 4, 5, 1, 1, 1),
(82, 'urna.', 728, 200, 28, 7, 'id,', 'sagittis', 4, 2, 2, 2, 1),
(83, 'Maecenas', 663, 114, 13, 7, 'Maecenas', 'commodo', 4, 5, 2, 1, 1),
(84, 'eu', 417, 223, 23, 10, 'Curabitur', 'nonummy', 4, 6, 1, 2, 1),
(85, 'Maecenas', 945, 201, 16, 7, 'Aenean', 'venenatis', 3, 3, 1, 2, 1),
(86, 'ipsum', 312, 195, 42, 6, 'id', 'et,', 5, 4, 1, 2, 1),
(87, 'quam', 591, 148, 14, 10, 'feugiat', 'feugiat', 2, 7, 2, 1, 1),
(88, 'sed,', 904, 130, 41, 9, 'sed', 'placerat', 3, 4, 2, 1, 1),
(89, 'molestie', 378, 173, 10, 11, 'Vestibulum', 'mi', 4, 3, 2, 1, 1),
(90, 'ornare,', 634, 160, 15, 10, 'Nulla', 'Donec', 5, 7, 1, 1, 1),
(91, 'nibh.', 688, 211, 49, 8, 'et,', 'risus.', 3, 7, 2, 2, 1),
(92, 'dolor.', 495, 68, 42, 7, 'Cras', 'auctor,', 5, 3, 1, 2, 1),
(93, 'fringilla,', 298, 194, 4, 12, 'aliquam', 'nunc', 2, 6, 1, 2, 1),
(94, 'tristique', 642, 135, 15, 6, 'Donec', 'vitae', 4, 5, 2, 1, 1),
(95, 'libero', 465, 135, 4, 11, 'justo.', 'malesuada', 3, 4, 1, 2, 1),
(96, 'Nullam', 610, 238, 41, 6, 'libero.', 'fames', 2, 5, 2, 2, 1),
(97, 'semper', 991, 134, 37, 5, 'Cum', 'scelerisque', 5, 6, 1, 2, 1),
(98, 'commodo', 540, 158, 37, 8, 'lectus', 'est', 3, 2, 1, 1, 1),
(99, 'egestas.', 862, 131, 47, 10, 'sociis', 'Integer', 2, 7, 1, 1, 1),
(100, 'Donec', 957, 134, 32, 7, 'erat', 'at', 3, 4, 2, 2, 1);

--
-- Indexes for dumped tables
--

--
-- Indexes for table `t_brand`
--
ALTER TABLE `t_brand`
  ADD PRIMARY KEY (`idBrand`),
  ADD KEY `fk_t_brand` (`fkOS`);

--
-- Indexes for table `t_constructor`
--
ALTER TABLE `t_constructor`
  ADD PRIMARY KEY (`idConstructor`);

--
-- Indexes for table `t_os`
--
ALTER TABLE `t_os`
  ADD PRIMARY KEY (`idOS`);

--
-- Indexes for table `t_provider`
--
ALTER TABLE `t_provider`
  ADD PRIMARY KEY (`idProvider`);

--
-- Indexes for table `t_smartphone`
--
ALTER TABLE `t_smartphone`
  ADD PRIMARY KEY (`id`);

--
-- AUTO_INCREMENT for dumped tables
--

--
-- AUTO_INCREMENT for table `t_brand`
--
ALTER TABLE `t_brand`
  MODIFY `idBrand` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=3;

--
-- AUTO_INCREMENT for table `t_constructor`
--
ALTER TABLE `t_constructor`
  MODIFY `idConstructor` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=2;

--
-- AUTO_INCREMENT for table `t_os`
--
ALTER TABLE `t_os`
  MODIFY `idOS` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=3;

--
-- AUTO_INCREMENT for table `t_provider`
--
ALTER TABLE `t_provider`
  MODIFY `idProvider` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=2;

--
-- AUTO_INCREMENT for table `t_smartphone`
--
ALTER TABLE `t_smartphone`
  MODIFY `id` mediumint(8) UNSIGNED NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=101;

--
-- Constraints for dumped tables
--

--
-- Constraints for table `t_brand`
--
ALTER TABLE `t_brand`
  ADD CONSTRAINT `fk_t_brand` FOREIGN KEY (`fkOS`) REFERENCES `t_os` (`idOS`);
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
