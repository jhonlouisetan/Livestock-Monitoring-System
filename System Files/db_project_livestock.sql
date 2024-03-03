-- MariaDB dump 10.19  Distrib 10.4.27-MariaDB, for Win64 (AMD64)
--
-- Host: localhost    Database: db_livestock
-- ------------------------------------------------------
-- Server version	10.4.27-MariaDB

/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;
/*!40103 SET @OLD_TIME_ZONE=@@TIME_ZONE */;
/*!40103 SET TIME_ZONE='+00:00' */;
/*!40014 SET @OLD_UNIQUE_CHECKS=@@UNIQUE_CHECKS, UNIQUE_CHECKS=0 */;
/*!40014 SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0 */;
/*!40101 SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='NO_AUTO_VALUE_ON_ZERO' */;
/*!40111 SET @OLD_SQL_NOTES=@@SQL_NOTES, SQL_NOTES=0 */;

--
-- Temporary table structure for view `proper`
--

DROP TABLE IF EXISTS `proper`;
/*!50001 DROP VIEW IF EXISTS `proper`*/;
SET @saved_cs_client     = @@character_set_client;
SET character_set_client = utf8;
/*!50001 CREATE VIEW `proper` AS SELECT
 1 AS `Cow ID`,
  1 AS `Owner`,
  1 AS `Gender`,
  1 AS `Age Group`,
  1 AS `Inventory Status`,
  1 AS `Date of Inventory`,
  1 AS `Date Recorded`,
  1 AS `Date Out` */;
SET character_set_client = @saved_cs_client;

--
-- Temporary table structure for view `properemp`
--

DROP TABLE IF EXISTS `properemp`;
/*!50001 DROP VIEW IF EXISTS `properemp`*/;
SET @saved_cs_client     = @@character_set_client;
SET character_set_client = utf8;
/*!50001 CREATE VIEW `properemp` AS SELECT
 1 AS `Employee ID`,
  1 AS `First Name`,
  1 AS `Middle Initial`,
  1 AS `Last Name`,
  1 AS `Gender`,
  1 AS `Contact Number`,
  1 AS `Job`,
  1 AS `Password`,
  1 AS `Birth Date`,
  1 AS `Date Hired` */;
SET character_set_client = @saved_cs_client;

--
-- Temporary table structure for view `properowner`
--

DROP TABLE IF EXISTS `properowner`;
/*!50001 DROP VIEW IF EXISTS `properowner`*/;
SET @saved_cs_client     = @@character_set_client;
SET character_set_client = utf8;
/*!50001 CREATE VIEW `properowner` AS SELECT
 1 AS `Owner ID`,
  1 AS `Name`,
  1 AS `Initials`,
  1 AS `Contact Number` */;
SET character_set_client = @saved_cs_client;

--
-- Table structure for table `tbl_admin`
--

DROP TABLE IF EXISTS `tbl_admin`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `tbl_admin` (
  `admin_id` int(8) NOT NULL,
  `admin_name` varchar(50) DEFAULT NULL,
  `admin_pass` varchar(20) DEFAULT NULL,
  `admin_contact` varchar(15) DEFAULT NULL,
  PRIMARY KEY (`admin_id`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `tbl_admin`
--

LOCK TABLES `tbl_admin` WRITE;
/*!40000 ALTER TABLE `tbl_admin` DISABLE KEYS */;
INSERT INTO `tbl_admin` VALUES (11111,'Jeses','admin','123123123');
/*!40000 ALTER TABLE `tbl_admin` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `tbl_cow`
--

DROP TABLE IF EXISTS `tbl_cow`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `tbl_cow` (
  `cow_id` int(8) NOT NULL,
  `owner_initials` varchar(5) DEFAULT NULL,
  `cow_gender` varchar(6) DEFAULT NULL,
  `cow_ageGroup` varchar(10) DEFAULT NULL,
  `cow_invStatus` varchar(10) DEFAULT NULL,
  `date_inventory` date DEFAULT NULL,
  `date_recorded` date DEFAULT NULL,
  `date_out` date DEFAULT NULL,
  PRIMARY KEY (`cow_id`),
  KEY `owner_initials` (`owner_initials`),
  CONSTRAINT `tbl_cow_ibfk_1` FOREIGN KEY (`owner_initials`) REFERENCES `tbl_owner` (`owner_initials`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `tbl_cow`
--

LOCK TABLES `tbl_cow` WRITE;
/*!40000 ALTER TABLE `tbl_cow` DISABLE KEYS */;
INSERT INTO `tbl_cow` VALUES (1,'ROS','Male','Inahin','IN','2023-04-20','2023-04-20','2023-04-20'),(2,'RRS','Male','Toro','IN','0000-00-00','0000-00-00','0000-00-00'),(3,'ROS','F','Inahin','IN','0000-00-00','0000-00-00','0000-00-00'),(4,'ROS','Male','Torete','IN','2023-05-15','2023-05-15',NULL),(6,'ASD','Male','Torete','OUT','2023-05-15','2023-05-15','2023-04-28');
/*!40000 ALTER TABLE `tbl_cow` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `tbl_emp`
--

DROP TABLE IF EXISTS `tbl_emp`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `tbl_emp` (
  `emp_id` int(8) NOT NULL AUTO_INCREMENT,
  `emp_fname` varchar(50) NOT NULL,
  `emp_midinit` char(2) NOT NULL,
  `emp_lname` varchar(50) NOT NULL,
  `emp_gender` varchar(15) DEFAULT NULL,
  `emp_contact` varchar(15) DEFAULT NULL,
  `emp_job` varchar(50) DEFAULT NULL,
  `emp_pass` varchar(20) DEFAULT NULL,
  `emp_birthdate` date DEFAULT NULL,
  `emp_hiredate` date DEFAULT NULL,
  PRIMARY KEY (`emp_id`)
) ENGINE=InnoDB AUTO_INCREMENT=102 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `tbl_emp`
--

LOCK TABLES `tbl_emp` WRITE;
/*!40000 ALTER TABLE `tbl_emp` DISABLE KEYS */;
INSERT INTO `tbl_emp` VALUES (10,'Jojo','B','Adventure','Gay','09010580085','Bookkeeper','1234','1998-08-11','2022-04-11'),(100,'Naroto','E','Sakora','Ninja','123','Cowboy','1234','2023-04-21','2023-04-21'),(101,'Luffy','D','Monkey','Rubber','09123157281','Captain','1234','1998-08-11','2022-04-11');
/*!40000 ALTER TABLE `tbl_emp` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `tbl_owner`
--

DROP TABLE IF EXISTS `tbl_owner`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `tbl_owner` (
  `owner_id` int(8) NOT NULL,
  `owner_name` varchar(50) DEFAULT NULL,
  `owner_initials` varchar(5) DEFAULT NULL,
  `owner_contact` varchar(15) DEFAULT NULL,
  PRIMARY KEY (`owner_id`),
  UNIQUE KEY `owner_initials` (`owner_initials`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `tbl_owner`
--

LOCK TABLES `tbl_owner` WRITE;
/*!40000 ALTER TABLE `tbl_owner` DISABLE KEYS */;
INSERT INTO `tbl_owner` VALUES (1,'Renato Salangsang','ROS','123123'),(2,'Renzo Rob Salangsang','RRS','123123'),(3,'Anthony Salangsang','AS','123123'),(4,'Aruel Salangsang Duque','ASD','123123'),(5,'Sheila Adi Salangsang','SAS','123122'),(6,'Bien Salangsang Arzagon','BSA','1231231');
/*!40000 ALTER TABLE `tbl_owner` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Final view structure for view `proper`
--

/*!50001 DROP VIEW IF EXISTS `proper`*/;
/*!50001 SET @saved_cs_client          = @@character_set_client */;
/*!50001 SET @saved_cs_results         = @@character_set_results */;
/*!50001 SET @saved_col_connection     = @@collation_connection */;
/*!50001 SET character_set_client      = utf8mb4 */;
/*!50001 SET character_set_results     = utf8mb4 */;
/*!50001 SET collation_connection      = utf8mb4_unicode_ci */;
/*!50001 CREATE ALGORITHM=UNDEFINED DEFINER=`` SQL SECURITY DEFINER VIEW `proper` AS select `tbl_cow`.`cow_id` AS `Cow ID`,`tbl_cow`.`owner_initials` AS `Owner`,`tbl_cow`.`cow_gender` AS `Gender`,`tbl_cow`.`cow_ageGroup` AS `Age Group`,`tbl_cow`.`cow_invStatus` AS `Inventory Status`,`tbl_cow`.`date_inventory` AS `Date of Inventory`,`tbl_cow`.`date_recorded` AS `Date Recorded`,`tbl_cow`.`date_out` AS `Date Out` from `tbl_cow` */;
/*!50001 SET character_set_client      = @saved_cs_client */;
/*!50001 SET character_set_results     = @saved_cs_results */;
/*!50001 SET collation_connection      = @saved_col_connection */;

--
-- Final view structure for view `properemp`
--

/*!50001 DROP VIEW IF EXISTS `properemp`*/;
/*!50001 SET @saved_cs_client          = @@character_set_client */;
/*!50001 SET @saved_cs_results         = @@character_set_results */;
/*!50001 SET @saved_col_connection     = @@collation_connection */;
/*!50001 SET character_set_client      = utf8mb4 */;
/*!50001 SET character_set_results     = utf8mb4 */;
/*!50001 SET collation_connection      = utf8mb4_unicode_ci */;
/*!50001 CREATE ALGORITHM=UNDEFINED DEFINER=`` SQL SECURITY DEFINER VIEW `properemp` AS select `tbl_emp`.`emp_id` AS `Employee ID`,`tbl_emp`.`emp_fname` AS `First Name`,`tbl_emp`.`emp_midinit` AS `Middle Initial`,`tbl_emp`.`emp_lname` AS `Last Name`,`tbl_emp`.`emp_gender` AS `Gender`,`tbl_emp`.`emp_contact` AS `Contact Number`,`tbl_emp`.`emp_job` AS `Job`,`tbl_emp`.`emp_pass` AS `Password`,`tbl_emp`.`emp_birthdate` AS `Birth Date`,`tbl_emp`.`emp_hiredate` AS `Date Hired` from `tbl_emp` */;
/*!50001 SET character_set_client      = @saved_cs_client */;
/*!50001 SET character_set_results     = @saved_cs_results */;
/*!50001 SET collation_connection      = @saved_col_connection */;

--
-- Final view structure for view `properowner`
--

/*!50001 DROP VIEW IF EXISTS `properowner`*/;
/*!50001 SET @saved_cs_client          = @@character_set_client */;
/*!50001 SET @saved_cs_results         = @@character_set_results */;
/*!50001 SET @saved_col_connection     = @@collation_connection */;
/*!50001 SET character_set_client      = utf8mb4 */;
/*!50001 SET character_set_results     = utf8mb4 */;
/*!50001 SET collation_connection      = utf8mb4_unicode_ci */;
/*!50001 CREATE ALGORITHM=UNDEFINED DEFINER=`` SQL SECURITY DEFINER VIEW `properowner` AS select `tbl_owner`.`owner_id` AS `Owner ID`,`tbl_owner`.`owner_name` AS `Name`,`tbl_owner`.`owner_initials` AS `Initials`,`tbl_owner`.`owner_contact` AS `Contact Number` from `tbl_owner` */;
/*!50001 SET character_set_client      = @saved_cs_client */;
/*!50001 SET character_set_results     = @saved_cs_results */;
/*!50001 SET collation_connection      = @saved_col_connection */;
/*!40103 SET TIME_ZONE=@OLD_TIME_ZONE */;

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;

-- Dump completed on 2023-05-15 14:45:20
