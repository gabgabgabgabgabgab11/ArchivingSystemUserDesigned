-- phpMyAdmin SQL Dump
-- version 5.2.1
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Generation Time: Jul 01, 2025 at 07:13 AM
-- Server version: 10.4.32-MariaDB
-- PHP Version: 8.2.12

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `academic_archive`
--

-- --------------------------------------------------------

--
-- Table structure for table `activity_log`
--

CREATE TABLE `activity_log` (
  `id` int(11) NOT NULL,
  `timestamp` datetime NOT NULL,
  `username` varchar(100) NOT NULL,
  `action` varchar(20) NOT NULL,
  `document_title` varchar(255) NOT NULL,
  `document_type` varchar(100) DEFAULT NULL,
  `details` text DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `activity_log`
--

INSERT INTO `activity_log` (`id`, `timestamp`, `username`, `action`, `document_title`, `document_type`, `details`) VALUES
(1, '2025-06-30 15:13:00', 'The Admin', 'Edited', 'Updated', 'OTHERS', 'Edited document details'),
(2, '2025-06-30 15:16:48', 'Admin', 'Deleted', 'Research Document', 'RESEARCH/THESIS', 'Deleted document'),
(3, '2025-06-30 15:31:20', 'The Admin', 'Added', 'A Web Based Thesis Management System for Polytechnic University of the Philippines Sta Maria Bulacan Campus', NULL, 'Added a new document'),
(4, '2025-06-30 15:43:26', 'The Admin', 'Added', 'Web-based Sales and Inventory Management System For Inocentes Hot\'s and Huts', NULL, 'Added a new document'),
(5, '2025-06-30 15:54:55', 'The Admin', 'Added', 'THESIS PORTAL FOR PUPSMBC', NULL, 'Added a new document'),
(6, '2025-06-30 15:58:47', 'The Admin', 'Added', 'ISKOalifiers: PUPSMB Scholarship Portal', NULL, 'Added a new document'),
(7, '2025-06-30 16:02:59', 'The Admin', 'Added', 'General Mathematics Proficiency Level of Grade 12 Students of Fortunato F. Halili National Agricultural School AY. 2018-2029', NULL, 'Added a new document'),
(8, '2025-06-30 16:23:39', 'The Admin', 'Added', 'sample', NULL, 'Added a new document'),
(9, '2025-06-30 16:24:02', 'The Admin', 'Deleted', 'sample', 'RESEARCH/THESIS', 'Deleted document'),
(10, '2025-06-30 16:36:57', 'The Admin', 'Added', 'Improving English Vocabulary Sills of First — Year Education', NULL, 'Added a new document'),
(11, '2025-06-30 16:39:47', 'The Admin', 'Added', 'Leading to Quality Education: A Phenomenological Exploration on the Use of Gamification in Teaching Mathematics', NULL, 'Added a new document'),
(12, '2025-06-30 16:41:52', 'The Admin', 'Added', 'Senior High School Students’ Numeracy Skills and Influential Factor or Readiness for College Mathematics', NULL, 'Added a new document'),
(13, '2025-06-30 16:44:52', 'The Admin', 'Added', 'The Use of Rewordify: A Tool for Enhancing Reading Comprehension', NULL, 'Added a new document'),
(14, '2025-06-30 16:48:58', 'The Admin', 'Added', 'Overcoming the Crisis: The impact of COVID-19 Pandemic on the Financial Performance of Chicharon Manufacturers in the Municipality of Santa Maria, Bulacan', NULL, 'Added a new document'),
(15, '2025-06-30 16:52:32', 'The Admin', 'Added', 'E-Commerce in the Times of Pandemic: Impact on the Sales Performance of Oniine Clothing Businesses in Sta. Maria, Bulacan', NULL, 'Added a new document'),
(16, '2025-06-30 16:57:42', 'The Admin', 'Added', 'The Perception of Selected Accountancy Undergraduate Students on the Effectiveness of Oniine Delivery System Of Learning amidst COVID-19 Pandemic', NULL, 'Added a new document'),
(17, '2025-06-30 17:02:21', 'The Admin', 'Added', 'Factors Affecting the Wilingness of Businesses Under Micro, Small, and Medium Enterprises to Shift from Manual Accounting Systems lo Computerized Accounting Systems', NULL, 'Added a new document'),
(18, '2025-06-30 17:06:11', 'The Admin', 'Added', 'Survival Amidst Pandemic: An Assessment of the Effectivenass of Strategy Adaptation of the Effectivenass of Strategy Adaptation of Micro Service Businesses in Santa Maria, Bulacan', NULL, 'Added a new document'),
(19, '2025-06-30 17:06:38', 'The Admin', 'Edited', 'Survival Amidst Pandemic: An Assessment of the Effectivenass of Strategy Adaptation of the Effectivenass of Strategy Adaptation of Micro Service Businesses in Santa Maria, Bulacan', 'RESEARCH/THESIS', 'Edited document details'),
(20, '2025-06-30 17:12:17', 'The Admin', 'Added', 'Lock and Go: An Arduino-based Smart Door Lock System Using Two-factor Authentication with SMS Alert', NULL, 'Added a new document'),
(21, '2025-06-30 17:15:14', 'The Admin', 'Added', 'IoT and Non-IoT: Automated Garage with Burglary Alarm System and SensoMatic Control', NULL, 'Added a new document'),
(22, '2025-06-30 17:17:11', 'The Admin', 'Added', 'SMART BROODING SYSTEM FOR QUAILS WITH MOBILE MONITORING', NULL, 'Added a new document'),
(23, '2025-06-30 17:19:15', 'The Admin', 'Added', 'Intelligent Robowaiter Using Fuzzy Logic', NULL, 'Added a new document'),
(24, '2025-06-30 17:34:26', 'The Admin', 'Added', 'Evolution of Financial Markets, Institutions, and Relevance to Business Finance', NULL, 'Added a new document'),
(25, '2025-06-30 17:37:36', 'The Admin', 'Added', 'Factors affecting Employees Attrition in selected Manufacturing companies in Santa Maria Bulacan', NULL, 'Added a new document'),
(26, '2025-06-30 17:44:59', 'The Admin', 'Added', 'Assestment of PUPSMB Students in tha Service Provided by the Convenience store at the Sta. Maria Bulacan', NULL, 'Added a new document'),
(27, '2025-06-30 17:47:26', 'The Admin', 'Added', 'Proper Selection of Business for Future Entepreneur in Terms of Capital at Pulong Buhangin Santa Maria Bulacan', NULL, 'Added a new document'),
(28, '2025-06-30 17:51:29', 'The Admin', 'Added', 'THE IMPACT OF PHYSICAL ENVIRONMENT OF A COFFEE SHOP IN A CUSTOMERS HEDONIC VALUE', NULL, 'Added a new document');

-- --------------------------------------------------------

--
-- Table structure for table `departments`
--

CREATE TABLE `departments` (
  `id` int(11) NOT NULL,
  `name` varchar(100) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `departments`
--

INSERT INTO `departments` (`id`, `name`) VALUES
(1, 'Information Technology'),
(2, 'Computer Engineering'),
(3, 'Education'),
(4, ' Office Management Technology'),
(5, 'Hospitality Management'),
(6, 'Bachelor of Science in Accountancy'),
(7, 'ENTREPENEURSHIP');

-- --------------------------------------------------------

--
-- Table structure for table `documents`
--

CREATE TABLE `documents` (
  `id` int(11) NOT NULL,
  `title` varchar(255) NOT NULL,
  `authors` varchar(255) NOT NULL,
  `type_id` int(11) NOT NULL,
  `description` text DEFAULT NULL,
  `year_published` int(11) DEFAULT NULL,
  `file_path` varchar(500) NOT NULL,
  `date_archived` datetime DEFAULT current_timestamp(),
  `department_id` int(11) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `documents`
--

INSERT INTO `documents` (`id`, `title`, `authors`, `type_id`, `description`, `year_published`, `file_path`, `date_archived`, `department_id`) VALUES
(2, 'Sample Document', 'Sample Author', 1, 'asdfasdasdasdadada', 2025, 'C:\\ArchivePDFs\\RegistrationCertificate (3).pdf', '2025-06-14 11:13:13', 1),
(4, 'A NARATIVE REPORT ON THE INTERSHIP UNDERTAKEN AT THE MELHAM CONSTRUCTION CORPORATION', 'MS. RYZZA P. PASCUAL', 2, NULL, 2025, '', '2022-07-01 00:00:00', 1),
(5, 'A NARATIVE REPORT ON THE INTERSHIP UNDERTAKEN AT THE GYSNC SOLUTIONS PHILIPPINES', 'MR. FLORENZ ALCANTARA', 2, NULL, 2025, '', '2022-07-01 00:00:00', 1),
(6, 'A NARATIVE REPORT ON THE INTERSHIP UNDERTAKEN AT THE TOP BLISS SOLUTIONS, INC.', 'MS. ANGELICA C. HERMOSO', 2, NULL, 2025, '', '2022-07-01 00:00:00', 1),
(7, 'A NARATIVE REPORT ON THE INTERSHIP UNDERTAKEN AT THE MELHAM CONSTRUCTION CORPORATION', 'MR. FRANCIS JOHN R. ZARATE', 2, NULL, 2025, '', '2022-07-01 00:00:00', 1),
(8, 'ONLINE BOOKING SYSTEM FOR ZC MASSAGE CLINIC', 'MS. APPLE JOYCE J. PIALA', 2, NULL, 2025, '', '2022-06-01 00:00:00', 1),
(9, 'A NARATIVE REPORT ON THE INTERNSHIP AT THE MYVATEAM, INC.', 'MS. LUISA MAE L. PETALLANA', 2, NULL, 2025, '', '2022-06-01 00:00:00', 1),
(10, 'A NARATIVE REPORT ON THE INTERNSHIP PRACTICUM FOR TESDASOLOLEARN AND HACKERHERO', 'MR. GILBERT V. GALVIZO', 2, NULL, 2025, '', '2021-07-01 00:00:00', 1),
(11, 'A NARATIVE REPORT ON THE INTERNSHIP UNDERTAKEN AT THE MAROONSTUDIOS LTD.', 'MS. JENNIFER GERONIMO', 2, NULL, 2025, '', '2021-07-01 00:00:00', 1),
(12, 'A NARATIVE REPORT ON THE INTERNSHIP UNDERTAKEN AT THE SOLOLEARN , HACKERHERO, AND TESDA', 'MS. JUDY ANDREIH F. GUITIERREZ', 2, NULL, 2025, '', '2021-07-01 00:00:00', 1),
(13, 'A NARATIVE REPORT ON THE INTERNSHIP UNDERTAKEN AT THE TOBIRA CO., LTD', 'MR. FRANCIS LESTER N. MACALINTAL', 2, NULL, 2025, '', '2021-07-01 00:00:00', 1),
(14, 'A NAARRATIVE REPORT ON THE INTERNSHIP UNDERTAKEN AT THE BLASTASIA INC.', 'MARGIE JUAN', 2, NULL, 2025, '', '2024-09-01 00:00:00', 1),
(15, 'A NARRATIVE REPORT ON THE INTERNSHIP UNDERTAKEN AT MUNICIPALITY OF NORZAGARAY', 'EVANGELINE L. GALVEZ', 2, NULL, 2025, '', '2024-11-01 00:00:00', 1),
(16, 'A NARRATIVE REPORT ON THE INTERNSHIP UNDERTAKEN AT HOOLI SOFTWARE', 'CHRISTIAN ASAN', 2, NULL, 2025, '', '2024-11-01 00:00:00', 1),
(17, 'A NARRATIVE REPORT ON THE INTERNSHIP UNDERTAKEN AT GRACE OF SHEKINAH SCHOL', 'ANGELO S. GUMAFELIX', 2, NULL, 2025, '', '2024-10-01 00:00:00', 1),
(18, 'A NARRATIVE REPORT ON THE INTERSHIP UNDERTAKEN AT MN ELECTRO INDUSTRIAL SUPPLY AND SERVICES, INC.', 'JORDAN A. MARQUEZ', 2, NULL, 2025, '', '2024-09-01 00:00:00', 1),
(19, 'A NARRATIVE REPORT ON THE INTERNSHIP UNDERTAKEN AT PIXEL8 WEB SOLUTIONS & CONSULTANCY INC.', 'DANICA JOY P. MARPA', 2, NULL, 2025, '', '2024-09-01 00:00:00', 1),
(20, 'A NARRATIVE REPORT ON THE INTERNSHIP UNDERTAKEN AT MN ELECTRO INDUSTRIAL SUPPLY AND SERVICES INC.', 'EMRO R. BERMEJO', 2, NULL, 2025, '', '2024-09-01 00:00:00', 1),
(21, 'A NARRATIVE REPORT ON THE INTERNSHIP UNDERTAKEN AT MN ELECTRO INDUSTRIAL SUPPLY AND SERVICES INC.', 'MARK EDRIAN C. BAYANI', 2, NULL, 2025, '', '2024-09-01 00:00:00', 1),
(22, 'A NARRATIVE REPORT ON THE INTERNSHIP UNDERTAKEN AT MN ELECTRO INDUSTRIAL SUPPLY AND SERVICES INC.', 'MARK ANDREI C. BAYANI', 2, NULL, 2025, '', '2024-09-01 00:00:00', 1),
(23, 'A NARRATIVE REPORT ON THE INTERNSHIP UNDERTAKEN AT DEPARTMENT OF INFORMATION AND COMMUNICATION TECHNOLOGY (DICT) BULACAN PROVINCIAL OFFICE', 'PRICESS KENETH G. DE GUZMAN', 2, NULL, 2025, '', '2024-11-01 00:00:00', 1),
(24, 'Updated', 'Emmans', 3, 'asdasdasda', 2025, 'C:\\ArchivePDFs\\Lesson-7-DML_merged.pdf', '2025-06-30 14:08:34', 3),
(25, 'A Web Based Thesis Management System for Polytechnic University of the Philippines Sta Maria Bulacan Campus', 'Alconaba, Juan, Ong, Simbillo', 1, 'A thesis by BSIT published on 2023 advised by Mr.Bryan Lawrence T. Asistin', 2025, 'C:\\ArchivePDFs\\WebBasedThesisManagementSystem.pdf', '2025-06-30 15:31:20', 1),
(26, 'Web-based Sales and Inventory Management System For Inocentes Hot\'s and Huts', 'Concepcion, Gojo Cruz , Et al.', 1, 'This is a thesis by BSIT published in 2022', 2025, 'C:\\ArchivePDFs\\WebBaseSalesInventory.pdf', '2025-06-30 15:43:26', 1),
(27, 'THESIS PORTAL FOR PUPSMBC', 'Pangunsan, Paereja, Peralta, Principie, Ramirez', 1, 'This is a Thesis Portal for PUPSMBC.', 2025, 'C:\\ArchivePDFs\\ThesisPortalforPUPSMB.pdf', '2025-06-30 15:54:55', 1),
(28, 'ISKOalifiers: PUPSMB Scholarship Portal', 'Maclang, Maristelle S. et al.', 1, 'This a PUPSMB Scholarship Portal.', 2025, 'C:\\ArchivePDFs\\PUPSMBScholarshipPortal.pdf', '2025-06-30 15:58:47', 1),
(29, 'General Mathematics Proficiency Level of Grade 12 Students of Fortunato F. Halili National Agricultural School AY. 2018-2029', 'Agustin,  Kyle S. et al.', 1, 'General Mathematics Proficiency Level', 2025, 'C:\\ArchivePDFs\\General-Mathematics-Proficiency-Level-of-Grade-12.pdf', '2025-06-30 16:02:59', 3),
(31, 'Improving English Vocabulary Sills of First — Year Education', 'Bemabe, Samantha Aubrey L; et al.', 1, 'This  is a research made by Bernabe, Samantha Aubrey L.', 2023, 'C:\\ArchivePDFs\\Improving-Vocabulary-Skills-of-first-year-education-students-through-quizlet (1).pdf', '2025-06-30 16:36:57', 3),
(32, 'Leading to Quality Education: A Phenomenological Exploration on the Use of Gamification in Teaching Mathematics', 'Francis C. Lazaro; et al.', 1, ' A Phenomenological Exploration on the Use of Gamification in Teaching Mathematics', 2023, 'C:\\ArchivePDFs\\Leading-to-Quality-Education.pdf', '2025-06-30 16:39:47', 3),
(33, 'Senior High School Students’ Numeracy Skills and Influential Factor or Readiness for College Mathematics', 'Rochele C, Alejandro; et al.', 1, 'Numeracy Skills and Influential Factor or Readiness for College Mathematics', 2023, 'C:\\ArchivePDFs\\Senior-High-School-Numeracy-Skills-and-Influential-Factor-on-Readiness-for-College-Mathematics.pdf', '2025-06-30 16:41:52', 3),
(34, 'The Use of Rewordify: A Tool for Enhancing Reading Comprehension', 'Balolot, Marife A. et al;', 1, 'This is a Thesis for enhancing reading comprehension.', 2023, 'C:\\ArchivePDFs\\The-use-of-rewordify.pdf', '2025-06-30 16:44:52', 3),
(35, 'Overcoming the Crisis: The impact of COVID-19 Pandemic on the Financial Performance of Chicharon Manufacturers in the Municipality of Santa Maria, Bulacan', 'Brioanes, Clariz Andrea; et al.', 1, 'The impact of COVID-19 Pandemic on the Financial Performance of Chicharon Manufacturers in the Municipality of Santa Maria, Bulacan', 2022, 'C:\\ArchivePDFs\\Overcoming-the-crisis.pdf', '2025-06-30 16:48:58', 6),
(36, 'E-Commerce in the Times of Pandemic: Impact on the Sales Performance of Oniine Clothing Businesses in Sta. Maria, Bulacan', 'Altovar, Cystal Jade S; et al.', 1, 'A Thesis for Oniine Clothing Businesses in Sta. Maria, Bulacan.', 2022, 'C:\\ArchivePDFs\\E-commerce-in-the-times-of-pandemic.pdf', '2025-06-30 16:52:32', 6),
(37, 'The Perception of Selected Accountancy Undergraduate Students on the Effectiveness of Oniine Delivery System Of Learning amidst COVID-19 Pandemic', 'Alexandra Louise H. VIlla-Real; et al.', 1, 'The Perception of Selected Accountancy Undergraduate Students', 2022, 'C:\\ArchivePDFs\\The-perception-of-selected-accountancy-undergraduate-students.pdf', '2025-06-30 16:57:42', 6),
(38, 'Factors Affecting the Wilingness of Businesses Under Micro, Small, and Medium Enterprises to Shift from Manual Accounting Systems lo Computerized Accounting Systems', 'Aljon A. Pineda; et al.', 1, 'Factors Affecting the Wilingness of Businesses Under Micro, Small, and Medium Enterprises to Shift from Manual Accounting Systems lo Computerized Accounting Systems', 2023, 'C:\\ArchivePDFs\\Factors-Affecting-the-willingness-of-business-Under-Micro (1).pdf', '2025-06-30 17:02:21', 6),
(39, 'Survival Amidst Pandemic: An Assessment of the Effectivenass of Strategy Adaptation of the Effectivenass of Strategy Adaptation of Micro Service Businesses in Santa Maria, Bulacan', 'Castro, Sarah May C; et al.', 1, 'A thesis about Assessment of the Effectiveness of Strategy Adaptation of the Effectivenass of Strategy Adaptation of Micro Service Businesses in Santa Maria, Bulacan.', 2022, 'C:\\ArchivePDFs\\Survival-amidst-pandemic.pdf', '2025-06-30 17:06:11', 6),
(40, 'Lock and Go: An Arduino-based Smart Door Lock System Using Two-factor Authentication with SMS Alert', 'Mickaela T. Buenaventura; et al.', 1, 'A Thesis made by Mickaela T. Buenaventura; et al.', 2023, 'C:\\ArchivePDFs\\LockGo.pdf', '2025-06-30 17:12:17', 2),
(41, 'IoT and Non-IoT: Automated Garage with Burglary Alarm System and SensoMatic Control', 'Renzford R. Angeles; et al.', 1, 'A Thesis m ade by Renzford R. Angeles; et al.', 2024, 'C:\\ArchivePDFs\\lotNonLot.pdf', '2025-06-30 17:15:14', 2),
(42, 'SMART BROODING SYSTEM FOR QUAILS WITH MOBILE MONITORING', 'Ruel C. Alcober; et al.', 1, 'A thesis made by Ruel C. Alcober; et al.', 2022, 'C:\\ArchivePDFs\\SmartBroodingSystem.pdf', '2025-06-30 17:17:11', 2),
(43, 'Intelligent Robowaiter Using Fuzzy Logic', 'Billie G. Delos Santos; et al.', 1, 'A thesis made by Billie G. Delos Santos; et al.', 2022, 'C:\\ArchivePDFs\\IntelligentRobowaiter.pdf', '2025-06-30 17:19:15', 2),
(44, 'Evolution of Financial Markets, Institutions, and Relevance to Business Finance', 'Brizuela, Derick; et al.', 1, 'A thesis made by Brizuela, Derick; et al.', 2018, 'C:\\ArchivePDFs\\Compilation-of-Manuscript.pdf', '2025-06-30 17:34:26', 7),
(45, 'Factors affecting Employees Attrition in selected Manufacturing companies in Santa Maria Bulacan', 'Balanac, Jasmine O; et al.', 1, 'A thesis made by Balanac, Jasmine ; et al.', 2019, 'C:\\ArchivePDFs\\entrep_factors-affecting-employees.pdf', '2025-06-30 17:37:36', 7),
(46, 'Assestment of PUPSMB Students in tha Service Provided by the Convenience store at the Sta. Maria Bulacan', 'Baes, John Rusell D.G; et al.', 1, 'A thesis made by Baes, John Rusell D.G; et al.', 2021, 'C:\\ArchivePDFs\\Entrep-_Assesment-of-PUPSMB.pdf', '2025-06-30 17:44:59', 7),
(47, 'Proper Selection of Business for Future Entepreneur in Terms of Capital at Pulong Buhangin Santa Maria Bulacan', 'Cauan, Jayson V; et al.', 1, 'A thesis made by Cauan, Jayson V; et al.', 2021, 'C:\\ArchivePDFs\\Entrep_Proper-Selection-of-business.pdf', '2025-06-30 17:47:26', 7),
(48, 'THE IMPACT OF PHYSICAL ENVIRONMENT OF A COFFEE SHOP IN A CUSTOMERS HEDONIC VALUE', 'Elicana, Joy Ann L; et al.', 1, 'A thesis made by Elicana, Joy Ann L; et al.', 2024, 'C:\\ArchivePDFs\\TheImpactOfPhysicalEnvironment.pdf', '2025-06-30 17:51:29', 5);

-- --------------------------------------------------------

--
-- Table structure for table `document_types`
--

CREATE TABLE `document_types` (
  `id` int(11) NOT NULL,
  `type_name` varchar(50) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `document_types`
--

INSERT INTO `document_types` (`id`, `type_name`) VALUES
(1, 'RESEARCH/THESIS'),
(2, 'OJT TERMINAL REPORT'),
(3, 'OTHERS');

-- --------------------------------------------------------

--
-- Table structure for table `users`
--

CREATE TABLE `users` (
  `id` int(11) NOT NULL,
  `username` varchar(50) DEFAULT NULL,
  `password` varchar(255) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `users`
--

INSERT INTO `users` (`id`, `username`, `password`) VALUES
(1, 'admin', 'admin123');

--
-- Indexes for dumped tables
--

--
-- Indexes for table `activity_log`
--
ALTER TABLE `activity_log`
  ADD PRIMARY KEY (`id`);

--
-- Indexes for table `departments`
--
ALTER TABLE `departments`
  ADD PRIMARY KEY (`id`);

--
-- Indexes for table `documents`
--
ALTER TABLE `documents`
  ADD PRIMARY KEY (`id`),
  ADD KEY `type_id` (`type_id`),
  ADD KEY `department_id` (`department_id`);

--
-- Indexes for table `document_types`
--
ALTER TABLE `document_types`
  ADD PRIMARY KEY (`id`);

--
-- Indexes for table `users`
--
ALTER TABLE `users`
  ADD PRIMARY KEY (`id`),
  ADD UNIQUE KEY `username` (`username`);

--
-- AUTO_INCREMENT for dumped tables
--

--
-- AUTO_INCREMENT for table `activity_log`
--
ALTER TABLE `activity_log`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=29;

--
-- AUTO_INCREMENT for table `departments`
--
ALTER TABLE `departments`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=8;

--
-- AUTO_INCREMENT for table `documents`
--
ALTER TABLE `documents`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=49;

--
-- AUTO_INCREMENT for table `document_types`
--
ALTER TABLE `document_types`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=4;

--
-- AUTO_INCREMENT for table `users`
--
ALTER TABLE `users`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=2;

--
-- Constraints for dumped tables
--

--
-- Constraints for table `documents`
--
ALTER TABLE `documents`
  ADD CONSTRAINT `documents_ibfk_1` FOREIGN KEY (`type_id`) REFERENCES `document_types` (`id`),
  ADD CONSTRAINT `documents_ibfk_2` FOREIGN KEY (`department_id`) REFERENCES `departments` (`id`);
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
