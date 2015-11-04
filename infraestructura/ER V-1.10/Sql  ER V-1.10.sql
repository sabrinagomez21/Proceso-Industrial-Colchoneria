--
-- ER/Studio Data Architect 11.0 SQL Code Generation
-- Project :      ER (7 DE 8 modulos incluidos).dm1
--
-- Date Created : Monday, November 02, 2015 16:20:00
-- Target DBMS : MySQL 3.x
--

-- 
-- TABLE: MaACCIONES 
--

CREATE TABLE MaACCIONES(
    ncodaccion       INT            NOT NULL,
    vnombreaccion    VARCHAR(40),
    PRIMARY KEY (ncodaccion)
)TYPE=INNODB
;



-- 
-- TABLE: MaAPLICACION 
--

CREATE TABLE MaAPLICACION(
    ncodaplicacion       INT            NOT NULL,
    vnombreaplicacion    VARCHAR(30),
    ncodmodulo           INT            NOT NULL,
    vnombreformulario    VARCHAR(40),
    PRIMARY KEY (ncodaplicacion)
)TYPE=INNODB
;



-- 
-- TABLE: MaARTICULO 
--

CREATE TABLE MaARTICULO(
    ncodarticulo         INT               AUTO_INCREMENT,
    nexistencia          DECIMAL(10, 0),
    nprecio              DECIMAL(10, 0),
    vmarca               VARCHAR(10),
    vnombre              VARCHAR(30),
    vdescripcion         VARCHAR(30),
    ncodlineaarticulo    INT               NOT NULL,
    ncodtipoarticulo     INT               NOT NULL,
    ncodproveedor        INT               NOT NULL,
    PRIMARY KEY (ncodarticulo)
)TYPE=INNODB
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
)TYPE=INNODB
;



-- 
-- TABLE: MaBITACORA 
--

CREATE TABLE MaBITACORA(
    ncodbitacorra     INT             NOT NULL,
    vnombreequipo     VARCHAR(25),
    vipequipo         VARCHAR(20),
    dhora             TIME,
    dfecha            DATE,
    vdetalleaccion    VARCHAR(100),
    ncodaccion        INT             NOT NULL,
    ncodusuario       INT             NOT NULL,
    ncodaplicacion    INT             NOT NULL,
    PRIMARY KEY (ncodbitacorra)
)TYPE=INNODB
;



-- 
-- TABLE: MaBODEGA 
--

CREATE TABLE MaBODEGA(
    ncodbodega          INT            AUTO_INCREMENT,
    vnombrebodega       VARCHAR(30),
    vdireccionbodega    VARCHAR(40),
    PRIMARY KEY (ncodbodega)
)TYPE=MYISAM
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
)TYPE=MYISAM
;



-- 
-- TABLE: MaCLIENTE 
--

CREATE TABLE MaCLIENTE(
    ncodcliente         DECIMAL(10, 0)    NOT NULL,
    vnombrecliente      VARCHAR(30),
    vapellidocliente    VARCHAR(40),
    vdireccion          VARCHAR(30),
    ntelefono           INT,
    vcorreo             VARCHAR(30),
    vestado             VARCHAR(20),
    PRIMARY KEY (ncodcliente)
)TYPE=INNODB
;



-- 
-- TABLE: MaCOGNITIVO 
--

CREATE TABLE MaCOGNITIVO(
    vtipo           VARCHAR(10),
    vdescripcion    VARCHAR(30),
    vestado         VARCHAR(10),
    ncodempleado    INT            NOT NULL
)TYPE=MYISAM
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
)TYPE=INNODB
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
    ncodcliente          DECIMAL(10, 0)    NOT NULL,
    vnombrevendedor      VARCHAR(25),
    ncodvendedor         INT               NOT NULL,
    PRIMARY KEY (ncodcotizacion)
)TYPE=INNODB
;



-- 
-- TABLE: MaCUENTA 
--

CREATE TABLE MaCUENTA(
    ncodcuenta       INT               AUTO_INCREMENT,
    dmontocuenta     DECIMAL(10, 0),
    dfecha           DATE,
    cestado          CHAR(20),
    ncodbanco        INT               NOT NULL,
    ncoddocumento    DECIMAL(10, 0)    NOT NULL,
    PRIMARY KEY (ncodcuenta)
)TYPE=INNODB
;



-- 
-- TABLE: MaDEPARTAMENTO 
--

CREATE TABLE MaDEPARTAMENTO(
    ncoddepartamento    INT            NOT NULL,
    vresponsable        VARCHAR(30),
    vextension          VARCHAR(30),
    PRIMARY KEY (ncoddepartamento)
)TYPE=MYISAM
;



-- 
-- TABLE: MaDETALLECOTIZACION 
--

CREATE TABLE MaDETALLECOTIZACION(
    ncodcotizacion       INT               NOT NULL,
    ncantidadcotizada    DECIMAL(10, 0),
    npreciocotizado      DECIMAL(10, 0),
    ncodarticulo         INT               NOT NULL
)TYPE=INNODB
;



-- 
-- TABLE: MaDETALLEFACTURA 
--

CREATE TABLE MaDETALLEFACTURA(
    ncodarticulo      INT    NOT NULL,
    ncantidadventa    INT    NOT NULL,
    nprecioventa      INT,
    ncodfactura       INT    NOT NULL
)TYPE=INNODB
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
)TYPE=INNODB
;



-- 
-- TABLE: MaDOCUMENTO 
--

CREATE TABLE MaDOCUMENTO(
    ncoddocumento        DECIMAL(10, 0)    NOT NULL,
    dfechadocumento      DATE,
    vreferenciafisica    VARCHAR(10),
    ntotalpago           DECIMAL(10, 0),
    ncantidadactual      DECIMAL(10, 0),
    vdescripcion         VARCHAR(10),
    ncodproveedor        INT               NOT NULL,
    PRIMARY KEY (ncoddocumento)
)TYPE=INNODB
;



-- 
-- TABLE: MaEMPLEADO 
--

CREATE TABLE MaEMPLEADO(
    ncodempleado         INT               NOT NULL,
    vnombreempleado      VARCHAR(40),
    vapellidoempleado    VARCHAR(40),
    vestadocivil         VARCHAR(30),
    dsalario             DECIMAL(10, 0),
    dcomision            DECIMAL(10, 0),
    vtipo                VARCHAR(30),
    vescolaridad         VARCHAR(30),
    dtelefono            DECIMAL(10, 0),
    vcargo               VARCHAR(30),
    vdpi                 VARCHAR(10),
    nedad                INTEGER,
    vgenero              VARCHAR(30),
    dnumcuenta           DECIMAL(10, 0),
    ncodhistoria         INT               NOT NULL,
    ncoddepartamento     INT               NOT NULL,
    PRIMARY KEY (ncodempleado)
)TYPE=INNODB
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
)TYPE=MYISAM
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
)TYPE=INNODB
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
)TYPE=INNODB
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
    ncodcliente          DECIMAL(10, 0)    NOT NULL,
    ncodvendedor         INT               NOT NULL,
    PRIMARY KEY (ncodfactura)
)TYPE=INNODB
;



-- 
-- TABLE: MaLINEAARTICULO 
--

CREATE TABLE MaLINEAARTICULO(
    ncodlineaarticulo    INT            AUTO_INCREMENT,
    vnombre              VARCHAR(30),
    vdescripcion         VARCHAR(10),
    PRIMARY KEY (ncodlineaarticulo)
)TYPE=MYISAM
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
)TYPE=MYISAM
;



-- 
-- TABLE: MaMATERIAL 
--

CREATE TABLE MaMATERIAL(
    ncodmaterial    INT               AUTO_INCREMENT,
    vnombre         VARCHAR(30),
    ncantidad       INTEGER,
    vestatus        VARCHAR(10),
    ncodarticulo    INT               NOT NULL,
    PRIMARY KEY (ncodmaterial)
)TYPE=INNODB
;



-- 
-- TABLE: MaMODULO 
--

CREATE TABLE MaMODULO(
    ncodmodulo        INT            AUTO_INCREMENT,
    vnombremodulo     VARCHAR(10),
    vdescripcion      VARCHAR(30),
    vnombrereporte    VARCHAR(10),
    PRIMARY KEY (ncodmodulo)
)TYPE=INNODB
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
)TYPE=MYISAM
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
)TYPE=INNODB
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
)TYPE=INNODB
;



-- 
-- TABLE: MaORDEN 
--

CREATE TABLE MaORDEN(
    ncodordenes             INT               AUTO_INCREMENT,
    vreferenciaproducto     VARCHAR(30),
    cinicioproducto         VARCHAR(30),
    ventregaproducto        VARCHAR(30),
    vultimomovimiento       VARCHAR(10),
    nnodocumento            INTEGER,
    dnoproductoafabricar    DECIMAL(10, 0),
    dnoproductoterminado    DECIMAL(10, 0),
    dnoproductofaltante     CHAR(10),
    ncodprocesoorden        INT               NOT NULL,
    ncodstatusorden         INT,
    PRIMARY KEY (ncodordenes)
)TYPE=INNODB
;



-- 
-- TABLE: MaORDENCOMPRA 
--

CREATE TABLE MaORDENCOMPRA(
    ncodordencompra       INT               AUTO_INCREMENT,
    ncodproveedor         INT               NOT NULL,
    vdescripcioncompra    VARCHAR(40),
    ncantidad             INTEGER,
    dcostototal           DECIMAL(10, 0),
    ncodarticulo          INT               NOT NULL,
    PRIMARY KEY (ncodordencompra)
)TYPE=MYISAM
;



-- 
-- TABLE: MaPEDIDO 
--

CREATE TABLE MaPEDIDO(
    ncodpedido           INT               AUTO_INCREMENT,
    vserie               VARCHAR(18),
    dfechapedido         DATE,
    dfechavencimiento    DATE,
    ntotal               INT,
    vestadocotizacion    VARCHAR(10),
    ncodcliente          DECIMAL(10, 0)    NOT NULL,
    ncodvendedor         INT               NOT NULL,
    PRIMARY KEY (ncodpedido)
)TYPE=INNODB
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
)TYPE=MYISAM
;



-- 
-- TABLE: MaPROVEEDOR 
--

CREATE TABLE MaPROVEEDOR(
    ncodproveedor    INT               AUTO_INCREMENT,
    nnit             VARCHAR(18),
    vciudad          VARCHAR(40),
    vnombre          VARCHAR(30),
    vdireccion       VARCHAR(30),
    saldo            DECIMAL(18, 0),
    PRIMARY KEY (ncodproveedor)
)TYPE=INNODB
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
)TYPE=MYISAM
;



-- 
-- TABLE: MaRECETA 
--

CREATE TABLE MaRECETA(
    ncodreceta       INT            AUTO_INCREMENT,
    vnombrereceta    VARCHAR(20),
    ncodordenes      INT            NOT NULL,
    PRIMARY KEY (ncodreceta)
)TYPE=INNODB
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
)TYPE=MYISAM
;



-- 
-- TABLE: MaROLUSUARIO 
--

CREATE TABLE MaROLUSUARIO(
    ncodrole       INT            AUTO_INCREMENT,
    vnombrerole    VARCHAR(10),
    PRIMARY KEY (ncodrole)
)TYPE=INNODB
;



-- 
-- TABLE: MaTIPOARTICULO 
--

CREATE TABLE MaTIPOARTICULO(
    ncodtipoarticulo    INT            AUTO_INCREMENT,
    vnombre             VARCHAR(10),
    vdescripcion        VARCHAR(10),
    PRIMARY KEY (ncodtipoarticulo)
)TYPE=INNODB
;



-- 
-- TABLE: MaTIPOERROR 
--

CREATE TABLE MaTIPOERROR(
    ncodtipo    INT            AUTO_INCREMENT,
    vnombre     VARCHAR(30),
    PRIMARY KEY (ncodtipo)
)TYPE=INNODB
;



-- 
-- TABLE: MaTIPOMOVIMIENTO 
--

CREATE TABLE MaTIPOMOVIMIENTO(
    ncodmoviemiento    INT            AUTO_INCREMENT,
    vdescripcion       VARCHAR(40),
    vtipomovimiento    VARCHAR(40),
    PRIMARY KEY (ncodmoviemiento)
)TYPE=MYISAM
;



-- 
-- TABLE: MaTIPOPAGO 
--

CREATE TABLE MaTIPOPAGO(
    ncodtipopago            INT            AUTO_INCREMENT,
    vdescripciontipopago    VARCHAR(30),
    PRIMARY KEY (ncodtipopago)
)TYPE=INNODB
;



-- 
-- TABLE: MaTIPOTRANSACCION 
--

CREATE TABLE MaTIPOTRANSACCION(
    ncodtipotransaccion    INT               AUTO_INCREMENT,
    nnumdocumento          DECIMAL(10, 0),
    vbincdec               VARCHAR(20),
    vnombredocumento       VARCHAR(20),
    cestado                CHAR(20),
    PRIMARY KEY (ncodtipotransaccion)
)TYPE=INNODB
;



-- 
-- TABLE: MaUSOARTICULO 
--

CREATE TABLE MaUSOARTICULO(
    ncodarticulo        INT    NOT NULL,
    ncoddepartamento    INT    NOT NULL
)TYPE=MYISAM
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
    ncodempleado        INT,
    PRIMARY KEY (ncodusuario)
)TYPE=INNODB
;



-- 
-- TABLE: MaVENDEDOR 
--

CREATE TABLE MaVENDEDOR(
    ncodvendedor         INT               AUTO_INCREMENT,
    vnombrevendedor      VARCHAR(50),
    vapellidovendedor    VARCHAR(50),
    vdireccion           VARCHAR(100),
    ntelefono            DECIMAL(10, 0),
    vcorreo              VARCHAR(30),
    vestado              VARCHAR(20),
    PRIMARY KEY (ncodvendedor)
)TYPE=INNODB
;



-- 
-- TABLE: MaVENTAS 
--

CREATE TABLE MaVENTAS(
    ncodventas      INT               AUTO_INCREMENT,
    vfechaventa     VARCHAR(40),
    dprecioventa    DECIMAL(10, 0),
    PRIMARY KEY (ncodventas)
)TYPE=MYISAM
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
)TYPE=MYISAM
;



-- 
-- TABLE: TrCOBRO 
--

CREATE TABLE TrCOBRO(
    ncodcobro          INT               AUTO_INCREMENT,
    dpago              DECIMAL(10, 0),
    dsaldo             DECIMAL(10, 0),
    dfecha             DATE,
    ncodmora           INT               NOT NULL,
    ncodfactura        INT               NOT NULL,
    ncodtransaccion    INT               NOT NULL,
    PRIMARY KEY (ncodcobro)
)TYPE=INNODB
;



-- 
-- TABLE: TrCOMPRA 
--

CREATE TABLE TrCOMPRA(
    ncodcompra       INT    NOT NULL,
    ncodarticulo     INT    NOT NULL,
    ncodproveedor    INT    NOT NULL
)TYPE=INNODB
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
    dsalario           DECIMAL(10, 0),
    ncodempleado       INT               NOT NULL,
    ncodempresa        INT               NOT NULL,
    ncodsolicitud      INT               NOT NULL,
    PRIMARY KEY (ncodcontrato)
)TYPE=MYISAM
;



-- 
-- TABLE: TrDEPARTAMENTO 
--

CREATE TABLE TrDEPARTAMENTO(
    ncoddepartamento       INT            AUTO_INCREMENT,
    vnombredepartamento    VARCHAR(30),
    vtipo                  VARCHAR(30),
    PRIMARY KEY (ncoddepartamento)
)TYPE=MYISAM
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
)TYPE=MYISAM
;



-- 
-- TABLE: TrDETALLECONCILIACION 
--

CREATE TABLE TrDETALLECONCILIACION(
    ncodconcilicacion    INT,
    ncodDetalleConci     INT    AUTO_INCREMENT,
    ncodtransaccion      INT,
    PRIMARY KEY (ncodDetalleConci)
)TYPE=INNODB
;



-- 
-- TABLE: TrDETALLERECETA 
--

CREATE TABLE TrDETALLERECETA(
    ncantidad       INT    AUTO_INCREMENT,
    ncodreceta      INT    NOT NULL,
    ncodmaterial    INT    NOT NULL,
    PRIMARY KEY (ncantidad)
)TYPE=INNODB
;



-- 
-- TABLE: TrESCOLARIDAD 
--

CREATE TABLE TrESCOLARIDAD(
    ncodescolaridad    INT            AUTO_INCREMENT,
    vtipo              VARCHAR(30),
    vdescripcion       VARCHAR(30),
    PRIMARY KEY (ncodescolaridad)
)TYPE=MYISAM
;



-- 
-- TABLE: TrEXISTENCIA 
--

CREATE TABLE TrEXISTENCIA(
    nexistencia     INT    AUTO_INCREMENT,
    ncodbodega      INT    NOT NULL,
    ncodarticulo    INT    NOT NULL
)TYPE=MYISAM
;



-- 
-- TABLE: TrFAMILIA 
--

CREATE TABLE TrFAMILIA(
    ncodfamilia     INT            AUTO_INCREMENT,
    vtipo           VARCHAR(10),
    vdescripcion    VARCHAR(20),
    PRIMARY KEY (ncodfamilia)
)TYPE=MYISAM
;



-- 
-- TABLE: TrGRAFICA 
--

CREATE TABLE TrGRAFICA(
    ncodgrafica       INT          AUTO_INCREMENT,
    dfecha            DATE,
    ctipo             CHAR(20),
    ctitulografica    CHAR(100)    NOT NULL,
    cejex             CHAR(100)    NOT NULL,
    cejey             CHAR(100)    NOT NULL,
    ncodreporte       INT          NOT NULL,
    ncodusuario       INT          NOT NULL,
    PRIMARY KEY (ncodgrafica)
)TYPE=INNODB
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
)TYPE=MYISAM
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
)TYPE=MYISAM
;



-- 
-- TABLE: TrPAGOPROVEEDOR 
--

CREATE TABLE TrPAGOPROVEEDOR(
    ncodpagoproveedor    INT    AUTO_INCREMENT,
    ncodproveedor        INT    NOT NULL,
    ncodtransaccion      INT    NOT NULL,
    PRIMARY KEY (ncodpagoproveedor)
)TYPE=INNODB
;



-- 
-- TABLE: TrPAGOS 
--

CREATE TABLE TrPAGOS(
    ncodpago           INT               AUTO_INCREMENT,
    vcantidadpago      VARCHAR(10),
    dfechapago         DATE,
    vdescripcion       VARCHAR(30),
    ncodcuenta         INT               NOT NULL,
    ncodrecibopago     INT               NOT NULL,
    ncodtipopago       INT,
    ncoddocumento      DECIMAL(10, 0)    NOT NULL,
    ncodtransaccion    INT,
    PRIMARY KEY (ncodpago)
)TYPE=INNODB
;



-- 
-- TABLE: TrPAGOSALARIO 
--

CREATE TABLE TrPAGOSALARIO(
    ncodpagosalario    INT    AUTO_INCREMENT,
    ncodcontrato       INT    NOT NULL,
    ncodtransaccion    INT    NOT NULL,
    PRIMARY KEY (ncodpagosalario)
)TYPE=INNODB
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
    ncodcliente          DECIMAL(10, 0)    NOT NULL,
    ncodvendedor         INT               NOT NULL,
    PRIMARY KEY (ncodpedido)
)TYPE=INNODB
;



-- 
-- TABLE: TrPLANILLA 
--

CREATE TABLE TrPLANILLA(
    cprestaciones     CHAR(10),
    vdetalle          VARCHAR(20),
    vhorasnormales    VARCHAR(10),
    vhorasextra       VARCHAR(10),
    nsemanas          INTEGER,
    ncodempleado      INT               NOT NULL,
    ncodempresa       INT               NOT NULL
)TYPE=MYISAM
;



-- 
-- TABLE: TrPROCESOORDEN 
--

CREATE TABLE TrPROCESOORDEN(
    ncodprocesoorden    INT            AUTO_INCREMENT,
    vnombreproceso      VARCHAR(10),
    PRIMARY KEY (ncodprocesoorden)
)TYPE=MYISAM
;



-- 
-- TABLE: TrREPORTE 
--

CREATE TABLE TrREPORTE(
    ncodreporte       INT            AUTO_INCREMENT,
    vnomreporte       VARCHAR(30),
    dfechareporte     DATE,
    ncodaplicacion    INTEGER,
    ncodmodulo        INT            NOT NULL,
    ncodusuario       INT            NOT NULL,
    PRIMARY KEY (ncodreporte)
)TYPE=INNODB
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
)TYPE=INNODB
;



-- 
-- TABLE: TrSTATUSORDEN 
--

CREATE TABLE TrSTATUSORDEN(
    ncodstatusorden    INT            AUTO_INCREMENT,
    vestatus           VARCHAR(30),
    PRIMARY KEY (ncodstatusorden)
)TYPE=INNODB
;



-- 
-- TABLE: TrTRANSACCION 
--

CREATE TABLE TrTRANSACCION(
    ncodtransaccion        INT               AUTO_INCREMENT,
    dfecha                 DATE,
    dmonto                 DECIMAL(10, 0),
    ncodtipotransaccion    INT               NOT NULL,
    ncodcuenta             INT               NOT NULL,
    PRIMARY KEY (ncodtransaccion)
)TYPE=INNODB
;



-- 
-- TABLE: TrUSUARIOAPLCACION 
--

CREATE TABLE TrUSUARIOAPLCACION(
    ncodusuario       INT         NOT NULL,
    ncodaplicacion    INT         NOT NULL,
    btnimprimir       BOOLEAN     NOT NULL,
    btnnuevo          BOOLEAN,
    btnirUltimo       BOOLEAN,
    btnirPrimero      BOOLEAN,
    btnanterior       BOOLEAN,
    btnsiguiente      BOOLEAN,
    btneditar         BOOLEAN,
    btncancelar       BOOLEAN,
    btnrefrescar      BOOLEAN,
    btnbuscar         BOOLEAN,
    btneliminar       BOOLEAN,
    btnguardar        BOOLEAN
)TYPE=INNODB
;



-- 
-- TABLE: TrUSUARIOROLE 
--

CREATE TABLE TrUSUARIOROLE(
    ncodusuario     INT         NOT NULL,
    ncodrole        INT         NOT NULL,
    btnimprimir     BOOLEAN,
    btnnuevo        BOOLEAN,
    btnirUltimo     BOOLEAN,
    btnsiguiente    BOOLEAN,
    btnanterior     BOOLEAN,
    btnirPrimero    BOOLEAN,
    btneditar       BOOLEAN,
    btncancelar     BOOLEAN,
    btnrefrescar    BOOLEAN,
    btnbuscar       BOOLEAN,
    btneliminar     BOOLEAN,
    btnguardar      BOOLEAN
)TYPE=INNODB
;



-- 
-- TABLE: MaAPLICACION 
--

ALTER TABLE MaAPLICACION ADD CONSTRAINT RefMaMODULO204 
    FOREIGN KEY (ncodmodulo)
    REFERENCES MaMODULO(ncodmodulo)
;


-- 
-- TABLE: MaARTICULO 
--

ALTER TABLE MaARTICULO ADD CONSTRAINT RefMaLINEAARTICULO135 
    FOREIGN KEY (ncodlineaarticulo)
    REFERENCES MaLINEAARTICULO(ncodlineaarticulo)
;

ALTER TABLE MaARTICULO ADD CONSTRAINT RefMaTIPOARTICULO136 
    FOREIGN KEY (ncodtipoarticulo)
    REFERENCES MaTIPOARTICULO(ncodtipoarticulo)
;

ALTER TABLE MaARTICULO ADD CONSTRAINT RefMaPROVEEDOR140 
    FOREIGN KEY (ncodproveedor)
    REFERENCES MaPROVEEDOR(ncodproveedor)
;


-- 
-- TABLE: MaBITACORA 
--

ALTER TABLE MaBITACORA ADD CONSTRAINT RefMaACCIONES202 
    FOREIGN KEY (ncodaccion)
    REFERENCES MaACCIONES(ncodaccion)
;

ALTER TABLE MaBITACORA ADD CONSTRAINT RefMaUSUARIO203 
    FOREIGN KEY (ncodusuario)
    REFERENCES MaUSUARIO(ncodusuario)
;

ALTER TABLE MaBITACORA ADD CONSTRAINT RefMaAPLICACION205 
    FOREIGN KEY (ncodaplicacion)
    REFERENCES MaAPLICACION(ncodaplicacion)
;


-- 
-- TABLE: MaCAPACITACION 
--

ALTER TABLE MaCAPACITACION ADD CONSTRAINT RefMaEMPLEADO150 
    FOREIGN KEY (ncodempleado)
    REFERENCES MaEMPLEADO(ncodempleado)
;


-- 
-- TABLE: MaCOGNITIVO 
--

ALTER TABLE MaCOGNITIVO ADD CONSTRAINT RefMaEMPLEADO125 
    FOREIGN KEY (ncodempleado)
    REFERENCES MaEMPLEADO(ncodempleado)
;


-- 
-- TABLE: MaCOTIZACION 
--

ALTER TABLE MaCOTIZACION ADD CONSTRAINT RefMaCLIENTE168 
    FOREIGN KEY (ncodcliente)
    REFERENCES MaCLIENTE(ncodcliente)
;

ALTER TABLE MaCOTIZACION ADD CONSTRAINT RefMaVENDEDOR226 
    FOREIGN KEY (ncodvendedor)
    REFERENCES MaVENDEDOR(ncodvendedor)
;

ALTER TABLE MaCOTIZACION ADD CONSTRAINT RefMaVENDEDOR242 
    FOREIGN KEY (ncodvendedor)
    REFERENCES MaVENDEDOR(ncodvendedor)
;

ALTER TABLE MaCOTIZACION ADD CONSTRAINT RefMaCLIENTE243 
    FOREIGN KEY (ncodcliente)
    REFERENCES MaCLIENTE(ncodcliente)
;


-- 
-- TABLE: MaCUENTA 
--

ALTER TABLE MaCUENTA ADD CONSTRAINT RefMaBANCO128 
    FOREIGN KEY (ncodbanco)
    REFERENCES MaBANCO(ncodbanco)
;

ALTER TABLE MaCUENTA ADD CONSTRAINT RefMaDOCUMENTO157 
    FOREIGN KEY (ncoddocumento)
    REFERENCES MaDOCUMENTO(ncoddocumento)
;


-- 
-- TABLE: MaDETALLECOTIZACION 
--

ALTER TABLE MaDETALLECOTIZACION ADD CONSTRAINT RefMaCOTIZACION169 
    FOREIGN KEY (ncodcotizacion)
    REFERENCES MaCOTIZACION(ncodcotizacion)
;

ALTER TABLE MaDETALLECOTIZACION ADD CONSTRAINT RefMaARTICULO170 
    FOREIGN KEY (ncodarticulo)
    REFERENCES MaARTICULO(ncodarticulo)
;

ALTER TABLE MaDETALLECOTIZACION ADD CONSTRAINT RefMaARTICULO252 
    FOREIGN KEY (ncodarticulo)
    REFERENCES MaARTICULO(ncodarticulo)
;


-- 
-- TABLE: MaDETALLEFACTURA 
--

ALTER TABLE MaDETALLEFACTURA ADD CONSTRAINT RefMaARTICULO134 
    FOREIGN KEY (ncodarticulo)
    REFERENCES MaARTICULO(ncodarticulo)
;

ALTER TABLE MaDETALLEFACTURA ADD CONSTRAINT RefMaFACTURA151 
    FOREIGN KEY (ncodfactura)
    REFERENCES MaFACTURA(ncodfactura)
;

ALTER TABLE MaDETALLEFACTURA ADD CONSTRAINT RefMaARTICULO251 
    FOREIGN KEY (ncodarticulo)
    REFERENCES MaARTICULO(ncodarticulo)
;


-- 
-- TABLE: MaDETALLEPEDIDO 
--

ALTER TABLE MaDETALLEPEDIDO ADD CONSTRAINT RefTrPEDIDO171 
    FOREIGN KEY (ncodpedido)
    REFERENCES TrPEDIDO(ncodpedido)
;

ALTER TABLE MaDETALLEPEDIDO ADD CONSTRAINT RefMaARTICULO172 
    FOREIGN KEY (ncodarticulo)
    REFERENCES MaARTICULO(ncodarticulo)
;

ALTER TABLE MaDETALLEPEDIDO ADD CONSTRAINT RefMaPEDIDO249 
    FOREIGN KEY (ncodpedido)
    REFERENCES MaPEDIDO(ncodpedido)
;

ALTER TABLE MaDETALLEPEDIDO ADD CONSTRAINT RefMaARTICULO250 
    FOREIGN KEY (ncodarticulo)
    REFERENCES MaARTICULO(ncodarticulo)
;


-- 
-- TABLE: MaDOCUMENTO 
--

ALTER TABLE MaDOCUMENTO ADD CONSTRAINT RefMaPROVEEDOR160 
    FOREIGN KEY (ncodproveedor)
    REFERENCES MaPROVEEDOR(ncodproveedor)
;


-- 
-- TABLE: MaEMPLEADO 
--

ALTER TABLE MaEMPLEADO ADD CONSTRAINT RefTrHISTORIAEMP130 
    FOREIGN KEY (ncodhistoria)
    REFERENCES TrHISTORIAEMP(ncodhistoria)
;

ALTER TABLE MaEMPLEADO ADD CONSTRAINT RefTrDEPARTAMENTO152 
    FOREIGN KEY (ncoddepartamento)
    REFERENCES TrDEPARTAMENTO(ncoddepartamento)
;


-- 
-- TABLE: MaENCABEZADOCONCILIACION 
--

ALTER TABLE MaENCABEZADOCONCILIACION ADD CONSTRAINT RefMaCUENTA190 
    FOREIGN KEY (ncodcuenta)
    REFERENCES MaCUENTA(ncodcuenta)
;


-- 
-- TABLE: MaERROR 
--

ALTER TABLE MaERROR ADD CONSTRAINT RefMaTIPOERROR199 
    FOREIGN KEY (ncodtipo)
    REFERENCES MaTIPOERROR(ncodtipo)
;

ALTER TABLE MaERROR ADD CONSTRAINT RefMaUSUARIO200 
    FOREIGN KEY (ncodusuario)
    REFERENCES MaUSUARIO(ncodusuario)
;

ALTER TABLE MaERROR ADD CONSTRAINT RefMaACCIONES201 
    FOREIGN KEY (ncodaccion)
    REFERENCES MaACCIONES(ncodaccion)
;

ALTER TABLE MaERROR ADD CONSTRAINT RefMaAPLICACION206 
    FOREIGN KEY (ncodaplicacion)
    REFERENCES MaAPLICACION(ncodaplicacion)
;


-- 
-- TABLE: MaFACTURA 
--

ALTER TABLE MaFACTURA ADD CONSTRAINT RefMaCLIENTE124 
    FOREIGN KEY (ncodcliente)
    REFERENCES MaCLIENTE(ncodcliente)
;

ALTER TABLE MaFACTURA ADD CONSTRAINT RefMaVENDEDOR225 
    FOREIGN KEY (ncodvendedor)
    REFERENCES MaVENDEDOR(ncodvendedor)
;

ALTER TABLE MaFACTURA ADD CONSTRAINT RefMaCLIENTE241 
    FOREIGN KEY (ncodcliente)
    REFERENCES MaCLIENTE(ncodcliente)
;

ALTER TABLE MaFACTURA ADD CONSTRAINT RefMaCLIENTE248 
    FOREIGN KEY (ncodcliente)
    REFERENCES MaCLIENTE(ncodcliente)
;


-- 
-- TABLE: MaLOCACION 
--

ALTER TABLE MaLOCACION ADD CONSTRAINT RefMaEMPLEADO155 
    FOREIGN KEY (ncodempleado)
    REFERENCES MaEMPLEADO(ncodempleado)
;


-- 
-- TABLE: MaMATERIAL 
--

ALTER TABLE MaMATERIAL ADD CONSTRAINT RefMaARTICULO117 
    FOREIGN KEY (ncodarticulo)
    REFERENCES MaARTICULO(ncodarticulo)
;


-- 
-- TABLE: MaMONEDA 
--

ALTER TABLE MaMONEDA ADD CONSTRAINT RefMaBANCO165 
    FOREIGN KEY (ncodbanco)
    REFERENCES MaBANCO(ncodbanco)
;


-- 
-- TABLE: MaMORA 
--

ALTER TABLE MaMORA ADD CONSTRAINT RefMaFACTURA110 
    FOREIGN KEY (ncodfactura)
    REFERENCES MaFACTURA(ncodfactura)
;


-- 
-- TABLE: MaOBSERVACION 
--

ALTER TABLE MaOBSERVACION ADD CONSTRAINT RefTrDETALLECONCILIACION196 
    FOREIGN KEY (ncodDetalleConci)
    REFERENCES TrDETALLECONCILIACION(ncodDetalleConci)
;


-- 
-- TABLE: MaORDEN 
--

ALTER TABLE MaORDEN ADD CONSTRAINT RefTrPROCESOORDEN143 
    FOREIGN KEY (ncodprocesoorden)
    REFERENCES TrPROCESOORDEN(ncodprocesoorden)
;

ALTER TABLE MaORDEN ADD CONSTRAINT RefTrSTATUSORDEN191 
    FOREIGN KEY (ncodstatusorden)
    REFERENCES TrSTATUSORDEN(ncodstatusorden)
;


-- 
-- TABLE: MaORDENCOMPRA 
--

ALTER TABLE MaORDENCOMPRA ADD CONSTRAINT RefMaPROVEEDOR118 
    FOREIGN KEY (ncodproveedor)
    REFERENCES MaPROVEEDOR(ncodproveedor)
;

ALTER TABLE MaORDENCOMPRA ADD CONSTRAINT RefMaARTICULO163 
    FOREIGN KEY (ncodarticulo)
    REFERENCES MaARTICULO(ncodarticulo)
;


-- 
-- TABLE: MaPEDIDO 
--

ALTER TABLE MaPEDIDO ADD CONSTRAINT RefMaCLIENTE245 
    FOREIGN KEY (ncodcliente)
    REFERENCES MaCLIENTE(ncodcliente)
;

ALTER TABLE MaPEDIDO ADD CONSTRAINT RefMaVENDEDOR247 
    FOREIGN KEY (ncodvendedor)
    REFERENCES MaVENDEDOR(ncodvendedor)
;


-- 
-- TABLE: MaPLAZA 
--

ALTER TABLE MaPLAZA ADD CONSTRAINT RefMaEMPRESA149 
    FOREIGN KEY (ncodempresa)
    REFERENCES MaEMPRESA(ncodempresa)
;


-- 
-- TABLE: MaPUNTO 
--

ALTER TABLE MaPUNTO ADD CONSTRAINT RefTrGRAFICA216 
    FOREIGN KEY (ncodgrafica)
    REFERENCES TrGRAFICA(ncodgrafica)
;


-- 
-- TABLE: MaRECETA 
--

ALTER TABLE MaRECETA ADD CONSTRAINT RefMaORDEN222 
    FOREIGN KEY (ncodordenes)
    REFERENCES MaORDEN(ncodordenes)
;


-- 
-- TABLE: MaRECIBOPAGO 
--

ALTER TABLE MaRECIBOPAGO ADD CONSTRAINT RefMaPROVEEDOR141 
    FOREIGN KEY (ncodproveedor)
    REFERENCES MaPROVEEDOR(ncodproveedor)
;


-- 
-- TABLE: MaUSOARTICULO 
--

ALTER TABLE MaUSOARTICULO ADD CONSTRAINT RefMaARTICULO120 
    FOREIGN KEY (ncodarticulo)
    REFERENCES MaARTICULO(ncodarticulo)
;

ALTER TABLE MaUSOARTICULO ADD CONSTRAINT RefMaDEPARTAMENTO121 
    FOREIGN KEY (ncoddepartamento)
    REFERENCES MaDEPARTAMENTO(ncoddepartamento)
;


-- 
-- TABLE: MaUSUARIO 
--

ALTER TABLE MaUSUARIO ADD CONSTRAINT RefMaEMPLEADO213 
    FOREIGN KEY (ncodempleado)
    REFERENCES MaEMPLEADO(ncodempleado)
;


-- 
-- TABLE: TrACTIVIDADLUDICA 
--

ALTER TABLE TrACTIVIDADLUDICA ADD CONSTRAINT RefMaEMPLEADO129 
    FOREIGN KEY (ncodempleado)
    REFERENCES MaEMPLEADO(ncodempleado)
;


-- 
-- TABLE: TrCOBRO 
--

ALTER TABLE TrCOBRO ADD CONSTRAINT RefMaMORA122 
    FOREIGN KEY (ncodmora)
    REFERENCES MaMORA(ncodmora)
;

ALTER TABLE TrCOBRO ADD CONSTRAINT RefMaFACTURA123 
    FOREIGN KEY (ncodfactura)
    REFERENCES MaFACTURA(ncodfactura)
;

ALTER TABLE TrCOBRO ADD CONSTRAINT RefTrTRANSACCION139 
    FOREIGN KEY (ncodtransaccion)
    REFERENCES TrTRANSACCION(ncodtransaccion)
;


-- 
-- TABLE: TrCOMPRA 
--

ALTER TABLE TrCOMPRA ADD CONSTRAINT RefMaCOMPRA237 
    FOREIGN KEY (ncodcompra)
    REFERENCES MaCOMPRA(ncodcompra)
;

ALTER TABLE TrCOMPRA ADD CONSTRAINT RefMaARTICULO238 
    FOREIGN KEY (ncodarticulo)
    REFERENCES MaARTICULO(ncodarticulo)
;

ALTER TABLE TrCOMPRA ADD CONSTRAINT RefMaPROVEEDOR239 
    FOREIGN KEY (ncodproveedor)
    REFERENCES MaPROVEEDOR(ncodproveedor)
;


-- 
-- TABLE: TrCONTRATO 
--

ALTER TABLE TrCONTRATO ADD CONSTRAINT RefMaEMPLEADO147 
    FOREIGN KEY (ncodempleado)
    REFERENCES MaEMPLEADO(ncodempleado)
;

ALTER TABLE TrCONTRATO ADD CONSTRAINT RefMaEMPRESA148 
    FOREIGN KEY (ncodempresa)
    REFERENCES MaEMPRESA(ncodempresa)
;

ALTER TABLE TrCONTRATO ADD CONSTRAINT RefTrSOLICITUD153 
    FOREIGN KEY (ncodsolicitud)
    REFERENCES TrSOLICITUD(ncodsolicitud)
;


-- 
-- TABLE: TrDESEMPENIO 
--

ALTER TABLE TrDESEMPENIO ADD CONSTRAINT RefMaEMPLEADO187 
    FOREIGN KEY (ncodempleado)
    REFERENCES MaEMPLEADO(ncodempleado)
;


-- 
-- TABLE: TrDETALLECONCILIACION 
--

ALTER TABLE TrDETALLECONCILIACION ADD CONSTRAINT RefMaENCABEZADOCONCILIACION188 
    FOREIGN KEY (ncodconcilicacion)
    REFERENCES MaENCABEZADOCONCILIACION(ncodconcilicacion)
;

ALTER TABLE TrDETALLECONCILIACION ADD CONSTRAINT RefTrTRANSACCION189 
    FOREIGN KEY (ncodtransaccion)
    REFERENCES TrTRANSACCION(ncodtransaccion)
;


-- 
-- TABLE: TrDETALLERECETA 
--

ALTER TABLE TrDETALLERECETA ADD CONSTRAINT RefMaRECETA221 
    FOREIGN KEY (ncodreceta)
    REFERENCES MaRECETA(ncodreceta)
;

ALTER TABLE TrDETALLERECETA ADD CONSTRAINT RefMaMATERIAL223 
    FOREIGN KEY (ncodmaterial)
    REFERENCES MaMATERIAL(ncodmaterial)
;


-- 
-- TABLE: TrEXISTENCIA 
--

ALTER TABLE TrEXISTENCIA ADD CONSTRAINT RefMaBODEGA126 
    FOREIGN KEY (ncodbodega)
    REFERENCES MaBODEGA(ncodbodega)
;

ALTER TABLE TrEXISTENCIA ADD CONSTRAINT RefMaARTICULO137 
    FOREIGN KEY (ncodarticulo)
    REFERENCES MaARTICULO(ncodarticulo)
;


-- 
-- TABLE: TrGRAFICA 
--

ALTER TABLE TrGRAFICA ADD CONSTRAINT RefTrREPORTE217 
    FOREIGN KEY (ncodreporte)
    REFERENCES TrREPORTE(ncodreporte)
;

ALTER TABLE TrGRAFICA ADD CONSTRAINT RefMaUSUARIO219 
    FOREIGN KEY (ncodusuario)
    REFERENCES MaUSUARIO(ncodusuario)
;


-- 
-- TABLE: TrMOVIMIENTO 
--

ALTER TABLE TrMOVIMIENTO ADD CONSTRAINT RefMaTIPOMOVIMIENTO127 
    FOREIGN KEY (ncodmoviemiento)
    REFERENCES MaTIPOMOVIMIENTO(ncodmoviemiento)
;

ALTER TABLE TrMOVIMIENTO ADD CONSTRAINT RefMaARTICULO144 
    FOREIGN KEY (ncodarticulo)
    REFERENCES MaARTICULO(ncodarticulo)
;


-- 
-- TABLE: TrPAGOPROVEEDOR 
--

ALTER TABLE TrPAGOPROVEEDOR ADD CONSTRAINT RefMaPROVEEDOR161 
    FOREIGN KEY (ncodproveedor)
    REFERENCES MaPROVEEDOR(ncodproveedor)
;

ALTER TABLE TrPAGOPROVEEDOR ADD CONSTRAINT RefTrTRANSACCION164 
    FOREIGN KEY (ncodtransaccion)
    REFERENCES TrTRANSACCION(ncodtransaccion)
;


-- 
-- TABLE: TrPAGOS 
--

ALTER TABLE TrPAGOS ADD CONSTRAINT RefMaCUENTA145 
    FOREIGN KEY (ncodcuenta)
    REFERENCES MaCUENTA(ncodcuenta)
;

ALTER TABLE TrPAGOS ADD CONSTRAINT RefMaRECIBOPAGO156 
    FOREIGN KEY (ncodrecibopago)
    REFERENCES MaRECIBOPAGO(ncodrecibopago)
;

ALTER TABLE TrPAGOS ADD CONSTRAINT RefMaTIPOPAGO232 
    FOREIGN KEY (ncodtipopago)
    REFERENCES MaTIPOPAGO(ncodtipopago)
;

ALTER TABLE TrPAGOS ADD CONSTRAINT RefMaDOCUMENTO233 
    FOREIGN KEY (ncoddocumento)
    REFERENCES MaDOCUMENTO(ncoddocumento)
;

ALTER TABLE TrPAGOS ADD CONSTRAINT RefTrTRANSACCION235 
    FOREIGN KEY (ncodtransaccion)
    REFERENCES TrTRANSACCION(ncodtransaccion)
;


-- 
-- TABLE: TrPAGOSALARIO 
--

ALTER TABLE TrPAGOSALARIO ADD CONSTRAINT RefTrCONTRATO133 
    FOREIGN KEY (ncodcontrato)
    REFERENCES TrCONTRATO(ncodcontrato)
;

ALTER TABLE TrPAGOSALARIO ADD CONSTRAINT RefTrTRANSACCION154 
    FOREIGN KEY (ncodtransaccion)
    REFERENCES TrTRANSACCION(ncodtransaccion)
;


-- 
-- TABLE: TrPEDIDO 
--

ALTER TABLE TrPEDIDO ADD CONSTRAINT RefMaVENTAS119 
    FOREIGN KEY (ncodventas)
    REFERENCES MaVENTAS(ncodventas)
;

ALTER TABLE TrPEDIDO ADD CONSTRAINT RefMaARTICULO146 
    FOREIGN KEY (ncodarticulo)
    REFERENCES MaARTICULO(ncodarticulo)
;

ALTER TABLE TrPEDIDO ADD CONSTRAINT RefMaCLIENTE167 
    FOREIGN KEY (ncodcliente)
    REFERENCES MaCLIENTE(ncodcliente)
;

ALTER TABLE TrPEDIDO ADD CONSTRAINT RefMaVENDEDOR224 
    FOREIGN KEY (ncodvendedor)
    REFERENCES MaVENDEDOR(ncodvendedor)
;


-- 
-- TABLE: TrPLANILLA 
--

ALTER TABLE TrPLANILLA ADD CONSTRAINT RefMaEMPLEADO112 
    FOREIGN KEY (ncodempleado)
    REFERENCES MaEMPLEADO(ncodempleado)
;

ALTER TABLE TrPLANILLA ADD CONSTRAINT RefMaEMPRESA113 
    FOREIGN KEY (ncodempresa)
    REFERENCES MaEMPRESA(ncodempresa)
;


-- 
-- TABLE: TrREPORTE 
--

ALTER TABLE TrREPORTE ADD CONSTRAINT RefMaMODULO197 
    FOREIGN KEY (ncodmodulo)
    REFERENCES MaMODULO(ncodmodulo)
;

ALTER TABLE TrREPORTE ADD CONSTRAINT RefMaUSUARIO198 
    FOREIGN KEY (ncodusuario)
    REFERENCES MaUSUARIO(ncodusuario)
;

ALTER TABLE TrREPORTE ADD CONSTRAINT RefMaUSUARIO220 
    FOREIGN KEY (ncodusuario)
    REFERENCES MaUSUARIO(ncodusuario)
;


-- 
-- TABLE: TrSOLICITUD 
--

ALTER TABLE TrSOLICITUD ADD CONSTRAINT RefTrESCOLARIDAD131 
    FOREIGN KEY (ncodescolaridad)
    REFERENCES TrESCOLARIDAD(ncodescolaridad)
;

ALTER TABLE TrSOLICITUD ADD CONSTRAINT RefTrFAMILIA162 
    FOREIGN KEY (ncodfamilia)
    REFERENCES TrFAMILIA(ncodfamilia)
;


-- 
-- TABLE: TrTRANSACCION 
--

ALTER TABLE TrTRANSACCION ADD CONSTRAINT RefMaTIPOTRANSACCION111 
    FOREIGN KEY (ncodtipotransaccion)
    REFERENCES MaTIPOTRANSACCION(ncodtipotransaccion)
;

ALTER TABLE TrTRANSACCION ADD CONSTRAINT RefMaCUENTA158 
    FOREIGN KEY (ncodcuenta)
    REFERENCES MaCUENTA(ncodcuenta)
;


-- 
-- TABLE: TrUSUARIOAPLCACION 
--

ALTER TABLE TrUSUARIOAPLCACION ADD CONSTRAINT RefMaUSUARIO207 
    FOREIGN KEY (ncodusuario)
    REFERENCES MaUSUARIO(ncodusuario)
;

ALTER TABLE TrUSUARIOAPLCACION ADD CONSTRAINT RefMaAPLICACION208 
    FOREIGN KEY (ncodaplicacion)
    REFERENCES MaAPLICACION(ncodaplicacion)
;


-- 
-- TABLE: TrUSUARIOROLE 
--

ALTER TABLE TrUSUARIOROLE ADD CONSTRAINT RefMaUSUARIO210 
    FOREIGN KEY (ncodusuario)
    REFERENCES MaUSUARIO(ncodusuario)
;

ALTER TABLE TrUSUARIOROLE ADD CONSTRAINT RefMaROLUSUARIO211 
    FOREIGN KEY (ncodrole)
    REFERENCES MaROLUSUARIO(ncodrole)
;


