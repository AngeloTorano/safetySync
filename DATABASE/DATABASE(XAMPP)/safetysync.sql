-- phpMyAdmin SQL Dump
-- version 5.2.1
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Generation Time: Dec 08, 2023 at 06:26 PM
-- Server version: 10.4.28-MariaDB
-- PHP Version: 8.2.4

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `safetysync`
--

-- --------------------------------------------------------

--
-- Table structure for table `admin_accounts`
--

CREATE TABLE `admin_accounts` (
  `admin_id` int(11) NOT NULL,
  `name` varchar(100) NOT NULL,
  `adminusername` varchar(50) NOT NULL,
  `adminpassword` varchar(255) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `admin_accounts`
--

INSERT INTO `admin_accounts` (`admin_id`, `name`, `adminusername`, `adminpassword`) VALUES
(41, 'admin', 'admin', '8c6976e5b5410415bde908bd4dee15dfb167a9c873fc4bb8a81f6f2ab448a918'),
(44, 'angelo', 'angelo', 'b6f2920002873556366ad9f9a44711e4f34b596a892bd175427071e4064a89cc'),
(47, 'marie123', 'marie', 'c6d17a3613b9914e68707fcfac8410f097643bc5840681bb533030d73cbb18f8'),
(51, 'luis', 'luis', 'c5ff177a86e82441f93e3772da700d5f6838157fa1bfdc0bb689d7f7e55e7aba'),
(57, 'Mark', 'kiwi', '1a5afeda973d776e31d1d7266f184468f84d99bed311d88d3dcb67015934f9f9'),
(58, 'King', 'yara', 'a38933a27dad50fd2ed7cf588ca553d2b4d1fc704e103dc99b22cb13a32bba56'),
(59, 'marie', 'marie123', 'c6d17a3613b9914e68707fcfac8410f097643bc5840681bb533030d73cbb18f8'),
(60, 'alex', 'alex', '4135aa9dc1b842a653dea846903ddb95bfb8c5a10c504a7fa16e10bc31d1fdf0'),
(61, 'kris', 'kris', 'd999056550fd648de6de0537f389c3da467f846a4fd6117a62cb54ba1c23cf3c'),
(62, 'rusette', 'rusette', 'c6d17a3613b9914e68707fcfac8410f097643bc5840681bb533030d73cbb18f8');

-- --------------------------------------------------------

--
-- Table structure for table `cashistory`
--

CREATE TABLE `cashistory` (
  `catastrophicHistory_id` int(11) NOT NULL,
  `disasterEvent` varchar(250) NOT NULL,
  `catastrophicHistory` text DEFAULT NULL,
  `category` varchar(100) DEFAULT NULL,
  `provinceName` varchar(100) NOT NULL,
  `province_id` int(11) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `cashistory`
--

INSERT INTO `cashistory` (`catastrophicHistory_id`, `disasterEvent`, `catastrophicHistory`, `category`, `provinceName`, `province_id`) VALUES
(1, 'Flooding and Landslides', 'On the 23rd of July in 2018, Cavite declares state of calamity due to widespread floods.', 'Low', 'Cavite', 1),
(2, 'Storm Surges', 'The Esperanza Bridge in Cavite’s upland town of Alfonso collapses as bridge easement and abutment foundation give way due to soil erosion, splitting the 50-meter bridge span in two, triggered by heavy rains and storm surge on Aug. 12, 2018.', 'Low to Moderate', 'Cavite', 1),
(3, 'Volcanic Hazards', 'On September 22, 2023, Taal Volcano emitted high levels of hazardous sulfur dioxide in the province of Cavite.', 'High', 'Cavite', 1),
(4, 'Earthquake', 'On October 13, 2023, magnitude 5.0 earthquake hits the province of Cavite.', 'Moderate', 'Cavite', 1),
(5, 'Typhoon', 'On the 29th of October in 2022, severe tropical storm Paeng hits the Cavite as it crossed in its northern part.', 'High', 'Cavite', 1),
(6, 'Flooding and Landslides', 'Four people died in a landslide that struck a remote village in the Sierra Madre Mountain range in General Nakar town, Quezon province on October 26, 2023.', 'High', 'Quezon', 5),
(7, 'Storm Surges', 'On September 25, 2022, Super Typhoon Karding caused a strong storm surge. The storm was packing maximum sustained wind speeds of 125mph (195km/h) after an unprecedented “explosive intensification”, the state weather forecaster said.', 'High', 'Quezon', 5),
(8, 'Volcanic Hazards', 'In 1730, Mount Banahaw erupted and made a deep crater that breached on the southern rim. The resulting eruption destroyed the town of Sariaya, Quezon located below the mountain.', 'High', 'Quezon', 5),
(9, 'Tsunami', NULL, NULL, 'Quezon', 5),
(10, 'Earthquake', 'A magnitude 4.8-earthquake struck the waters off Jomalig town in Quezon province on February 20, 2023.', 'Medium', 'Quezon', 5),
(11, 'Typhoon', 'Quezon province’s provincial disaster management operation center was placed on red alert status by Governor Angelina Tan on September 25, 2022, as Super Typhoon Karding (international name: Noru) roars closer to land.', 'High', 'Quezon', 5),
(12, 'Flooding and Landslides', 'Typhoon Falcon and the enhanced Southwest Monsoon or Habagat have displaced 1,554 families in Rizal and Cavite and caused flooding in both provinces on August 1, 2023.', 'Low to High', 'Rizal', 4),
(13, 'Storm Surges', NULL, NULL, 'Rizal', 4),
(14, 'Volcanic Hazards', 'On September 26, 2023, vog or smog from the Taal Volcano continues to emit that affects people in Rizal.', 'High', 'Rizal', 4),
(15, 'Tsunami', NULL, NULL, 'Rizal', 4),
(16, 'Earthquake', 'Two earthquakes that came within an hour of each other shook the province of Rizal and parts of Metro Manila before dawn on August 8, 2017 according to Phivolcs.', 'Medium', 'Rizal', 4),
(17, 'Typhoon', 'In 2014, the whole province of Batangas was placed under a state of calamity after it suffered millions of pesos worth of damage to infrastructure and agriculture due to Typhoon Glenda.', 'High', 'Rizal', 4),
(18, 'Flooding and Landslides', 'Typhoon Jolina, in 2021, brought extensive flooding, and rain-induced landslides, bringing a damaging gale-force to storm-force winds.', 'Low to High', 'Batangas', 3),
(19, 'Storm Surges', 'During the Typhoon Glenda in 2014, storm surge hazard reaches the inland portion primarily due to the presence of streams.', 'Low to High', 'Batangas', 3),
(20, 'Volcanic Hazards', 'On March 26, 2022, alert level 3 was recorded due to the volcanic activities of Taal Volcano. There has been a magmatic intrusion at the main crater that may succeed into an eruption.', 'High', 'Batangas', 3),
(21, 'Tsunami', NULL, NULL, 'Batangas', 3),
(22, 'Earthquake', 'On October 13, 2023, magnitude 5.0 earthquake hits the province of Batangas.', 'Medium', 'Batangas', 3),
(23, 'Typhoon', 'In 2014, the whole province of Batangas was placed under a state of calamity after it suffered millions of pesos worth of damage to infrastructure and agriculture due to Typhoon Glenda.', 'High', 'Batangas', 3),
(30, 'Flooding and Landsides', 'On November 24, 2020, City of San Pedro in Laguna was left flooded for days after Typhoon Ulysses happened. The flood remained under knee-to-waist-deep.', 'High', 'Laguna', 2),
(31, 'Storm Surges', 'In 2020, strong waves were seen in Laguna Lake as the water kept rising, threatening lakeshore communities in Laguna.', 'High', 'Laguna', 2),
(32, 'Volcanic Hazards', 'On the 22nd of September in 2023, Laguna experienced a volcanic smog from the Taal Volcano, leaving the residents with the risk of being ill.', 'High', 'Laguna', 2),
(34, 'Earthquake', 'On August 11, 2017, intensity II was recorded in Laguna after the 6.3 magnitude earthquake that happened.', 'Medium', 'Laguna', 2),
(35, 'Typhoon', 'April 12, 2022, Typhoon Malakas landed and hit the province of Laguna, leaving some casualties and damages.', 'High', 'Laguna', 2),
(37, 'Tsunami', NULL, NULL, 'Laguna', 2);

-- --------------------------------------------------------

--
-- Table structure for table `hotline`
--

CREATE TABLE `hotline` (
  `hotline_id` int(11) NOT NULL,
  `agency` varchar(100) NOT NULL,
  `hotlineNumber` varchar(100) DEFAULT NULL,
  `provinceName` varchar(100) NOT NULL,
  `province_id` int(11) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `hotline`
--

INSERT INTO `hotline` (`hotline_id`, `agency`, `hotlineNumber`, `provinceName`, `province_id`) VALUES
(1, 'Police Station (PNP)', '0920 979 6911', 'Quezon', 5),
(2, 'Fire Station', '(02) 8426 0219', 'Quezon', 5),
(3, 'PDRRM', '0946 274 8706', 'Quezon', 5),
(4, 'Police Station (PNP)', '(049) 502 6535', 'Laguna', 2),
(5, 'Fire Station', '(049) 530-2285', 'Laguna', 2),
(6, 'PDRRM', '0917 417 3698', 'Laguna', 2),
(7, 'Police Station (PNP)', '0917-143-1580', 'Batangas', 3),
(8, 'Fire Station', '(049) 530-2285', 'Batangas', 3),
(9, 'PDRRM', '(043) 723 9350', 'Batangas', 3),
(10, 'Police Station (PNP)', '09164291515 / 09989673414', 'Rizal', 4),
(11, 'Fire Station', '09201725254', 'Rizal', 4),
(12, 'PDRRM', '911-14-06', 'Rizal', 4),
(13, 'Police Station (PNP)', '09184626623', 'Cavite', 1),
(14, 'Fire Station', '(046) 431-0380', 'Cavite', 1),
(15, 'PDRRM', '0917 – 858 8263', 'Cavite', 1);

-- --------------------------------------------------------

--
-- Table structure for table `province`
--

CREATE TABLE `province` (
  `province_id` int(11) NOT NULL,
  `provinceName` varchar(100) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `province`
--

INSERT INTO `province` (`province_id`, `provinceName`) VALUES
(1, 'CAVITE'),
(2, 'LAGUNA'),
(3, 'BATANGAS'),
(4, 'RIZAL'),
(5, 'QUEZON');

--
-- Indexes for dumped tables
--

--
-- Indexes for table `admin_accounts`
--
ALTER TABLE `admin_accounts`
  ADD PRIMARY KEY (`admin_id`);

--
-- Indexes for table `cashistory`
--
ALTER TABLE `cashistory`
  ADD PRIMARY KEY (`catastrophicHistory_id`),
  ADD KEY `province_id` (`province_id`);

--
-- Indexes for table `hotline`
--
ALTER TABLE `hotline`
  ADD PRIMARY KEY (`hotline_id`),
  ADD KEY `province_id` (`province_id`);

--
-- Indexes for table `province`
--
ALTER TABLE `province`
  ADD PRIMARY KEY (`province_id`);

--
-- AUTO_INCREMENT for dumped tables
--

--
-- AUTO_INCREMENT for table `admin_accounts`
--
ALTER TABLE `admin_accounts`
  MODIFY `admin_id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=63;

--
-- AUTO_INCREMENT for table `cashistory`
--
ALTER TABLE `cashistory`
  MODIFY `catastrophicHistory_id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=45;

--
-- AUTO_INCREMENT for table `hotline`
--
ALTER TABLE `hotline`
  MODIFY `hotline_id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=23;

--
-- AUTO_INCREMENT for table `province`
--
ALTER TABLE `province`
  MODIFY `province_id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=6;

--
-- Constraints for dumped tables
--

--
-- Constraints for table `cashistory`
--
ALTER TABLE `cashistory`
  ADD CONSTRAINT `cashistory_ibfk_1` FOREIGN KEY (`province_id`) REFERENCES `province` (`province_id`);

--
-- Constraints for table `hotline`
--
ALTER TABLE `hotline`
  ADD CONSTRAINT `hotline_ibfk_1` FOREIGN KEY (`province_id`) REFERENCES `province` (`province_id`);
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
