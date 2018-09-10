-- phpMyAdmin SQL Dump
-- version 4.0.9
-- http://www.phpmyadmin.net
--
-- Host: 127.0.0.1
-- Generation Time: Apr 05, 2017 at 03:45 AM
-- Server version: 5.6.14
-- PHP Version: 5.5.6

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8 */;

--
-- Database: `dbpizza`
--

-- --------------------------------------------------------

--
-- Table structure for table `login`
--

CREATE TABLE IF NOT EXISTS `login` (
  `username` varchar(10) NOT NULL,
  `password` varchar(10) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `login`
--

INSERT INTO `login` (`username`, `password`) VALUES
('admin', 'ryanjie');

-- --------------------------------------------------------

--
-- Table structure for table `tb_order`
--

CREATE TABLE IF NOT EXISTS `tb_order` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `order_id` int(11) NOT NULL,
  `date_ordered` varchar(25) NOT NULL,
  `cus_name` varchar(50) NOT NULL,
  `cus_num` int(12) NOT NULL,
  `cus_add` varchar(50) NOT NULL,
  `pizza_id` int(5) NOT NULL,
  `type` varchar(25) NOT NULL,
  PRIMARY KEY (`id`),
  KEY `pizza_id` (`pizza_id`)
) ENGINE=InnoDB  DEFAULT CHARSET=latin1 AUTO_INCREMENT=11 ;

--
-- Dumping data for table `tb_order`
--

INSERT INTO `tb_order` (`id`, `order_id`, `date_ordered`, `cus_name`, `cus_num`, `cus_add`, `pizza_id`, `type`) VALUES
(4, 1, '2017-04-04', '', 0, '', 5, 'Dine In'),
(5, 1, '2017-04-04', '', 0, '', 5, 'Dine In'),
(6, 1, '2017-04-04', '', 0, '', 8, 'Dine In'),
(7, 1, '2017-04-04', '', 0, '', 8, 'Dine In'),
(8, 1, '2017-04-04', '', 0, '', 8, 'Dine In'),
(9, 1, '2017-04-04', 'Ham Delight', 0, '', 12, 'Dine In'),
(10, 1, '2017-04-04', 'Ham Delight', 0, '', 12, 'Dine In');

-- --------------------------------------------------------

--
-- Table structure for table `tb_pizzalist`
--

CREATE TABLE IF NOT EXISTS `tb_pizzalist` (
  `id` int(8) NOT NULL AUTO_INCREMENT,
  `pizza_name` varchar(50) NOT NULL,
  `pizza_size` varchar(15) NOT NULL,
  `pizza_price` varchar(11) NOT NULL,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB  DEFAULT CHARSET=latin1 AUTO_INCREMENT=16 ;

--
-- Dumping data for table `tb_pizzalist`
--

INSERT INTO `tb_pizzalist` (`id`, `pizza_name`, `pizza_size`, `pizza_price`) VALUES
(1, 'Cookies n Cheese', '9', '75'),
(2, 'Cookies n  Cheese', '11', '115'),
(3, 'Yummy Hotdog', '9', '75'),
(4, 'Yummy Hotdog', '11', '117'),
(5, 'Ham Delight', '9', '80'),
(6, 'Ham Delight', '11', '120'),
(7, 'Tuna Garlic', '9', '90'),
(8, 'Tuna Garlic', '11', '130'),
(9, 'Hawaiian', '9', '100'),
(10, 'Hawaiian', '11', '140'),
(11, 'MeatLovers', '9', '125'),
(12, 'MeatLovers', '11', '175'),
(13, 'Diavolos', '9', '130'),
(14, 'Diavolos', '11', '180'),
(15, 'dghdghd', '9', '120');

--
-- Constraints for dumped tables
--

--
-- Constraints for table `tb_order`
--
ALTER TABLE `tb_order`
  ADD CONSTRAINT `tb_order_ibfk_1` FOREIGN KEY (`pizza_id`) REFERENCES `tb_pizzalist` (`id`) ON DELETE NO ACTION ON UPDATE NO ACTION;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
