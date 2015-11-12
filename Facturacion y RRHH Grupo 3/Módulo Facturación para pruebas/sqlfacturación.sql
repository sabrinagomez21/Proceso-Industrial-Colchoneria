-- MySQL dump 10.13  Distrib 5.6.23, for Win64 (x86_64)
--
-- Host: localhost    Database: colchoneria
-- ------------------------------------------------------
-- Server version	5.6.17

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
-- Table structure for table `maacciones`
--

DROP TABLE IF EXISTS `maacciones`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `maacciones` (
  `ncodaccion` int(11) NOT NULL AUTO_INCREMENT,
  `vnombreaccion` varchar(40) DEFAULT NULL,
  PRIMARY KEY (`ncodaccion`)
) ENGINE=MyISAM AUTO_INCREMENT=8 DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `maacciones`
--

LOCK TABLES `maacciones` WRITE;
/*!40000 ALTER TABLE `maacciones` DISABLE KEYS */;
INSERT INTO `maacciones` VALUES (1,'Loggin'),(2,'Insercion'),(3,'Buscar'),(4,'Eliminacion'),(5,'Actualizacion'),(6,'Reportes'),(7,'Graficas');
/*!40000 ALTER TABLE `maacciones` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `maaplicacion`
--

DROP TABLE IF EXISTS `maaplicacion`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `maaplicacion` (
  `ncodaplicacion` int(11) NOT NULL AUTO_INCREMENT,
  `vnombreaplicacion` varchar(30) DEFAULT NULL,
  `ncodmodulo` int(11) NOT NULL,
  `vnombreformulario` varchar(40) DEFAULT NULL,
  PRIMARY KEY (`ncodaplicacion`),
  KEY `RefMaMODULO64` (`ncodmodulo`)
) ENGINE=MyISAM AUTO_INCREMENT=24 DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `maaplicacion`
--

LOCK TABLES `maaplicacion` WRITE;
/*!40000 ALTER TABLE `maaplicacion` DISABLE KEYS */;
INSERT INTO `maaplicacion` VALUES (1,'Asignacion de Aplicacion',1,'frmAsignacionAplicacion'),(2,'Buscar Aplicacion',1,'frmBuscarApli'),(3,'Buscar Usuario',1,'frmBuscarUser'),(9,'Bitacora',1,'Presentacion'),(5,'Errores Sistema',1,'frmErrores'),(6,'Manejo de Roles',1,'frmManejoRol'),(7,'Registro Usuario',1,'frmRegistro'),(8,'Registro de Aplicaciones',1,'frmRegistroAplicacion'),(12,'Regristro Modulo',1,'frmRegistroModulo'),(11,'Salir',1,'Salir'),(22,'Pronostico',4,'frmPronosticoVentas'),(15,'Vendedores',3,'frmVendedores'),(16,'Clientes',3,'frmClientes'),(23,'Reporteador',2,'frmReporteador'),(18,'Facturacion',4,'frmFacturacion'),(19,'Pedidos',4,'frmPedido'),(20,'Cotizaciones',4,'frmCotizacion');
/*!40000 ALTER TABLE `maaplicacion` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `mabanco`
--

DROP TABLE IF EXISTS `mabanco`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `mabanco` (
  `ncodbanco` int(11) NOT NULL AUTO_INCREMENT,
  `vnombrebanco` varchar(18) DEFAULT NULL,
  `vdireccion` varchar(30) DEFAULT NULL,
  `cestado` char(20) DEFAULT NULL,
  PRIMARY KEY (`ncodbanco`)
) ENGINE=MyISAM DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `mabanco`
--

LOCK TABLES `mabanco` WRITE;
/*!40000 ALTER TABLE `mabanco` DISABLE KEYS */;
/*!40000 ALTER TABLE `mabanco` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `mabitacora`
--

DROP TABLE IF EXISTS `mabitacora`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `mabitacora` (
  `ncodbitacora` int(11) NOT NULL AUTO_INCREMENT,
  `vnombreequipo` varchar(25) DEFAULT NULL,
  `vipequipo` varchar(20) DEFAULT NULL,
  `dhora` time DEFAULT NULL,
  `dfecha` date DEFAULT NULL,
  `vdetalleaccion` varchar(100) DEFAULT NULL,
  `ncodaccion` int(11) NOT NULL,
  `ncodusuario` int(11) NOT NULL,
  `ncodaplicacion` int(11) NOT NULL,
  PRIMARY KEY (`ncodbitacora`),
  KEY `RefMaACCIONES59` (`ncodaccion`),
  KEY `RefMaUSUARIO62` (`ncodusuario`),
  KEY `RefMaAPLICACION66` (`ncodaplicacion`)
) ENGINE=MyISAM AUTO_INCREMENT=218 DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `mabitacora`
--

LOCK TABLES `mabitacora` WRITE;
/*!40000 ALTER TABLE `mabitacora` DISABLE KEYS */;
INSERT INTO `mabitacora` VALUES (1,'HECTORCARDONA','192.168.232.1','19:49:19','2015-11-07','Ingreso al sistema',1,2,1),(2,'HECTORCARDONA','192.168.232.1','19:49:48','2015-11-07','Ingreso al sistema',1,1,1),(3,'HECTORCARDONA','192.168.232.1','19:50:41','2015-11-07','Ingreso al sistema',1,2,1),(4,'HECTORCARDONA','192.168.232.1','19:51:27','2015-11-07','Ingreso al sistema',1,1,1),(5,'HECTORCARDONA','192.168.232.1','19:53:03','2015-11-07','Ingreso al sistema',1,1,1),(6,'HECTORCARDONA','192.168.232.1','19:55:23','2015-11-07','Ingreso al sistema',1,1,1),(7,'HECTORCARDONA','192.168.232.1','19:56:16','2015-11-07','Ingreso al sistema',1,1,1),(8,'HECTORCARDONA','192.168.232.1','19:59:39','2015-11-07','Ingreso al sistema',1,2,1),(9,'HECTORCARDONA','192.168.232.1','20:00:09','2015-11-07','Ingreso al sistema',1,1,1),(10,'HECTORCARDONA','192.168.232.1','20:02:10','2015-11-07','Ingreso al sistema',1,1,1),(11,'HECTORCARDONA','192.168.232.1','20:03:10','2015-11-07','Ingreso al sistema',1,1,1),(12,'HECTORCARDONA','192.168.232.1','20:04:41','2015-11-07','Ingreso al sistema',1,2,1),(13,'HECTORCARDONA','192.168.232.1','20:06:24','2015-11-07','Ingreso al sistema',1,2,1),(14,'HECTORCARDONA','192.168.232.1','20:09:09','2015-11-07','Ingreso al sistema',1,2,1),(15,'HECTORCARDONA','192.168.232.1','20:11:20','2015-11-07','Ingreso al sistema',1,2,1),(16,'HECTORCARDONA','192.168.232.1','20:15:08','2015-11-07','Ingreso al sistema',1,1,1),(17,'HECTORCARDONA','192.168.232.1','20:16:16','2015-11-07','Ingreso al sistema',1,2,1),(18,'HECTORCARDONA','192.168.232.1','20:19:45','2015-11-07','Ingreso al sistema',1,1,1),(19,'HECTORCARDONA','192.168.232.1','20:20:35','2015-11-07','Ingreso al sistema',1,2,1),(20,'HECTORCARDONA','192.168.232.1','20:22:46','2015-11-07','Ingreso al sistema',1,2,1),(21,'HECTORCARDONA','192.168.232.1','20:24:27','2015-11-07','Ingreso al sistema',1,2,1),(22,'HECTORCARDONA','192.168.232.1','20:25:17','2015-11-07','Ingreso al sistema',1,1,1),(23,'HECTORCARDONA','192.168.232.1','20:26:01','2015-11-07','Ingreso al sistema',1,2,1),(24,'HECTORCARDONA','192.168.232.1','20:30:01','2015-11-07','Ingreso al sistema',1,2,1),(25,'HECTORCARDONA','192.168.232.1','20:30:51','2015-11-07','Ingreso al sistema',1,1,1),(26,'HECTORCARDONA','192.168.232.1','20:32:01','2015-11-07','Ingreso al sistema',1,2,1),(27,'HECTORCARDONA','192.168.232.1','20:34:36','2015-11-07','Ingreso al sistema',1,2,1),(28,'HECTORCARDONA','192.168.232.1','20:35:58','2015-11-07','Ingreso al sistema',1,2,1),(29,'HECTORCARDONA','192.168.232.1','20:44:40','2015-11-07','Ingreso al sistema',1,2,1),(30,'HECTORCARDONA','192.168.232.1','20:48:08','2015-11-07','Ingreso al sistema',1,1,1),(31,'HECTORCARDONA','192.168.232.1','20:49:44','2015-11-07','Ingreso al sistema',1,2,1),(32,'HECTORCARDONA','192.168.232.1','20:51:41','2015-11-07','Ingreso al sistema',1,1,1),(33,'HECTORCARDONA','192.168.232.1','20:52:28','2015-11-07','Ingreso al sistema',1,2,1),(34,'HECTORCARDONA','192.168.232.1','21:00:36','2015-11-07','Ingreso al sistema',1,1,1),(35,'HECTORCARDONA','192.168.232.1','21:00:52','2015-11-07','Ingreso al sistema',1,2,1),(36,'HECTORCARDONA','192.168.232.1','21:02:08','2015-11-07','Ingreso al sistema',1,2,1),(37,'HECTORCARDONA','192.168.232.1','21:09:12','2015-11-07','Ingreso al sistema',1,2,1),(38,'HECTORCARDONA','192.168.232.1','21:10:59','2015-11-07','Ingreso al sistema',1,2,1),(39,'HECTORCARDONA','192.168.232.1','21:12:35','2015-11-07','Ingreso al sistema',1,2,1),(40,'HECTORCARDONA','192.168.232.1','21:22:37','2015-11-07','Ingreso al sistema',1,3,1),(41,'HECTORCARDONA','192.168.232.1','21:23:18','2015-11-07','Ingreso al sistema',1,3,1),(42,'HECTORCARDONA','192.168.232.1','21:24:47','2015-11-07','Ingreso al sistema',1,3,1),(43,'HECTORCARDONA','192.168.232.1','21:31:02','2015-11-07','Ingreso al sistema',1,3,1),(44,'HECTORCARDONA','192.168.232.1','21:32:46','2015-11-07','Ingreso al sistema',1,3,1),(45,'HECTORCARDONA','192.168.232.1','21:32:59','2015-11-07','Ingreso al sistema',1,2,1),(46,'HECTORCARDONA','192.168.232.1','23:03:50','2015-11-07','Ingreso al sistema',1,3,1),(47,'HECTORCARDONA','192.168.232.1','23:07:45','2015-11-07','Ingreso al sistema',1,3,1),(48,'HECTORCARDONA','192.168.232.1','23:09:37','2015-11-07','Ingreso al sistema',1,3,1),(49,'HECTORCARDONA','192.168.232.1','23:16:15','2015-11-07','Ingreso al sistema',1,3,1),(50,'HECTORCARDONA','192.168.232.1','23:18:47','2015-11-07','Ingreso al sistema',1,3,1),(51,'HECTORCARDONA','192.168.232.1','23:24:37','2015-11-07','Ingreso al sistema',1,3,1),(52,'HECTORCARDONA','192.168.232.1','06:35:49','2015-11-08','Ingreso al sistema',1,3,1),(53,'HECTORCARDONA','192.168.232.1','08:43:30','2015-11-08','Ingreso al sistema',1,3,1),(54,'HECTORCARDONA','192.168.232.1','08:44:48','2015-11-08','Ingreso al sistema',1,1,1),(55,'HECTORCARDONA','192.168.232.1','08:45:02','2015-11-08','Ingreso al sistema',1,3,1),(56,'HECTORCARDONA','192.168.232.1','08:45:57','2015-11-08','Ingreso al sistema',1,1,1),(57,'HECTORCARDONA','192.168.232.1','08:46:38','2015-11-08','Ingreso al sistema',1,3,1),(58,'HECTORCARDONA','192.168.232.1','08:48:17','2015-11-08','Ingreso al sistema',1,1,1),(59,'HECTORCARDONA','192.168.232.1','09:43:36','2015-11-08','Ingreso al sistema',1,1,1),(60,'HECTORCARDONA','192.168.232.1','10:09:37','2015-11-08','Ingreso al sistema',1,3,1),(61,'HECTORCARDONA','192.168.232.1','10:09:50','2015-11-08','Ingreso al sistema',1,1,1),(62,'HECTORCARDONA','192.168.232.1','10:14:12','2015-11-08','Ingreso al sistema',1,1,1),(63,'HECTORCARDONA','192.168.232.1','10:17:20','2015-11-08','Ingreso al sistema',1,1,1),(64,'HECTORCARDONA','192.168.232.1','10:23:06','2015-11-08','Ingreso al sistema',1,1,1),(65,'HECTORCARDONA','192.168.232.1','10:24:34','2015-11-08','Ingreso al sistema',1,1,1),(66,'HECTORCARDONA','192.168.232.1','10:27:52','2015-11-08','Ingreso al sistema',1,1,1),(67,'HECTORCARDONA','192.168.232.1','10:31:37','2015-11-08','Ingreso al sistema',1,1,1),(68,'HECTORCARDONA','192.168.232.1','10:42:52','2015-11-08','Ingreso al sistema',1,1,1),(69,'HECTORCARDONA','192.168.232.1','10:48:58','2015-11-08','Ingreso al sistema',1,1,1),(70,'HECTORCARDONA','192.168.232.1','10:50:01','2015-11-08','Ingreso al sistema',1,3,1),(71,'HECTORCARDONA','192.168.232.1','10:50:35','2015-11-08','Ingreso al sistema',1,1,1),(72,'HECTORCARDONA','192.168.232.1','10:51:20','2015-11-08','Ingreso al sistema',1,3,1),(73,'HECTORCARDONA','192.168.232.1','10:54:01','2015-11-08','Ingreso al sistema',1,1,1),(74,'HECTORCARDONA','192.168.232.1','10:56:15','2015-11-08','Ingreso al sistema',1,1,1),(75,'HECTORCARDONA','192.168.232.1','10:58:30','2015-11-08','Ingreso al sistema',1,3,1),(76,'HECTORCARDONA','192.168.232.1','11:00:40','2015-11-08','Ingreso al sistema',1,1,1),(77,'HECTORCARDONA','192.168.232.1','11:39:08','2015-11-08','Ingreso al sistema',1,1,1),(78,'HECTORCARDONA','192.168.232.1','12:00:38','2015-11-08','Ingreso al sistema',1,1,1),(79,'HECTORCARDONA','192.168.232.1','12:02:05','2015-11-08','Ingreso al sistema',1,1,1),(80,'HECTORCARDONA','192.168.232.1','12:02:45','2015-11-08','Ingreso al sistema',1,3,1),(81,'HECTORCARDONA','192.168.232.1','12:03:01','2015-11-08','Ingreso al sistema',1,1,1),(82,'HECTORCARDONA','192.168.232.1','12:03:44','2015-11-08','Ingreso al sistema',1,3,1),(83,'PAMELAJSD','fe80::c84d:2d2c:5006','21:14:47','2015-11-09','Ingreso al sistema',1,1,1),(84,'PAMELAJSD','fe80::c84d:2d2c:5006','21:28:11','2015-11-09','Ingreso al sistema',1,1,1),(85,'PAMELAJSD','fe80::c84d:2d2c:5006','21:44:09','2015-11-09','Ingreso al sistema',1,1,1),(86,'PAMELAJSD','fe80::c84d:2d2c:5006','21:44:34','2015-11-09','Ingreso al sistema',1,1,1),(87,'PAMELAJSD','fe80::c84d:2d2c:5006','21:48:07','2015-11-09','Ingreso al sistema',1,1,1),(88,'PAMELAJSD','fe80::c84d:2d2c:5006','21:49:55','2015-11-09','Ingreso al sistema',1,4,1),(89,'PAMELAJSD','fe80::c84d:2d2c:5006','21:55:19','2015-11-09','Ingreso al sistema',1,1,1),(90,'PAMELAJSD','fe80::c84d:2d2c:5006','22:07:58','2015-11-09','Ingreso al sistema',1,3,1),(91,'PAMELAJSD','fe80::c84d:2d2c:5006','22:08:26','2015-11-09','Ingreso al sistema',1,1,1),(92,'PAMELAJSD','fe80::c84d:2d2c:5006','22:32:09','2015-11-09','Ingreso al sistema',1,1,1),(93,'PAMELAJSD','fe80::c84d:2d2c:5006','22:39:01','2015-11-09','Ingreso al sistema',1,4,1),(94,'PAMELAJSD','fe80::c84d:2d2c:5006','23:07:59','2015-11-09','Ingreso al sistema',1,4,1),(95,'PAMELAJSD','fe80::c84d:2d2c:5006','23:10:25','2015-11-09','Ingreso al sistema',1,4,1),(96,'PAMELAJSD','fe80::c84d:2d2c:5006','23:14:41','2015-11-09','Ingreso al sistema',1,4,1),(97,'PAMELAJSD','fe80::c84d:2d2c:5006','23:16:11','2015-11-09','Ingreso al sistema',1,3,1),(98,'PAMELAJSD','fe80::c84d:2d2c:5006','23:21:47','2015-11-09','Ingreso al sistema',1,4,1),(99,'PAMELAJSD','fe80::c84d:2d2c:5006','23:23:33','2015-11-09','Ingreso al sistema',1,4,1),(100,'PAMELAJSD','fe80::c84d:2d2c:5006','23:24:02','2015-11-09','Ingreso al sistema',1,4,1),(101,'PAMELAJSD','fe80::c84d:2d2c:5006','23:25:14','2015-11-09','Ingreso al sistema',1,4,1),(102,'PAMELAJSD','fe80::c84d:2d2c:5006','07:39:10','2015-11-10','Ingreso al sistema',1,4,1),(103,'PAMELAJSD','fe80::c84d:2d2c:5006','07:41:04','2015-11-10','Ingreso al sistema',1,3,1),(104,'PAMELAJSD','fe80::c84d:2d2c:5006','07:41:36','2015-11-10','Ingreso al sistema',1,4,1),(105,'PAMELAJSD','fe80::c84d:2d2c:5006','07:43:50','2015-11-10','Ingreso al sistema',1,4,1),(106,'PAMELAJSD','fe80::c84d:2d2c:5006','07:44:16','2015-11-10','Ingreso al sistema',1,4,1),(107,'PAMELAJSD','fe80::c84d:2d2c:5006','07:44:34','2015-11-10','Ingreso al sistema',1,4,1),(108,'PAMELAJSD','fe80::c84d:2d2c:5006','07:48:59','2015-11-10','Ingreso al sistema',1,4,1),(109,'PAMELAJSD','fe80::c84d:2d2c:5006','07:49:43','2015-11-10','Ingreso al sistema',1,4,1),(110,'PAMELAJSD','fe80::c84d:2d2c:5006','07:51:49','2015-11-10','Ingreso al sistema',1,4,1),(111,'PAMELAJSD','fe80::c84d:2d2c:5006','07:52:58','2015-11-10','Ingreso al sistema',1,4,1),(112,'PAMELAJSD','fe80::c84d:2d2c:5006','08:01:10','2015-11-10','Ingreso al sistema',1,4,1),(113,'PAMELAJSD','fe80::c84d:2d2c:5006','08:04:17','2015-11-10','Ingreso al sistema',1,4,1),(114,'PAMELAJSD','fe80::c84d:2d2c:5006','08:06:42','2015-11-10','Ingreso al sistema',1,4,1),(115,'PAMELAJSD','fe80::c84d:2d2c:5006','08:09:59','2015-11-10','Ingreso al sistema',1,4,1),(116,'PAMELAJSD','fe80::c84d:2d2c:5006','08:33:49','2015-11-10','Ingreso al sistema',1,4,1),(117,'PAMELAJSD','fe80::c84d:2d2c:5006','08:38:01','2015-11-10','Ingreso al sistema',1,4,1),(118,'PAMELAJSD','fe80::c84d:2d2c:5006','08:39:37','2015-11-10','Ingreso al sistema',1,4,1),(119,'PAMELAJSD','fe80::c84d:2d2c:5006','08:40:19','2015-11-10','Ingreso al sistema',1,4,1),(120,'PAMELAJSD','fe80::c84d:2d2c:5006','08:41:56','2015-11-10','Ingreso al sistema',1,4,1),(121,'PAMELAJSD','fe80::c84d:2d2c:5006','08:57:26','2015-11-10','Ingreso al sistema',1,4,1),(122,'PAMELAJSD','fe80::c84d:2d2c:5006','09:07:12','2015-11-10','Ingreso al sistema',1,4,1),(123,'PAMELAJSD','fe80::c84d:2d2c:5006','09:11:21','2015-11-10','Ingreso al sistema',1,4,1),(124,'PAMELAJSD','fe80::c84d:2d2c:5006','09:15:04','2015-11-10','Ingreso al sistema',1,4,1),(125,'PAMELAJSD','fe80::c84d:2d2c:5006','09:15:28','2015-11-10','Ingreso al sistema',1,4,1),(126,'PAMELAJSD','fe80::c84d:2d2c:5006','09:17:57','2015-11-10','Ingreso al sistema',1,4,1),(127,'PAMELAJSD','fe80::c84d:2d2c:5006','09:18:56','2015-11-10','Ingreso al sistema',1,4,1),(128,'PAMELAJSD','fe80::c84d:2d2c:5006','09:20:16','2015-11-10','Ingreso al sistema',1,4,1),(129,'PAMELAJSD','fe80::c84d:2d2c:5006','09:20:50','2015-11-10','Ingreso al sistema',1,4,1),(130,'PAMELAJSD','fe80::c84d:2d2c:5006','09:21:40','2015-11-10','Ingreso al sistema',1,4,1),(131,'PAMELAJSD','fe80::c84d:2d2c:5006','09:32:09','2015-11-10','Ingreso al sistema',1,4,1),(132,'PAMELAJSD','fe80::c84d:2d2c:5006','09:33:03','2015-11-10','Ingreso al sistema',1,4,1),(133,'PAMELAJSD','fe80::c84d:2d2c:5006','09:34:42','2015-11-10','Ingreso al sistema',1,4,1),(134,'PAMELAJSD','fe80::c84d:2d2c:5006','09:36:28','2015-11-10','Ingreso al sistema',1,4,1),(135,'PAMELAJSD','fe80::c84d:2d2c:5006','09:37:54','2015-11-10','Ingreso al sistema',1,4,1),(136,'PAMELAJSD','fe80::c84d:2d2c:5006','09:41:06','2015-11-10','Ingreso al sistema',1,4,1),(137,'PAMELAJSD','fe80::c84d:2d2c:5006','10:10:40','2015-11-10','Ingreso al sistema',1,4,1),(138,'PAMELAJSD','fe80::c84d:2d2c:5006','10:11:46','2015-11-10','Ingreso al sistema',1,4,1),(139,'PAMELAJSD','fe80::c84d:2d2c:5006','10:13:11','2015-11-10','Ingreso al sistema',1,4,1),(140,'PAMELAJSD','fe80::c84d:2d2c:5006','10:27:15','2015-11-10','Ingreso al sistema',1,4,1),(141,'PAMELAJSD','fe80::c84d:2d2c:5006','10:30:54','2015-11-10','Ingreso al sistema',1,4,1),(142,'PAMELAJSD','fe80::c84d:2d2c:5006','10:31:41','2015-11-10','Ingreso al sistema',1,4,1),(143,'PAMELAJSD','fe80::c84d:2d2c:5006','10:33:29','2015-11-10','Ingreso al sistema',1,4,1),(144,'PAMELAJSD','fe80::c84d:2d2c:5006','10:35:22','2015-11-10','Ingreso al sistema',1,4,1),(145,'PAMELAJSD','fe80::c84d:2d2c:5006','10:36:05','2015-11-10','Ingreso al sistema',1,4,1),(146,'PAMELAJSD','fe80::c84d:2d2c:5006','10:36:57','2015-11-10','Ingreso al sistema',1,4,1),(147,'PAMELAJSD','fe80::c84d:2d2c:5006','10:38:07','2015-11-10','Ingreso al sistema',1,4,1),(148,'PAMELAJSD','fe80::c84d:2d2c:5006','10:38:25','2015-11-10','Ingreso al sistema',1,4,1),(149,'PAMELAJSD','fe80::c84d:2d2c:5006','10:38:53','2015-11-10','Ingreso al sistema',1,4,1),(150,'PAMELAJSD','fe80::c84d:2d2c:5006','10:39:40','2015-11-10','Ingreso al sistema',1,4,1),(151,'PAMELAJSD','fe80::c84d:2d2c:5006','10:43:46','2015-11-10','Ingreso al sistema',1,1,1),(152,'PAMELAJSD','fe80::c84d:2d2c:5006','10:44:26','2015-11-10','Ingreso al sistema',1,4,1),(153,'PAMELAJSD','fe80::c84d:2d2c:5006','10:45:03','2015-11-10','Ingreso al sistema',1,1,1),(154,'PAMELAJSD','fe80::c84d:2d2c:5006','10:46:02','2015-11-10','Ingreso al sistema',1,1,1),(155,'PAMELAJSD','fe80::c84d:2d2c:5006','10:46:53','2015-11-10','Ingreso al sistema',1,1,1),(156,'PAMELAJSD','fe80::c84d:2d2c:5006','10:47:25','2015-11-10','Ingreso al sistema',1,4,1),(157,'PAMELAJSD','fe80::c84d:2d2c:5006','10:58:42','2015-11-10','Ingreso al sistema',1,4,1),(158,'PAMELAJSD','fe80::c84d:2d2c:5006','10:59:19','2015-11-10','Ingreso al sistema',1,4,1),(159,'PAMELAJSD','fe80::c84d:2d2c:5006','11:00:57','2015-11-10','Ingreso al sistema',1,4,1),(160,'PAMELAJSD','fe80::c84d:2d2c:5006','11:02:25','2015-11-10','Ingreso al sistema',1,4,1),(161,'PAMELAJSD','fe80::c84d:2d2c:5006','11:04:50','2015-11-10','Ingreso al sistema',1,4,1),(162,'PAMELAJSD','fe80::c84d:2d2c:5006','11:05:26','2015-11-10','Ingreso al sistema',1,4,1),(163,'PAMELAJSD','fe80::c84d:2d2c:5006','22:35:25','2015-11-10','Ingreso al sistema',1,4,1),(164,'PAMELAJSD','fe80::c84d:2d2c:5006','22:38:46','2015-11-10','Ingreso al sistema',1,4,1),(165,'PAMELAJSD','fe80::c84d:2d2c:5006','07:14:46','2015-11-11','Ingreso al sistema',1,4,1),(166,'PAMELAJSD','fe80::c84d:2d2c:5006','07:21:16','2015-11-11','Ingreso al sistema',1,4,1),(167,'PAMELAJSD','fe80::c84d:2d2c:5006','07:25:14','2015-11-11','Ingreso al sistema',1,4,1),(168,'PAMELAJSD','fe80::c84d:2d2c:5006','07:33:10','2015-11-11','Ingreso al sistema',1,4,1),(169,'PAMELAJSD','fe80::c84d:2d2c:5006','07:43:30','2015-11-11','Ingreso al sistema',1,4,1),(170,'PAMELAJSD','fe80::c84d:2d2c:5006','07:45:40','2015-11-11','Ingreso al sistema',1,4,1),(171,'PAMELAJSD','fe80::c84d:2d2c:5006','07:47:53','2015-11-11','Ingreso al sistema',1,4,1),(172,'PAMELAJSD','fe80::c84d:2d2c:5006','07:53:05','2015-11-11','Ingreso al sistema',1,4,1),(173,'PAMELAJSD','fe80::c84d:2d2c:5006','07:59:22','2015-11-11','Ingreso al sistema',1,4,1),(174,'PAMELAJSD','fe80::c84d:2d2c:5006','08:00:52','2015-11-11','Ingreso al sistema',1,4,1),(175,'PAMELAJSD','fe80::c84d:2d2c:5006','08:04:39','2015-11-11','Ingreso al sistema',1,4,1),(176,'PAMELAJSD','fe80::c84d:2d2c:5006','08:11:29','2015-11-11','Ingreso al sistema',1,4,1),(177,'PAMELAJSD','fe80::c84d:2d2c:5006','08:12:56','2015-11-11','Ingreso al sistema',1,4,1),(178,'PAMELAJSD','fe80::c84d:2d2c:5006','08:20:41','2015-11-11','Ingreso al sistema',1,4,1),(179,'PAMELAJSD','fe80::c84d:2d2c:5006','08:22:10','2015-11-11','Ingreso al sistema',1,4,1),(180,'PAMELAJSD','fe80::c84d:2d2c:5006','08:26:57','2015-11-11','Ingreso al sistema',1,4,1),(181,'PAMELAJSD','fe80::c84d:2d2c:5006','08:34:13','2015-11-11','Ingreso al sistema',1,4,1),(182,'PAMELAJSD','fe80::c84d:2d2c:5006','08:36:47','2015-11-11','Ingreso al sistema',1,4,1),(183,'PAMELAJSD','fe80::c84d:2d2c:5006','08:44:31','2015-11-11','Ingreso al sistema',1,4,1),(184,'PAMELAJSD','fe80::c84d:2d2c:5006','08:48:18','2015-11-11','Ingreso al sistema',1,4,1),(185,'PAMELAJSD','fe80::c84d:2d2c:5006','08:50:44','2015-11-11','Ingreso al sistema',1,4,1),(186,'PAMELAJSD','fe80::c84d:2d2c:5006','08:51:39','2015-11-11','Ingreso al sistema',1,4,1),(187,'PAMELAJSD','fe80::c84d:2d2c:5006','08:52:49','2015-11-11','Ingreso al sistema',1,4,1),(188,'PAMELAJSD','fe80::c84d:2d2c:5006','08:53:47','2015-11-11','Ingreso al sistema',1,4,1),(189,'PAMELAJSD','fe80::c84d:2d2c:5006','09:41:46','2015-11-11','Ingreso al sistema',1,4,1),(190,'PAMELAJSD','fe80::c84d:2d2c:5006','09:50:43','2015-11-11','Ingreso al sistema',1,4,1),(191,'PAMELAJSD','fe80::c84d:2d2c:5006','09:52:36','2015-11-11','Ingreso al sistema',1,4,1),(192,'PAMELAJSD','fe80::c84d:2d2c:5006','20:55:52','2015-11-11','Ingreso al sistema',1,4,1),(193,'PAMELAJSD','fe80::c84d:2d2c:5006','21:22:33','2015-11-11','Ingreso al sistema',1,4,1),(194,'PAMELAJSD','fe80::c84d:2d2c:5006','21:24:40','2015-11-11','Ingreso al sistema',1,4,1),(195,'PAMELAJSD','fe80::c84d:2d2c:5006','21:27:36','2015-11-11','Ingreso al sistema',1,4,1),(196,'PAMELAJSD','fe80::c84d:2d2c:5006','22:12:02','2015-11-11','Ingreso al sistema',1,4,1),(197,'PAMELAJSD','fe80::c84d:2d2c:5006','23:17:37','2015-11-11','Ingreso al sistema',1,4,1),(198,'PAMELAJSD','fe80::c84d:2d2c:5006','23:20:45','2015-11-11','Ingreso al sistema',1,4,1),(199,'PAMELAJSD','fe80::c84d:2d2c:5006','07:58:13','2015-11-12','Ingreso al sistema',1,4,1),(200,'PAMELAJSD','fe80::c84d:2d2c:5006','08:07:25','2015-11-12','Ingreso al sistema',1,4,1),(201,'PAMELAJSD','fe80::c84d:2d2c:5006','08:10:44','2015-11-12','Ingreso al sistema',1,4,1),(202,'PAMELAJSD','fe80::c84d:2d2c:5006','08:14:02','2015-11-12','Ingreso al sistema',1,4,1),(203,'PAMELAJSD','fe80::c84d:2d2c:5006','08:29:13','2015-11-12','Ingreso al sistema',1,4,1),(204,'PAMELAJSD','fe80::c84d:2d2c:5006','09:10:49','2015-11-12','Ingreso al sistema',1,4,1),(205,'PAMELAJSD','fe80::c84d:2d2c:5006','09:34:28','2015-11-12','Ingreso al sistema',1,4,1),(206,'PAMELAJSD','fe80::c84d:2d2c:5006','09:37:53','2015-11-12','Ingreso al sistema',1,4,1),(207,'PAMELAJSD','fe80::c84d:2d2c:5006','09:40:41','2015-11-12','Ingreso al sistema',1,4,1),(208,'PAMELAJSD','fe80::c84d:2d2c:5006','09:42:02','2015-11-12','Ingreso al sistema',1,4,1),(209,'PAMELAJSD','fe80::c84d:2d2c:5006','11:08:58','2015-11-12','Ingreso al sistema',1,4,1),(210,'PAMELAJSD','fe80::c84d:2d2c:5006','11:12:29','2015-11-12','Ingreso al sistema',1,4,1),(211,'PAMELAJSD','fe80::c84d:2d2c:5006','11:14:15','2015-11-12','Ingreso al sistema',1,4,1),(212,'PAMELAJSD','fe80::c84d:2d2c:5006','11:15:09','2015-11-12','Ingreso al sistema',1,4,1),(213,'PAMELAJSD','fe80::c84d:2d2c:5006','11:15:40','2015-11-12','Ingreso al sistema',1,4,1),(214,'PAMELAJSD','fe80::c84d:2d2c:5006','11:16:51','2015-11-12','Ingreso al sistema',1,4,1),(215,'PAMELAJSD','fe80::c84d:2d2c:5006','11:18:13','2015-11-12','Ingreso al sistema',1,4,1),(216,'PAMELAJSD','fe80::c84d:2d2c:5006','11:20:14','2015-11-12','Ingreso al sistema',1,4,1),(217,'PAMELAJSD','fe80::c84d:2d2c:5006','11:21:17','2015-11-12','Ingreso al sistema',1,4,1);
/*!40000 ALTER TABLE `mabitacora` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `mabodega`
--

DROP TABLE IF EXISTS `mabodega`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `mabodega` (
  `ncodbodega` int(11) NOT NULL AUTO_INCREMENT,
  `vnombrebodega` varchar(30) DEFAULT NULL,
  `vdireccionbodega` varchar(40) DEFAULT NULL,
  PRIMARY KEY (`ncodbodega`)
) ENGINE=MyISAM DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `mabodega`
--

LOCK TABLES `mabodega` WRITE;
/*!40000 ALTER TABLE `mabodega` DISABLE KEYS */;
/*!40000 ALTER TABLE `mabodega` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `macapacitacion`
--

DROP TABLE IF EXISTS `macapacitacion`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `macapacitacion` (
  `ncodcapacitacion` int(11) NOT NULL AUTO_INCREMENT,
  `vnecesidad` varchar(20) DEFAULT NULL,
  `vobjetivo` varchar(20) DEFAULT NULL,
  `vresultadosesperados` varchar(30) DEFAULT NULL,
  `vresponsable` varchar(30) DEFAULT NULL,
  `vdetalle` varchar(60) DEFAULT NULL,
  `iparticipantes` int(11) DEFAULT NULL,
  `vtiempo` varchar(10) DEFAULT NULL,
  `vnombrecapacitacion` varchar(10) DEFAULT NULL,
  `vtipo` varchar(10) DEFAULT NULL,
  `ncodempleado` int(11) NOT NULL,
  PRIMARY KEY (`ncodcapacitacion`),
  KEY `RefMaEMPLEADO87` (`ncodempleado`)
) ENGINE=MyISAM DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `macapacitacion`
--

LOCK TABLES `macapacitacion` WRITE;
/*!40000 ALTER TABLE `macapacitacion` DISABLE KEYS */;
/*!40000 ALTER TABLE `macapacitacion` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `macliente`
--

DROP TABLE IF EXISTS `macliente`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `macliente` (
  `ncodcliente` int(11) NOT NULL AUTO_INCREMENT,
  `vnit` varchar(18) DEFAULT NULL,
  `vnombrecliente` varchar(30) DEFAULT NULL,
  `vapellidocliente` varchar(40) DEFAULT NULL,
  `vdireccion` varchar(30) DEFAULT NULL,
  `ntelefono` int(11) DEFAULT NULL,
  `vcorreo` varchar(30) DEFAULT NULL,
  `vestado` varchar(20) DEFAULT NULL,
  `ncodvendedor` int(11) DEFAULT NULL,
  PRIMARY KEY (`ncodcliente`)
) ENGINE=MyISAM AUTO_INCREMENT=8 DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `macliente`
--

LOCK TABLES `macliente` WRITE;
/*!40000 ALTER TABLE `macliente` DISABLE KEYS */;
INSERT INTO `macliente` VALUES (1,'122335','Pamela  Jacqueline','Selman David','Guatemala',121212,'pamela','ACTIVO',NULL),(2,'121212121','Jose ','Chajon','Guatemala',2131,'jchajon@gmail.com','ACTIVO',NULL),(3,'121212121','Jose Andrés','Chajon Cueto','Guatemala',2131,'jchajon@gmail.com','ACTIVO',3),(5,'1212','Sabrina','Gomez','Guatemala',23252,'sabrina@gmail.com','',NULL),(4,'Guatemala','Dennys Ivan','Choy','1234423',2345233,'dennys@gmail.com','ACTIVO',1),(6,'Guatemala','Gerardo','Santizo','234455-9',22334455,'gerardo@gmail.com','ACTIVO',2),(7,'1222124-2','Sabrina María','Gomez Girón','Guatemala',23423233,'sabrina@yahoo.com','ACTIVO',2);
/*!40000 ALTER TABLE `macliente` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `macognitivo`
--

DROP TABLE IF EXISTS `macognitivo`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `macognitivo` (
  `vtipo` varchar(10) DEFAULT NULL,
  `vdescripcion` varchar(30) DEFAULT NULL,
  `vestado` varchar(10) DEFAULT NULL,
  `ncodempleado` int(11) NOT NULL,
  KEY `RefMaEMPLEADO45` (`ncodempleado`)
) ENGINE=MyISAM DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `macognitivo`
--

LOCK TABLES `macognitivo` WRITE;
/*!40000 ALTER TABLE `macognitivo` DISABLE KEYS */;
/*!40000 ALTER TABLE `macognitivo` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `macompra`
--

DROP TABLE IF EXISTS `macompra`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `macompra` (
  `ncodcompra` int(11) NOT NULL AUTO_INCREMENT,
  `vdescripcioncompra` varchar(100) DEFAULT NULL,
  `ncantidad` decimal(10,0) DEFAULT NULL,
  `ncostototal` decimal(10,0) DEFAULT NULL,
  `dfecha` date DEFAULT NULL,
  PRIMARY KEY (`ncodcompra`)
) ENGINE=MyISAM AUTO_INCREMENT=2 DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `macompra`
--

LOCK TABLES `macompra` WRITE;
/*!40000 ALTER TABLE `macompra` DISABLE KEYS */;
INSERT INTO `macompra` VALUES (1,'a',2,200,NULL);
/*!40000 ALTER TABLE `macompra` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `macotizacion`
--

DROP TABLE IF EXISTS `macotizacion`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `macotizacion` (
  `ncodcotizacion` int(11) NOT NULL,
  `vserie` varchar(10) DEFAULT NULL,
  `dfechacotizacion` date DEFAULT NULL,
  `dfechavencimiento` date DEFAULT NULL,
  `ntotal` decimal(10,0) DEFAULT NULL,
  `vestadocotizacion` varchar(10) DEFAULT NULL,
  `ncodcliente` int(11) NOT NULL,
  `vnombrevendedor` varchar(25) DEFAULT NULL,
  `ncodvendedor` int(11) NOT NULL,
  PRIMARY KEY (`ncodcotizacion`),
  KEY `RefMaCLIENTE101` (`ncodcliente`),
  KEY `RefMaVENDEDOR14` (`ncodvendedor`)
) ENGINE=MyISAM DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `macotizacion`
--

LOCK TABLES `macotizacion` WRITE;
/*!40000 ALTER TABLE `macotizacion` DISABLE KEYS */;
INSERT INTO `macotizacion` VALUES (1,'A','0000-00-00','0000-00-00',0,'Pendiente ',1,NULL,1),(2,'A','0000-00-00','0000-00-00',0,'Pendiente ',1,NULL,1),(3,'A','0000-00-00','0000-00-00',0,'Pendiente ',1,NULL,1),(4,'A','0000-00-00','0000-00-00',0,'Pendiente ',1,NULL,1),(5,'C','0000-00-00','0000-00-00',0,'Pendiente ',1,NULL,1),(6,'A','0000-00-00','0000-00-00',240,'Pendiente ',1,NULL,1),(7,'C','0000-00-00','0000-00-00',1200,'Pendiente ',1,NULL,1),(8,'B','2015-12-11','2015-11-30',144,'Pendiente ',1,NULL,1),(9,'C','2015-12-11','2015-11-26',1068,'Pendiente ',1,NULL,1);
/*!40000 ALTER TABLE `macotizacion` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `macuenta`
--

DROP TABLE IF EXISTS `macuenta`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `macuenta` (
  `ncodcuenta` int(11) NOT NULL AUTO_INCREMENT,
  `ncodbanco` int(11) NOT NULL,
  `ncoddocumento` int(11) NOT NULL,
  PRIMARY KEY (`ncodcuenta`),
  KEY `RefTrDOCUMENTOS29` (`ncoddocumento`),
  KEY `RefMaBANCO51` (`ncodbanco`)
) ENGINE=MyISAM DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `macuenta`
--

LOCK TABLES `macuenta` WRITE;
/*!40000 ALTER TABLE `macuenta` DISABLE KEYS */;
/*!40000 ALTER TABLE `macuenta` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `madetallecotizacion`
--

DROP TABLE IF EXISTS `madetallecotizacion`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `madetallecotizacion` (
  `ncodcotizacion` int(11) NOT NULL,
  `ncantidadcotizada` decimal(10,0) DEFAULT NULL,
  `npreciocotizado` decimal(10,0) DEFAULT NULL,
  `ncodarticulo` int(11) NOT NULL,
  KEY `RefMaCOTIZACION102` (`ncodcotizacion`),
  KEY `RefMaPRODUCTO103` (`ncodarticulo`)
) ENGINE=MyISAM DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `madetallecotizacion`
--

LOCK TABLES `madetallecotizacion` WRITE;
/*!40000 ALTER TABLE `madetallecotizacion` DISABLE KEYS */;
INSERT INTO `madetallecotizacion` VALUES (0,12,144,0),(0,12,12,0),(0,10,120,0),(5,212,12,0),(5,1,12,0),(6,20,240,0),(6,12,144,0),(7,100,1200,0),(8,12,144,0),(9,89,1068,0);
/*!40000 ALTER TABLE `madetallecotizacion` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `madetallefactura`
--

DROP TABLE IF EXISTS `madetallefactura`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `madetallefactura` (
  `ncodarticulo` int(11) NOT NULL,
  `ncantidadventa` int(11) NOT NULL,
  `nprecioventa` int(11) DEFAULT NULL,
  `ncodfactura` int(11) NOT NULL,
  KEY `RefMaPRODUCTO61` (`ncodarticulo`),
  KEY `RefMaFACTURA88` (`ncodfactura`)
) ENGINE=MyISAM DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `madetallefactura`
--

LOCK TABLES `madetallefactura` WRITE;
/*!40000 ALTER TABLE `madetallefactura` DISABLE KEYS */;
INSERT INTO `madetallefactura` VALUES (1,4,48,3),(1,10,120,3),(1,10,120,3),(1,1,12,0),(1,12,144,4),(1,10,120,8),(1,10,12,0),(1,10,12,9),(1,20,12,10),(0,0,0,10),(1,1,12,11),(1,1,12,12),(1,12,12,13),(1,19,228,15),(1,10,120,16),(1,10,120,16),(1,12,144,17),(1,10,120,18),(1,10,120,19),(1,5,60,20),(2,100,1000,20);
/*!40000 ALTER TABLE `madetallefactura` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `madetallepedido`
--

DROP TABLE IF EXISTS `madetallepedido`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `madetallepedido` (
  `ncodpedido` int(11) NOT NULL,
  `dcodproducto` decimal(10,0) DEFAULT NULL,
  `dcantidadpedido` decimal(10,0) DEFAULT NULL,
  `dpreciopedido` decimal(10,0) DEFAULT NULL,
  `ncodarticulo` int(11) NOT NULL,
  KEY `RefTrPEDIDO104` (`ncodpedido`),
  KEY `RefMaPRODUCTO105` (`ncodarticulo`)
) ENGINE=MyISAM DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `madetallepedido`
--

LOCK TABLES `madetallepedido` WRITE;
/*!40000 ALTER TABLE `madetallepedido` DISABLE KEYS */;
INSERT INTO `madetallepedido` VALUES (0,NULL,12,144,0),(2,NULL,12,144,0),(3,NULL,10,120,0),(4,NULL,10,120,0),(4,NULL,10,120,0),(5,NULL,1,12,0),(6,NULL,10,120,0),(7,NULL,10,120,0),(8,NULL,89,1068,0);
/*!40000 ALTER TABLE `madetallepedido` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `madocporpagar`
--

DROP TABLE IF EXISTS `madocporpagar`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `madocporpagar` (
  `ndocumento` int(11) NOT NULL AUTO_INCREMENT,
  `vfechaemision` date DEFAULT NULL,
  `ntotalpago` decimal(10,0) DEFAULT NULL,
  `ndeudaactual` decimal(10,0) DEFAULT NULL,
  `vdescripcioncompra` varchar(30) DEFAULT NULL,
  `vnumerodocfisico` varchar(10) DEFAULT NULL,
  `ncodproveedor` int(11) NOT NULL,
  `ncodtipodocumento` int(11) NOT NULL,
  PRIMARY KEY (`ndocumento`),
  KEY `RefMaPROVEEDOR35` (`ncodproveedor`),
  KEY `RefMaTIPODOCUMENTO42` (`ncodtipodocumento`)
) ENGINE=MyISAM DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `madocporpagar`
--

LOCK TABLES `madocporpagar` WRITE;
/*!40000 ALTER TABLE `madocporpagar` DISABLE KEYS */;
/*!40000 ALTER TABLE `madocporpagar` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `maempleado`
--

DROP TABLE IF EXISTS `maempleado`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `maempleado` (
  `ncodempleado` int(11) NOT NULL AUTO_INCREMENT,
  `vnombreempleado` varchar(40) DEFAULT NULL,
  `vapellidoempleado` varchar(40) DEFAULT NULL,
  `vestadocivil` varchar(30) DEFAULT NULL,
  `dsalario` decimal(10,0) DEFAULT NULL,
  `dcomision` decimal(10,0) DEFAULT NULL,
  `vtipo` varchar(30) DEFAULT NULL,
  `vescolaridad` varchar(30) DEFAULT NULL,
  `dtelefono` decimal(10,0) DEFAULT NULL,
  `vcargo` varchar(30) DEFAULT NULL,
  `vdpi` varchar(10) DEFAULT NULL,
  `nedad` decimal(10,0) DEFAULT NULL,
  `vgenero` varchar(30) DEFAULT NULL,
  `dnumcuenta` decimal(10,0) DEFAULT NULL,
  `ncodhistoria` int(11) NOT NULL,
  `ncoddepartamento` int(11) NOT NULL,
  `ncodusuario` int(11) DEFAULT NULL,
  PRIMARY KEY (`ncodempleado`),
  KEY `RefTrHISTORIAEMP55` (`ncodhistoria`),
  KEY `RefMaUSUARIO74` (`ncodusuario`),
  KEY `RefTrDEPARTAMENTO89` (`ncoddepartamento`)
) ENGINE=MyISAM DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `maempleado`
--

LOCK TABLES `maempleado` WRITE;
/*!40000 ALTER TABLE `maempleado` DISABLE KEYS */;
/*!40000 ALTER TABLE `maempleado` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `maempresa`
--

DROP TABLE IF EXISTS `maempresa`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `maempresa` (
  `ncodempresa` int(11) NOT NULL,
  `vpuestovacante` varchar(20) DEFAULT NULL,
  `vnomempresa` varchar(20) DEFAULT NULL,
  `vdescripcion` varchar(50) DEFAULT NULL,
  `vtipoempresa` varchar(40) DEFAULT NULL,
  `vnombreempresa` varchar(30) DEFAULT NULL,
  `vdireccion` varchar(50) DEFAULT NULL,
  `dtelefono` decimal(10,0) DEFAULT NULL,
  PRIMARY KEY (`ncodempresa`)
) ENGINE=MyISAM DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `maempresa`
--

LOCK TABLES `maempresa` WRITE;
/*!40000 ALTER TABLE `maempresa` DISABLE KEYS */;
/*!40000 ALTER TABLE `maempresa` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `maencabezadoconciliacion`
--

DROP TABLE IF EXISTS `maencabezadoconciliacion`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `maencabezadoconciliacion` (
  `ncodconcilicacion` int(11) NOT NULL AUTO_INCREMENT,
  `dfecha` date DEFAULT NULL,
  `encargado` char(25) DEFAULT NULL,
  `cestado` char(20) DEFAULT NULL,
  `ncodcuenta` int(11) DEFAULT NULL,
  PRIMARY KEY (`ncodconcilicacion`),
  KEY `RefMaCUENTA109` (`ncodcuenta`)
) ENGINE=MyISAM DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `maencabezadoconciliacion`
--

LOCK TABLES `maencabezadoconciliacion` WRITE;
/*!40000 ALTER TABLE `maencabezadoconciliacion` DISABLE KEYS */;
/*!40000 ALTER TABLE `maencabezadoconciliacion` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `maerror`
--

DROP TABLE IF EXISTS `maerror`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `maerror` (
  `ncoderror` int(11) NOT NULL AUTO_INCREMENT,
  `dhora` time DEFAULT NULL,
  `dfecha` date DEFAULT NULL,
  `ncodusuario` int(11) NOT NULL,
  `ncodaccion` int(11) NOT NULL,
  `ncodaplicacion` int(11) NOT NULL,
  `vaccion` varchar(45) DEFAULT NULL,
  PRIMARY KEY (`ncoderror`),
  KEY `RefMaUSUARIO56` (`ncodusuario`),
  KEY `RefMaACCIONES58` (`ncodaccion`),
  KEY `RefMaAPLICACION68` (`ncodaplicacion`)
) ENGINE=MyISAM AUTO_INCREMENT=7 DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `maerror`
--

LOCK TABLES `maerror` WRITE;
/*!40000 ALTER TABLE `maerror` DISABLE KEYS */;
INSERT INTO `maerror` VALUES (1,'20:20:27','2015-11-07',0,1,1,'Usuario o ContraseÃ±a Incorrecta'),(2,'22:47:02','2015-11-07',0,1,1,'Hay Uno o mas Campos Vacios'),(3,'10:09:33','2015-11-08',3,1,1,'Usuario o ContraseÃ±a Incorrecta'),(4,'12:01:54','2015-11-08',3,1,1,'Usuario o ContraseÃ±a Incorrecta'),(5,'22:38:54','2015-11-09',4,1,1,'Usuario o Contraseña Incorrecta'),(6,'23:14:37','2015-11-09',4,1,1,'Usuario o Contraseña Incorrecta');
/*!40000 ALTER TABLE `maerror` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `mafactura`
--

DROP TABLE IF EXISTS `mafactura`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `mafactura` (
  `ncodfactura` int(11) NOT NULL AUTO_INCREMENT,
  `vserie` varchar(10) DEFAULT NULL,
  `vestado` varchar(15) DEFAULT NULL,
  `dfechavencimiento` date DEFAULT NULL,
  `ntotal` decimal(10,0) DEFAULT NULL,
  `dfecha` date DEFAULT NULL,
  `ncodcliente` int(11) NOT NULL,
  `ncodvendedor` int(11) NOT NULL,
  PRIMARY KEY (`ncodfactura`),
  KEY `RefMaVENDEDOR7` (`ncodvendedor`),
  KEY `RefMaCLIENTE13` (`ncodcliente`)
) ENGINE=MyISAM AUTO_INCREMENT=21 DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `mafactura`
--

LOCK TABLES `mafactura` WRITE;
/*!40000 ALTER TABLE `mafactura` DISABLE KEYS */;
INSERT INTO `mafactura` VALUES (1,'A','Pendiente de Pa','2015-11-10',200,'2015-11-10',1,1),(2,'C','Pendiente de Pa','2015-11-10',200,'2015-11-10',1,1),(3,'A','Pendiente de Pa','2015-11-10',500,'2015-11-10',1,1),(4,'','Pendiente de Pa','2015-11-10',300,'2015-11-10',1,1),(5,'A','Pendiente de Pa','2015-11-10',1500,'2015-11-10',1,1),(6,'A','Pendiente de Pa','2015-11-10',112,'2015-11-10',1,1),(7,'A ','Pendiente de Pa','2015-11-10',122,'2015-11-10',1,1),(8,'A','Pendiente de Pa','0000-00-00',0,'0000-00-00',1,1),(9,'B','Pendiente de Pa','0000-00-00',0,'0000-00-00',1,1),(10,'A','Pendiente de Pa','0000-00-00',0,'0000-00-00',1,1),(11,'A','Pendiente de Pa','0000-00-00',0,'0000-00-00',1,1),(12,'A','Pendiente de Pa','0000-00-00',0,'0000-00-00',1,1),(13,'A','Pendiente de Pa','0000-00-00',0,'0000-00-00',1,1),(14,'A','Pendiente de Pa','0000-00-00',0,'0000-00-00',1,1),(15,'A','Pendiente de Pa','0000-00-00',0,'0000-00-00',1,1),(16,'A','Pendiente de Pa','0000-00-00',120,'0000-00-00',1,1),(17,'A','Pendiente de Pa','0000-00-00',288,'0000-00-00',1,1),(18,'B','Pendiente de Pa','0000-00-00',240,'0000-00-00',1,1),(19,'A','Pendiente de Pa','2015-11-18',240,'2015-11-11',1,1),(20,'A','Pendiente de Pa','2015-11-26',2000,'2015-11-12',1,1);
/*!40000 ALTER TABLE `mafactura` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `malineaarticulo`
--

DROP TABLE IF EXISTS `malineaarticulo`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `malineaarticulo` (
  `ncodlineaarticulo` int(11) NOT NULL AUTO_INCREMENT,
  `vnombre` varchar(30) DEFAULT NULL,
  `vdescripcion` varchar(10) DEFAULT NULL,
  PRIMARY KEY (`ncodlineaarticulo`)
) ENGINE=MyISAM AUTO_INCREMENT=4 DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `malineaarticulo`
--

LOCK TABLES `malineaarticulo` WRITE;
/*!40000 ALTER TABLE `malineaarticulo` DISABLE KEYS */;
INSERT INTO `malineaarticulo` VALUES (1,'Premium','Premium'),(2,'Matrimonial','Matrimonia'),(3,'Ortopedica','Ortopedica');
/*!40000 ALTER TABLE `malineaarticulo` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `malocacion`
--

DROP TABLE IF EXISTS `malocacion`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `malocacion` (
  `ncodlocacion` int(11) NOT NULL AUTO_INCREMENT,
  `direccion` varchar(40) DEFAULT NULL,
  `vcodpostal` varchar(10) DEFAULT NULL,
  `vciudad` varchar(10) DEFAULT NULL,
  `vprovincia` varchar(10) DEFAULT NULL,
  `ncodempleado` int(11) NOT NULL,
  PRIMARY KEY (`ncodlocacion`),
  KEY `RefMaEMPLEADO92` (`ncodempleado`)
) ENGINE=MyISAM DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `malocacion`
--

LOCK TABLES `malocacion` WRITE;
/*!40000 ALTER TABLE `malocacion` DISABLE KEYS */;
/*!40000 ALTER TABLE `malocacion` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `mamaterial`
--

DROP TABLE IF EXISTS `mamaterial`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `mamaterial` (
  `ncodmaterial` int(11) NOT NULL AUTO_INCREMENT,
  `vnombre` varchar(30) DEFAULT NULL,
  `ncantidad` decimal(10,0) DEFAULT NULL,
  `vestatus` varchar(10) DEFAULT NULL,
  `ncodarticulo` int(11) NOT NULL,
  PRIMARY KEY (`ncodmaterial`),
  KEY `RefMaPRODUCTO30` (`ncodarticulo`)
) ENGINE=MyISAM DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `mamaterial`
--

LOCK TABLES `mamaterial` WRITE;
/*!40000 ALTER TABLE `mamaterial` DISABLE KEYS */;
/*!40000 ALTER TABLE `mamaterial` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `mamodulo`
--

DROP TABLE IF EXISTS `mamodulo`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `mamodulo` (
  `ncodmodulo` int(11) NOT NULL AUTO_INCREMENT,
  `vnombremodulo` varchar(10) DEFAULT NULL,
  `vdescripcion` varchar(30) DEFAULT NULL,
  `vnombrereporte` varchar(10) DEFAULT NULL,
  PRIMARY KEY (`ncodmodulo`)
) ENGINE=MyISAM AUTO_INCREMENT=5 DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `mamodulo`
--

LOCK TABLES `mamodulo` WRITE;
/*!40000 ALTER TABLE `mamodulo` DISABLE KEYS */;
INSERT INTO `mamodulo` VALUES (1,'Seguridad','Seguridad Sistema',NULL),(2,'Reportes','reportes',NULL),(3,'Catalogos','Facturacion',NULL),(4,'Procesos','Procesos del Módulo',NULL);
/*!40000 ALTER TABLE `mamodulo` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `mamoneda`
--

DROP TABLE IF EXISTS `mamoneda`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `mamoneda` (
  `ncodmoneda` int(11) NOT NULL AUTO_INCREMENT,
  `cdescripcion` varchar(25) DEFAULT NULL,
  `cestado` char(15) DEFAULT NULL,
  `ncodbanco` int(11) NOT NULL,
  PRIMARY KEY (`ncodmoneda`),
  KEY `RefMaBANCO99` (`ncodbanco`)
) ENGINE=MyISAM DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `mamoneda`
--

LOCK TABLES `mamoneda` WRITE;
/*!40000 ALTER TABLE `mamoneda` DISABLE KEYS */;
/*!40000 ALTER TABLE `mamoneda` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `mamora`
--

DROP TABLE IF EXISTS `mamora`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `mamora` (
  `ncodmora` int(11) NOT NULL AUTO_INCREMENT,
  `dcantidad` decimal(10,0) DEFAULT NULL,
  `cestado` char(10) DEFAULT NULL,
  `ncodfactura` int(11) NOT NULL,
  PRIMARY KEY (`ncodmora`),
  KEY `RefMaFACTURA21` (`ncodfactura`)
) ENGINE=MyISAM DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `mamora`
--

LOCK TABLES `mamora` WRITE;
/*!40000 ALTER TABLE `mamora` DISABLE KEYS */;
/*!40000 ALTER TABLE `mamora` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `maobservacion`
--

DROP TABLE IF EXISTS `maobservacion`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `maobservacion` (
  `ncodobservacion` int(11) NOT NULL AUTO_INCREMENT,
  `cDescripcion` varchar(18) DEFAULT NULL,
  `cestado` char(20) DEFAULT NULL,
  `ncodDetalleConci` int(11) DEFAULT NULL,
  PRIMARY KEY (`ncodobservacion`),
  KEY `RefTrDETALLECONCILIACION111` (`ncodDetalleConci`)
) ENGINE=MyISAM DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `maobservacion`
--

LOCK TABLES `maobservacion` WRITE;
/*!40000 ALTER TABLE `maobservacion` DISABLE KEYS */;
/*!40000 ALTER TABLE `maobservacion` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `maordencompra`
--

DROP TABLE IF EXISTS `maordencompra`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `maordencompra` (
  `ncodordencompra` int(11) NOT NULL AUTO_INCREMENT,
  `ncodproveedor` int(11) NOT NULL,
  `vdescripcioncompra` varchar(40) DEFAULT NULL,
  `ncantidad` decimal(10,0) DEFAULT NULL,
  `dcostototal` decimal(10,0) DEFAULT NULL,
  `ncodarticulo` int(11) NOT NULL,
  PRIMARY KEY (`ncodordencompra`),
  KEY `RefMaPROVEEDOR32` (`ncodproveedor`),
  KEY `RefMaPRODUCTO97` (`ncodarticulo`)
) ENGINE=MyISAM DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `maordencompra`
--

LOCK TABLES `maordencompra` WRITE;
/*!40000 ALTER TABLE `maordencompra` DISABLE KEYS */;
/*!40000 ALTER TABLE `maordencompra` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `maordenproduccion`
--

DROP TABLE IF EXISTS `maordenproduccion`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `maordenproduccion` (
  `ncodordenes` int(11) NOT NULL AUTO_INCREMENT,
  `vreferenciaproducto` varchar(30) DEFAULT NULL,
  `cinicioproduccion` varchar(30) DEFAULT NULL,
  `ventregaproducto` varchar(30) DEFAULT NULL,
  `vultimomovimiento` varchar(10) DEFAULT NULL,
  `nnodocumento` decimal(10,0) DEFAULT NULL,
  `dcantidadproductoafabricar` decimal(10,0) DEFAULT NULL,
  `dcantidadnoproductoterminado` decimal(10,0) DEFAULT NULL,
  `dcantidadproductofaltante` char(10) DEFAULT NULL,
  `ncodprocesoorden` int(11) NOT NULL,
  `ncodstatusorden` int(11) DEFAULT NULL,
  PRIMARY KEY (`ncodordenes`),
  KEY `RefTrPROCESOORDEN77` (`ncodprocesoorden`),
  KEY `RefTrSTATUSORDEN110` (`ncodstatusorden`)
) ENGINE=MyISAM DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `maordenproduccion`
--

LOCK TABLES `maordenproduccion` WRITE;
/*!40000 ALTER TABLE `maordenproduccion` DISABLE KEYS */;
/*!40000 ALTER TABLE `maordenproduccion` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `mapedido`
--

DROP TABLE IF EXISTS `mapedido`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `mapedido` (
  `ncodpedido` int(11) NOT NULL AUTO_INCREMENT,
  `vserie` varchar(18) DEFAULT NULL,
  `dfechapedido` date DEFAULT NULL,
  `dfechavencimiento` date DEFAULT NULL,
  `ntotal` int(11) DEFAULT NULL,
  `vestadocotizacion` varchar(10) DEFAULT NULL,
  `ncodcliente` int(11) NOT NULL,
  `ncodvendedor` int(11) NOT NULL,
  PRIMARY KEY (`ncodpedido`),
  KEY `RefMaCLIENTE16` (`ncodcliente`),
  KEY `RefMaVENDEDOR17` (`ncodvendedor`)
) ENGINE=MyISAM AUTO_INCREMENT=9 DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `mapedido`
--

LOCK TABLES `mapedido` WRITE;
/*!40000 ALTER TABLE `mapedido` DISABLE KEYS */;
INSERT INTO `mapedido` VALUES (1,'','0000-00-00','0000-00-00',0,'Pendiente',1,1),(2,'','0000-00-00','0000-00-00',0,'Pendiente',1,1),(3,'B','0000-00-00','0000-00-00',0,'Pendiente',1,1),(4,'A','0000-00-00','0000-00-00',120,'Pendiente',1,1),(5,'A','0000-00-00','0000-00-00',0,'Pendiente',1,1),(6,'B','0000-00-00','0000-00-00',120,'Pendiente',1,1),(7,'B','2015-10-11','0000-00-00',120,'Pendiente',1,1),(8,'C','2015-12-11','2015-11-26',1068,'Pendiente',1,1);
/*!40000 ALTER TABLE `mapedido` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `maplaza`
--

DROP TABLE IF EXISTS `maplaza`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `maplaza` (
  `ncodplaza` int(11) NOT NULL AUTO_INCREMENT,
  `vdepartamento` varchar(30) DEFAULT NULL,
  `vcausasolicitud` varchar(10) DEFAULT NULL,
  `vtipoempleado` varchar(20) DEFAULT NULL,
  `vcapacidadesrequeridas` varchar(30) DEFAULT NULL,
  `vhorario` varchar(20) DEFAULT NULL,
  `vtipo` varchar(30) DEFAULT NULL,
  `vdescripcion` varchar(20) DEFAULT NULL,
  `dsueldomin` decimal(10,0) DEFAULT NULL,
  `dsueldomax` decimal(10,0) DEFAULT NULL,
  `ncodempresa` int(11) NOT NULL,
  PRIMARY KEY (`ncodplaza`),
  KEY `RefMaEMPRESA86` (`ncodempresa`)
) ENGINE=MyISAM DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `maplaza`
--

LOCK TABLES `maplaza` WRITE;
/*!40000 ALTER TABLE `maplaza` DISABLE KEYS */;
/*!40000 ALTER TABLE `maplaza` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `maproducto`
--

DROP TABLE IF EXISTS `maproducto`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `maproducto` (
  `ncodarticulo` int(11) NOT NULL AUTO_INCREMENT,
  `nexistencia` decimal(10,0) DEFAULT NULL,
  `nprecio` decimal(10,0) DEFAULT NULL,
  `vmarca` varchar(10) DEFAULT NULL,
  `vnombre` varchar(30) DEFAULT NULL,
  `vdescripcion` varchar(30) DEFAULT NULL,
  `ncodlineaarticulo` int(11) NOT NULL,
  `ncodtipoarticulo` int(11) NOT NULL,
  `ncodproveedor` int(11) NOT NULL,
  `ncodunidad` int(11) NOT NULL,
  PRIMARY KEY (`ncodarticulo`),
  KEY `RefMaLINEAARTICULO63` (`ncodlineaarticulo`),
  KEY `RefMaTIPOARTICULO65` (`ncodtipoarticulo`),
  KEY `RefMaPROVEEDOR73` (`ncodproveedor`),
  KEY `RefMaUNIDAD79` (`ncodunidad`)
) ENGINE=MyISAM AUTO_INCREMENT=3 DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `maproducto`
--

LOCK TABLES `maproducto` WRITE;
/*!40000 ALTER TABLE `maproducto` DISABLE KEYS */;
INSERT INTO `maproducto` VALUES (1,1200,12,'Prueba','Prueba','Esponjas',1,1,1,1),(2,3000,10,'Cama','Cama','Cama',1,1,1,1);
/*!40000 ALTER TABLE `maproducto` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `maproveedor`
--

DROP TABLE IF EXISTS `maproveedor`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `maproveedor` (
  `ncodproveedor` int(11) NOT NULL AUTO_INCREMENT,
  `vdescripcion` varchar(10) DEFAULT NULL,
  `vpais` varchar(20) DEFAULT NULL,
  `vtelefono` varchar(40) DEFAULT NULL,
  `vciudad` varchar(40) DEFAULT NULL,
  `vnombre` varchar(30) DEFAULT NULL,
  `vdireccion` varchar(30) DEFAULT NULL,
  PRIMARY KEY (`ncodproveedor`)
) ENGINE=MyISAM AUTO_INCREMENT=2 DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `maproveedor`
--

LOCK TABLES `maproveedor` WRITE;
/*!40000 ALTER TABLE `maproveedor` DISABLE KEYS */;
INSERT INTO `maproveedor` VALUES (1,'ProveedorP','Guatemala','22334455','Guatemala','Prueba','Guatemala');
/*!40000 ALTER TABLE `maproveedor` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `mapunto`
--

DROP TABLE IF EXISTS `mapunto`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `mapunto` (
  `ncodigopunto` int(11) NOT NULL AUTO_INCREMENT,
  `cx` char(10) DEFAULT NULL,
  `cy` char(10) DEFAULT NULL,
  `ncodgrafica` int(11) NOT NULL,
  PRIMARY KEY (`ncodigopunto`),
  KEY `RefTrGRAFICA1` (`ncodgrafica`)
) ENGINE=MyISAM AUTO_INCREMENT=34 DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `mapunto`
--

LOCK TABLES `mapunto` WRITE;
/*!40000 ALTER TABLE `mapunto` DISABLE KEYS */;
INSERT INTO `mapunto` VALUES (1,'Nov 4000','4000',1),(2,'Nov 4000','4000',2),(3,'11','4000',3),(4,'Nov','4000',4),(5,'Oct','3000',5),(6,'Nov','4000',5),(7,'10','3000',6),(8,'11','4000',6),(9,'Oct 3000','3000',7),(10,'Nov 4000','4000',7),(11,'Nov','4000',8),(12,'11','4000',9),(13,'Nov 4000','4000',10),(14,'11','4388',11),(15,'Nov','4388',12),(16,'Oct 3000','3000',13),(17,'Nov 4388','4388',13),(18,'10','3000',14),(19,'11','4388',14),(20,'Nov','4628',15),(21,'Nov 4628','4628',16),(22,'Nov 4628','4628',17),(23,'Nov','4628',18),(24,'11','4628',19),(25,'Oct 3000','3000',20),(26,'Nov 4628','4628',20),(27,'Oct','3000',21),(28,'Nov','4628',21),(29,'10','3000',22),(30,'11','4628',22),(31,'Nov','4628',23),(32,'Oct','3000',24),(33,'Nov','4628',24);
/*!40000 ALTER TABLE `mapunto` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `mareceta`
--

DROP TABLE IF EXISTS `mareceta`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `mareceta` (
  `ncodreceta` int(11) NOT NULL AUTO_INCREMENT,
  `nhorahombre` time DEFAULT NULL,
  `vnombrereceta` varchar(20) DEFAULT NULL,
  `ncodordenes` int(11) NOT NULL,
  PRIMARY KEY (`ncodreceta`),
  KEY `RefMaORDENPRODUCCION4` (`ncodordenes`)
) ENGINE=MyISAM DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `mareceta`
--

LOCK TABLES `mareceta` WRITE;
/*!40000 ALTER TABLE `mareceta` DISABLE KEYS */;
/*!40000 ALTER TABLE `mareceta` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `marecibopago`
--

DROP TABLE IF EXISTS `marecibopago`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `marecibopago` (
  `ncodrecibopago` int(11) NOT NULL AUTO_INCREMENT,
  `vnombre` varchar(10) DEFAULT NULL,
  `vfechapago` varchar(10) DEFAULT NULL,
  `ncantidadpago` decimal(10,0) DEFAULT NULL,
  `ncodproveedor` int(11) NOT NULL,
  PRIMARY KEY (`ncodrecibopago`),
  KEY `RefMaPROVEEDOR75` (`ncodproveedor`)
) ENGINE=MyISAM DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `marecibopago`
--

LOCK TABLES `marecibopago` WRITE;
/*!40000 ALTER TABLE `marecibopago` DISABLE KEYS */;
/*!40000 ALTER TABLE `marecibopago` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `marolusuario`
--

DROP TABLE IF EXISTS `marolusuario`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `marolusuario` (
  `ncodrole` int(11) NOT NULL AUTO_INCREMENT,
  `vnombrerole` varchar(50) DEFAULT NULL,
  PRIMARY KEY (`ncodrole`)
) ENGINE=MyISAM AUTO_INCREMENT=4 DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `marolusuario`
--

LOCK TABLES `marolusuario` WRITE;
/*!40000 ALTER TABLE `marolusuario` DISABLE KEYS */;
INSERT INTO `marolusuario` VALUES (2,'Administrador'),(1,'Superusuario'),(3,'vendedor');
/*!40000 ALTER TABLE `marolusuario` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `matipoarticulo`
--

DROP TABLE IF EXISTS `matipoarticulo`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `matipoarticulo` (
  `ncodtipoarticulo` int(11) NOT NULL AUTO_INCREMENT,
  `vnombre` varchar(10) DEFAULT NULL,
  `vdescripcion` varchar(10) DEFAULT NULL,
  PRIMARY KEY (`ncodtipoarticulo`)
) ENGINE=MyISAM AUTO_INCREMENT=4 DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `matipoarticulo`
--

LOCK TABLES `matipoarticulo` WRITE;
/*!40000 ALTER TABLE `matipoarticulo` DISABLE KEYS */;
INSERT INTO `matipoarticulo` VALUES (1,'Esponjas',' Esponjas'),(2,'Madera','Maderas'),(3,'Resortes','Resortes');
/*!40000 ALTER TABLE `matipoarticulo` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `matipodocumento`
--

DROP TABLE IF EXISTS `matipodocumento`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `matipodocumento` (
  `ncodtipodocumento` int(11) NOT NULL AUTO_INCREMENT,
  `vdescripciondocumento` varchar(30) DEFAULT NULL,
  `vtipodocumento` varchar(30) DEFAULT NULL,
  PRIMARY KEY (`ncodtipodocumento`)
) ENGINE=MyISAM DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `matipodocumento`
--

LOCK TABLES `matipodocumento` WRITE;
/*!40000 ALTER TABLE `matipodocumento` DISABLE KEYS */;
/*!40000 ALTER TABLE `matipodocumento` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `matipoerror`
--

DROP TABLE IF EXISTS `matipoerror`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `matipoerror` (
  `ncodtipo` int(11) NOT NULL AUTO_INCREMENT,
  `vnombre` varchar(30) DEFAULT NULL,
  PRIMARY KEY (`ncodtipo`)
) ENGINE=MyISAM DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `matipoerror`
--

LOCK TABLES `matipoerror` WRITE;
/*!40000 ALTER TABLE `matipoerror` DISABLE KEYS */;
/*!40000 ALTER TABLE `matipoerror` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `matipomovimiento`
--

DROP TABLE IF EXISTS `matipomovimiento`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `matipomovimiento` (
  `ncodmoviemiento` int(11) NOT NULL AUTO_INCREMENT,
  `vdescripcion` varchar(40) DEFAULT NULL,
  `vtipomovimiento` varchar(40) DEFAULT NULL,
  PRIMARY KEY (`ncodmoviemiento`)
) ENGINE=MyISAM DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `matipomovimiento`
--

LOCK TABLES `matipomovimiento` WRITE;
/*!40000 ALTER TABLE `matipomovimiento` DISABLE KEYS */;
/*!40000 ALTER TABLE `matipomovimiento` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `matipopago`
--

DROP TABLE IF EXISTS `matipopago`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `matipopago` (
  `ncodtipopago` int(11) NOT NULL AUTO_INCREMENT,
  `vdescripciontipopago` varchar(30) DEFAULT NULL,
  PRIMARY KEY (`ncodtipopago`)
) ENGINE=MyISAM AUTO_INCREMENT=5 DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `matipopago`
--

LOCK TABLES `matipopago` WRITE;
/*!40000 ALTER TABLE `matipopago` DISABLE KEYS */;
INSERT INTO `matipopago` VALUES (1,'Efectivo'),(2,'Cheque'),(3,'Tarjeta'),(4,'Credito');
/*!40000 ALTER TABLE `matipopago` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `matipotransaccion`
--

DROP TABLE IF EXISTS `matipotransaccion`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `matipotransaccion` (
  `ncodtipotransaccion` int(11) NOT NULL AUTO_INCREMENT,
  `vbincdec` varchar(20) DEFAULT NULL,
  `vnombredocumento` varchar(20) DEFAULT NULL,
  PRIMARY KEY (`ncodtipotransaccion`)
) ENGINE=MyISAM DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `matipotransaccion`
--

LOCK TABLES `matipotransaccion` WRITE;
/*!40000 ALTER TABLE `matipotransaccion` DISABLE KEYS */;
/*!40000 ALTER TABLE `matipotransaccion` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `maunidad`
--

DROP TABLE IF EXISTS `maunidad`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `maunidad` (
  `ncodunidad` int(11) NOT NULL AUTO_INCREMENT,
  `vnombreunidad` varchar(20) DEFAULT NULL,
  PRIMARY KEY (`ncodunidad`)
) ENGINE=MyISAM AUTO_INCREMENT=2 DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `maunidad`
--

LOCK TABLES `maunidad` WRITE;
/*!40000 ALTER TABLE `maunidad` DISABLE KEYS */;
INSERT INTO `maunidad` VALUES (1,'Prueba');
/*!40000 ALTER TABLE `maunidad` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `mausoarticulo`
--

DROP TABLE IF EXISTS `mausoarticulo`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `mausoarticulo` (
  `ncodarticulo` int(11) NOT NULL,
  `vnombreuso` char(10) DEFAULT NULL,
  KEY `RefMaPRODUCTO36` (`ncodarticulo`)
) ENGINE=MyISAM DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `mausoarticulo`
--

LOCK TABLES `mausoarticulo` WRITE;
/*!40000 ALTER TABLE `mausoarticulo` DISABLE KEYS */;
/*!40000 ALTER TABLE `mausoarticulo` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `mausuario`
--

DROP TABLE IF EXISTS `mausuario`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `mausuario` (
  `ncodusuario` int(11) NOT NULL AUTO_INCREMENT,
  `vnombreusuario` varchar(30) DEFAULT NULL,
  `vapellidousuario` varchar(30) DEFAULT NULL,
  `vemailusuario` varchar(45) DEFAULT NULL,
  `vusuario` varchar(25) NOT NULL,
  `vpassword` varchar(200) NOT NULL,
  `ncodgrafica` int(11) NOT NULL,
  PRIMARY KEY (`ncodusuario`),
  KEY `RefTrGRAFICA70` (`ncodgrafica`)
) ENGINE=MyISAM AUTO_INCREMENT=5 DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `mausuario`
--

LOCK TABLES `mausuario` WRITE;
/*!40000 ALTER TABLE `mausuario` DISABLE KEYS */;
INSERT INTO `mausuario` VALUES (1,'root','root','root@root.com','Superusuario','dc76e9f0c0006e8f919e0c515c66dbba3982f785',0),(2,'Administrador','Admin','----','Administrador','4e7afebcfbae000b22c7c85e5560f89a2a0280b4',0),(3,'joseandres','chajon','jchajon@gmail.com','jchajon','e10c25a0088bc7415ad695ed6312829b1711ce1f',0),(4,'Pamela','Selman','pselman@gmail.com','pselman','7110eda4d09e062aa5e4a390b0a572ac0d2c0220',0);
/*!40000 ALTER TABLE `mausuario` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `mavendedor`
--

DROP TABLE IF EXISTS `mavendedor`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `mavendedor` (
  `ncodvendedor` int(11) NOT NULL AUTO_INCREMENT,
  `nnit` varchar(10) DEFAULT NULL,
  `vnombrevendedor` varchar(50) DEFAULT NULL,
  `vapellidovendedor` varchar(50) DEFAULT NULL,
  `vdireccion` varchar(100) DEFAULT NULL,
  `ntelefono` decimal(10,0) DEFAULT NULL,
  `vcorreo` varchar(30) DEFAULT NULL,
  `vestado` varchar(20) DEFAULT NULL,
  PRIMARY KEY (`ncodvendedor`)
) ENGINE=MyISAM AUTO_INCREMENT=5 DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `mavendedor`
--

LOCK TABLES `mavendedor` WRITE;
/*!40000 ALTER TABLE `mavendedor` DISABLE KEYS */;
INSERT INTO `mavendedor` VALUES (1,'23423452','Jose Andrés ','Chajon Cueto','Guatemala',235232524,'jchajon@hotmail.com','ACTIVO'),(2,'1224213214','Sabrina','Gomez','Guatemala',121212,'sabrina@gmail.com','INACTIVO'),(3,'234234','Pamela ','Selman','Guatemala',124234,'pselman@gmail.com','ACTIVO'),(4,'235423','Gerardo','Santizo','Guatemala',444444,'Gerardo@yahoo.es','ACTIVO');
/*!40000 ALTER TABLE `mavendedor` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `maventas`
--

DROP TABLE IF EXISTS `maventas`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `maventas` (
  `ncodventas` int(11) NOT NULL AUTO_INCREMENT,
  `dfechaventa` date DEFAULT NULL,
  `dprecioventa` decimal(10,0) DEFAULT NULL,
  PRIMARY KEY (`ncodventas`)
) ENGINE=MyISAM AUTO_INCREMENT=9 DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `maventas`
--

LOCK TABLES `maventas` WRITE;
/*!40000 ALTER TABLE `maventas` DISABLE KEYS */;
INSERT INTO `maventas` VALUES (1,'2015-11-11',2000),(2,'2015-10-11',3000),(3,'2015-11-11',2000),(4,'2015-11-11',288),(5,'2015-11-11',100),(6,'0000-00-00',240),(7,'2015-11-11',240),(8,'2015-12-11',2000);
/*!40000 ALTER TABLE `maventas` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `tractividadludica`
--

DROP TABLE IF EXISTS `tractividadludica`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `tractividadludica` (
  `ncodactividad` int(11) NOT NULL AUTO_INCREMENT,
  `vtipo` varchar(10) DEFAULT NULL,
  `vnombre` varchar(30) DEFAULT NULL,
  `vdescripcion` varchar(30) DEFAULT NULL,
  `ncodempleado` int(11) NOT NULL,
  PRIMARY KEY (`ncodactividad`),
  KEY `RefMaEMPLEADO53` (`ncodempleado`)
) ENGINE=MyISAM DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `tractividadludica`
--

LOCK TABLES `tractividadludica` WRITE;
/*!40000 ALTER TABLE `tractividadludica` DISABLE KEYS */;
/*!40000 ALTER TABLE `tractividadludica` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `trcobro`
--

DROP TABLE IF EXISTS `trcobro`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `trcobro` (
  `ncodcobro` int(11) NOT NULL AUTO_INCREMENT,
  `dpago` decimal(10,0) DEFAULT NULL,
  `dsaldo` decimal(10,0) DEFAULT NULL,
  `dfecha` date DEFAULT NULL,
  `ncodmora` int(11) NOT NULL,
  `ncodfactura` int(11) NOT NULL,
  `ncoddocumento` int(11) NOT NULL,
  PRIMARY KEY (`ncodcobro`),
  KEY `RefMaMORA39` (`ncodmora`),
  KEY `RefMaFACTURA41` (`ncodfactura`),
  KEY `RefTrDOCUMENTOS71` (`ncoddocumento`)
) ENGINE=MyISAM DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `trcobro`
--

LOCK TABLES `trcobro` WRITE;
/*!40000 ALTER TABLE `trcobro` DISABLE KEYS */;
/*!40000 ALTER TABLE `trcobro` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `trcompra`
--

DROP TABLE IF EXISTS `trcompra`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `trcompra` (
  `ncodarticulo` int(11) NOT NULL,
  `ncodproveedor` int(11) NOT NULL,
  `ncantidadProducto` char(10) DEFAULT NULL,
  `ntotalapagar` char(10) DEFAULT NULL,
  `ntotalpagado` char(10) DEFAULT NULL,
  `nsaldoapagar` char(10) DEFAULT NULL,
  `ncodorden` int(11) NOT NULL,
  KEY `RefTrORDENPRODUCTO81` (`ncodorden`),
  KEY `RefMaPRODUCTO11` (`ncodarticulo`),
  KEY `RefMaPROVEEDOR12` (`ncodproveedor`)
) ENGINE=MyISAM DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `trcompra`
--

LOCK TABLES `trcompra` WRITE;
/*!40000 ALTER TABLE `trcompra` DISABLE KEYS */;
/*!40000 ALTER TABLE `trcompra` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `trcontrato`
--

DROP TABLE IF EXISTS `trcontrato`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `trcontrato` (
  `ncodcontrato` int(11) NOT NULL AUTO_INCREMENT,
  `vhorariotrabajo` varchar(30) DEFAULT NULL,
  `vdetalle` varchar(20) DEFAULT NULL,
  `vpuestoreporta` varchar(20) DEFAULT NULL,
  `vzonaresidencia` varchar(30) DEFAULT NULL,
  `Vtipocontrato` varchar(30) DEFAULT NULL,
  `dfechainicio` date DEFAULT NULL,
  `dfechafin` date DEFAULT NULL,
  `dsalario` decimal(10,0) DEFAULT NULL,
  `ncodempleado` int(11) NOT NULL,
  `ncodempresa` int(11) NOT NULL,
  `ncodsolicitud` int(11) NOT NULL,
  PRIMARY KEY (`ncodcontrato`),
  KEY `RefMaEMPLEADO84` (`ncodempleado`),
  KEY `RefMaEMPRESA85` (`ncodempresa`),
  KEY `RefTrSOLICITUD90` (`ncodsolicitud`)
) ENGINE=MyISAM DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `trcontrato`
--

LOCK TABLES `trcontrato` WRITE;
/*!40000 ALTER TABLE `trcontrato` DISABLE KEYS */;
/*!40000 ALTER TABLE `trcontrato` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `trdepartamento`
--

DROP TABLE IF EXISTS `trdepartamento`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `trdepartamento` (
  `ncoddepartamento` int(11) NOT NULL AUTO_INCREMENT,
  `vnombredepartamento` varchar(30) DEFAULT NULL,
  `vtipo` varchar(30) DEFAULT NULL,
  PRIMARY KEY (`ncoddepartamento`)
) ENGINE=MyISAM DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `trdepartamento`
--

LOCK TABLES `trdepartamento` WRITE;
/*!40000 ALTER TABLE `trdepartamento` DISABLE KEYS */;
/*!40000 ALTER TABLE `trdepartamento` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `trdesempenio`
--

DROP TABLE IF EXISTS `trdesempenio`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `trdesempenio` (
  `vcargo` varchar(10) NOT NULL,
  `vcalidadtrabajo` varchar(10) DEFAULT NULL,
  `vcantidadtrabajo` varchar(10) DEFAULT NULL,
  `ncodempleado` int(11) NOT NULL,
  PRIMARY KEY (`vcargo`),
  KEY `RefMaEMPLEADO106` (`ncodempleado`)
) ENGINE=MyISAM DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `trdesempenio`
--

LOCK TABLES `trdesempenio` WRITE;
/*!40000 ALTER TABLE `trdesempenio` DISABLE KEYS */;
/*!40000 ALTER TABLE `trdesempenio` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `trdetalleconciliacion`
--

DROP TABLE IF EXISTS `trdetalleconciliacion`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `trdetalleconciliacion` (
  `ncodDetalleConci` int(11) NOT NULL AUTO_INCREMENT,
  `ncodconcilicacion` int(11) DEFAULT NULL,
  `ncoddocumento` int(11) DEFAULT NULL,
  PRIMARY KEY (`ncodDetalleConci`),
  KEY `RefMaENCABEZADOCONCILIACION107` (`ncodconcilicacion`),
  KEY `RefTrDOCUMENTOS108` (`ncoddocumento`)
) ENGINE=MyISAM DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `trdetalleconciliacion`
--

LOCK TABLES `trdetalleconciliacion` WRITE;
/*!40000 ALTER TABLE `trdetalleconciliacion` DISABLE KEYS */;
/*!40000 ALTER TABLE `trdetalleconciliacion` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `trdetallereceta`
--

DROP TABLE IF EXISTS `trdetallereceta`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `trdetallereceta` (
  `ncantidad` int(11) NOT NULL AUTO_INCREMENT,
  `ncodreceta` int(11) NOT NULL,
  `ncodmaterial` int(11) NOT NULL,
  PRIMARY KEY (`ncantidad`),
  KEY `RefMaRECETA3` (`ncodreceta`),
  KEY `RefMaMATERIAL5` (`ncodmaterial`)
) ENGINE=MyISAM DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `trdetallereceta`
--

LOCK TABLES `trdetallereceta` WRITE;
/*!40000 ALTER TABLE `trdetallereceta` DISABLE KEYS */;
/*!40000 ALTER TABLE `trdetallereceta` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `trdocumentos`
--

DROP TABLE IF EXISTS `trdocumentos`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `trdocumentos` (
  `ncoddocumento` int(11) NOT NULL AUTO_INCREMENT,
  `dfecha` date DEFAULT NULL,
  `dmonto` decimal(10,0) DEFAULT NULL,
  `ncodtipotransaccion` int(11) NOT NULL,
  `ncodcuenta` int(11) NOT NULL,
  `ncodproveedor` int(11) NOT NULL,
  `ndocumento` int(11) NOT NULL,
  PRIMARY KEY (`ncoddocumento`),
  KEY `RefMaPROVEEDOR33` (`ncodproveedor`),
  KEY `RefMaDOCPORPAGAR37` (`ndocumento`),
  KEY `RefMaTIPOTRANSACCION38` (`ncodtipotransaccion`),
  KEY `RefMaCUENTA94` (`ncodcuenta`)
) ENGINE=MyISAM DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `trdocumentos`
--

LOCK TABLES `trdocumentos` WRITE;
/*!40000 ALTER TABLE `trdocumentos` DISABLE KEYS */;
/*!40000 ALTER TABLE `trdocumentos` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `trescolaridad`
--

DROP TABLE IF EXISTS `trescolaridad`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `trescolaridad` (
  `ncodescolaridad` int(11) NOT NULL AUTO_INCREMENT,
  `vtipo` varchar(30) DEFAULT NULL,
  `vdescripcion` varchar(30) DEFAULT NULL,
  PRIMARY KEY (`ncodescolaridad`)
) ENGINE=MyISAM DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `trescolaridad`
--

LOCK TABLES `trescolaridad` WRITE;
/*!40000 ALTER TABLE `trescolaridad` DISABLE KEYS */;
/*!40000 ALTER TABLE `trescolaridad` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `trexistencia`
--

DROP TABLE IF EXISTS `trexistencia`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `trexistencia` (
  `nexistencia` int(11) NOT NULL AUTO_INCREMENT,
  `ncodbodega` int(11) NOT NULL,
  `ncodarticulo` int(11) NOT NULL,
  PRIMARY KEY (`nexistencia`),
  KEY `RefMaBODEGA47` (`ncodbodega`),
  KEY `RefMaPRODUCTO67` (`ncodarticulo`)
) ENGINE=MyISAM DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `trexistencia`
--

LOCK TABLES `trexistencia` WRITE;
/*!40000 ALTER TABLE `trexistencia` DISABLE KEYS */;
/*!40000 ALTER TABLE `trexistencia` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `trfamilia`
--

DROP TABLE IF EXISTS `trfamilia`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `trfamilia` (
  `ncodfamilia` int(11) NOT NULL AUTO_INCREMENT,
  `vtipo` varchar(10) DEFAULT NULL,
  `vdescripcion` varchar(20) DEFAULT NULL,
  PRIMARY KEY (`ncodfamilia`)
) ENGINE=MyISAM DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `trfamilia`
--

LOCK TABLES `trfamilia` WRITE;
/*!40000 ALTER TABLE `trfamilia` DISABLE KEYS */;
/*!40000 ALTER TABLE `trfamilia` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `trgrafica`
--

DROP TABLE IF EXISTS `trgrafica`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `trgrafica` (
  `ncodgrafica` int(11) NOT NULL AUTO_INCREMENT,
  `dfecha` date DEFAULT NULL,
  `ctipo` char(20) DEFAULT NULL,
  `ctitulografica` char(100) NOT NULL,
  `cejex` char(100) NOT NULL,
  `cejey` char(100) NOT NULL,
  `vnomreporte` varchar(30) NOT NULL,
  `ncodusuario` int(11) DEFAULT NULL,
  PRIMARY KEY (`ncodgrafica`),
  KEY `RefTrREPORTE2` (`vnomreporte`)
) ENGINE=MyISAM AUTO_INCREMENT=25 DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `trgrafica`
--

LOCK TABLES `trgrafica` WRITE;
/*!40000 ALTER TABLE `trgrafica` DISABLE KEYS */;
INSERT INTO `trgrafica` VALUES (1,'2015-11-11','pie','AS','AAS','AS','',0),(2,'2015-11-11','pie','a','b','c','',0),(3,'2015-11-11','lineal','a','b','c','',0),(4,'2015-11-11','barras','a','b','c','',0),(5,'2015-11-11','barras','a','b','c','',0),(6,'2015-11-11','lineal','a','b','c','',0),(7,'2015-11-11','pie','a','b','c','',0),(8,'2015-11-11','barras','Ventas','Fecha','Valores','',0),(9,'2015-11-11','lineal','Ventas','Fecha','Valores','',0),(10,'2015-11-11','pie','Ventas','Fecha','Valores','',0),(11,'2015-11-11','lineal','Ventas','fecha','valores','',0),(12,'2015-11-11','barras','Ventas','fecha','valores','',0),(13,'2015-11-11','pie','Ventas','fecha','valores','',0),(14,'2015-11-11','lineal','Ventas','fecha','valores','',0),(15,'2015-11-11','barras','Ventas','Fecha','Valores','',0),(16,'2015-11-11','pie','Ventas','Fecha','Valores','',0),(17,'2015-11-11','pie','Pronóstico de Ventas','Fechas','Valores','',0),(18,'2015-11-11','barras','Pronóstico de Ventas','Fechas','Valores','',0),(19,'2015-11-11','lineal','Pronóstico de Ventas','Fechas','Valores','',0),(20,'2015-11-12','pie','h','f','fg','',0),(21,'2015-11-12','barras','h','f','fg','',0),(22,'2015-11-12','lineal','h','f','fg','',0),(23,'2015-11-12','barras','Pronóstico','Fecha','Montos','',0),(24,'2015-11-12','barras','Pronóstico','Fecha','Montos','',0);
/*!40000 ALTER TABLE `trgrafica` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `trhistoriaemp`
--

DROP TABLE IF EXISTS `trhistoriaemp`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `trhistoriaemp` (
  `ncodhistoria` int(11) NOT NULL AUTO_INCREMENT,
  `vdescripcion` varchar(10) DEFAULT NULL,
  `dfechainicio` date DEFAULT NULL,
  `dfechafin` date DEFAULT NULL,
  `vdepartamento` varchar(10) DEFAULT NULL,
  PRIMARY KEY (`ncodhistoria`)
) ENGINE=MyISAM DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `trhistoriaemp`
--

LOCK TABLES `trhistoriaemp` WRITE;
/*!40000 ALTER TABLE `trhistoriaemp` DISABLE KEYS */;
/*!40000 ALTER TABLE `trhistoriaemp` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `trmovimiento`
--

DROP TABLE IF EXISTS `trmovimiento`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `trmovimiento` (
  `ncodmovimiento` int(11) NOT NULL AUTO_INCREMENT,
  `vjustificacion` varchar(30) DEFAULT NULL,
  `vencargado` varchar(30) DEFAULT NULL,
  `dfechamovimiento` date DEFAULT NULL,
  `vhoramovimiento` varchar(10) DEFAULT NULL,
  `vreferenciafisica` varchar(10) DEFAULT NULL,
  `ncodmoviemiento` int(11) NOT NULL,
  `ncodarticulo` int(11) NOT NULL,
  PRIMARY KEY (`ncodmovimiento`),
  KEY `RefMaTIPOMOVIMIENTO49` (`ncodmoviemiento`),
  KEY `RefMaPRODUCTO78` (`ncodarticulo`)
) ENGINE=MyISAM DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `trmovimiento`
--

LOCK TABLES `trmovimiento` WRITE;
/*!40000 ALTER TABLE `trmovimiento` DISABLE KEYS */;
/*!40000 ALTER TABLE `trmovimiento` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `trordenproducto`
--

DROP TABLE IF EXISTS `trordenproducto`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `trordenproducto` (
  `ncodorden` int(11) NOT NULL AUTO_INCREMENT,
  `ncantidad` decimal(10,0) DEFAULT NULL,
  `vdescripcion` decimal(10,0) DEFAULT NULL,
  `vstatus` varchar(20) DEFAULT NULL,
  `ncodarticulo` int(11) NOT NULL,
  PRIMARY KEY (`ncodorden`),
  KEY `RefMaPRODUCTO28` (`ncodarticulo`)
) ENGINE=MyISAM DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `trordenproducto`
--

LOCK TABLES `trordenproducto` WRITE;
/*!40000 ALTER TABLE `trordenproducto` DISABLE KEYS */;
/*!40000 ALTER TABLE `trordenproducto` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `trpagoproveedor`
--

DROP TABLE IF EXISTS `trpagoproveedor`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `trpagoproveedor` (
  `ncodpagoproveedor` int(11) NOT NULL AUTO_INCREMENT,
  `ncodproveedor` int(11) NOT NULL,
  `ncoddocumento` int(11) NOT NULL,
  PRIMARY KEY (`ncodpagoproveedor`),
  KEY `RefMaPROVEEDOR95` (`ncodproveedor`),
  KEY `RefTrDOCUMENTOS98` (`ncoddocumento`)
) ENGINE=MyISAM DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `trpagoproveedor`
--

LOCK TABLES `trpagoproveedor` WRITE;
/*!40000 ALTER TABLE `trpagoproveedor` DISABLE KEYS */;
/*!40000 ALTER TABLE `trpagoproveedor` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `trpagos`
--

DROP TABLE IF EXISTS `trpagos`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `trpagos` (
  `ncodpago` int(11) NOT NULL AUTO_INCREMENT,
  `vcantidadpago` varchar(10) DEFAULT NULL,
  `dfechapago` date DEFAULT NULL,
  `vdescripcion` varchar(30) DEFAULT NULL,
  `ncodcuenta` int(11) NOT NULL,
  `ncodrecibopago` int(11) NOT NULL,
  `ncodtipopago` int(11) DEFAULT NULL,
  `ncoddocumento` int(11) NOT NULL,
  PRIMARY KEY (`ncodpago`),
  KEY `RefMaCUENTA80` (`ncodcuenta`),
  KEY `RefMaRECIBOPAGO93` (`ncodrecibopago`),
  KEY `RefMaTIPOPAGO9` (`ncodtipopago`),
  KEY `RefTrDOCUMENTOS10` (`ncoddocumento`)
) ENGINE=MyISAM DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `trpagos`
--

LOCK TABLES `trpagos` WRITE;
/*!40000 ALTER TABLE `trpagos` DISABLE KEYS */;
/*!40000 ALTER TABLE `trpagos` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `trpagosalario`
--

DROP TABLE IF EXISTS `trpagosalario`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `trpagosalario` (
  `ncodpagosalario` int(11) NOT NULL AUTO_INCREMENT,
  `ncodcontrato` int(11) NOT NULL,
  `ncoddocumento` int(11) NOT NULL,
  PRIMARY KEY (`ncodpagosalario`),
  KEY `RefTrCONTRATO60` (`ncodcontrato`),
  KEY `RefTrDOCUMENTOS91` (`ncoddocumento`)
) ENGINE=MyISAM DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `trpagosalario`
--

LOCK TABLES `trpagosalario` WRITE;
/*!40000 ALTER TABLE `trpagosalario` DISABLE KEYS */;
/*!40000 ALTER TABLE `trpagosalario` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `trpedido`
--

DROP TABLE IF EXISTS `trpedido`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `trpedido` (
  `ncodpedido` int(11) NOT NULL AUTO_INCREMENT,
  `vserie` varchar(10) DEFAULT NULL,
  `vnombrepedido` varchar(10) DEFAULT NULL,
  `vnit` varchar(10) DEFAULT NULL,
  `vdireccion` varchar(25) DEFAULT NULL,
  `dfechapedido` date DEFAULT NULL,
  `dfechavencimiento` date DEFAULT NULL,
  `ntotal` decimal(10,0) DEFAULT NULL,
  `vestadopedido` varchar(10) DEFAULT NULL,
  `vnombrevendedor` varchar(20) DEFAULT NULL,
  `vdescripcion` varchar(18) DEFAULT NULL,
  `dfechaentrega` date DEFAULT NULL,
  `ncodventas` int(11) NOT NULL,
  `ncodarticulo` int(11) NOT NULL,
  `ncodcliente` int(11) NOT NULL,
  `ncodvendedor` int(11) NOT NULL,
  PRIMARY KEY (`ncodpedido`),
  KEY `RefMaVENTAS34` (`ncodventas`),
  KEY `RefMaPRODUCTO82` (`ncodarticulo`),
  KEY `RefMaCLIENTE100` (`ncodcliente`),
  KEY `RefMaVENDEDOR6` (`ncodvendedor`)
) ENGINE=MyISAM DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `trpedido`
--

LOCK TABLES `trpedido` WRITE;
/*!40000 ALTER TABLE `trpedido` DISABLE KEYS */;
/*!40000 ALTER TABLE `trpedido` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `trplanilla`
--

DROP TABLE IF EXISTS `trplanilla`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `trplanilla` (
  `cprestaciones` char(10) DEFAULT NULL,
  `vdetalle` varchar(20) DEFAULT NULL,
  `vhorasnormales` varchar(10) DEFAULT NULL,
  `vhorasextra` varchar(10) DEFAULT NULL,
  `nsemanas` decimal(10,0) DEFAULT NULL,
  `ncodempleado` int(11) NOT NULL,
  `ncodempresa` int(11) NOT NULL,
  KEY `RefMaEMPLEADO25` (`ncodempleado`),
  KEY `RefMaEMPRESA27` (`ncodempresa`)
) ENGINE=MyISAM DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `trplanilla`
--

LOCK TABLES `trplanilla` WRITE;
/*!40000 ALTER TABLE `trplanilla` DISABLE KEYS */;
/*!40000 ALTER TABLE `trplanilla` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `trprocesoorden`
--

DROP TABLE IF EXISTS `trprocesoorden`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `trprocesoorden` (
  `ncodprocesoorden` int(11) NOT NULL AUTO_INCREMENT,
  `vnombreproceso` varchar(10) DEFAULT NULL,
  PRIMARY KEY (`ncodprocesoorden`)
) ENGINE=MyISAM DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `trprocesoorden`
--

LOCK TABLES `trprocesoorden` WRITE;
/*!40000 ALTER TABLE `trprocesoorden` DISABLE KEYS */;
/*!40000 ALTER TABLE `trprocesoorden` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `trreporte`
--

DROP TABLE IF EXISTS `trreporte`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `trreporte` (
  `vnomreporte` varchar(30) NOT NULL,
  `dfechareporte` date DEFAULT NULL,
  `ncodaplicacion` char(10) DEFAULT NULL,
  `ncodmodulo` int(100) NOT NULL,
  `ncodusuario` int(11) NOT NULL,
  PRIMARY KEY (`vnomreporte`),
  KEY `RefMaUSUARIO72` (`ncodusuario`)
) ENGINE=MyISAM DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `trreporte`
--

LOCK TABLES `trreporte` WRITE;
/*!40000 ALTER TABLE `trreporte` DISABLE KEYS */;
INSERT INTO `trreporte` VALUES ('macliente','0000-00-00','1',0,1),('mavendedor','0000-00-00','1',0,1),('maventas','0000-00-00','1',0,1),('mapedido','0000-00-00','1',0,1),('macotizacion','0000-00-00','1',0,1),('mafactura','0000-00-00','1',0,1);
/*!40000 ALTER TABLE `trreporte` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `trroletoaplicacion`
--

DROP TABLE IF EXISTS `trroletoaplicacion`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `trroletoaplicacion` (
  `ncodrole` int(11) NOT NULL,
  `ncodaplicacion` int(11) NOT NULL,
  `btnimprimir` bit(1) DEFAULT NULL,
  `btnnuevo` bit(1) DEFAULT NULL,
  `btnirUltimo` bit(1) DEFAULT NULL,
  `btnirPrimero` bit(1) DEFAULT NULL,
  `btnanterior` bit(1) DEFAULT NULL,
  `btnsiguiente` bit(1) DEFAULT NULL,
  `btneditar` bit(1) DEFAULT NULL,
  `btncancelar` bit(1) DEFAULT NULL,
  `btnrefrescar` bit(1) DEFAULT NULL,
  `btnbuscar` bit(1) DEFAULT NULL,
  `btneliminar` bit(1) DEFAULT NULL,
  `btnguardar` bit(1) DEFAULT NULL,
  KEY `RefMaROLUSUARIO50` (`ncodrole`),
  KEY `RefMaAPLICACION52` (`ncodaplicacion`)
) ENGINE=MyISAM DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `trroletoaplicacion`
--

LOCK TABLES `trroletoaplicacion` WRITE;
/*!40000 ALTER TABLE `trroletoaplicacion` DISABLE KEYS */;
INSERT INTO `trroletoaplicacion` VALUES (3,14,'\0','','\0','\0','\0','\0','','\0','\0','\0','','\0'),(3,11,'\0','\0','\0','\0','\0','\0','\0','\0','\0','\0','\0','\0'),(1,14,'\0','\0','\0','\0','\0','\0','\0','\0','\0','\0','\0','\0'),(1,1,'\0','\0','\0','\0','\0','\0','\0','\0','\0','\0','\0','\0'),(3,15,'','','','','','','','','','','',''),(3,16,'','','','','','','','','','','',''),(1,16,'','','','','','','','','','','',''),(1,15,'','','','','','','','','','','',''),(1,18,'','','','','','','','','','','',''),(1,19,'','','','','','','','','','','',''),(1,20,'','','','','','','','','','','',''),(1,22,'\0','\0','\0','\0','\0','\0','\0','\0','\0','\0','\0','\0'),(1,23,'\0','\0','\0','\0','\0','\0','\0','\0','\0','\0','\0','\0');
/*!40000 ALTER TABLE `trroletoaplicacion` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `trsolicitud`
--

DROP TABLE IF EXISTS `trsolicitud`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `trsolicitud` (
  `ncodsolicitud` int(11) NOT NULL AUTO_INCREMENT,
  `vcaracteristicaspsicofisicas` varchar(100) DEFAULT NULL,
  `vdetalleestudios` varchar(30) DEFAULT NULL,
  `vpretencionsalarial` varchar(20) DEFAULT NULL,
  `dfecha` date DEFAULT NULL,
  `vnacionalidad` varchar(30) DEFAULT NULL,
  `vnopasaporte` varchar(10) DEFAULT NULL,
  `vhabitospersonales` varchar(30) DEFAULT NULL,
  `vpuestosolicitado` varchar(20) DEFAULT NULL,
  `vsueldosolicitado` varchar(30) DEFAULT NULL,
  `dfechanacimiento` date DEFAULT NULL,
  `ncodescolaridad` int(11) NOT NULL,
  `ncodfamilia` int(11) NOT NULL,
  PRIMARY KEY (`ncodsolicitud`),
  KEY `RefTrESCOLARIDAD57` (`ncodescolaridad`),
  KEY `RefTrFAMILIA96` (`ncodfamilia`)
) ENGINE=MyISAM DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `trsolicitud`
--

LOCK TABLES `trsolicitud` WRITE;
/*!40000 ALTER TABLE `trsolicitud` DISABLE KEYS */;
/*!40000 ALTER TABLE `trsolicitud` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `trstatusorden`
--

DROP TABLE IF EXISTS `trstatusorden`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `trstatusorden` (
  `ncodstatusorden` int(11) NOT NULL AUTO_INCREMENT,
  `vestatus` varchar(30) DEFAULT NULL,
  PRIMARY KEY (`ncodstatusorden`)
) ENGINE=MyISAM DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `trstatusorden`
--

LOCK TABLES `trstatusorden` WRITE;
/*!40000 ALTER TABLE `trstatusorden` DISABLE KEYS */;
/*!40000 ALTER TABLE `trstatusorden` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `trunidad`
--

DROP TABLE IF EXISTS `trunidad`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `trunidad` (
  `nconversion` double(18,0) DEFAULT NULL,
  `vnombreconversion` varchar(20) DEFAULT NULL,
  `ncodunidad` int(11) NOT NULL,
  KEY `RefMaUNIDAD76` (`ncodunidad`)
) ENGINE=MyISAM DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `trunidad`
--

LOCK TABLES `trunidad` WRITE;
/*!40000 ALTER TABLE `trunidad` DISABLE KEYS */;
/*!40000 ALTER TABLE `trunidad` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `trusuariotoaplicacion`
--

DROP TABLE IF EXISTS `trusuariotoaplicacion`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `trusuariotoaplicacion` (
  `ncodusuario` int(11) NOT NULL,
  `ncodaplicacion` int(11) NOT NULL,
  `btnimprimir` bit(1) NOT NULL,
  `btnnuevo` bit(1) DEFAULT NULL,
  `btnirUltimo` bit(1) DEFAULT NULL,
  `btnirPrimero` bit(1) DEFAULT NULL,
  `btnanterior` bit(1) DEFAULT NULL,
  `btnsiguiente` bit(1) DEFAULT NULL,
  `btneditar` bit(1) DEFAULT NULL,
  `btncancelar` bit(1) DEFAULT NULL,
  `btnrefrescar` bit(1) DEFAULT NULL,
  `btnbuscar` bit(1) DEFAULT NULL,
  `btneliminar` bit(1) DEFAULT NULL,
  `btnguardar` bit(1) DEFAULT NULL,
  KEY `RefMaAPLICACION44` (`ncodaplicacion`),
  KEY `RefMaUSUARIO69` (`ncodusuario`)
) ENGINE=MyISAM DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `trusuariotoaplicacion`
--

LOCK TABLES `trusuariotoaplicacion` WRITE;
/*!40000 ALTER TABLE `trusuariotoaplicacion` DISABLE KEYS */;
INSERT INTO `trusuariotoaplicacion` VALUES (2,5,'\0','\0','\0','\0','\0','\0','\0','\0','\0','\0','\0','\0'),(3,14,'','\0','','','\0','\0','\0','\0','\0','','\0','\0'),(3,11,'\0','\0','\0','\0','\0','\0','\0','\0','\0','\0','\0','\0'),(2,1,'\0','\0','\0','\0','\0','\0','\0','\0','\0','\0','\0','\0'),(4,22,'\0','\0','\0','\0','\0','\0','\0','\0','\0','\0','\0','\0'),(4,20,'','','','','','','','','','','',''),(4,19,'','','','','','','','','','','',''),(4,18,'','','','','','','','','','','',''),(4,23,'\0','\0','\0','\0','\0','\0','\0','\0','\0','\0','\0','\0'),(4,16,'','','','','','','','','','','',''),(4,15,'','','','','','','','','','','',''),(4,11,'','','','','','','','','','','',''),(4,12,'','','','','','','','','','','',''),(4,8,'','','','','','','','','','','',''),(4,7,'','','','','','','','','','','',''),(4,6,'','','','','','','','','','','',''),(4,5,'','','','','','','','','','','',''),(4,9,'','','','','','','','','','','',''),(4,3,'','','','','','','','','','','',''),(4,2,'','','','','','','','','','','',''),(4,1,'','','','','','','','','','','','');
/*!40000 ALTER TABLE `trusuariotoaplicacion` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `trusuariotorole`
--

DROP TABLE IF EXISTS `trusuariotorole`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `trusuariotorole` (
  `ncodusuario` int(11) NOT NULL,
  `ncodrole` int(11) NOT NULL,
  KEY `RefMaUSUARIO46` (`ncodusuario`),
  KEY `RefMaROLUSUARIO48` (`ncodrole`)
) ENGINE=MyISAM DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `trusuariotorole`
--

LOCK TABLES `trusuariotorole` WRITE;
/*!40000 ALTER TABLE `trusuariotorole` DISABLE KEYS */;
INSERT INTO `trusuariotorole` VALUES (3,3),(1,1),(2,2),(4,1);
/*!40000 ALTER TABLE `trusuariotorole` ENABLE KEYS */;
UNLOCK TABLES;
/*!40103 SET TIME_ZONE=@OLD_TIME_ZONE */;

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;

-- Dump completed on 2015-11-12 11:25:44
