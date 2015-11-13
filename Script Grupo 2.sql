-- phpMyAdmin SQL Dump
-- version 4.4.12
-- http://www.phpmyadmin.net
--
-- Servidor: 127.0.0.1
-- Tiempo de generación: 13-11-2015 a las 19:11:54
-- Versión del servidor: 5.6.25
-- Versión de PHP: 5.6.11

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Base de datos: `colchoneria`
--

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `mafacturacobro`
--

CREATE TABLE IF NOT EXISTS `mafacturacobro` (
  `ncodfactura` int(11) NOT NULL,
  `nnofactura` decimal(10,0) DEFAULT NULL,
  `dfecha` date DEFAULT NULL,
  `dfechaexpiracion` date DEFAULT NULL,
  `ntotal` decimal(18,2) DEFAULT NULL,
  `cestado` char(25) DEFAULT NULL,
  `cpagado` char(25) DEFAULT NULL,
  `ncodcliente` int(11) DEFAULT NULL
) ENGINE=MyISAM AUTO_INCREMENT=6 DEFAULT CHARSET=latin1;

--
-- Volcado de datos para la tabla `mafacturacobro`
--

INSERT INTO `mafacturacobro` (`ncodfactura`, `nnofactura`, `dfecha`, `dfechaexpiracion`, `ntotal`, `cestado`, `cpagado`, `ncodcliente`) VALUES
(1, '1', '2015-11-12', '2015-11-20', '10.00', 'ACTIVO', 'SI', 2),
(2, '2', '2015-11-12', '2015-11-17', '100.00', 'ACTIVO', 'SI', 4),
(3, '2', '2015-11-12', '2015-10-29', '1.00', 'INACTIVO', 'NO', 2),
(4, '156', '2015-11-13', '2015-11-26', '100.00', 'ACTIVO', 'NO', 2),
(5, '1238', '2015-11-13', '2015-11-25', '100.00', 'ACTIVO', 'NO', 4);

--
-- Índices para tablas volcadas
--

--
-- Indices de la tabla `mafacturacobro`
--
ALTER TABLE `mafacturacobro`
  ADD PRIMARY KEY (`ncodfactura`),
  ADD KEY `RefMaCLIENTECOBRO119` (`ncodcliente`);

--
-- AUTO_INCREMENT de las tablas volcadas
--

--
-- AUTO_INCREMENT de la tabla `mafacturacobro`
--
ALTER TABLE `mafacturacobro`
  MODIFY `ncodfactura` int(11) NOT NULL AUTO_INCREMENT,AUTO_INCREMENT=6;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
