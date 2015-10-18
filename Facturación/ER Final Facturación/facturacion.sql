--
-- ER/Studio 8.0 SQL Code Generation
-- Company :      umg
-- Project :      er facturacion.dm1
-- Author :       Jose
--
-- Date Created : Sunday, October 18, 2015 17:04:41
-- Target DBMS : MySQL 5.x
--

-- 
-- TABLE: MaCLIENTE 
--

CREATE TABLE MaCLIENTE(
    ncodcliente         DECIMAL(10, 0)    NOT NULL,
    vnombrecliente      VARCHAR(50),
    vapellidocliente    VARCHAR(50),
    vdireccion          VARCHAR(100),
    ntelefono           DECIMAL(10, 0),
    vcorreo             VARCHAR(30),
    vestado             VARCHAR(20),
    PRIMARY KEY (ncodcliente)
)ENGINE=MYISAM
;



-- 
-- TABLE: MaCOTIZACIÓN 
--

CREATE TABLE MaCOTIZACIÓN(
    ncodcotizacion       DECIMAL(10, 0)    NOT NULL,
    vserie               VARCHAR(10),
    vnombrecotizacion    VARCHAR(50),
    vnit                 VARCHAR(10),
    vdireccion           VARCHAR(50),
    dfechacotizacion     DATE,
    dfechavencimiento    DATE,
    ntotal               DECIMAL(10, 0),
    vestadocotizacion    VARCHAR(20),
    ncodcliente          DECIMAL(10, 0)    NOT NULL,
    vnombrevendedor      VARCHAR(100),
    PRIMARY KEY (ncodcotizacion)
)ENGINE=MYISAM
;



-- 
-- TABLE: MaDETALLECOTIZACION 
--

CREATE TABLE MaDETALLECOTIZACION(
    ncodcotizacion       DECIMAL(10, 0)    NOT NULL,
    ncodproducto         DECIMAL(10, 0)    NOT NULL,
    ncantidadcotizada    DECIMAL(10, 0),
    npreciocotizado      DECIMAL(10, 0)
)ENGINE=MYISAM
;



-- 
-- TABLE: MaDETALLEFACTURA 
--

CREATE TABLE MaDETALLEFACTURA(
    ncodfactura       DECIMAL(10, 0),
    ncodproducto      DECIMAL(10, 0),
    ncantidadventa    DECIMAL(10, 0),
    nprecioventa      DECIMAL(10, 0)
)ENGINE=MYISAM
;



-- 
-- TABLE: MaDETALLEPEDIDO 
--

CREATE TABLE MaDETALLEPEDIDO(
    ncodpedido         DECIMAL(10, 0)    NOT NULL,
    ncodproducto       DECIMAL(10, 0)    NOT NULL,
    ncantidadpedido    DECIMAL(10, 0),
    npreciopedido      DECIMAL(10, 0)
)ENGINE=MYISAM
;



-- 
-- TABLE: MaFACTURA 
--

CREATE TABLE MaFACTURA(
    ncodfactura          DECIMAL(10, 0)    NOT NULL,
    vserie               VARCHAR(10),
    vnombrefactura       VARCHAR(50),
    vnit                 VARCHAR(10),
    vdireccion           VARCHAR(50),
    dfechafactura        DATE,
    dfechavencimiento    DATE,
    ntotal               DECIMAL(10, 0),
    vestadofactura       VARCHAR(20),
    ncodcliente          DECIMAL(10, 0),
    PRIMARY KEY (ncodfactura)
)ENGINE=MYISAM
;



-- 
-- TABLE: MaPEDIDO 
--

CREATE TABLE MaPEDIDO(
    ncodpedido           DECIMAL(10, 0)    NOT NULL,
    vserie               VARCHAR(10),
    vnombrepedido        VARCHAR(50),
    vnit                 VARCHAR(10),
    vdireccion           VARCHAR(50),
    dfechapedido         DATE,
    dfechavencimiento    DATE,
    ntotal               DECIMAL(10, 0),
    vestadopedido        VARCHAR(20),
    ncodcliente          DECIMAL(10, 0)    NOT NULL,
    vnombrevendedor      VARCHAR(100),
    PRIMARY KEY (ncodpedido)
)ENGINE=MYISAM
;



-- 
-- TABLE: MaPRODUCTO 
--

CREATE TABLE MaPRODUCTO(
    ncodproducto        DECIMAL(10, 0)    NOT NULL,
    vnombreproducto     VARCHAR(50),
    vmarca              VARCHAR(20),
    vdescripcion        VARCHAR(50),
    ncantidad           DECIMAL(10, 0),
    nprecio             DECIMAL(10, 0),
    ncodtipoproducto    DECIMAL(10, 0),
    PRIMARY KEY (ncodproducto)
)ENGINE=MYISAM
;



-- 
-- TABLE: MaTIPOPRODUCTO 
--

CREATE TABLE MaTIPOPRODUCTO(
    ncodtipoproducto    DECIMAL(10, 0)    NOT NULL,
    descripcion         CHAR(30),
    PRIMARY KEY (ncodtipoproducto)
)ENGINE=MYISAM
;



-- 
-- TABLE: MaCOTIZACIÓN 
--

ALTER TABLE MaCOTIZACIÓN ADD CONSTRAINT RefMaCLIENTE11 
    FOREIGN KEY (ncodcliente)
    REFERENCES MaCLIENTE(ncodcliente)
;


-- 
-- TABLE: MaDETALLECOTIZACION 
--

ALTER TABLE MaDETALLECOTIZACION ADD CONSTRAINT RefMaCOTIZACIÓN15 
    FOREIGN KEY (ncodcotizacion)
    REFERENCES MaCOTIZACIÓN(ncodcotizacion)
;

ALTER TABLE MaDETALLECOTIZACION ADD CONSTRAINT RefMaPRODUCTO17 
    FOREIGN KEY (ncodproducto)
    REFERENCES MaPRODUCTO(ncodproducto)
;


-- 
-- TABLE: MaDETALLEFACTURA 
--

ALTER TABLE MaDETALLEFACTURA ADD CONSTRAINT RefMaFACTURA3 
    FOREIGN KEY (ncodfactura)
    REFERENCES MaFACTURA(ncodfactura)
;

ALTER TABLE MaDETALLEFACTURA ADD CONSTRAINT RefMaPRODUCTO4 
    FOREIGN KEY (ncodproducto)
    REFERENCES MaPRODUCTO(ncodproducto)
;


-- 
-- TABLE: MaDETALLEPEDIDO 
--

ALTER TABLE MaDETALLEPEDIDO ADD CONSTRAINT RefMaPEDIDO18 
    FOREIGN KEY (ncodpedido)
    REFERENCES MaPEDIDO(ncodpedido)
;

ALTER TABLE MaDETALLEPEDIDO ADD CONSTRAINT RefMaPRODUCTO19 
    FOREIGN KEY (ncodproducto)
    REFERENCES MaPRODUCTO(ncodproducto)
;


-- 
-- TABLE: MaFACTURA 
--

ALTER TABLE MaFACTURA ADD CONSTRAINT RefMaCLIENTE2 
    FOREIGN KEY (ncodcliente)
    REFERENCES MaCLIENTE(ncodcliente)
;


-- 
-- TABLE: MaPEDIDO 
--

ALTER TABLE MaPEDIDO ADD CONSTRAINT RefMaCLIENTE8 
    FOREIGN KEY (ncodcliente)
    REFERENCES MaCLIENTE(ncodcliente)
;


-- 
-- TABLE: MaPRODUCTO 
--

ALTER TABLE MaPRODUCTO ADD CONSTRAINT RefMaTIPOPRODUCTO1 
    FOREIGN KEY (ncodtipoproducto)
    REFERENCES MaTIPOPRODUCTO(ncodtipoproducto)
;


