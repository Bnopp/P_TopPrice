-- phpMyAdmin SQL Dump
-- version 5.0.4
-- https://www.phpmyadmin.net/
--
-- Host: localhost
-- Generation Time: May 27, 2022 at 04:29 PM
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

CREATE DATABASE `db_topprice`;

-- --------------------------------------------------------

--
-- Table structure for table `t_brand`
--

CREATE TABLE `t_brand` (
  `idBrand` int(11) NOT NULL,
  `braName` varchar(255) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `t_brand`
--

INSERT INTO `t_brand` (`idBrand`, `braName`) VALUES
(1, 'Apple Inc.'),
(2, 'Samsung'),
(7, 'ASUS'),
(8, 'Google'),
(9, 'OnePlus'),
(10, 'Huawei'),
(11, 'Xiaomi'),
(12, 'Fairphone'),
(13, 'Oppo'),
(14, 'Honor'),
(15, 'Sony'),
(16, 'Nokia'),
(17, 'Motorola'),
(18, 'Cat');

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
-- Table structure for table `t_pricehistory`
--

CREATE TABLE `t_pricehistory` (
  `idPrice` int(11) NOT NULL,
  `priAmount` decimal(10,0) NOT NULL,
  `priDate` date NOT NULL,
  `fkSmartphone` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `t_pricehistory`
--

INSERT INTO `t_pricehistory` (`idPrice`, `priAmount`, `priDate`, `fkSmartphone`) VALUES
(13, '879', '2022-05-27', 1),
(14, '839', '2022-05-27', 2),
(15, '609', '2022-05-27', 3),
(16, '538', '2022-05-27', 4),
(17, '369', '2022-05-27', 5),
(18, '1148', '2022-05-27', 6),
(19, '1380', '2022-05-27', 7),
(20, '1265', '2022-05-27', 8),
(21, '90', '2022-05-27', 9),
(22, '639', '2022-05-27', 10),
(23, '969', '2022-05-27', 11),
(24, '621', '2022-05-27', 12),
(25, '260', '2022-05-27', 13),
(26, '878', '2022-05-27', 14),
(27, '1070', '2022-05-27', 15),
(28, '1222', '2022-05-27', 16),
(29, '419', '2022-05-27', 17),
(30, '198', '2022-05-27', 18),
(31, '200', '2022-05-27', 19),
(32, '956', '2022-05-27', 20),
(33, '505', '2022-05-27', 21),
(34, '345', '2022-05-27', 22),
(35, '530', '2022-05-27', 23),
(36, '299', '2022-05-27', 24),
(37, '721', '2022-05-27', 25),
(38, '499', '2022-05-27', 26),
(39, '515', '2022-05-27', 27),
(40, '589', '2022-05-27', 28),
(41, '589', '2022-05-27', 29),
(42, '366', '2022-05-27', 30),
(43, '1232', '2022-04-12', 1),
(44, '912', '2022-05-01', 1),
(45, '746', '2022-05-10', 1),
(46, '974', '2022-01-03', 2),
(47, '1150', '2022-02-15', 2),
(48, '731', '2022-03-23', 2),
(49, '800', '2022-05-17', 2),
(50, '800', '2021-09-14', 3),
(51, '400', '2022-02-08', 4),
(52, '460', '2022-04-13', 4),
(53, '600', '2022-05-10', 4),
(54, '600', '2021-11-09', 5),
(55, '543', '2022-02-21', 5),
(56, '1148', '2022-03-07', 6),
(57, '1200', '2022-04-03', 6),
(58, '1112', '2022-04-18', 6),
(59, '900', '2022-05-01', 6),
(60, '1045', '2022-05-10', 6),
(66, '1700', '2022-03-11', 7),
(67, '1674', '2022-04-14', 7),
(68, '1112', '2022-04-08', 7),
(69, '1205', '2022-05-01', 7),
(70, '1045', '2022-05-10', 7),
(71, '1265', '2021-04-07', 8),
(72, '1156', '2022-04-03', 8),
(73, '1200', '2022-01-24', 8),
(74, '989', '2022-05-01', 8),
(75, '1045', '2022-05-10', 8),
(76, '205', '2020-01-09', 9),
(77, '342', '2022-04-03', 9),
(78, '242', '2022-04-18', 6),
(79, '101', '2022-05-01', 9),
(80, '90', '2022-05-10', 9),
(81, '639', '2022-03-07', 10),
(82, '543', '2022-04-03', 10),
(83, '720', '2022-04-18', 10),
(84, '650', '2022-05-01', 10),
(85, '690', '2022-05-10', 10),
(86, '1148', '2022-03-07', 11),
(87, '1200', '2022-04-03', 11),
(88, '1112', '2022-04-18', 11),
(89, '900', '2022-05-01', 11),
(90, '1045', '2022-05-10', 11),
(91, '502', '2022-03-07', 12),
(92, '625', '2022-04-03', 12),
(93, '712', '2022-04-18', 12),
(94, '632', '2022-05-01', 12),
(95, '578', '2022-05-10', 12),
(96, '502', '2022-03-07', 13),
(97, '430', '2022-04-03', 13),
(98, '356', '2022-04-18', 13),
(99, '409', '2022-05-01', 13),
(100, '332', '2022-05-10', 13),
(101, '1148', '2022-03-07', 14),
(102, '1200', '2022-04-03', 14),
(103, '1112', '2022-04-18', 14),
(104, '900', '2022-05-01', 14),
(105, '1045', '2022-05-10', 14),
(106, '1342', '2022-03-07', 15),
(107, '1459', '2022-04-03', 15),
(108, '1387', '2022-04-18', 15),
(109, '1254', '2022-05-01', 15),
(110, '1132', '2022-05-10', 15),
(111, '1342', '2022-03-07', 16),
(112, '1459', '2022-04-03', 16),
(113, '1387', '2022-04-18', 16),
(114, '1254', '2022-05-01', 16),
(115, '1132', '2022-05-10', 16),
(116, '502', '2022-03-07', 17),
(117, '625', '2022-04-03', 17),
(118, '712', '2022-04-18', 12),
(119, '632', '2022-05-01', 17),
(120, '578', '2022-05-10', 17),
(121, '243', '2022-03-07', 18),
(122, '298', '2022-04-03', 18),
(123, '254', '2022-04-18', 18),
(124, '230', '2022-05-01', 18),
(125, '270', '2022-05-10', 18),
(126, '502', '2022-03-07', 18),
(127, '430', '2022-04-03', 18),
(128, '356', '2022-04-18', 18),
(129, '409', '2022-05-01', 18),
(130, '332', '2022-05-10', 18),
(131, '502', '2022-03-07', 19),
(132, '430', '2022-04-03', 19),
(133, '356', '2022-04-18', 19),
(134, '409', '2022-05-01', 19),
(135, '332', '2022-05-10', 19),
(136, '1148', '2022-03-07', 20),
(137, '1200', '2022-04-03', 20),
(138, '1112', '2022-04-18', 20),
(139, '900', '2022-05-01', 20),
(140, '1045', '2022-05-10', 20),
(141, '498', '2022-03-07', 21),
(142, '569', '2022-04-03', 21),
(143, '612', '2022-04-18', 21),
(144, '508', '2022-05-01', 21),
(145, '546', '2022-05-10', 21),
(146, '502', '2022-03-07', 22),
(147, '430', '2022-04-03', 22),
(148, '356', '2022-04-18', 22),
(149, '409', '2022-05-01', 22),
(150, '332', '2022-05-10', 22),
(151, '498', '2022-03-07', 23),
(152, '569', '2022-04-03', 23),
(153, '612', '2022-04-18', 23),
(154, '508', '2022-05-01', 23),
(155, '546', '2022-05-10', 23),
(156, '243', '2022-03-07', 24),
(157, '298', '2022-04-03', 24),
(158, '254', '2022-04-18', 24),
(159, '230', '2022-05-01', 24),
(160, '270', '2022-05-10', 24),
(161, '502', '2022-03-07', 25),
(162, '625', '2022-04-03', 25),
(163, '712', '2022-04-18', 25),
(164, '632', '2022-05-01', 25),
(165, '578', '2022-05-10', 25),
(166, '502', '2022-03-07', 26),
(167, '430', '2022-04-03', 26),
(168, '356', '2022-04-18', 26),
(169, '409', '2022-05-01', 26),
(170, '332', '2022-05-10', 26),
(171, '498', '2022-03-07', 27),
(172, '569', '2022-04-03', 27),
(173, '612', '2022-04-18', 27),
(174, '508', '2022-05-01', 27),
(175, '546', '2022-05-10', 27),
(176, '502', '2022-03-07', 30),
(177, '430', '2022-04-03', 30),
(178, '356', '2022-04-18', 30),
(179, '409', '2022-05-01', 30),
(180, '332', '2022-05-10', 30),
(181, '498', '2022-03-07', 28),
(182, '569', '2022-04-03', 29),
(183, '612', '2022-04-18', 28),
(184, '508', '2022-05-01', 28),
(185, '546', '2022-05-10', 28),
(186, '498', '2022-03-07', 29),
(187, '569', '2022-04-03', 28),
(188, '612', '2022-04-18', 29),
(189, '508', '2022-05-01', 29),
(190, '546', '2022-05-10', 29);

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
  `idSmartphone` int(11) NOT NULL,
  `smaModel` varchar(255) NOT NULL,
  `smaPrice` decimal(10,2) NOT NULL,
  `smaStorage` int(11) NOT NULL,
  `smaBatteryLife` int(11) NOT NULL,
  `smaRAM` int(11) NOT NULL,
  `smaScreenSize` decimal(10,2) DEFAULT NULL,
  `smaResolution` varchar(255) NOT NULL,
  `smaCPU` varchar(255) DEFAULT NULL,
  `smaClockSpeed` decimal(10,2) DEFAULT NULL,
  `smaThreads` decimal(10,0) DEFAULT NULL,
  `fkConstructor` int(11) DEFAULT NULL,
  `fkBrand` int(11) DEFAULT NULL,
  `fkOS` int(11) DEFAULT NULL,
  `fkProvider` int(11) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `t_smartphone`
--

INSERT INTO `t_smartphone` (`idSmartphone`, `smaModel`, `smaPrice`, `smaStorage`, `smaBatteryLife`, `smaRAM`, `smaScreenSize`, `smaResolution`, `smaCPU`, `smaClockSpeed`, `smaThreads`, `fkConstructor`, `fkBrand`, `fkOS`, `fkProvider`) VALUES
(1, 'iPhone 13', '879.00', 128, 19, 4, '6.00', '1170 x 2532', 'A15 Bionic', '3.00', '6', 1, 1, 1, 1),
(2, 'iPhone 12', '839.00', 128, 17, 4, '6.00', '1170 x 2532', 'A14 Bionic', '3.00', '6', 1, 1, 1, 1),
(3, 'iPhone 11', '609.00', 128, 17, 4, '6.00', '828 x 1792', 'A13 Bionic', '3.00', '6', 1, 1, 1, 1),
(4, 'iPhone SE', '538.00', 128, 9, 4, '5.00', '750 x 1334', 'A15 Bionic', '3.00', '6', 1, 1, 1, 1),
(5, 'iPhone X', '369.00', 128, 18, 3, '5.85', '2436 x 1125', 'A11', '2.39', '8', 1, 1, 1, 1),
(6, '13 Pro Max', '1148.00', 256, 12, 6, '6.10', '2532 x 1170', 'A 15 Bionic', '3.22', '6', 1, 1, 1, 1),
(7, 'ROG 5s Pro', '1380.00', 512, 15, 18, '6.75', '2448 x 1080', 'Snapdragon 888+ 5G', '2.99', '8', 1, 7, 2, 1),
(8, 'Pixel 6 Pro', '1265.00', 256, 24, 12, '6.71', '3120 x 1440', 'Google tensor', '2.80', '8', 1, 8, 2, 1),
(9, 'Redmi 9A', '89.80', 32, 48, 2, '6.53', '1600 x 720', 'MediaTek MT6762G Helio G25', '2.00', '4', 1, 11, 2, 1),
(10, '4', '639.00', 256, 13, 8, '6.30', '2340 x 1080', 'Qualcomm SM7225 Snapdragon 750G 5G\r\n', '2.20', '4', 1, 12, 2, 1),
(11, '10 Pro', '969.00', 128, 15, 8, '6.70', '3216 x 1440', 'Qualcomm SM8450 Snapdragon 8 gen', '3.00', '4', 1, 9, 2, 1),
(12, 'Reno6 Pro 5G', '621.00', 256, 20, 12, '6.55', '2400 x 1080', 'Qualcomm SM8250-AC Snapdragon 870 5G', '3.20', '8', 1, 13, 2, 1),
(13, 'Galaxy A32 5G', '260.00', 128, 13, 4, '6.50', '1600 x 720', 'MediaTek MT6853 Dimensity 720', '2.00', '8', 1, 2, 2, 1),
(14, 'Galaxy S22 5G', '878.00', 256, 14, 8, '6.10', '2340 x 1080', 'Exynos 2200\r\n', '2.80', NULL, 1, 2, 2, 1),
(15, 'Galaxy S22+ 5G', '1070.00', 256, 35, 8, '6.60', '2340 x 1080', 'Exynos 2200\r\n', '2.80', '8', 1, 2, 2, 1),
(16, 'Galaxy S22 Ultra 5G', '1222.00', 256, 15, 12, '6.80', '3088 x 1440', 'Exynos 2200\r\n', '2.80', '8', NULL, 2, 2, 1),
(17, '50', '419.00', 256, 19, 8, '6.57', '2340 x 1080', 'Qualcomm SM7325 Snapdragon 778G 5G\r\n', '2.40', '8', 1, 14, 2, 1),
(18, '50 Lite', '198.00', 128, 16, 6, '6.67', '1376 x 1080', 'Qualcomm Snapdragon 662\r\n', '2.00', '8', 1, 14, 2, 1),
(19, 'Redmi Note 11', '200.00', 128, 16, 4, '6.43', '2400 x 1080', 'Qualcomm Snapdragon 680\r\n', '2.40', '8', 1, 11, 2, 1),
(20, 'Xperia 5 III', '956.00', 128, 15, 8, '6.10', '2520 x 1080', 'Qualcomm Snapdragon 888\r\n', '2.84', '8', 1, 15, 2, 1),
(21, 'Galaxy A53 5G', '505.00', 256, 12, 8, '6.50', '2400 x 1080', 'Exynos 1280', '2.00', '8', 1, 2, 2, 1),
(22, 'Nord CE 5G', '345.00', 128, 19, 8, '6.43', '2400 x 1080', 'Qualcomm Snapdragon 750G', '2.20', '8', 1, 9, 2, 1),
(23, 'S62 Pro', '530.00', 128, 40, 6, '5.70', '2160 x 1080', 'Qualcomm Snapdragon 660', '2.00', '8', 1, 18, 2, 1),
(24, 'P40 Lite', '299.00', 128, 16, 6, '6.40', '2310 x 1080', 'Kirin 810', '2.27', '8', 1, 10, 2, 1),
(25, 'Galaxy Z Flip3 5G', '721.00', 128, 6, 8, '6.70', '2640 x 1080', 'Qualcomm Snapdragon 888', '2.84', '8', 1, 2, 2, 1),
(26, 'Edge+', '499.00', 256, 9, 12, '6.70', '2340 x 1080', 'Qualcomm Snapdragon 865', '2.40', '8', 1, 17, 2, 1),
(27, '11T Pro', '515.00', 256, 30, 8, '6.67', '1400 x 1080', 'Qualcomm Snapdragon 888', '2.84', '8', 1, 11, 2, 1),
(28, 'Pixel 6', '589.00', 128, 20, 8, '6.40', '2400 x 1080', 'Google Tensor\r\n', '2.50', '8', 1, 8, 2, 1),
(29, 'XR20', '589.00', 128, 17, 6, '6.67', '2400 x 1080', 'Qualcomm Snapdragon 480', '2.40', '8', 1, 16, 2, 1),
(30, 'Redmi Note 11 Pro 5G', '366.00', 128, 17, 8, '6.67', '2400 x 1080', 'Qualcomm Snapdragon 695', '2.20', '8', 1, 11, 2, 1);

--
-- Indexes for dumped tables
--

--
-- Indexes for table `t_brand`
--
ALTER TABLE `t_brand`
  ADD PRIMARY KEY (`idBrand`);

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
-- Indexes for table `t_pricehistory`
--
ALTER TABLE `t_pricehistory`
  ADD PRIMARY KEY (`idPrice`),
  ADD KEY `fkSmartpone` (`fkSmartphone`);

--
-- Indexes for table `t_provider`
--
ALTER TABLE `t_provider`
  ADD PRIMARY KEY (`idProvider`);

--
-- Indexes for table `t_smartphone`
--
ALTER TABLE `t_smartphone`
  ADD PRIMARY KEY (`idSmartphone`),
  ADD KEY `fkConstructor` (`fkConstructor`),
  ADD KEY `fkOS` (`fkOS`),
  ADD KEY `fkProvider` (`fkProvider`),
  ADD KEY `fkBrand` (`fkBrand`);

--
-- AUTO_INCREMENT for dumped tables
--

--
-- AUTO_INCREMENT for table `t_brand`
--
ALTER TABLE `t_brand`
  MODIFY `idBrand` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=19;

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
-- AUTO_INCREMENT for table `t_pricehistory`
--
ALTER TABLE `t_pricehistory`
  MODIFY `idPrice` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=191;

--
-- AUTO_INCREMENT for table `t_provider`
--
ALTER TABLE `t_provider`
  MODIFY `idProvider` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=2;

--
-- AUTO_INCREMENT for table `t_smartphone`
--
ALTER TABLE `t_smartphone`
  MODIFY `idSmartphone` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=33;

--
-- Constraints for dumped tables
--

--
-- Constraints for table `t_pricehistory`
--
ALTER TABLE `t_pricehistory`
  ADD CONSTRAINT `t_pricehistory_ibfk_1` FOREIGN KEY (`fkSmartphone`) REFERENCES `t_smartphone` (`idSmartphone`);

--
-- Constraints for table `t_smartphone`
--
ALTER TABLE `t_smartphone`
  ADD CONSTRAINT `t_smartphone_ibfk_1` FOREIGN KEY (`fkConstructor`) REFERENCES `t_constructor` (`idConstructor`),
  ADD CONSTRAINT `t_smartphone_ibfk_2` FOREIGN KEY (`fkOS`) REFERENCES `t_os` (`idOS`),
  ADD CONSTRAINT `t_smartphone_ibfk_3` FOREIGN KEY (`fkProvider`) REFERENCES `t_provider` (`idProvider`),
  ADD CONSTRAINT `t_smartphone_ibfk_4` FOREIGN KEY (`fkBrand`) REFERENCES `t_brand` (`idBrand`);
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
