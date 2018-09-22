-- phpMyAdmin SQL Dump
-- version 4.8.2
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Generation Time: Sep 22, 2018 at 08:20 PM
-- Server version: 10.1.34-MariaDB
-- PHP Version: 7.2.7

SET FOREIGN_KEY_CHECKS=0;
SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
SET AUTOCOMMIT = 0;
START TRANSACTION;


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `db_poshconceptstorefinal`
--

--
-- Dumping data for table `tbl_brandpartner`
--

REPLACE INTO `tbl_brandpartner` (`col_useraccountsid`, `col_brandname`, `col_brandaddress`, `col_brandcontactnum`) VALUES
(19, 'adidas', 'Talamban', '09987654321'),
(20, 'nike', 'IBABAO, MANDAUE', '09987654321'),
(21, 'H&M', 'cebu', '223311');

--
-- Dumping data for table `tbl_category`
--

REPLACE INTO `tbl_category` (`col_categoryid`, `col_useraccountsid`, `col_categoryname`) VALUES
(3, 19, 'shoes'),
(4, 19, 'jacket'),
(5, 19, 'shirt'),
(6, 20, 'shoes'),
(7, 20, 'glasses'),
(8, 20, 'hat'),
(9, 21, 'makeup'),
(10, 21, 'bag');

--
-- Dumping data for table `tbl_order`
--

REPLACE INTO `tbl_order` (`col_orderid`, `col_transactionid`, `col_productid`, `col_quantitybought`, `col_subtotal`, `col_orderstatus`) VALUES
(1, 2, 1, 2, 4000, 'unfinished'),
(2, 2, 2, 1, 1000, 'unfinished'),
(3, 2, 3, 3, 9000, 'unfinished'),
(4, 2, 5, 2, 1998, 'unfinished'),
(5, 3, 3, 1, 3000, 'unfinished'),
(6, 3, 4, 1, 2000, 'unfinished'),
(7, 4, 5, 3, 2997, 'unfinished'),
(8, 5, 2, 2, 2000, 'unfinished'),
(9, 6, 1, 2, 2000, 'unfinished'),
(10, 7, 1, 5, 10000, 'unfinished'),
(11, 8, 1, 6, 12000, 'unfinished');

--
-- Dumping data for table `tbl_product`
--

REPLACE INTO `tbl_product` (`col_productid`, `col_productcode`, `col_productname`, `col_productprice`, `col_useraccountsid`, `col_categoryid`, `col_status`) VALUES
(1, 'ADSHO001', 'runner', 2000, 19, 3, 'unarchived'),
(2, 'ADSHO002', 'hiker', 1000, 19, 3, 'unarchived'),
(3, 'NISHO001', 'sprinter', 3000, 20, 3, 'unarchived'),
(4, 'NISHO002', 'trekker', 2000, 20, 3, 'unarchived'),
(5, 'HMMAK001', 'AntiAging', 999, 21, 9, 'unarchived');

--
-- Dumping data for table `tbl_transaction`
--

REPLACE INTO `tbl_transaction` (`col_transactionid`, `col_transactioncode`, `col_useraccountsid`, `col_totalprice`, `col_dateofpurchase`) VALUES
(2, 'PCS02', 22, 15998, '2018-09-16'),
(3, 'PCS03', 22, 5000, '2018-09-17'),
(4, 'PCS04', 22, 2997, '2018-09-18'),
(5, 'PCS05', 22, 2000, '2018-09-19'),
(6, 'PCS06', 22, 2000, '2018-09-20'),
(7, 'PCS07', 22, 10000, '2018-09-21'),
(8, 'PCS08', 22, 0, '2018-09-22');

--
-- Dumping data for table `tbl_useraccounts`
--

REPLACE INTO `tbl_useraccounts` (`col_useraccountsid`, `col_user`, `col_password`, `col_lastname`, `col_firstname`, `col_middlename`, `col_address`, `col_dateofbirth`, `col_gender`, `col_contactnum`, `col_usertypeid`, `col_status`) VALUES
(17, 'admin', 'admin', 'admin', 'admin', 'admin', 'admin', '2018-09-05', 'Male', 'admin', 1, 'unarchived'),
(18, 'cashier', 'cashier', 'naldoza', 'jenalyn', 'bonior', 'bohol', '2018-09-05', 'Female', '2398899', 2, 'unarchived'),
(19, 'adidas', '123', 'cahimat', 'jurix', 'm', 'cebu', '2018-09-04', 'Male', '123321', 3, 'unarchived'),
(20, 'nike', '123', 'salva', 'ryanjie', 'a', 'CDO', '2018-09-02', 'Male', '1234567', 3, 'unarchived'),
(21, 'HnM', '123', 'cruz', 'john', 'doe', 'street', '2018-09-01', 'Male', '12345678', 3, 'unarchived'),
(22, 'anne', 'asd', 'tan', 'marie', 'anne', 'ads1172', '2018-09-18', 'Female', '1234567', 2, 'unarchived');

--
-- Dumping data for table `tbl_usertype`
--

REPLACE INTO `tbl_usertype` (`col_usertypeid`, `col_userrole`) VALUES
(1, 'Admin'),
(2, 'Cashier'),
(3, 'Brandpartner');
SET FOREIGN_KEY_CHECKS=1;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
