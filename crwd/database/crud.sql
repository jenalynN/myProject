-- phpMyAdmin SQL Dump
-- version 4.2.11
-- http://www.phpmyadmin.net
--
-- Host: 127.0.0.1
-- Generation Time: May 31, 2016 at 07:08 AM
-- Server version: 5.6.21
-- PHP Version: 5.6.3

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8 */;

--
-- Database: `crud`
--

-- --------------------------------------------------------

--
-- Table structure for table `crud_account_tbl`
--

CREATE TABLE IF NOT EXISTS `crud_account_tbl` (
`id` int(11) NOT NULL,
  `fn` varchar(100) NOT NULL,
  `mn` varchar(100) NOT NULL,
  `ln` varchar(100) NOT NULL
) ENGINE=InnoDB AUTO_INCREMENT=8 DEFAULT CHARSET=latin1;

--
-- Dumping data for table `crud_account_tbl`
--

INSERT INTO `crud_account_tbl` (`id`, `fn`, `mn`, `ln`) VALUES
(5, 'John David', 'Sadia', 'Lozano'),
(6, 'Jeddahlyn', 'Linzag', 'Cabuga');

--
-- Indexes for dumped tables
--

--
-- Indexes for table `crud_account_tbl`
--
ALTER TABLE `crud_account_tbl`
 ADD PRIMARY KEY (`id`);

--
-- AUTO_INCREMENT for dumped tables
--

--
-- AUTO_INCREMENT for table `crud_account_tbl`
--
ALTER TABLE `crud_account_tbl`
MODIFY `id` int(11) NOT NULL AUTO_INCREMENT,AUTO_INCREMENT=8;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
