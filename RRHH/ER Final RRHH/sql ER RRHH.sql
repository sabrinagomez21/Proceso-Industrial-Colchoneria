--
--ER/Studio 7.0 SQL Code Generation
-- Project :      ER RRHH.dm1
--
-- Date Created : Thursday, September 24, 2015 21:05:27
-- Target DBMS : MySQL 4.x
--

-- 
-- TABLE: MaCapacitacion 
--

CREATE TABLE MaCapacitacion(
    ncodcapacitacion    DECIMAL(10, 0)    NOT NULL,
    ncodempleado        DECIMAL(10, 0)    NOT NULL,
    vnomcapacitacion    VARCHAR(20),
    vtipo               VARCHAR(30),
    ncodempresa         DECIMAL(10, 0)    NOT NULL,
    PRIMARY KEY (ncodcapacitacion)
)TYPE=MYISAM
;



-- 
-- TABLE: MaDepartamento 
--

CREATE TABLE MaDepartamento(
    ncoddep         DECIMAL(10, 0)    NOT NULL,
    vnomdep         VARCHAR(10),
    vtipo           VARCHAR(20),
    ncodempleado    DECIMAL(10, 0)    NOT NULL,
    ncodempresa     DECIMAL(10, 0)    NOT NULL,
    PRIMARY KEY (ncoddep)
)TYPE=MYISAM
;



-- 
-- TABLE: MaEmpleado 
--

CREATE TABLE MaEmpleado(
    ncodempleado    DECIMAL(10, 0)    NOT NULL,
    ncodempresa     DECIMAL(10, 0)    NOT NULL,
    vnomempleado    VARCHAR(25),
    vestadocivil    VARCHAR(15),
    vapeempleado    VARCHAR(30),
    vsalario        VARCHAR(10),
    vcomision       VARCHAR(10),
    vtipo           VARCHAR(10),
    escolaridad     VARCHAR(10),
    cargo           VARCHAR(15),
    ntelefono       DECIMAL(11, 0),
    vdpi            VARCHAR(11),
    nedad           DECIMAL(3, 0),
    vgenero         VARCHAR(10),
    PRIMARY KEY (ncodempleado, ncodempresa)
)TYPE=MYISAM
;



-- 
-- TABLE: MaEmpresa 
--

CREATE TABLE MaEmpresa(
    ncodempresa     DECIMAL(10, 0)    NOT NULL,
    vtipoempresa    VARCHAR(20),
    vnomempresa     VARCHAR(20),
    vdireccion      VARCHAR(20),
    ntelefono       DECIMAL(11, 0),
    vdescripcion    VARCHAR(80),
    PRIMARY KEY (ncodempresa)
)TYPE=MYISAM
;



-- 
-- TABLE: MaPlaza 
--

CREATE TABLE MaPlaza(
    ncodplaza        DECIMAL(10, 0)    NOT NULL,
    vtipo            VARCHAR(20),
    vdescripcion     VARCHAR(50),
    vsueldomin       VARCHAR(10),
    vsueldomax       VARCHAR(10),
    vhorario         VARCHAR(10),
    ncodempresa      DECIMAL(10, 0)    NOT NULL,
    ncodsolicitud    DECIMAL(10, 0)    NOT NULL,
    PRIMARY KEY (ncodplaza)
)TYPE=MYISAM
;



-- 
-- TABLE: Tractividadludica 
--

CREATE TABLE Tractividadludica(
    ncodactividad    VARCHAR(10)       NOT NULL,
    vtipo            VARCHAR(10),
    vnombre          VARCHAR(10),
    vdescripcion     VARCHAR(50),
    ncodempleado     DECIMAL(10, 0)    NOT NULL,
    ncodempresa      DECIMAL(10, 0)    NOT NULL,
    PRIMARY KEY (ncodactividad)
)TYPE=MYISAM
;



-- 
-- TABLE: TrCognitivo 
--

CREATE TABLE TrCognitivo(
    vtipo           VARCHAR(10)       NOT NULL,
    vdescripcion    VARCHAR(50),
    vestado         VARCHAR(10),
    ncodempleado    DECIMAL(10, 0)    NOT NULL,
    ncodempresa     DECIMAL(10, 0)    NOT NULL,
    PRIMARY KEY (vtipo)
)TYPE=MYISAM
;



-- 
-- TABLE: TrContrato 
--

CREATE TABLE TrContrato(
    vtipocontrato    VARCHAR(10)       NOT NULL,
    dfechainicio     DATE,
    dfechafin        DATE,
    ncodempresa      DECIMAL(10, 0)    NOT NULL,
    ncodsolicitud    DECIMAL(10, 0)    NOT NULL
)TYPE=MYISAM
;



-- 
-- TABLE: TrEscolaridad 
--

CREATE TABLE TrEscolaridad(
    ncodescolaridad    DECIMAL(10, 0)    NOT NULL,
    vtipo              VARCHAR(20)       NOT NULL,
    vdescripcion       VARCHAR(80),
    PRIMARY KEY (ncodescolaridad)
)TYPE=MYISAM
;



-- 
-- TABLE: TrFamilia 
--

CREATE TABLE TrFamilia(
    ncodfamilia     DECIMAL(10, 0)    NOT NULL,
    vtipo           VARCHAR(10),
    vdescripcion    VARCHAR(80),
    PRIMARY KEY (ncodfamilia)
)TYPE=MYISAM
;



-- 
-- TABLE: Trhistoriaemp 
--

CREATE TABLE Trhistoriaemp(
    ncodhistoria     DECIMAL(10, 0)    NOT NULL,
    vdescripcion     VARCHAR(50),
    dfechainicio     DATE,
    dfechafin        DATE,
    vdepartamento    VARCHAR(20),
    ncodempleado     DECIMAL(10, 0)    NOT NULL,
    ncodempresa      DECIMAL(10, 0)    NOT NULL,
    PRIMARY KEY (ncodhistoria)
)TYPE=MYISAM
;



-- 
-- TABLE: TrLocacion 
--

CREATE TABLE TrLocacion(
    ncodlocacion    DECIMAL(10, 0)    NOT NULL,
    vdireccion      VARCHAR(20),
    ncodpostal      DECIMAL(10, 0),
    vciudad         VARCHAR(20),
    vprovincia      VARCHAR(20),
    ncodempleado    DECIMAL(10, 0)    NOT NULL,
    ncodempresa     DECIMAL(10, 0)    NOT NULL,
    PRIMARY KEY (ncodlocacion)
)TYPE=MYISAM
;



-- 
-- TABLE: TrPLANILLA 
--

CREATE TABLE TrPLANILLA(
    ncodsolicitud     DECIMAL(10, 0)    NOT NULL,
    ncodempresa       DECIMAL(10, 0)    NOT NULL,
    vprestaciones     VARCHAR(10),
    vhorasnormales    VARCHAR(10)       NOT NULL,
    vhorasextras      VARCHAR(10),
    PRIMARY KEY (ncodsolicitud, ncodempresa)
)TYPE=MYISAM
;



-- 
-- TABLE: TrSolicitud 
--

CREATE TABLE TrSolicitud(
    ncodsolicitud         DECIMAL(10, 0)    NOT NULL,
    fecha                 DATE,
    vnacionalidad         VARCHAR(10),
    vnopasaporte          VARCHAR(11),
    vhabitospersonales    VARCHAR(80),
    vpuestosolicitado     VARCHAR(20),
    vsueldosolicitado     VARCHAR(10),
    dfechanacimiento      DATE,
    ncodfamilia           DECIMAL(10, 0)    NOT NULL,
    ncodescolaridad       DECIMAL(10, 0)    NOT NULL,
    PRIMARY KEY (ncodsolicitud)
)TYPE=MYISAM
;



-- 
-- TABLE: MaCapacitacion 
--

ALTER TABLE MaCapacitacion ADD CONSTRAINT RefMaEmpleado7 
    FOREIGN KEY (ncodempleado, ncodempresa)
    REFERENCES MaEmpleado(ncodempleado, ncodempresa)
;


-- 
-- TABLE: MaDepartamento 
--

ALTER TABLE MaDepartamento ADD CONSTRAINT RefMaEmpleado13 
    FOREIGN KEY (ncodempleado, ncodempresa)
    REFERENCES MaEmpleado(ncodempleado, ncodempresa)
;


-- 
-- TABLE: MaEmpleado 
--

ALTER TABLE MaEmpleado ADD CONSTRAINT RefMaEmpresa20 
    FOREIGN KEY (ncodempresa)
    REFERENCES MaEmpresa(ncodempresa)
;


-- 
-- TABLE: MaPlaza 
--

ALTER TABLE MaPlaza ADD CONSTRAINT RefMaEmpresa15 
    FOREIGN KEY (ncodempresa)
    REFERENCES MaEmpresa(ncodempresa)
;

ALTER TABLE MaPlaza ADD CONSTRAINT RefTrSolicitud16 
    FOREIGN KEY (ncodsolicitud)
    REFERENCES TrSolicitud(ncodsolicitud)
;


-- 
-- TABLE: Tractividadludica 
--

ALTER TABLE Tractividadludica ADD CONSTRAINT RefMaEmpleado5 
    FOREIGN KEY (ncodempleado, ncodempresa)
    REFERENCES MaEmpleado(ncodempleado, ncodempresa)
;


-- 
-- TABLE: TrCognitivo 
--

ALTER TABLE TrCognitivo ADD CONSTRAINT RefMaEmpleado12 
    FOREIGN KEY (ncodempleado, ncodempresa)
    REFERENCES MaEmpleado(ncodempleado, ncodempresa)
;


-- 
-- TABLE: TrContrato 
--

ALTER TABLE TrContrato ADD CONSTRAINT RefMaEmpresa14 
    FOREIGN KEY (ncodempresa)
    REFERENCES MaEmpresa(ncodempresa)
;

ALTER TABLE TrContrato ADD CONSTRAINT RefTrSolicitud17 
    FOREIGN KEY (ncodsolicitud)
    REFERENCES TrSolicitud(ncodsolicitud)
;


-- 
-- TABLE: Trhistoriaemp 
--

ALTER TABLE Trhistoriaemp ADD CONSTRAINT RefMaEmpleado4 
    FOREIGN KEY (ncodempleado, ncodempresa)
    REFERENCES MaEmpleado(ncodempleado, ncodempresa)
;


-- 
-- TABLE: TrLocacion 
--

ALTER TABLE TrLocacion ADD CONSTRAINT RefMaEmpleado3 
    FOREIGN KEY (ncodempleado, ncodempresa)
    REFERENCES MaEmpleado(ncodempleado, ncodempresa)
;


-- 
-- TABLE: TrPLANILLA 
--

ALTER TABLE TrPLANILLA ADD CONSTRAINT RefTrSolicitud21 
    FOREIGN KEY (ncodsolicitud)
    REFERENCES TrSolicitud(ncodsolicitud)
;

ALTER TABLE TrPLANILLA ADD CONSTRAINT RefMaEmpresa22 
    FOREIGN KEY (ncodempresa)
    REFERENCES MaEmpresa(ncodempresa)
;


-- 
-- TABLE: TrSolicitud 
--

ALTER TABLE TrSolicitud ADD CONSTRAINT RefTrEscolaridad18 
    FOREIGN KEY (ncodescolaridad)
    REFERENCES TrEscolaridad(ncodescolaridad)
;

ALTER TABLE TrSolicitud ADD CONSTRAINT RefTrFamilia19 
    FOREIGN KEY (ncodfamilia)
    REFERENCES TrFamilia(ncodfamilia)
;


