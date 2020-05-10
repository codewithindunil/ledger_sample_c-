-- phpMyAdmin SQL Dump
-- version 4.8.3
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Generation Time: May 10, 2020 at 11:07 PM
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
(14, 'tes3', '4/25/2020 9:07:', 'test', '2020-04-25 15:37:28');

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
(2, '10000255038', '12');

-- --------------------------------------------------------

--
-- Table structure for table `duecheques`
--

CREATE TABLE `duecheques` (
  `id` int(11) NOT NULL,
  `chequeNo` varchar(100) NOT NULL,
  `chequeValue` varchar(100) NOT NULL,
  `bankName` varchar(100) NOT NULL,
  `invoiceId` varchar(100) NOT NULL,
  `dueDayNo` varchar(100) NOT NULL,
  `dueWeekNo` varchar(100) NOT NULL,
  `dueDate` datetime NOT NULL,
  `enteredDate` timestamp NOT NULL DEFAULT CURRENT_TIMESTAMP
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

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

INSERT INTO `ledgerdebit` (`id`, `category`, `sub_category`, `invoice_no`, `invoice_date`, `invoice_value`, `paid_value`, `cash_or_cheque`, `bnn`, `user`, `igeshe`, `week_no`, `date_no`, `timestamp`) VALUES
(7, 'TEST1', 'FIRST', '2113', '5/8/2020 9:54:39 PM', 31, 13, 'CASH', 121, 'test', 10000247213, '19', '129', '2020-05-08 16:24:45'),
(8, 'TEST1', 'FIRST', '1', '5/9/2020 12:13:22 AM', 1234, 1234, 'CASH', 1, 'test', 10000252570, '19', '130', '2020-05-08 18:43:31'),
(9, 'TEST1', 'FIRST', '2', '5/9/2020 12:13:22 AM', 1234, 1234, 'CASH', 2, 'test', 10000253804, '19', '130', '2020-05-08 18:43:34'),
(10, 'TEST1', 'FIRST', '3', '5/9/2020 12:13:22 AM', 1234, 1234, 'CASH', 3, 'test', 10000255038, '19', '130', '2020-05-08 18:43:38');

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
(3, 'INDUNIL', 'INDUNIL', 'ABC', '2', '----', '2020-05-10 20:11:56');

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
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=15;

--
-- AUTO_INCREMENT for table `creditigeshe`
--
ALTER TABLE `creditigeshe`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=3;

--
-- AUTO_INCREMENT for table `duecheques`
--
ALTER TABLE `duecheques`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT;

--
-- AUTO_INCREMENT for table `ledgercredit`
--
ALTER TABLE `ledgercredit`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=14;

--
-- AUTO_INCREMENT for table `ledgerdebit`
--
ALTER TABLE `ledgerdebit`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=11;

--
-- AUTO_INCREMENT for table `subcategories`
--
ALTER TABLE `subcategories`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=14;

--
-- AUTO_INCREMENT for table `users`
--
ALTER TABLE `users`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=4;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
