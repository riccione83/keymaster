-- MySQL dump 10.13  Distrib 5.5.41, for Win32 (AMD64)
--
-- Host: localhost    Database: KeysDB
-- ------------------------------------------------------
-- Server version	5.5.41-log

/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8 */;
/*!40103 SET @OLD_TIME_ZONE=@@TIME_ZONE */;
/*!40103 SET TIME_ZONE='+00:00' */;
/*!40014 SET @OLD_UNIQUE_CHECKS=@@UNIQUE_CHECKS, UNIQUE_CHECKS=0 */;
/*!40014 SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0 */;
/*!40101 SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='NO_AUTO_VALUE_ON_ZERO' */;
/*!40111 SET @OLD_SQL_NOTES=@@SQL_NOTES, SQL_NOTES=0 */;

--
-- Table structure for table `keys`
--

DROP TABLE IF EXISTS `keys`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `keys` (
  `KeyNumber` varchar(10) NOT NULL,
  `ExpiryDate` timestamp NULL DEFAULT NULL,
  `Description` text NOT NULL,
  `CreatedAt` timestamp NOT NULL DEFAULT CURRENT_TIMESTAMP,
  `ID` int(10) NOT NULL AUTO_INCREMENT,
  `USER_ID` int(11) NOT NULL,
  `Position` varchar(10) NOT NULL,
  PRIMARY KEY (`ID`)
) ENGINE=InnoDB AUTO_INCREMENT=9 DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `keys`
--

LOCK TABLES `keys` WRITE;
/*!40000 ALTER TABLE `keys` DISABLE KEYS */;
INSERT INTO `keys` VALUES ('106004','2017-12-01 23:00:00','Le chiavi di casa','2015-12-01 09:45:49',1,2,'0-0-2'),('106005','2015-12-08 23:00:00','Le chiavi della macchina','2015-12-01 15:20:51',3,1,'0-0-0'),('106006','2016-12-09 14:39:03','Nuova chiave','2015-12-09 14:39:29',6,1,'0-0-1'),('101010','2015-12-10 09:20:20','Chiave di prova','2015-12-10 09:28:33',7,3,'0-0-0'),('101101','2015-12-09 09:47:29','Una nuova chiave','2015-12-10 09:47:48',8,3,'0-0-1');
/*!40000 ALTER TABLE `keys` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `payments`
--

DROP TABLE IF EXISTS `payments`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `payments` (
  `id` int(6) NOT NULL AUTO_INCREMENT,
  `user_id` varchar(20) NOT NULL,
  `payment_id` varchar(60) NOT NULL,
  `hash` varchar(60) NOT NULL,
  `complete` int(11) NOT NULL,
  `key_number` varchar(30) NOT NULL,
  `CreatedAt` timestamp NOT NULL DEFAULT CURRENT_TIMESTAMP,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB AUTO_INCREMENT=31 DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `payments`
--

LOCK TABLES `payments` WRITE;
/*!40000 ALTER TABLE `payments` DISABLE KEYS */;
INSERT INTO `payments` VALUES (21,'1','PAY-9L952487YU344101CKZUEFMA','d378c0f11fb5c16a86447a35bc7597a5',1,'106005','2015-12-09 15:03:11'),(22,'1','PAY-63D6908937664411EKZUEF2I','093ec89f38ddcae47ec3e2840358606f',1,'106006','2015-12-09 15:04:08'),(25,'2','PAY-8XM07269C4977331XKZUEICY','0c517cb29d286c773f2f439a5ecc6bc7',1,'106004','2015-12-09 15:08:58'),(28,'2','PAY-8S952165AK5493736KZUYSXI','db750ce470b21d040ab8a5c43ef32980',1,'106004','2015-12-10 14:17:00');
/*!40000 ALTER TABLE `payments` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `users`
--

DROP TABLE IF EXISTS `users`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `users` (
  `id` int(10) NOT NULL AUTO_INCREMENT,
  `Name` varchar(20) NOT NULL,
  `Surname` varchar(20) NOT NULL,
  `Email` varchar(60) NOT NULL,
  `Password` varchar(60) NOT NULL,
  `Address` varchar(60) NOT NULL,
  `City` varchar(30) NOT NULL,
  `Note` text NOT NULL,
  `Free` text NOT NULL,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB AUTO_INCREMENT=4 DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `users`
--

LOCK TABLES `users` WRITE;
/*!40000 ALTER TABLE `users` DISABLE KEYS */;
INSERT INTO `users` VALUES (1,'Riccardo','Rizzo','r.riki@tiscali.it','laura007','via Scipione Porzio, 13','CATANIA','Il cliente ha lasciato le chiavi della macchina targata EC324XM. Inoltre ha lasciato le chiavi di casa.',''),(2,'Sabrina','Sineri','sabrina@2858.it','sabrina1009','','MILANO','',''),(3,'Mario','De Felice','dfm@2858.it','123456','via Garibaldi','S.A. Li Ba','Prova Prova','');
/*!40000 ALTER TABLE `users` ENABLE KEYS */;
UNLOCK TABLES;
/*!40103 SET TIME_ZONE=@OLD_TIME_ZONE */;

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;

-- Dump completed on 2015-12-11 12:13:59

