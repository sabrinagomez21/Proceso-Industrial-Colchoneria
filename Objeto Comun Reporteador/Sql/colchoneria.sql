-- phpMyAdmin SQL Dump
-- version 4.4.14
-- http://www.phpmyadmin.net
--
-- Servidor: 127.0.0.1
-- Tiempo de generación: 05-11-2015 a las 05:30:52
-- Versión del servidor: 5.6.26-log
-- Versión de PHP: 5.6.12

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Base de datos: `colchoneria`
--
CREATE DATABASE IF NOT EXISTS `colchoneria` DEFAULT CHARACTER SET utf8 COLLATE utf8_general_ci;
USE `colchoneria`;

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `clientes`
--

CREATE TABLE IF NOT EXISTS `clientes` (
  `cod_cliente` int(11) NOT NULL,
  `nombre` varchar(40) DEFAULT NULL,
  `apellido` varchar(40) DEFAULT NULL,
  `direccion` varchar(40) DEFAULT NULL
) ENGINE=InnoDB AUTO_INCREMENT=8 DEFAULT CHARSET=latin1;

--
-- Volcado de datos para la tabla `clientes`
--

INSERT INTO `clientes` (`cod_cliente`, `nombre`, `apellido`, `direccion`) VALUES
(1, 'david', 'barrios', 'guatemala'),
(2, 'denys', 'choy', 'guatemala'),
(3, 'enrique', 'arredondo', 'guatemala'),
(4, 'ricardo ', 'von-raynts', 'guatemala'),
(5, 'cristhiam', 'duarte', 'guatemala'),
(6, 'josue', 'duarte', 'guatemala'),
(7, 'prueba', 'final', NULL);

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `dt_inventario`
--

CREATE TABLE IF NOT EXISTS `dt_inventario` (
  `id` int(11) NOT NULL,
  `orden` char(20) NOT NULL,
  `producto` char(20) NOT NULL,
  `cantidad` char(20) NOT NULL,
  `tipo` char(20) NOT NULL
) ENGINE=InnoDB AUTO_INCREMENT=11 DEFAULT CHARSET=utf8;

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `inventario`
--

CREATE TABLE IF NOT EXISTS `inventario` (
  `producto` char(40) NOT NULL,
  `cantidad` varchar(45) NOT NULL,
  `Descripcion` varchar(45) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Volcado de datos para la tabla `inventario`
--

INSERT INTO `inventario` (`producto`, `cantidad`, `Descripcion`) VALUES
('algodon', '110', 'Algodon para colchon'),
('Esponja', '140', 'Esponja para cama'),
('esponja espacial', '300', 'esponja con memoria'),
('Nylon', '100', 'Recubrimiento de Camas'),
('Resortes', '400', 'Resortes para Camas'),
('Tablas', '200', 'Madera para madera'),
('Tela', '100', 'Tela cobertora');

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `mausuario`
--

CREATE TABLE IF NOT EXISTS `mausuario` (
  `ncodusuario` int(11) NOT NULL,
  `vnombreusuario` varchar(30) DEFAULT NULL,
  `vapellidousuario` varchar(30) DEFAULT NULL,
  `vemailusuario` varchar(45) DEFAULT NULL,
  `vusuario` varchar(25) NOT NULL,
  `vpassword` varchar(200) NOT NULL,
  `ncodgrafica` int(11) NOT NULL
) ENGINE=InnoDB AUTO_INCREMENT=3 DEFAULT CHARSET=utf8;

--
-- Volcado de datos para la tabla `mausuario`
--

INSERT INTO `mausuario` (`ncodusuario`, `vnombreusuario`, `vapellidousuario`, `vemailusuario`, `vusuario`, `vpassword`, `ncodgrafica`) VALUES
(1, 'cristhiam', 'duarte', '@hotmail.com', 'criss', '12345', 1),
(2, 'josue', 'duarte', '@gmail.com', 'josdua', '12345', 1);

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `productos`
--

CREATE TABLE IF NOT EXISTS `productos` (
  `cod_producto` int(11) NOT NULL,
  `nombre` varchar(25) DEFAULT NULL,
  `descripcion` varchar(25) DEFAULT NULL,
  `cantidad` int(11) DEFAULT NULL
) ENGINE=InnoDB AUTO_INCREMENT=3 DEFAULT CHARSET=latin1;

--
-- Volcado de datos para la tabla `productos`
--

INSERT INTO `productos` (`cod_producto`, `nombre`, `descripcion`, `cantidad`) VALUES
(1, 'Colchon', NULL, 10),
(2, 'almohada', NULL, 15);

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `trreporte`
--

CREATE TABLE IF NOT EXISTS `trreporte` (
  `vnomreporte` varchar(100) NOT NULL,
  `dfechareporte` varchar(45) DEFAULT NULL,
  `ncodaplicacion` int(100) NOT NULL,
  `ncodmodulo` int(11) NOT NULL,
  `ncodusuario` int(45) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Volcado de datos para la tabla `trreporte`
--

INSERT INTO `trreporte` (`vnomreporte`, `dfechareporte`, `ncodaplicacion`, `ncodmodulo`, `ncodusuario`) VALUES
('clientes', '04/11/2015 21:33:18', 1, 1, 1),
('productos', '04/11/2015 21:32:58', 1, 1, 1),
('prueba', '04/11/2015 21:33:27', 1, 1, 1);

--
-- Índices para tablas volcadas
--

--
-- Indices de la tabla `clientes`
--
ALTER TABLE `clientes`
  ADD PRIMARY KEY (`cod_cliente`);

--
-- Indices de la tabla `dt_inventario`
--
ALTER TABLE `dt_inventario`
  ADD PRIMARY KEY (`id`);

--
-- Indices de la tabla `inventario`
--
ALTER TABLE `inventario`
  ADD PRIMARY KEY (`producto`);

--
-- Indices de la tabla `mausuario`
--
ALTER TABLE `mausuario`
  ADD PRIMARY KEY (`ncodusuario`);

--
-- Indices de la tabla `productos`
--
ALTER TABLE `productos`
  ADD PRIMARY KEY (`cod_producto`);

--
-- Indices de la tabla `trreporte`
--
ALTER TABLE `trreporte`
  ADD PRIMARY KEY (`vnomreporte`);

--
-- AUTO_INCREMENT de las tablas volcadas
--

--
-- AUTO_INCREMENT de la tabla `clientes`
--
ALTER TABLE `clientes`
  MODIFY `cod_cliente` int(11) NOT NULL AUTO_INCREMENT,AUTO_INCREMENT=8;
--
-- AUTO_INCREMENT de la tabla `dt_inventario`
--
ALTER TABLE `dt_inventario`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT,AUTO_INCREMENT=11;
--
-- AUTO_INCREMENT de la tabla `mausuario`
--
ALTER TABLE `mausuario`
  MODIFY `ncodusuario` int(11) NOT NULL AUTO_INCREMENT,AUTO_INCREMENT=3;
--
-- AUTO_INCREMENT de la tabla `productos`
--
ALTER TABLE `productos`
  MODIFY `cod_producto` int(11) NOT NULL AUTO_INCREMENT,AUTO_INCREMENT=3;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
