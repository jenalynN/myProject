-- phpMyAdmin SQL Dump
-- version 4.6.5.2
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Generation Time: Aug 12, 2017 at 07:55 PM
-- Server version: 10.1.21-MariaDB
-- PHP Version: 5.6.30

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
-- Table structure for table `tb_asset`
--

CREATE TABLE `tb_asset` (
  `assetID` int(11) NOT NULL,
  `motorID` int(11) NOT NULL,
  `houseID` int(11) NOT NULL,
  `status` varchar(50) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Table structure for table `tb_costumer`
--

CREATE TABLE `tb_costumer` (
  `customerID` int(11) NOT NULL,
  `F_name` varchar(50) NOT NULL,
  `L_name` varchar(50) NOT NULL,
  `age` int(11) NOT NULL,
  `address` varchar(50) NOT NULL,
  `gender` varchar(50) NOT NULL,
  `contactNo` int(11) NOT NULL,
  `email` varchar(50) NOT NULL,
  `ID_provided` varchar(30) NOT NULL,
  `ID_number` varchar(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `tb_costumer`
--

INSERT INTO `tb_costumer` (`customerID`, `F_name`, `L_name`, `age`, `address`, `gender`, `contactNo`, `email`, `ID_provided`, `ID_number`) VALUES
(7, '', '', 0, '', '', 0, '', '2', ''),
(8, 'rd', 'brd', 21, '', 'female', 87687654, 'vevelyn@yahoo.com', '2', 'fdxcx');

-- --------------------------------------------------------

--
-- Table structure for table `tb_house`
--

CREATE TABLE `tb_house` (
  `houseID` int(11) NOT NULL,
  `houseNo` int(11) NOT NULL,
  `picture` varchar(50) NOT NULL,
  `rate` float NOT NULL,
  `houseName` varchar(50) NOT NULL,
  `bedRoom` int(11) NOT NULL,
  `bathRoom` int(11) NOT NULL,
  `area` float NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Table structure for table `tb_motor`
--

CREATE TABLE `tb_motor` (
  `motorID` int(11) NOT NULL,
  `plateNo` varchar(50) NOT NULL,
  `picture` varchar(50) NOT NULL,
  `brand` varchar(50) NOT NULL,
  `type` varchar(50) NOT NULL,
  `rate` float NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Table structure for table `tb_receipts`
--

CREATE TABLE `tb_receipts` (
  `receiptID` int(11) NOT NULL,
  `receiversName` varchar(50) NOT NULL,
  `receiversMobile` int(15) NOT NULL,
  `sendersName` varchar(50) NOT NULL,
  `sendersMobile` int(15) NOT NULL,
  `transactionCode` varchar(50) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Table structure for table `tb_reservation`
--

CREATE TABLE `tb_reservation` (
  `reservationID` int(11) NOT NULL,
  `customerID` int(11) NOT NULL,
  `assetID` int(11) NOT NULL,
  `startDate` date NOT NULL,
  `endDate` date NOT NULL,
  `status` varchar(50) NOT NULL,
  `agreement` tinyint(1) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Table structure for table `typeofid`
--

CREATE TABLE `typeofid` (
  `id` int(11) NOT NULL,
  `type` varchar(30) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `typeofid`
--

INSERT INTO `typeofid` (`id`, `type`) VALUES
(2, 'SSS'),
(3, 'Passport');

--
-- Indexes for dumped tables
--

--
-- Indexes for table `tb_asset`
--
ALTER TABLE `tb_asset`
  ADD PRIMARY KEY (`assetID`),
  ADD KEY `houseID` (`houseID`),
  ADD KEY `motorID` (`motorID`);

--
-- Indexes for table `tb_costumer`
--
ALTER TABLE `tb_costumer`
  ADD PRIMARY KEY (`customerID`);

--
-- Indexes for table `tb_house`
--
ALTER TABLE `tb_house`
  ADD PRIMARY KEY (`houseID`);

--
-- Indexes for table `tb_motor`
--
ALTER TABLE `tb_motor`
  ADD PRIMARY KEY (`motorID`);

--
-- Indexes for table `tb_reservation`
--
ALTER TABLE `tb_reservation`
  ADD PRIMARY KEY (`reservationID`),
  ADD KEY `customerID` (`customerID`),
  ADD KEY `assetID` (`assetID`),
  ADD KEY `assetID_2` (`assetID`);

--
-- Indexes for table `typeofid`
--
ALTER TABLE `typeofid`
  ADD PRIMARY KEY (`id`);

--
-- AUTO_INCREMENT for dumped tables
--

--
-- AUTO_INCREMENT for table `tb_asset`
--
ALTER TABLE `tb_asset`
  MODIFY `assetID` int(11) NOT NULL AUTO_INCREMENT;
--
-- AUTO_INCREMENT for table `tb_costumer`
--
ALTER TABLE `tb_costumer`
  MODIFY `customerID` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=9;
--
-- AUTO_INCREMENT for table `tb_house`
--
ALTER TABLE `tb_house`
  MODIFY `houseID` int(11) NOT NULL AUTO_INCREMENT;
--
-- AUTO_INCREMENT for table `tb_motor`
--
ALTER TABLE `tb_motor`
  MODIFY `motorID` int(11) NOT NULL AUTO_INCREMENT;
--
-- AUTO_INCREMENT for table `tb_reservation`
--
ALTER TABLE `tb_reservation`
  MODIFY `reservationID` int(11) NOT NULL AUTO_INCREMENT;
--
-- AUTO_INCREMENT for table `typeofid`
--
ALTER TABLE `typeofid`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=4;
--
-- Constraints for dumped tables
--

--
-- Constraints for table `tb_asset`
--
ALTER TABLE `tb_asset`
  ADD CONSTRAINT `tb_asset_ibfk_1` FOREIGN KEY (`houseID`) REFERENCES `tb_house` (`houseID`) ON DELETE NO ACTION ON UPDATE NO ACTION,
  ADD CONSTRAINT `tb_asset_ibfk_2` FOREIGN KEY (`motorID`) REFERENCES `tb_motor` (`motorID`) ON DELETE NO ACTION ON UPDATE NO ACTION;

--
-- Constraints for table `tb_reservation`
--
ALTER TABLE `tb_reservation`
  ADD CONSTRAINT `tb_reservation_ibfk_1` FOREIGN KEY (`customerID`) REFERENCES `tb_costumer` (`customerID`) ON DELETE NO ACTION ON UPDATE NO ACTION,
  ADD CONSTRAINT `tb_reservation_ibfk_2` FOREIGN KEY (`assetID`) REFERENCES `tb_asset` (`assetID`) ON DELETE NO ACTION ON UPDATE NO ACTION;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
