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
) ENGINE=MyISAM AUTO_INCREMENT=27 DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `maaplicacion`
--

LOCK TABLES `maaplicacion` WRITE;
/*!40000 ALTER TABLE `maaplicacion` DISABLE KEYS */;
INSERT INTO `maaplicacion` VALUES (15,'Vendedores',3,'frmVendedores'),(22,'Pronostico',4,'frmPronosticoVentas'),(11,'Salir',1,'Salir'),(12,'Regristro Modulo',1,'frmRegistroModulo'),(8,'Registro de Aplicaciones',1,'frmRegistroAplicacion'),(7,'Registro Usuario',1,'frmRegistro'),(6,'Manejo de Roles',1,'frmManejoRol'),(5,'Errores Sistema',1,'frmErrores'),(9,'Bitacora',1,'Presentacion'),(3,'Buscar Usuario',1,'frmBuscarUser'),(2,'Buscar Aplicacion',1,'frmBuscarApli'),(1,'Asignacion de Aplicacion',1,'frmAsignacionAplicacion'),(16,'Clientes',3,'frmClientes'),(23,'Reporteador',2,'frmReporteador'),(18,'Facturacion',4,'frmFacturacion'),(19,'Pedidos',4,'frmPedido'),(20,'Cotizaciones',4,'frmCotizacion'),(24,'Ayuda',8,'Ayuda'),(25,'Ayuda',9,'Ayuda'),(26,'AyudaUser',5,'Ayuda');
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
) ENGINE=MyISAM AUTO_INCREMENT=49 DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `mabitacora`
--

LOCK TABLES `mabitacora` WRITE;
/*!40000 ALTER TABLE `mabitacora` DISABLE KEYS */;
INSERT INTO `mabitacora` VALUES (1,'PAMELAJSD','fe80::c84d:2d2c:5006','23:07:20','2015-11-12','Ingreso al sistema',1,1,1),(2,'PAMELAJSD','fe80::c84d:2d2c:5006','23:18:57','2015-11-12','Ingreso al sistema',1,4,1),(3,'PAMELAJSD','fe80::c84d:2d2c:5006','23:22:39','2015-11-12','Ingreso al sistema',1,4,1),(4,'PAMELAJSD','fe80::c84d:2d2c:5006','23:23:48','2015-11-12','Ingreso al sistema',1,4,1),(5,'PAMELAJSD','fe80::c84d:2d2c:5006','23:26:23','2015-11-12','Ingreso al sistema',1,4,1),(6,'PAMELAJSD','fe80::c84d:2d2c:5006','23:31:07','2015-11-12','Ingreso al sistema',1,4,1),(7,'PAMELAJSD','fe80::c84d:2d2c:5006','23:32:40','2015-11-12','Ingreso al sistema',1,4,1),(8,'PAMELAJSD','fe80::c84d:2d2c:5006','23:43:11','2015-11-12','Ingreso al sistema',1,4,1),(9,'PAMELAJSD','fe80::c84d:2d2c:5006','00:13:07','2015-11-13','Ingreso al sistema',1,4,1),(10,'PAMELAJSD','fe80::c84d:2d2c:5006','00:19:26','2015-11-13','Ingreso al sistema',1,4,1),(11,'PAMELAJSD','fe80::c84d:2d2c:5006','00:25:43','2015-11-13','Ingreso al sistema',1,4,1),(12,'PAMELAJSD','fe80::c84d:2d2c:5006','00:27:33','2015-11-13','Ingreso al sistema',1,4,1),(13,'PAMELAJSD','fe80::c84d:2d2c:5006','06:49:29','2015-11-13','Ingreso al sistema',1,4,1),(14,'PAMELAJSD','fe80::c84d:2d2c:5006','06:59:55','2015-11-13','Ingreso al sistema',1,4,1),(15,'PAMELAJSD','fe80::c84d:2d2c:5006','07:30:59','2015-11-13','Ingreso al sistema',1,4,1),(16,'PAMELAJSD','fe80::c84d:2d2c:5006','07:31:34','2015-11-13','Guardar Registro',1,0,1),(17,'PAMELAJSD','fe80::c84d:2d2c:5006','07:37:38','2015-11-13','Ingreso al sistema',1,4,1),(18,'PAMELAJSD','fe80::c84d:2d2c:5006','07:40:01','2015-11-13','Ingreso al sistema',1,4,1),(19,'PAMELAJSD','fe80::c84d:2d2c:5006','07:42:07','2015-11-13','Ingreso al sistema',1,4,1),(20,'PAMELAJSD','fe80::c84d:2d2c:5006','07:45:47','2015-11-13','Ingreso al sistema',1,4,1),(21,'PAMELAJSD','fe80::c84d:2d2c:5006','07:46:32','2015-11-13','Ingreso al sistema',1,4,1),(22,'PAMELAJSD','fe80::c84d:2d2c:5006','07:46:46','2015-11-13','Ingreso al sistema',1,4,1),(23,'PAMELAJSD','fe80::c84d:2d2c:5006','07:47:21','2015-11-13','Ingreso al sistema',1,4,1),(24,'PAMELAJSD','fe80::c84d:2d2c:5006','07:53:10','2015-11-13','Ingreso al sistema',1,4,1),(25,'PAMELAJSD','fe80::c84d:2d2c:5006','07:53:44','2015-11-13','Ingreso al sistema',1,4,1),(26,'PAMELAJSD','fe80::c84d:2d2c:5006','07:59:19','2015-11-13','Ingreso al sistema',1,4,1),(27,'PAMELAJSD','fe80::c84d:2d2c:5006','07:59:47','2015-11-13','Editar  Registro Vendedores',1,0,1),(28,'PAMELAJSD','fe80::c84d:2d2c:5006','08:01:08','2015-11-13','Ingreso al sistema',1,4,1),(29,'PAMELAJSD','fe80::c84d:2d2c:5006','08:01:46','2015-11-13','Editar Registro Clientes',1,0,1),(30,'PAMELAJSD','fe80::c84d:2d2c:5006','08:03:16','2015-11-13','Guardar Registro Clientes',1,0,1),(31,'PAMELAJSD','fe80::c84d:2d2c:5006','08:07:59','2015-11-13','Ingreso al sistema',1,4,1),(32,'PAMELAJSD','fe80::c84d:2d2c:5006','08:08:30','2015-11-13','Guardar Registro Factura',1,0,1),(33,'PAMELAJSD','fe80::c84d:2d2c:5006','08:09:33','2015-11-13','Ingreso al sistema',1,4,1),(34,'PAMELAJSD','fe80::c84d:2d2c:5006','08:10:27','2015-11-13','Guardar Registro Factura',1,0,1),(35,'PAMELAJSD','fe80::c84d:2d2c:5006','08:18:42','2015-11-13','Ingreso al sistema',1,4,1),(36,'PAMELAJSD','fe80::c84d:2d2c:5006','08:30:21','2015-11-13','Ingreso al sistema',1,4,1),(37,'PAMELAJSD','fe80::c84d:2d2c:5006','08:30:57','2015-11-13','Guardar Registro Clientes',2,0,1),(38,'PAMELAJSD','fe80::c84d:2d2c:5006','09:08:17','2015-11-13','Ingreso al sistema',1,4,1),(39,'PAMELAJSD','fe80::c84d:2d2c:5006','09:09:32','2015-11-13','Guardar Registro Clientes',2,0,1),(40,'PAMELAJSD','fe80::c84d:2d2c:5006','09:09:52','2015-11-13','Editar Registro Clientes',1,0,5),(41,'PAMELAJSD','fe80::c84d:2d2c:5006','09:11:23','2015-11-13','Editar Registro Clientes',1,0,5),(42,'PAMELAJSD','fe80::c84d:2d2c:5006','09:11:38','2015-11-13','Eliminar Registro Clientes',4,0,1),(43,'PAMELAJSD','fe80::c84d:2d2c:5006','09:12:13','2015-11-13','Eliminar Registro Clientes',4,0,1),(44,'PAMELAJSD','fe80::c84d:2d2c:5006','09:12:35','2015-11-13','Editar Registro Clientes',1,0,5),(45,'PAMELAJSD','fe80::c84d:2d2c:5006','09:17:34','2015-11-13','Guardar Registro Factura',2,0,1),(46,'PAMELAJSD','fe80::c84d:2d2c:5006','09:19:42','2015-11-13',' Guardar Registro Pedido',2,0,1),(47,'PAMELAJSD','fe80::c84d:2d2c:5006','09:21:07','2015-11-13','Guardar Registro Cotizacion',2,0,1),(48,'PAMELAJSD','fe80::c84d:2d2c:5006','10:07:36','2015-11-13','Ingreso al sistema',1,4,1);
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
  `ncodvendedor` int(11) DEFAULT NULL,
  `vnit` varchar(18) DEFAULT NULL,
  `vnombrecliente` varchar(30) DEFAULT NULL,
  `vapellidocliente` varchar(40) DEFAULT NULL,
  `vdireccion` varchar(30) DEFAULT NULL,
  `ntelefono` int(11) DEFAULT NULL,
  `vcorreo` varchar(30) DEFAULT NULL,
  `vestado` varchar(20) DEFAULT NULL,
  PRIMARY KEY (`ncodcliente`)
) ENGINE=MyISAM AUTO_INCREMENT=13 DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `macliente`
--

LOCK TABLES `macliente` WRITE;
/*!40000 ALTER TABLE `macliente` DISABLE KEYS */;
INSERT INTO `macliente` VALUES (11,1,'34323','Jose Andrés','Chajón','Guatemala',23232,'chajon@hotmail.com','INACTIVO'),(10,1,'23323323','Gerardo','Santizo','Guatemala',23232323,'gerardo@hotmail.com','ACTIVO'),(9,1,'123455-6','Pamela Jacqueline','Selman David','Guatemala',23232332,'pselman@gmail.com','ACTIVO'),(8,1,'Guatemala','Pamela Jacqueline','Selman David','123455-6',23232332,'pselman@gmail.com','ACTIVO'),(12,1,'223344-9','Kevin','Gutierrez','Guatemala',222334455,'kevin@hotmail.com','INACTIVO');
/*!40000 ALTER TABLE `macliente` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `maclientecobro`
--

DROP TABLE IF EXISTS `maclientecobro`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `maclientecobro` (
  `ncodcliente` int(11) NOT NULL AUTO_INCREMENT,
  `vnit` char(25) DEFAULT NULL,
  `vnombrecliente` char(50) DEFAULT NULL,
  `vapellidocliente` char(50) DEFAULT NULL,
  `vdireccion` char(50) DEFAULT NULL,
  `ntelefono` int(11) DEFAULT NULL,
  `vcorreo` char(50) DEFAULT NULL,
  `vestado` char(25) DEFAULT NULL,
  `nsaldo` decimal(10,2) DEFAULT NULL,
  PRIMARY KEY (`ncodcliente`)
) ENGINE=MyISAM AUTO_INCREMENT=6 DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `maclientecobro`
--

LOCK TABLES `maclientecobro` WRITE;
/*!40000 ALTER TABLE `maclientecobro` DISABLE KEYS */;
INSERT INTO `maclientecobro` VALUES (1,'123455-6','Pamela','Selman','Guatemala',23232332,'pselman@gmail.com','ACTIVO',NULL),(2,'233423','Sabrina','Gomez','Guatemala',23523,'sabrina@yajoo.com','ACTIVO',NULL),(3,'23323323','Gerardo','Santizo','Guatemala',23232323,'gerardo@hotmail.com','',NULL),(4,'34323','Jose Andrés','Chajón','Guatemala',23232,'chajon@hotmail.com','ACTIVO',NULL),(5,'223344-9','Kevin','Gutierrez','Guatemala',222334455,'kevin@yahoo.es','ACTIVO',NULL);
/*!40000 ALTER TABLE `maclientecobro` ENABLE KEYS */;
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
  PRIMARY KEY (`ncodcompra`)
) ENGINE=MyISAM DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `macompra`
--

LOCK TABLES `macompra` WRITE;
/*!40000 ALTER TABLE `macompra` DISABLE KEYS */;
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
  KEY `RefMaVENDEDOR14` (`ncodvendedor`),
  KEY `RefMaCLIENTE101` (`ncodcliente`)
) ENGINE=MyISAM DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `macotizacion`
--

LOCK TABLES `macotizacion` WRITE;
/*!40000 ALTER TABLE `macotizacion` DISABLE KEYS */;
INSERT INTO `macotizacion` VALUES (1,'A','0000-00-00','2015-11-19',300000,'Pendiente ',8,NULL,1),(2,'B','2015-11-13','2015-11-27',1200000,'Pendiente ',8,NULL,1),(3,'A','2015-11-06','2015-11-20',300000,'Pendiente ',11,NULL,1);
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
  `nsaldo` decimal(10,2) DEFAULT NULL,
  `nnocuenta` decimal(10,0) DEFAULT NULL,
  `cestado` char(25) DEFAULT NULL,
  `ncodbanco` int(11) NOT NULL,
  PRIMARY KEY (`ncodcuenta`),
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
INSERT INTO `madetallecotizacion` VALUES (1,100,300000,0),(2,1000,1200000,0),(3,100,300000,0);
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
INSERT INTO `madetallefactura` VALUES (1,12,14400,1),(1,120,144000,1),(1,12,14400,2),(1,100,120000,3),(1,10,12000,4),(1,100,120000,5);
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
INSERT INTO `madetallepedido` VALUES (1,NULL,110,132000,0),(2,NULL,111,133200,0),(3,NULL,100,120000,0),(4,NULL,1,1200,0);
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
  `vestado` varchar(20) DEFAULT NULL,
  `vfechaemision` varchar(30) DEFAULT NULL,
  `ntotalpago` decimal(10,2) DEFAULT NULL,
  `ndeudaactual` decimal(10,2) DEFAULT NULL,
  `vdescripcioncompra` varchar(30) DEFAULT NULL,
  `vnumerodocfisico` varchar(30) DEFAULT NULL,
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
  `nsalario` decimal(10,0) DEFAULT NULL,
  `ncomision` decimal(10,0) DEFAULT NULL,
  `vtipo` varchar(30) DEFAULT NULL,
  `vescolaridad` varchar(30) DEFAULT NULL,
  `ntelefono` decimal(10,0) DEFAULT NULL,
  `vcargo` varchar(30) DEFAULT NULL,
  `vdpi` varchar(10) DEFAULT NULL,
  `nedad` decimal(10,0) DEFAULT NULL,
  `vgenero` varchar(30) DEFAULT NULL,
  `nnumcuenta` decimal(10,0) DEFAULT NULL,
  `ncodusuario` int(11) DEFAULT NULL,
  PRIMARY KEY (`ncodempleado`),
  KEY `RefMaUSUARIO74` (`ncodusuario`)
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
-- Table structure for table `maempleadobanco`
--

DROP TABLE IF EXISTS `maempleadobanco`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `maempleadobanco` (
  `ncodempleado` int(11) NOT NULL AUTO_INCREMENT,
  `cnombre` char(40) DEFAULT NULL,
  `nsalario` decimal(18,2) DEFAULT NULL,
  `nnocuenta` decimal(18,0) DEFAULT NULL,
  `cestado` char(25) DEFAULT NULL,
  PRIMARY KEY (`ncodempleado`)
) ENGINE=MyISAM DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `maempleadobanco`
--

LOCK TABLES `maempleadobanco` WRITE;
/*!40000 ALTER TABLE `maempleadobanco` DISABLE KEYS */;
/*!40000 ALTER TABLE `maempleadobanco` ENABLE KEYS */;
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
  `ncodtipo` int(11) DEFAULT NULL,
  `ncodusuario` int(11) NOT NULL,
  `ncodaccion` int(11) NOT NULL,
  `ncodaplicacion` int(11) NOT NULL,
  PRIMARY KEY (`ncoderror`),
  KEY `RefMaTIPOERROR54` (`ncodtipo`),
  KEY `RefMaUSUARIO56` (`ncodusuario`),
  KEY `RefMaACCIONES58` (`ncodaccion`),
  KEY `RefMaAPLICACION68` (`ncodaplicacion`)
) ENGINE=MyISAM DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `maerror`
--

LOCK TABLES `maerror` WRITE;
/*!40000 ALTER TABLE `maerror` DISABLE KEYS */;
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
  `cpagado` char(25) DEFAULT NULL,
  `ncodcliente` int(11) NOT NULL,
  `ncodvendedor` int(11) NOT NULL,
  PRIMARY KEY (`ncodfactura`),
  KEY `RefMaVENDEDOR7` (`ncodvendedor`),
  KEY `RefMaCLIENTE43` (`ncodcliente`)
) ENGINE=MyISAM AUTO_INCREMENT=6 DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `mafactura`
--

LOCK TABLES `mafactura` WRITE;
/*!40000 ALTER TABLE `mafactura` DISABLE KEYS */;
INSERT INTO `mafactura` VALUES (1,'A','Pendiente de Pa','2015-11-19',288000,'2015-11-12','NO',8,1),(2,'A','Pendiente de Pa','2015-11-26',28800,'2015-11-12','NO',8,1),(3,'A','Pendiente de Pa','2015-12-03',240000,'2015-11-13','NO',10,1),(4,'B','Pendiente de Pa','2015-11-18',24000,'2015-11-04','NO',10,1),(5,'A','Pendiente de Pa','2015-11-20',240000,'2015-11-13','NO',11,1);
/*!40000 ALTER TABLE `mafactura` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `mafacturacobro`
--

DROP TABLE IF EXISTS `mafacturacobro`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `mafacturacobro` (
  `ncodfactura` int(11) NOT NULL AUTO_INCREMENT,
  `nnofactura` decimal(10,0) DEFAULT NULL,
  `dfecha` date DEFAULT NULL,
  `dfechaexpiracion` date DEFAULT NULL,
  `ntotal` decimal(18,2) DEFAULT NULL,
  `cestado` char(25) DEFAULT NULL,
  `cpagado` char(25) DEFAULT NULL,
  `ncodcliente` int(11) DEFAULT NULL,
  PRIMARY KEY (`ncodfactura`),
  KEY `RefMaCLIENTECOBRO119` (`ncodcliente`)
) ENGINE=MyISAM AUTO_INCREMENT=6 DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `mafacturacobro`
--

LOCK TABLES `mafacturacobro` WRITE;
/*!40000 ALTER TABLE `mafacturacobro` DISABLE KEYS */;
INSERT INTO `mafacturacobro` VALUES (1,1,'2015-11-12','2015-11-19',288000.00,'Pendiente de Pago','NO',8),(2,2,'2015-11-12','2015-11-26',28800.00,'Pendiente de Pago','NO',8),(3,3,'2015-11-13','2015-12-03',240000.00,'Pendiente de Pago','NO',10),(4,4,'2015-11-04','2015-11-18',24000.00,'Pendiente de Pago','NO',10),(5,5,'2015-11-13','2015-11-20',240000.00,'Pendiente de Pago','NO',11);
/*!40000 ALTER TABLE `mafacturacobro` ENABLE KEYS */;
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
  `ncantidad` decimal(10,2) DEFAULT NULL,
  `vestatus` varchar(10) DEFAULT NULL,
  `nprecio` decimal(18,2) DEFAULT NULL,
  `nconsulta` int(11) DEFAULT NULL,
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
  `vnombremodulo` varchar(20) DEFAULT NULL,
  `vdescripcion` varchar(50) DEFAULT NULL,
  PRIMARY KEY (`ncodmodulo`)
) ENGINE=MyISAM AUTO_INCREMENT=10 DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `mamodulo`
--

LOCK TABLES `mamodulo` WRITE;
/*!40000 ALTER TABLE `mamodulo` DISABLE KEYS */;
INSERT INTO `mamodulo` VALUES (3,'Catalogos','Catálogos'),(4,'Procesos','Procesos'),(2,'Reportes','Reportes Disponibles'),(1,'Seguridad','Seguridad Sistema'),(5,'AyudaUsuario','AyudaUsuario');
/*!40000 ALTER TABLE `mamodulo` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `maordencompra`
--

DROP TABLE IF EXISTS `maordencompra`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `maordencompra` (
  `ncodordencompra` int(11) NOT NULL AUTO_INCREMENT,
  `vstatusorden` varchar(20) DEFAULT NULL,
  `ncodproveedor` int(11) NOT NULL,
  `vdescripcioncompra` varchar(40) DEFAULT NULL,
  `ncantidad` decimal(10,0) DEFAULT NULL,
  `ncostototal` decimal(10,0) DEFAULT NULL,
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
  `vinicioproduccion` varchar(30) DEFAULT NULL,
  `ventregaproducto` varchar(30) DEFAULT NULL,
  `vultimomovimiento` varchar(20) DEFAULT NULL,
  `nnodocumento` int(11) DEFAULT NULL,
  `ncantidadproductoafabricar` int(11) DEFAULT NULL,
  `ncantidadnoproductoterminado` int(11) DEFAULT NULL,
  `ncantidadproductofaltante` int(11) DEFAULT NULL,
  `vestatusorden` varchar(40) DEFAULT NULL,
  `ncodreceta` int(11) NOT NULL,
  PRIMARY KEY (`ncodordenes`),
  KEY `RefMaRECETA122` (`ncodreceta`)
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
) ENGINE=MyISAM AUTO_INCREMENT=5 DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `mapedido`
--

LOCK TABLES `mapedido` WRITE;
/*!40000 ALTER TABLE `mapedido` DISABLE KEYS */;
INSERT INTO `mapedido` VALUES (1,'A','0000-00-00','0000-00-00',132000,'Pendiente',8,1),(2,'A','0000-00-00','2015-11-26',133200,'Pendiente',8,1),(3,'A','2015-11-13','2015-11-27',120000,'Pendiente',8,1),(4,'A','0000-00-00','0000-00-00',1200,'Pendiente',11,1);
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
  PRIMARY KEY (`ncodarticulo`)
) ENGINE=MyISAM AUTO_INCREMENT=3 DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `maproducto`
--

LOCK TABLES `maproducto` WRITE;
/*!40000 ALTER TABLE `maproducto` DISABLE KEYS */;
INSERT INTO `maproducto` VALUES (1,1300,1200,'Olimpia','Cama Imperial','Cama Olimpia'),(2,1200,3000,'Olimpia','Cama Matrimonial','Cama Olimpia');
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
  `vnit` varchar(10) DEFAULT NULL,
  `vdescripcion` varchar(100) DEFAULT NULL,
  `vpais` varchar(20) DEFAULT NULL,
  `vtelefono` varchar(40) DEFAULT NULL,
  `vciudad` varchar(40) DEFAULT NULL,
  `vnombre` varchar(30) DEFAULT NULL,
  `vdireccion` varchar(30) DEFAULT NULL,
  `vestado` varchar(20) DEFAULT NULL,
  PRIMARY KEY (`ncodproveedor`)
) ENGINE=MyISAM DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `maproveedor`
--

LOCK TABLES `maproveedor` WRITE;
/*!40000 ALTER TABLE `maproveedor` DISABLE KEYS */;
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
) ENGINE=MyISAM AUTO_INCREMENT=7 DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `mapunto`
--

LOCK TABLES `mapunto` WRITE;
/*!40000 ALTER TABLE `mapunto` DISABLE KEYS */;
INSERT INTO `mapunto` VALUES (1,'Nov','316800',1),(2,'Nov','340800',2),(3,'Nov 340800','340800',3),(4,'Nov','340800',4),(5,'11','340800',5),(6,'Nov 340800','340800',6);
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
  `nhorahombre` varchar(18) DEFAULT NULL,
  `vnombrereceta` varchar(20) DEFAULT NULL,
  PRIMARY KEY (`ncodreceta`)
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
  `vnombrerole` varchar(30) NOT NULL,
  PRIMARY KEY (`ncodrole`)
) ENGINE=MyISAM AUTO_INCREMENT=4 DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `marolusuario`
--

LOCK TABLES `marolusuario` WRITE;
/*!40000 ALTER TABLE `marolusuario` DISABLE KEYS */;
INSERT INTO `marolusuario` VALUES (1,'Superusuario'),(2,'Administrador'),(3,'vendedor');
/*!40000 ALTER TABLE `marolusuario` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `matipodocumento`
--

DROP TABLE IF EXISTS `matipodocumento`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `matipodocumento` (
  `ncodtipodocumento` int(11) NOT NULL AUTO_INCREMENT,
  `vestado` varchar(20) DEFAULT NULL,
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
INSERT INTO `matipopago` VALUES (1,'Efectivo'),(2,'Cheque'),(3,'Tarjeta'),(4,'Crédito');
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
  `vestado` char(25) DEFAULT NULL,
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
  PRIMARY KEY (`ncodusuario`)
) ENGINE=MyISAM AUTO_INCREMENT=5 DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `mausuario`
--

LOCK TABLES `mausuario` WRITE;
/*!40000 ALTER TABLE `mausuario` DISABLE KEYS */;
INSERT INTO `mausuario` VALUES (1,'root','root','root@root.com','Superusuario','dc76e9f0c0006e8f919e0c515c66dbba3982f785'),(2,'Administrador','Admin','----','Administrador','4e7afebcfbae000b22c7c85e5560f89a2a0280b4'),(3,'hector','cardona','--','hcardona','81bce1f3bf343c464685d875c626820cdb58e309'),(4,'Pamela','Selman','pselman@gmail.com','pselman','7110eda4d09e062aa5e4a390b0a572ac0d2c0220');
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
) ENGINE=MyISAM AUTO_INCREMENT=2 DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `mavendedor`
--

LOCK TABLES `mavendedor` WRITE;
/*!40000 ALTER TABLE `mavendedor` DISABLE KEYS */;
INSERT INTO `mavendedor` VALUES (1,'23423423','Gerardo','Santizo','Guatemala',234523,'gerardo@yahoo.com','ACTIVO');
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
) ENGINE=MyISAM AUTO_INCREMENT=6 DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `maventas`
--

LOCK TABLES `maventas` WRITE;
/*!40000 ALTER TABLE `maventas` DISABLE KEYS */;
INSERT INTO `maventas` VALUES (1,'2015-11-11',288000),(2,'2015-11-11',28800),(3,'0000-00-00',240000),(4,'2015-11-04',24000),(5,'2015-11-13',240000);
/*!40000 ALTER TABLE `maventas` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `trcobro`
--

DROP TABLE IF EXISTS `trcobro`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `trcobro` (
  `ncodcobro` int(11) NOT NULL AUTO_INCREMENT,
  `npago` decimal(10,2) DEFAULT NULL,
  `nsaldo` decimal(10,2) DEFAULT NULL,
  `dfecha` date DEFAULT NULL,
  `nmora` decimal(10,2) DEFAULT NULL,
  `ncoddocumento` int(11) NOT NULL,
  `ncodfactura` int(11) DEFAULT NULL,
  PRIMARY KEY (`ncodcobro`),
  KEY `RefTrDOCUMENTOS71` (`ncoddocumento`),
  KEY `RefMaFACTURACOBRO120` (`ncodfactura`)
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
  `ncantidadProducto` decimal(10,0) DEFAULT NULL,
  `ntotalapagar` decimal(10,0) DEFAULT NULL,
  `ntotalpagado` decimal(10,0) DEFAULT NULL,
  `nsaldoapagar` decimal(10,0) DEFAULT NULL,
  `ncodorden` int(11) NOT NULL,
  KEY `RefMaPRODUCTO11` (`ncodarticulo`),
  KEY `RefMaPROVEEDOR12` (`ncodproveedor`),
  KEY `RefTrORDENPRODUCTO81` (`ncodorden`)
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
-- Table structure for table `trcreditodebito`
--

DROP TABLE IF EXISTS `trcreditodebito`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `trcreditodebito` (
  `ncoddocumento` int(11) NOT NULL AUTO_INCREMENT,
  `dfecha` date DEFAULT NULL,
  `nmonto` decimal(18,2) DEFAULT NULL,
  `ncodtipotransaccion` int(11) DEFAULT NULL,
  `ncodfactura` int(11) DEFAULT NULL,
  PRIMARY KEY (`ncoddocumento`),
  KEY `RefMaTIPOTRANSACCION118` (`ncodtipotransaccion`),
  KEY `RefMaFACTURACOBRO121` (`ncodfactura`)
) ENGINE=MyISAM DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `trcreditodebito`
--

LOCK TABLES `trcreditodebito` WRITE;
/*!40000 ALTER TABLE `trcreditodebito` DISABLE KEYS */;
/*!40000 ALTER TABLE `trcreditodebito` ENABLE KEYS */;
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
  `dmonto` decimal(10,2) DEFAULT NULL,
  `ncodtipotransaccion` int(11) NOT NULL,
  `ncodcuenta` int(11) NOT NULL,
  PRIMARY KEY (`ncoddocumento`),
  KEY `RefMaTIPOTRANSACCION23` (`ncodtipotransaccion`),
  KEY `RefMaCUENTA40` (`ncodcuenta`)
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
-- Table structure for table `trdocumentosaceptados`
--

DROP TABLE IF EXISTS `trdocumentosaceptados`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `trdocumentosaceptados` (
  `ncodaceptacion` int(11) NOT NULL AUTO_INCREMENT,
  `cestado` char(25) DEFAULT NULL,
  `nmonto` decimal(18,2) DEFAULT NULL,
  `ncoddocumento` int(11) DEFAULT NULL,
  PRIMARY KEY (`ncodaceptacion`),
  KEY `RefTrDOCUMENTOS117` (`ncoddocumento`)
) ENGINE=MyISAM DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `trdocumentosaceptados`
--

LOCK TABLES `trdocumentosaceptados` WRITE;
/*!40000 ALTER TABLE `trdocumentosaceptados` DISABLE KEYS */;
/*!40000 ALTER TABLE `trdocumentosaceptados` ENABLE KEYS */;
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
  `ncodusuario` int(11) DEFAULT NULL,
  PRIMARY KEY (`ncodgrafica`)
) ENGINE=MyISAM AUTO_INCREMENT=7 DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `trgrafica`
--

LOCK TABLES `trgrafica` WRITE;
/*!40000 ALTER TABLE `trgrafica` DISABLE KEYS */;
INSERT INTO `trgrafica` VALUES (1,'2015-11-13','barras','v','v','v',0),(2,'2015-11-13','barras','a','v','b',0),(3,'2015-11-13','pie','Ventas','Fechas','Valores',0),(4,'2015-11-13','barras','Ventas','Fechas','Valores',0),(5,'2015-11-13','lineal','Ventas','Fechas','Valores',0),(6,'2015-11-13','pie','Ventas','Ventas','Valores',0);
/*!40000 ALTER TABLE `trgrafica` ENABLE KEYS */;
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
-- Table structure for table `trpagoempleado`
--

DROP TABLE IF EXISTS `trpagoempleado`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `trpagoempleado` (
  `ncodpagoempleado` int(11) NOT NULL AUTO_INCREMENT,
  `ncodempleado` int(11) DEFAULT NULL,
  `ncoddocumento` int(11) DEFAULT NULL,
  PRIMARY KEY (`ncodpagoempleado`),
  KEY `RefMaEMPLEADOBANCO115` (`ncodempleado`),
  KEY `RefTrDOCUMENTOS116` (`ncoddocumento`)
) ENGINE=MyISAM DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `trpagoempleado`
--

LOCK TABLES `trpagoempleado` WRITE;
/*!40000 ALTER TABLE `trpagoempleado` DISABLE KEYS */;
/*!40000 ALTER TABLE `trpagoempleado` ENABLE KEYS */;
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
  KEY `RefMaTIPOPAGO9` (`ncodtipopago`),
  KEY `RefTrDOCUMENTOS31` (`ncoddocumento`),
  KEY `RefMaCUENTA80` (`ncodcuenta`),
  KEY `RefMaRECIBOPAGO93` (`ncodrecibopago`)
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
  KEY `RefMaVENDEDOR6` (`ncodvendedor`),
  KEY `RefMaVENTAS34` (`ncodventas`),
  KEY `RefMaPRODUCTO82` (`ncodarticulo`),
  KEY `RefMaCLIENTE100` (`ncodcliente`)
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
-- Table structure for table `trreporte`
--

DROP TABLE IF EXISTS `trreporte`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `trreporte` (
  `vnomreporte` varchar(30) NOT NULL,
  `dfechareporte` varchar(50) DEFAULT NULL,
  `ncodaplicacion` char(10) DEFAULT NULL,
  `ncodmodulo` int(11) DEFAULT NULL,
  `ncodusuario` int(11) NOT NULL,
  PRIMARY KEY (`vnomreporte`),
  KEY `RefMaUSUARIO72` (`ncodusuario`),
  KEY `RefMaMODULO113` (`ncodmodulo`)
) ENGINE=MyISAM DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `trreporte`
--

LOCK TABLES `trreporte` WRITE;
/*!40000 ALTER TABLE `trreporte` DISABLE KEYS */;
INSERT INTO `trreporte` VALUES ('macliente','12/11/2015 11:19:49 p. m.','1',0,1),('macotizacion','12/11/2015 11:19:57 p. m.','1',0,1),('mafactura','12/11/2015 11:20:04 p. m.','1',0,1),('mapedido','12/11/2015 11:20:10 p. m.','1',0,1),('mavendedor','12/11/2015 11:20:17 p. m.','1',0,1),('maventas','12/11/2015 11:20:24 p. m.','1',0,1);
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
INSERT INTO `trroletoaplicacion` VALUES (3,14,'\0','','\0','\0','\0','\0','','\0','\0','\0','','\0'),(3,11,'\0','\0','\0','\0','\0','\0','\0','\0','\0','\0','\0','\0'),(2,8,'\0','\0','\0','\0','\0','\0','\0','\0','\0','\0','\0','\0'),(1,1,'\0','\0','\0','\0','\0','\0','\0','\0','\0','\0','\0','\0'),(1,11,'\0','\0','\0','\0','\0','\0','\0','\0','\0','\0','\0','\0'),(1,15,'','','','','','','','','','','',''),(1,16,'','','','','','','','','','','',''),(1,17,'','','','','','','','','','','',''),(1,18,'\0','\0','\0','\0','\0','\0','\0','\0','','\0','\0',''),(1,19,'\0','\0','\0','\0','\0','\0','\0','\0','','\0','\0',''),(1,20,'\0','\0','\0','\0','\0','\0','\0','\0','','\0','\0',''),(1,21,'\0','\0','\0','\0','\0','\0','\0','\0','\0','\0','\0','\0'),(1,1,'','','','','','','','','','','',''),(1,2,'','','','','','','','','','','',''),(1,3,'','','','','','','','','','','',''),(1,9,'','','','','','','','','','','',''),(1,5,'','','','','','','','','','','',''),(1,6,'','','','','','','','','','','',''),(1,7,'','','','','','','','','','','',''),(1,8,'','','','','','','','','','','',''),(1,12,'','','','','','','','','','','',''),(1,24,'\0','\0','\0','\0','\0','\0','\0','\0','\0','\0','\0','\0'),(1,24,'\0','\0','\0','\0','\0','\0','\0','\0','\0','\0','\0','\0');
/*!40000 ALTER TABLE `trroletoaplicacion` ENABLE KEYS */;
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
INSERT INTO `trusuariotoaplicacion` VALUES (2,5,'\0','\0','\0','\0','\0','\0','\0','\0','\0','\0','\0','\0'),(3,14,'','\0','','','\0','\0','\0','\0','\0','','\0','\0'),(3,11,'\0','\0','\0','\0','\0','\0','\0','\0','\0','\0','\0','\0'),(2,1,'\0','\0','\0','\0','\0','\0','\0','\0','\0','\0','\0','\0'),(4,1,'','','','','','','','','','','',''),(4,2,'','','','','','','','','','','',''),(4,15,'','','','','','','','','','','',''),(4,15,'','','','','','','','','','','',''),(4,16,'','','','','','','','','','','',''),(4,17,'','','','','','','','','','','',''),(4,21,'','','','','','','','','','','',''),(4,18,'\0','\0','\0','\0','\0','\0','\0','\0','','\0','\0',''),(4,19,'\0','\0','\0','\0','\0','\0','\0','\0','','\0','\0',''),(4,20,'\0','\0','\0','\0','\0','\0','\0','\0','','\0','\0',''),(4,24,'\0','\0','\0','\0','\0','\0','\0','\0','\0','\0','\0','\0'),(4,25,'\0','\0','\0','\0','\0','\0','\0','\0','\0','\0','\0','\0');
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

-- Dump completed on 2015-11-13 10:12:27
