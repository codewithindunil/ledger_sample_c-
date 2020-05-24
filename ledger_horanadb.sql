-- phpMyAdmin SQL Dump
-- version 4.8.3
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Generation Time: May 24, 2020 at 10:20 PM
-- Server version: 10.1.36-MariaDB
-- PHP Version: 7.2.10

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
SET AUTOCOMMIT = 0;
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `ledger_horanadb`
--

-- --------------------------------------------------------

--
-- Table structure for table `categories`
--

CREATE TABLE `categories` (
  `id` int(11) NOT NULL,
  `cname` varchar(15) NOT NULL,
  `date` varchar(15) NOT NULL,
  `user` varchar(15) NOT NULL,
  `datetimesnap` timestamp NOT NULL DEFAULT CURRENT_TIMESTAMP
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `categories`
--

INSERT INTO `categories` (`id`, `cname`, `date`, `user`, `datetimesnap`) VALUES
(12, 'test1', '4/25/2020 9:07:', 'test', '2020-04-25 15:37:20'),
(13, 'test2', '4/25/2020 9:07:', 'test', '2020-04-25 15:37:24'),
(14, 'tes3', '4/25/2020 9:07:', 'test', '2020-04-25 15:37:28'),
(15, 'abc', '5/25/2020 1:16:', 'test', '2020-05-24 19:46:45');

-- --------------------------------------------------------

--
-- Table structure for table `creditigeshe`
--

CREATE TABLE `creditigeshe` (
  `id` int(11) NOT NULL,
  `credit` varchar(100) NOT NULL,
  `debit` varchar(100) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `creditigeshe`
--

INSERT INTO `creditigeshe` (`id`, `credit`, `debit`) VALUES
(2, '13367141', '12');

-- --------------------------------------------------------

--
-- Table structure for table `dailytotal`
--

CREATE TABLE `dailytotal` (
  `id` int(11) NOT NULL,
  `dateNo` varchar(100) NOT NULL,
  `wekNo` varchar(100) NOT NULL,
  `monthNo` varchar(100) NOT NULL,
  `creditTotal` double NOT NULL,
  `debitTotal` double NOT NULL,
  `datestamp` timestamp NOT NULL DEFAULT CURRENT_TIMESTAMP
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `dailytotal`
--

INSERT INTO `dailytotal` (`id`, `dateNo`, `wekNo`, `monthNo`, `creditTotal`, `debitTotal`, `datestamp`) VALUES
(3, '135', '20', '05', 3000000000, 7000000000, '2020-05-13 21:24:57'),
(4, '136', '20', '05', 0, 0, '2020-05-15 18:21:05'),
(5, '137', '20', '05', 14445, 258666, '2020-05-15 18:35:59'),
(6, '141', '21', '05', 232, 0, '2020-05-20 09:43:45'),
(7, '145', '21', '05', 0, 0, '2020-05-23 19:10:33'),
(8, '146', '22', '05', 1001111, 21312, '2020-05-24 19:32:28');

-- --------------------------------------------------------

--
-- Table structure for table `duecheques`
--

CREATE TABLE `duecheques` (
  `id` int(11) NOT NULL,
  `chequeNo` varchar(100) NOT NULL,
  `chequeValue` varchar(100) NOT NULL,
  `credited` double NOT NULL,
  `debited` double NOT NULL,
  `bankName` varchar(100) NOT NULL,
  `invoiceId` varchar(100) NOT NULL,
  `dueDayNo` varchar(100) NOT NULL,
  `dueWeekNo` varchar(100) NOT NULL,
  `dueDate` datetime NOT NULL,
  `enteredDate` timestamp NOT NULL DEFAULT CURRENT_TIMESTAMP
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `duecheques`
--

INSERT INTO `duecheques` (`id`, `chequeNo`, `chequeValue`, `credited`, `debited`, `bankName`, `invoiceId`, `dueDayNo`, `dueWeekNo`, `dueDate`, `enteredDate`) VALUES
(3, '1', '150000', 150000, 0, 'NSB', '', '134', '20', '0000-00-00 00:00:00', '2020-05-13 16:22:50'),
(4, '2', '200000', 0, 200000, 'PEOPLES', '', '134', '20', '0000-00-00 00:00:00', '2020-05-13 16:23:17'),
(5, '2222', '323', 323, 0, 'NTB', '232', '129', '19', '0000-00-00 00:00:00', '2020-05-20 10:41:03');

-- --------------------------------------------------------

--
-- Table structure for table `ledgercredit`
--

CREATE TABLE `ledgercredit` (
  `id` int(11) NOT NULL,
  `category` varchar(15) NOT NULL,
  `sub_category` varchar(15) NOT NULL,
  `invoice_no` varchar(15) NOT NULL,
  `invoice_date` varchar(100) NOT NULL,
  `invoice_value` double NOT NULL,
  `paid_value` double NOT NULL,
  `cash_or_cheque` varchar(15) NOT NULL,
  `bnn` int(11) NOT NULL,
  `user` varchar(15) NOT NULL,
  `igeshe` double NOT NULL,
  `week_no` varchar(100) NOT NULL,
  `date_no` varchar(100) NOT NULL,
  `datetimestamp` timestamp NOT NULL DEFAULT CURRENT_TIMESTAMP
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `ledgercredit`
--

INSERT INTO `ledgercredit` (`id`, `category`, `sub_category`, `invoice_no`, `invoice_date`, `invoice_value`, `paid_value`, `cash_or_cheque`, `bnn`, `user`, `igeshe`, `week_no`, `date_no`, `datetimestamp`) VALUES
(10, 'TEST1', 'FIRST', '1', '5/9/2020 12:12:56 AM', 1000, 1000, 'CASH', 1, 'test', 10000248336, '19', '130', '2020-05-08 18:43:07'),
(11, 'TEST1', 'FIRST', '2', '5/9/2020 12:12:56 AM', 1000, 1000, 'CASH', 2, 'test', 10000249336, '19', '130', '2020-05-08 18:43:13'),
(12, 'TEST1', 'FIRST', '3', '5/9/2020 12:12:56 AM', 1000, 1000, 'CASH', 3, 'test', 10000250336, '19', '130', '2020-05-08 18:43:17'),
(13, 'TEST1', 'FIRST', '4', '5/9/2020 12:12:56 AM', 1000, 1000, 'CASH', 4, 'test', 10000251336, '19', '130', '2020-05-08 18:43:20');

-- --------------------------------------------------------

--
-- Table structure for table `ledgerdebit`
--

CREATE TABLE `ledgerdebit` (
  `id` int(11) NOT NULL,
  `category` varchar(15) NOT NULL,
  `sub_category` varchar(15) NOT NULL,
  `invoice_no` varchar(15) NOT NULL,
  `invoice_date` varchar(100) NOT NULL,
  `invoice_value` double NOT NULL,
  `paid_value` double NOT NULL,
  `credited` double NOT NULL,
  `debited` double NOT NULL,
  `cash_or_cheque` varchar(15) NOT NULL,
  `bnn` int(11) NOT NULL,
  `user` varchar(15) NOT NULL,
  `igeshe` double NOT NULL,
  `week_no` varchar(100) NOT NULL,
  `date_no` varchar(100) NOT NULL,
  `timestamp` timestamp NOT NULL DEFAULT CURRENT_TIMESTAMP
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `ledgerdebit`
--

INSERT INTO `ledgerdebit` (`id`, `category`, `sub_category`, `invoice_no`, `invoice_date`, `invoice_value`, `paid_value`, `credited`, `debited`, `cash_or_cheque`, `bnn`, `user`, `igeshe`, `week_no`, `date_no`, `timestamp`) VALUES
(147, 'CHEQUE', 'NSB', '', '5/14/2020 1:16:01 AM', 10000, 10000, 10000, 0, 'CHEQUE', 0, 'test', 0, '20', '135', '2020-05-13 19:46:53'),
(148, 'CHEQUE', 'PEOPLES', '', '5/14/2020 1:16:25 AM', 20000, 20000, 0, 20000, 'CHEQUE', 0, 'test', 0, '20', '135', '2020-05-13 19:46:53'),
(149, 'TEST1', 'FIRST', '123', '5/14/2020 2:40:20 AM', 100000, 100000, 100000, 0, 'CASH', 12, 'test', 100000, '20', '135', '2020-05-13 21:10:35'),
(150, 'TEST1', 'FIRST', '12313', '5/14/2020 2:41:16 AM', 200000, 200000, 0, 200000, 'CASH', 33, 'test', 300000, '20', '135', '2020-05-13 21:11:47'),
(151, 'TEST1', 'FIRST', '1312', '5/14/2020 2:46:08 AM', 150000, 150000, 150000, 0, 'CASH', 21, 'test', 450000, '20', '135', '2020-05-13 21:16:20'),
(152, 'TEST1', 'FIRST', '1312', '5/14/2020 2:46:08 AM', 150000, 200000, 200000, 0, 'CASH', 21, 'test', 600000, '20', '135', '2020-05-13 21:16:47'),
(153, 'TEST1', 'FIRST', '123124', '5/14/2020 2:47:02 AM', 10000, 10000, 0, 10000, 'CASH', 231, 'test', 610000, '20', '135', '2020-05-13 21:17:19'),
(154, 'TEST1', 'FIRST', '0087', '5/14/2020 2:50:49 AM', 1.11111111111111e20, 1.11111111111111e20, 1.11111111111111e20, 0, 'CASH', 1, 'test', 1.11111111111112e20, '20', '135', '2020-05-13 21:21:13'),
(155, 'TEST1', 'FIRST', '0088', '5/14/2020 2:50:49 AM', 1.11111111111111e20, 2.22222222222222e20, 2.22222222222222e20, 0, 'CASH', 1, 'test', 2.22222222222223e20, '20', '135', '2020-05-13 21:21:28'),
(156, 'TEST1', 'FIRST', '121', '5/14/2020 2:51:38 AM', 3.33333333333333e21, 3.33333333333333e22, 0, 3.33333333333333e22, 'CASH', 12, 'test', 3.55555555555556e21, '20', '135', '2020-05-13 21:21:56'),
(157, 'TEST1', 'FIRST', '1312', '5/14/2020 2:54:11 AM', 1323, 4e19, 4e19, 0, 'CASH', 123, 'test', 3.55555555555556e21, '20', '135', '2020-05-13 21:24:21'),
(158, 'TEST1', 'FIRST', '1', '5/14/2020 2:55:10 AM', 1000000000, 1000000000, 1000000000, 0, 'CASH', 1, 'test', 3.55555555555656e21, '20', '135', '2020-05-13 21:25:25'),
(159, 'TEST1', 'FIRST', '1', '5/14/2020 2:55:10 AM', 1000000000, 2000000000, 2000000000, 0, 'CASH', 1, 'test', 3.55555555555756e21, '20', '135', '2020-05-13 21:25:30'),
(160, 'TEST1', 'FIRST', '12', '5/14/2020 2:55:31 AM', 21, 3000000000, 0, 3000000000, 'CASH', 12, 'test', 3.55555555555756e21, '20', '135', '2020-05-13 21:25:46'),
(161, 'TEST1', 'FIRST', '12', '5/14/2020 2:55:31 AM', 21, 4000000000, 0, 4000000000, 'CASH', 12, 'test', 3.55555555555756e21, '20', '135', '2020-05-13 21:25:50'),
(162, 'CHEQUE', 'PEOPLES', '', '5/14/2020 1:16:32 AM', 20000, 20000, 0, 20000, 'CHEQUE', 0, 'test', 0, '20', '136', '2020-05-15 18:21:05'),
(163, 'TEST1', 'FIRST', '12312', '5/16/2020 12:06:13 AM', 12312312, 123231, 0, 123231, 'CASH', 123123, 'test', 12312312, '20', '137', '2020-05-15 18:36:22'),
(164, 'TEST1', 'FIRST', '12312', '5/16/2020 12:41:40 AM', 12312, 123123, 0, 123123, 'CASH', 1321, 'test', 12324624, '20', '137', '2020-05-15 19:11:46'),
(165, 'TEST1', 'FIRST', '12312', '5/16/2020 12:42:57 AM', 12312, 12312, 0, 12312, 'CASH', 23213, 'test', 12336936, '20', '137', '2020-05-15 19:13:04'),
(166, 'TEST1', 'FIRST', '31232', '5/16/2020 12:43:47 AM', 3123, 12312, 12312, 0, 'CASH', 23213, 'test', 12340059, '20', '137', '2020-05-15 19:13:51'),
(167, 'TEST1', 'FIRST', '12312', '5/16/2020 12:45:00 AM', 123, 1, 1, 0, 'CASH', 12, 'test', 12340182, '20', '137', '2020-05-15 19:15:08'),
(168, 'TEST1', 'FIRST', '3213', '5/16/2020 12:58:44 AM', 12312, 2132, 2132, 0, 'CASH', 1312, 'test', 12352494, '20', '137', '2020-05-15 19:28:49'),
(169, 'TEST1', 'FIRST', '232', '5/22/2020 4:10:39 PM', 323, 232, 232, 0, 'CASH', 232, 'test', 12352817, '21', '143', '2020-05-20 10:40:52'),
(170, 'TEST1', 'FIRST', '111', '5/25/2020 1:14:09 AM', 1111, 1111, 1111, 0, 'CASH', 111, 'test', 12353928, '22', '146', '2020-05-24 19:44:13'),
(171, 'TEST1', 'FIRST', '12132', '5/25/2020 1:14:15 AM', 13213, 21312, 0, 21312, 'CASH', 111, 'test', 12367141, '22', '146', '2020-05-24 19:44:18'),
(172, 'TEST1', 'FIRST', '132', '5/25/2020 1:38:58 AM', 1000000, 1000000, 1000000, 0, 'CASH', 123, 'test', 13367141, '22', '146', '2020-05-24 20:09:17');

-- --------------------------------------------------------

--
-- Table structure for table `subcategories`
--

CREATE TABLE `subcategories` (
  `id` int(11) NOT NULL,
  `cname` varchar(15) NOT NULL,
  `sname` varchar(50) NOT NULL,
  `date` varchar(15) NOT NULL,
  `user` varchar(15) NOT NULL,
  `datetimesnap` timestamp NOT NULL DEFAULT CURRENT_TIMESTAMP
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `subcategories`
--

INSERT INTO `subcategories` (`id`, `cname`, `sname`, `date`, `user`, `datetimesnap`) VALUES
(8, 'TEST1', 'FIRST', '4/25/2020 9:07:', 'test', '2020-04-25 15:37:40'),
(9, 'TEST1', 'SECOND', '4/25/2020 9:07:', 'test', '2020-04-25 15:37:46'),
(10, 'TEST2', 'THIRD', '4/25/2020 9:07:', 'test', '2020-04-25 15:37:52'),
(11, 'TEST2', 'FOURTH', '4/25/2020 9:07:', 'test', '2020-04-25 15:37:59'),
(12, 'TES3', 'FIFTH', '4/25/2020 9:08:', 'test', '2020-04-25 15:38:06'),
(13, 'TES3', 'SIXTH', '4/25/2020 9:08:', 'test', '2020-04-25 15:38:10');

-- --------------------------------------------------------

--
-- Table structure for table `users`
--

CREATE TABLE `users` (
  `id` int(11) NOT NULL,
  `name` varchar(15) NOT NULL,
  `username` varchar(15) NOT NULL,
  `password` varchar(15) NOT NULL,
  `privilages` varchar(15) NOT NULL,
  `addedBy` varchar(15) NOT NULL,
  `datentime` timestamp NOT NULL DEFAULT CURRENT_TIMESTAMP
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `users`
--

INSERT INTO `users` (`id`, `name`, `username`, `password`, `privilages`, `addedBy`, `datentime`) VALUES
(1, 'root', 'root', 'root', '1', 'root', '2020-04-25 09:20:10'),
(3, 'INDUNIL', 'INDUNIL', 'ABC', '2', '----', '2020-05-10 20:11:56'),
(4, 'D', 'D', 'D', '1', 'ROOT', '2020-05-24 20:17:10'),
(5, 'F', 'F', 'F', '2', 'ROOT', '2020-05-24 20:17:16'),
(6, 'X', 'X', 'X', '1', 'ROOT', '2020-05-24 20:19:29'),
(7, 'XY', 'XY', 'XY', '2', 'ROOT', '2020-05-24 20:19:33');

--
-- Indexes for dumped tables
--

--
-- Indexes for table `categories`
--
ALTER TABLE `categories`
  ADD PRIMARY KEY (`id`);

--
-- Indexes for table `creditigeshe`
--
ALTER TABLE `creditigeshe`
  ADD PRIMARY KEY (`id`);

--
-- Indexes for table `dailytotal`
--
ALTER TABLE `dailytotal`
  ADD PRIMARY KEY (`id`);

--
-- Indexes for table `duecheques`
--
ALTER TABLE `duecheques`
  ADD PRIMARY KEY (`id`);

--
-- Indexes for table `ledgercredit`
--
ALTER TABLE `ledgercredit`
  ADD PRIMARY KEY (`id`);

--
-- Indexes for table `ledgerdebit`
--
ALTER TABLE `ledgerdebit`
  ADD PRIMARY KEY (`id`);

--
-- Indexes for table `subcategories`
--
ALTER TABLE `subcategories`
  ADD PRIMARY KEY (`id`);

--
-- Indexes for table `users`
--
ALTER TABLE `users`
  ADD PRIMARY KEY (`id`,`datentime`);

--
-- AUTO_INCREMENT for dumped tables
--

--
-- AUTO_INCREMENT for table `categories`
--
ALTER TABLE `categories`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=16;

--
-- AUTO_INCREMENT for table `creditigeshe`
--
ALTER TABLE `creditigeshe`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=3;

--
-- AUTO_INCREMENT for table `dailytotal`
--
ALTER TABLE `dailytotal`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=9;

--
-- AUTO_INCREMENT for table `duecheques`
--
ALTER TABLE `duecheques`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=6;

--
-- AUTO_INCREMENT for table `ledgercredit`
--
ALTER TABLE `ledgercredit`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=14;

--
-- AUTO_INCREMENT for table `ledgerdebit`
--
ALTER TABLE `ledgerdebit`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=173;

--
-- AUTO_INCREMENT for table `subcategories`
--
ALTER TABLE `subcategories`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=14;

--
-- AUTO_INCREMENT for table `users`
--
ALTER TABLE `users`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=8;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
