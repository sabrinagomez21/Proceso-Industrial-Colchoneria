--
-- ER/Studio Data Architect 11.0 SQL Code Generation
-- Project :      ER-Final-Definitiva.dm1
--
-- Date Created : Monday, November 09, 2015 11:02:01
-- Target DBMS : MySQL 5.x
--

-- 
-- TABLE: MaACCIONES 
--

CREATE TABLE MaACCIONES(
    ncodaccion       INT            AUTO_INCREMENT,
    vnombreaccion    VARCHAR(40),
    PRIMARY KEY (ncodaccion)
)ENGINE=MYISAM
;



-- 
-- TABLE: MaAPLICACION 
--

CREATE TABLE MaAPLICACION(
    ncodaplicacion       INT            AUTO_INCREMENT,
    vnombreaplicacion    VARCHAR(30),
    ncodmodulo           INT            NOT NULL,
    vnombreformulario    VARCHAR(40),
    PRIMARY KEY (ncodaplicacion)
)ENGINE=MYISAM
;



-- 
-- TABLE: MaBANCO 
--

CREATE TABLE MaBANCO(
    ncodbanco       INT            AUTO_INCREMENT,
    vnombrebanco    VARCHAR(18),
    vdireccion      VARCHAR(30),
    cestado         CHAR(20),
    PRIMARY KEY (ncodbanco)
)ENGINE=MYISAM
;



-- 
-- TABLE: MaBITACORA 
--

CREATE TABLE MaBITACORA(
    ncodbitacora      INT             AUTO_INCREMENT,
    vnombreequipo     VARCHAR(25),
    vipequipo         VARCHAR(20),
    dhora             TIME,
    dfecha            DATE,
    vdetalleaccion    VARCHAR(100),
    ncodaccion        INT             NOT NULL,
    ncodusuario       INT             NOT NULL,
    ncodaplicacion    INT             NOT NULL,
    PRIMARY KEY (ncodbitacora)
)ENGINE=MYISAM
;



-- 
-- TABLE: MaBODEGA 
--

CREATE TABLE MaBODEGA(
    ncodbodega          INT            AUTO_INCREMENT,
    vnombrebodega       VARCHAR(30),
    vdireccionbodega    VARCHAR(40),
    PRIMARY KEY (ncodbodega)
)ENGINE=MYISAM
;



-- 
-- TABLE: MaCAPACITACION 
--

CREATE TABLE MaCAPACITACION(
    ncodcapacitacion        INT            AUTO_INCREMENT,
    vnecesidad              VARCHAR(20),
    vobjetivo               VARCHAR(20),
    vresultadosesperados    VARCHAR(30),
    vresponsable            VARCHAR(30),
    vdetalle                VARCHAR(60),
    iparticipantes          INT,
    vtiempo                 VARCHAR(10),
    vnombrecapacitacion     VARCHAR(10),
    vtipo                   VARCHAR(10),
    ncodempleado            INT            NOT NULL,
    PRIMARY KEY (ncodcapacitacion)
)ENGINE=MYISAM
;



-- 
-- TABLE: MaCLIENTE 
--

CREATE TABLE MaCLIENTE(
    ncodcliente         INT            AUTO_INCREMENT,
    vnit                VARCHAR(18),
    vnombrecliente      VARCHAR(30),
    vapellidocliente    VARCHAR(40),
    vdireccion          VARCHAR(30),
    ntelefono           INT,
    vcorreo             VARCHAR(30),
    vestado             VARCHAR(20),
    PRIMARY KEY (ncodcliente)
)ENGINE=MYISAM
;



-- 
-- TABLE: MaCOGNITIVO 
--

CREATE TABLE MaCOGNITIVO(
    vtipo           VARCHAR(10),
    vdescripcion    VARCHAR(30),
    vestado         VARCHAR(10),
    ncodempleado    INT            NOT NULL
)ENGINE=MYISAM
;



-- 
-- TABLE: MaCOMPRA 
--

CREATE TABLE MaCOMPRA(
    ncodcompra            INT               AUTO_INCREMENT,
    vdescripcioncompra    VARCHAR(100),
    ncantidad             DECIMAL(10, 0),
    ncostototal           DECIMAL(10, 0),
    PRIMARY KEY (ncodcompra)
)ENGINE=MYISAM
;



-- 
-- TABLE: MaCOTIZACION 
--

CREATE TABLE MaCOTIZACION(
    ncodcotizacion       INT               NOT NULL,
    vserie               VARCHAR(10),
    dfechacotizacion     DATE,
    dfechavencimiento    DATE,
    ntotal               DECIMAL(10, 0),
    vestadocotizacion    VARCHAR(10),
    ncodcliente          INT               NOT NULL,
    vnombrevendedor      VARCHAR(25),
    ncodvendedor         INT               NOT NULL,
    PRIMARY KEY (ncodcotizacion)
)ENGINE=MYISAM
;



-- 
-- TABLE: MaCUENTA 
--

CREATE TABLE MaCUENTA(
    ncodcuenta       INT               AUTO_INCREMENT,
    nsaldo           DECIMAL(10, 0),
    ncodbanco        INT               NOT NULL,
    ncoddocumento    INT               NOT NULL,
    ncodempleado     INT,
    PRIMARY KEY (ncodcuenta)
)ENGINE=MYISAM
;



-- 
-- TABLE: MaDETALLECOTIZACION 
--

CREATE TABLE MaDETALLECOTIZACION(
    ncodcotizacion       INT               NOT NULL,
    ncantidadcotizada    DECIMAL(10, 0),
    npreciocotizado      DECIMAL(10, 0),
    ncodarticulo         INT               NOT NULL
)ENGINE=MYISAM
;



-- 
-- TABLE: MaDETALLEFACTURA 
--

CREATE TABLE MaDETALLEFACTURA(
    ncodarticulo      INT    NOT NULL,
    ncantidadventa    INT    NOT NULL,
    nprecioventa      INT,
    ncodfactura       INT    NOT NULL
)ENGINE=MYISAM
;



-- 
-- TABLE: MaDETALLEPEDIDO 
--

CREATE TABLE MaDETALLEPEDIDO(
    ncodpedido         INT               NOT NULL,
    dcodproducto       DECIMAL(10, 0),
    dcantidadpedido    DECIMAL(10, 0),
    dpreciopedido      DECIMAL(10, 0),
    ncodarticulo       INT               NOT NULL
)ENGINE=MYISAM
;



-- 
-- TABLE: MaDOCPORPAGAR 
--

CREATE TABLE MaDOCPORPAGAR(
    ndocumento            INT               AUTO_INCREMENT,
    vfechaemision         DATE,
    ntotalpago            DECIMAL(10, 0),
    ndeudaactual          DECIMAL(10, 0),
    vdescripcioncompra    VARCHAR(30),
    vnumerodocfisico      VARCHAR(10),
    ncodproveedor         INT               NOT NULL,
    ncodtipodocumento     INT               NOT NULL,
    PRIMARY KEY (ndocumento)
)ENGINE=MYISAM
;



-- 
-- TABLE: MaEMPLEADO 
--

CREATE TABLE MaEMPLEADO(
    ncodempleado         INT               AUTO_INCREMENT,
    vnombreempleado      VARCHAR(40),
    vapellidoempleado    VARCHAR(40),
    vestadocivil         VARCHAR(30),
    nsalario             DECIMAL(10, 0),
    ncomision            DECIMAL(10, 0),
    vtipo                VARCHAR(30),
    vescolaridad         VARCHAR(30),
    ntelefono            DECIMAL(10, 0),
    vcargo               VARCHAR(30),
    vdpi                 VARCHAR(10),
    nedad                DECIMAL(10, 0),
    vgenero              VARCHAR(30),
    nnumcuenta           DECIMAL(10, 0),
    ncodhistoria         INT               NOT NULL,
    ncoddepartamento     INT               NOT NULL,
    ncodusuario          INT,
    PRIMARY KEY (ncodempleado)
)ENGINE=MYISAM
;



-- 
-- TABLE: MaEMPRESA 
--

CREATE TABLE MaEMPRESA(
    ncodempresa       INT               NOT NULL,
    vpuestovacante    VARCHAR(20),
    vnomempresa       VARCHAR(20),
    vdescripcion      VARCHAR(50),
    vtipoempresa      VARCHAR(40),
    vnombreempresa    VARCHAR(30),
    vdireccion        VARCHAR(50),
    dtelefono         DECIMAL(10, 0),
    PRIMARY KEY (ncodempresa)
)ENGINE=MYISAM
;



-- 
-- TABLE: MaENCABEZADOCONCILIACION 
--

CREATE TABLE MaENCABEZADOCONCILIACION(
    ncodconcilicacion    INT         AUTO_INCREMENT,
    dfecha               DATE,
    encargado            CHAR(25),
    cestado              CHAR(20),
    ncodcuenta           INT,
    PRIMARY KEY (ncodconcilicacion)
)ENGINE=MYISAM
;



-- 
-- TABLE: MaERROR 
--

CREATE TABLE MaERROR(
    ncoderror         INT     AUTO_INCREMENT,
    dhora             TIME,
    dfecha            DATE,
    ncodtipo          INT,
    ncodusuario       INT     NOT NULL,
    ncodaccion        INT     NOT NULL,
    ncodaplicacion    INT     NOT NULL,
    PRIMARY KEY (ncoderror)
)ENGINE=MYISAM
;



-- 
-- TABLE: MaFACTURA 
--

CREATE TABLE MaFACTURA(
    ncodfactura          INT               AUTO_INCREMENT,
    vserie               VARCHAR(10),
    vestado              VARCHAR(15),
    dfechavencimiento    DATE,
    ntotal               DECIMAL(10, 0),
    dfecha               DATE,
    ncodcliente          INT               NOT NULL,
    ncodvendedor         INT               NOT NULL,
    PRIMARY KEY (ncodfactura)
)ENGINE=MYISAM
;



-- 
-- TABLE: MaLINEAARTICULO 
--

CREATE TABLE MaLINEAARTICULO(
    ncodlineaarticulo    INT            AUTO_INCREMENT,
    vnombre              VARCHAR(30),
    vdescripcion         VARCHAR(10),
    PRIMARY KEY (ncodlineaarticulo)
)ENGINE=MYISAM
;



-- 
-- TABLE: MaLOCACION 
--

CREATE TABLE MaLOCACION(
    ncodlocacion    INT            AUTO_INCREMENT,
    direccion       VARCHAR(40),
    vcodpostal      VARCHAR(10),
    vciudad         VARCHAR(10),
    vprovincia      VARCHAR(10),
    ncodempleado    INT            NOT NULL,
    PRIMARY KEY (ncodlocacion)
)ENGINE=MYISAM
;



-- 
-- TABLE: MaMATERIAL 
--

CREATE TABLE MaMATERIAL(
    ncodmaterial    INT               AUTO_INCREMENT,
    vnombre         VARCHAR(30),
    ncantidad       DECIMAL(10, 0),
    vestatus        VARCHAR(10),
    ncodarticulo    INT               NOT NULL,
    PRIMARY KEY (ncodmaterial)
)ENGINE=MYISAM
;



-- 
-- TABLE: MaMODULO 
--

CREATE TABLE MaMODULO(
    ncodmodulo        INT            AUTO_INCREMENT,
    vnombremodulo     VARCHAR(10),
    vdescripcion      VARCHAR(50),
    vnombrereporte    VARCHAR(10),
    PRIMARY KEY (ncodmodulo)
)ENGINE=MYISAM
;



-- 
-- TABLE: MaMONEDA 
--

CREATE TABLE MaMONEDA(
    ncodmoneda      INT            AUTO_INCREMENT,
    cdescripcion    VARCHAR(25),
    cestado         CHAR(15),
    ncodbanco       INT            NOT NULL,
    PRIMARY KEY (ncodmoneda)
)ENGINE=MYISAM
;



-- 
-- TABLE: MaMORA 
--

CREATE TABLE MaMORA(
    ncodmora       INT               AUTO_INCREMENT,
    dcantidad      DECIMAL(10, 0),
    cestado        CHAR(10),
    ncodfactura    INT               NOT NULL,
    PRIMARY KEY (ncodmora)
)ENGINE=MYISAM
;



-- 
-- TABLE: MaOBSERVACION 
--

CREATE TABLE MaOBSERVACION(
    ncodobservacion     INT            AUTO_INCREMENT,
    cDescripcion        VARCHAR(18),
    cestado             CHAR(20),
    ncodDetalleConci    INT,
    PRIMARY KEY (ncodobservacion)
)ENGINE=MYISAM
;



-- 
-- TABLE: MaORDEN 
--

CREATE TABLE MaORDEN(
    ncodordenes                     INT               AUTO_INCREMENT,
    vreferenciaproducto             VARCHAR(30),
    vinicioproduccion               VARCHAR(30),
    ventregaproducto                VARCHAR(30),
    vultimomovimiento               VARCHAR(10),
    nnodocumento                    DECIMAL(10, 0),
    ncantidadproductoafabricar      DECIMAL(10, 0),
    ncantidadnoproductoterminado    DECIMAL(10, 0),
    ncantidadproductofaltante       CHAR(10),
    ncodprocesoorden                INT               NOT NULL,
    ncodstatusorden                 INT,
    PRIMARY KEY (ncodordenes)
)ENGINE=MYISAM
;



-- 
-- TABLE: MaORDENCOMPRA 
--

CREATE TABLE MaORDENCOMPRA(
    ncodordencompra       INT               AUTO_INCREMENT,
    ncodproveedor         INT               NOT NULL,
    vdescripcioncompra    VARCHAR(40),
    ncantidad             DECIMAL(10, 0),
    ncostototal           DECIMAL(10, 0),
    ncodarticulo          INT               NOT NULL,
    PRIMARY KEY (ncodordencompra)
)ENGINE=MYISAM
;



-- 
-- TABLE: MaPEDIDO 
--

CREATE TABLE MaPEDIDO(
    ncodpedido           INT            AUTO_INCREMENT,
    vserie               VARCHAR(18),
    dfechapedido         DATE,
    dfechavencimiento    DATE,
    ntotal               INT,
    vestadocotizacion    VARCHAR(10),
    ncodcliente          INT            NOT NULL,
    ncodvendedor         INT            NOT NULL,
    PRIMARY KEY (ncodpedido)
)ENGINE=MYISAM
;



-- 
-- TABLE: MaPLAZA 
--

CREATE TABLE MaPLAZA(
    ncodplaza                 INT               AUTO_INCREMENT,
    vdepartamento             VARCHAR(30),
    vcausasolicitud           VARCHAR(10),
    vtipoempleado             VARCHAR(20),
    vcapacidadesrequeridas    VARCHAR(30),
    vhorario                  VARCHAR(20),
    vtipo                     VARCHAR(30),
    vdescripcion              VARCHAR(20),
    dsueldomin                DECIMAL(10, 0),
    dsueldomax                DECIMAL(10, 0),
    ncodempresa               INT               NOT NULL,
    PRIMARY KEY (ncodplaza)
)ENGINE=MYISAM
;



-- 
-- TABLE: MaPRODUCTO 
--

CREATE TABLE MaPRODUCTO(
    ncodarticulo         INT               AUTO_INCREMENT,
    nexistencia          DECIMAL(10, 0),
    nprecio              DECIMAL(10, 0),
    vmarca               VARCHAR(10),
    vnombre              VARCHAR(30),
    vdescripcion         VARCHAR(30),
    ncodlineaarticulo    INT               NOT NULL,
    ncodtipoarticulo     INT               NOT NULL,
    ncodproveedor        INT               NOT NULL,
    ncodunidad           INT               NOT NULL,
    PRIMARY KEY (ncodarticulo)
)ENGINE=MYISAM
;



-- 
-- TABLE: MaPROVEEDOR 
--

CREATE TABLE MaPROVEEDOR(
    ncodproveedor    INT               AUTO_INCREMENT,
    vnit             VARCHAR(10),
    nsaldo           DECIMAL(10, 0),
    vdescripcion     VARCHAR(10),
    vpais            VARCHAR(20),
    vtelefono        VARCHAR(40),
    vciudad          VARCHAR(40),
    vnombre          VARCHAR(30),
    vdireccion       VARCHAR(30),
    PRIMARY KEY (ncodproveedor)
)ENGINE=MYISAM
;



-- 
-- TABLE: MaPUNTO 
--

CREATE TABLE MaPUNTO(
    ncodigopunto    INT         AUTO_INCREMENT,
    cx              CHAR(10),
    cy              CHAR(10),
    ncodgrafica     INT         NOT NULL,
    PRIMARY KEY (ncodigopunto)
)ENGINE=MYISAM
;



-- 
-- TABLE: MaRECETA 
--

CREATE TABLE MaRECETA(
    ncodreceta       INT            AUTO_INCREMENT,
    nhorahombre      TIME,
    vnombrereceta    VARCHAR(20),
    ncodordenes      INT            NOT NULL,
    PRIMARY KEY (ncodreceta)
)ENGINE=MYISAM
;



-- 
-- TABLE: MaRECIBOPAGO 
--

CREATE TABLE MaRECIBOPAGO(
    ncodrecibopago    INT               AUTO_INCREMENT,
    vnombre           VARCHAR(10),
    vfechapago        VARCHAR(10),
    ncantidadpago     DECIMAL(10, 0),
    ncodproveedor     INT               NOT NULL,
    PRIMARY KEY (ncodrecibopago)
)ENGINE=MYISAM
;



-- 
-- TABLE: MaROLUSUARIO 
--

CREATE TABLE MaROLUSUARIO(
    ncodrole       INT            AUTO_INCREMENT,
    vnombrerole    VARCHAR(10),
    PRIMARY KEY (ncodrole)
)ENGINE=MYISAM
;



-- 
-- TABLE: MaTIPOARTICULO 
--

CREATE TABLE MaTIPOARTICULO(
    ncodtipoarticulo    INT            AUTO_INCREMENT,
    vnombre             VARCHAR(10),
    vdescripcion        VARCHAR(10),
    PRIMARY KEY (ncodtipoarticulo)
)ENGINE=MYISAM
;



-- 
-- TABLE: MaTIPODOCUMENTO 
--

CREATE TABLE MaTIPODOCUMENTO(
    ncodtipodocumento        INT            AUTO_INCREMENT,
    vdescripciondocumento    VARCHAR(30),
    vtipodocumento           VARCHAR(30),
    PRIMARY KEY (ncodtipodocumento)
)ENGINE=MYISAM
;



-- 
-- TABLE: MaTIPOERROR 
--

CREATE TABLE MaTIPOERROR(
    ncodtipo    INT            AUTO_INCREMENT,
    vnombre     VARCHAR(30),
    PRIMARY KEY (ncodtipo)
)ENGINE=MYISAM
;



-- 
-- TABLE: MaTIPOMOVIMIENTO 
--

CREATE TABLE MaTIPOMOVIMIENTO(
    ncodmoviemiento    INT            AUTO_INCREMENT,
    vdescripcion       VARCHAR(40),
    vtipomovimiento    VARCHAR(40),
    PRIMARY KEY (ncodmoviemiento)
)ENGINE=MYISAM
;



-- 
-- TABLE: MaTIPOPAGO 
--

CREATE TABLE MaTIPOPAGO(
    ncodtipopago            INT            AUTO_INCREMENT,
    vdescripciontipopago    VARCHAR(30),
    PRIMARY KEY (ncodtipopago)
)ENGINE=MYISAM
;



-- 
-- TABLE: MaTIPOTRANSACCION 
--

CREATE TABLE MaTIPOTRANSACCION(
    ncodtipotransaccion    INT            AUTO_INCREMENT,
    vbincdec               VARCHAR(20),
    vnombredocumento       VARCHAR(20),
    PRIMARY KEY (ncodtipotransaccion)
)ENGINE=MYISAM
;



-- 
-- TABLE: MaUNIDAD 
--

CREATE TABLE MaUNIDAD(
    ncodunidad       INT            AUTO_INCREMENT,
    vnombreunidad    VARCHAR(20),
    PRIMARY KEY (ncodunidad)
)ENGINE=MYISAM
;



-- 
-- TABLE: MaUSOARTICULO 
--

CREATE TABLE MaUSOARTICULO(
    ncodarticulo    INT            NOT NULL,
    vnombreuso      VARCHAR(10)
)ENGINE=MYISAM
;



-- 
-- TABLE: MaUSUARIO 
--

CREATE TABLE MaUSUARIO(
    ncodusuario         INT             AUTO_INCREMENT,
    vnombreusuario      VARCHAR(30),
    vapellidousuario    VARCHAR(30),
    vemailusuario       VARCHAR(45),
    vusuario            VARCHAR(25)     NOT NULL,
    vpassword           VARCHAR(200)    NOT NULL,
    ncodgrafica         INT             NOT NULL,
    PRIMARY KEY (ncodusuario)
)ENGINE=MYISAM
;



-- 
-- TABLE: MaVENDEDOR 
--

CREATE TABLE MaVENDEDOR(
    ncodvendedor         INT               AUTO_INCREMENT,
    nnit                 VARCHAR(10),
    vnombrevendedor      VARCHAR(50),
    vapellidovendedor    VARCHAR(50),
    vdireccion           VARCHAR(100),
    ntelefono            DECIMAL(10, 0),
    vcorreo              VARCHAR(30),
    vestado              VARCHAR(20),
    PRIMARY KEY (ncodvendedor)
)ENGINE=MYISAM
;



-- 
-- TABLE: MaVENTAS 
--

CREATE TABLE MaVENTAS(
    ncodventas      INT               AUTO_INCREMENT,
    vfechaventa     VARCHAR(40),
    dprecioventa    DECIMAL(10, 0),
    PRIMARY KEY (ncodventas)
)ENGINE=MYISAM
;



-- 
-- TABLE: TrACTIVIDADLUDICA 
--

CREATE TABLE TrACTIVIDADLUDICA(
    ncodactividad    INT            AUTO_INCREMENT,
    vtipo            VARCHAR(10),
    vnombre          VARCHAR(30),
    vdescripcion     VARCHAR(30),
    ncodempleado     INT            NOT NULL,
    PRIMARY KEY (ncodactividad)
)ENGINE=MYISAM
;



-- 
-- TABLE: TrCOBRO 
--

CREATE TABLE TrCOBRO(
    ncodcobro        INT               AUTO_INCREMENT,
    dpago            DECIMAL(10, 0),
    dsaldo           DECIMAL(10, 0),
    dfecha           DATE,
    ncodmora         INT               NOT NULL,
    ncodfactura      INT               NOT NULL,
    ncoddocumento    INT               NOT NULL,
    PRIMARY KEY (ncodcobro)
)ENGINE=MYISAM
;



-- 
-- TABLE: TrCOMPRA 
--

CREATE TABLE TrCOMPRA(
    ncodarticulo         INT               NOT NULL,
    ncodproveedor        INT               NOT NULL,
    ncantidadProducto    DECIMAL(10, 0),
    ntotalapagar         DECIMAL(10, 0),
    ntotalpagado         DECIMAL(10, 0),
    nsaldoapagar         DECIMAL(10, 0),
    ncodorden            INT               NOT NULL
)ENGINE=MYISAM
;



-- 
-- TABLE: TrCONTRATO 
--

CREATE TABLE TrCONTRATO(
    ncodcontrato       INT               AUTO_INCREMENT,
    vhorariotrabajo    VARCHAR(30),
    vdetalle           VARCHAR(20),
    vpuestoreporta     VARCHAR(20),
    vzonaresidencia    VARCHAR(30),
    Vtipocontrato      VARCHAR(30),
    dfechainicio       DATE,
    dfechafin          DATE,
    nsalario           DECIMAL(10, 0),
    ncodempleado       INT               NOT NULL,
    ncodempresa        INT               NOT NULL,
    ncodsolicitud      INT               NOT NULL,
    PRIMARY KEY (ncodcontrato)
)ENGINE=MYISAM
;



-- 
-- TABLE: TrDEPARTAMENTO 
--

CREATE TABLE TrDEPARTAMENTO(
    ncoddepartamento       INT            AUTO_INCREMENT,
    vnombredepartamento    VARCHAR(30),
    vtipo                  VARCHAR(30),
    PRIMARY KEY (ncoddepartamento)
)ENGINE=MYISAM
;



-- 
-- TABLE: TrDESEMPENIO 
--

CREATE TABLE TrDESEMPENIO(
    vcargo              VARCHAR(10)    NOT NULL,
    vcalidadtrabajo     VARCHAR(10),
    vcantidadtrabajo    VARCHAR(10),
    ncodempleado        INT            NOT NULL,
    PRIMARY KEY (vcargo)
)ENGINE=MYISAM
;



-- 
-- TABLE: TrDETALLECONCILIACION 
--

CREATE TABLE TrDETALLECONCILIACION(
    ncodDetalleConci     INT    AUTO_INCREMENT,
    ncodconcilicacion    INT,
    ncoddocumento        INT,
    PRIMARY KEY (ncodDetalleConci)
)ENGINE=MYISAM
;



-- 
-- TABLE: TrDETALLERECETA 
--

CREATE TABLE TrDETALLERECETA(
    ncantidad       INT    AUTO_INCREMENT,
    ncodreceta      INT    NOT NULL,
    ncodmaterial    INT    NOT NULL,
    PRIMARY KEY (ncantidad)
)ENGINE=MYISAM
;



-- 
-- TABLE: TrDOCUMENTOS 
--

CREATE TABLE TrDOCUMENTOS(
    ncoddocumento          INT               AUTO_INCREMENT,
    dfecha                 DATE,
    dmonto                 DECIMAL(10, 0),
    ncodtipotransaccion    INT               NOT NULL,
    ncodcuenta             INT               NOT NULL,
    ncodproveedor          INT               NOT NULL,
    ndocumento             INT               NOT NULL,
    PRIMARY KEY (ncoddocumento)
)ENGINE=MYISAM
;



-- 
-- TABLE: TrESCOLARIDAD 
--

CREATE TABLE TrESCOLARIDAD(
    ncodescolaridad    INT            AUTO_INCREMENT,
    vtipo              VARCHAR(30),
    vdescripcion       VARCHAR(30),
    PRIMARY KEY (ncodescolaridad)
)ENGINE=MYISAM
;



-- 
-- TABLE: TrEXISTENCIA 
--

CREATE TABLE TrEXISTENCIA(
    nexistencia     INT    AUTO_INCREMENT,
    ncodbodega      INT    NOT NULL,
    ncodarticulo    INT    NOT NULL,
    PRIMARY KEY (nexistencia)
)ENGINE=MYISAM
;



-- 
-- TABLE: TrFAMILIA 
--

CREATE TABLE TrFAMILIA(
    ncodfamilia     INT            AUTO_INCREMENT,
    vtipo           VARCHAR(10),
    vdescripcion    VARCHAR(20),
    PRIMARY KEY (ncodfamilia)
)ENGINE=MYISAM
;



-- 
-- TABLE: TrGRAFICA 
--

CREATE TABLE TrGRAFICA(
    ncodgrafica       INT            AUTO_INCREMENT,
    dfecha            DATE,
    ctipo             CHAR(20),
    ctitulografica    CHAR(100)      NOT NULL,
    cejex             CHAR(100)      NOT NULL,
    cejey             CHAR(100)      NOT NULL,
    vnomreporte       VARCHAR(30)    NOT NULL,
    PRIMARY KEY (ncodgrafica)
)ENGINE=MYISAM
;



-- 
-- TABLE: TrHISTORIAEMP 
--

CREATE TABLE TrHISTORIAEMP(
    ncodhistoria     INT            AUTO_INCREMENT,
    vdescripcion     VARCHAR(10),
    dfechainicio     DATE,
    dfechafin        DATE,
    vdepartamento    VARCHAR(10),
    PRIMARY KEY (ncodhistoria)
)ENGINE=MYISAM
;



-- 
-- TABLE: TrMOVIMIENTO 
--

CREATE TABLE TrMOVIMIENTO(
    ncodmovimiento       INT            AUTO_INCREMENT,
    vjustificacion       VARCHAR(30),
    vencargado           VARCHAR(30),
    dfechamovimiento     DATE,
    vhoramovimiento      VARCHAR(10),
    vreferenciafisica    VARCHAR(10),
    ncodmoviemiento      INT            NOT NULL,
    ncodarticulo         INT            NOT NULL,
    PRIMARY KEY (ncodmovimiento)
)ENGINE=MYISAM
;



-- 
-- TABLE: TrORDENPRODUCTO 
--

CREATE TABLE TrORDENPRODUCTO(
    ncodorden       INT               AUTO_INCREMENT,
    ncantidad       DECIMAL(10, 0),
    vdescripcion    DECIMAL(10, 0),
    vstatus         VARCHAR(20),
    ncodarticulo    INT               NOT NULL,
    PRIMARY KEY (ncodorden)
)ENGINE=MYISAM
;



-- 
-- TABLE: TrPAGOPROVEEDOR 
--

CREATE TABLE TrPAGOPROVEEDOR(
    ncodpagoproveedor    INT    AUTO_INCREMENT,
    ncodproveedor        INT    NOT NULL,
    ncoddocumento        INT    NOT NULL,
    PRIMARY KEY (ncodpagoproveedor)
)ENGINE=MYISAM
;



-- 
-- TABLE: TrPAGOS 
--

CREATE TABLE TrPAGOS(
    ncodpago          INT            AUTO_INCREMENT,
    vcantidadpago     VARCHAR(10),
    dfechapago        DATE,
    vdescripcion      VARCHAR(30),
    ncodcuenta        INT            NOT NULL,
    ncodrecibopago    INT            NOT NULL,
    ncodtipopago      INT,
    ncoddocumento     INT            NOT NULL,
    PRIMARY KEY (ncodpago)
)ENGINE=MYISAM
;



-- 
-- TABLE: TrPAGOSALARIO 
--

CREATE TABLE TrPAGOSALARIO(
    ncodpagosalario    INT    AUTO_INCREMENT,
    ncodcontrato       INT    NOT NULL,
    ncoddocumento      INT    NOT NULL,
    PRIMARY KEY (ncodpagosalario)
)ENGINE=MYISAM
;



-- 
-- TABLE: TrPEDIDO 
--

CREATE TABLE TrPEDIDO(
    ncodpedido           INT               AUTO_INCREMENT,
    vserie               VARCHAR(10),
    vnombrepedido        VARCHAR(10),
    vnit                 VARCHAR(10),
    vdireccion           VARCHAR(25),
    dfechapedido         DATE,
    dfechavencimiento    DATE,
    ntotal               DECIMAL(10, 0),
    vestadopedido        VARCHAR(10),
    vnombrevendedor      VARCHAR(20),
    vdescripcion         VARCHAR(18),
    dfechaentrega        DATE,
    ncodventas           INT               NOT NULL,
    ncodarticulo         INT               NOT NULL,
    ncodcliente          INT               NOT NULL,
    ncodvendedor         INT               NOT NULL,
    PRIMARY KEY (ncodpedido)
)ENGINE=MYISAM
;



-- 
-- TABLE: TrPLANILLA 
--

CREATE TABLE TrPLANILLA(
    cprestaciones     CHAR(10),
    vdetalle          VARCHAR(20),
    vhorasnormales    VARCHAR(10),
    vhorasextra       VARCHAR(10),
    nsemanas          DECIMAL(10, 0),
    ncodempleado      INT               NOT NULL,
    ncodempresa       INT               NOT NULL
)ENGINE=MYISAM
;



-- 
-- TABLE: TrPROCESOORDEN 
--

CREATE TABLE TrPROCESOORDEN(
    ncodprocesoorden    INT            AUTO_INCREMENT,
    vnombreproceso      VARCHAR(10),
    PRIMARY KEY (ncodprocesoorden)
)ENGINE=MYISAM
;



-- 
-- TABLE: TrREPORTE 
--

CREATE TABLE TrREPORTE(
    vnomreporte       VARCHAR(30)    NOT NULL,
    dfechareporte     VARCHAR(50),
    ncodaplicacion    CHAR(10),
    ncodmodulo        INT,
    ncodusuario       INT            NOT NULL,
    PRIMARY KEY (vnomreporte)
)ENGINE=MYISAM
;



-- 
-- TABLE: TrROLETOAPLICACION 
--

CREATE TABLE TrROLETOAPLICACION(
    ncodrole          INT       NOT NULL,
    ncodaplicacion    INT       NOT NULL,
    btnimprimir       BIT(1),
    btnnuevo          BIT(1),
    btnirUltimo       BIT(1),
    btnirPrimero      BIT(1),
    btnanterior       BIT(1),
    btnsiguiente      BIT(1),
    btneditar         BIT(1),
    btncancelar       BIT(1),
    btnrefrescar      BIT(1),
    btnbuscar         BIT(1),
    btneliminar       BIT(1),
    btnguardar        BIT(1)
)ENGINE=MYISAM
;



-- 
-- TABLE: TrSOLICITUD 
--

CREATE TABLE TrSOLICITUD(
    ncodsolicitud                   INT             AUTO_INCREMENT,
    vcaracteristicaspsicofisicas    VARCHAR(100),
    vdetalleestudios                VARCHAR(30),
    vpretencionsalarial             VARCHAR(20),
    dfecha                          DATE,
    vnacionalidad                   VARCHAR(30),
    vnopasaporte                    VARCHAR(10),
    vhabitospersonales              VARCHAR(30),
    vpuestosolicitado               VARCHAR(20),
    vsueldosolicitado               VARCHAR(30),
    dfechanacimiento                DATE,
    ncodescolaridad                 INT             NOT NULL,
    ncodfamilia                     INT             NOT NULL,
    PRIMARY KEY (ncodsolicitud)
)ENGINE=MYISAM
;



-- 
-- TABLE: TrSTATUSORDEN 
--

CREATE TABLE TrSTATUSORDEN(
    ncodstatusorden    INT            AUTO_INCREMENT,
    vestatus           VARCHAR(30),
    PRIMARY KEY (ncodstatusorden)
)ENGINE=MYISAM
;



-- 
-- TABLE: TrUNIDAD 
--

CREATE TABLE TrUNIDAD(
    nconversion          DOUBLE(18, 0),
    vnombreconversion    VARCHAR(20),
    ncodunidad           INT              NOT NULL
)ENGINE=MYISAM
;



-- 
-- TABLE: TrUSUARIOTOAPLICACION 
--

CREATE TABLE TrUSUARIOTOAPLICACION(
    ncodusuario       INT       NOT NULL,
    ncodaplicacion    INT       NOT NULL,
    btnimprimir       BIT(1)    NOT NULL,
    btnnuevo          BIT(1),
    btnirUltimo       BIT(1),
    btnirPrimero      BIT(1),
    btnanterior       BIT(1),
    btnsiguiente      BIT(1),
    btneditar         BIT(1),
    btncancelar       BIT(1),
    btnrefrescar      BIT(1),
    btnbuscar         BIT(1),
    btneliminar       BIT(1),
    btnguardar        BIT(1)
)ENGINE=MYISAM
;



-- 
-- TABLE: TrUSUARIOTOROLE 
--

CREATE TABLE TrUSUARIOTOROLE(
    ncodusuario    INT    NOT NULL,
    ncodrole       INT    NOT NULL
)ENGINE=MYISAM
;



-- 
-- TABLE: MaAPLICACION 
--

ALTER TABLE MaAPLICACION ADD CONSTRAINT RefMaMODULO64 
    FOREIGN KEY (ncodmodulo)
    REFERENCES MaMODULO(ncodmodulo)
;


-- 
-- TABLE: MaBITACORA 
--

ALTER TABLE MaBITACORA ADD CONSTRAINT RefMaACCIONES59 
    FOREIGN KEY (ncodaccion)
    REFERENCES MaACCIONES(ncodaccion)
;

ALTER TABLE MaBITACORA ADD CONSTRAINT RefMaUSUARIO62 
    FOREIGN KEY (ncodusuario)
    REFERENCES MaUSUARIO(ncodusuario)
;

ALTER TABLE MaBITACORA ADD CONSTRAINT RefMaAPLICACION66 
    FOREIGN KEY (ncodaplicacion)
    REFERENCES MaAPLICACION(ncodaplicacion)
;


-- 
-- TABLE: MaCAPACITACION 
--

ALTER TABLE MaCAPACITACION ADD CONSTRAINT RefMaEMPLEADO87 
    FOREIGN KEY (ncodempleado)
    REFERENCES MaEMPLEADO(ncodempleado)
;


-- 
-- TABLE: MaCOGNITIVO 
--

ALTER TABLE MaCOGNITIVO ADD CONSTRAINT RefMaEMPLEADO45 
    FOREIGN KEY (ncodempleado)
    REFERENCES MaEMPLEADO(ncodempleado)
;


-- 
-- TABLE: MaCOTIZACION 
--

ALTER TABLE MaCOTIZACION ADD CONSTRAINT RefMaCLIENTE100 
    FOREIGN KEY (ncodcliente)
    REFERENCES MaCLIENTE(ncodcliente)
;

ALTER TABLE MaCOTIZACION ADD CONSTRAINT RefMaVENDEDOR8 
    FOREIGN KEY (ncodvendedor)
    REFERENCES MaVENDEDOR(ncodvendedor)
;

ALTER TABLE MaCOTIZACION ADD CONSTRAINT RefMaVENDEDOR14 
    FOREIGN KEY (ncodvendedor)
    REFERENCES MaVENDEDOR(ncodvendedor)
;

ALTER TABLE MaCOTIZACION ADD CONSTRAINT RefMaCLIENTE15 
    FOREIGN KEY (ncodcliente)
    REFERENCES MaCLIENTE(ncodcliente)
;


-- 
-- TABLE: MaCUENTA 
--

ALTER TABLE MaCUENTA ADD CONSTRAINT RefMaEMPLEADO112 
    FOREIGN KEY (ncodempleado)
    REFERENCES MaEMPLEADO(ncodempleado)
;

ALTER TABLE MaCUENTA ADD CONSTRAINT RefTrDOCUMENTOS29 
    FOREIGN KEY (ncoddocumento)
    REFERENCES TrDOCUMENTOS(ncoddocumento)
;

ALTER TABLE MaCUENTA ADD CONSTRAINT RefMaBANCO51 
    FOREIGN KEY (ncodbanco)
    REFERENCES MaBANCO(ncodbanco)
;


-- 
-- TABLE: MaDETALLECOTIZACION 
--

ALTER TABLE MaDETALLECOTIZACION ADD CONSTRAINT RefMaCOTIZACION101 
    FOREIGN KEY (ncodcotizacion)
    REFERENCES MaCOTIZACION(ncodcotizacion)
;

ALTER TABLE MaDETALLECOTIZACION ADD CONSTRAINT RefMaPRODUCTO102 
    FOREIGN KEY (ncodarticulo)
    REFERENCES MaPRODUCTO(ncodarticulo)
;

ALTER TABLE MaDETALLECOTIZACION ADD CONSTRAINT RefMaPRODUCTO24 
    FOREIGN KEY (ncodarticulo)
    REFERENCES MaPRODUCTO(ncodarticulo)
;


-- 
-- TABLE: MaDETALLEFACTURA 
--

ALTER TABLE MaDETALLEFACTURA ADD CONSTRAINT RefMaFACTURA88 
    FOREIGN KEY (ncodfactura)
    REFERENCES MaFACTURA(ncodfactura)
;

ALTER TABLE MaDETALLEFACTURA ADD CONSTRAINT RefMaPRODUCTO22 
    FOREIGN KEY (ncodarticulo)
    REFERENCES MaPRODUCTO(ncodarticulo)
;

ALTER TABLE MaDETALLEFACTURA ADD CONSTRAINT RefMaPRODUCTO61 
    FOREIGN KEY (ncodarticulo)
    REFERENCES MaPRODUCTO(ncodarticulo)
;


-- 
-- TABLE: MaDETALLEPEDIDO 
--

ALTER TABLE MaDETALLEPEDIDO ADD CONSTRAINT RefTrPEDIDO103 
    FOREIGN KEY (ncodpedido)
    REFERENCES TrPEDIDO(ncodpedido)
;

ALTER TABLE MaDETALLEPEDIDO ADD CONSTRAINT RefMaPRODUCTO104 
    FOREIGN KEY (ncodarticulo)
    REFERENCES MaPRODUCTO(ncodarticulo)
;

ALTER TABLE MaDETALLEPEDIDO ADD CONSTRAINT RefMaPEDIDO19 
    FOREIGN KEY (ncodpedido)
    REFERENCES MaPEDIDO(ncodpedido)
;

ALTER TABLE MaDETALLEPEDIDO ADD CONSTRAINT RefMaPRODUCTO20 
    FOREIGN KEY (ncodarticulo)
    REFERENCES MaPRODUCTO(ncodarticulo)
;


-- 
-- TABLE: MaDOCPORPAGAR 
--

ALTER TABLE MaDOCPORPAGAR ADD CONSTRAINT RefMaPROVEEDOR35 
    FOREIGN KEY (ncodproveedor)
    REFERENCES MaPROVEEDOR(ncodproveedor)
;

ALTER TABLE MaDOCPORPAGAR ADD CONSTRAINT RefMaTIPODOCUMENTO42 
    FOREIGN KEY (ncodtipodocumento)
    REFERENCES MaTIPODOCUMENTO(ncodtipodocumento)
;


-- 
-- TABLE: MaEMPLEADO 
--

ALTER TABLE MaEMPLEADO ADD CONSTRAINT RefTrDEPARTAMENTO89 
    FOREIGN KEY (ncoddepartamento)
    REFERENCES TrDEPARTAMENTO(ncoddepartamento)
;

ALTER TABLE MaEMPLEADO ADD CONSTRAINT RefTrHISTORIAEMP55 
    FOREIGN KEY (ncodhistoria)
    REFERENCES TrHISTORIAEMP(ncodhistoria)
;

ALTER TABLE MaEMPLEADO ADD CONSTRAINT RefMaUSUARIO74 
    FOREIGN KEY (ncodusuario)
    REFERENCES MaUSUARIO(ncodusuario)
;


-- 
-- TABLE: MaENCABEZADOCONCILIACION 
--

ALTER TABLE MaENCABEZADOCONCILIACION ADD CONSTRAINT RefMaCUENTA108 
    FOREIGN KEY (ncodcuenta)
    REFERENCES MaCUENTA(ncodcuenta)
;


-- 
-- TABLE: MaERROR 
--

ALTER TABLE MaERROR ADD CONSTRAINT RefMaTIPOERROR54 
    FOREIGN KEY (ncodtipo)
    REFERENCES MaTIPOERROR(ncodtipo)
;

ALTER TABLE MaERROR ADD CONSTRAINT RefMaUSUARIO56 
    FOREIGN KEY (ncodusuario)
    REFERENCES MaUSUARIO(ncodusuario)
;

ALTER TABLE MaERROR ADD CONSTRAINT RefMaACCIONES58 
    FOREIGN KEY (ncodaccion)
    REFERENCES MaACCIONES(ncodaccion)
;

ALTER TABLE MaERROR ADD CONSTRAINT RefMaAPLICACION68 
    FOREIGN KEY (ncodaplicacion)
    REFERENCES MaAPLICACION(ncodaplicacion)
;


-- 
-- TABLE: MaFACTURA 
--

ALTER TABLE MaFACTURA ADD CONSTRAINT RefMaVENDEDOR7 
    FOREIGN KEY (ncodvendedor)
    REFERENCES MaVENDEDOR(ncodvendedor)
;

ALTER TABLE MaFACTURA ADD CONSTRAINT RefMaCLIENTE13 
    FOREIGN KEY (ncodcliente)
    REFERENCES MaCLIENTE(ncodcliente)
;

ALTER TABLE MaFACTURA ADD CONSTRAINT RefMaCLIENTE18 
    FOREIGN KEY (ncodcliente)
    REFERENCES MaCLIENTE(ncodcliente)
;

ALTER TABLE MaFACTURA ADD CONSTRAINT RefMaCLIENTE43 
    FOREIGN KEY (ncodcliente)
    REFERENCES MaCLIENTE(ncodcliente)
;


-- 
-- TABLE: MaLOCACION 
--

ALTER TABLE MaLOCACION ADD CONSTRAINT RefMaEMPLEADO92 
    FOREIGN KEY (ncodempleado)
    REFERENCES MaEMPLEADO(ncodempleado)
;


-- 
-- TABLE: MaMATERIAL 
--

ALTER TABLE MaMATERIAL ADD CONSTRAINT RefMaPRODUCTO30 
    FOREIGN KEY (ncodarticulo)
    REFERENCES MaPRODUCTO(ncodarticulo)
;


-- 
-- TABLE: MaMONEDA 
--

ALTER TABLE MaMONEDA ADD CONSTRAINT RefMaBANCO98 
    FOREIGN KEY (ncodbanco)
    REFERENCES MaBANCO(ncodbanco)
;


-- 
-- TABLE: MaMORA 
--

ALTER TABLE MaMORA ADD CONSTRAINT RefMaFACTURA21 
    FOREIGN KEY (ncodfactura)
    REFERENCES MaFACTURA(ncodfactura)
;


-- 
-- TABLE: MaOBSERVACION 
--

ALTER TABLE MaOBSERVACION ADD CONSTRAINT RefTrDETALLECONCILIACION110 
    FOREIGN KEY (ncodDetalleConci)
    REFERENCES TrDETALLECONCILIACION(ncodDetalleConci)
;


-- 
-- TABLE: MaORDEN 
--

ALTER TABLE MaORDEN ADD CONSTRAINT RefTrSTATUSORDEN109 
    FOREIGN KEY (ncodstatusorden)
    REFERENCES TrSTATUSORDEN(ncodstatusorden)
;

ALTER TABLE MaORDEN ADD CONSTRAINT RefTrPROCESOORDEN77 
    FOREIGN KEY (ncodprocesoorden)
    REFERENCES TrPROCESOORDEN(ncodprocesoorden)
;


-- 
-- TABLE: MaORDENCOMPRA 
--

ALTER TABLE MaORDENCOMPRA ADD CONSTRAINT RefMaPRODUCTO96 
    FOREIGN KEY (ncodarticulo)
    REFERENCES MaPRODUCTO(ncodarticulo)
;

ALTER TABLE MaORDENCOMPRA ADD CONSTRAINT RefMaPROVEEDOR32 
    FOREIGN KEY (ncodproveedor)
    REFERENCES MaPROVEEDOR(ncodproveedor)
;


-- 
-- TABLE: MaPEDIDO 
--

ALTER TABLE MaPEDIDO ADD CONSTRAINT RefMaCLIENTE16 
    FOREIGN KEY (ncodcliente)
    REFERENCES MaCLIENTE(ncodcliente)
;

ALTER TABLE MaPEDIDO ADD CONSTRAINT RefMaVENDEDOR17 
    FOREIGN KEY (ncodvendedor)
    REFERENCES MaVENDEDOR(ncodvendedor)
;


-- 
-- TABLE: MaPLAZA 
--

ALTER TABLE MaPLAZA ADD CONSTRAINT RefMaEMPRESA86 
    FOREIGN KEY (ncodempresa)
    REFERENCES MaEMPRESA(ncodempresa)
;


-- 
-- TABLE: MaPRODUCTO 
--

ALTER TABLE MaPRODUCTO ADD CONSTRAINT RefMaUNIDAD79 
    FOREIGN KEY (ncodunidad)
    REFERENCES MaUNIDAD(ncodunidad)
;

ALTER TABLE MaPRODUCTO ADD CONSTRAINT RefMaPRODUCTO26 
    FOREIGN KEY (ncodarticulo)
    REFERENCES MaPRODUCTO(ncodarticulo)
;

ALTER TABLE MaPRODUCTO ADD CONSTRAINT RefMaLINEAARTICULO63 
    FOREIGN KEY (ncodlineaarticulo)
    REFERENCES MaLINEAARTICULO(ncodlineaarticulo)
;

ALTER TABLE MaPRODUCTO ADD CONSTRAINT RefMaTIPOARTICULO65 
    FOREIGN KEY (ncodtipoarticulo)
    REFERENCES MaTIPOARTICULO(ncodtipoarticulo)
;

ALTER TABLE MaPRODUCTO ADD CONSTRAINT RefMaPROVEEDOR73 
    FOREIGN KEY (ncodproveedor)
    REFERENCES MaPROVEEDOR(ncodproveedor)
;


-- 
-- TABLE: MaPUNTO 
--

ALTER TABLE MaPUNTO ADD CONSTRAINT RefTrGRAFICA1 
    FOREIGN KEY (ncodgrafica)
    REFERENCES TrGRAFICA(ncodgrafica)
;


-- 
-- TABLE: MaRECETA 
--

ALTER TABLE MaRECETA ADD CONSTRAINT RefMaORDEN4 
    FOREIGN KEY (ncodordenes)
    REFERENCES MaORDEN(ncodordenes)
;


-- 
-- TABLE: MaRECIBOPAGO 
--

ALTER TABLE MaRECIBOPAGO ADD CONSTRAINT RefMaPROVEEDOR75 
    FOREIGN KEY (ncodproveedor)
    REFERENCES MaPROVEEDOR(ncodproveedor)
;


-- 
-- TABLE: MaUSOARTICULO 
--

ALTER TABLE MaUSOARTICULO ADD CONSTRAINT RefMaPRODUCTO36 
    FOREIGN KEY (ncodarticulo)
    REFERENCES MaPRODUCTO(ncodarticulo)
;


-- 
-- TABLE: MaUSUARIO 
--

ALTER TABLE MaUSUARIO ADD CONSTRAINT RefTrGRAFICA70 
    FOREIGN KEY (ncodgrafica)
    REFERENCES TrGRAFICA(ncodgrafica)
;


-- 
-- TABLE: TrACTIVIDADLUDICA 
--

ALTER TABLE TrACTIVIDADLUDICA ADD CONSTRAINT RefMaEMPLEADO53 
    FOREIGN KEY (ncodempleado)
    REFERENCES MaEMPLEADO(ncodempleado)
;


-- 
-- TABLE: TrCOBRO 
--

ALTER TABLE TrCOBRO ADD CONSTRAINT RefMaMORA39 
    FOREIGN KEY (ncodmora)
    REFERENCES MaMORA(ncodmora)
;

ALTER TABLE TrCOBRO ADD CONSTRAINT RefMaFACTURA41 
    FOREIGN KEY (ncodfactura)
    REFERENCES MaFACTURA(ncodfactura)
;

ALTER TABLE TrCOBRO ADD CONSTRAINT RefTrDOCUMENTOS71 
    FOREIGN KEY (ncoddocumento)
    REFERENCES TrDOCUMENTOS(ncoddocumento)
;


-- 
-- TABLE: TrCOMPRA 
--

ALTER TABLE TrCOMPRA ADD CONSTRAINT RefTrORDENPRODUCTO81 
    FOREIGN KEY (ncodorden)
    REFERENCES TrORDENPRODUCTO(ncodorden)
;

ALTER TABLE TrCOMPRA ADD CONSTRAINT RefMaPRODUCTO11 
    FOREIGN KEY (ncodarticulo)
    REFERENCES MaPRODUCTO(ncodarticulo)
;

ALTER TABLE TrCOMPRA ADD CONSTRAINT RefMaPROVEEDOR12 
    FOREIGN KEY (ncodproveedor)
    REFERENCES MaPROVEEDOR(ncodproveedor)
;


-- 
-- TABLE: TrCONTRATO 
--

ALTER TABLE TrCONTRATO ADD CONSTRAINT RefMaEMPLEADO84 
    FOREIGN KEY (ncodempleado)
    REFERENCES MaEMPLEADO(ncodempleado)
;

ALTER TABLE TrCONTRATO ADD CONSTRAINT RefMaEMPRESA85 
    FOREIGN KEY (ncodempresa)
    REFERENCES MaEMPRESA(ncodempresa)
;

ALTER TABLE TrCONTRATO ADD CONSTRAINT RefTrSOLICITUD90 
    FOREIGN KEY (ncodsolicitud)
    REFERENCES TrSOLICITUD(ncodsolicitud)
;


-- 
-- TABLE: TrDESEMPENIO 
--

ALTER TABLE TrDESEMPENIO ADD CONSTRAINT RefMaEMPLEADO105 
    FOREIGN KEY (ncodempleado)
    REFERENCES MaEMPLEADO(ncodempleado)
;


-- 
-- TABLE: TrDETALLECONCILIACION 
--

ALTER TABLE TrDETALLECONCILIACION ADD CONSTRAINT RefMaENCABEZADOCONCILIACION106 
    FOREIGN KEY (ncodconcilicacion)
    REFERENCES MaENCABEZADOCONCILIACION(ncodconcilicacion)
;

ALTER TABLE TrDETALLECONCILIACION ADD CONSTRAINT RefTrDOCUMENTOS107 
    FOREIGN KEY (ncoddocumento)
    REFERENCES TrDOCUMENTOS(ncoddocumento)
;


-- 
-- TABLE: TrDETALLERECETA 
--

ALTER TABLE TrDETALLERECETA ADD CONSTRAINT RefMaRECETA3 
    FOREIGN KEY (ncodreceta)
    REFERENCES MaRECETA(ncodreceta)
;

ALTER TABLE TrDETALLERECETA ADD CONSTRAINT RefMaMATERIAL5 
    FOREIGN KEY (ncodmaterial)
    REFERENCES MaMATERIAL(ncodmaterial)
;


-- 
-- TABLE: TrDOCUMENTOS 
--

ALTER TABLE TrDOCUMENTOS ADD CONSTRAINT RefMaTIPOTRANSACCION23 
    FOREIGN KEY (ncodtipotransaccion)
    REFERENCES MaTIPOTRANSACCION(ncodtipotransaccion)
;

ALTER TABLE TrDOCUMENTOS ADD CONSTRAINT RefMaPROVEEDOR33 
    FOREIGN KEY (ncodproveedor)
    REFERENCES MaPROVEEDOR(ncodproveedor)
;

ALTER TABLE TrDOCUMENTOS ADD CONSTRAINT RefMaDOCPORPAGAR37 
    FOREIGN KEY (ndocumento)
    REFERENCES MaDOCPORPAGAR(ndocumento)
;

ALTER TABLE TrDOCUMENTOS ADD CONSTRAINT RefMaTIPOTRANSACCION38 
    FOREIGN KEY (ncodtipotransaccion)
    REFERENCES MaTIPOTRANSACCION(ncodtipotransaccion)
;

ALTER TABLE TrDOCUMENTOS ADD CONSTRAINT RefMaCUENTA40 
    FOREIGN KEY (ncodcuenta)
    REFERENCES MaCUENTA(ncodcuenta)
;


-- 
-- TABLE: TrEXISTENCIA 
--

ALTER TABLE TrEXISTENCIA ADD CONSTRAINT RefMaBODEGA47 
    FOREIGN KEY (ncodbodega)
    REFERENCES MaBODEGA(ncodbodega)
;

ALTER TABLE TrEXISTENCIA ADD CONSTRAINT RefMaPRODUCTO67 
    FOREIGN KEY (ncodarticulo)
    REFERENCES MaPRODUCTO(ncodarticulo)
;


-- 
-- TABLE: TrGRAFICA 
--

ALTER TABLE TrGRAFICA ADD CONSTRAINT RefTrREPORTE2 
    FOREIGN KEY (vnomreporte)
    REFERENCES TrREPORTE(vnomreporte)
;


-- 
-- TABLE: TrMOVIMIENTO 
--

ALTER TABLE TrMOVIMIENTO ADD CONSTRAINT RefMaPRODUCTO78 
    FOREIGN KEY (ncodarticulo)
    REFERENCES MaPRODUCTO(ncodarticulo)
;

ALTER TABLE TrMOVIMIENTO ADD CONSTRAINT RefMaTIPOMOVIMIENTO49 
    FOREIGN KEY (ncodmoviemiento)
    REFERENCES MaTIPOMOVIMIENTO(ncodmoviemiento)
;


-- 
-- TABLE: TrORDENPRODUCTO 
--

ALTER TABLE TrORDENPRODUCTO ADD CONSTRAINT RefMaPRODUCTO28 
    FOREIGN KEY (ncodarticulo)
    REFERENCES MaPRODUCTO(ncodarticulo)
;


-- 
-- TABLE: TrPAGOPROVEEDOR 
--

ALTER TABLE TrPAGOPROVEEDOR ADD CONSTRAINT RefMaPROVEEDOR94 
    FOREIGN KEY (ncodproveedor)
    REFERENCES MaPROVEEDOR(ncodproveedor)
;

ALTER TABLE TrPAGOPROVEEDOR ADD CONSTRAINT RefTrDOCUMENTOS97 
    FOREIGN KEY (ncoddocumento)
    REFERENCES TrDOCUMENTOS(ncoddocumento)
;


-- 
-- TABLE: TrPAGOS 
--

ALTER TABLE TrPAGOS ADD CONSTRAINT RefMaCUENTA80 
    FOREIGN KEY (ncodcuenta)
    REFERENCES MaCUENTA(ncodcuenta)
;

ALTER TABLE TrPAGOS ADD CONSTRAINT RefMaRECIBOPAGO93 
    FOREIGN KEY (ncodrecibopago)
    REFERENCES MaRECIBOPAGO(ncodrecibopago)
;

ALTER TABLE TrPAGOS ADD CONSTRAINT RefMaTIPOPAGO9 
    FOREIGN KEY (ncodtipopago)
    REFERENCES MaTIPOPAGO(ncodtipopago)
;

ALTER TABLE TrPAGOS ADD CONSTRAINT RefTrDOCUMENTOS10 
    FOREIGN KEY (ncoddocumento)
    REFERENCES TrDOCUMENTOS(ncoddocumento)
;

ALTER TABLE TrPAGOS ADD CONSTRAINT RefTrDOCUMENTOS31 
    FOREIGN KEY (ncoddocumento)
    REFERENCES TrDOCUMENTOS(ncoddocumento)
;


-- 
-- TABLE: TrPAGOSALARIO 
--

ALTER TABLE TrPAGOSALARIO ADD CONSTRAINT RefTrDOCUMENTOS91 
    FOREIGN KEY (ncoddocumento)
    REFERENCES TrDOCUMENTOS(ncoddocumento)
;

ALTER TABLE TrPAGOSALARIO ADD CONSTRAINT RefTrCONTRATO60 
    FOREIGN KEY (ncodcontrato)
    REFERENCES TrCONTRATO(ncodcontrato)
;


-- 
-- TABLE: TrPEDIDO 
--

ALTER TABLE TrPEDIDO ADD CONSTRAINT RefMaPRODUCTO82 
    FOREIGN KEY (ncodarticulo)
    REFERENCES MaPRODUCTO(ncodarticulo)
;

ALTER TABLE TrPEDIDO ADD CONSTRAINT RefMaCLIENTE99 
    FOREIGN KEY (ncodcliente)
    REFERENCES MaCLIENTE(ncodcliente)
;

ALTER TABLE TrPEDIDO ADD CONSTRAINT RefMaVENDEDOR6 
    FOREIGN KEY (ncodvendedor)
    REFERENCES MaVENDEDOR(ncodvendedor)
;

ALTER TABLE TrPEDIDO ADD CONSTRAINT RefMaVENTAS34 
    FOREIGN KEY (ncodventas)
    REFERENCES MaVENTAS(ncodventas)
;


-- 
-- TABLE: TrPLANILLA 
--

ALTER TABLE TrPLANILLA ADD CONSTRAINT RefMaEMPLEADO25 
    FOREIGN KEY (ncodempleado)
    REFERENCES MaEMPLEADO(ncodempleado)
;

ALTER TABLE TrPLANILLA ADD CONSTRAINT RefMaEMPRESA27 
    FOREIGN KEY (ncodempresa)
    REFERENCES MaEMPRESA(ncodempresa)
;


-- 
-- TABLE: TrREPORTE 
--

ALTER TABLE TrREPORTE ADD CONSTRAINT RefMaMODULO111 
    FOREIGN KEY (ncodmodulo)
    REFERENCES MaMODULO(ncodmodulo)
;

ALTER TABLE TrREPORTE ADD CONSTRAINT RefMaUSUARIO72 
    FOREIGN KEY (ncodusuario)
    REFERENCES MaUSUARIO(ncodusuario)
;


-- 
-- TABLE: TrROLETOAPLICACION 
--

ALTER TABLE TrROLETOAPLICACION ADD CONSTRAINT RefMaROLUSUARIO50 
    FOREIGN KEY (ncodrole)
    REFERENCES MaROLUSUARIO(ncodrole)
;

ALTER TABLE TrROLETOAPLICACION ADD CONSTRAINT RefMaAPLICACION52 
    FOREIGN KEY (ncodaplicacion)
    REFERENCES MaAPLICACION(ncodaplicacion)
;


-- 
-- TABLE: TrSOLICITUD 
--

ALTER TABLE TrSOLICITUD ADD CONSTRAINT RefTrFAMILIA95 
    FOREIGN KEY (ncodfamilia)
    REFERENCES TrFAMILIA(ncodfamilia)
;

ALTER TABLE TrSOLICITUD ADD CONSTRAINT RefTrESCOLARIDAD57 
    FOREIGN KEY (ncodescolaridad)
    REFERENCES TrESCOLARIDAD(ncodescolaridad)
;


-- 
-- TABLE: TrUNIDAD 
--

ALTER TABLE TrUNIDAD ADD CONSTRAINT RefMaUNIDAD76 
    FOREIGN KEY (ncodunidad)
    REFERENCES MaUNIDAD(ncodunidad)
;


-- 
-- TABLE: TrUSUARIOTOAPLICACION 
--

ALTER TABLE TrUSUARIOTOAPLICACION ADD CONSTRAINT RefMaAPLICACION44 
    FOREIGN KEY (ncodaplicacion)
    REFERENCES MaAPLICACION(ncodaplicacion)
;

ALTER TABLE TrUSUARIOTOAPLICACION ADD CONSTRAINT RefMaUSUARIO69 
    FOREIGN KEY (ncodusuario)
    REFERENCES MaUSUARIO(ncodusuario)
;


-- 
-- TABLE: TrUSUARIOTOROLE 
--

ALTER TABLE TrUSUARIOTOROLE ADD CONSTRAINT RefMaUSUARIO46 
    FOREIGN KEY (ncodusuario)
    REFERENCES MaUSUARIO(ncodusuario)
;

ALTER TABLE TrUSUARIOTOROLE ADD CONSTRAINT RefMaROLUSUARIO48 
    FOREIGN KEY (ncodrole)
    REFERENCES MaROLUSUARIO(ncodrole)
;


