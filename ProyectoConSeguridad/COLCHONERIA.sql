-- phpMyAdmin SQL Dump
-- version 4.4.14
-- http://www.phpmyadmin.net
--
-- Host: 127.0.0.1
-- Generation Time: Nov 08, 2015 at 07:14 PM
-- Server version: 5.6.26
-- PHP Version: 5.6.12

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `COLCHONERIA`
--

-- --------------------------------------------------------

--
-- Table structure for table `MaACCIONES`
--

CREATE TABLE IF NOT EXISTS `MaACCIONES` (
  `ncodAccion` int(11) NOT NULL,
  `vnombreAccion` varchar(40) NOT NULL
) ENGINE=MyISAM AUTO_INCREMENT=8 DEFAULT CHARSET=latin1;

--
-- Dumping data for table `MaACCIONES`
--

INSERT INTO `MaACCIONES` (`ncodAccion`, `vnombreAccion`) VALUES
(1, 'Loggin'),
(2, 'Insercion'),
(3, 'Buscar'),
(4, 'Eliminacion'),
(5, 'Actualizacion'),
(6, 'Reportes'),
(7, 'Graficas');

-- --------------------------------------------------------

--
-- Table structure for table `MaAPLICACION`
--

CREATE TABLE IF NOT EXISTS `MaAPLICACION` (
  `ncodAplicacion` int(11) NOT NULL,
  `vnombreAplicacion` varchar(30) NOT NULL,
  `ncodModulo` int(11) NOT NULL,
  `vnombreFormulario` varchar(40) DEFAULT NULL
) ENGINE=MyISAM AUTO_INCREMENT=15 DEFAULT CHARSET=latin1;

--
-- Dumping data for table `MaAPLICACION`
--

INSERT INTO `MaAPLICACION` (`ncodAplicacion`, `vnombreAplicacion`, `ncodModulo`, `vnombreFormulario`) VALUES
(1, 'Asignacion de Aplicacion', 1, 'frmAsignacionAplicacion'),
(2, 'Buscar Aplicacion', 1, 'frmBuscarApli'),
(3, 'Buscar Usuario', 1, 'frmBuscarUser'),
(9, 'Bitacora', 1, 'Presentacion'),
(5, 'Errores Sistema', 1, 'frmErrores'),
(6, 'Manejo de Roles', 1, 'frmManejoRol'),
(7, 'Registro Usuario', 1, 'frmRegistro'),
(8, 'Registro de Aplicaciones', 1, 'frmRegistroAplicacion'),
(12, 'Regristro Modulo', 1, 'frmRegistroModulo'),
(11, 'Salir', 1, 'Salir'),
(14, 'Prueba', 2, 'frmPrueba');

-- --------------------------------------------------------

--
-- Table structure for table `MaBITACORA`
--

CREATE TABLE IF NOT EXISTS `MaBITACORA` (
  `ncodBitacora` int(11) NOT NULL,
  `vnombreEquipo` varchar(25) NOT NULL,
  `vipEquipo` varchar(20) DEFAULT NULL,
  `dhora` time DEFAULT NULL,
  `dfecha` date DEFAULT NULL,
  `vdetalleAccion` varchar(100) DEFAULT NULL,
  `ncodAccion` int(11) NOT NULL,
  `ncodUsuario` int(11) NOT NULL,
  `ncodAplicacion` int(11) NOT NULL
) ENGINE=MyISAM AUTO_INCREMENT=83 DEFAULT CHARSET=latin1;

--
-- Dumping data for table `MaBITACORA`
--

INSERT INTO `MaBITACORA` (`ncodBitacora`, `vnombreEquipo`, `vipEquipo`, `dhora`, `dfecha`, `vdetalleAccion`, `ncodAccion`, `ncodUsuario`, `ncodAplicacion`) VALUES
(1, 'HECTORCARDONA', '192.168.232.1', '19:49:19', '2015-11-07', 'Ingreso al sistema', 1, 2, 1),
(2, 'HECTORCARDONA', '192.168.232.1', '19:49:48', '2015-11-07', 'Ingreso al sistema', 1, 1, 1),
(3, 'HECTORCARDONA', '192.168.232.1', '19:50:41', '2015-11-07', 'Ingreso al sistema', 1, 2, 1),
(4, 'HECTORCARDONA', '192.168.232.1', '19:51:27', '2015-11-07', 'Ingreso al sistema', 1, 1, 1),
(5, 'HECTORCARDONA', '192.168.232.1', '19:53:03', '2015-11-07', 'Ingreso al sistema', 1, 1, 1),
(6, 'HECTORCARDONA', '192.168.232.1', '19:55:23', '2015-11-07', 'Ingreso al sistema', 1, 1, 1),
(7, 'HECTORCARDONA', '192.168.232.1', '19:56:16', '2015-11-07', 'Ingreso al sistema', 1, 1, 1),
(8, 'HECTORCARDONA', '192.168.232.1', '19:59:39', '2015-11-07', 'Ingreso al sistema', 1, 2, 1),
(9, 'HECTORCARDONA', '192.168.232.1', '20:00:09', '2015-11-07', 'Ingreso al sistema', 1, 1, 1),
(10, 'HECTORCARDONA', '192.168.232.1', '20:02:10', '2015-11-07', 'Ingreso al sistema', 1, 1, 1),
(11, 'HECTORCARDONA', '192.168.232.1', '20:03:10', '2015-11-07', 'Ingreso al sistema', 1, 1, 1),
(12, 'HECTORCARDONA', '192.168.232.1', '20:04:41', '2015-11-07', 'Ingreso al sistema', 1, 2, 1),
(13, 'HECTORCARDONA', '192.168.232.1', '20:06:24', '2015-11-07', 'Ingreso al sistema', 1, 2, 1),
(14, 'HECTORCARDONA', '192.168.232.1', '20:09:09', '2015-11-07', 'Ingreso al sistema', 1, 2, 1),
(15, 'HECTORCARDONA', '192.168.232.1', '20:11:20', '2015-11-07', 'Ingreso al sistema', 1, 2, 1),
(16, 'HECTORCARDONA', '192.168.232.1', '20:15:08', '2015-11-07', 'Ingreso al sistema', 1, 1, 1),
(17, 'HECTORCARDONA', '192.168.232.1', '20:16:16', '2015-11-07', 'Ingreso al sistema', 1, 2, 1),
(18, 'HECTORCARDONA', '192.168.232.1', '20:19:45', '2015-11-07', 'Ingreso al sistema', 1, 1, 1),
(19, 'HECTORCARDONA', '192.168.232.1', '20:20:35', '2015-11-07', 'Ingreso al sistema', 1, 2, 1),
(20, 'HECTORCARDONA', '192.168.232.1', '20:22:46', '2015-11-07', 'Ingreso al sistema', 1, 2, 1),
(21, 'HECTORCARDONA', '192.168.232.1', '20:24:27', '2015-11-07', 'Ingreso al sistema', 1, 2, 1),
(22, 'HECTORCARDONA', '192.168.232.1', '20:25:17', '2015-11-07', 'Ingreso al sistema', 1, 1, 1),
(23, 'HECTORCARDONA', '192.168.232.1', '20:26:01', '2015-11-07', 'Ingreso al sistema', 1, 2, 1),
(24, 'HECTORCARDONA', '192.168.232.1', '20:30:01', '2015-11-07', 'Ingreso al sistema', 1, 2, 1),
(25, 'HECTORCARDONA', '192.168.232.1', '20:30:51', '2015-11-07', 'Ingreso al sistema', 1, 1, 1),
(26, 'HECTORCARDONA', '192.168.232.1', '20:32:01', '2015-11-07', 'Ingreso al sistema', 1, 2, 1),
(27, 'HECTORCARDONA', '192.168.232.1', '20:34:36', '2015-11-07', 'Ingreso al sistema', 1, 2, 1),
(28, 'HECTORCARDONA', '192.168.232.1', '20:35:58', '2015-11-07', 'Ingreso al sistema', 1, 2, 1),
(29, 'HECTORCARDONA', '192.168.232.1', '20:44:40', '2015-11-07', 'Ingreso al sistema', 1, 2, 1),
(30, 'HECTORCARDONA', '192.168.232.1', '20:48:08', '2015-11-07', 'Ingreso al sistema', 1, 1, 1),
(31, 'HECTORCARDONA', '192.168.232.1', '20:49:44', '2015-11-07', 'Ingreso al sistema', 1, 2, 1),
(32, 'HECTORCARDONA', '192.168.232.1', '20:51:41', '2015-11-07', 'Ingreso al sistema', 1, 1, 1),
(33, 'HECTORCARDONA', '192.168.232.1', '20:52:28', '2015-11-07', 'Ingreso al sistema', 1, 2, 1),
(34, 'HECTORCARDONA', '192.168.232.1', '21:00:36', '2015-11-07', 'Ingreso al sistema', 1, 1, 1),
(35, 'HECTORCARDONA', '192.168.232.1', '21:00:52', '2015-11-07', 'Ingreso al sistema', 1, 2, 1),
(36, 'HECTORCARDONA', '192.168.232.1', '21:02:08', '2015-11-07', 'Ingreso al sistema', 1, 2, 1),
(37, 'HECTORCARDONA', '192.168.232.1', '21:09:12', '2015-11-07', 'Ingreso al sistema', 1, 2, 1),
(38, 'HECTORCARDONA', '192.168.232.1', '21:10:59', '2015-11-07', 'Ingreso al sistema', 1, 2, 1),
(39, 'HECTORCARDONA', '192.168.232.1', '21:12:35', '2015-11-07', 'Ingreso al sistema', 1, 2, 1),
(40, 'HECTORCARDONA', '192.168.232.1', '21:22:37', '2015-11-07', 'Ingreso al sistema', 1, 3, 1),
(41, 'HECTORCARDONA', '192.168.232.1', '21:23:18', '2015-11-07', 'Ingreso al sistema', 1, 3, 1),
(42, 'HECTORCARDONA', '192.168.232.1', '21:24:47', '2015-11-07', 'Ingreso al sistema', 1, 3, 1),
(43, 'HECTORCARDONA', '192.168.232.1', '21:31:02', '2015-11-07', 'Ingreso al sistema', 1, 3, 1),
(44, 'HECTORCARDONA', '192.168.232.1', '21:32:46', '2015-11-07', 'Ingreso al sistema', 1, 3, 1),
(45, 'HECTORCARDONA', '192.168.232.1', '21:32:59', '2015-11-07', 'Ingreso al sistema', 1, 2, 1),
(46, 'HECTORCARDONA', '192.168.232.1', '23:03:50', '2015-11-07', 'Ingreso al sistema', 1, 3, 1),
(47, 'HECTORCARDONA', '192.168.232.1', '23:07:45', '2015-11-07', 'Ingreso al sistema', 1, 3, 1),
(48, 'HECTORCARDONA', '192.168.232.1', '23:09:37', '2015-11-07', 'Ingreso al sistema', 1, 3, 1),
(49, 'HECTORCARDONA', '192.168.232.1', '23:16:15', '2015-11-07', 'Ingreso al sistema', 1, 3, 1),
(50, 'HECTORCARDONA', '192.168.232.1', '23:18:47', '2015-11-07', 'Ingreso al sistema', 1, 3, 1),
(51, 'HECTORCARDONA', '192.168.232.1', '23:24:37', '2015-11-07', 'Ingreso al sistema', 1, 3, 1),
(52, 'HECTORCARDONA', '192.168.232.1', '06:35:49', '2015-11-08', 'Ingreso al sistema', 1, 3, 1),
(53, 'HECTORCARDONA', '192.168.232.1', '08:43:30', '2015-11-08', 'Ingreso al sistema', 1, 3, 1),
(54, 'HECTORCARDONA', '192.168.232.1', '08:44:48', '2015-11-08', 'Ingreso al sistema', 1, 1, 1),
(55, 'HECTORCARDONA', '192.168.232.1', '08:45:02', '2015-11-08', 'Ingreso al sistema', 1, 3, 1),
(56, 'HECTORCARDONA', '192.168.232.1', '08:45:57', '2015-11-08', 'Ingreso al sistema', 1, 1, 1),
(57, 'HECTORCARDONA', '192.168.232.1', '08:46:38', '2015-11-08', 'Ingreso al sistema', 1, 3, 1),
(58, 'HECTORCARDONA', '192.168.232.1', '08:48:17', '2015-11-08', 'Ingreso al sistema', 1, 1, 1),
(59, 'HECTORCARDONA', '192.168.232.1', '09:43:36', '2015-11-08', 'Ingreso al sistema', 1, 1, 1),
(60, 'HECTORCARDONA', '192.168.232.1', '10:09:37', '2015-11-08', 'Ingreso al sistema', 1, 3, 1),
(61, 'HECTORCARDONA', '192.168.232.1', '10:09:50', '2015-11-08', 'Ingreso al sistema', 1, 1, 1),
(62, 'HECTORCARDONA', '192.168.232.1', '10:14:12', '2015-11-08', 'Ingreso al sistema', 1, 1, 1),
(63, 'HECTORCARDONA', '192.168.232.1', '10:17:20', '2015-11-08', 'Ingreso al sistema', 1, 1, 1),
(64, 'HECTORCARDONA', '192.168.232.1', '10:23:06', '2015-11-08', 'Ingreso al sistema', 1, 1, 1),
(65, 'HECTORCARDONA', '192.168.232.1', '10:24:34', '2015-11-08', 'Ingreso al sistema', 1, 1, 1),
(66, 'HECTORCARDONA', '192.168.232.1', '10:27:52', '2015-11-08', 'Ingreso al sistema', 1, 1, 1),
(67, 'HECTORCARDONA', '192.168.232.1', '10:31:37', '2015-11-08', 'Ingreso al sistema', 1, 1, 1),
(68, 'HECTORCARDONA', '192.168.232.1', '10:42:52', '2015-11-08', 'Ingreso al sistema', 1, 1, 1),
(69, 'HECTORCARDONA', '192.168.232.1', '10:48:58', '2015-11-08', 'Ingreso al sistema', 1, 1, 1),
(70, 'HECTORCARDONA', '192.168.232.1', '10:50:01', '2015-11-08', 'Ingreso al sistema', 1, 3, 1),
(71, 'HECTORCARDONA', '192.168.232.1', '10:50:35', '2015-11-08', 'Ingreso al sistema', 1, 1, 1),
(72, 'HECTORCARDONA', '192.168.232.1', '10:51:20', '2015-11-08', 'Ingreso al sistema', 1, 3, 1),
(73, 'HECTORCARDONA', '192.168.232.1', '10:54:01', '2015-11-08', 'Ingreso al sistema', 1, 1, 1),
(74, 'HECTORCARDONA', '192.168.232.1', '10:56:15', '2015-11-08', 'Ingreso al sistema', 1, 1, 1),
(75, 'HECTORCARDONA', '192.168.232.1', '10:58:30', '2015-11-08', 'Ingreso al sistema', 1, 3, 1),
(76, 'HECTORCARDONA', '192.168.232.1', '11:00:40', '2015-11-08', 'Ingreso al sistema', 1, 1, 1),
(77, 'HECTORCARDONA', '192.168.232.1', '11:39:08', '2015-11-08', 'Ingreso al sistema', 1, 1, 1),
(78, 'HECTORCARDONA', '192.168.232.1', '12:00:38', '2015-11-08', 'Ingreso al sistema', 1, 1, 1),
(79, 'HECTORCARDONA', '192.168.232.1', '12:02:05', '2015-11-08', 'Ingreso al sistema', 1, 1, 1),
(80, 'HECTORCARDONA', '192.168.232.1', '12:02:45', '2015-11-08', 'Ingreso al sistema', 1, 3, 1),
(81, 'HECTORCARDONA', '192.168.232.1', '12:03:01', '2015-11-08', 'Ingreso al sistema', 1, 1, 1),
(82, 'HECTORCARDONA', '192.168.232.1', '12:03:44', '2015-11-08', 'Ingreso al sistema', 1, 3, 1);

-- --------------------------------------------------------

--
-- Table structure for table `MaERROR`
--

CREATE TABLE IF NOT EXISTS `MaERROR` (
  `ncodError` int(11) NOT NULL,
  `dhora` time DEFAULT NULL,
  `dfecha` date DEFAULT NULL,
  `ncodAccion` int(11) DEFAULT NULL,
  `ncodUsuario` int(11) NOT NULL,
  `vaccion` varchar(50) NOT NULL,
  `ncodAplicacion` int(11) NOT NULL
) ENGINE=MyISAM AUTO_INCREMENT=5 DEFAULT CHARSET=latin1;

--
-- Dumping data for table `MaERROR`
--

INSERT INTO `MaERROR` (`ncodError`, `dhora`, `dfecha`, `ncodAccion`, `ncodUsuario`, `vaccion`, `ncodAplicacion`) VALUES
(1, '20:20:27', '2015-11-07', 1, 0, 'Usuario o Contraseña Incorrecta', 1),
(2, '22:47:02', '2015-11-07', 1, 0, 'Hay Uno o mas Campos Vacios', 1),
(3, '10:09:33', '2015-11-08', 1, 3, 'Usuario o Contraseña Incorrecta', 1),
(4, '12:01:54', '2015-11-08', 1, 3, 'Usuario o Contraseña Incorrecta', 1);

-- --------------------------------------------------------

--
-- Table structure for table `MaMODULO`
--

CREATE TABLE IF NOT EXISTS `MaMODULO` (
  `ncodModulo` int(11) NOT NULL,
  `vnombreModulo` varchar(10) NOT NULL,
  `vdescripcion` varchar(30) DEFAULT NULL,
  `vnombreReporte` varchar(10) DEFAULT NULL
) ENGINE=MyISAM AUTO_INCREMENT=3 DEFAULT CHARSET=latin1;

--
-- Dumping data for table `MaMODULO`
--

INSERT INTO `MaMODULO` (`ncodModulo`, `vnombreModulo`, `vdescripcion`, `vnombreReporte`) VALUES
(1, 'Seguridad', 'Seguridad Sistema', NULL),
(2, 'prueba', 'prueba usuario', NULL);

-- --------------------------------------------------------

--
-- Table structure for table `MaROLUSUARIO`
--

CREATE TABLE IF NOT EXISTS `MaROLUSUARIO` (
  `ncodRole` int(11) NOT NULL,
  `vnombrerole` varchar(20) DEFAULT NULL
) ENGINE=MyISAM AUTO_INCREMENT=4 DEFAULT CHARSET=latin1;

--
-- Dumping data for table `MaROLUSUARIO`
--

INSERT INTO `MaROLUSUARIO` (`ncodRole`, `vnombrerole`) VALUES
(1, 'Superusuario'),
(2, 'Administrador'),
(3, 'vendedor');

-- --------------------------------------------------------

--
-- Table structure for table `MaUSUARIO`
--

CREATE TABLE IF NOT EXISTS `MaUSUARIO` (
  `ncodUsuario` int(11) NOT NULL,
  `vnombreUsuario` varchar(30) NOT NULL,
  `vapellidoUsuario` varchar(30) DEFAULT NULL,
  `vemailUsuario` varchar(45) DEFAULT NULL,
  `vusuario` varchar(25) NOT NULL,
  `vpassword` varchar(200) NOT NULL
) ENGINE=MyISAM AUTO_INCREMENT=4 DEFAULT CHARSET=latin1;

--
-- Dumping data for table `MaUSUARIO`
--

INSERT INTO `MaUSUARIO` (`ncodUsuario`, `vnombreUsuario`, `vapellidoUsuario`, `vemailUsuario`, `vusuario`, `vpassword`) VALUES
(1, 'root', 'root', 'root@root.com', 'Superusuario', 'dc76e9f0c0006e8f919e0c515c66dbba3982f785'),
(2, 'Administrador', 'Admin', '----', 'Administrador', '4e7afebcfbae000b22c7c85e5560f89a2a0280b4'),
(3, 'hector', 'cardona', '--', 'hcardona', '81bce1f3bf343c464685d875c626820cdb58e309');

-- --------------------------------------------------------

--
-- Table structure for table `TrROLETOAPLICACION`
--

CREATE TABLE IF NOT EXISTS `TrROLETOAPLICACION` (
  `ncodRole` int(11) NOT NULL,
  `ncodAplicacion` int(11) NOT NULL,
  `btnimprimir` tinyint(1) DEFAULT NULL,
  `btnnuevo` tinyint(1) DEFAULT NULL,
  `btnirUltimo` tinyint(1) DEFAULT NULL,
  `btnirPrimero` tinyint(1) DEFAULT NULL,
  `btnanterior` tinyint(1) DEFAULT NULL,
  `btnsiguiente` tinyint(1) DEFAULT NULL,
  `btneditar` tinyint(1) DEFAULT NULL,
  `btncancelar` tinyint(1) DEFAULT NULL,
  `btnrefrescar` tinyint(1) DEFAULT NULL,
  `btnbuscar` tinyint(1) DEFAULT NULL,
  `btneliminar` tinyint(1) DEFAULT NULL,
  `btnguardar` tinyint(1) DEFAULT NULL
) ENGINE=MyISAM DEFAULT CHARSET=latin1;

--
-- Dumping data for table `TrROLETOAPLICACION`
--

INSERT INTO `TrROLETOAPLICACION` (`ncodRole`, `ncodAplicacion`, `btnimprimir`, `btnnuevo`, `btnirUltimo`, `btnirPrimero`, `btnanterior`, `btnsiguiente`, `btneditar`, `btncancelar`, `btnrefrescar`, `btnbuscar`, `btneliminar`, `btnguardar`) VALUES
(3, 14, 0, 1, 0, 0, 0, 0, 1, 0, 0, 0, 1, 0),
(3, 11, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0),
(2, 8, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0);

-- --------------------------------------------------------

--
-- Table structure for table `TrUSUARIOTOAPLICACION`
--

CREATE TABLE IF NOT EXISTS `TrUSUARIOTOAPLICACION` (
  `ncodUsuario` int(11) NOT NULL,
  `ncodAplicacion` int(11) NOT NULL,
  `btnimprimir` tinyint(1) NOT NULL,
  `btnnuevo` tinyint(1) DEFAULT NULL,
  `btnirUltimo` tinyint(1) DEFAULT NULL,
  `btnirPrimero` tinyint(1) DEFAULT NULL,
  `btnanterior` tinyint(1) DEFAULT NULL,
  `btnsiguiente` tinyint(1) DEFAULT NULL,
  `btneditar` tinyint(1) DEFAULT NULL,
  `btncancelar` tinyint(1) DEFAULT NULL,
  `btnrefrescar` tinyint(1) DEFAULT NULL,
  `btnbuscar` tinyint(1) DEFAULT NULL,
  `btneliminar` tinyint(1) DEFAULT NULL,
  `btnguardar` tinyint(1) DEFAULT NULL
) ENGINE=MyISAM DEFAULT CHARSET=latin1;

--
-- Dumping data for table `TrUSUARIOTOAPLICACION`
--

INSERT INTO `TrUSUARIOTOAPLICACION` (`ncodUsuario`, `ncodAplicacion`, `btnimprimir`, `btnnuevo`, `btnirUltimo`, `btnirPrimero`, `btnanterior`, `btnsiguiente`, `btneditar`, `btncancelar`, `btnrefrescar`, `btnbuscar`, `btneliminar`, `btnguardar`) VALUES
(2, 5, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0),
(3, 14, 1, 0, 1, 1, 0, 0, 0, 0, 0, 1, 0, 0),
(3, 11, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0),
(2, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0);

-- --------------------------------------------------------

--
-- Table structure for table `TrUSUARIOTOROLE`
--

CREATE TABLE IF NOT EXISTS `TrUSUARIOTOROLE` (
  `ncodUsuario` int(11) NOT NULL,
  `ncodRole` int(11) NOT NULL
) ENGINE=MyISAM DEFAULT CHARSET=latin1;

--
-- Dumping data for table `TrUSUARIOTOROLE`
--

INSERT INTO `TrUSUARIOTOROLE` (`ncodUsuario`, `ncodRole`) VALUES
(3, 3),
(1, 1),
(2, 2);

--
-- Indexes for dumped tables
--

--
-- Indexes for table `MaACCIONES`
--
ALTER TABLE `MaACCIONES`
  ADD PRIMARY KEY (`ncodAccion`);

--
-- Indexes for table `MaAPLICACION`
--
ALTER TABLE `MaAPLICACION`
  ADD PRIMARY KEY (`ncodAplicacion`),
  ADD KEY `RefMaMODULO81` (`ncodModulo`);

--
-- Indexes for table `MaBITACORA`
--
ALTER TABLE `MaBITACORA`
  ADD PRIMARY KEY (`ncodBitacora`),
  ADD KEY `RefMaACCIONES61` (`ncodAccion`),
  ADD KEY `RefMaUSUARIO71` (`ncodUsuario`),
  ADD KEY `RefMaAPLICACION91` (`ncodAplicacion`);

--
-- Indexes for table `MaERROR`
--
ALTER TABLE `MaERROR`
  ADD PRIMARY KEY (`ncodError`),
  ADD KEY `RefMaTIPOERROR31` (`ncodAccion`),
  ADD KEY `RefMaUSUARIO41` (`ncodUsuario`),
  ADD KEY `RefMaACCIONES51` (`vaccion`),
  ADD KEY `RefMaAPLICACION101` (`ncodAplicacion`);

--
-- Indexes for table `MaMODULO`
--
ALTER TABLE `MaMODULO`
  ADD PRIMARY KEY (`ncodModulo`);

--
-- Indexes for table `MaROLUSUARIO`
--
ALTER TABLE `MaROLUSUARIO`
  ADD PRIMARY KEY (`ncodRole`);

--
-- Indexes for table `MaUSUARIO`
--
ALTER TABLE `MaUSUARIO`
  ADD PRIMARY KEY (`ncodUsuario`);

--
-- Indexes for table `TrROLETOAPLICACION`
--
ALTER TABLE `TrROLETOAPLICACION`
  ADD KEY `RefMaROLUSUARIO161` (`ncodRole`),
  ADD KEY `RefMaAPLICACION181` (`ncodAplicacion`);

--
-- Indexes for table `TrUSUARIOTOAPLICACION`
--
ALTER TABLE `TrUSUARIOTOAPLICACION`
  ADD KEY `RefMaUSUARIO111` (`ncodUsuario`),
  ADD KEY `RefMaAPLICACION121` (`ncodAplicacion`);

--
-- Indexes for table `TrUSUARIOTOROLE`
--
ALTER TABLE `TrUSUARIOTOROLE`
  ADD KEY `RefMaUSUARIO131` (`ncodUsuario`),
  ADD KEY `RefMaROLUSUARIO141` (`ncodRole`);

--
-- AUTO_INCREMENT for dumped tables
--

--
-- AUTO_INCREMENT for table `MaACCIONES`
--
ALTER TABLE `MaACCIONES`
  MODIFY `ncodAccion` int(11) NOT NULL AUTO_INCREMENT,AUTO_INCREMENT=8;
--
-- AUTO_INCREMENT for table `MaAPLICACION`
--
ALTER TABLE `MaAPLICACION`
  MODIFY `ncodAplicacion` int(11) NOT NULL AUTO_INCREMENT,AUTO_INCREMENT=15;
--
-- AUTO_INCREMENT for table `MaBITACORA`
--
ALTER TABLE `MaBITACORA`
  MODIFY `ncodBitacora` int(11) NOT NULL AUTO_INCREMENT,AUTO_INCREMENT=83;
--
-- AUTO_INCREMENT for table `MaERROR`
--
ALTER TABLE `MaERROR`
  MODIFY `ncodError` int(11) NOT NULL AUTO_INCREMENT,AUTO_INCREMENT=5;
--
-- AUTO_INCREMENT for table `MaMODULO`
--
ALTER TABLE `MaMODULO`
  MODIFY `ncodModulo` int(11) NOT NULL AUTO_INCREMENT,AUTO_INCREMENT=3;
--
-- AUTO_INCREMENT for table `MaROLUSUARIO`
--
ALTER TABLE `MaROLUSUARIO`
  MODIFY `ncodRole` int(11) NOT NULL AUTO_INCREMENT,AUTO_INCREMENT=4;
--
-- AUTO_INCREMENT for table `MaUSUARIO`
--
ALTER TABLE `MaUSUARIO`
  MODIFY `ncodUsuario` int(11) NOT NULL AUTO_INCREMENT,AUTO_INCREMENT=4;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
