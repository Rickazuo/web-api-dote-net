-- MySQL dump 10.13  Distrib 8.0.36, for Win64 (x86_64)
--
-- Host: localhost    Database: desafiolar
-- ------------------------------------------------------
-- Server version	8.0.36

/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!50503 SET NAMES utf8 */;
/*!40103 SET @OLD_TIME_ZONE=@@TIME_ZONE */;
/*!40103 SET TIME_ZONE='+00:00' */;
/*!40014 SET @OLD_UNIQUE_CHECKS=@@UNIQUE_CHECKS, UNIQUE_CHECKS=0 */;
/*!40014 SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0 */;
/*!40101 SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='NO_AUTO_VALUE_ON_ZERO' */;
/*!40111 SET @OLD_SQL_NOTES=@@SQL_NOTES, SQL_NOTES=0 */;

--
-- Table structure for table `telefones`
--

DROP TABLE IF EXISTS `telefones`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `telefones` (
  `TelefoneId` int NOT NULL AUTO_INCREMENT,
  `Tipo` longtext CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci NOT NULL,
  `Numero` longtext CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci NOT NULL,
  `PessoaId` int NOT NULL,
  PRIMARY KEY (`TelefoneId`),
  KEY `IX_Telefones_PessoaId` (`PessoaId`),
  CONSTRAINT `FK_Telefones_Pessoas_PessoaId` FOREIGN KEY (`PessoaId`) REFERENCES `pessoas` (`PessoaId`) ON DELETE CASCADE
) ENGINE=InnoDB AUTO_INCREMENT=48 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `telefones`
--

LOCK TABLES `telefones` WRITE;
/*!40000 ALTER TABLE `telefones` DISABLE KEYS */;
INSERT INTO `telefones` VALUES (1,'Celular','(72) 98889-8027',1),(2,'Comercial','(45) 8815-6479',1),(3,'Comercial','(99) 3151-4178',2),(4,'Comercial','(16) 7591-3235',2),(5,'Residencial','(27) 7559-3820',3),(6,'Celular','(28) 98659-1385',3),(7,'Celular','(42) 94033-1993',4),(8,'Residencial','(87) 4514-8479',4),(9,'Residencial','(21) 7564-7306',5),(10,'Celular','(11) 95498-7692',5),(11,'Celular','(87) 93872-9550',5),(12,'Celular','(94) 92828-9258',6),(13,'Residencial','(61) 2627-2406',6),(14,'Comercial','(97) 4264-3964',7),(15,'Comercial','(39) 3556-2359',7),(16,'Comercial','(80) 4783-1508',7),(17,'Celular','(58) 99876-9559',8),(18,'Comercial','(93) 4146-5197',8),(19,'Residencial','(19) 5950-5397',9),(20,'Celular','(12) 95283-5148',9),(21,'Comercial','(39) 1316-6983',10),(22,'Comercial','(64) 9878-9854',10),(23,'Comercial','(40) 9404-3266',10),(24,'Residencial','(32) 8917-4642',11),(25,'Celular','(96) 98143-9175',11),(26,'Comercial','(40) 3721-6687',12),(27,'Celular','(71) 95161-5973',12),(28,'Residencial','(28) 4027-2571',13),(29,'Celular','(21) 99219-8571',13),(46,'Celular','(21) 93597-1078',20),(47,'Celular','(37) 94483-1294',20);
/*!40000 ALTER TABLE `telefones` ENABLE KEYS */;
UNLOCK TABLES;
/*!40103 SET TIME_ZONE=@OLD_TIME_ZONE */;

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;

-- Dump completed on 2024-01-26 21:50:51
