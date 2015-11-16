-- phpMyAdmin SQL Dump
-- version 4.4.14
-- http://www.phpmyadmin.net
--
-- Servidor: 127.0.0.1
-- Tiempo de generación: 16-11-2015 a las 04:48:07
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
) ENGINE=MyISAM AUTO_INCREMENT=15 DEFAULT CHARSET=latin1;

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
(14, 'Prueba', 2, 'frmPrueba');

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
) ENGINE=MyISAM AUTO_INCREMENT=53 DEFAULT CHARSET=latin1;

--
-- Volcado de datos para la tabla `mabitacora`
--

INSERT INTO `mabitacora` (`ncodbitacora`, `vnombreequipo`, `vipequipo`, `dhora`, `dfecha`, `vdetalleaccion`, `ncodaccion`, `ncodusuario`, `ncodaplicacion`) VALUES
(1, 'CRISS', '192.168.0.8', '20:00:34', '2015-11-12', 'Ingreso al sistema', 1, 1, 1),
(2, 'CRISS', '192.168.0.8', '20:02:31', '2015-11-12', 'Ingreso al sistema', 1, 1, 1),
(3, 'CRISS', '192.168.0.8', '20:03:01', '2015-11-12', 'Ingreso al sistema', 1, 1, 1),
(4, 'CRISS', '192.168.0.8', '20:28:51', '2015-11-12', 'Ingreso al sistema', 1, 1, 1),
(5, 'CRISS', '192.168.0.8', '20:31:17', '2015-11-12', 'Ingreso al sistema', 1, 1, 1),
(6, 'CRISS', '192.168.0.8', '20:32:05', '2015-11-12', 'Ingreso al sistema', 1, 4, 1),
(7, 'CRISS', '192.168.0.8', '20:54:19', '2015-11-12', 'Ingreso al sistema', 1, 4, 1),
(8, 'CRISS', '192.168.0.8', '21:12:45', '2015-11-12', 'Ingreso al sistema', 1, 4, 1),
(9, 'CRISS', '192.168.0.8', '21:17:13', '2015-11-12', 'Ingreso al sistema', 1, 4, 1),
(10, 'CRISS', '192.168.0.8', '21:28:22', '2015-11-12', 'Ingreso al sistema', 1, 4, 1),
(11, 'CRISS', '192.168.0.8', '21:29:00', '2015-11-12', 'Ingreso al sistema', 1, 4, 1),
(12, 'CRISS', '192.168.0.8', '21:30:27', '2015-11-12', 'Ingreso al sistema', 1, 4, 1),
(13, 'CRISS', '192.168.0.8', '21:37:50', '2015-11-12', 'Ingreso al sistema', 1, 4, 1),
(14, 'CRISS', '192.168.0.8', '21:38:43', '2015-11-12', 'Ingreso al sistema', 1, 4, 1),
(15, 'CRISS', '192.168.0.8', '21:39:20', '2015-11-12', 'Ingreso al sistema', 1, 4, 1),
(16, 'CRISS', '192.168.0.8', '21:40:05', '2015-11-12', 'Ingreso al sistema', 1, 4, 1),
(17, 'CRISS', '192.168.0.8', '21:40:56', '2015-11-12', 'Ingreso al sistema', 1, 4, 1),
(18, 'CRISS', '192.168.0.8', '21:41:39', '2015-11-12', 'Ingreso al sistema', 1, 4, 1),
(19, 'CRISS', '192.168.0.8', '21:42:19', '2015-11-12', 'Ingreso al sistema', 1, 4, 1),
(20, 'CRISS', '192.168.0.8', '21:44:34', '2015-11-12', 'Ingreso al sistema', 1, 4, 1),
(21, 'CRISS', '192.168.0.8', '21:45:08', '2015-11-12', 'Ingreso al sistema', 1, 4, 1),
(22, 'CRISS', '192.168.0.8', '21:48:18', '2015-11-12', 'Ingreso al sistema', 1, 4, 1),
(23, 'CRISS', '192.168.0.8', '21:49:33', '2015-11-12', 'Ingreso al sistema', 1, 4, 1),
(24, 'CRISS', '192.168.0.8', '21:51:11', '2015-11-12', 'Ingreso al sistema', 1, 4, 1),
(25, 'CRISS', '192.168.0.8', '21:56:20', '2015-11-12', 'Ingreso al sistema', 1, 4, 1),
(26, 'CRISS', '192.168.0.8', '22:01:37', '2015-11-12', 'Ingreso al sistema', 1, 4, 1),
(27, 'CRISS', '192.168.0.8', '22:03:12', '2015-11-12', 'Ingreso al sistema', 1, 4, 1),
(28, 'CRISS', '192.168.0.8', '22:03:35', '2015-11-12', 'Ingreso al sistema', 1, 4, 1),
(29, 'CRISS', '192.168.0.8', '22:10:54', '2015-11-12', 'Ingreso al sistema', 1, 4, 1),
(30, 'CRISS', '192.168.0.8', '22:24:05', '2015-11-12', 'Ingreso al sistema', 1, 4, 1),
(31, 'CRISS', '192.168.0.8', '22:32:21', '2015-11-12', 'Ingreso al sistema', 1, 4, 1),
(32, 'CRISS', '192.168.0.8', '23:18:30', '2015-11-12', 'Ingreso al sistema', 1, 4, 1),
(33, 'CRISS', '192.168.0.8', '23:21:49', '2015-11-12', 'Ingreso al sistema', 1, 4, 1),
(34, 'CRISS', '192.168.0.8', '23:27:17', '2015-11-12', 'Ingreso al sistema', 1, 4, 1),
(35, 'CRISS', '192.168.0.8', '23:30:09', '2015-11-12', 'Ingreso al sistema', 1, 4, 1),
(36, 'CRISS', '192.168.0.8', '23:31:57', '2015-11-12', 'Ingreso al sistema', 1, 4, 1),
(37, 'CRISS', '192.168.0.8', '23:34:10', '2015-11-12', 'Ingreso al sistema', 1, 4, 1),
(38, 'CRISS', '192.168.0.8', '23:42:14', '2015-11-12', 'Ingreso al sistema', 1, 4, 1),
(39, 'CRISS', '192.168.0.8', '23:44:58', '2015-11-12', 'Ingreso al sistema', 1, 4, 1),
(40, 'CRISS', '192.168.0.8', '00:03:28', '2015-11-13', 'Ingreso al sistema', 1, 4, 1),
(41, 'CRISS', '192.168.0.8', '00:06:12', '2015-11-13', 'Ingreso al sistema', 1, 4, 1),
(42, 'CRISS', '192.168.0.8', '00:31:27', '2015-11-13', 'Ingreso al sistema', 1, 4, 1),
(43, 'CRISS', '192.168.0.8', '00:32:30', '2015-11-13', 'Ingreso al sistema', 1, 4, 1),
(44, 'CRISS', '192.168.0.8', '00:56:29', '2015-11-13', 'Ingreso al sistema', 1, 4, 1),
(45, 'CRISS', '10.1.90.232', '07:59:43', '2015-11-13', 'Ingreso al sistema', 1, 4, 1),
(46, 'CRISS', '10.1.90.232', '08:44:21', '2015-11-13', 'Ingreso al sistema', 1, 4, 1),
(47, 'CRISS', '10.1.90.232', '08:45:57', '2015-11-13', 'Ingreso al sistema', 1, 4, 1),
(48, 'CRISS', '192.168.0.104', '09:11:03', '2015-11-13', 'Ingreso al sistema', 1, 4, 1),
(49, 'CRISS', '192.168.0.104', '09:23:46', '2015-11-13', 'Ingreso al sistema', 1, 4, 1),
(50, 'CRISS', '192.168.0.104', '09:34:35', '2015-11-13', 'Ingreso al sistema', 1, 4, 1),
(51, 'CRISS', '169.254.127.72', '10:08:01', '2015-11-13', 'Ingreso al sistema', 1, 4, 1),
(52, 'CRISS', '192.168.0.4', '21:46:52', '2015-11-15', 'Ingreso al sistema', 1, 4, 1);

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `mabodega`
--

CREATE TABLE IF NOT EXISTS `mabodega` (
  `ncodbodega` int(11) NOT NULL,
  `vnombrebodega` varchar(30) DEFAULT NULL,
  `vdireccionbodega` varchar(40) DEFAULT NULL,
  `vstatus` varchar(20) NOT NULL
) ENGINE=MyISAM AUTO_INCREMENT=6 DEFAULT CHARSET=latin1;

--
-- Volcado de datos para la tabla `mabodega`
--

INSERT INTO `mabodega` (`ncodbodega`, `vnombrebodega`, `vdireccionbodega`, `vstatus`) VALUES
(1, 'Bodega Principal', 'Guatemala', 'ACTIVO'),
(2, 'Bodega Segunda', 'Guatemala', 'ACTIVO'),
(3, 'Bodega 3', 'Mixco', 'ACTIVO'),
(4, 'Bodega 4', 'Mixco', 'ACTIVO'),
(5, 'Bodega sur', 'villa nueva', 'ACTIVO');

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
  `ncodvendedor` int(11) DEFAULT NULL,
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
-- Estructura de tabla para la tabla `maclientecobro`
--

CREATE TABLE IF NOT EXISTS `maclientecobro` (
  `ncodcliente` int(11) NOT NULL,
  `vnit` char(25) DEFAULT NULL,
  `vnombrecliente` char(50) DEFAULT NULL,
  `vapellidocliente` char(50) DEFAULT NULL,
  `vdireccion` char(50) DEFAULT NULL,
  `ntelefono` int(11) DEFAULT NULL,
  `vcorreo` char(50) DEFAULT NULL,
  `vestado` char(25) DEFAULT NULL,
  `nsaldo` decimal(10,2) DEFAULT NULL
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
  `nsaldo` decimal(10,2) DEFAULT NULL,
  `nnocuenta` decimal(10,0) DEFAULT NULL,
  `cestado` char(25) DEFAULT NULL,
  `ncodbanco` int(11) NOT NULL
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
  `vestado` varchar(20) DEFAULT NULL,
  `vfechaemision` varchar(30) DEFAULT NULL,
  `ntotalpago` decimal(10,2) DEFAULT NULL,
  `ndeudaactual` decimal(10,2) DEFAULT NULL,
  `vdescripcioncompra` varchar(30) DEFAULT NULL,
  `vnumerodocfisico` varchar(30) DEFAULT NULL,
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
  `ncodusuario` int(11) DEFAULT NULL
) ENGINE=MyISAM DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `maempleadobanco`
--

CREATE TABLE IF NOT EXISTS `maempleadobanco` (
  `ncodempleado` int(11) NOT NULL,
  `cnombre` char(40) DEFAULT NULL,
  `nsalario` decimal(18,2) DEFAULT NULL,
  `nnocuenta` decimal(18,0) DEFAULT NULL,
  `cestado` char(25) DEFAULT NULL
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
  `cpagado` char(25) DEFAULT NULL,
  `ncodcliente` int(11) NOT NULL,
  `ncodvendedor` int(11) NOT NULL
) ENGINE=MyISAM DEFAULT CHARSET=latin1;

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
) ENGINE=MyISAM DEFAULT CHARSET=latin1;

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
  `ncantidad` int(10) DEFAULT NULL,
  `vestatus` varchar(10) DEFAULT NULL,
  `nprecio` decimal(18,2) DEFAULT NULL,
  `nconsulta` int(11) DEFAULT NULL
) ENGINE=MyISAM AUTO_INCREMENT=6 DEFAULT CHARSET=latin1;

--
-- Volcado de datos para la tabla `mamaterial`
--

INSERT INTO `mamaterial` (`ncodmaterial`, `vnombre`, `ncantidad`, `vestatus`, `nprecio`, `nconsulta`) VALUES
(2, 'clavos', 110, 'ACTIVO', '3.20', 110),
(3, 'tornillos', 200, 'ACTIVO', '20.00', 200),
(4, 'clavos', 0, 'INACTIVO', '3.20', 0),
(5, 'espuma', 40, 'ACTIVO', '5.00', 40);

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `mamodulo`
--

CREATE TABLE IF NOT EXISTS `mamodulo` (
  `ncodmodulo` int(11) NOT NULL,
  `vnombremodulo` varchar(20) DEFAULT NULL,
  `vdescripcion` varchar(50) DEFAULT NULL
) ENGINE=MyISAM AUTO_INCREMENT=5 DEFAULT CHARSET=latin1;

--
-- Volcado de datos para la tabla `mamodulo`
--

INSERT INTO `mamodulo` (`ncodmodulo`, `vnombremodulo`, `vdescripcion`) VALUES
(1, 'Seguridad', 'Seguridad Sistema'),
(2, 'Compras', 'Registro de Compras'),
(3, 'cuentas', 'cuentas'),
(4, 'Detalle', 'descripcion');

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `maordencompra`
--

CREATE TABLE IF NOT EXISTS `maordencompra` (
  `ncodordencompra` int(11) NOT NULL,
  `vstatusorden` varchar(20) DEFAULT NULL,
  `ncodproveedor` int(11) NOT NULL,
  `vdescripcioncompra` varchar(40) DEFAULT NULL,
  `ncantidad` int(10) DEFAULT NULL,
  `ncostototal` decimal(10,0) DEFAULT NULL,
  `ncodarticulo` int(11) NOT NULL,
  `vstatus` varchar(20) NOT NULL
) ENGINE=MyISAM AUTO_INCREMENT=11112 DEFAULT CHARSET=latin1;

--
-- Volcado de datos para la tabla `maordencompra`
--

INSERT INTO `maordencompra` (`ncodordencompra`, `vstatusorden`, `ncodproveedor`, `vdescripcioncompra`, `ncantidad`, `ncostototal`, `ncodarticulo`, `vstatus`) VALUES
(1001, 'inicial', 1, 'compra de camas', 20, '250', 3, 'INACTIVO'),
(2002, 'inicial', 2, 'compras', 20, '560', 2, 'INACTIVO'),
(11111, 'inicial', 1, 'gffh', 20, '150', 2, 'ACTIVO');

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `maordenproduccion`
--

CREATE TABLE IF NOT EXISTS `maordenproduccion` (
  `ncodordenes` int(11) NOT NULL,
  `vreferenciaproducto` varchar(30) DEFAULT NULL,
  `vinicioproduccion` varchar(30) DEFAULT NULL,
  `ventregaproducto` varchar(30) DEFAULT NULL,
  `vultimomovimiento` varchar(20) DEFAULT NULL,
  `nnodocumento` int(11) DEFAULT NULL,
  `ncantidadproductoafabricar` int(11) DEFAULT NULL,
  `ncantidadnoproductoterminado` int(11) DEFAULT NULL,
  `ncantidadproductofaltante` int(11) DEFAULT NULL,
  `vestatusorden` varchar(40) DEFAULT NULL,
  `ncodreceta` int(11) NOT NULL
) ENGINE=MyISAM DEFAULT CHARSET=latin1;

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
  `vdescripcion` varchar(30) DEFAULT NULL
) ENGINE=MyISAM AUTO_INCREMENT=4 DEFAULT CHARSET=latin1;

--
-- Volcado de datos para la tabla `maproducto`
--

INSERT INTO `maproducto` (`ncodarticulo`, `nexistencia`, `nprecio`, `vmarca`, `vnombre`, `vdescripcion`) VALUES
(2, '150', '25', 'Olimpia', 'Cama King', 'Cama grande'),
(3, '175', '32', 'Sheep', 'Semimatrimonial', 'Cama Mediana');

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `maproveedor`
--

CREATE TABLE IF NOT EXISTS `maproveedor` (
  `ncodproveedor` int(11) NOT NULL,
  `vnit` varchar(10) DEFAULT NULL,
  `vdescripcion` varchar(100) DEFAULT NULL,
  `vpais` varchar(20) DEFAULT NULL,
  `vtelefono` varchar(40) DEFAULT NULL,
  `vciudad` varchar(40) DEFAULT NULL,
  `vnombre` varchar(30) DEFAULT NULL,
  `vdireccion` varchar(30) DEFAULT NULL,
  `vestado` varchar(20) DEFAULT NULL
) ENGINE=MyISAM AUTO_INCREMENT=3 DEFAULT CHARSET=latin1;

--
-- Volcado de datos para la tabla `maproveedor`
--

INSERT INTO `maproveedor` (`ncodproveedor`, `vnit`, `vdescripcion`, `vpais`, `vtelefono`, `vciudad`, `vnombre`, `vdireccion`, `vestado`) VALUES
(1, '489226-7', 'Venta de Camas', 'Guatemala', '24323049', 'Guatemala', 'Josue', 'Mixco', 'Activo'),
(2, '45613-7', 'Vendedor', 'Guatemala', '2134545', 'Guatemala', 'Cristhiam', 'Mixco', 'Activo}');

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
  `nhorahombre` varchar(18) DEFAULT NULL,
  `vnombrereceta` varchar(20) DEFAULT NULL
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
  `vnombrerole` varchar(30) NOT NULL
) ENGINE=MyISAM AUTO_INCREMENT=4 DEFAULT CHARSET=latin1;

--
-- Volcado de datos para la tabla `marolusuario`
--

INSERT INTO `marolusuario` (`ncodrole`, `vnombrerole`) VALUES
(1, 'Superusuario'),
(2, 'Administrador'),
(3, 'vendedor');

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `matipodocumento`
--

CREATE TABLE IF NOT EXISTS `matipodocumento` (
  `ncodtipodocumento` int(11) NOT NULL,
  `vestado` varchar(20) DEFAULT NULL,
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
  `vnombredocumento` varchar(20) DEFAULT NULL,
  `vestado` char(25) DEFAULT NULL
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
) ENGINE=MyISAM AUTO_INCREMENT=5 DEFAULT CHARSET=latin1;

--
-- Volcado de datos para la tabla `mausuario`
--

INSERT INTO `mausuario` (`ncodusuario`, `vnombreusuario`, `vapellidousuario`, `vemailusuario`, `vusuario`, `vpassword`) VALUES
(1, 'root', 'root', 'root@root.com', 'Superusuario', 'dc76e9f0c0006e8f919e0c515c66dbba3982f785'),
(2, 'Administrador', 'Admin', '----', 'Administrador', '4e7afebcfbae000b22c7c85e5560f89a2a0280b4'),
(3, 'hector', 'cardona', '--', 'hcardona', '81bce1f3bf343c464685d875c626820cdb58e309'),
(4, 'cristhiam', 'duarte', '@gmail.com', 'criss', '40bd001563085fc35165329ea1ff5c5ecbdbbeef');

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
-- Estructura de tabla para la tabla `trcobro`
--

CREATE TABLE IF NOT EXISTS `trcobro` (
  `ncodcobro` int(11) NOT NULL,
  `npago` decimal(10,2) DEFAULT NULL,
  `nsaldo` decimal(10,2) DEFAULT NULL,
  `dfecha` date DEFAULT NULL,
  `nmora` decimal(10,2) DEFAULT NULL,
  `ncoddocumento` int(11) NOT NULL,
  `ncodfactura` int(11) DEFAULT NULL
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
-- Estructura de tabla para la tabla `trcreditodebito`
--

CREATE TABLE IF NOT EXISTS `trcreditodebito` (
  `ncoddocumento` int(11) NOT NULL,
  `dfecha` date DEFAULT NULL,
  `nmonto` decimal(18,2) DEFAULT NULL,
  `ncodtipotransaccion` int(11) DEFAULT NULL,
  `ncodfactura` int(11) DEFAULT NULL
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
  `dmonto` decimal(10,2) DEFAULT NULL,
  `ncodtipotransaccion` int(11) NOT NULL,
  `ncodcuenta` int(11) NOT NULL
) ENGINE=MyISAM DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `trdocumentosaceptados`
--

CREATE TABLE IF NOT EXISTS `trdocumentosaceptados` (
  `ncodaceptacion` int(11) NOT NULL,
  `cestado` char(25) DEFAULT NULL,
  `nmonto` decimal(18,2) DEFAULT NULL,
  `ncoddocumento` int(11) DEFAULT NULL
) ENGINE=MyISAM DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `trexistencia`
--

CREATE TABLE IF NOT EXISTS `trexistencia` (
  `nexistencia` int(11) NOT NULL,
  `ncodbodega` int(11) NOT NULL,
  `ncodarticulo` int(11) NOT NULL
) ENGINE=MyISAM AUTO_INCREMENT=3 DEFAULT CHARSET=latin1;

--
-- Volcado de datos para la tabla `trexistencia`
--

INSERT INTO `trexistencia` (`nexistencia`, `ncodbodega`, `ncodarticulo`) VALUES
(1, 4, 2),
(2, 5, 3);

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
-- Estructura de tabla para la tabla `trpagoempleado`
--

CREATE TABLE IF NOT EXISTS `trpagoempleado` (
  `ncodpagoempleado` int(11) NOT NULL,
  `ncodempleado` int(11) DEFAULT NULL,
  `ncoddocumento` int(11) DEFAULT NULL
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
('maproducto', '13/11/2015 0:56:49', '1', 1, 4),
('maordencompra', '13/11/2015 9:14:54', '1', 1, 4);

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
(2, 8, b'0', b'0', b'0', b'0', b'0', b'0', b'0', b'0', b'0', b'0', b'0', b'0');

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
(2, 1, b'0', b'0', b'0', b'0', b'0', b'0', b'0', b'0', b'0', b'0', b'0', b'0');

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
(4, 2);

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
-- Indices de la tabla `maclientecobro`
--
ALTER TABLE `maclientecobro`
  ADD PRIMARY KEY (`ncodcliente`);

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
  ADD KEY `RefMaCLIENTE101` (`ncodcliente`);

--
-- Indices de la tabla `macuenta`
--
ALTER TABLE `macuenta`
  ADD PRIMARY KEY (`ncodcuenta`),
  ADD KEY `RefMaBANCO51` (`ncodbanco`);

--
-- Indices de la tabla `madetallecotizacion`
--
ALTER TABLE `madetallecotizacion`
  ADD KEY `RefMaCOTIZACION102` (`ncodcotizacion`),
  ADD KEY `RefMaPRODUCTO103` (`ncodarticulo`);

--
-- Indices de la tabla `madetallefactura`
--
ALTER TABLE `madetallefactura`
  ADD KEY `RefMaPRODUCTO61` (`ncodarticulo`),
  ADD KEY `RefMaFACTURA88` (`ncodfactura`);

--
-- Indices de la tabla `madetallepedido`
--
ALTER TABLE `madetallepedido`
  ADD KEY `RefTrPEDIDO104` (`ncodpedido`),
  ADD KEY `RefMaPRODUCTO105` (`ncodarticulo`);

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
  ADD KEY `RefMaUSUARIO74` (`ncodusuario`);

--
-- Indices de la tabla `maempleadobanco`
--
ALTER TABLE `maempleadobanco`
  ADD PRIMARY KEY (`ncodempleado`);

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
  ADD KEY `RefMaCUENTA109` (`ncodcuenta`);

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
-- Indices de la tabla `mafacturacobro`
--
ALTER TABLE `mafacturacobro`
  ADD PRIMARY KEY (`ncodfactura`),
  ADD KEY `RefMaCLIENTECOBRO119` (`ncodcliente`);

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
-- Indices de la tabla `maordencompra`
--
ALTER TABLE `maordencompra`
  ADD PRIMARY KEY (`ncodordencompra`),
  ADD KEY `RefMaPROVEEDOR32` (`ncodproveedor`),
  ADD KEY `RefMaPRODUCTO97` (`ncodarticulo`);

--
-- Indices de la tabla `maordenproduccion`
--
ALTER TABLE `maordenproduccion`
  ADD PRIMARY KEY (`ncodordenes`),
  ADD KEY `RefMaRECETA122` (`ncodreceta`);

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
  ADD PRIMARY KEY (`ncodarticulo`);

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
  ADD PRIMARY KEY (`ncodreceta`);

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
-- Indices de la tabla `trcobro`
--
ALTER TABLE `trcobro`
  ADD PRIMARY KEY (`ncodcobro`),
  ADD KEY `RefTrDOCUMENTOS71` (`ncoddocumento`),
  ADD KEY `RefMaFACTURACOBRO120` (`ncodfactura`);

--
-- Indices de la tabla `trcompra`
--
ALTER TABLE `trcompra`
  ADD KEY `RefMaPRODUCTO11` (`ncodarticulo`),
  ADD KEY `RefMaPROVEEDOR12` (`ncodproveedor`),
  ADD KEY `RefTrORDENPRODUCTO81` (`ncodorden`);

--
-- Indices de la tabla `trcreditodebito`
--
ALTER TABLE `trcreditodebito`
  ADD PRIMARY KEY (`ncoddocumento`),
  ADD KEY `RefMaTIPOTRANSACCION118` (`ncodtipotransaccion`),
  ADD KEY `RefMaFACTURACOBRO121` (`ncodfactura`);

--
-- Indices de la tabla `trdetalleconciliacion`
--
ALTER TABLE `trdetalleconciliacion`
  ADD PRIMARY KEY (`ncodDetalleConci`),
  ADD KEY `RefMaENCABEZADOCONCILIACION107` (`ncodconcilicacion`),
  ADD KEY `RefTrDOCUMENTOS108` (`ncoddocumento`);

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
  ADD KEY `RefMaTIPOTRANSACCION23` (`ncodtipotransaccion`),
  ADD KEY `RefMaCUENTA40` (`ncodcuenta`);

--
-- Indices de la tabla `trdocumentosaceptados`
--
ALTER TABLE `trdocumentosaceptados`
  ADD PRIMARY KEY (`ncodaceptacion`),
  ADD KEY `RefTrDOCUMENTOS117` (`ncoddocumento`);

--
-- Indices de la tabla `trexistencia`
--
ALTER TABLE `trexistencia`
  ADD PRIMARY KEY (`nexistencia`),
  ADD KEY `RefMaBODEGA47` (`ncodbodega`),
  ADD KEY `RefMaPRODUCTO67` (`ncodarticulo`);

--
-- Indices de la tabla `trgrafica`
--
ALTER TABLE `trgrafica`
  ADD PRIMARY KEY (`ncodgrafica`),
  ADD KEY `RefTrREPORTE2` (`vnomreporte`);

--
-- Indices de la tabla `trmovimiento`
--
ALTER TABLE `trmovimiento`
  ADD PRIMARY KEY (`ncodmovimiento`),
  ADD KEY `RefMaTIPOMOVIMIENTO49` (`ncodmoviemiento`),
  ADD KEY `RefMaPRODUCTO78` (`ncodarticulo`);

--
-- Indices de la tabla `trordenproducto`
--
ALTER TABLE `trordenproducto`
  ADD PRIMARY KEY (`ncodorden`),
  ADD KEY `RefMaPRODUCTO28` (`ncodarticulo`);

--
-- Indices de la tabla `trpagoempleado`
--
ALTER TABLE `trpagoempleado`
  ADD PRIMARY KEY (`ncodpagoempleado`),
  ADD KEY `RefMaEMPLEADOBANCO115` (`ncodempleado`),
  ADD KEY `RefTrDOCUMENTOS116` (`ncoddocumento`);

--
-- Indices de la tabla `trpagoproveedor`
--
ALTER TABLE `trpagoproveedor`
  ADD PRIMARY KEY (`ncodpagoproveedor`),
  ADD KEY `RefMaPROVEEDOR95` (`ncodproveedor`),
  ADD KEY `RefTrDOCUMENTOS98` (`ncoddocumento`);

--
-- Indices de la tabla `trpagos`
--
ALTER TABLE `trpagos`
  ADD PRIMARY KEY (`ncodpago`),
  ADD KEY `RefMaTIPOPAGO9` (`ncodtipopago`),
  ADD KEY `RefTrDOCUMENTOS31` (`ncoddocumento`),
  ADD KEY `RefMaCUENTA80` (`ncodcuenta`),
  ADD KEY `RefMaRECIBOPAGO93` (`ncodrecibopago`);

--
-- Indices de la tabla `trpedido`
--
ALTER TABLE `trpedido`
  ADD PRIMARY KEY (`ncodpedido`),
  ADD KEY `RefMaVENDEDOR6` (`ncodvendedor`),
  ADD KEY `RefMaVENTAS34` (`ncodventas`),
  ADD KEY `RefMaPRODUCTO82` (`ncodarticulo`),
  ADD KEY `RefMaCLIENTE100` (`ncodcliente`);

--
-- Indices de la tabla `trplanilla`
--
ALTER TABLE `trplanilla`
  ADD KEY `RefMaEMPLEADO25` (`ncodempleado`),
  ADD KEY `RefMaEMPRESA27` (`ncodempresa`);

--
-- Indices de la tabla `trreporte`
--
ALTER TABLE `trreporte`
  ADD PRIMARY KEY (`vnomreporte`),
  ADD KEY `RefMaUSUARIO72` (`ncodusuario`),
  ADD KEY `RefMaMODULO113` (`ncodmodulo`);

--
-- Indices de la tabla `trroletoaplicacion`
--
ALTER TABLE `trroletoaplicacion`
  ADD KEY `RefMaROLUSUARIO50` (`ncodrole`),
  ADD KEY `RefMaAPLICACION52` (`ncodaplicacion`);

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
  MODIFY `ncodaplicacion` int(11) NOT NULL AUTO_INCREMENT,AUTO_INCREMENT=15;
--
-- AUTO_INCREMENT de la tabla `mabanco`
--
ALTER TABLE `mabanco`
  MODIFY `ncodbanco` int(11) NOT NULL AUTO_INCREMENT;
--
-- AUTO_INCREMENT de la tabla `mabitacora`
--
ALTER TABLE `mabitacora`
  MODIFY `ncodbitacora` int(11) NOT NULL AUTO_INCREMENT,AUTO_INCREMENT=53;
--
-- AUTO_INCREMENT de la tabla `mabodega`
--
ALTER TABLE `mabodega`
  MODIFY `ncodbodega` int(11) NOT NULL AUTO_INCREMENT,AUTO_INCREMENT=6;
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
-- AUTO_INCREMENT de la tabla `maclientecobro`
--
ALTER TABLE `maclientecobro`
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
-- AUTO_INCREMENT de la tabla `maempleadobanco`
--
ALTER TABLE `maempleadobanco`
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
-- AUTO_INCREMENT de la tabla `mafacturacobro`
--
ALTER TABLE `mafacturacobro`
  MODIFY `ncodfactura` int(11) NOT NULL AUTO_INCREMENT;
--
-- AUTO_INCREMENT de la tabla `malocacion`
--
ALTER TABLE `malocacion`
  MODIFY `ncodlocacion` int(11) NOT NULL AUTO_INCREMENT;
--
-- AUTO_INCREMENT de la tabla `mamaterial`
--
ALTER TABLE `mamaterial`
  MODIFY `ncodmaterial` int(11) NOT NULL AUTO_INCREMENT,AUTO_INCREMENT=6;
--
-- AUTO_INCREMENT de la tabla `mamodulo`
--
ALTER TABLE `mamodulo`
  MODIFY `ncodmodulo` int(11) NOT NULL AUTO_INCREMENT,AUTO_INCREMENT=5;
--
-- AUTO_INCREMENT de la tabla `maordencompra`
--
ALTER TABLE `maordencompra`
  MODIFY `ncodordencompra` int(11) NOT NULL AUTO_INCREMENT,AUTO_INCREMENT=11112;
--
-- AUTO_INCREMENT de la tabla `maordenproduccion`
--
ALTER TABLE `maordenproduccion`
  MODIFY `ncodordenes` int(11) NOT NULL AUTO_INCREMENT;
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
  MODIFY `ncodarticulo` int(11) NOT NULL AUTO_INCREMENT,AUTO_INCREMENT=4;
--
-- AUTO_INCREMENT de la tabla `maproveedor`
--
ALTER TABLE `maproveedor`
  MODIFY `ncodproveedor` int(11) NOT NULL AUTO_INCREMENT,AUTO_INCREMENT=3;
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
  MODIFY `ncodrole` int(11) NOT NULL AUTO_INCREMENT,AUTO_INCREMENT=4;
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
-- AUTO_INCREMENT de la tabla `mausuario`
--
ALTER TABLE `mausuario`
  MODIFY `ncodusuario` int(11) NOT NULL AUTO_INCREMENT,AUTO_INCREMENT=5;
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
-- AUTO_INCREMENT de la tabla `trcobro`
--
ALTER TABLE `trcobro`
  MODIFY `ncodcobro` int(11) NOT NULL AUTO_INCREMENT;
--
-- AUTO_INCREMENT de la tabla `trcreditodebito`
--
ALTER TABLE `trcreditodebito`
  MODIFY `ncoddocumento` int(11) NOT NULL AUTO_INCREMENT;
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
-- AUTO_INCREMENT de la tabla `trdocumentosaceptados`
--
ALTER TABLE `trdocumentosaceptados`
  MODIFY `ncodaceptacion` int(11) NOT NULL AUTO_INCREMENT;
--
-- AUTO_INCREMENT de la tabla `trexistencia`
--
ALTER TABLE `trexistencia`
  MODIFY `nexistencia` int(11) NOT NULL AUTO_INCREMENT,AUTO_INCREMENT=3;
--
-- AUTO_INCREMENT de la tabla `trgrafica`
--
ALTER TABLE `trgrafica`
  MODIFY `ncodgrafica` int(11) NOT NULL AUTO_INCREMENT;
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
-- AUTO_INCREMENT de la tabla `trpagoempleado`
--
ALTER TABLE `trpagoempleado`
  MODIFY `ncodpagoempleado` int(11) NOT NULL AUTO_INCREMENT;
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
-- AUTO_INCREMENT de la tabla `trpedido`
--
ALTER TABLE `trpedido`
  MODIFY `ncodpedido` int(11) NOT NULL AUTO_INCREMENT;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
