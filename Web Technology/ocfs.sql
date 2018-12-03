-- phpMyAdmin SQL Dump
-- version 4.2.11
-- http://www.phpmyadmin.net
--
-- Host: 127.0.0.1
-- Generation Time: May 07, 2015 at 04:43 AM
-- Server version: 5.6.21
-- PHP Version: 5.5.19

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8 */;

--
-- Database: `ocfs`
--

-- --------------------------------------------------------

--
-- Table structure for table `admin`
--

CREATE TABLE IF NOT EXISTS `admin` (
  `username` varchar(20) NOT NULL,
  `password` varchar(20) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `admin`
--

INSERT INTO `admin` (`username`, `password`) VALUES
('13-23200-1', 'liverpool');

-- --------------------------------------------------------

--
-- Table structure for table `banani`
--

CREATE TABLE IF NOT EXISTS `banani` (
  `report_type` varchar(50) NOT NULL,
  `complainant` varchar(50) NOT NULL,
  `caddress` varchar(50) NOT NULL,
  `cemail` varchar(50) NOT NULL,
  `cphone` varchar(50) NOT NULL,
  `suspect` varchar(50) NOT NULL,
  `nsuspect` varchar(50) NOT NULL,
  `saddress` varchar(50) NOT NULL,
  `arms` varchar(50) NOT NULL,
  `sphone` varchar(50) NOT NULL,
  `details` text NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `banani`
--

INSERT INTO `banani` (`report_type`, `complainant`, `caddress`, `cemail`, `cphone`, `suspect`, `nsuspect`, `saddress`, `arms`, `sphone`, `details`) VALUES
('General Diary(GD)', 'Simon Mignolet', 'Banani Dhaka', 'mignolet@gmail.com', '01857575758', 'Pepe Reina', '1', 'Banani Dhaka', 'Knife', '01667676767', 'Tried to kill me.\r\n'),
('General Diary(GD)', 'Koushik', 'Banani Dhaka', 'phkoumas@gmail.com', '01898567433', 'Jon flanagan', 'flanagan@gmail.com', 'Banani Dhaka', 'Riffle', '01899997573', 'threaten me with riffle.');

-- --------------------------------------------------------

--
-- Table structure for table `create_stations`
--

CREATE TABLE IF NOT EXISTS `create_stations` (
  `name` varchar(30) NOT NULL,
  `address` varchar(40) NOT NULL,
  `area` varchar(40) NOT NULL,
  `sp` varchar(40) NOT NULL,
  `addl_sp` varchar(40) NOT NULL,
  `s_asp` varchar(40) NOT NULL,
  `asp` varchar(40) NOT NULL,
  `inspector` int(40) NOT NULL,
  `sub_inspector` int(40) NOT NULL,
  `constable` int(40) NOT NULL,
  `username` varchar(30) NOT NULL,
  `password` varchar(30) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `create_stations`
--

INSERT INTO `create_stations` (`name`, `address`, `area`, `sp`, `addl_sp`, `s_asp`, `asp`, `inspector`, `sub_inspector`, `constable`, `username`, `password`) VALUES
('Banani Police Station', 'Banani', 'Banani, Dhaka', 'Adam Johnson', 'Alberto Moreno', 'Martin Skrtel', 'Sturridge', 3, 15, 12, '1002', 'banani'),
('Dhanmondi Police station', 'Dhanmondi', 'Dhanmondi, Dhaka', 'John Terry', 'Wayne Rooney', 'Hazzard', 'Oscar', 12, 12, 12, '1004', 'dhanmondi'),
('Motijheel Police Station', 'Motijheel', 'Motijheel, Dhaka', 'Lucas Leiva', 'Jordan henderson', 'Raheem Sterling', 'Mignolet', 2, 15, 4, '1001', 'motijheel'),
('New Market Police Station', 'NewMarket', 'New Market, Dhaka', 'Van Persi', 'Nasri', 'Yaya Toure', 'De Gea', 15, 16, 15, '1005', 'newmarket');

-- --------------------------------------------------------

--
-- Table structure for table `dhanmondi`
--

CREATE TABLE IF NOT EXISTS `dhanmondi` (
  `report_type` varchar(50) NOT NULL,
  `complainant` varchar(50) NOT NULL,
  `caddress` varchar(50) NOT NULL,
  `cemail` varchar(50) NOT NULL,
  `cphone` varchar(50) NOT NULL,
  `suspect` varchar(50) NOT NULL,
  `nsuspect` varchar(50) NOT NULL,
  `saddress` varchar(50) NOT NULL,
  `arms` varchar(50) NOT NULL,
  `sphone` varchar(50) NOT NULL,
  `details` text NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Table structure for table `login`
--

CREATE TABLE IF NOT EXISTS `login` (
  `username` varchar(20) NOT NULL,
  `firstname` varchar(20) NOT NULL,
  `lastname` varchar(20) NOT NULL,
  `gender` varchar(10) NOT NULL,
  `dob` varchar(10) NOT NULL,
  `house` varchar(15) NOT NULL,
  `road` varchar(10) NOT NULL,
  `area` varchar(25) NOT NULL,
  `postal` varchar(10) NOT NULL,
  `email` varchar(50) NOT NULL,
  `phone` varchar(15) NOT NULL,
  `password` varchar(20) NOT NULL,
  `repassword` varchar(20) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `login`
--

INSERT INTO `login` (`username`, `firstname`, `lastname`, `gender`, `dob`, `house`, `road`, `area`, `postal`, `email`, `phone`, `password`, `repassword`) VALUES
('KoushikGerrard', 'Koushik', 'Gerrard', 'Male', '07/04/1993', '12', '04', 'Azimpur, Dhaka', '1239', 'phkoumas@gmail.com', '01554771132', '12345qQ', '12345qQ'),
('LucasLFC', 'Lucas', 'Leiva', 'Male', '09/01/1987', '12', 'Shahid Roa', 'Farmgate, Dhaka', '1432', 'lucas@gmail.com', '01554771132', '123456qQ', '123456qQ'),
('StevenGerrard', 'Steven', 'Gerrard', 'Male', '31/05/1981', '2', '3', 'Banani Dhaka', '2314', 'gerrard@liverpool.com', '01756847582', '123456qQ', '123456qQ');

-- --------------------------------------------------------

--
-- Table structure for table `missing`
--

CREATE TABLE IF NOT EXISTS `missing` (
`id` int(11) NOT NULL,
  `location` varchar(100) NOT NULL,
  `caption` varchar(100) NOT NULL
) ENGINE=MyISAM AUTO_INCREMENT=9 DEFAULT CHARSET=latin1;

--
-- Dumping data for table `missing`
--

INSERT INTO `missing` (`id`, `location`, `caption`) VALUES
(1, 'photos/7468__1363__17._sakho.jpg', 'M. Shako 1988'),
(2, 'photos/4062__6627__21._lucas.jpg', 'Lucas Leiva 1987'),
(3, 'photos/1339__6820__31._sterling.jpg', 'Raheem Sterling 1994'),
(4, 'photos/4025__6748__22._mignolet.jpg', 'Simon Mignolet 1988'),
(5, 'photos/1404__3717__15._sturridge.jpg', 'Daniel Sturridge 1989'),
(7, 'photos/5076__9063__9._lambert.jpg', 'Rickie Lambet 1980');

-- --------------------------------------------------------

--
-- Table structure for table `motijheel`
--

CREATE TABLE IF NOT EXISTS `motijheel` (
  `report_type` varchar(50) NOT NULL,
  `complainant` varchar(50) NOT NULL,
  `caddress` varchar(50) NOT NULL,
  `cemail` varchar(50) NOT NULL,
  `cphone` varchar(50) NOT NULL,
  `suspect` varchar(50) NOT NULL,
  `nsuspect` varchar(50) NOT NULL,
  `saddress` varchar(50) NOT NULL,
  `arms` varchar(50) NOT NULL,
  `sphone` varchar(50) NOT NULL,
  `details` text NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `motijheel`
--

INSERT INTO `motijheel` (`report_type`, `complainant`, `caddress`, `cemail`, `cphone`, `suspect`, `nsuspect`, `saddress`, `arms`, `sphone`, `details`) VALUES
('General Diary(GD)', 'Daniel Agger', 'Motijheel, Dhaka', 'agger@gmail.com', '01768567433', 'Wanye Rooney', '1', 'Motijheel, Dhaka', 'Riffle', '01873547573', 'Yesterday came to my house and tried to kill me with his riffle but fortunately I was saved.'),
('General Diary(GD)', 'Shakib AL Hasan', 'Motijheel, Dhaka', 'shakib@gmail.com', '01925647472', 'Aleem Dhar', '1', 'Motijheel, Dhaka', 'Knife', '16787878787', 'Tried to destroy me..'),
('General Diary(GD)', 'John Terry', 'Banani Dhaka', 'terry@ymail.com', '01678274456', 'Messi', '2', 'Banani Dhaka', 'Riffle', '01873547573', 'Threaten me with his riffle.');

-- --------------------------------------------------------

--
-- Table structure for table `newmarket`
--

CREATE TABLE IF NOT EXISTS `newmarket` (
  `report_type` varchar(50) NOT NULL,
  `complainant` varchar(50) NOT NULL,
  `caddress` varchar(50) NOT NULL,
  `cemail` varchar(50) NOT NULL,
  `cphone` varchar(50) NOT NULL,
  `suspect` varchar(50) NOT NULL,
  `nsuspect` varchar(50) NOT NULL,
  `saddress` varchar(50) NOT NULL,
  `arms` varchar(50) NOT NULL,
  `sphone` varchar(50) NOT NULL,
  `details` text NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `newmarket`
--

INSERT INTO `newmarket` (`report_type`, `complainant`, `caddress`, `cemail`, `cphone`, `suspect`, `nsuspect`, `saddress`, `arms`, `sphone`, `details`) VALUES
('General Diary(GD)', 'Jose Enrique', 'New Market, Dhaka', 'enrique@ymail.com', '01785858522', 'John Terry', '1', 'New Market, Dhaka', 'Riffle', '01675757575', 'threaten me.......');

-- --------------------------------------------------------

--
-- Table structure for table `news`
--

CREATE TABLE IF NOT EXISTS `news` (
`id` int(20) NOT NULL,
  `file` varchar(40) NOT NULL,
  `type` varchar(40) NOT NULL,
  `size` int(20) NOT NULL,
  `caption` text NOT NULL
) ENGINE=InnoDB AUTO_INCREMENT=9 DEFAULT CHARSET=latin1;

--
-- Dumping data for table `news`
--

INSERT INTO `news` (`id`, `file`, `type`, `size`, `caption`) VALUES
(2, '8299-lfc1.txt', 'text/plain', 1, 'Captain Steven Gerrard grabbed a late winner for Liverpool.'),
(3, '66673-lfc2.txt', 'text/plain', 2, 'Brendan Rodgers on Daniel Sturridge & Steven Gerrard.'),
(4, '39620-lfc3.txt', 'text/plain', 0, 'Jon Flanagan out for six to nine months.'),
(5, '22097-lfc.txt', 'text/plain', 1, 'Anti-Brendan Rodgers plane banner flown over Anfield.'),
(7, '60023-lfc4.docx', 'application/vnd.openxmlformats-officedoc', 13, 'Liverpool boss says squad playing for futures.'),
(8, '89166-m.docx', 'application/vnd.openxmlformats-officedoc', 29, 'Survey Questionnaire for Software Engineering.');

-- --------------------------------------------------------

--
-- Table structure for table `photos`
--

CREATE TABLE IF NOT EXISTS `photos` (
`id` int(11) NOT NULL,
  `location` varchar(100) NOT NULL,
  `caption` tinytext NOT NULL
) ENGINE=MyISAM AUTO_INCREMENT=12 DEFAULT CHARSET=latin1;

--
-- Dumping data for table `photos`
--

INSERT INTO `photos` (`id`, `location`, `caption`) VALUES
(5, 'photos/0976__5759__454322570.jpg', 'Mario balotelli 1988'),
(6, 'photos/7148__8702__10._coutinho.jpg', 'P. Coutinho 1991'),
(9, 'photos/5349__8304__jonathan_flanagan_green.jpg', 'Jon Flanagan 1991'),
(8, 'photos/5282__9448__14._henderson.jpg', 'Jordan henderson 1990'),
(10, 'photos/2215__5724__adam_lallana_green.jpg', 'Adam Lallana 1990');

--
-- Indexes for dumped tables
--

--
-- Indexes for table `admin`
--
ALTER TABLE `admin`
 ADD UNIQUE KEY `username` (`username`);

--
-- Indexes for table `banani`
--
ALTER TABLE `banani`
 ADD PRIMARY KEY (`cemail`,`cphone`);

--
-- Indexes for table `create_stations`
--
ALTER TABLE `create_stations`
 ADD UNIQUE KEY `name` (`name`,`username`);

--
-- Indexes for table `dhanmondi`
--
ALTER TABLE `dhanmondi`
 ADD PRIMARY KEY (`cemail`,`cphone`);

--
-- Indexes for table `login`
--
ALTER TABLE `login`
 ADD UNIQUE KEY `username` (`username`,`email`,`phone`);

--
-- Indexes for table `missing`
--
ALTER TABLE `missing`
 ADD PRIMARY KEY (`id`);

--
-- Indexes for table `motijheel`
--
ALTER TABLE `motijheel`
 ADD PRIMARY KEY (`cemail`,`cphone`);

--
-- Indexes for table `newmarket`
--
ALTER TABLE `newmarket`
 ADD PRIMARY KEY (`cemail`,`cphone`);

--
-- Indexes for table `news`
--
ALTER TABLE `news`
 ADD PRIMARY KEY (`id`);

--
-- Indexes for table `photos`
--
ALTER TABLE `photos`
 ADD PRIMARY KEY (`id`);

--
-- AUTO_INCREMENT for dumped tables
--

--
-- AUTO_INCREMENT for table `missing`
--
ALTER TABLE `missing`
MODIFY `id` int(11) NOT NULL AUTO_INCREMENT,AUTO_INCREMENT=9;
--
-- AUTO_INCREMENT for table `news`
--
ALTER TABLE `news`
MODIFY `id` int(20) NOT NULL AUTO_INCREMENT,AUTO_INCREMENT=9;
--
-- AUTO_INCREMENT for table `photos`
--
ALTER TABLE `photos`
MODIFY `id` int(11) NOT NULL AUTO_INCREMENT,AUTO_INCREMENT=12;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
