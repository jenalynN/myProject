-- phpMyAdmin SQL Dump
-- version 4.5.1
-- http://www.phpmyadmin.net
--
-- Host: 127.0.0.1
-- Generation Time: Aug 26, 2017 at 08:36 AM
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

-- --------------------------------------------------------

--
-- Table structure for table `motorbrand`
--

DROP TABLE IF EXISTS `motorbrand`;
CREATE TABLE IF NOT EXISTS `motorbrand` (
  `id` int(5) NOT NULL AUTO_INCREMENT,
  `motorBrand` varchar(50) NOT NULL,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB AUTO_INCREMENT=5 DEFAULT CHARSET=latin1;

--
-- Dumping data for table `motorbrand`
--

INSERT INTO `motorbrand` (`id`, `motorBrand`) VALUES
(1, 'Honda'),
(2, 'Yamaha'),
(3, 'Suzuki'),
(4, 'Kawasaki');

-- --------------------------------------------------------

--
-- Table structure for table `motortype`
--

DROP TABLE IF EXISTS `motortype`;
CREATE TABLE IF NOT EXISTS `motortype` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `motorType` varchar(50) NOT NULL,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB AUTO_INCREMENT=2 DEFAULT CHARSET=latin1;

--
-- Dumping data for table `motortype`
--

INSERT INTO `motortype` (`id`, `motorType`) VALUES
(1, 'Scooter');

-- --------------------------------------------------------

--
-- Table structure for table `tb_asset`
--

DROP TABLE IF EXISTS `tb_asset`;
CREATE TABLE IF NOT EXISTS `tb_asset` (
  `assetID` int(11) NOT NULL AUTO_INCREMENT,
  `type` varchar(50) NOT NULL,
  PRIMARY KEY (`assetID`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Table structure for table `tb_costumer`
--

DROP TABLE IF EXISTS `tb_costumer`;
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
) ENGINE=InnoDB AUTO_INCREMENT=3 DEFAULT CHARSET=latin1;

--
-- Dumping data for table `tb_costumer`
--

INSERT INTO `tb_costumer` (`customerID`, `F_name`, `L_name`, `age`, `address`, `birthDate`, `gender`, `contactNo`, `email`, `ID_provided`, `ID_number`) VALUES
(1, '', '', 0, '', '0000-00-00', 'gender', 0, '', 0, 0),
(2, '', '', 0, '', '0000-00-00', 'gender', 0, '', 0, 0);

-- --------------------------------------------------------

--
-- Table structure for table `tb_house`
--

DROP TABLE IF EXISTS `tb_house`;
CREATE TABLE IF NOT EXISTS `tb_house` (
  `HouseID` int(11) NOT NULL AUTO_INCREMENT,
  `HouseNo` int(11) NOT NULL,
  `Picture` varchar(50) NOT NULL,
  `Rate` float NOT NULL,
  `HouseName` varchar(50) NOT NULL,
  `BedRoom` int(11) NOT NULL,
  `BathRoom` int(11) NOT NULL,
  `Area` float NOT NULL,
  PRIMARY KEY (`HouseID`)
) ENGINE=InnoDB AUTO_INCREMENT=7 DEFAULT CHARSET=latin1;

--
-- Dumping data for table `tb_house`
--

INSERT INTO `tb_house` (`HouseID`, `HouseNo`, `Picture`, `Rate`, `HouseName`, `BedRoom`, `BathRoom`, `Area`) VALUES
(1, 1, 'img/l.JPG', 1500, 'Rosita1', 2, 1, 20),
(2, 2, 'img/n.JPG', 1500, 'Rosita2', 2, 1, 20),
(3, 3, 'img/p.JPG', 1000, 'Rosita3', 1, 1, 20),
(4, 4, 'img/p.JPG', 1000, 'Rosita4', 1, 1, 20),
(6, 5, 'img/o.JPG', 1000, 'Rosita5', 1, 1, 20);

-- --------------------------------------------------------

--
-- Table structure for table `tb_login`
--

DROP TABLE IF EXISTS `tb_login`;
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

DROP TABLE IF EXISTS `tb_motor`;
CREATE TABLE IF NOT EXISTS `tb_motor` (
  `motorID` int(11) NOT NULL AUTO_INCREMENT,
  `plateNo` varchar(50) NOT NULL,
  `picture` varchar(50) NOT NULL,
  `brand` varchar(50) NOT NULL,
  `type` varchar(50) NOT NULL,
  `rate` float NOT NULL,
  PRIMARY KEY (`motorID`)
) ENGINE=InnoDB AUTO_INCREMENT=7 DEFAULT CHARSET=latin1;

--
-- Dumping data for table `tb_motor`
--

INSERT INTO `tb_motor` (`motorID`, `plateNo`, `picture`, `brand`, `type`, `rate`) VALUES
(1, 'ABC 1234', 'img/rusi.jpg', 'Suzuki', 'Scooter', 500),
(2, 'AAA 1678', 'img/Yamaha.jpg', 'Yamaha', 'Scooter', 600),
(3, 'LTE 1345', 'img/honda.jpg', 'Honda', 'Scooter', 450),
(4, 'SBA 1234', 'img/Yamaha-Mio-GT.jpg', 'Kawasaki', 'Scooter', 650),
(5, 'SBA 456', 'img/asd.jpg', 'Yamaha', 'Scooter', 500);

-- --------------------------------------------------------

--
-- Table structure for table `tb_reservation`
--

DROP TABLE IF EXISTS `tb_reservation`;
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
(2, 0, 0, '0000-00-00', '0000-00-00', 'Confirm', 0);

-- --------------------------------------------------------

--
-- Table structure for table `typeofid`
--

DROP TABLE IF EXISTS `typeofid`;
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

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
