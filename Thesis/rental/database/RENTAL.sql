-- phpMyAdmin SQL Dump
-- version 4.5.1
-- http://www.phpmyadmin.net
--
-- Host: 127.0.0.1
-- Generation Time: Aug 25, 2017 at 04:27 PM
-- Server version: 10.1.13-MariaDB
-- PHP Version: 5.5.37

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `db_rental`
--
DROP DATABASE `db_rental`;
CREATE DATABASE IF NOT EXISTS `db_rental` DEFAULT CHARACTER SET latin1 COLLATE latin1_swedish_ci;
USE `db_rental`;

-- --------------------------------------------------------

--
-- Table structure for table `tb_asset`
--

CREATE TABLE IF NOT EXISTS `tb_asset` (
  `assetID` int(11) NOT NULL AUTO_INCREMENT,
  `type` varchar(50) NOT NULL,
  PRIMARY KEY (`assetID`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Table structure for table `tb_costumer`
--

CREATE TABLE IF NOT EXISTS `tb_costumer` (
  `customerID` int(11) NOT NULL AUTO_INCREMENT,
  `F_name` varchar(50) NOT NULL,
  `L_name` varchar(50) NOT NULL,
  `age` int(11) NOT NULL,
  `address` varchar(50) NOT NULL,
  `birthDate` date NOT NULL,
  `gender` varchar(50) NOT NULL,
  `contactNo` int(11) NOT NULL,
  `email` varchar(50) NOT NULL,
  `ID_provided` int(11) NOT NULL,
  `ID_number` int(11) NOT NULL,
  PRIMARY KEY (`customerID`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Table structure for table `tb_house`
--

CREATE TABLE IF NOT EXISTS `tb_house` (
  `HouseID` int(11) NOT NULL,
  `HouseNo` int(11) NOT NULL,
  `Picture` varchar(50) NOT NULL,
  `Rate` float NOT NULL,
  `HouseName` varchar(50) NOT NULL,
  `BedRoom` int(11) NOT NULL,
  `BathRoom` int(11) NOT NULL,
  `Area` float NOT NULL,
  PRIMARY KEY (`HouseID`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Table structure for table `tb_login`
--

CREATE TABLE IF NOT EXISTS `tb_login` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `uname` varchar(50) NOT NULL,
  `pass` varchar(50) NOT NULL,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB AUTO_INCREMENT=2 DEFAULT CHARSET=latin1;

--
-- Dumping data for table `tb_login`
--

INSERT INTO `tb_login` (`id`, `uname`, `pass`) VALUES
(1, 'admin', 'admin');

-- --------------------------------------------------------

--
-- Table structure for table `tb_motor`
--

CREATE TABLE IF NOT EXISTS `tb_motor` (
  `motorID` int(11) NOT NULL,
  `plateNo` varchar(50) NOT NULL,
  `picture` varchar(50) NOT NULL,
  `brand` varchar(50) NOT NULL,
  `type` varchar(50) NOT NULL,
  `rate` float NOT NULL,
  PRIMARY KEY (`motorID`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Table structure for table `tb_reservation`
--

CREATE TABLE IF NOT EXISTS `tb_reservation` (
  `reservationID` int(11) NOT NULL AUTO_INCREMENT,
  `customerID` int(11) NOT NULL,
  `assetID` int(11) NOT NULL,
  `startDate` date NOT NULL,
  `endDate` date NOT NULL,
  `status` varchar(50) NOT NULL,
  `agreement` tinyint(1) NOT NULL,
  PRIMARY KEY (`reservationID`),
  KEY `customerID` (`customerID`),
  KEY `assetID` (`assetID`),
  KEY `assetID_2` (`assetID`)
) ENGINE=InnoDB AUTO_INCREMENT=3 DEFAULT CHARSET=latin1;

--
-- Dumping data for table `tb_reservation`
--

INSERT INTO `tb_reservation` (`reservationID`, `customerID`, `assetID`, `startDate`, `endDate`, `status`, `agreement`) VALUES
(2, 0, 0, '0000-00-00', '0000-00-00', '', 0);

-- --------------------------------------------------------

--
-- Table structure for table `typeofid`
--

CREATE TABLE IF NOT EXISTS `typeofid` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `type` varchar(30) NOT NULL,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB AUTO_INCREMENT=4 DEFAULT CHARSET=latin1;

--
-- Dumping data for table `typeofid`
--

INSERT INTO `typeofid` (`id`, `type`) VALUES
(1, 'Driver License'),
(2, 'SSS'),
(3, 'Passport');

--
-- Constraints for dumped tables
--

--
-- Constraints for table `tb_house`
--
ALTER TABLE `tb_house`
  ADD CONSTRAINT `tb_house_ibfk_1` FOREIGN KEY (`HouseID`) REFERENCES `tb_asset` (`assetID`) ON DELETE CASCADE ON UPDATE CASCADE;

--
-- Constraints for table `tb_motor`
--
ALTER TABLE `tb_motor`
  ADD CONSTRAINT `tb_motor_ibfk_1` FOREIGN KEY (`motorID`) REFERENCES `tb_asset` (`assetID`) ON DELETE CASCADE ON UPDATE CASCADE;

--
-- Constraints for table `tb_reservation`
--
ALTER TABLE `tb_reservation`
  ADD CONSTRAINT `tb_reservation_ibfk_1` FOREIGN KEY (`customerID`) REFERENCES `tb_costumer` (`customerID`) ON DELETE NO ACTION ON UPDATE NO ACTION,
  ADD CONSTRAINT `tb_reservation_ibfk_2` FOREIGN KEY (`assetID`) REFERENCES `tb_asset` (`assetID`) ON DELETE NO ACTION ON UPDATE NO ACTION;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
