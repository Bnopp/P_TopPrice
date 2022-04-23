-- phpMyAdmin SQL Dump
-- version 5.0.4
-- https://www.phpmyadmin.net/
--
-- Host: localhost
-- Generation Time: Apr 23, 2022 at 07:34 PM
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

CREATE DATABASE db_topprice;

-- --------------------------------------------------------

--
-- Table structure for table `t_brand`
--

CREATE TABLE `t_brand` (
  `idBrand` int(11) NOT NULL,
  `braName` varchar(255) NOT NULL,
  `fkOS` int(11) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Table structure for table `t_constructor`
--

CREATE TABLE `t_constructor` (
  `idConstructor` int(11) NOT NULL,
  `conName` varchar(255) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Table structure for table `t_os`
--

CREATE TABLE `t_os` (
  `idOS` int(11) NOT NULL,
  `osName` varchar(255) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

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

-- --------------------------------------------------------

--
-- Table structure for table `t_smartphone`
--

CREATE TABLE `t_smartphone` (
  `idSmartphone` int(11) NOT NULL,
  `smaModel` varchar(255) NOT NULL,
  `smaPrice` double NOT NULL,
  `smaStorage` int(11) NOT NULL,
  `smaBattery` int(11) NOT NULL,
  `smaRAM` int(11) NOT NULL,
  `smaResolution` varchar(255) NOT NULL,
  `smaCPU` varchar(255) DEFAULT NULL,
  `smaClockSpeed` double DEFAULT NULL,
  `smaThreads` double DEFAULT NULL,
  `fkConstructor` int(11) DEFAULT NULL,
  `fkOS` int(11) DEFAULT NULL,
  `fkProvider` int(11) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

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
  ADD PRIMARY KEY (`idSmartphone`),
  ADD KEY `fkConstructor` (`fkConstructor`),
  ADD KEY `fkOS` (`fkOS`),
  ADD KEY `fkProvider` (`fkProvider`);

--
-- AUTO_INCREMENT for dumped tables
--

--
-- AUTO_INCREMENT for table `t_brand`
--
ALTER TABLE `t_brand`
  MODIFY `idBrand` int(11) NOT NULL AUTO_INCREMENT;

--
-- AUTO_INCREMENT for table `t_constructor`
--
ALTER TABLE `t_constructor`
  MODIFY `idConstructor` int(11) NOT NULL AUTO_INCREMENT;

--
-- AUTO_INCREMENT for table `t_os`
--
ALTER TABLE `t_os`
  MODIFY `idOS` int(11) NOT NULL AUTO_INCREMENT;

--
-- AUTO_INCREMENT for table `t_provider`
--
ALTER TABLE `t_provider`
  MODIFY `idProvider` int(11) NOT NULL AUTO_INCREMENT;

--
-- AUTO_INCREMENT for table `t_smartphone`
--
ALTER TABLE `t_smartphone`
  MODIFY `idSmartphone` int(11) NOT NULL AUTO_INCREMENT;

--
-- Constraints for dumped tables
--

--
-- Constraints for table `t_brand`
--
ALTER TABLE `t_brand`
  ADD CONSTRAINT `fk_t_brand` FOREIGN KEY (`fkOS`) REFERENCES `t_os` (`idOS`);

--
-- Constraints for table `t_smartphone`
--
ALTER TABLE `t_smartphone`
  ADD CONSTRAINT `t_smartphone_ibfk_1` FOREIGN KEY (`fkConstructor`) REFERENCES `t_constructor` (`idConstructor`),
  ADD CONSTRAINT `t_smartphone_ibfk_2` FOREIGN KEY (`fkOS`) REFERENCES `t_os` (`idOS`),
  ADD CONSTRAINT `t_smartphone_ibfk_3` FOREIGN KEY (`fkProvider`) REFERENCES `t_provider` (`idProvider`);
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
