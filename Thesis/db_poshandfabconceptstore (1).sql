-- phpMyAdmin SQL Dump
-- version 4.6.5.2
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Generation Time: Aug 27, 2018 at 07:48 AM
-- Server version: 10.1.21-MariaDB
-- PHP Version: 5.6.30

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `db_poshandfabconceptstore`
--

-- --------------------------------------------------------

--
-- Table structure for table `tbl_adminuser`
--

CREATE TABLE `tbl_adminuser` (
  `col_adminid` int(11) NOT NULL,
  `col_adminusername` varchar(20) NOT NULL,
  `col_adminpassword` varchar(20) NOT NULL,
  `col_lastname` varchar(50) NOT NULL,
  `col_firstname` varchar(50) NOT NULL,
  `col_middlename` varchar(50) NOT NULL,
  `col_dateofbirth` date NOT NULL,
  `col_address` varchar(50) NOT NULL,
  `col_contactnum` varchar(50) NOT NULL,
  `col_gender` varchar(50) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `tbl_adminuser`
--

INSERT INTO `tbl_adminuser` (`col_adminid`, `col_adminusername`, `col_adminpassword`, `col_lastname`, `col_firstname`, `col_middlename`, `col_dateofbirth`, `col_address`, `col_contactnum`, `col_gender`) VALUES
(1, 'admin', 'admin', 'admin', 'admin', 'admin', '2018-07-04', 'admin', 'admin', 'admin');

-- --------------------------------------------------------

--
-- Table structure for table `tbl_branduser`
--

CREATE TABLE `tbl_branduser` (
  `col_brandid` int(11) NOT NULL,
  `col_brandname` varchar(50) NOT NULL,
  `col_branduser` varchar(20) NOT NULL,
  `col_brandpassword` varchar(20) NOT NULL,
  `col_lastname` varchar(50) NOT NULL,
  `col_firstname` varchar(50) NOT NULL,
  `col_middlename` varchar(50) NOT NULL,
  `col_address` varchar(50) NOT NULL,
  `col_dateofbirth` date NOT NULL,
  `col_gender` varchar(50) NOT NULL,
  `col_contactnum` varchar(50) NOT NULL,
  `col_status` varchar(50) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `tbl_branduser`
--

INSERT INTO `tbl_branduser` (`col_brandid`, `col_brandname`, `col_branduser`, `col_brandpassword`, `col_lastname`, `col_firstname`, `col_middlename`, `col_address`, `col_dateofbirth`, `col_gender`, `col_contactnum`, `col_status`) VALUES
(1, '0', 'brand', 'brand', 'brand', 'brand', 'brand', 'brand', '2018-07-04', 'brand', 'brand', 'brand'),
(2, 'samplebrand', 'samplebrand', 'samplebrand', 'samplebrand', 'samplebrand', 'samplebrand', 'samplebrand', '2018-07-04', 'samplebrand', 'samplebrand', 'unarchived');

-- --------------------------------------------------------

--
-- Table structure for table `tbl_cashieruser`
--

CREATE TABLE `tbl_cashieruser` (
  `col_cashierid` int(11) NOT NULL,
  `col_cashierusername` varchar(20) NOT NULL,
  `col_cashierpassword` varchar(20) NOT NULL,
  `col_lastname` varchar(50) NOT NULL,
  `col_firstname` varchar(50) NOT NULL,
  `col_middlename` varchar(50) NOT NULL,
  `col_dateofbirth` date NOT NULL,
  `col_gender` varchar(50) NOT NULL,
  `col_contactnum` varchar(50) NOT NULL,
  `col_status` varchar(25) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `tbl_cashieruser`
--

INSERT INTO `tbl_cashieruser` (`col_cashierid`, `col_cashierusername`, `col_cashierpassword`, `col_lastname`, `col_firstname`, `col_middlename`, `col_dateofbirth`, `col_gender`, `col_contactnum`, `col_status`) VALUES
(1, 'cashier', 'cashier', 'cashier', 'cashier', 'cashier', '2018-07-04', 'cashier', 'cashier', ''),
(3, 'samplecashier', 'samplecashier', 'samplecashier', 'samplecashier', 'samplecashier', '2018-08-22', 'samplecashier', 'samplecashier', 'unarchived'),
(4, 'samplecashier2', 'samplecashier2', 'samplecashier2', 'samplecashier2', 'samplecashier2', '2018-07-04', 'samplecashier2', 'samplecashier2', 'archived');

-- --------------------------------------------------------

--
-- Table structure for table `tbl_category`
--

CREATE TABLE `tbl_category` (
  `col_categoryid` int(11) NOT NULL,
  `col_categoryname` varchar(50) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `tbl_category`
--

INSERT INTO `tbl_category` (`col_categoryid`, `col_categoryname`) VALUES
(1, 'Shoes'),
(2, 'Cloth');

-- --------------------------------------------------------

--
-- Table structure for table `tbl_damage`
--

CREATE TABLE `tbl_damage` (
  `col_damageitemid` int(11) NOT NULL,
  `col_categoryid` int(11) NOT NULL,
  `col_brandid` int(11) NOT NULL,
  `col_productid` int(11) NOT NULL,
  `col_reason` varchar(250) NOT NULL,
  `col_status` varchar(250) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

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
  `col_brandid` int(11) NOT NULL,
  `col_categoryid` int(11) NOT NULL,
  `col_cashierid` int(11) NOT NULL,
  `col_totalprice` varchar(50) NOT NULL,
  `col_itemsold` varchar(50) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1 ROW_FORMAT=COMPACT;

-- --------------------------------------------------------

--
-- Table structure for table `tbl_product`
--

CREATE TABLE `tbl_product` (
  `col_productid` int(11) NOT NULL,
  `col_productcode` varchar(35) NOT NULL,
  `col_productprice` int(11) NOT NULL,
  `col_brandid` int(11) NOT NULL,
  `col_categoryid` int(11) NOT NULL,
  `col_status` varchar(50) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `tbl_product`
--

INSERT INTO `tbl_product` (`col_productid`, `col_productcode`, `col_productprice`, `col_brandid`, `col_categoryid`, `col_status`) VALUES
(1, 'sampleproduct', 12, 2, 1, 'unarchived');

-- --------------------------------------------------------

--
-- Table structure for table `tbl_transaction`
--

CREATE TABLE `tbl_transaction` (
  `col_transactionid` int(11) NOT NULL,
  `col_totalprice` int(11) NOT NULL,
  `col_dateofpurchase` date NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1 ROW_FORMAT=COMPACT;

--
-- Indexes for dumped tables
--

--
-- Indexes for table `tbl_adminuser`
--
ALTER TABLE `tbl_adminuser`
  ADD PRIMARY KEY (`col_adminid`);

--
-- Indexes for table `tbl_branduser`
--
ALTER TABLE `tbl_branduser`
  ADD PRIMARY KEY (`col_brandid`),
  ADD UNIQUE KEY `col_brandid` (`col_brandname`);

--
-- Indexes for table `tbl_cashieruser`
--
ALTER TABLE `tbl_cashieruser`
  ADD PRIMARY KEY (`col_cashierid`);

--
-- Indexes for table `tbl_category`
--
ALTER TABLE `tbl_category`
  ADD PRIMARY KEY (`col_categoryid`);

--
-- Indexes for table `tbl_damage`
--
ALTER TABLE `tbl_damage`
  ADD PRIMARY KEY (`col_damageitemid`),
  ADD KEY `col_categoryid` (`col_categoryid`,`col_brandid`,`col_productid`),
  ADD KEY `col_productid` (`col_productid`),
  ADD KEY `col_brandid` (`col_brandid`);

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
  ADD KEY `col_brandid` (`col_brandid`),
  ADD KEY `col_brandid_2` (`col_brandid`),
  ADD KEY `col_brandid_3` (`col_brandid`),
  ADD KEY `col_transactionid` (`col_transactionid`),
  ADD KEY `col_categoryid` (`col_categoryid`),
  ADD KEY `col_cashierid` (`col_cashierid`);

--
-- Indexes for table `tbl_product`
--
ALTER TABLE `tbl_product`
  ADD PRIMARY KEY (`col_productid`),
  ADD KEY `col_brandid` (`col_brandid`),
  ADD KEY `col_brandid_2` (`col_brandid`),
  ADD KEY `col_categoryid` (`col_categoryid`);

--
-- Indexes for table `tbl_transaction`
--
ALTER TABLE `tbl_transaction`
  ADD PRIMARY KEY (`col_transactionid`);

--
-- AUTO_INCREMENT for dumped tables
--

--
-- AUTO_INCREMENT for table `tbl_adminuser`
--
ALTER TABLE `tbl_adminuser`
  MODIFY `col_adminid` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=2;
--
-- AUTO_INCREMENT for table `tbl_branduser`
--
ALTER TABLE `tbl_branduser`
  MODIFY `col_brandid` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=3;
--
-- AUTO_INCREMENT for table `tbl_cashieruser`
--
ALTER TABLE `tbl_cashieruser`
  MODIFY `col_cashierid` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=5;
--
-- AUTO_INCREMENT for table `tbl_category`
--
ALTER TABLE `tbl_category`
  MODIFY `col_categoryid` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=3;
--
-- AUTO_INCREMENT for table `tbl_damage`
--
ALTER TABLE `tbl_damage`
  MODIFY `col_damageitemid` int(11) NOT NULL AUTO_INCREMENT;
--
-- AUTO_INCREMENT for table `tbl_logs`
--
ALTER TABLE `tbl_logs`
  MODIFY `col_logid` int(11) NOT NULL AUTO_INCREMENT;
--
-- AUTO_INCREMENT for table `tbl_order`
--
ALTER TABLE `tbl_order`
  MODIFY `col_orderid` int(11) NOT NULL AUTO_INCREMENT;
--
-- AUTO_INCREMENT for table `tbl_product`
--
ALTER TABLE `tbl_product`
  MODIFY `col_productid` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=2;
--
-- AUTO_INCREMENT for table `tbl_transaction`
--
ALTER TABLE `tbl_transaction`
  MODIFY `col_transactionid` int(11) NOT NULL AUTO_INCREMENT;
--
-- Constraints for dumped tables
--

--
-- Constraints for table `tbl_damage`
--
ALTER TABLE `tbl_damage`
  ADD CONSTRAINT `tbl_damage_ibfk_1` FOREIGN KEY (`col_productid`) REFERENCES `tbl_product` (`col_productid`),
  ADD CONSTRAINT `tbl_damage_ibfk_2` FOREIGN KEY (`col_categoryid`) REFERENCES `tbl_category` (`col_categoryid`),
  ADD CONSTRAINT `tbl_damage_ibfk_3` FOREIGN KEY (`col_brandid`) REFERENCES `tbl_branduser` (`col_brandid`);

--
-- Constraints for table `tbl_order`
--
ALTER TABLE `tbl_order`
  ADD CONSTRAINT `tbl_order_ibfk_1` FOREIGN KEY (`col_productid`) REFERENCES `tbl_product` (`col_productid`),
  ADD CONSTRAINT `tbl_order_ibfk_2` FOREIGN KEY (`col_brandid`) REFERENCES `tbl_branduser` (`col_brandid`) ON DELETE CASCADE ON UPDATE CASCADE,
  ADD CONSTRAINT `tbl_order_ibfk_3` FOREIGN KEY (`col_transactionid`) REFERENCES `tbl_transaction` (`col_transactionid`) ON DELETE CASCADE ON UPDATE CASCADE,
  ADD CONSTRAINT `tbl_order_ibfk_5` FOREIGN KEY (`col_cashierid`) REFERENCES `tbl_cashieruser` (`col_cashierid`) ON DELETE CASCADE ON UPDATE CASCADE,
  ADD CONSTRAINT `tbl_order_ibfk_6` FOREIGN KEY (`col_categoryid`) REFERENCES `tbl_category` (`col_categoryid`) ON DELETE NO ACTION ON UPDATE CASCADE;

--
-- Constraints for table `tbl_product`
--
ALTER TABLE `tbl_product`
  ADD CONSTRAINT `tbl_product_ibfk_1` FOREIGN KEY (`col_brandid`) REFERENCES `tbl_branduser` (`col_brandid`) ON DELETE CASCADE ON UPDATE CASCADE,
  ADD CONSTRAINT `tbl_product_ibfk_2` FOREIGN KEY (`col_categoryid`) REFERENCES `tbl_category` (`col_categoryid`);

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
