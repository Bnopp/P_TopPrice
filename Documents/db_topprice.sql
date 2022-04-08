-- phpMyAdmin SQL Dump
-- version 5.0.4
-- https://www.phpmyadmin.net/
--
-- Hôte : localhost
-- Généré le : ven. 08 avr. 2022 à 09:13
-- Version du serveur :  5.7.11
-- Version de PHP : 8.0.1

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Base de données : `db_topprice`
--

-- --------------------------------------------------------

--
-- Structure de la table `t_brand`
--

CREATE TABLE `t_brand` (
  `idBrand` int(11) NOT NULL,
  `braName` varchar(255) NOT NULL,
  `fkOS` int(11) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Structure de la table `t_constructor`
--

CREATE TABLE `t_constructor` (
  `idConstructor` int(11) NOT NULL,
  `conName` varchar(255) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Structure de la table `t_os`
--

CREATE TABLE `t_os` (
  `idOS` int(11) NOT NULL,
  `osName` varchar(255) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Structure de la table `t_provider`
--

CREATE TABLE `t_provider` (
  `idProvider` int(11) NOT NULL,
  `proName` varchar(255) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Structure de la table `t_smartphone`
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
-- Index pour les tables déchargées
--

--
-- Index pour la table `t_brand`
--
ALTER TABLE `t_brand`
  ADD PRIMARY KEY (`idBrand`),
  ADD KEY `fk_t_brand` (`fkOS`);

--
-- Index pour la table `t_constructor`
--
ALTER TABLE `t_constructor`
  ADD PRIMARY KEY (`idConstructor`);

--
-- Index pour la table `t_os`
--
ALTER TABLE `t_os`
  ADD PRIMARY KEY (`idOS`);

--
-- Index pour la table `t_provider`
--
ALTER TABLE `t_provider`
  ADD PRIMARY KEY (`idProvider`);

--
-- Index pour la table `t_smartphone`
--
ALTER TABLE `t_smartphone`
  ADD PRIMARY KEY (`idSmartphone`),
  ADD KEY `fkConstructor` (`fkConstructor`),
  ADD KEY `fkOS` (`fkOS`),
  ADD KEY `fkProvider` (`fkProvider`);

--
-- AUTO_INCREMENT pour les tables déchargées
--

--
-- AUTO_INCREMENT pour la table `t_brand`
--
ALTER TABLE `t_brand`
  MODIFY `idBrand` int(11) NOT NULL AUTO_INCREMENT;

--
-- AUTO_INCREMENT pour la table `t_constructor`
--
ALTER TABLE `t_constructor`
  MODIFY `idConstructor` int(11) NOT NULL AUTO_INCREMENT;

--
-- AUTO_INCREMENT pour la table `t_os`
--
ALTER TABLE `t_os`
  MODIFY `idOS` int(11) NOT NULL AUTO_INCREMENT;

--
-- AUTO_INCREMENT pour la table `t_provider`
--
ALTER TABLE `t_provider`
  MODIFY `idProvider` int(11) NOT NULL AUTO_INCREMENT;

--
-- AUTO_INCREMENT pour la table `t_smartphone`
--
ALTER TABLE `t_smartphone`
  MODIFY `idSmartphone` int(11) NOT NULL AUTO_INCREMENT;

--
-- Contraintes pour les tables déchargées
--

--
-- Contraintes pour la table `t_brand`
--
ALTER TABLE `t_brand`
  ADD CONSTRAINT `fk_t_brand` FOREIGN KEY (`fkOS`) REFERENCES `t_os` (`idOS`);

--
-- Contraintes pour la table `t_smartphone`
--
ALTER TABLE `t_smartphone`
  ADD CONSTRAINT `t_smartphone_ibfk_1` FOREIGN KEY (`fkConstructor`) REFERENCES `t_constructor` (`idConstructor`),
  ADD CONSTRAINT `t_smartphone_ibfk_2` FOREIGN KEY (`fkOS`) REFERENCES `t_os` (`idOS`),
  ADD CONSTRAINT `t_smartphone_ibfk_3` FOREIGN KEY (`fkProvider`) REFERENCES `t_provider` (`idProvider`);
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
