-- phpMyAdmin SQL Dump
-- version 4.6.5.2
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Generation Time: Aug 30, 2018 at 04:56 PM
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
  `col_brandcontactnum` varchar(50) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `tbl_brandpartner`
--

INSERT INTO `tbl_brandpartner` (`col_useraccountsid`, `col_brandname`, `col_brandaddress`, `col_brandcontactnum`) VALUES
(1, 'samplebrand', 'asd', 'asd'),
(3, 'brand', 'brand', 'brand');

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
  `col_productid` int(11) NOT NULL,
  `col_transactionid` int(11) NOT NULL,
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
  `col_quantitybought` int(11) NOT NULL,
  `col_subtotal` int(11) NOT NULL,
  `col_status` varchar(30) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1 ROW_FORMAT=COMPACT;

--
-- Dumping data for table `tbl_order`
--

INSERT INTO `tbl_order` (`col_orderid`, `col_transactionid`, `col_productid`, `col_quantitybought`, `col_subtotal`, `col_status`) VALUES
(46, 124, 1, 12, 1200, 'unfinished');

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
(1, 'sampleproduct', 'nimbus', 100, 3, 2, 'unarchived'),
(3, 'asd', 'asd', 100, 1, 2, 'unarchived');

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
(2, '', 3, 123123, '2018-08-09'),
(3, 'PCS013', 1, 0, '2018-08-29'),
(4, 'PCS013', 1, 0, '2018-08-29'),
(5, 'PCS013', 1, 0, '2018-08-29'),
(6, 'PCS013', 1, 0, '2018-08-29'),
(31, 'PCS017', 1, 0, '2018-08-29'),
(32, 'PCS017', 1, 0, '2018-08-29'),
(33, 'PCS0133', 1, 0, '2018-08-29'),
(34, 'PCS0133', 1, 0, '2018-08-29'),
(35, 'PCS0133', 1, 0, '2018-08-29'),
(36, 'PCS0133', 1, 0, '2018-08-29'),
(37, 'PCS0133', 1, 0, '2018-08-29'),
(38, 'PCS0133', 1, 0, '2018-08-29'),
(39, 'PCS0133', 1, 0, '2018-08-29'),
(40, 'PCS0133', 1, 0, '2018-08-29'),
(41, 'PCS0133', 1, 0, '2018-08-29'),
(42, 'PCS0133', 1, 0, '2018-08-29'),
(46, 'PCS0143', 1, 0, '2018-08-29'),
(47, 'PCS0143', 1, 0, '2018-08-29'),
(48, 'PCS0148', 1, 0, '2018-08-29'),
(49, 'PCS0149', 1, 0, '2018-08-29'),
(50, 'PCS0150', 1, 0, '2018-08-29'),
(51, 'PCS0151', 1, 0, '2018-08-29'),
(52, 'PCS0152', 1, 0, '2018-08-29'),
(53, 'PCS0153', 1, 0, '2018-08-29'),
(54, 'PCS0154', 1, 0, '2018-08-29'),
(55, 'PCS0155', 1, 0, '2018-08-30'),
(56, 'PCS0156', 1, 0, '2018-08-30'),
(57, 'PCS0157', 1, 0, '2018-08-30'),
(58, 'PCS0158', 1, 0, '2018-08-30'),
(59, 'PCS0159', 1, 0, '2018-08-30'),
(60, 'PCS0160', 1, 0, '2018-08-30'),
(61, 'PCS0160', 1, 0, '2018-08-30'),
(62, 'PCS0162', 1, 0, '2018-08-30'),
(65, 'PCS0163', 1, 0, '2018-08-30'),
(66, 'PCS0166', 1, 0, '2018-08-30'),
(67, 'PCS0167', 1, 0, '2018-08-30'),
(68, 'PCS0168', 1, 0, '2018-08-30'),
(69, 'PCS0168', 1, 2400, '2018-08-30'),
(70, 'PCS0170', 1, 0, '2018-08-30'),
(71, 'PCS0171', 1, 0, '2018-08-30'),
(72, 'PCS0171', 1, 1200, '2018-08-30'),
(73, 'PCS0173', 1, 0, '2018-08-30'),
(74, 'PCS0173', 1, 2400, '2018-08-30'),
(75, 'PCS0175', 1, 0, '2018-08-30'),
(76, 'PCS0176', 1, 0, '2018-08-30'),
(77, 'PCS0177', 1, 0, '2018-08-30'),
(78, 'PCS0178', 1, 0, '2018-08-30'),
(79, 'PCS0178', 1, 0, '2018-08-30'),
(80, 'PCS0180', 1, 0, '2018-08-30'),
(81, 'PCS0181', 1, 0, '2018-08-30'),
(82, 'PCS0181', 1, 2400, '2018-08-30'),
(83, 'PCS0183', 1, 0, '2018-08-30'),
(84, 'PCS0184', 1, 0, '2018-08-30'),
(85, 'PCS0185', 1, 0, '2018-08-30'),
(86, 'PCS0185', 1, 0, '2018-08-30'),
(87, 'PCS0187', 1, 0, '2018-08-30'),
(88, 'PCS0188', 1, 0, '2018-08-30'),
(89, 'PCS0189', 1, 0, '2018-08-30'),
(90, 'PCS0190', 1, 0, '2018-08-30'),
(91, 'PCS0191', 1, 0, '2018-08-30'),
(92, 'PCS0192', 1, 0, '2018-08-30'),
(93, 'PCS0193', 1, 0, '2018-08-30'),
(94, 'PCS0193', 1, 0, '2018-08-30'),
(95, 'PCS0195', 1, 0, '2018-08-30'),
(96, 'PCS0196', 1, 0, '2018-08-30'),
(97, 'PCS0197', 1, 0, '2018-08-30'),
(98, 'PCS0197', 1, 1200, '2018-08-30'),
(99, 'PCS0199', 1, 0, '2018-08-30'),
(100, 'PCS01100', 1, 0, '2018-08-30'),
(101, 'PCS01101', 1, 0, '2018-08-30'),
(102, 'PCS01102', 1, 0, '2018-08-30'),
(103, 'PCS01102', 1, 3600, '2018-08-30'),
(104, 'PCS01104', 1, 0, '2018-08-30'),
(105, 'PCS01104', 1, 4800, '2018-08-30'),
(106, 'PCS01106', 1, 0, '2018-08-30'),
(107, 'PCS01106', 1, 6000, '2018-08-30'),
(108, 'PCS01108', 1, 0, '2018-08-30'),
(109, 'PCS01109', 1, 0, '2018-08-30'),
(110, 'PCS01110', 1, 0, '2018-08-30'),
(111, 'PCS01110', 1, 8400, '2018-08-30'),
(112, 'PCS01112', 1, 0, '2018-08-30'),
(113, 'PCS01113', 1, 0, '2018-08-30'),
(114, 'PCS01114', 1, 0, '2018-08-30'),
(115, 'PCS01115', 1, 0, '2018-08-30'),
(116, 'PCS01115', 1, 0, '2018-08-30'),
(117, 'PCS01117', 1, 0, '2018-08-30'),
(118, 'PCS01117', 1, 1200, '2018-08-30'),
(119, 'PCS01117', 1, 1200, '2018-08-30'),
(120, 'PCS01120', 1, 0, '2018-08-30'),
(121, 'PCS01120', 1, 0, '2018-08-30'),
(122, 'PCS01120', 1, 0, '2018-08-30'),
(123, 'PCS01120', 1, 0, '2018-08-30'),
(124, 'PCS01124', 1, 0, '2018-08-30'),
(125, 'PCS01124', 1, 1200, '2018-08-30');

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
(1, 'cashier', 'cashier', 'cashier', 'cashier', 'cashier', 'cashier', '2018-07-04', 'cashier', 'cashier', 2, 'unarchived'),
(3, 'cashier2', 'cashier2', 'cashier2', 'cashier2', 'cashier2', 'cashier2', '2018-07-04', 'cashier2', 'cashier2', 2, 'archived');

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
(2, 'Cashier');

--
-- Indexes for dumped tables
--

--
-- Indexes for table `tbl_brandpartner`
--
ALTER TABLE `tbl_brandpartner`
  ADD PRIMARY KEY (`col_useraccountsid`),
  ADD UNIQUE KEY `col_brandid` (`col_brandname`) USING BTREE;

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
  ADD KEY `col_categoryid` (`col_productid`),
  ADD KEY `col_productid` (`col_productid`);

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
  MODIFY `col_useraccountsid` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=5;
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
  MODIFY `col_orderid` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=47;
--
-- AUTO_INCREMENT for table `tbl_product`
--
ALTER TABLE `tbl_product`
  MODIFY `col_productid` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=4;
--
-- AUTO_INCREMENT for table `tbl_transaction`
--
ALTER TABLE `tbl_transaction`
  MODIFY `col_transactionid` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=126;
--
-- AUTO_INCREMENT for table `tbl_useraccounts`
--
ALTER TABLE `tbl_useraccounts`
  MODIFY `col_useraccountsid` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=4;
--
-- Constraints for dumped tables
--

--
-- Constraints for table `tbl_brandpartner`
--
ALTER TABLE `tbl_brandpartner`
  ADD CONSTRAINT `tbl_brandpartner_ibfk_1` FOREIGN KEY (`col_useraccountsid`) REFERENCES `tbl_useraccounts` (`col_useraccountsid`);

--
-- Constraints for table `tbl_damage`
--
ALTER TABLE `tbl_damage`
  ADD CONSTRAINT `tbl_damage_ibfk_1` FOREIGN KEY (`col_productid`) REFERENCES `tbl_product` (`col_productid`);

--
-- Constraints for table `tbl_order`
--
ALTER TABLE `tbl_order`
  ADD CONSTRAINT `tbl_order_ibfk_2` FOREIGN KEY (`col_productid`) REFERENCES `tbl_product` (`col_productid`),
  ADD CONSTRAINT `tbl_order_ibfk_3` FOREIGN KEY (`col_transactionid`) REFERENCES `tbl_transaction` (`col_transactionid`) ON DELETE CASCADE ON UPDATE CASCADE;

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
