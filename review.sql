-- MySQL dump 10.13  Distrib 8.0.31, for Win64 (x86_64)
--
-- Host: 127.0.0.1    Database: review
-- ------------------------------------------------------
-- Server version	8.0.31

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
-- Table structure for table `author`
--

DROP TABLE IF EXISTS `author`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `author` (
  `id_author` int NOT NULL AUTO_INCREMENT,
  `name_auth` varchar(100) DEFAULT NULL,
  PRIMARY KEY (`id_author`)
) ENGINE=InnoDB AUTO_INCREMENT=7 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `author`
--

LOCK TABLES `author` WRITE;
/*!40000 ALTER TABLE `author` DISABLE KEYS */;
INSERT INTO `author` VALUES (1,'Синдзи Такамацу'),(3,'Ник Кастл');
/*!40000 ALTER TABLE `author` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `creation`
--

DROP TABLE IF EXISTS `creation`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `creation` (
  `id_creation` int NOT NULL AUTO_INCREMENT,
  `name_cre` varchar(200) DEFAULT NULL,
  `id_type` int DEFAULT NULL,
  `id_author` int DEFAULT NULL,
  `genre` varchar(200) DEFAULT NULL,
  `desc_cre` varchar(600) DEFAULT NULL,
  `total_rate` double DEFAULT '0',
  PRIMARY KEY (`id_creation`),
  KEY `id_type` (`id_type`),
  KEY `id_author` (`id_author`),
  CONSTRAINT `creation_ibfk_1` FOREIGN KEY (`id_type`) REFERENCES `type_creation` (`id_type`),
  CONSTRAINT `creation_ibfk_2` FOREIGN KEY (`id_author`) REFERENCES `author` (`id_author`)
) ENGINE=InnoDB AUTO_INCREMENT=9 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `creation`
--

LOCK TABLES `creation` WRITE;
/*!40000 ALTER TABLE `creation` DISABLE KEYS */;
INSERT INTO `creation` VALUES (1,'asfdv',2,3,'Хоррор Детектив Сверхъестественное ','zdfbgzdf',0),(2,'Необъятный океан',3,1,'Комедия','Иори Китахара поступил в университет в прибрежном городке и снял комнату у семьи Котэгава. Глава семьи владеет магазинчиком снаряжения для дайвинга, но эта тематика не близка сердцу Иори - он до ужаса боится воды. Но знакомство с компанией друзей-дайверов заставляет его постепенно менять свои взгляды, научиться смотреть своим страхам прямо в глаза и открыть для себя просторы необъятного океана.',8),(4,'Майор Пейн',1,3,'Комедия','',0);
/*!40000 ALTER TABLE `creation` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `genre`
--

DROP TABLE IF EXISTS `genre`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `genre` (
  `id_genre` int NOT NULL AUTO_INCREMENT,
  `name_genre` varchar(100) DEFAULT NULL,
  PRIMARY KEY (`id_genre`)
) ENGINE=InnoDB AUTO_INCREMENT=6 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `genre`
--

LOCK TABLES `genre` WRITE;
/*!40000 ALTER TABLE `genre` DISABLE KEYS */;
INSERT INTO `genre` VALUES (1,'Комедия'),(2,'Хоррор'),(3,'Драма'),(4,'Детектив'),(5,'Сверхъестественное');
/*!40000 ALTER TABLE `genre` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `list_review`
--

DROP TABLE IF EXISTS `list_review`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `list_review` (
  `id_prof` int DEFAULT NULL,
  `id_review` int DEFAULT NULL,
  KEY `id_prof` (`id_prof`),
  KEY `id_review` (`id_review`),
  CONSTRAINT `list_review_ibfk_1` FOREIGN KEY (`id_prof`) REFERENCES `profile` (`id_prof`),
  CONSTRAINT `list_review_ibfk_2` FOREIGN KEY (`id_review`) REFERENCES `review` (`id_review`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `list_review`
--

LOCK TABLES `list_review` WRITE;
/*!40000 ALTER TABLE `list_review` DISABLE KEYS */;
INSERT INTO `list_review` VALUES (5,6);
/*!40000 ALTER TABLE `list_review` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `login`
--

DROP TABLE IF EXISTS `login`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `login` (
  `id_log` int NOT NULL AUTO_INCREMENT,
  `login` varchar(100) DEFAULT NULL,
  PRIMARY KEY (`id_log`)
) ENGINE=InnoDB AUTO_INCREMENT=5 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `login`
--

LOCK TABLES `login` WRITE;
/*!40000 ALTER TABLE `login` DISABLE KEYS */;
INSERT INTO `login` VALUES (2,'tst'),(3,'mod'),(4,'qwe');
/*!40000 ALTER TABLE `login` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `profile`
--

DROP TABLE IF EXISTS `profile`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `profile` (
  `id_prof` int NOT NULL AUTO_INCREMENT,
  `name` varchar(100) DEFAULT NULL,
  `id_log` int DEFAULT NULL,
  `id_pswrd` int DEFAULT NULL,
  `id_role` int DEFAULT NULL,
  PRIMARY KEY (`id_prof`),
  KEY `id_log` (`id_log`),
  KEY `id_pswrd` (`id_pswrd`),
  KEY `id_role` (`id_role`),
  CONSTRAINT `profile_ibfk_1` FOREIGN KEY (`id_log`) REFERENCES `login` (`id_log`),
  CONSTRAINT `profile_ibfk_2` FOREIGN KEY (`id_pswrd`) REFERENCES `pswrd` (`id_pswrd`),
  CONSTRAINT `profile_ibfk_3` FOREIGN KEY (`id_role`) REFERENCES `role` (`id_role`)
) ENGINE=InnoDB AUTO_INCREMENT=7 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `profile`
--

LOCK TABLES `profile` WRITE;
/*!40000 ALTER TABLE `profile` DISABLE KEYS */;
INSERT INTO `profile` VALUES (4,'tst',2,3,1),(5,'moderator',3,4,2),(6,'qwe',4,5,1);
/*!40000 ALTER TABLE `profile` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `pswrd`
--

DROP TABLE IF EXISTS `pswrd`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `pswrd` (
  `id_pswrd` int NOT NULL AUTO_INCREMENT,
  `pswrd` varchar(100) DEFAULT NULL,
  PRIMARY KEY (`id_pswrd`)
) ENGINE=InnoDB AUTO_INCREMENT=6 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `pswrd`
--

LOCK TABLES `pswrd` WRITE;
/*!40000 ALTER TABLE `pswrd` DISABLE KEYS */;
INSERT INTO `pswrd` VALUES (3,'tst'),(4,'mod'),(5,'qwe');
/*!40000 ALTER TABLE `pswrd` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `review`
--

DROP TABLE IF EXISTS `review`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `review` (
  `id_review` int NOT NULL AUTO_INCREMENT,
  `id_creation` int DEFAULT NULL,
  `txt_review` varchar(1000) DEFAULT NULL,
  `rate` int DEFAULT NULL,
  PRIMARY KEY (`id_review`),
  KEY `id_creation` (`id_creation`),
  CONSTRAINT `review_ibfk_1` FOREIGN KEY (`id_creation`) REFERENCES `creation` (`id_creation`)
) ENGINE=InnoDB AUTO_INCREMENT=9 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `review`
--

LOCK TABLES `review` WRITE;
/*!40000 ALTER TABLE `review` DISABLE KEYS */;
INSERT INTO `review` VALUES (6,2,'test',8);
/*!40000 ALTER TABLE `review` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `role`
--

DROP TABLE IF EXISTS `role`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `role` (
  `id_role` int NOT NULL AUTO_INCREMENT,
  `role` varchar(50) DEFAULT NULL,
  PRIMARY KEY (`id_role`)
) ENGINE=InnoDB AUTO_INCREMENT=4 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `role`
--

LOCK TABLES `role` WRITE;
/*!40000 ALTER TABLE `role` DISABLE KEYS */;
INSERT INTO `role` VALUES (1,'Пользователь'),(2,'Модератор');
/*!40000 ALTER TABLE `role` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `type_creation`
--

DROP TABLE IF EXISTS `type_creation`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `type_creation` (
  `id_type` int NOT NULL AUTO_INCREMENT,
  `type` varchar(50) DEFAULT NULL,
  PRIMARY KEY (`id_type`)
) ENGINE=InnoDB AUTO_INCREMENT=7 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `type_creation`
--

LOCK TABLES `type_creation` WRITE;
/*!40000 ALTER TABLE `type_creation` DISABLE KEYS */;
INSERT INTO `type_creation` VALUES (1,'Фильм'),(2,'Мультфильм'),(3,'Аниме'),(4,'Манга'),(5,'Книга'),(6,'Сериал');
/*!40000 ALTER TABLE `type_creation` ENABLE KEYS */;
UNLOCK TABLES;
/*!40103 SET TIME_ZONE=@OLD_TIME_ZONE */;

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;

-- Dump completed on 2023-04-19  5:34:48
