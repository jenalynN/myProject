-- phpMyAdmin SQL Dump
-- version 4.6.5.2
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Generation Time: Sep 29, 2018 at 06:45 PM
-- Server version: 10.1.21-MariaDB
-- PHP Version: 5.6.30

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `db_poshconceptstorefinal`
--

-- --------------------------------------------------------

--
-- Table structure for table `tbl_brandpartner`
--

CREATE TABLE `tbl_brandpartner` (
  `col_useraccountsid` int(11) NOT NULL,
  `col_brandname` varchar(50) NOT NULL,
  `col_brandaddress` varchar(50) NOT NULL,
  `col_brandcontactnum` varchar(50) NOT NULL,
  `col_brandemail` varchar(40) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `tbl_brandpartner`
--

INSERT INTO `tbl_brandpartner` (`col_useraccountsid`, `col_brandname`, `col_brandaddress`, `col_brandcontactnum`, `col_brandemail`) VALUES
(19, 'adidas', 'Talamban', '09987654321', ''),
(20, 'nike', 'IBABAO, MANDAUE', '09987654321', ''),
(21, 'H&M', 'cebu', '223311', ''),
(23, 'Metro Sunnies', 'Apas', '09145785324', 'metrosunnies@gmail.com'),
(24, 'Bench', 'Cogon', '09784567325', 'bench@gmail.com'),
(25, 'Penshoppe', 'Mambajao', '09675432189', 'penshoppe@gmail.com'),
(26, 'Parfum De Mimi', 'Carmen', '09756743998', 'parfum@gmail.com');

-- --------------------------------------------------------

--
-- Table structure for table `tbl_category`
--

CREATE TABLE `tbl_category` (
  `col_categoryid` int(11) NOT NULL,
  `col_useraccountsid` int(11) NOT NULL,
  `col_categoryname` varchar(50) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `tbl_category`
--

INSERT INTO `tbl_category` (`col_categoryid`, `col_useraccountsid`, `col_categoryname`) VALUES
(3, 19, 'shoes'),
(4, 19, 'jacket'),
(5, 19, 'shirt'),
(6, 20, 'shoes'),
(7, 20, 'glasses'),
(8, 20, 'hat'),
(9, 21, 'makeup'),
(10, 21, 'bag'),
(11, 23, 'Specs'),
(12, 24, 'shirt'),
(13, 25, 'shirt'),
(14, 26, 'dress');

-- --------------------------------------------------------

--
-- Table structure for table `tbl_damage`
--

CREATE TABLE `tbl_damage` (
  `col_damageitemid` int(11) NOT NULL,
  `col_orderid` int(11) NOT NULL,
  `col_transactionid` int(11) NOT NULL,
  `col_reason` varchar(250) NOT NULL,
  `col_status` varchar(250) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `tbl_damage`
--

INSERT INTO `tbl_damage` (`col_damageitemid`, `col_orderid`, `col_transactionid`, `col_reason`, `col_status`) VALUES
(1, 2, 2, '', 'pending-change'),
(2, 2, 2, 'asd', 'pending-change');

-- --------------------------------------------------------

--
-- Table structure for table `tbl_logs`
--

CREATE TABLE `tbl_logs` (
  `col_logid` int(11) NOT NULL,
  `col_activity` varchar(250) NOT NULL,
  `col_dateofactivity` date NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Table structure for table `tbl_order`
--

CREATE TABLE `tbl_order` (
  `col_orderid` int(11) NOT NULL,
  `col_transactionid` int(11) NOT NULL,
  `col_productid` int(11) NOT NULL,
  `col_staticprice` int(11) NOT NULL,
  `col_quantitybought` int(11) NOT NULL,
  `col_subtotal` int(11) NOT NULL,
  `col_orderstatus` varchar(30) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1 ROW_FORMAT=COMPACT;

--
-- Dumping data for table `tbl_order`
--

INSERT INTO `tbl_order` (`col_orderid`, `col_transactionid`, `col_productid`, `col_staticprice`, `col_quantitybought`, `col_subtotal`, `col_orderstatus`) VALUES
(1, 2, 1, 0, 2, 4000, 'unfinished'),
(2, 2, 2, 0, 1, 1000, 'unfinished'),
(3, 2, 3, 0, 3, 9000, 'unfinished'),
(4, 2, 5, 0, 2, 1998, 'unfinished'),
(5, 3, 3, 0, 1, 3000, 'unfinished'),
(6, 3, 4, 0, 1, 2000, 'unfinished'),
(7, 4, 5, 0, 3, 2997, 'unfinished'),
(8, 5, 2, 0, 2, 2000, 'unfinished'),
(9, 6, 1, 0, 2, 2000, 'unfinished'),
(10, 7, 1, 0, 5, 10000, 'unfinished'),
(11, 8, 1, 0, 6, 12000, 'unfinished');

-- --------------------------------------------------------

--
-- Table structure for table `tbl_product`
--

CREATE TABLE `tbl_product` (
  `col_productid` int(11) NOT NULL,
  `col_productcode` varchar(35) NOT NULL,
  `col_productname` varchar(150) NOT NULL,
  `col_productprice` int(11) NOT NULL,
  `col_useraccountsid` int(11) NOT NULL,
  `col_categoryid` int(11) NOT NULL,
  `col_status` varchar(50) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `tbl_product`
--

INSERT INTO `tbl_product` (`col_productid`, `col_productcode`, `col_productname`, `col_productprice`, `col_useraccountsid`, `col_categoryid`, `col_status`) VALUES
(1, 'ADSHO001', 'runner', 2000, 19, 3, 'unarchived'),
(2, 'ADSHO002', 'hiker', 1000, 19, 3, 'unarchived'),
(3, 'NISHO001', 'sprinter', 3000, 20, 3, 'unarchived'),
(4, 'NISHO002', 'trekker', 2000, 20, 3, 'unarchived'),
(5, 'HMMAK001', 'AntiAging', 999, 21, 9, 'unarchived'),
(6, 'MSSH001', 'Logan Specs', 400, 23, 11, 'unarchived'),
(7, 'MSSH002', 'Emerson Specs', 350, 23, 11, 'unarchived'),
(8, 'BSH006', 'Urban Shirt', 250, 24, 13, 'unarchived'),
(9, 'BSH0032', 'Printed Tee', 440, 24, 13, 'unarchived'),
(10, 'PENSH0088', 'Tribal', 250, 25, 13, 'unarchived'),
(11, 'PENSH003', 'Tee', 450, 25, 13, 'unarchived'),
(12, 'PDMSH0067', 'Cotillon Dress', 560, 26, 14, 'unarchived'),
(13, 'PDMSH0033', 'Sheath Dress', 660, 26, 14, 'unarchived');

-- --------------------------------------------------------

--
-- Table structure for table `tbl_transaction`
--

CREATE TABLE `tbl_transaction` (
  `col_transactionid` int(11) NOT NULL,
  `col_transactioncode` varchar(20) NOT NULL,
  `col_useraccountsid` int(11) NOT NULL,
  `col_totalprice` int(11) NOT NULL,
  `col_dateofpurchase` date NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1 ROW_FORMAT=COMPACT;

--
-- Dumping data for table `tbl_transaction`
--

INSERT INTO `tbl_transaction` (`col_transactionid`, `col_transactioncode`, `col_useraccountsid`, `col_totalprice`, `col_dateofpurchase`) VALUES
(2, 'PCS02', 22, 15998, '2018-09-16'),
(3, 'PCS03', 22, 5000, '2018-09-17'),
(4, 'PCS04', 22, 2997, '2018-09-18'),
(5, 'PCS05', 22, 2000, '2018-09-19'),
(6, 'PCS06', 22, 2000, '2018-09-20'),
(7, 'PCS07', 22, 10000, '2018-09-21'),
(8, 'PCS08', 22, 0, '2018-09-22'),
(9, 'PCS09', 22, 0, '2018-09-23'),
(10, 'PCS010', 22, 0, '2018-09-23'),
(11, 'PCS011', 22, 0, '2018-09-23'),
(12, 'PCS012', 22, 0, '2018-09-23'),
(13, 'PCS013', 22, 0, '2018-09-23'),
(14, 'PCS014', 22, 0, '2018-09-23'),
(15, 'PCS015', 22, 0, '2018-09-23'),
(16, 'PCS016', 22, 0, '2018-09-23'),
(17, 'PCS017', 22, 0, '2018-09-23'),
(18, 'PCS018', 22, 0, '2018-09-23'),
(19, 'PCS019', 22, 0, '2018-09-23'),
(20, 'PCS020', 22, 0, '2018-09-23'),
(21, 'PCS021', 22, 0, '2018-09-23'),
(22, 'PCS022', 22, 0, '2018-09-23'),
(23, 'PCS023', 22, 0, '2018-09-23'),
(24, 'PCS024', 22, 0, '2018-09-23'),
(25, 'PCS025', 22, 0, '2018-09-23');

-- --------------------------------------------------------

--
-- Table structure for table `tbl_useraccounts`
--

CREATE TABLE `tbl_useraccounts` (
  `col_useraccountsid` int(11) NOT NULL,
  `col_user` varchar(20) NOT NULL,
  `col_password` varchar(20) NOT NULL,
  `col_lastname` varchar(50) NOT NULL,
  `col_firstname` varchar(50) NOT NULL,
  `col_middlename` varchar(50) NOT NULL,
  `col_address` varchar(50) NOT NULL,
  `col_dateofbirth` date NOT NULL,
  `col_gender` varchar(50) NOT NULL,
  `col_contactnum` varchar(50) NOT NULL,
  `col_usertypeid` int(11) NOT NULL,
  `col_status` varchar(50) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `tbl_useraccounts`
--

INSERT INTO `tbl_useraccounts` (`col_useraccountsid`, `col_user`, `col_password`, `col_lastname`, `col_firstname`, `col_middlename`, `col_address`, `col_dateofbirth`, `col_gender`, `col_contactnum`, `col_usertypeid`, `col_status`) VALUES
(17, 'admin', 'admin', 'admin', 'admin', 'admin', 'admin', '2018-09-05', 'Male', 'admin', 1, 'unarchived'),
(18, 'cashier', 'cashier', 'naldoza', 'jenalyn', 'bonior', 'bohol', '2018-09-05', 'Female', '2398899', 2, 'unarchived'),
(19, 'adidas', '123', 'cahimat', 'jurix', 'moana', 'cebu', '2018-09-04', 'Male', '123321', 3, 'unarchived'),
(20, 'nike', '123', 'salva', 'ryanjie', 'a', 'CDO', '2018-09-02', 'Male', '1234567', 3, 'unarchived'),
(21, 'HnM', '123', 'cruz', 'john', 'doe', 'street', '2018-09-01', 'Male', '12345678', 3, 'unarchived'),
(22, 'anne', 'asd', 'tan', 'marie', 'anne', 'ads1172', '2018-09-18', 'Female', '1234567', 2, 'unarchived'),
(23, 'Metro Sunnies', '123', 'Moradas', 'Carla', 'Bacus', 'Lahug', '1989-09-05', 'Female', '09785645312', 3, 'unarchived'),
(24, 'Bench', '123', 'Chan', 'Ben', 'Cruz', 'CDO', '1983-12-25', 'Male', '09234568123', 3, 'unarchived'),
(25, 'Penshoppe', '123', 'Pame', 'Jaymar', 'Lopez', 'Camiguin', '1986-01-06', 'Male', '09685949237', 3, 'unarchived'),
(26, 'Parfum De Mimi', '123', 'Lopez', 'Charice', 'Pempengco', 'Carmen Cebu', '1979-06-06', 'Female', '09562490584', 3, 'unarchived');

-- --------------------------------------------------------

--
-- Table structure for table `tbl_usertype`
--

CREATE TABLE `tbl_usertype` (
  `col_usertypeid` int(11) NOT NULL,
  `col_userrole` varchar(25) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `tbl_usertype`
--

INSERT INTO `tbl_usertype` (`col_usertypeid`, `col_userrole`) VALUES
(1, 'Admin'),
(2, 'Cashier'),
(3, 'Brandpartner');

--
-- Indexes for dumped tables
--

--
-- Indexes for table `tbl_brandpartner`
--
ALTER TABLE `tbl_brandpartner`
  ADD PRIMARY KEY (`col_useraccountsid`);

--
-- Indexes for table `tbl_category`
--
ALTER TABLE `tbl_category`
  ADD PRIMARY KEY (`col_categoryid`),
  ADD KEY `col_useraccountsid` (`col_useraccountsid`);

--
-- Indexes for table `tbl_damage`
--
ALTER TABLE `tbl_damage`
  ADD PRIMARY KEY (`col_damageitemid`),
  ADD KEY `col_categoryid` (`col_orderid`),
  ADD KEY `col_productid` (`col_orderid`);

--
-- Indexes for table `tbl_logs`
--
ALTER TABLE `tbl_logs`
  ADD PRIMARY KEY (`col_logid`);

--
-- Indexes for table `tbl_order`
--
ALTER TABLE `tbl_order`
  ADD PRIMARY KEY (`col_orderid`),
  ADD KEY `col_productid` (`col_productid`),
  ADD KEY `col_transactionid` (`col_transactionid`);

--
-- Indexes for table `tbl_product`
--
ALTER TABLE `tbl_product`
  ADD PRIMARY KEY (`col_productid`),
  ADD KEY `col_brandid` (`col_useraccountsid`),
  ADD KEY `col_brandid_2` (`col_useraccountsid`),
  ADD KEY `col_categoryid` (`col_categoryid`);

--
-- Indexes for table `tbl_transaction`
--
ALTER TABLE `tbl_transaction`
  ADD PRIMARY KEY (`col_transactionid`),
  ADD KEY `col_useraccountsid` (`col_useraccountsid`);

--
-- Indexes for table `tbl_useraccounts`
--
ALTER TABLE `tbl_useraccounts`
  ADD PRIMARY KEY (`col_useraccountsid`),
  ADD KEY `col_usertypeid` (`col_usertypeid`);

--
-- Indexes for table `tbl_usertype`
--
ALTER TABLE `tbl_usertype`
  ADD PRIMARY KEY (`col_usertypeid`);

--
-- AUTO_INCREMENT for dumped tables
--

--
-- AUTO_INCREMENT for table `tbl_brandpartner`
--
ALTER TABLE `tbl_brandpartner`
  MODIFY `col_useraccountsid` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=27;
--
-- AUTO_INCREMENT for table `tbl_category`
--
ALTER TABLE `tbl_category`
  MODIFY `col_categoryid` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=15;
--
-- AUTO_INCREMENT for table `tbl_damage`
--
ALTER TABLE `tbl_damage`
  MODIFY `col_damageitemid` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=3;
--
-- AUTO_INCREMENT for table `tbl_logs`
--
ALTER TABLE `tbl_logs`
  MODIFY `col_logid` int(11) NOT NULL AUTO_INCREMENT;
--
-- AUTO_INCREMENT for table `tbl_order`
--
ALTER TABLE `tbl_order`
  MODIFY `col_orderid` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=12;
--
-- AUTO_INCREMENT for table `tbl_product`
--
ALTER TABLE `tbl_product`
  MODIFY `col_productid` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=14;
--
-- AUTO_INCREMENT for table `tbl_transaction`
--
ALTER TABLE `tbl_transaction`
  MODIFY `col_transactionid` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=26;
--
-- AUTO_INCREMENT for table `tbl_useraccounts`
--
ALTER TABLE `tbl_useraccounts`
  MODIFY `col_useraccountsid` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=27;
--
-- Constraints for dumped tables
--

--
-- Constraints for table `tbl_brandpartner`
--
ALTER TABLE `tbl_brandpartner`
  ADD CONSTRAINT `tbl_brandpartner_ibfk_1` FOREIGN KEY (`col_useraccountsid`) REFERENCES `tbl_useraccounts` (`col_useraccountsid`);

--
-- Constraints for table `tbl_category`
--
ALTER TABLE `tbl_category`
  ADD CONSTRAINT `tbl_category_ibfk_1` FOREIGN KEY (`col_useraccountsid`) REFERENCES `tbl_brandpartner` (`col_useraccountsid`);

--
-- Constraints for table `tbl_damage`
--
ALTER TABLE `tbl_damage`
  ADD CONSTRAINT `tbl_damage_ibfk_1` FOREIGN KEY (`col_orderid`) REFERENCES `tbl_order` (`col_orderid`);

--
-- Constraints for table `tbl_order`
--
ALTER TABLE `tbl_order`
  ADD CONSTRAINT `tbl_order_ibfk_3` FOREIGN KEY (`col_transactionid`) REFERENCES `tbl_transaction` (`col_transactionid`) ON DELETE CASCADE ON UPDATE CASCADE,
  ADD CONSTRAINT `tbl_order_ibfk_4` FOREIGN KEY (`col_productid`) REFERENCES `tbl_product` (`col_productid`);

--
-- Constraints for table `tbl_product`
--
ALTER TABLE `tbl_product`
  ADD CONSTRAINT `tbl_product_ibfk_1` FOREIGN KEY (`col_useraccountsid`) REFERENCES `tbl_useraccounts` (`col_useraccountsid`),
  ADD CONSTRAINT `tbl_product_ibfk_2` FOREIGN KEY (`col_categoryid`) REFERENCES `tbl_category` (`col_categoryid`);

--
-- Constraints for table `tbl_transaction`
--
ALTER TABLE `tbl_transaction`
  ADD CONSTRAINT `tbl_transaction_ibfk_1` FOREIGN KEY (`col_useraccountsid`) REFERENCES `tbl_useraccounts` (`col_useraccountsid`);

--
-- Constraints for table `tbl_useraccounts`
--
ALTER TABLE `tbl_useraccounts`
  ADD CONSTRAINT `tbl_useraccounts_ibfk_1` FOREIGN KEY (`col_usertypeid`) REFERENCES `tbl_usertype` (`col_usertypeid`);

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
