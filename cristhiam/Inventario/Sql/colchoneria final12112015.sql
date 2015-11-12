-- phpMyAdmin SQL Dump
-- version 4.4.14
-- http://www.phpmyadmin.net
--
-- Servidor: 127.0.0.1
-- Tiempo de generación: 12-11-2015 a las 09:43:54
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

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `maacciones`
--

CREATE TABLE IF NOT EXISTS `maacciones` (
  `ncodaccion` int(11) NOT NULL,
  `vnombreaccion` varchar(40) DEFAULT NULL
) ENGINE=MyISAM AUTO_INCREMENT=8 DEFAULT CHARSET=latin1;

--
-- Volcado de datos para la tabla `maacciones`
--

INSERT INTO `maacciones` (`ncodaccion`, `vnombreaccion`) VALUES
(1, 'Loggin'),
(2, 'Insercion'),
(3, 'Buscar'),
(4, 'Eliminacion'),
(5, 'Actualizacion'),
(6, 'Reportes'),
(7, 'Graficas');

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `maaplicacion`
--

CREATE TABLE IF NOT EXISTS `maaplicacion` (
  `ncodaplicacion` int(11) NOT NULL,
  `vnombreaplicacion` varchar(30) DEFAULT NULL,
  `ncodmodulo` int(11) NOT NULL,
  `vnombreformulario` varchar(40) DEFAULT NULL
) ENGINE=MyISAM AUTO_INCREMENT=17 DEFAULT CHARSET=latin1;

--
-- Volcado de datos para la tabla `maaplicacion`
--

INSERT INTO `maaplicacion` (`ncodaplicacion`, `vnombreaplicacion`, `ncodmodulo`, `vnombreformulario`) VALUES
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
(15, 'Proveedores', 2, 'frmproveedores'),
(16, 'pagos', 3, 'frmproveedores');

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `mabanco`
--

CREATE TABLE IF NOT EXISTS `mabanco` (
  `ncodbanco` int(11) NOT NULL,
  `vnombrebanco` varchar(18) DEFAULT NULL,
  `vdireccion` varchar(30) DEFAULT NULL,
  `cestado` char(20) DEFAULT NULL
) ENGINE=MyISAM DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `mabitacora`
--

CREATE TABLE IF NOT EXISTS `mabitacora` (
  `ncodbitacora` int(11) NOT NULL,
  `vnombreequipo` varchar(25) DEFAULT NULL,
  `vipequipo` varchar(20) DEFAULT NULL,
  `dhora` time DEFAULT NULL,
  `dfecha` date DEFAULT NULL,
  `vdetalleaccion` varchar(100) DEFAULT NULL,
  `ncodaccion` int(11) NOT NULL,
  `ncodusuario` int(11) NOT NULL,
  `ncodaplicacion` int(11) NOT NULL
) ENGINE=MyISAM AUTO_INCREMENT=150 DEFAULT CHARSET=latin1;

--
-- Volcado de datos para la tabla `mabitacora`
--

INSERT INTO `mabitacora` (`ncodbitacora`, `vnombreequipo`, `vipequipo`, `dhora`, `dfecha`, `vdetalleaccion`, `ncodaccion`, `ncodusuario`, `ncodaplicacion`) VALUES
(1, 'MELVIN', '10.1.85.243', '13:00:05', '2015-11-09', 'Ingreso al sistema', 1, 3, 1),
(2, 'MELVIN', '10.1.85.243', '13:00:24', '2015-11-09', 'Ingreso al sistema', 1, 1, 1),
(3, 'MELVIN', '10.1.85.243', '13:06:12', '2015-11-09', 'Ingreso al sistema', 1, 3, 1),
(4, 'MELVIN', '192.168.0.106', '23:07:19', '2015-11-09', 'Ingreso al sistema', 1, 3, 1),
(5, 'MELVIN', '192.168.0.106', '23:09:45', '2015-11-09', 'Ingreso al sistema', 1, 3, 1),
(6, 'MELVIN', '192.168.0.106', '23:14:31', '2015-11-09', 'Ingreso al sistema', 1, 3, 1),
(7, 'MELVIN', '192.168.0.106', '23:36:04', '2015-11-09', 'Ingreso al sistema', 1, 3, 1),
(8, 'MELVIN', '192.168.0.106', '23:41:46', '2015-11-09', 'Ingreso al sistema', 1, 3, 1),
(9, 'MELVIN', '192.168.0.106', '00:17:24', '2015-11-10', 'Ingreso al sistema', 1, 3, 1),
(10, 'MELVIN', '192.168.0.106', '00:21:04', '2015-11-10', 'Ingreso al sistema', 1, 3, 1),
(11, 'MELVIN', '192.168.0.106', '00:29:19', '2015-11-10', 'Ingreso al sistema', 1, 3, 1),
(12, 'MELVIN', '192.168.0.106', '00:35:37', '2015-11-10', 'Ingreso al sistema', 1, 3, 1),
(13, 'MELVIN', '192.168.0.106', '00:39:17', '2015-11-10', 'Ingreso al sistema', 1, 3, 1),
(14, 'MELVIN', '192.168.0.106', '00:44:32', '2015-11-10', 'Ingreso al sistema', 1, 3, 1),
(15, 'MELVIN', '192.168.0.106', '00:56:11', '2015-11-10', 'Ingreso al sistema', 1, 3, 1),
(16, 'MELVIN', '192.168.0.106', '01:01:27', '2015-11-10', 'Ingreso al sistema', 1, 3, 1),
(17, 'MELVIN', '192.168.0.103', '08:07:36', '2015-11-10', 'Ingreso al sistema', 1, 3, 1),
(18, 'MELVIN', '192.168.0.103', '08:10:56', '2015-11-10', 'Ingreso al sistema', 1, 3, 1),
(19, 'MELVIN', '192.168.0.103', '08:14:41', '2015-11-10', 'Ingreso al sistema', 1, 3, 1),
(20, 'MELVIN', '192.168.0.103', '08:16:44', '2015-11-10', 'Ingreso al sistema', 1, 3, 1),
(21, 'MELVIN', '192.168.0.103', '08:33:07', '2015-11-10', 'Ingreso al sistema', 1, 3, 1),
(22, 'MELVIN', '10.1.93.156', '08:59:22', '2015-11-10', 'Ingreso al sistema', 1, 3, 1),
(23, 'MELVIN', '10.1.93.156', '09:01:56', '2015-11-10', 'Ingreso al sistema', 1, 1, 1),
(24, 'MELVIN', '10.1.93.156', '09:02:40', '2015-11-10', 'Ingreso al sistema', 1, 1, 1),
(25, 'MELVIN', '10.1.93.156', '09:03:35', '2015-11-10', 'Ingreso al sistema', 1, 1, 1),
(26, 'MELVIN', '10.1.93.156', '09:06:16', '2015-11-10', 'Ingreso al sistema', 1, 1, 1),
(27, 'MELVIN', '10.1.93.156', '09:08:58', '2015-11-10', 'Ingreso al sistema', 1, 1, 1),
(28, 'MELVIN', '10.1.93.156', '09:25:13', '2015-11-10', 'Ingreso al sistema', 1, 1, 1),
(29, 'MELVIN', '10.1.93.156', '09:26:02', '2015-11-10', 'Ingreso al sistema', 1, 4, 1),
(30, 'MELVIN', '10.1.93.156', '09:26:45', '2015-11-10', 'Ingreso al sistema', 1, 1, 1),
(31, 'MELVIN', '10.1.93.156', '09:28:11', '2015-11-10', 'Ingreso al sistema', 1, 4, 1),
(32, 'MELVIN', '10.1.93.156', '09:29:05', '2015-11-10', 'Ingreso al sistema', 1, 1, 1),
(33, 'MELVIN', '10.1.93.156', '09:31:36', '2015-11-10', 'Ingreso al sistema', 1, 1, 1),
(34, 'MELVIN', '10.1.93.156', '09:38:05', '2015-11-10', 'Ingreso al sistema', 1, 3, 1),
(35, 'MELVIN', '10.1.93.156', '09:40:18', '2015-11-10', 'Ingreso al sistema', 1, 1, 1),
(36, 'CRISS', '192.168.0.8', '20:55:30', '2015-11-10', 'Ingreso al sistema', 1, 1, 1),
(37, 'CRISS', '192.168.0.8', '22:22:11', '2015-11-10', 'Ingreso al sistema', 1, 1, 1),
(38, 'CRISS', '192.168.0.8', '22:24:12', '2015-11-10', 'Ingreso al sistema', 1, 1, 1),
(39, 'CRISS', '192.168.0.8', '22:47:47', '2015-11-10', 'Ingreso al sistema', 1, 1, 1),
(40, 'CRISS', '192.168.0.8', '23:03:31', '2015-11-10', 'Ingreso al sistema', 1, 1, 1),
(41, 'CRISS', '192.168.0.8', '23:08:32', '2015-11-10', 'Ingreso al sistema', 1, 1, 1),
(42, 'CRISS', '192.168.0.8', '23:11:17', '2015-11-10', 'Ingreso al sistema', 1, 1, 1),
(43, 'CRISS', '192.168.0.8', '23:12:52', '2015-11-10', 'Ingreso al sistema', 1, 3, 1),
(44, 'CRISS', '192.168.0.8', '23:14:13', '2015-11-10', 'Ingreso al sistema', 1, 3, 1),
(45, 'CRISS', '192.168.0.8', '23:23:27', '2015-11-10', 'Ingreso al sistema', 1, 1, 1),
(46, 'CRISS', '192.168.0.8', '23:25:02', '2015-11-10', 'Ingreso al sistema', 1, 5, 1),
(47, 'CRISS', '192.168.0.8', '23:37:05', '2015-11-10', 'Ingreso al sistema', 1, 1, 1),
(48, 'CRISS', '192.168.0.8', '23:40:44', '2015-11-10', 'Ingreso al sistema', 1, 5, 1),
(49, 'CRISS', '192.168.0.8', '23:41:56', '2015-11-10', 'Ingreso al sistema', 1, 5, 1),
(50, 'CRISS', '192.168.0.8', '23:44:35', '2015-11-10', 'Ingreso al sistema', 1, 3, 1),
(51, 'CRISS', '192.168.0.8', '23:44:44', '2015-11-10', 'Ingreso al sistema', 1, 5, 1),
(52, 'CRISS', '192.168.0.8', '23:45:41', '2015-11-10', 'Ingreso al sistema', 1, 3, 1),
(53, 'CRISS', '192.168.0.8', '23:46:11', '2015-11-10', 'Ingreso al sistema', 1, 1, 1),
(54, 'CRISS', '192.168.0.8', '23:48:15', '2015-11-10', 'Ingreso al sistema', 1, 1, 1),
(55, 'CRISS', '192.168.0.8', '00:00:46', '2015-11-11', 'Ingreso al sistema', 1, 5, 1),
(56, 'CRISS', '192.168.0.8', '00:09:04', '2015-11-11', 'Ingreso al sistema', 1, 5, 1),
(57, 'CRISS', '192.168.0.8', '00:23:08', '2015-11-11', 'Ingreso al sistema', 1, 5, 1),
(58, 'CRISS', '192.168.0.8', '00:30:30', '2015-11-11', 'Ingreso al sistema', 1, 5, 1),
(59, 'CRISS', '192.168.0.8', '00:36:21', '2015-11-11', 'Ingreso al sistema', 1, 5, 1),
(60, 'CRISS', '192.168.0.8', '00:37:15', '2015-11-11', 'Ingreso al sistema', 1, 5, 1),
(61, 'CRISS', '192.168.0.8', '00:49:38', '2015-11-11', 'Ingreso al sistema', 1, 5, 1),
(62, 'CRISS', '192.168.0.8', '00:57:01', '2015-11-11', 'Ingreso al sistema', 1, 5, 1),
(63, 'CRISS', '192.168.0.8', '00:58:59', '2015-11-11', 'Ingreso al sistema', 1, 5, 1),
(64, 'CRISS', '192.168.0.8', '01:01:12', '2015-11-11', 'Ingreso al sistema', 1, 5, 1),
(65, 'CRISS', '192.168.0.8', '01:04:12', '2015-11-11', 'Ingreso al sistema', 1, 5, 1),
(66, 'CRISS', '192.168.0.8', '01:06:11', '2015-11-11', 'Ingreso al sistema', 1, 5, 1),
(67, 'CRISS', '192.168.0.8', '01:06:58', '2015-11-11', 'Ingreso al sistema', 1, 5, 1),
(68, 'CRISS', '192.168.0.8', '01:10:36', '2015-11-11', 'Ingreso al sistema', 1, 5, 1),
(69, 'CRISS', '192.168.0.8', '01:11:32', '2015-11-11', 'Ingreso al sistema', 1, 5, 1),
(70, 'CRISS', '192.168.0.8', '01:15:26', '2015-11-11', 'Ingreso al sistema', 1, 5, 1),
(71, 'CRISS', '192.168.0.8', '01:16:11', '2015-11-11', 'Ingreso al sistema', 1, 5, 1),
(72, 'CRISS', '192.168.0.8', '01:19:32', '2015-11-11', 'Ingreso al sistema', 1, 5, 1),
(73, 'CRISS', '192.168.0.8', '01:28:47', '2015-11-11', 'Ingreso al sistema', 1, 5, 1),
(74, 'CRISS', '192.168.0.8', '01:31:26', '2015-11-11', 'Ingreso al sistema', 1, 5, 1),
(75, 'CRISS', '10.1.88.11', '12:02:15', '2015-11-11', 'Ingreso al sistema', 1, 5, 1),
(76, 'CRISS', '10.1.88.11', '12:02:48', '2015-11-11', 'Ingreso al sistema', 1, 3, 1),
(77, 'CRISS', '192.168.0.8', '22:17:03', '2015-11-11', 'Ingreso al sistema', 1, 5, 1),
(78, 'CRISS', '192.168.0.8', '22:25:09', '2015-11-11', 'Ingreso al sistema', 1, 5, 1),
(79, 'CRISS', '192.168.0.8', '22:38:25', '2015-11-11', 'Ingreso al sistema', 1, 5, 1),
(80, 'CRISS', '192.168.0.8', '22:40:12', '2015-11-11', 'Ingreso al sistema', 1, 5, 1),
(81, 'CRISS', '192.168.0.8', '22:45:26', '2015-11-11', 'Ingreso al sistema', 1, 5, 1),
(82, 'CRISS', '192.168.0.8', '22:47:14', '2015-11-11', 'Ingreso al sistema', 1, 5, 1),
(83, 'CRISS', '192.168.0.8', '22:48:41', '2015-11-11', 'Ingreso al sistema', 1, 5, 1),
(84, 'CRISS', '192.168.0.8', '22:49:55', '2015-11-11', 'Ingreso al sistema', 1, 5, 1),
(85, 'CRISS', '192.168.0.8', '22:52:33', '2015-11-11', 'Ingreso al sistema', 1, 5, 1),
(86, 'CRISS', '192.168.0.8', '22:58:33', '2015-11-11', 'Ingreso al sistema', 1, 5, 1),
(87, 'CRISS', '192.168.0.8', '22:59:35', '2015-11-11', 'Ingreso al sistema', 1, 5, 1),
(88, 'CRISS', '192.168.0.8', '23:12:54', '2015-11-11', 'Ingreso al sistema', 1, 5, 1),
(89, 'CRISS', '192.168.0.8', '23:16:59', '2015-11-11', 'Ingreso al sistema', 1, 5, 1),
(90, 'CRISS', '192.168.0.8', '23:17:47', '2015-11-11', 'Ingreso al sistema', 1, 5, 1),
(91, 'CRISS', '192.168.0.8', '23:21:10', '2015-11-11', 'Ingreso al sistema', 1, 5, 1),
(92, 'CRISS', '192.168.0.8', '23:22:09', '2015-11-11', 'Ingreso al sistema', 1, 5, 1),
(93, 'CRISS', '192.168.0.8', '23:23:53', '2015-11-11', 'Ingreso al sistema', 1, 5, 1),
(94, 'CRISS', '192.168.0.8', '23:25:39', '2015-11-11', 'Ingreso al sistema', 1, 5, 1),
(95, 'CRISS', '192.168.0.8', '23:26:15', '2015-11-11', 'Ingreso al sistema', 1, 5, 1),
(96, 'CRISS', '192.168.0.8', '23:35:46', '2015-11-11', 'Ingreso al sistema', 1, 5, 1),
(97, 'CRISS', '192.168.0.8', '23:38:35', '2015-11-11', 'Ingreso al sistema', 1, 5, 1),
(98, 'CRISS', '192.168.0.8', '23:41:43', '2015-11-11', 'Ingreso al sistema', 1, 5, 1),
(99, 'CRISS', '192.168.0.8', '23:43:25', '2015-11-11', 'Ingreso al sistema', 1, 5, 1),
(100, 'CRISS', '192.168.0.8', '23:46:21', '2015-11-11', 'Ingreso al sistema', 1, 5, 1),
(101, 'CRISS', '192.168.0.8', '23:49:45', '2015-11-11', 'Ingreso al sistema', 1, 5, 1),
(102, 'CRISS', '192.168.0.8', '23:51:01', '2015-11-11', 'Ingreso al sistema', 1, 5, 1),
(103, 'CRISS', '192.168.0.8', '23:52:27', '2015-11-11', 'Ingreso al sistema', 1, 5, 1),
(104, 'CRISS', '192.168.0.8', '23:53:43', '2015-11-11', 'Ingreso al sistema', 1, 5, 1),
(105, 'CRISS', '192.168.0.8', '23:54:30', '2015-11-11', 'Ingreso al sistema', 1, 5, 1),
(106, 'CRISS', '192.168.0.8', '23:57:40', '2015-11-11', 'Ingreso al sistema', 1, 5, 1),
(107, 'CRISS', '192.168.0.8', '23:59:12', '2015-11-11', 'Ingreso al sistema', 1, 5, 1),
(108, 'CRISS', '192.168.0.8', '00:01:57', '2015-11-12', 'Ingreso al sistema', 1, 5, 1),
(109, 'CRISS', '192.168.0.8', '00:09:04', '2015-11-12', 'Ingreso al sistema', 1, 5, 1),
(110, 'CRISS', '192.168.0.8', '00:11:43', '2015-11-12', 'Ingreso al sistema', 1, 5, 1),
(111, 'CRISS', '192.168.0.8', '00:13:06', '2015-11-12', 'Ingreso al sistema', 1, 5, 1),
(112, 'CRISS', '192.168.0.8', '00:25:47', '2015-11-12', 'Ingreso al sistema', 1, 5, 1),
(113, 'CRISS', '192.168.0.8', '00:26:33', '2015-11-12', 'Ingreso al sistema', 1, 5, 1),
(114, 'CRISS', '192.168.0.8', '00:28:05', '2015-11-12', 'Ingreso al sistema', 1, 5, 1),
(115, 'CRISS', '192.168.0.8', '00:29:08', '2015-11-12', 'Ingreso al sistema', 1, 5, 1),
(116, 'CRISS', '192.168.0.8', '00:29:47', '2015-11-12', 'Ingreso al sistema', 1, 5, 1),
(117, 'CRISS', '192.168.0.8', '00:31:06', '2015-11-12', 'Ingreso al sistema', 1, 5, 1),
(118, 'CRISS', '192.168.0.8', '00:34:37', '2015-11-12', 'Ingreso al sistema', 1, 5, 1),
(119, 'CRISS', '192.168.0.8', '00:36:58', '2015-11-12', 'Ingreso al sistema', 1, 5, 1),
(120, 'CRISS', '192.168.0.8', '00:38:09', '2015-11-12', 'Ingreso al sistema', 1, 5, 1),
(121, 'CRISS', '192.168.0.8', '00:39:14', '2015-11-12', 'Ingreso al sistema', 1, 5, 1),
(122, 'CRISS', '192.168.0.8', '00:42:35', '2015-11-12', 'Ingreso al sistema', 1, 5, 1),
(123, 'CRISS', '192.168.0.8', '00:51:25', '2015-11-12', 'Ingreso al sistema', 1, 5, 1),
(124, 'CRISS', '192.168.0.8', '00:53:09', '2015-11-12', 'Ingreso al sistema', 1, 5, 1),
(125, 'CRISS', '192.168.0.8', '00:53:38', '2015-11-12', 'Ingreso al sistema', 1, 5, 1),
(126, 'CRISS', '192.168.0.8', '00:54:32', '2015-11-12', 'Ingreso al sistema', 1, 5, 1),
(127, 'CRISS', '192.168.0.8', '00:55:54', '2015-11-12', 'Ingreso al sistema', 1, 5, 1),
(128, 'CRISS', '192.168.0.8', '00:56:27', '2015-11-12', 'Ingreso al sistema', 1, 5, 1),
(129, 'CRISS', '192.168.0.8', '01:07:25', '2015-11-12', 'Ingreso al sistema', 1, 5, 1),
(130, 'CRISS', '192.168.0.8', '01:12:50', '2015-11-12', 'Ingreso al sistema', 1, 5, 1),
(131, 'CRISS', '192.168.0.8', '01:14:26', '2015-11-12', 'Ingreso al sistema', 1, 5, 1),
(132, 'CRISS', '192.168.0.8', '01:27:54', '2015-11-12', 'Ingreso al sistema', 1, 5, 1),
(133, 'CRISS', '192.168.0.8', '01:30:51', '2015-11-12', 'Ingreso al sistema', 1, 5, 1),
(134, 'CRISS', '192.168.0.8', '01:31:12', '2015-11-12', 'Ingreso al sistema', 1, 5, 1),
(135, 'CRISS', '192.168.0.8', '01:31:34', '2015-11-12', 'Ingreso al sistema', 1, 5, 1),
(136, 'CRISS', '192.168.0.8', '01:39:50', '2015-11-12', 'Ingreso al sistema', 1, 5, 1),
(137, 'CRISS', '192.168.0.8', '01:41:31', '2015-11-12', 'Ingreso al sistema', 1, 5, 1),
(138, 'CRISS', '192.168.0.8', '01:44:17', '2015-11-12', 'Ingreso al sistema', 1, 5, 1),
(139, 'CRISS', '192.168.0.8', '01:52:00', '2015-11-12', 'Ingreso al sistema', 1, 5, 1),
(140, 'CRISS', '192.168.0.8', '01:53:10', '2015-11-12', 'Ingreso al sistema', 1, 5, 1),
(141, 'CRISS', '192.168.0.8', '01:55:44', '2015-11-12', 'Ingreso al sistema', 1, 5, 1),
(142, 'CRISS', '192.168.0.8', '01:57:14', '2015-11-12', 'Ingreso al sistema', 1, 5, 1),
(143, 'CRISS', '192.168.0.8', '01:57:33', '2015-11-12', 'Ingreso al sistema', 1, 5, 1),
(144, 'CRISS', '192.168.0.8', '01:58:06', '2015-11-12', 'Ingreso al sistema', 1, 5, 1),
(145, 'CRISS', '192.168.0.8', '02:00:35', '2015-11-12', 'Ingreso al sistema', 1, 5, 1),
(146, 'CRISS', '192.168.0.8', '02:11:00', '2015-11-12', 'Ingreso al sistema', 1, 5, 1),
(147, 'CRISS', '192.168.0.8', '02:38:54', '2015-11-12', 'Ingreso al sistema', 1, 1, 1),
(148, 'CRISS', '192.168.0.8', '02:42:51', '2015-11-12', 'Ingreso al sistema', 1, 8, 1),
(149, 'CRISS', '192.168.0.8', '02:43:13', '2015-11-12', 'Ingreso al sistema', 1, 7, 1);

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `mabodega`
--

CREATE TABLE IF NOT EXISTS `mabodega` (
  `ncodbodega` int(11) NOT NULL,
  `vnombrebodega` varchar(30) DEFAULT NULL,
  `vdireccionbodega` varchar(40) DEFAULT NULL,
  `vstatus` varchar(20) NOT NULL
) ENGINE=MyISAM AUTO_INCREMENT=3 DEFAULT CHARSET=latin1;

--
-- Volcado de datos para la tabla `mabodega`
--

INSERT INTO `mabodega` (`ncodbodega`, `vnombrebodega`, `vdireccionbodega`, `vstatus`) VALUES
(1, 'Bodega', 'Guatemala', 'INACTIVO'),
(2, 'Bodega2', 'Mixco', 'ACTIVO');

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `macapacitacion`
--

CREATE TABLE IF NOT EXISTS `macapacitacion` (
  `ncodcapacitacion` int(11) NOT NULL,
  `vnecesidad` varchar(20) DEFAULT NULL,
  `vobjetivo` varchar(20) DEFAULT NULL,
  `vresultadosesperados` varchar(30) DEFAULT NULL,
  `vresponsable` varchar(30) DEFAULT NULL,
  `vdetalle` varchar(60) DEFAULT NULL,
  `iparticipantes` int(11) DEFAULT NULL,
  `vtiempo` varchar(10) DEFAULT NULL,
  `vnombrecapacitacion` varchar(10) DEFAULT NULL,
  `vtipo` varchar(10) DEFAULT NULL,
  `ncodempleado` int(11) NOT NULL
) ENGINE=MyISAM DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `macliente`
--

CREATE TABLE IF NOT EXISTS `macliente` (
  `ncodcliente` int(11) NOT NULL,
  `vnit` varchar(18) DEFAULT NULL,
  `vnombrecliente` varchar(30) DEFAULT NULL,
  `vapellidocliente` varchar(40) DEFAULT NULL,
  `vdireccion` varchar(30) DEFAULT NULL,
  `ntelefono` int(11) DEFAULT NULL,
  `vcorreo` varchar(30) DEFAULT NULL,
  `vestado` varchar(20) DEFAULT NULL
) ENGINE=MyISAM DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `macognitivo`
--

CREATE TABLE IF NOT EXISTS `macognitivo` (
  `vtipo` varchar(10) DEFAULT NULL,
  `vdescripcion` varchar(30) DEFAULT NULL,
  `vestado` varchar(10) DEFAULT NULL,
  `ncodempleado` int(11) NOT NULL
) ENGINE=MyISAM DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `macompra`
--

CREATE TABLE IF NOT EXISTS `macompra` (
  `ncodcompra` int(11) NOT NULL,
  `vdescripcioncompra` varchar(100) DEFAULT NULL,
  `ncantidad` decimal(10,0) DEFAULT NULL,
  `ncostototal` decimal(10,0) DEFAULT NULL
) ENGINE=MyISAM DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `macotizacion`
--

CREATE TABLE IF NOT EXISTS `macotizacion` (
  `ncodcotizacion` int(11) NOT NULL,
  `vserie` varchar(10) DEFAULT NULL,
  `dfechacotizacion` date DEFAULT NULL,
  `dfechavencimiento` date DEFAULT NULL,
  `ntotal` decimal(10,0) DEFAULT NULL,
  `vestadocotizacion` varchar(10) DEFAULT NULL,
  `ncodcliente` int(11) NOT NULL,
  `vnombrevendedor` varchar(25) DEFAULT NULL,
  `ncodvendedor` int(11) NOT NULL
) ENGINE=MyISAM DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `macuenta`
--

CREATE TABLE IF NOT EXISTS `macuenta` (
  `ncodcuenta` int(11) NOT NULL,
  `nsaldo` decimal(10,0) DEFAULT NULL,
  `ncodbanco` int(11) NOT NULL,
  `ncoddocumento` int(11) NOT NULL,
  `ncodempleado` int(11) DEFAULT NULL
) ENGINE=MyISAM DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `madetallecotizacion`
--

CREATE TABLE IF NOT EXISTS `madetallecotizacion` (
  `ncodcotizacion` int(11) NOT NULL,
  `ncantidadcotizada` decimal(10,0) DEFAULT NULL,
  `npreciocotizado` decimal(10,0) DEFAULT NULL,
  `ncodarticulo` int(11) NOT NULL
) ENGINE=MyISAM DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `madetallefactura`
--

CREATE TABLE IF NOT EXISTS `madetallefactura` (
  `ncodarticulo` int(11) NOT NULL,
  `ncantidadventa` int(11) NOT NULL,
  `nprecioventa` int(11) DEFAULT NULL,
  `ncodfactura` int(11) NOT NULL
) ENGINE=MyISAM DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `madetallepedido`
--

CREATE TABLE IF NOT EXISTS `madetallepedido` (
  `ncodpedido` int(11) NOT NULL,
  `dcodproducto` decimal(10,0) DEFAULT NULL,
  `dcantidadpedido` decimal(10,0) DEFAULT NULL,
  `dpreciopedido` decimal(10,0) DEFAULT NULL,
  `ncodarticulo` int(11) NOT NULL
) ENGINE=MyISAM DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `madocporpagar`
--

CREATE TABLE IF NOT EXISTS `madocporpagar` (
  `ndocumento` int(11) NOT NULL,
  `vfechaemision` date DEFAULT NULL,
  `ntotalpago` decimal(10,0) DEFAULT NULL,
  `ndeudaactual` decimal(10,0) DEFAULT NULL,
  `vdescripcioncompra` varchar(30) DEFAULT NULL,
  `vnumerodocfisico` varchar(10) DEFAULT NULL,
  `ncodproveedor` int(11) NOT NULL,
  `ncodtipodocumento` int(11) NOT NULL
) ENGINE=MyISAM DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `maempleado`
--

CREATE TABLE IF NOT EXISTS `maempleado` (
  `ncodempleado` int(11) NOT NULL,
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
  `ncodhistoria` int(11) NOT NULL,
  `ncoddepartamento` int(11) NOT NULL,
  `ncodusuario` int(11) DEFAULT NULL
) ENGINE=MyISAM DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `maempresa`
--

CREATE TABLE IF NOT EXISTS `maempresa` (
  `ncodempresa` int(11) NOT NULL,
  `vpuestovacante` varchar(20) DEFAULT NULL,
  `vnomempresa` varchar(20) DEFAULT NULL,
  `vdescripcion` varchar(50) DEFAULT NULL,
  `vtipoempresa` varchar(40) DEFAULT NULL,
  `vnombreempresa` varchar(30) DEFAULT NULL,
  `vdireccion` varchar(50) DEFAULT NULL,
  `dtelefono` decimal(10,0) DEFAULT NULL
) ENGINE=MyISAM DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `maencabezadoconciliacion`
--

CREATE TABLE IF NOT EXISTS `maencabezadoconciliacion` (
  `ncodconcilicacion` int(11) NOT NULL,
  `dfecha` date DEFAULT NULL,
  `encargado` char(25) DEFAULT NULL,
  `cestado` char(20) DEFAULT NULL,
  `ncodcuenta` int(11) DEFAULT NULL
) ENGINE=MyISAM DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `maerror`
--

CREATE TABLE IF NOT EXISTS `maerror` (
  `ncoderror` int(11) NOT NULL,
  `dhora` time DEFAULT NULL,
  `dfecha` date DEFAULT NULL,
  `ncodtipo` int(11) DEFAULT NULL,
  `ncodusuario` int(11) NOT NULL,
  `ncodaccion` int(11) NOT NULL,
  `ncodaplicacion` int(11) NOT NULL
) ENGINE=MyISAM DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `mafactura`
--

CREATE TABLE IF NOT EXISTS `mafactura` (
  `ncodfactura` int(11) NOT NULL,
  `vserie` varchar(10) DEFAULT NULL,
  `vestado` varchar(15) DEFAULT NULL,
  `dfechavencimiento` date DEFAULT NULL,
  `ntotal` decimal(10,0) DEFAULT NULL,
  `dfecha` date DEFAULT NULL,
  `ncodcliente` int(11) NOT NULL,
  `ncodvendedor` int(11) NOT NULL
) ENGINE=MyISAM DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `malineaarticulo`
--

CREATE TABLE IF NOT EXISTS `malineaarticulo` (
  `ncodlineaarticulo` int(11) NOT NULL,
  `vnombre` varchar(30) DEFAULT NULL,
  `vdescripcion` varchar(10) DEFAULT NULL
) ENGINE=MyISAM AUTO_INCREMENT=3 DEFAULT CHARSET=latin1;

--
-- Volcado de datos para la tabla `malineaarticulo`
--

INSERT INTO `malineaarticulo` (`ncodlineaarticulo`, `vnombre`, `vdescripcion`) VALUES
(1, 'King', 'Grande'),
(2, 'SemiMatrimonial', 'Mediana');

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `malocacion`
--

CREATE TABLE IF NOT EXISTS `malocacion` (
  `ncodlocacion` int(11) NOT NULL,
  `direccion` varchar(40) DEFAULT NULL,
  `vcodpostal` varchar(10) DEFAULT NULL,
  `vciudad` varchar(10) DEFAULT NULL,
  `vprovincia` varchar(10) DEFAULT NULL,
  `ncodempleado` int(11) NOT NULL
) ENGINE=MyISAM DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `mamaterial`
--

CREATE TABLE IF NOT EXISTS `mamaterial` (
  `ncodmaterial` int(11) NOT NULL,
  `vnombre` varchar(30) DEFAULT NULL,
  `ncantidad` decimal(10,0) DEFAULT NULL,
  `vestatus` varchar(10) DEFAULT NULL
) ENGINE=MyISAM AUTO_INCREMENT=7 DEFAULT CHARSET=latin1;

--
-- Volcado de datos para la tabla `mamaterial`
--

INSERT INTO `mamaterial` (`ncodmaterial`, `vnombre`, `ncantidad`, `vestatus`) VALUES
(1, 'madera', '200', 'INACTIVO'),
(2, 'tablas', '20', 'INACTIVO'),
(3, 'madera', '21', 'INACTIVO'),
(4, 'tablas', '200', 'ACTIVO'),
(5, 'madera', '100', 'ACTIVO'),
(6, 'tornillos', '200', 'ACTIVO');

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `mamodulo`
--

CREATE TABLE IF NOT EXISTS `mamodulo` (
  `ncodmodulo` int(11) NOT NULL,
  `vnombremodulo` varchar(10) DEFAULT NULL,
  `vdescripcion` varchar(50) DEFAULT NULL,
  `vnombrereporte` varchar(10) DEFAULT NULL
) ENGINE=MyISAM AUTO_INCREMENT=4 DEFAULT CHARSET=latin1;

--
-- Volcado de datos para la tabla `mamodulo`
--

INSERT INTO `mamodulo` (`ncodmodulo`, `vnombremodulo`, `vdescripcion`, `vnombrereporte`) VALUES
(1, 'Seguridad', 'Seguridad Sistema', NULL),
(2, 'Compras', 'Registro de Compras', NULL),
(3, 'cuentas', 'cuentas', NULL);

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `mamoneda`
--

CREATE TABLE IF NOT EXISTS `mamoneda` (
  `ncodmoneda` int(11) NOT NULL,
  `cdescripcion` varchar(25) DEFAULT NULL,
  `cestado` char(15) DEFAULT NULL,
  `ncodbanco` int(11) NOT NULL
) ENGINE=MyISAM DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `mamora`
--

CREATE TABLE IF NOT EXISTS `mamora` (
  `ncodmora` int(11) NOT NULL,
  `dcantidad` decimal(10,0) DEFAULT NULL,
  `cestado` char(10) DEFAULT NULL,
  `ncodfactura` int(11) NOT NULL
) ENGINE=MyISAM DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `maobservacion`
--

CREATE TABLE IF NOT EXISTS `maobservacion` (
  `ncodobservacion` int(11) NOT NULL,
  `cDescripcion` varchar(18) DEFAULT NULL,
  `cestado` char(20) DEFAULT NULL,
  `ncodDetalleConci` int(11) DEFAULT NULL
) ENGINE=MyISAM DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `maorden`
--

CREATE TABLE IF NOT EXISTS `maorden` (
  `ncodordenes` int(11) NOT NULL,
  `vreferenciaproducto` varchar(30) DEFAULT NULL,
  `vinicioproduccion` varchar(30) DEFAULT NULL,
  `ventregaproducto` varchar(30) DEFAULT NULL,
  `vultimomovimiento` varchar(10) DEFAULT NULL,
  `nnodocumento` decimal(10,0) DEFAULT NULL,
  `ncantidadproductoafabricar` decimal(10,0) DEFAULT NULL,
  `ncantidadnoproductoterminado` decimal(10,0) DEFAULT NULL,
  `ncantidadproductofaltante` char(10) DEFAULT NULL,
  `ncodprocesoorden` int(11) NOT NULL,
  `ncodstatusorden` int(11) DEFAULT NULL
) ENGINE=MyISAM DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `maordencompra`
--

CREATE TABLE IF NOT EXISTS `maordencompra` (
  `ncodordencompra` int(11) NOT NULL,
  `ncodproveedor` int(11) NOT NULL,
  `vdescripcioncompra` varchar(40) DEFAULT NULL,
  `ncantidad` decimal(10,0) DEFAULT NULL,
  `ncostototal` decimal(10,0) DEFAULT NULL,
  `ncodarticulo` int(11) NOT NULL,
  `vstatusorden` varchar(20) NOT NULL,
  `vstatus` varchar(20) NOT NULL
) ENGINE=MyISAM DEFAULT CHARSET=latin1;

--
-- Volcado de datos para la tabla `maordencompra`
--

INSERT INTO `maordencompra` (`ncodordencompra`, `ncodproveedor`, `vdescripcioncompra`, `ncantidad`, `ncostototal`, `ncodarticulo`, `vstatusorden`, `vstatus`) VALUES
(1002, 4, 'prueba estados2', '25', '2500', 2, 'INICIAL', 'ACTIVO'),
(1001, 4, 'prueba estados', '25', '2500', 2, 'INICIAL', 'INACTIVO');

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `mapedido`
--

CREATE TABLE IF NOT EXISTS `mapedido` (
  `ncodpedido` int(11) NOT NULL,
  `vserie` varchar(18) DEFAULT NULL,
  `dfechapedido` date DEFAULT NULL,
  `dfechavencimiento` date DEFAULT NULL,
  `ntotal` int(11) DEFAULT NULL,
  `vestadocotizacion` varchar(10) DEFAULT NULL,
  `ncodcliente` int(11) NOT NULL,
  `ncodvendedor` int(11) NOT NULL
) ENGINE=MyISAM DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `maplaza`
--

CREATE TABLE IF NOT EXISTS `maplaza` (
  `ncodplaza` int(11) NOT NULL,
  `vdepartamento` varchar(30) DEFAULT NULL,
  `vcausasolicitud` varchar(10) DEFAULT NULL,
  `vtipoempleado` varchar(20) DEFAULT NULL,
  `vcapacidadesrequeridas` varchar(30) DEFAULT NULL,
  `vhorario` varchar(20) DEFAULT NULL,
  `vtipo` varchar(30) DEFAULT NULL,
  `vdescripcion` varchar(20) DEFAULT NULL,
  `dsueldomin` decimal(10,0) DEFAULT NULL,
  `dsueldomax` decimal(10,0) DEFAULT NULL,
  `ncodempresa` int(11) NOT NULL
) ENGINE=MyISAM DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `maproducto`
--

CREATE TABLE IF NOT EXISTS `maproducto` (
  `ncodarticulo` int(11) NOT NULL,
  `nexistencia` decimal(10,0) DEFAULT NULL,
  `nprecio` decimal(10,0) DEFAULT NULL,
  `vmarca` varchar(10) DEFAULT NULL,
  `vnombre` varchar(30) DEFAULT NULL,
  `vdescripcion` varchar(30) DEFAULT NULL,
  `ncodlineaarticulo` int(11) NOT NULL,
  `ncodtipoarticulo` int(11) NOT NULL,
  `ncodproveedor` int(11) NOT NULL,
  `ncodunidad` int(11) NOT NULL
) ENGINE=MyISAM AUTO_INCREMENT=3 DEFAULT CHARSET=latin1;

--
-- Volcado de datos para la tabla `maproducto`
--

INSERT INTO `maproducto` (`ncodarticulo`, `nexistencia`, `nprecio`, `vmarca`, `vnombre`, `vdescripcion`, `ncodlineaarticulo`, `ncodtipoarticulo`, `ncodproveedor`, `ncodunidad`) VALUES
(1, '8', '100', 'Imperio', 'Cama', 'cama grande', 1, 1, 1, 1),
(2, '15', '400', 'Cama', 'Camota', 'camas', 2, 2, 2, 2);

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `maproveedor`
--

CREATE TABLE IF NOT EXISTS `maproveedor` (
  `ncodproveedor` int(11) NOT NULL,
  `vnit` varchar(10) DEFAULT NULL,
  `nsaldo` decimal(10,0) DEFAULT NULL,
  `vdescripcion` varchar(10) DEFAULT NULL,
  `vtelefono` varchar(40) DEFAULT NULL,
  `vciudad` varchar(40) DEFAULT NULL,
  `vnombre` varchar(30) DEFAULT NULL,
  `vdireccion` varchar(30) DEFAULT NULL
) ENGINE=MyISAM AUTO_INCREMENT=8 DEFAULT CHARSET=latin1;

--
-- Volcado de datos para la tabla `maproveedor`
--

INSERT INTO `maproveedor` (`ncodproveedor`, `vnit`, `nsaldo`, `vdescripcion`, `vtelefono`, `vciudad`, `vnombre`, `vdireccion`) VALUES
(1, '61651561', '50', 'dasdasd', 'asdasdas', 'asdasda', 'asd', 'zona 7'),
(4, '1513121', '10', 'programado', '2826232', 'asdasd', 'manuel', 'mixco'),
(5, '516161', '100', 'analista', '165156', 'guatemala', 'melvin', 'landivar');

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `mapunto`
--

CREATE TABLE IF NOT EXISTS `mapunto` (
  `ncodigopunto` int(11) NOT NULL,
  `cx` char(10) DEFAULT NULL,
  `cy` char(10) DEFAULT NULL,
  `ncodgrafica` int(11) NOT NULL
) ENGINE=MyISAM DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `mareceta`
--

CREATE TABLE IF NOT EXISTS `mareceta` (
  `ncodreceta` int(11) NOT NULL,
  `nhorahombre` time DEFAULT NULL,
  `vnombrereceta` varchar(20) DEFAULT NULL,
  `ncodordenes` int(11) NOT NULL
) ENGINE=MyISAM DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `marecibopago`
--

CREATE TABLE IF NOT EXISTS `marecibopago` (
  `ncodrecibopago` int(11) NOT NULL,
  `vnombre` varchar(10) DEFAULT NULL,
  `vfechapago` varchar(10) DEFAULT NULL,
  `ncantidadpago` decimal(10,0) DEFAULT NULL,
  `ncodproveedor` int(11) NOT NULL
) ENGINE=MyISAM DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `marolusuario`
--

CREATE TABLE IF NOT EXISTS `marolusuario` (
  `ncodrole` int(11) NOT NULL,
  `vnombrerole` varchar(30) DEFAULT NULL
) ENGINE=MyISAM AUTO_INCREMENT=5 DEFAULT CHARSET=latin1;

--
-- Volcado de datos para la tabla `marolusuario`
--

INSERT INTO `marolusuario` (`ncodrole`, `vnombrerole`) VALUES
(1, 'Superusuario'),
(2, 'Administrador'),
(3, 'vendedor'),
(4, 'Usuario Comun');

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `matipoarticulo`
--

CREATE TABLE IF NOT EXISTS `matipoarticulo` (
  `ncodtipoarticulo` int(11) NOT NULL,
  `vnombre` varchar(10) DEFAULT NULL,
  `vdescripcion` varchar(10) DEFAULT NULL
) ENGINE=MyISAM AUTO_INCREMENT=3 DEFAULT CHARSET=latin1;

--
-- Volcado de datos para la tabla `matipoarticulo`
--

INSERT INTO `matipoarticulo` (`ncodtipoarticulo`, `vnombre`, `vdescripcion`) VALUES
(1, 'cama', 'grande'),
(2, 'litera', 'grande');

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `matipodocumento`
--

CREATE TABLE IF NOT EXISTS `matipodocumento` (
  `ncodtipodocumento` int(11) NOT NULL,
  `vdescripciondocumento` varchar(30) DEFAULT NULL,
  `vtipodocumento` varchar(30) DEFAULT NULL
) ENGINE=MyISAM DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `matipoerror`
--

CREATE TABLE IF NOT EXISTS `matipoerror` (
  `ncodtipo` int(11) NOT NULL,
  `vnombre` varchar(30) DEFAULT NULL
) ENGINE=MyISAM DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `matipomovimiento`
--

CREATE TABLE IF NOT EXISTS `matipomovimiento` (
  `ncodmoviemiento` int(11) NOT NULL,
  `vdescripcion` varchar(40) DEFAULT NULL,
  `vtipomovimiento` varchar(40) DEFAULT NULL
) ENGINE=MyISAM DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `matipopago`
--

CREATE TABLE IF NOT EXISTS `matipopago` (
  `ncodtipopago` int(11) NOT NULL,
  `vdescripciontipopago` varchar(30) DEFAULT NULL
) ENGINE=MyISAM DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `matipotransaccion`
--

CREATE TABLE IF NOT EXISTS `matipotransaccion` (
  `ncodtipotransaccion` int(11) NOT NULL,
  `vbincdec` varchar(20) DEFAULT NULL,
  `vnombredocumento` varchar(20) DEFAULT NULL
) ENGINE=MyISAM DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `maunidad`
--

CREATE TABLE IF NOT EXISTS `maunidad` (
  `ncodunidad` int(11) NOT NULL,
  `vnombreunidad` varchar(20) DEFAULT NULL
) ENGINE=MyISAM AUTO_INCREMENT=3 DEFAULT CHARSET=latin1;

--
-- Volcado de datos para la tabla `maunidad`
--

INSERT INTO `maunidad` (`ncodunidad`, `vnombreunidad`) VALUES
(1, 'lb'),
(2, 'kg');

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `mausoarticulo`
--

CREATE TABLE IF NOT EXISTS `mausoarticulo` (
  `ncodarticulo` int(11) NOT NULL,
  `vnombreuso` varchar(10) DEFAULT NULL
) ENGINE=MyISAM DEFAULT CHARSET=latin1;

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
  `vpassword` varchar(200) NOT NULL
) ENGINE=MyISAM AUTO_INCREMENT=9 DEFAULT CHARSET=latin1;

--
-- Volcado de datos para la tabla `mausuario`
--

INSERT INTO `mausuario` (`ncodusuario`, `vnombreusuario`, `vapellidousuario`, `vemailusuario`, `vusuario`, `vpassword`) VALUES
(1, 'root', 'root', 'root@root.com', 'Superusuario', 'dc76e9f0c0006e8f919e0c515c66dbba3982f785'),
(2, 'Administrador', 'Admin', '----', 'Administrador', '4e7afebcfbae000b22c7c85e5560f89a2a0280b4'),
(3, 'hector', 'cardona', '--', 'hcardona', '81bce1f3bf343c464685d875c626820cdb58e309'),
(4, 'Luis', 'Linares', 'l@yahoo.com', 'LuisH', '7110eda4d09e062aa5e4a390b0a572ac0d2c0220'),
(5, 'cristhiam', 'duarte', '@gmail.com', 'criss', '8cb2237d0679ca88db6464eac60da96345513964'),
(6, 'David', 'Barrios', '@gmail.com', 'David', '8cb2237d0679ca88db6464eac60da96345513964'),
(7, 'Ricardo', 'Von', '@gmail.com', 'Ricardo', '8cb2237d0679ca88db6464eac60da96345513964'),
(8, 'Usuario', 'usuario', '@gmail.com', 'Usuario', '8cb2237d0679ca88db6464eac60da96345513964');

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `mavendedor`
--

CREATE TABLE IF NOT EXISTS `mavendedor` (
  `ncodvendedor` int(11) NOT NULL,
  `nnit` varchar(10) DEFAULT NULL,
  `vnombrevendedor` varchar(50) DEFAULT NULL,
  `vapellidovendedor` varchar(50) DEFAULT NULL,
  `vdireccion` varchar(100) DEFAULT NULL,
  `ntelefono` decimal(10,0) DEFAULT NULL,
  `vcorreo` varchar(30) DEFAULT NULL,
  `vestado` varchar(20) DEFAULT NULL
) ENGINE=MyISAM DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `maventas`
--

CREATE TABLE IF NOT EXISTS `maventas` (
  `ncodventas` int(11) NOT NULL,
  `vfechaventa` varchar(40) DEFAULT NULL,
  `dprecioventa` decimal(10,0) DEFAULT NULL
) ENGINE=MyISAM DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `tractividadludica`
--

CREATE TABLE IF NOT EXISTS `tractividadludica` (
  `ncodactividad` int(11) NOT NULL,
  `vtipo` varchar(10) DEFAULT NULL,
  `vnombre` varchar(30) DEFAULT NULL,
  `vdescripcion` varchar(30) DEFAULT NULL,
  `ncodempleado` int(11) NOT NULL
) ENGINE=MyISAM DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `trcobro`
--

CREATE TABLE IF NOT EXISTS `trcobro` (
  `ncodcobro` int(11) NOT NULL,
  `dpago` decimal(10,0) DEFAULT NULL,
  `dsaldo` decimal(10,0) DEFAULT NULL,
  `dfecha` date DEFAULT NULL,
  `ncodmora` int(11) NOT NULL,
  `ncodfactura` int(11) NOT NULL,
  `ncoddocumento` int(11) NOT NULL
) ENGINE=MyISAM DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `trcompra`
--

CREATE TABLE IF NOT EXISTS `trcompra` (
  `ncodarticulo` int(11) NOT NULL,
  `ncodproveedor` int(11) NOT NULL,
  `ncantidadProducto` decimal(10,0) DEFAULT NULL,
  `ntotalapagar` decimal(10,0) DEFAULT NULL,
  `ntotalpagado` decimal(10,0) DEFAULT NULL,
  `nsaldoapagar` decimal(10,0) DEFAULT NULL,
  `ncodorden` int(11) NOT NULL
) ENGINE=MyISAM DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `trcontrato`
--

CREATE TABLE IF NOT EXISTS `trcontrato` (
  `ncodcontrato` int(11) NOT NULL,
  `vhorariotrabajo` varchar(30) DEFAULT NULL,
  `vdetalle` varchar(20) DEFAULT NULL,
  `vpuestoreporta` varchar(20) DEFAULT NULL,
  `vzonaresidencia` varchar(30) DEFAULT NULL,
  `Vtipocontrato` varchar(30) DEFAULT NULL,
  `dfechainicio` date DEFAULT NULL,
  `dfechafin` date DEFAULT NULL,
  `nsalario` decimal(10,0) DEFAULT NULL,
  `ncodempleado` int(11) NOT NULL,
  `ncodempresa` int(11) NOT NULL,
  `ncodsolicitud` int(11) NOT NULL
) ENGINE=MyISAM DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `trdepartamento`
--

CREATE TABLE IF NOT EXISTS `trdepartamento` (
  `ncoddepartamento` int(11) NOT NULL,
  `vnombredepartamento` varchar(30) DEFAULT NULL,
  `vtipo` varchar(30) DEFAULT NULL
) ENGINE=MyISAM DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `trdesempenio`
--

CREATE TABLE IF NOT EXISTS `trdesempenio` (
  `vcargo` varchar(10) NOT NULL,
  `vcalidadtrabajo` varchar(10) DEFAULT NULL,
  `vcantidadtrabajo` varchar(10) DEFAULT NULL,
  `ncodempleado` int(11) NOT NULL
) ENGINE=MyISAM DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `trdetalleconciliacion`
--

CREATE TABLE IF NOT EXISTS `trdetalleconciliacion` (
  `ncodDetalleConci` int(11) NOT NULL,
  `ncodconcilicacion` int(11) DEFAULT NULL,
  `ncoddocumento` int(11) DEFAULT NULL
) ENGINE=MyISAM DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `trdetallereceta`
--

CREATE TABLE IF NOT EXISTS `trdetallereceta` (
  `ncantidad` int(11) NOT NULL,
  `ncodreceta` int(11) NOT NULL,
  `ncodmaterial` int(11) NOT NULL
) ENGINE=MyISAM DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `trdocumentos`
--

CREATE TABLE IF NOT EXISTS `trdocumentos` (
  `ncoddocumento` int(11) NOT NULL,
  `dfecha` date DEFAULT NULL,
  `dmonto` decimal(10,0) DEFAULT NULL,
  `ncodtipotransaccion` int(11) NOT NULL,
  `ncodcuenta` int(11) NOT NULL,
  `ncodproveedor` int(11) NOT NULL,
  `ndocumento` int(11) NOT NULL
) ENGINE=MyISAM DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `trescolaridad`
--

CREATE TABLE IF NOT EXISTS `trescolaridad` (
  `ncodescolaridad` int(11) NOT NULL,
  `vtipo` varchar(30) DEFAULT NULL,
  `vdescripcion` varchar(30) DEFAULT NULL
) ENGINE=MyISAM DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `trexistencia`
--

CREATE TABLE IF NOT EXISTS `trexistencia` (
  `nexistencia` int(11) NOT NULL,
  `ncodbodega` int(11) NOT NULL,
  `ncodarticulo` int(11) NOT NULL
) ENGINE=MyISAM DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `trfamilia`
--

CREATE TABLE IF NOT EXISTS `trfamilia` (
  `ncodfamilia` int(11) NOT NULL,
  `vtipo` varchar(10) DEFAULT NULL,
  `vdescripcion` varchar(20) DEFAULT NULL
) ENGINE=MyISAM DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `trgrafica`
--

CREATE TABLE IF NOT EXISTS `trgrafica` (
  `ncodgrafica` int(11) NOT NULL,
  `dfecha` date DEFAULT NULL,
  `ctipo` char(20) DEFAULT NULL,
  `ctitulografica` char(100) NOT NULL,
  `cejex` char(100) NOT NULL,
  `cejey` char(100) NOT NULL,
  `vnomreporte` varchar(30) NOT NULL
) ENGINE=MyISAM DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `trhistoriaemp`
--

CREATE TABLE IF NOT EXISTS `trhistoriaemp` (
  `ncodhistoria` int(11) NOT NULL,
  `vdescripcion` varchar(10) DEFAULT NULL,
  `dfechainicio` date DEFAULT NULL,
  `dfechafin` date DEFAULT NULL,
  `vdepartamento` varchar(10) DEFAULT NULL
) ENGINE=MyISAM DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `trmovimiento`
--

CREATE TABLE IF NOT EXISTS `trmovimiento` (
  `ncodmovimiento` int(11) NOT NULL,
  `vjustificacion` varchar(30) DEFAULT NULL,
  `vencargado` varchar(30) DEFAULT NULL,
  `dfechamovimiento` date DEFAULT NULL,
  `vhoramovimiento` varchar(10) DEFAULT NULL,
  `vreferenciafisica` varchar(10) DEFAULT NULL,
  `ncodmoviemiento` int(11) NOT NULL,
  `ncodarticulo` int(11) NOT NULL
) ENGINE=MyISAM DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `trordenproducto`
--

CREATE TABLE IF NOT EXISTS `trordenproducto` (
  `ncodorden` int(11) NOT NULL,
  `ncantidad` decimal(10,0) DEFAULT NULL,
  `vdescripcion` decimal(10,0) DEFAULT NULL,
  `vstatus` varchar(20) DEFAULT NULL,
  `ncodarticulo` int(11) NOT NULL
) ENGINE=MyISAM DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `trpagoproveedor`
--

CREATE TABLE IF NOT EXISTS `trpagoproveedor` (
  `ncodpagoproveedor` int(11) NOT NULL,
  `ncodproveedor` int(11) NOT NULL,
  `ncoddocumento` int(11) NOT NULL
) ENGINE=MyISAM DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `trpagos`
--

CREATE TABLE IF NOT EXISTS `trpagos` (
  `ncodpago` int(11) NOT NULL,
  `vcantidadpago` varchar(10) DEFAULT NULL,
  `dfechapago` date DEFAULT NULL,
  `vdescripcion` varchar(30) DEFAULT NULL,
  `ncodcuenta` int(11) NOT NULL,
  `ncodrecibopago` int(11) NOT NULL,
  `ncodtipopago` int(11) DEFAULT NULL,
  `ncoddocumento` int(11) NOT NULL
) ENGINE=MyISAM DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `trpagosalario`
--

CREATE TABLE IF NOT EXISTS `trpagosalario` (
  `ncodpagosalario` int(11) NOT NULL,
  `ncodcontrato` int(11) NOT NULL,
  `ncoddocumento` int(11) NOT NULL
) ENGINE=MyISAM DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `trpedido`
--

CREATE TABLE IF NOT EXISTS `trpedido` (
  `ncodpedido` int(11) NOT NULL,
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
  `ncodvendedor` int(11) NOT NULL
) ENGINE=MyISAM DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `trplanilla`
--

CREATE TABLE IF NOT EXISTS `trplanilla` (
  `cprestaciones` char(10) DEFAULT NULL,
  `vdetalle` varchar(20) DEFAULT NULL,
  `vhorasnormales` varchar(10) DEFAULT NULL,
  `vhorasextra` varchar(10) DEFAULT NULL,
  `nsemanas` decimal(10,0) DEFAULT NULL,
  `ncodempleado` int(11) NOT NULL,
  `ncodempresa` int(11) NOT NULL
) ENGINE=MyISAM DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `trprocesoorden`
--

CREATE TABLE IF NOT EXISTS `trprocesoorden` (
  `ncodprocesoorden` int(11) NOT NULL,
  `vnombreproceso` varchar(10) DEFAULT NULL
) ENGINE=MyISAM DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `trreporte`
--

CREATE TABLE IF NOT EXISTS `trreporte` (
  `vnomreporte` varchar(30) NOT NULL,
  `dfechareporte` varchar(50) DEFAULT NULL,
  `ncodaplicacion` char(10) DEFAULT NULL,
  `ncodmodulo` int(11) DEFAULT NULL,
  `ncodusuario` int(11) NOT NULL
) ENGINE=MyISAM DEFAULT CHARSET=latin1;

--
-- Volcado de datos para la tabla `trreporte`
--

INSERT INTO `trreporte` (`vnomreporte`, `dfechareporte`, `ncodaplicacion`, `ncodmodulo`, `ncodusuario`) VALUES
('mamaterial', '10/11/2015 22:02:04', '1', 1, 1),
('maordencompra', '12/11/2015 0:51:45', '1', 1, 5),
('mabodega', '12/11/2015 2:00:53', '1', 1, 5);

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `trroletoaplicacion`
--

CREATE TABLE IF NOT EXISTS `trroletoaplicacion` (
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
  `btnguardar` bit(1) DEFAULT NULL
) ENGINE=MyISAM DEFAULT CHARSET=latin1;

--
-- Volcado de datos para la tabla `trroletoaplicacion`
--

INSERT INTO `trroletoaplicacion` (`ncodrole`, `ncodaplicacion`, `btnimprimir`, `btnnuevo`, `btnirUltimo`, `btnirPrimero`, `btnanterior`, `btnsiguiente`, `btneditar`, `btncancelar`, `btnrefrescar`, `btnbuscar`, `btneliminar`, `btnguardar`) VALUES
(3, 14, b'0', b'1', b'0', b'0', b'0', b'0', b'1', b'0', b'0', b'0', b'1', b'0'),
(3, 11, b'0', b'0', b'0', b'0', b'0', b'0', b'0', b'0', b'0', b'0', b'0', b'0'),
(2, 8, b'0', b'0', b'0', b'0', b'0', b'0', b'0', b'0', b'0', b'0', b'0', b'0'),
(3, 15, b'0', b'1', b'0', b'0', b'0', b'0', b'0', b'0', b'0', b'0', b'0', b'0');

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `trsolicitud`
--

CREATE TABLE IF NOT EXISTS `trsolicitud` (
  `ncodsolicitud` int(11) NOT NULL,
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
  `ncodfamilia` int(11) NOT NULL
) ENGINE=MyISAM DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `trstatusorden`
--

CREATE TABLE IF NOT EXISTS `trstatusorden` (
  `ncodstatusorden` int(11) NOT NULL,
  `vestatus` varchar(30) DEFAULT NULL
) ENGINE=MyISAM DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `trunidad`
--

CREATE TABLE IF NOT EXISTS `trunidad` (
  `nconversion` double(18,0) DEFAULT NULL,
  `vnombreconversion` varchar(20) DEFAULT NULL,
  `ncodunidad` int(11) NOT NULL
) ENGINE=MyISAM DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `trusuariotoaplicacion`
--

CREATE TABLE IF NOT EXISTS `trusuariotoaplicacion` (
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
  `btnguardar` bit(1) DEFAULT NULL
) ENGINE=MyISAM DEFAULT CHARSET=latin1;

--
-- Volcado de datos para la tabla `trusuariotoaplicacion`
--

INSERT INTO `trusuariotoaplicacion` (`ncodusuario`, `ncodaplicacion`, `btnimprimir`, `btnnuevo`, `btnirUltimo`, `btnirPrimero`, `btnanterior`, `btnsiguiente`, `btneditar`, `btncancelar`, `btnrefrescar`, `btnbuscar`, `btneliminar`, `btnguardar`) VALUES
(2, 5, b'0', b'0', b'0', b'0', b'0', b'0', b'0', b'0', b'0', b'0', b'0', b'0'),
(3, 14, b'1', b'0', b'1', b'1', b'0', b'0', b'0', b'0', b'0', b'1', b'0', b'0'),
(3, 11, b'0', b'0', b'0', b'0', b'0', b'0', b'0', b'0', b'0', b'0', b'0', b'0'),
(2, 1, b'0', b'0', b'0', b'0', b'0', b'0', b'0', b'0', b'0', b'0', b'0', b'0'),
(3, 15, b'0', b'1', b'0', b'0', b'0', b'0', b'1', b'1', b'1', b'1', b'1', b'1'),
(4, 11, b'0', b'0', b'0', b'0', b'0', b'0', b'0', b'0', b'0', b'0', b'0', b'0'),
(4, 15, b'0', b'1', b'0', b'0', b'0', b'0', b'0', b'0', b'0', b'1', b'1', b'1');

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `trusuariotorole`
--

CREATE TABLE IF NOT EXISTS `trusuariotorole` (
  `ncodusuario` int(11) NOT NULL,
  `ncodrole` int(11) NOT NULL
) ENGINE=MyISAM DEFAULT CHARSET=latin1;

--
-- Volcado de datos para la tabla `trusuariotorole`
--

INSERT INTO `trusuariotorole` (`ncodusuario`, `ncodrole`) VALUES
(3, 3),
(1, 1),
(2, 2),
(4, 3),
(5, 2),
(6, 2),
(7, 2),
(8, 4);

--
-- Índices para tablas volcadas
--

--
-- Indices de la tabla `maacciones`
--
ALTER TABLE `maacciones`
  ADD PRIMARY KEY (`ncodaccion`);

--
-- Indices de la tabla `maaplicacion`
--
ALTER TABLE `maaplicacion`
  ADD PRIMARY KEY (`ncodaplicacion`),
  ADD KEY `RefMaMODULO64` (`ncodmodulo`);

--
-- Indices de la tabla `mabanco`
--
ALTER TABLE `mabanco`
  ADD PRIMARY KEY (`ncodbanco`);

--
-- Indices de la tabla `mabitacora`
--
ALTER TABLE `mabitacora`
  ADD PRIMARY KEY (`ncodbitacora`),
  ADD KEY `RefMaACCIONES59` (`ncodaccion`),
  ADD KEY `RefMaUSUARIO62` (`ncodusuario`),
  ADD KEY `RefMaAPLICACION66` (`ncodaplicacion`);

--
-- Indices de la tabla `mabodega`
--
ALTER TABLE `mabodega`
  ADD PRIMARY KEY (`ncodbodega`);

--
-- Indices de la tabla `macapacitacion`
--
ALTER TABLE `macapacitacion`
  ADD PRIMARY KEY (`ncodcapacitacion`),
  ADD KEY `RefMaEMPLEADO87` (`ncodempleado`);

--
-- Indices de la tabla `macliente`
--
ALTER TABLE `macliente`
  ADD PRIMARY KEY (`ncodcliente`);

--
-- Indices de la tabla `macognitivo`
--
ALTER TABLE `macognitivo`
  ADD KEY `RefMaEMPLEADO45` (`ncodempleado`);

--
-- Indices de la tabla `macompra`
--
ALTER TABLE `macompra`
  ADD PRIMARY KEY (`ncodcompra`);

--
-- Indices de la tabla `macotizacion`
--
ALTER TABLE `macotizacion`
  ADD PRIMARY KEY (`ncodcotizacion`),
  ADD KEY `RefMaVENDEDOR14` (`ncodvendedor`),
  ADD KEY `RefMaCLIENTE15` (`ncodcliente`);

--
-- Indices de la tabla `macuenta`
--
ALTER TABLE `macuenta`
  ADD PRIMARY KEY (`ncodcuenta`),
  ADD KEY `RefMaEMPLEADO112` (`ncodempleado`),
  ADD KEY `RefTrDOCUMENTOS29` (`ncoddocumento`),
  ADD KEY `RefMaBANCO51` (`ncodbanco`);

--
-- Indices de la tabla `madetallecotizacion`
--
ALTER TABLE `madetallecotizacion`
  ADD KEY `RefMaCOTIZACION101` (`ncodcotizacion`),
  ADD KEY `RefMaPRODUCTO24` (`ncodarticulo`);

--
-- Indices de la tabla `madetallefactura`
--
ALTER TABLE `madetallefactura`
  ADD KEY `RefMaFACTURA88` (`ncodfactura`),
  ADD KEY `RefMaPRODUCTO61` (`ncodarticulo`);

--
-- Indices de la tabla `madetallepedido`
--
ALTER TABLE `madetallepedido`
  ADD KEY `RefMaPEDIDO19` (`ncodpedido`),
  ADD KEY `RefMaPRODUCTO20` (`ncodarticulo`);

--
-- Indices de la tabla `madocporpagar`
--
ALTER TABLE `madocporpagar`
  ADD PRIMARY KEY (`ndocumento`),
  ADD KEY `RefMaPROVEEDOR35` (`ncodproveedor`),
  ADD KEY `RefMaTIPODOCUMENTO42` (`ncodtipodocumento`);

--
-- Indices de la tabla `maempleado`
--
ALTER TABLE `maempleado`
  ADD PRIMARY KEY (`ncodempleado`),
  ADD KEY `RefTrDEPARTAMENTO89` (`ncoddepartamento`),
  ADD KEY `RefTrHISTORIAEMP55` (`ncodhistoria`),
  ADD KEY `RefMaUSUARIO74` (`ncodusuario`);

--
-- Indices de la tabla `maempresa`
--
ALTER TABLE `maempresa`
  ADD PRIMARY KEY (`ncodempresa`);

--
-- Indices de la tabla `maencabezadoconciliacion`
--
ALTER TABLE `maencabezadoconciliacion`
  ADD PRIMARY KEY (`ncodconcilicacion`),
  ADD KEY `RefMaCUENTA108` (`ncodcuenta`);

--
-- Indices de la tabla `maerror`
--
ALTER TABLE `maerror`
  ADD PRIMARY KEY (`ncoderror`),
  ADD KEY `RefMaTIPOERROR54` (`ncodtipo`),
  ADD KEY `RefMaUSUARIO56` (`ncodusuario`),
  ADD KEY `RefMaACCIONES58` (`ncodaccion`),
  ADD KEY `RefMaAPLICACION68` (`ncodaplicacion`);

--
-- Indices de la tabla `mafactura`
--
ALTER TABLE `mafactura`
  ADD PRIMARY KEY (`ncodfactura`),
  ADD KEY `RefMaVENDEDOR7` (`ncodvendedor`),
  ADD KEY `RefMaCLIENTE43` (`ncodcliente`);

--
-- Indices de la tabla `malineaarticulo`
--
ALTER TABLE `malineaarticulo`
  ADD PRIMARY KEY (`ncodlineaarticulo`);

--
-- Indices de la tabla `malocacion`
--
ALTER TABLE `malocacion`
  ADD PRIMARY KEY (`ncodlocacion`),
  ADD KEY `RefMaEMPLEADO92` (`ncodempleado`);

--
-- Indices de la tabla `mamaterial`
--
ALTER TABLE `mamaterial`
  ADD PRIMARY KEY (`ncodmaterial`);

--
-- Indices de la tabla `mamodulo`
--
ALTER TABLE `mamodulo`
  ADD PRIMARY KEY (`ncodmodulo`);

--
-- Indices de la tabla `mamoneda`
--
ALTER TABLE `mamoneda`
  ADD PRIMARY KEY (`ncodmoneda`),
  ADD KEY `RefMaBANCO98` (`ncodbanco`);

--
-- Indices de la tabla `mamora`
--
ALTER TABLE `mamora`
  ADD PRIMARY KEY (`ncodmora`),
  ADD KEY `RefMaFACTURA21` (`ncodfactura`);

--
-- Indices de la tabla `maobservacion`
--
ALTER TABLE `maobservacion`
  ADD PRIMARY KEY (`ncodobservacion`),
  ADD KEY `RefTrDETALLECONCILIACION110` (`ncodDetalleConci`);

--
-- Indices de la tabla `maorden`
--
ALTER TABLE `maorden`
  ADD PRIMARY KEY (`ncodordenes`),
  ADD KEY `RefTrSTATUSORDEN109` (`ncodstatusorden`),
  ADD KEY `RefTrPROCESOORDEN77` (`ncodprocesoorden`);

--
-- Indices de la tabla `maordencompra`
--
ALTER TABLE `maordencompra`
  ADD PRIMARY KEY (`ncodordencompra`),
  ADD KEY `RefMaPRODUCTO96` (`ncodarticulo`),
  ADD KEY `RefMaPROVEEDOR32` (`ncodproveedor`);

--
-- Indices de la tabla `mapedido`
--
ALTER TABLE `mapedido`
  ADD PRIMARY KEY (`ncodpedido`),
  ADD KEY `RefMaCLIENTE16` (`ncodcliente`),
  ADD KEY `RefMaVENDEDOR17` (`ncodvendedor`);

--
-- Indices de la tabla `maplaza`
--
ALTER TABLE `maplaza`
  ADD PRIMARY KEY (`ncodplaza`),
  ADD KEY `RefMaEMPRESA86` (`ncodempresa`);

--
-- Indices de la tabla `maproducto`
--
ALTER TABLE `maproducto`
  ADD PRIMARY KEY (`ncodarticulo`),
  ADD KEY `RefMaUNIDAD79` (`ncodunidad`),
  ADD KEY `RefMaLINEAARTICULO63` (`ncodlineaarticulo`),
  ADD KEY `RefMaTIPOARTICULO65` (`ncodtipoarticulo`),
  ADD KEY `RefMaPROVEEDOR73` (`ncodproveedor`);

--
-- Indices de la tabla `maproveedor`
--
ALTER TABLE `maproveedor`
  ADD PRIMARY KEY (`ncodproveedor`);

--
-- Indices de la tabla `mapunto`
--
ALTER TABLE `mapunto`
  ADD PRIMARY KEY (`ncodigopunto`),
  ADD KEY `RefTrGRAFICA1` (`ncodgrafica`);

--
-- Indices de la tabla `mareceta`
--
ALTER TABLE `mareceta`
  ADD PRIMARY KEY (`ncodreceta`),
  ADD KEY `RefMaORDEN4` (`ncodordenes`);

--
-- Indices de la tabla `marecibopago`
--
ALTER TABLE `marecibopago`
  ADD PRIMARY KEY (`ncodrecibopago`),
  ADD KEY `RefMaPROVEEDOR75` (`ncodproveedor`);

--
-- Indices de la tabla `marolusuario`
--
ALTER TABLE `marolusuario`
  ADD PRIMARY KEY (`ncodrole`);

--
-- Indices de la tabla `matipoarticulo`
--
ALTER TABLE `matipoarticulo`
  ADD PRIMARY KEY (`ncodtipoarticulo`);

--
-- Indices de la tabla `matipodocumento`
--
ALTER TABLE `matipodocumento`
  ADD PRIMARY KEY (`ncodtipodocumento`);

--
-- Indices de la tabla `matipoerror`
--
ALTER TABLE `matipoerror`
  ADD PRIMARY KEY (`ncodtipo`);

--
-- Indices de la tabla `matipomovimiento`
--
ALTER TABLE `matipomovimiento`
  ADD PRIMARY KEY (`ncodmoviemiento`);

--
-- Indices de la tabla `matipopago`
--
ALTER TABLE `matipopago`
  ADD PRIMARY KEY (`ncodtipopago`);

--
-- Indices de la tabla `matipotransaccion`
--
ALTER TABLE `matipotransaccion`
  ADD PRIMARY KEY (`ncodtipotransaccion`);

--
-- Indices de la tabla `maunidad`
--
ALTER TABLE `maunidad`
  ADD PRIMARY KEY (`ncodunidad`);

--
-- Indices de la tabla `mausoarticulo`
--
ALTER TABLE `mausoarticulo`
  ADD KEY `RefMaPRODUCTO36` (`ncodarticulo`);

--
-- Indices de la tabla `mausuario`
--
ALTER TABLE `mausuario`
  ADD PRIMARY KEY (`ncodusuario`);

--
-- Indices de la tabla `mavendedor`
--
ALTER TABLE `mavendedor`
  ADD PRIMARY KEY (`ncodvendedor`);

--
-- Indices de la tabla `maventas`
--
ALTER TABLE `maventas`
  ADD PRIMARY KEY (`ncodventas`);

--
-- Indices de la tabla `tractividadludica`
--
ALTER TABLE `tractividadludica`
  ADD PRIMARY KEY (`ncodactividad`),
  ADD KEY `RefMaEMPLEADO53` (`ncodempleado`);

--
-- Indices de la tabla `trcobro`
--
ALTER TABLE `trcobro`
  ADD PRIMARY KEY (`ncodcobro`),
  ADD KEY `RefMaMORA39` (`ncodmora`),
  ADD KEY `RefMaFACTURA41` (`ncodfactura`),
  ADD KEY `RefTrDOCUMENTOS71` (`ncoddocumento`);

--
-- Indices de la tabla `trcompra`
--
ALTER TABLE `trcompra`
  ADD KEY `RefTrORDENPRODUCTO81` (`ncodorden`),
  ADD KEY `RefMaPRODUCTO11` (`ncodarticulo`),
  ADD KEY `RefMaPROVEEDOR12` (`ncodproveedor`);

--
-- Indices de la tabla `trcontrato`
--
ALTER TABLE `trcontrato`
  ADD PRIMARY KEY (`ncodcontrato`),
  ADD KEY `RefMaEMPLEADO84` (`ncodempleado`),
  ADD KEY `RefMaEMPRESA85` (`ncodempresa`),
  ADD KEY `RefTrSOLICITUD90` (`ncodsolicitud`);

--
-- Indices de la tabla `trdepartamento`
--
ALTER TABLE `trdepartamento`
  ADD PRIMARY KEY (`ncoddepartamento`);

--
-- Indices de la tabla `trdesempenio`
--
ALTER TABLE `trdesempenio`
  ADD PRIMARY KEY (`vcargo`),
  ADD KEY `RefMaEMPLEADO105` (`ncodempleado`);

--
-- Indices de la tabla `trdetalleconciliacion`
--
ALTER TABLE `trdetalleconciliacion`
  ADD PRIMARY KEY (`ncodDetalleConci`),
  ADD KEY `RefMaENCABEZADOCONCILIACION106` (`ncodconcilicacion`),
  ADD KEY `RefTrDOCUMENTOS107` (`ncoddocumento`);

--
-- Indices de la tabla `trdetallereceta`
--
ALTER TABLE `trdetallereceta`
  ADD PRIMARY KEY (`ncantidad`),
  ADD KEY `RefMaRECETA3` (`ncodreceta`),
  ADD KEY `RefMaMATERIAL5` (`ncodmaterial`);

--
-- Indices de la tabla `trdocumentos`
--
ALTER TABLE `trdocumentos`
  ADD PRIMARY KEY (`ncoddocumento`),
  ADD KEY `RefMaPROVEEDOR33` (`ncodproveedor`),
  ADD KEY `RefMaDOCPORPAGAR37` (`ndocumento`),
  ADD KEY `RefMaTIPOTRANSACCION38` (`ncodtipotransaccion`),
  ADD KEY `RefMaCUENTA40` (`ncodcuenta`);

--
-- Indices de la tabla `trescolaridad`
--
ALTER TABLE `trescolaridad`
  ADD PRIMARY KEY (`ncodescolaridad`);

--
-- Indices de la tabla `trexistencia`
--
ALTER TABLE `trexistencia`
  ADD PRIMARY KEY (`nexistencia`),
  ADD KEY `RefMaBODEGA47` (`ncodbodega`),
  ADD KEY `RefMaPRODUCTO67` (`ncodarticulo`);

--
-- Indices de la tabla `trfamilia`
--
ALTER TABLE `trfamilia`
  ADD PRIMARY KEY (`ncodfamilia`);

--
-- Indices de la tabla `trgrafica`
--
ALTER TABLE `trgrafica`
  ADD PRIMARY KEY (`ncodgrafica`),
  ADD KEY `RefTrREPORTE2` (`vnomreporte`);

--
-- Indices de la tabla `trhistoriaemp`
--
ALTER TABLE `trhistoriaemp`
  ADD PRIMARY KEY (`ncodhistoria`);

--
-- Indices de la tabla `trmovimiento`
--
ALTER TABLE `trmovimiento`
  ADD PRIMARY KEY (`ncodmovimiento`),
  ADD KEY `RefMaPRODUCTO78` (`ncodarticulo`),
  ADD KEY `RefMaTIPOMOVIMIENTO49` (`ncodmoviemiento`);

--
-- Indices de la tabla `trordenproducto`
--
ALTER TABLE `trordenproducto`
  ADD PRIMARY KEY (`ncodorden`),
  ADD KEY `RefMaPRODUCTO28` (`ncodarticulo`);

--
-- Indices de la tabla `trpagoproveedor`
--
ALTER TABLE `trpagoproveedor`
  ADD PRIMARY KEY (`ncodpagoproveedor`),
  ADD KEY `RefMaPROVEEDOR94` (`ncodproveedor`),
  ADD KEY `RefTrDOCUMENTOS97` (`ncoddocumento`);

--
-- Indices de la tabla `trpagos`
--
ALTER TABLE `trpagos`
  ADD PRIMARY KEY (`ncodpago`),
  ADD KEY `RefMaCUENTA80` (`ncodcuenta`),
  ADD KEY `RefMaRECIBOPAGO93` (`ncodrecibopago`),
  ADD KEY `RefMaTIPOPAGO9` (`ncodtipopago`),
  ADD KEY `RefTrDOCUMENTOS31` (`ncoddocumento`);

--
-- Indices de la tabla `trpagosalario`
--
ALTER TABLE `trpagosalario`
  ADD PRIMARY KEY (`ncodpagosalario`),
  ADD KEY `RefTrDOCUMENTOS91` (`ncoddocumento`),
  ADD KEY `RefTrCONTRATO60` (`ncodcontrato`);

--
-- Indices de la tabla `trpedido`
--
ALTER TABLE `trpedido`
  ADD PRIMARY KEY (`ncodpedido`),
  ADD KEY `RefMaPRODUCTO82` (`ncodarticulo`),
  ADD KEY `RefMaCLIENTE99` (`ncodcliente`),
  ADD KEY `RefMaVENDEDOR6` (`ncodvendedor`),
  ADD KEY `RefMaVENTAS34` (`ncodventas`);

--
-- Indices de la tabla `trplanilla`
--
ALTER TABLE `trplanilla`
  ADD KEY `RefMaEMPLEADO25` (`ncodempleado`),
  ADD KEY `RefMaEMPRESA27` (`ncodempresa`);

--
-- Indices de la tabla `trprocesoorden`
--
ALTER TABLE `trprocesoorden`
  ADD PRIMARY KEY (`ncodprocesoorden`);

--
-- Indices de la tabla `trreporte`
--
ALTER TABLE `trreporte`
  ADD PRIMARY KEY (`vnomreporte`),
  ADD KEY `RefMaMODULO111` (`ncodmodulo`),
  ADD KEY `RefMaUSUARIO72` (`ncodusuario`);

--
-- Indices de la tabla `trroletoaplicacion`
--
ALTER TABLE `trroletoaplicacion`
  ADD KEY `RefMaROLUSUARIO50` (`ncodrole`),
  ADD KEY `RefMaAPLICACION52` (`ncodaplicacion`);

--
-- Indices de la tabla `trsolicitud`
--
ALTER TABLE `trsolicitud`
  ADD PRIMARY KEY (`ncodsolicitud`),
  ADD KEY `RefTrFAMILIA95` (`ncodfamilia`),
  ADD KEY `RefTrESCOLARIDAD57` (`ncodescolaridad`);

--
-- Indices de la tabla `trstatusorden`
--
ALTER TABLE `trstatusorden`
  ADD PRIMARY KEY (`ncodstatusorden`);

--
-- Indices de la tabla `trunidad`
--
ALTER TABLE `trunidad`
  ADD KEY `RefMaUNIDAD76` (`ncodunidad`);

--
-- Indices de la tabla `trusuariotoaplicacion`
--
ALTER TABLE `trusuariotoaplicacion`
  ADD KEY `RefMaAPLICACION44` (`ncodaplicacion`),
  ADD KEY `RefMaUSUARIO69` (`ncodusuario`);

--
-- Indices de la tabla `trusuariotorole`
--
ALTER TABLE `trusuariotorole`
  ADD KEY `RefMaUSUARIO46` (`ncodusuario`),
  ADD KEY `RefMaROLUSUARIO48` (`ncodrole`);

--
-- AUTO_INCREMENT de las tablas volcadas
--

--
-- AUTO_INCREMENT de la tabla `maacciones`
--
ALTER TABLE `maacciones`
  MODIFY `ncodaccion` int(11) NOT NULL AUTO_INCREMENT,AUTO_INCREMENT=8;
--
-- AUTO_INCREMENT de la tabla `maaplicacion`
--
ALTER TABLE `maaplicacion`
  MODIFY `ncodaplicacion` int(11) NOT NULL AUTO_INCREMENT,AUTO_INCREMENT=17;
--
-- AUTO_INCREMENT de la tabla `mabanco`
--
ALTER TABLE `mabanco`
  MODIFY `ncodbanco` int(11) NOT NULL AUTO_INCREMENT;
--
-- AUTO_INCREMENT de la tabla `mabitacora`
--
ALTER TABLE `mabitacora`
  MODIFY `ncodbitacora` int(11) NOT NULL AUTO_INCREMENT,AUTO_INCREMENT=150;
--
-- AUTO_INCREMENT de la tabla `mabodega`
--
ALTER TABLE `mabodega`
  MODIFY `ncodbodega` int(11) NOT NULL AUTO_INCREMENT,AUTO_INCREMENT=3;
--
-- AUTO_INCREMENT de la tabla `macapacitacion`
--
ALTER TABLE `macapacitacion`
  MODIFY `ncodcapacitacion` int(11) NOT NULL AUTO_INCREMENT;
--
-- AUTO_INCREMENT de la tabla `macliente`
--
ALTER TABLE `macliente`
  MODIFY `ncodcliente` int(11) NOT NULL AUTO_INCREMENT;
--
-- AUTO_INCREMENT de la tabla `macompra`
--
ALTER TABLE `macompra`
  MODIFY `ncodcompra` int(11) NOT NULL AUTO_INCREMENT;
--
-- AUTO_INCREMENT de la tabla `macuenta`
--
ALTER TABLE `macuenta`
  MODIFY `ncodcuenta` int(11) NOT NULL AUTO_INCREMENT;
--
-- AUTO_INCREMENT de la tabla `madocporpagar`
--
ALTER TABLE `madocporpagar`
  MODIFY `ndocumento` int(11) NOT NULL AUTO_INCREMENT;
--
-- AUTO_INCREMENT de la tabla `maempleado`
--
ALTER TABLE `maempleado`
  MODIFY `ncodempleado` int(11) NOT NULL AUTO_INCREMENT;
--
-- AUTO_INCREMENT de la tabla `maencabezadoconciliacion`
--
ALTER TABLE `maencabezadoconciliacion`
  MODIFY `ncodconcilicacion` int(11) NOT NULL AUTO_INCREMENT;
--
-- AUTO_INCREMENT de la tabla `maerror`
--
ALTER TABLE `maerror`
  MODIFY `ncoderror` int(11) NOT NULL AUTO_INCREMENT;
--
-- AUTO_INCREMENT de la tabla `mafactura`
--
ALTER TABLE `mafactura`
  MODIFY `ncodfactura` int(11) NOT NULL AUTO_INCREMENT;
--
-- AUTO_INCREMENT de la tabla `malineaarticulo`
--
ALTER TABLE `malineaarticulo`
  MODIFY `ncodlineaarticulo` int(11) NOT NULL AUTO_INCREMENT,AUTO_INCREMENT=3;
--
-- AUTO_INCREMENT de la tabla `malocacion`
--
ALTER TABLE `malocacion`
  MODIFY `ncodlocacion` int(11) NOT NULL AUTO_INCREMENT;
--
-- AUTO_INCREMENT de la tabla `mamaterial`
--
ALTER TABLE `mamaterial`
  MODIFY `ncodmaterial` int(11) NOT NULL AUTO_INCREMENT,AUTO_INCREMENT=7;
--
-- AUTO_INCREMENT de la tabla `mamodulo`
--
ALTER TABLE `mamodulo`
  MODIFY `ncodmodulo` int(11) NOT NULL AUTO_INCREMENT,AUTO_INCREMENT=4;
--
-- AUTO_INCREMENT de la tabla `mamoneda`
--
ALTER TABLE `mamoneda`
  MODIFY `ncodmoneda` int(11) NOT NULL AUTO_INCREMENT;
--
-- AUTO_INCREMENT de la tabla `mamora`
--
ALTER TABLE `mamora`
  MODIFY `ncodmora` int(11) NOT NULL AUTO_INCREMENT;
--
-- AUTO_INCREMENT de la tabla `maobservacion`
--
ALTER TABLE `maobservacion`
  MODIFY `ncodobservacion` int(11) NOT NULL AUTO_INCREMENT;
--
-- AUTO_INCREMENT de la tabla `maorden`
--
ALTER TABLE `maorden`
  MODIFY `ncodordenes` int(11) NOT NULL AUTO_INCREMENT;
--
-- AUTO_INCREMENT de la tabla `maordencompra`
--
ALTER TABLE `maordencompra`
AUTO_INCREMENT=6;
--
-- AUTO_INCREMENT de la tabla `mapedido`
--
ALTER TABLE `mapedido`
  MODIFY `ncodpedido` int(11) NOT NULL AUTO_INCREMENT;
--
-- AUTO_INCREMENT de la tabla `maplaza`
--
ALTER TABLE `maplaza`
  MODIFY `ncodplaza` int(11) NOT NULL AUTO_INCREMENT;
--
-- AUTO_INCREMENT de la tabla `maproducto`
--
ALTER TABLE `maproducto`
  MODIFY `ncodarticulo` int(11) NOT NULL AUTO_INCREMENT,AUTO_INCREMENT=3;
--
-- AUTO_INCREMENT de la tabla `maproveedor`
--
ALTER TABLE `maproveedor`
  MODIFY `ncodproveedor` int(11) NOT NULL AUTO_INCREMENT,AUTO_INCREMENT=8;
--
-- AUTO_INCREMENT de la tabla `mapunto`
--
ALTER TABLE `mapunto`
  MODIFY `ncodigopunto` int(11) NOT NULL AUTO_INCREMENT;
--
-- AUTO_INCREMENT de la tabla `mareceta`
--
ALTER TABLE `mareceta`
  MODIFY `ncodreceta` int(11) NOT NULL AUTO_INCREMENT;
--
-- AUTO_INCREMENT de la tabla `marecibopago`
--
ALTER TABLE `marecibopago`
  MODIFY `ncodrecibopago` int(11) NOT NULL AUTO_INCREMENT;
--
-- AUTO_INCREMENT de la tabla `marolusuario`
--
ALTER TABLE `marolusuario`
  MODIFY `ncodrole` int(11) NOT NULL AUTO_INCREMENT,AUTO_INCREMENT=5;
--
-- AUTO_INCREMENT de la tabla `matipoarticulo`
--
ALTER TABLE `matipoarticulo`
  MODIFY `ncodtipoarticulo` int(11) NOT NULL AUTO_INCREMENT,AUTO_INCREMENT=3;
--
-- AUTO_INCREMENT de la tabla `matipodocumento`
--
ALTER TABLE `matipodocumento`
  MODIFY `ncodtipodocumento` int(11) NOT NULL AUTO_INCREMENT;
--
-- AUTO_INCREMENT de la tabla `matipoerror`
--
ALTER TABLE `matipoerror`
  MODIFY `ncodtipo` int(11) NOT NULL AUTO_INCREMENT;
--
-- AUTO_INCREMENT de la tabla `matipomovimiento`
--
ALTER TABLE `matipomovimiento`
  MODIFY `ncodmoviemiento` int(11) NOT NULL AUTO_INCREMENT;
--
-- AUTO_INCREMENT de la tabla `matipopago`
--
ALTER TABLE `matipopago`
  MODIFY `ncodtipopago` int(11) NOT NULL AUTO_INCREMENT;
--
-- AUTO_INCREMENT de la tabla `matipotransaccion`
--
ALTER TABLE `matipotransaccion`
  MODIFY `ncodtipotransaccion` int(11) NOT NULL AUTO_INCREMENT;
--
-- AUTO_INCREMENT de la tabla `maunidad`
--
ALTER TABLE `maunidad`
  MODIFY `ncodunidad` int(11) NOT NULL AUTO_INCREMENT,AUTO_INCREMENT=3;
--
-- AUTO_INCREMENT de la tabla `mausuario`
--
ALTER TABLE `mausuario`
  MODIFY `ncodusuario` int(11) NOT NULL AUTO_INCREMENT,AUTO_INCREMENT=9;
--
-- AUTO_INCREMENT de la tabla `mavendedor`
--
ALTER TABLE `mavendedor`
  MODIFY `ncodvendedor` int(11) NOT NULL AUTO_INCREMENT;
--
-- AUTO_INCREMENT de la tabla `maventas`
--
ALTER TABLE `maventas`
  MODIFY `ncodventas` int(11) NOT NULL AUTO_INCREMENT;
--
-- AUTO_INCREMENT de la tabla `tractividadludica`
--
ALTER TABLE `tractividadludica`
  MODIFY `ncodactividad` int(11) NOT NULL AUTO_INCREMENT;
--
-- AUTO_INCREMENT de la tabla `trcobro`
--
ALTER TABLE `trcobro`
  MODIFY `ncodcobro` int(11) NOT NULL AUTO_INCREMENT;
--
-- AUTO_INCREMENT de la tabla `trcontrato`
--
ALTER TABLE `trcontrato`
  MODIFY `ncodcontrato` int(11) NOT NULL AUTO_INCREMENT;
--
-- AUTO_INCREMENT de la tabla `trdepartamento`
--
ALTER TABLE `trdepartamento`
  MODIFY `ncoddepartamento` int(11) NOT NULL AUTO_INCREMENT;
--
-- AUTO_INCREMENT de la tabla `trdetalleconciliacion`
--
ALTER TABLE `trdetalleconciliacion`
  MODIFY `ncodDetalleConci` int(11) NOT NULL AUTO_INCREMENT;
--
-- AUTO_INCREMENT de la tabla `trdetallereceta`
--
ALTER TABLE `trdetallereceta`
  MODIFY `ncantidad` int(11) NOT NULL AUTO_INCREMENT;
--
-- AUTO_INCREMENT de la tabla `trdocumentos`
--
ALTER TABLE `trdocumentos`
  MODIFY `ncoddocumento` int(11) NOT NULL AUTO_INCREMENT;
--
-- AUTO_INCREMENT de la tabla `trescolaridad`
--
ALTER TABLE `trescolaridad`
  MODIFY `ncodescolaridad` int(11) NOT NULL AUTO_INCREMENT;
--
-- AUTO_INCREMENT de la tabla `trexistencia`
--
ALTER TABLE `trexistencia`
  MODIFY `nexistencia` int(11) NOT NULL AUTO_INCREMENT;
--
-- AUTO_INCREMENT de la tabla `trfamilia`
--
ALTER TABLE `trfamilia`
  MODIFY `ncodfamilia` int(11) NOT NULL AUTO_INCREMENT;
--
-- AUTO_INCREMENT de la tabla `trgrafica`
--
ALTER TABLE `trgrafica`
  MODIFY `ncodgrafica` int(11) NOT NULL AUTO_INCREMENT;
--
-- AUTO_INCREMENT de la tabla `trhistoriaemp`
--
ALTER TABLE `trhistoriaemp`
  MODIFY `ncodhistoria` int(11) NOT NULL AUTO_INCREMENT;
--
-- AUTO_INCREMENT de la tabla `trmovimiento`
--
ALTER TABLE `trmovimiento`
  MODIFY `ncodmovimiento` int(11) NOT NULL AUTO_INCREMENT;
--
-- AUTO_INCREMENT de la tabla `trordenproducto`
--
ALTER TABLE `trordenproducto`
  MODIFY `ncodorden` int(11) NOT NULL AUTO_INCREMENT;
--
-- AUTO_INCREMENT de la tabla `trpagoproveedor`
--
ALTER TABLE `trpagoproveedor`
  MODIFY `ncodpagoproveedor` int(11) NOT NULL AUTO_INCREMENT;
--
-- AUTO_INCREMENT de la tabla `trpagos`
--
ALTER TABLE `trpagos`
  MODIFY `ncodpago` int(11) NOT NULL AUTO_INCREMENT;
--
-- AUTO_INCREMENT de la tabla `trpagosalario`
--
ALTER TABLE `trpagosalario`
  MODIFY `ncodpagosalario` int(11) NOT NULL AUTO_INCREMENT;
--
-- AUTO_INCREMENT de la tabla `trpedido`
--
ALTER TABLE `trpedido`
  MODIFY `ncodpedido` int(11) NOT NULL AUTO_INCREMENT;
--
-- AUTO_INCREMENT de la tabla `trprocesoorden`
--
ALTER TABLE `trprocesoorden`
  MODIFY `ncodprocesoorden` int(11) NOT NULL AUTO_INCREMENT;
--
-- AUTO_INCREMENT de la tabla `trsolicitud`
--
ALTER TABLE `trsolicitud`
  MODIFY `ncodsolicitud` int(11) NOT NULL AUTO_INCREMENT;
--
-- AUTO_INCREMENT de la tabla `trstatusorden`
--
ALTER TABLE `trstatusorden`
  MODIFY `ncodstatusorden` int(11) NOT NULL AUTO_INCREMENT;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
