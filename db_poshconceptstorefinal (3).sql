-- phpMyAdmin SQL Dump
-- version 4.6.5.2
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Generation Time: Sep 22, 2018 at 05:33 PM
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
(18, 'PLDT', 'IBABAO, MANDAUE', '09987654321'),
(19, 'PLDTBossing', 'wireless', '09987654321');

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
(3, 18, 'ROUTER');

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
  `col_orderstatus` varchar(30) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1 ROW_FORMAT=COMPACT;

--
-- Dumping data for table `tbl_order`
--

INSERT INTO `tbl_order` (`col_orderid`, `col_transactionid`, `col_productid`, `col_quantitybought`, `col_subtotal`, `col_orderstatus`) VALUES
(8, 211, 3, 12, 1200, 'Sales'),
(9, 212, 1, 12, 1200, 'unfinished'),
(10, 213, 1, 12, 1200, 'unfinished'),
(11, 218, 1, 12, 1200, 'void'),
(12, 219, 1, 12, 1200, 'void'),
(13, 226, 1, 12, 1200, 'unfinished'),
(14, 227, 1, 123, 12300, 'unfinished'),
(15, 233, 1, 12, 1200, 'void'),
(16, 246, 1, 12, 1200, 'unfinished'),
(17, 247, 1, 12, 1200, 'unfinished'),
(18, 248, 1, 12, 1200, 'void'),
(19, 249, 1, 12, 1200, 'void'),
(20, 250, 1, 12, 1200, 'unfinished'),
(21, 253, 1, 12, 1200, 'unfinished'),
(22, 254, 3, 12, 1200, 'unfinished'),
(23, 258, 1, 12, 1200, 'Sales'),
(24, 276, 5, 1, 21, 'unfinished'),
(25, 278, 5, 1, 21, 'unfinished'),
(26, 279, 5, 1, 21, 'unfinished'),
(27, 279, 5, 2, 42, 'unfinished'),
(28, 280, 5, 12, 252, 'unfinished'),
(29, 281, 5, 12, 252, 'unfinished'),
(30, 282, 5, 12, 252, 'unfinished'),
(31, 282, 5, 21, 441, 'unfinished'),
(32, 284, 5, 12, 252, 'unfinished');

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
(3, 'asd', 'asd', 100, 3, 2, 'archived'),
(4, 'sample', '', 25000, 8, 1, 'archived'),
(5, '001a', 'garmin', 21, 20, 1, 'unarchived'),
(6, 'charan', 'cheeze cake', 100, 20, 2, 'unarchived'),
(7, 'POS-0000002222', 'helloworld', 900, 19, 3, 'archived'),
(8, 'asdasd', 'asdasd', 20, 19, 3, 'unarchived'),
(9, 'dasdasd', 'asddsdsd', 210, 18, 3, 'archived');

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
(3, 'PCS013', 17, 15000, '2018-08-29'),
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
(125, 'PCS01124', 1, 1200, '2018-08-30'),
(126, 'PCS01126', 1, 0, '2018-08-31'),
(127, 'PCS01126', 1, 2400, '2018-08-31'),
(128, 'PCS01128', 1, 0, '2018-08-31'),
(129, 'PCS01128', 1, 3600, '2018-08-31'),
(130, 'PCS01130', 1, 0, '2018-08-31'),
(131, 'PCS01131', 1, 0, '2018-08-31'),
(132, 'PCS01132', 1, 0, '2018-08-31'),
(133, 'PCS01132', 1, 1200, '2018-08-31'),
(134, 'PCS01134', 1, 0, '2018-08-31'),
(135, 'PCS01134', 1, 2400, '2018-08-31'),
(136, 'PCS01136', 1, 0, '2018-08-31'),
(137, 'PCS01136', 1, 3600, '2018-08-31'),
(138, 'PCS01138', 1, 0, '2018-08-31'),
(139, 'PCS01138', 1, 4800, '2018-08-31'),
(140, 'PCS0140', 1, 0, '2018-08-31'),
(141, 'PCS0141', 1, 0, '2018-08-31'),
(142, 'PCS0142', 1, 0, '2018-08-31'),
(143, 'PCS0143', 1, 0, '2018-08-31'),
(144, 'PCS0144', 1, 0, '2018-08-31'),
(145, 'PCS0145', 1, 0, '2018-08-31'),
(146, 'PCS0146', 1, 0, '2018-09-01'),
(147, 'PCS0147', 1, 0, '2018-09-01'),
(148, 'PCS0148', 1, 0, '2018-09-01'),
(149, 'PCS0149', 1, 0, '2018-09-01'),
(150, 'PCS0150', 1, 0, '2018-09-01'),
(151, 'PCS0151', 1, 0, '2018-09-01'),
(152, 'PCS0152', 1, 0, '2018-09-01'),
(153, 'PCS0153', 1, 0, '2018-09-01'),
(154, 'PCS0154', 1, 0, '2018-09-01'),
(155, 'PCS0155', 1, 0, '2018-09-01'),
(156, 'PCS0156', 1, 0, '2018-09-01'),
(157, 'PCS0157', 1, 0, '2018-09-01'),
(158, 'PCS0158', 1, 0, '2018-09-01'),
(159, 'PCS0159', 1, 0, '2018-09-01'),
(160, 'PCS0160', 1, 0, '2018-09-01'),
(161, 'PCS0161', 1, 0, '2018-09-05'),
(162, 'PCS0162', 1, 0, '2018-09-05'),
(163, 'PCS0163', 1, 0, '2018-09-05'),
(164, 'PCS0164', 1, 0, '2018-09-05'),
(165, 'PCS0165', 1, 0, '2018-09-05'),
(166, 'PCS0166', 1, 0, '2018-09-05'),
(167, 'PCS0167', 1, 0, '2018-09-05'),
(168, 'PCS0168', 1, 0, '2018-09-05'),
(169, 'PCS0169', 1, 0, '2018-09-05'),
(170, 'PCS0170', 1, 0, '2018-09-05'),
(171, 'PCS0171', 1, 0, '2018-09-05'),
(172, 'PCS0172', 1, 0, '2018-09-05'),
(173, 'PCS0173', 1, 0, '2018-09-05'),
(174, 'PCS0174', 1, 0, '2018-09-05'),
(175, 'PCS0175', 1, 0, '2018-09-05'),
(176, 'PCS0176', 1, 0, '2018-09-05'),
(177, 'PCS0177', 1, 0, '2018-09-05'),
(178, 'PCS0178', 1, 0, '2018-09-05'),
(179, 'PCS0179', 1, 0, '2018-09-05'),
(180, 'PCS0180', 1, 0, '2018-09-05'),
(181, 'PCS0181', 1, 0, '2018-09-05'),
(182, 'PCS0182', 1, 0, '2018-09-05'),
(183, 'PCS0183', 1, 0, '2018-09-05'),
(184, 'PCS0184', 1, 0, '2018-09-05'),
(185, 'PCS0185', 1, 0, '2018-09-05'),
(186, 'PCS0186', 1, 1200, '2018-09-05'),
(187, 'PCS0187', 1, 0, '2018-09-05'),
(188, 'PCS0188', 1, 0, '2018-09-05'),
(189, 'PCS0189', 1, 0, '2018-09-05'),
(190, 'PCS0190', 1, 0, '2018-09-05'),
(191, 'PCS0191', 1, 0, '2018-09-05'),
(192, 'PCS0192', 1, 0, '2018-09-05'),
(193, 'PCS0193', 1, 0, '2018-09-05'),
(194, 'PCS0194', 1, 0, '2018-09-05'),
(195, 'PCS0195', 1, 0, '2018-09-05'),
(196, 'PCS0196', 1, 0, '2018-09-05'),
(197, 'PCS0197', 1, 0, '2018-09-05'),
(199, 'PCS0198', 1, 0, '2018-09-05'),
(202, 'PCS0200', 1, 0, '2018-09-05'),
(203, 'PCS0203', 1, 0, '2018-09-05'),
(204, 'PCS0204', 1, 0, '2018-09-05'),
(205, 'PCS0205', 1, 0, '2018-09-05'),
(211, 'PCS0206', 1, 0, '2018-09-06'),
(212, 'PCS0212', 1, 1200, '2018-09-06'),
(213, 'PCS0213', 1, 1200, '2018-09-06'),
(214, 'PCS0214', 18, 0, '2018-09-10'),
(215, 'PCS0215', 18, 0, '2018-09-15'),
(216, 'PCS0216', 18, 0, '2018-09-15'),
(217, 'PCS0217', 18, 0, '2018-09-15'),
(218, 'PCS0218', 18, 0, '2018-09-15'),
(219, 'PCS0219', 18, 0, '2018-09-15'),
(220, 'PCS0220', 18, 0, '2018-09-15'),
(221, 'PCS0221', 18, 0, '2018-09-15'),
(222, 'PCS0222', 18, 0, '2018-09-15'),
(223, 'PCS0223', 18, 0, '2018-09-15'),
(224, 'PCS0224', 18, 0, '2018-09-15'),
(225, 'PCS0225', 18, 0, '2018-09-15'),
(226, 'PCS0226', 18, 0, '2018-09-15'),
(227, 'PCS0227', 18, 12300, '2018-09-15'),
(228, 'PCS0228', 18, 0, '2018-09-15'),
(229, 'PCS0229', 18, 0, '2018-09-15'),
(230, 'PCS0230', 18, 0, '2018-09-15'),
(231, 'PCS0231', 18, 0, '2018-09-15'),
(232, 'PCS0232', 18, 0, '2018-09-15'),
(233, 'PCS0233', 18, 0, '2018-09-15'),
(234, 'PCS0234', 18, 0, '2018-09-15'),
(235, 'PCS0235', 18, 0, '2018-09-15'),
(236, 'PCS0236', 18, 0, '2018-09-15'),
(237, 'PCS0237', 18, 0, '2018-09-15'),
(238, 'PCS0238', 18, 0, '2018-09-15'),
(239, 'PCS0239', 18, 0, '2018-09-15'),
(240, 'PCS0240', 18, 0, '2018-09-15'),
(241, 'PCS0241', 18, 0, '2018-09-15'),
(242, 'PCS0242', 18, 0, '2018-09-15'),
(243, 'PCS0243', 18, 0, '2018-09-15'),
(244, 'PCS0244', 18, 0, '2018-09-15'),
(245, 'PCS0245', 18, 0, '2018-09-15'),
(246, 'PCS0246', 18, 0, '2018-09-15'),
(247, 'PCS0247', 18, 0, '2018-09-15'),
(248, 'PCS0248', 18, 0, '2018-09-15'),
(249, 'PCS0249', 18, 0, '2018-09-15'),
(250, 'PCS0250', 18, 0, '2018-09-15'),
(251, 'PCS0251', 18, 0, '2018-09-15'),
(252, 'PCS0252', 18, 0, '2018-09-15'),
(253, 'PCS0253', 18, 0, '2018-09-15'),
(254, 'PCS0254', 18, 0, '2018-09-15'),
(255, 'PCS0255', 18, 0, '2018-09-15'),
(256, 'PCS0256', 18, 0, '2018-09-15'),
(257, 'PCS0257', 18, 0, '2018-09-16'),
(258, 'PCS0258', 18, 0, '2018-09-16'),
(259, 'PCS0259', 18, 0, '2018-09-16'),
(260, 'PCS0260', 18, 0, '2018-09-16'),
(261, 'PCS0261', 18, 0, '2018-09-16'),
(262, 'PCS0262', 18, 0, '2018-09-16'),
(263, 'PCS0263', 18, 0, '2018-09-16'),
(264, 'PCS0264', 18, 0, '2018-09-16'),
(265, 'PCS0265', 18, 0, '2018-09-16'),
(266, 'PCS0266', 18, 0, '2018-09-16'),
(267, 'PCS0267', 18, 0, '2018-09-16'),
(268, 'PCS0268', 18, 0, '2018-09-16'),
(269, 'PCS0269', 18, 0, '2018-09-16'),
(270, 'PCS0270', 18, 0, '2018-09-16'),
(271, 'PCS0271', 18, 0, '2018-09-16'),
(272, 'PCS0272', 18, 0, '2018-09-16'),
(273, 'PCS0273', 18, 0, '2018-09-16'),
(274, 'PCS0274', 18, 0, '2018-09-17'),
(275, 'PCS0275', 18, 0, '2018-09-18'),
(276, 'PCS0276', 22, 0, '2018-09-18'),
(277, 'PCS0277', 18, 0, '2018-09-18'),
(278, 'PCS0278', 22, 0, '2018-09-18'),
(279, 'PCS0279', 22, 0, '2018-09-18'),
(280, 'PCS0280', 18, 0, '2018-09-18'),
(281, 'PCS0281', 18, 252, '2018-09-18'),
(282, 'PCS0282', 22, 693, '2018-09-18'),
(283, 'PCS0283', 22, 0, '2018-09-18'),
(284, 'PCS0284', 18, 252, '2018-09-18'),
(285, 'PCS0285', 22, 0, '2018-09-18'),
(286, 'PCS0286', 18, 0, '2018-09-18'),
(287, 'PCS0287', 18, 0, '2018-09-21'),
(288, 'PCS0288', 18, 0, '2018-09-21'),
(289, 'PCS0289', 18, 0, '2018-09-21'),
(290, 'PCS0290', 18, 0, '2018-09-21'),
(291, 'PCS0291', 22, 0, '2018-09-22'),
(292, 'PCS0292', 22, 0, '2018-09-22'),
(293, 'PCS0293', 22, 0, '2018-09-22'),
(294, 'PCS0294', 22, 0, '2018-09-22'),
(295, 'PCS0295', 22, 0, '2018-09-22'),
(296, 'PCS0296', 22, 0, '2018-09-22'),
(297, 'PCS0297', 22, 0, '2018-09-22'),
(298, 'PCS0298', 22, 0, '2018-09-22'),
(299, 'PCS0299', 22, 0, '2018-09-22'),
(300, 'PCS0300', 22, 0, '2018-09-22'),
(301, 'PCS0301', 22, 0, '2018-09-22'),
(302, 'PCS0302', 22, 0, '2018-09-22'),
(303, 'PCS0303', 22, 0, '2018-09-22'),
(304, 'PCS0304', 22, 0, '2018-09-22'),
(305, 'PCS0305', 22, 0, '2018-09-22'),
(306, 'PCS0306', 22, 0, '2018-09-22'),
(307, 'PCS0307', 22, 0, '2018-09-22');

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
(18, 'cashier', 'cashier', 'cashier', 'cashier', 'cashier', 'cashier', '2018-09-05', 'Male', 'cashier', 2, 'archived'),
(19, 'samplebrand2', 'samplebrand2', 'samplebrand2', 'samplebrand2', 'samplebrand2', 'samplebrand2', '0000-00-00', 'Male', 'samplebrand2', 3, 'unarchived'),
(20, 'guest101', '123', 'guest21', 'guest123', 'guest1', 'opopo', '0000-00-00', 'Female', '1234567', 3, 'unarchived'),
(21, 'her', '1234', 'cruz', 'john', 'doe', 'street', '0000-00-00', 'Male', '12345678', 3, 'unarchived'),
(22, 'anne', 'asd', 'tan', 'marie', 'anne', 'ads1172', '2018-09-18', 'Male', '1234567', 2, 'unarchived');

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
  MODIFY `col_useraccountsid` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=22;
--
-- AUTO_INCREMENT for table `tbl_category`
--
ALTER TABLE `tbl_category`
  MODIFY `col_categoryid` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=4;
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
  MODIFY `col_orderid` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=33;
--
-- AUTO_INCREMENT for table `tbl_product`
--
ALTER TABLE `tbl_product`
  MODIFY `col_productid` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=10;
--
-- AUTO_INCREMENT for table `tbl_transaction`
--
ALTER TABLE `tbl_transaction`
  MODIFY `col_transactionid` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=308;
--
-- AUTO_INCREMENT for table `tbl_useraccounts`
--
ALTER TABLE `tbl_useraccounts`
  MODIFY `col_useraccountsid` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=23;
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
