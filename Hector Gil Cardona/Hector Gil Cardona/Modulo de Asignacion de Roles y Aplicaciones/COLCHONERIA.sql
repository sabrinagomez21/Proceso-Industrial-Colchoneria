-- phpMyAdmin SQL Dump
-- version 4.4.14
-- http://www.phpmyadmin.net
--
-- Host: 127.0.0.1
-- Generation Time: Oct 25, 2015 at 02:53 AM
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
  `iidAccion` int(11) NOT NULL,
  `vnombreAccion` varchar(40) DEFAULT NULL
) ENGINE=MyISAM DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Table structure for table `MaAPLICACION`
--

CREATE TABLE IF NOT EXISTS `MaAPLICACION` (
  `iidAplicacion` int(11) NOT NULL,
  `vnombreAplicacion` varchar(40) DEFAULT NULL,
  `iidModulo` int(11) NOT NULL
) ENGINE=MyISAM AUTO_INCREMENT=5 DEFAULT CHARSET=latin1;

--
-- Dumping data for table `MaAPLICACION`
--

INSERT INTO `MaAPLICACION` (`iidAplicacion`, `vnombreAplicacion`, `iidModulo`) VALUES
(1, 'Compras', 1),
(2, 'ventas', 1),
(3, 'Contabilidad', 2),
(4, 'Ajustes', 1);

-- --------------------------------------------------------

--
-- Table structure for table `MaBITACORA`
--

CREATE TABLE IF NOT EXISTS `MaBITACORA` (
  `iidBitacora` int(11) NOT NULL,
  `vnombreEquipo` varchar(40) DEFAULT NULL,
  `vipEquipo` varchar(30) DEFAULT NULL,
  `iidUsuario` int(11) NOT NULL,
  `dhora` time DEFAULT NULL,
  `dfecha` date DEFAULT NULL,
  `iidAccion` int(11) NOT NULL,
  `vDetalleAccion` varchar(100) DEFAULT NULL,
  `iidAplicacion` int(11) NOT NULL
) ENGINE=MyISAM DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Table structure for table `MaERROR`
--

CREATE TABLE IF NOT EXISTS `MaERROR` (
  `iidError` int(11) NOT NULL,
  `dora` time DEFAULT NULL,
  `decha` date DEFAULT NULL,
  `iidAplicacion` int(11) NOT NULL,
  `iidUsuario` int(11) NOT NULL,
  `iidAccion` int(11) NOT NULL,
  `iidTipo` int(11) DEFAULT NULL
) ENGINE=MyISAM DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Table structure for table `MaMODULO`
--

CREATE TABLE IF NOT EXISTS `MaMODULO` (
  `iidModulo` int(11) NOT NULL,
  `vNombreModulo` varchar(50) DEFAULT NULL
) ENGINE=MyISAM DEFAULT CHARSET=latin1;

--
-- Dumping data for table `MaMODULO`
--

INSERT INTO `MaMODULO` (`iidModulo`, `vNombreModulo`) VALUES
(1, 'Archivo'),
(2, 'Prueba');

-- --------------------------------------------------------

--
-- Table structure for table `MaROLUSUARIO`
--

CREATE TABLE IF NOT EXISTS `MaROLUSUARIO` (
  `iidRole` int(11) NOT NULL,
  `vnombreRole` varchar(30) DEFAULT NULL
) ENGINE=MyISAM AUTO_INCREMENT=5 DEFAULT CHARSET=latin1;

--
-- Dumping data for table `MaROLUSUARIO`
--

INSERT INTO `MaROLUSUARIO` (`iidRole`, `vnombreRole`) VALUES
(1, 'admin'),
(2, 'prueba'),
(3, 'preuba2');

-- --------------------------------------------------------

--
-- Table structure for table `MaTIPOERROR`
--

CREATE TABLE IF NOT EXISTS `MaTIPOERROR` (
  `iidTipo` int(11) NOT NULL,
  `vnombre` varchar(40) DEFAULT NULL
) ENGINE=MyISAM DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Table structure for table `MaUSUARIO`
--

CREATE TABLE IF NOT EXISTS `MaUSUARIO` (
  `iidUsuario` int(11) NOT NULL,
  `vnombreUsuario` varchar(30) DEFAULT NULL,
  `vapellidoUsuario` varchar(50) DEFAULT NULL,
  `vemailUsuario` varchar(30) DEFAULT NULL,
  `vusuario` varchar(30) DEFAULT NULL,
  `vpassword` varchar(30) DEFAULT NULL
) ENGINE=MyISAM AUTO_INCREMENT=4 DEFAULT CHARSET=latin1;

--
-- Dumping data for table `MaUSUARIO`
--

INSERT INTO `MaUSUARIO` (`iidUsuario`, `vnombreUsuario`, `vapellidoUsuario`, `vemailUsuario`, `vusuario`, `vpassword`) VALUES
(1, 'hector', 'Gil', 'joannes14@hotmail.com', 'hector', 'viento');

-- --------------------------------------------------------

--
-- Table structure for table `TrROLETOAPLICACION`
--

CREATE TABLE IF NOT EXISTS `TrROLETOAPLICACION` (
  `iidRole` int(11) NOT NULL,
  `iidAplicacion` int(11) NOT NULL,
  `bbotonNuevo` tinyint(1) NOT NULL,
  `bbotonEditar` tinyint(1) NOT NULL,
  `bbotonEliminar` tinyint(1) NOT NULL,
  `bbotonInsertar` tinyint(1) NOT NULL,
  `bbotonCancelar` tinyint(1) NOT NULL,
  `bbotonActualizar` tinyint(1) NOT NULL,
  `bbotonImprimir` tinyint(1) NOT NULL,
  `bbotonBuscar` tinyint(1) NOT NULL,
  `bbotonPrimerReg` tinyint(1) NOT NULL,
  `bbotonAnteriorReg` tinyint(1) NOT NULL,
  `bbotonSigReg` tinyint(1) NOT NULL,
  `bbotonUltimoReg` tinyint(1) NOT NULL
) ENGINE=MyISAM DEFAULT CHARSET=latin1;

--
-- Dumping data for table `TrROLETOAPLICACION`
--

INSERT INTO `TrROLETOAPLICACION` (`iidRole`, `iidAplicacion`, `bbotonNuevo`, `bbotonEditar`, `bbotonEliminar`, `bbotonInsertar`, `bbotonCancelar`, `bbotonActualizar`, `bbotonImprimir`, `bbotonBuscar`, `bbotonPrimerReg`, `bbotonAnteriorReg`, `bbotonSigReg`, `bbotonUltimoReg`) VALUES
(2, 1, 0, 0, 0, 0, 1, 0, 0, 1, 0, 0, 0, 0),
(3, 3, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0),
(3, 1, 1, 0, 0, 0, 0, 0, 1, 0, 0, 0, 0, 0),
(1, 1, 1, 1, 1, 1, 1, 1, 0, 0, 0, 0, 0, 0);

-- --------------------------------------------------------

--
-- Table structure for table `TrUSUARIOTOAPLICACION`
--

CREATE TABLE IF NOT EXISTS `TrUSUARIOTOAPLICACION` (
  `iidUsuario` int(11) NOT NULL,
  `iidAplicacion` int(11) NOT NULL,
  `bbotonNuevo` tinyint(1) NOT NULL,
  `bbotonInsertar` tinyint(1) NOT NULL,
  `bbotonEliminar` tinyint(1) NOT NULL,
  `bbotonEditar` tinyint(1) NOT NULL,
  `bbotonBuscar` tinyint(1) NOT NULL,
  `bbotonCancelar` tinyint(1) NOT NULL,
  `bbotonActualizar` tinyint(1) NOT NULL,
  `bbotonImprimir` tinyint(1) NOT NULL,
  `bbotonPrimerReg` tinyint(1) NOT NULL,
  `bbotonAnteriorReg` tinyint(1) NOT NULL,
  `bbotonSigReg` tinyint(1) NOT NULL,
  `bbotonUltimoReg` tinyint(1) NOT NULL
) ENGINE=MyISAM DEFAULT CHARSET=latin1;

--
-- Dumping data for table `TrUSUARIOTOAPLICACION`
--

INSERT INTO `TrUSUARIOTOAPLICACION` (`iidUsuario`, `iidAplicacion`, `bbotonNuevo`, `bbotonInsertar`, `bbotonEliminar`, `bbotonEditar`, `bbotonBuscar`, `bbotonCancelar`, `bbotonActualizar`, `bbotonImprimir`, `bbotonPrimerReg`, `bbotonAnteriorReg`, `bbotonSigReg`, `bbotonUltimoReg`) VALUES
(1, 2, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0);

-- --------------------------------------------------------

--
-- Table structure for table `TrUSUARIOTOROLE`
--

CREATE TABLE IF NOT EXISTS `TrUSUARIOTOROLE` (
  `iidRole` int(11) NOT NULL,
  `iidUsuario` int(11) NOT NULL
) ENGINE=MyISAM DEFAULT CHARSET=latin1;

--
-- Dumping data for table `TrUSUARIOTOROLE`
--

INSERT INTO `TrUSUARIOTOROLE` (`iidRole`, `iidUsuario`) VALUES
(1, 1);

--
-- Indexes for dumped tables
--

--
-- Indexes for table `MaACCIONES`
--
ALTER TABLE `MaACCIONES`
  ADD PRIMARY KEY (`iidAccion`);

--
-- Indexes for table `MaAPLICACION`
--
ALTER TABLE `MaAPLICACION`
  ADD PRIMARY KEY (`iidAplicacion`),
  ADD KEY `Ref1220` (`iidModulo`);

--
-- Indexes for table `MaBITACORA`
--
ALTER TABLE `MaBITACORA`
  ADD PRIMARY KEY (`iidBitacora`),
  ADD KEY `Ref110` (`iidUsuario`),
  ADD KEY `Ref811` (`iidAccion`),
  ADD KEY `Ref412` (`iidAplicacion`);

--
-- Indexes for table `MaERROR`
--
ALTER TABLE `MaERROR`
  ADD PRIMARY KEY (`iidError`),
  ADD KEY `Ref414` (`iidAplicacion`),
  ADD KEY `Ref115` (`iidUsuario`),
  ADD KEY `Ref816` (`iidAccion`),
  ADD KEY `Ref1118` (`iidTipo`);

--
-- Indexes for table `MaMODULO`
--
ALTER TABLE `MaMODULO`
  ADD PRIMARY KEY (`iidModulo`);

--
-- Indexes for table `MaROLUSUARIO`
--
ALTER TABLE `MaROLUSUARIO`
  ADD PRIMARY KEY (`iidRole`);

--
-- Indexes for table `MaTIPOERROR`
--
ALTER TABLE `MaTIPOERROR`
  ADD PRIMARY KEY (`iidTipo`);

--
-- Indexes for table `MaUSUARIO`
--
ALTER TABLE `MaUSUARIO`
  ADD PRIMARY KEY (`iidUsuario`);

--
-- Indexes for table `TrROLETOAPLICACION`
--
ALTER TABLE `TrROLETOAPLICACION`
  ADD KEY `Ref23` (`iidRole`),
  ADD KEY `Ref44` (`iidAplicacion`);

--
-- Indexes for table `TrUSUARIOTOAPLICACION`
--
ALTER TABLE `TrUSUARIOTOAPLICACION`
  ADD KEY `Ref17` (`iidUsuario`),
  ADD KEY `Ref48` (`iidAplicacion`);

--
-- Indexes for table `TrUSUARIOTOROLE`
--
ALTER TABLE `TrUSUARIOTOROLE`
  ADD KEY `Ref25` (`iidRole`),
  ADD KEY `Ref16` (`iidUsuario`);

--
-- AUTO_INCREMENT for dumped tables
--

--
-- AUTO_INCREMENT for table `MaAPLICACION`
--
ALTER TABLE `MaAPLICACION`
  MODIFY `iidAplicacion` int(11) NOT NULL AUTO_INCREMENT,AUTO_INCREMENT=5;
--
-- AUTO_INCREMENT for table `MaROLUSUARIO`
--
ALTER TABLE `MaROLUSUARIO`
  MODIFY `iidRole` int(11) NOT NULL AUTO_INCREMENT,AUTO_INCREMENT=5;
--
-- AUTO_INCREMENT for table `MaUSUARIO`
--
ALTER TABLE `MaUSUARIO`
  MODIFY `iidUsuario` int(11) NOT NULL AUTO_INCREMENT,AUTO_INCREMENT=4;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
