--
-- ER/Studio 8.0 SQL Code Generation
-- Project :      ER (7 DE 8 modulos incluidos).dm1
--
-- Date Created : Sunday, October 11, 2015 07:59:08
-- Target DBMS : MySQL 5.x
--

-- 
-- TABLE: MaARTICULO 
--

CREATE TABLE MaARTICULO(
    ncodproveedor        DECIMAL(10, 0)    NOT NULL,
    ncodarticulo         DECIMAL(10, 0)    NOT NULL,
    ncodtipoarticulo     DECIMAL(10, 0)    NOT NULL,
    ncodlineaarticulo    DECIMAL(10, 0)    NOT NULL,
    ncantidad            DECIMAL(10, 0),
    nprecio              DECIMAL(10, 0),
    cmarca               CHAR(10),
    cestado              CHAR(10),
    cnombre              CHAR(10),
    cdescripcion         CHAR(10),
    cfotoarticulo        CHAR(10),
    cfechaingreso        CHAR(10),
    PRIMARY KEY (ncodproveedor, ncodarticulo, ncodtipoarticulo, ncodlineaarticulo)
)ENGINE=MYISAM
;



-- 
-- TABLE: MaBANCO 
--

CREATE TABLE MaBANCO(
    ncodbanco       DECIMAL(10, 0)    NOT NULL,
    cnombrebanco    CHAR(10),
    cdireccion      CHAR(10),
    PRIMARY KEY (ncodbanco)
)ENGINE=MYISAM
;



-- 
-- TABLE: MaBODEGA 
--

CREATE TABLE MaBODEGA(
    ncodbodega          DECIMAL(10, 0)    NOT NULL,
    cnombrebodega       CHAR(10),
    cdireccionbodega    CHAR(10),
    PRIMARY KEY (ncodbodega)
)ENGINE=MYISAM
;



-- 
-- TABLE: MaCAPACITACION 
--

CREATE TABLE MaCAPACITACION(
    ncodempleado           DECIMAL(10, 0)    NOT NULL,
    ncodcapacitacion       DECIMAL(10, 0)    NOT NULL,
    ncodhistoria           DECIMAL(10, 0)    NOT NULL,
    ncoddepartamento       DECIMAL(10, 0)    NOT NULL,
    cnombrecapacitacion    CHAR(10),
    ctipo                  CHAR(10),
    PRIMARY KEY (ncodempleado, ncodcapacitacion, ncodhistoria, ncoddepartamento)
)ENGINE=MYISAM
;



-- 
-- TABLE: MaCLIENTE 
--

CREATE TABLE MaCLIENTE(
    ncodcliente         DECIMAL(10, 0)    NOT NULL,
    cnombrecliente      CHAR(10),
    capellidocliente    CHAR(10),
    cdireccion          CHAR(10),
    ntelefono           DECIMAL(10, 0),
    ccorreo             CHAR(10),
    cestado             CHAR(10),
    PRIMARY KEY (ncodcliente)
)ENGINE=MYISAM
;



-- 
-- TABLE: MaCOGNITIVO 
--

CREATE TABLE MaCOGNITIVO(
    ncodempleado        DECIMAL(10, 0)    NOT NULL,
    ncodhistoria        DECIMAL(10, 0)    NOT NULL,
    ncoddepartamento    DECIMAL(10, 0)    NOT NULL,
    ctipo               CHAR(10),
    cdescripcion        CHAR(10),
    cestado             CHAR(10),
    PRIMARY KEY (ncodempleado, ncodhistoria, ncoddepartamento)
)ENGINE=MYISAM
;



-- 
-- TABLE: MaCUENTA 
--

CREATE TABLE MaCUENTA(
    ncodbanco       DECIMAL(10, 0)    NOT NULL,
    ncodcuenta      DECIMAL(10, 0)    NOT NULL,
    ncodmoneda      DECIMAL(10, 0)    NOT NULL,
    nmontocuenta    DECIMAL(10, 0),
    cfecha          CHAR(10),
    PRIMARY KEY (ncodbanco, ncodcuenta, ncodmoneda)
)ENGINE=MYISAM
;



-- 
-- TABLE: MaDEPARTAMENTO 
--

CREATE TABLE MaDEPARTAMENTO(
    ncoddepartamento    DECIMAL(10, 0)    NOT NULL,
    cresponsable        CHAR(10),
    cextension          CHAR(10),
    PRIMARY KEY (ncoddepartamento)
)ENGINE=MYISAM
;



-- 
-- TABLE: MaDETALLEFACTURA 
--

CREATE TABLE MaDETALLEFACTURA(
    ncodproveedor         DECIMAL(10, 0)    NOT NULL,
    ncoddetallefactura    DECIMAL(10, 0)    NOT NULL,
    ncodtipoarticulo      DECIMAL(10, 0)    NOT NULL,
    ncodarticulo          DECIMAL(10, 0)    NOT NULL,
    ncodlineaarticulo     DECIMAL(10, 0)    NOT NULL,
    ncodcliente           DECIMAL(10, 0)    NOT NULL,
    ncodfactura           DECIMAL(10, 0)    NOT NULL,
    ncantidaddeventa      DECIMAL(10, 0),
    nprecioventa          DECIMAL(10, 0),
    PRIMARY KEY (ncodproveedor, ncoddetallefactura, ncodtipoarticulo, ncodarticulo, ncodlineaarticulo, ncodcliente, ncodfactura)
)ENGINE=MYISAM
;



-- 
-- TABLE: MaDOCUMENTO 
--

CREATE TABLE MaDOCUMENTO(
    ncoddocumento        DECIMAL(10, 0)    NOT NULL,
    cfechadocumento      CHAR(10),
    creferenciafisica    CHAR(10),
    ntotalpago           DECIMAL(10, 0),
    ncantidadactual      DECIMAL(10, 0),
    cdescripcion         CHAR(10),
    PRIMARY KEY (ncoddocumento)
)ENGINE=MYISAM
;



-- 
-- TABLE: MaEMPLEADO 
--

CREATE TABLE MaEMPLEADO(
    ncodempleado         DECIMAL(10, 0)    NOT NULL,
    ncodhistoria         DECIMAL(10, 0)    NOT NULL,
    ncoddepartamento     DECIMAL(10, 0)    NOT NULL,
    cnombreempleado      CHAR(10),
    capellidoempleado    CHAR(10),
    cestadocivil         CHAR(10),
    csalario             CHAR(10),
    ccomision            CHAR(10),
    ctipo                CHAR(10),
    cescolaridad         CHAR(10),
    ntelefono            DECIMAL(10, 0),
    ccargo               CHAR(10),
    cdpi                 CHAR(10),
    nedad                DECIMAL(10, 0),
    cgenero              CHAR(10),
    nnumcuenta           DECIMAL(10, 0),
    PRIMARY KEY (ncodempleado, ncodhistoria, ncoddepartamento)
)ENGINE=MYISAM
;



-- 
-- TABLE: MaEMPRESA 
--

CREATE TABLE MaEMPRESA(
    ncodempresa       DECIMAL(10, 0)    NOT NULL,
    ctipoempresa      CHAR(10),
    cnombreempresa    CHAR(10),
    cdireccion        CHAR(10),
    ntelefono         DECIMAL(10, 0),
    cdescripcion      CHAR(10),
    PRIMARY KEY (ncodempresa)
)ENGINE=MYISAM
;



-- 
-- TABLE: MaFACTURA 
--

CREATE TABLE MaFACTURA(
    ncodcliente          DECIMAL(10, 0)    NOT NULL,
    ncodfactura          DECIMAL(10, 0)    NOT NULL,
    cserie               CHAR(10),
    cnombrefactura       CHAR(10),
    cnit                 CHAR(10),
    cdireccion           CHAR(10),
    cestado              CHAR(10),
    cfechavencimiento    CHAR(10),
    ntotal               DECIMAL(10, 0),
    cfecha               CHAR(10),
    PRIMARY KEY (ncodcliente, ncodfactura)
)ENGINE=MYISAM
;



-- 
-- TABLE: MaLINEAARTICULO 
--

CREATE TABLE MaLINEAARTICULO(
    ncodlineaarticulo    DECIMAL(10, 0)    NOT NULL,
    cnombre              CHAR(10),
    cdescripcion         CHAR(10),
    PRIMARY KEY (ncodlineaarticulo)
)ENGINE=MYISAM
;



-- 
-- TABLE: MaLOCACION 
--

CREATE TABLE MaLOCACION(
    ncodempleado        DECIMAL(10, 0)    NOT NULL,
    ncodlocacion        DECIMAL(10, 0)    NOT NULL,
    ncodhistoria        DECIMAL(10, 0)    NOT NULL,
    ncoddepartamento    DECIMAL(10, 0)    NOT NULL,
    cdireccion          CHAR(10),
    ncodpostal          CHAR(10),
    cciudad             CHAR(10),
    cprovincia          CHAR(10),
    PRIMARY KEY (ncodempleado, ncodlocacion, ncodhistoria, ncoddepartamento)
)ENGINE=MYISAM
;



-- 
-- TABLE: Mamaterial 
--

CREATE TABLE Mamaterial(
    ncodproveedor        DECIMAL(10, 0)    NOT NULL,
    ncodmaterial         DECIMAL(10, 0)    NOT NULL,
    ncodtipoarticulo     DECIMAL(10, 0)    NOT NULL,
    ncodarticulo         DECIMAL(10, 0)    NOT NULL,
    ncodlineaarticulo    DECIMAL(10, 0)    NOT NULL,
    cnombre              CHAR(10),
    ncantidad            DECIMAL(10, 0),
    cestatus             CHAR(10),
    PRIMARY KEY (ncodproveedor, ncodmaterial, ncodtipoarticulo, ncodarticulo, ncodlineaarticulo)
)ENGINE=MYISAM
;



-- 
-- TABLE: MaMONEDA 
--

CREATE TABLE MaMONEDA(
    ncodmoneda      DECIMAL(10, 0)    NOT NULL,
    ndescripcion    DECIMAL(10, 0),
    PRIMARY KEY (ncodmoneda)
)ENGINE=MYISAM
;



-- 
-- TABLE: MaMORA 
--

CREATE TABLE MaMORA(
    ncodmora       DECIMAL(10, 0)    NOT NULL,
    ncantidad      DECIMAL(10, 0),
    ncodcliente    DECIMAL(10, 0)    NOT NULL,
    ncodfactura    DECIMAL(10, 0)    NOT NULL,
    PRIMARY KEY (ncodmora)
)ENGINE=MYISAM
;



-- 
-- TABLE: MaORDEN 
--

CREATE TABLE MaORDEN(
    ncodcama                DECIMAL(10, 0)    NOT NULL,
    ncodordenes             DECIMAL(10, 0)    NOT NULL,
    ncodcolchon             DECIMAL(10, 0)    NOT NULL,
    ncodstatusorden         DECIMAL(10, 0)    NOT NULL,
    ncodprocesoorden        DECIMAL(10, 0)    NOT NULL,
    creferenciaproducto     CHAR(10),
    cinicioproducto         CHAR(10),
    centregaproducto        CHAR(10),
    cultimomovimiento       CHAR(10),
    nnodocumento            DECIMAL(10, 0),
    nnoproductoafabricar    DECIMAL(10, 0),
    nnoproductoterminado    DECIMAL(10, 0),
    nnoproductofaltante     CHAR(10),
    PRIMARY KEY (ncodcama, ncodordenes, ncodcolchon, ncodstatusorden, ncodprocesoorden)
)ENGINE=MYISAM
;



-- 
-- TABLE: MaORDENCOMPRA 
--

CREATE TABLE MaORDENCOMPRA(
    ncodproveedor         DECIMAL(10, 0)    NOT NULL,
    ncodordencompra       DECIMAL(10, 0)    NOT NULL,
    ncodtipoarticulo      DECIMAL(10, 0)    NOT NULL,
    ncodarticulo          DECIMAL(10, 0)    NOT NULL,
    ncodlineaarticulo     DECIMAL(10, 0)    NOT NULL,
    cdescripcioncompra    CHAR(10),
    ncantidad             DECIMAL(10, 0),
    ncostototal           DECIMAL(10, 0),
    PRIMARY KEY (ncodproveedor, ncodordencompra, ncodtipoarticulo, ncodarticulo, ncodlineaarticulo)
)ENGINE=MYISAM
;



-- 
-- TABLE: MaPLAZA 
--

CREATE TABLE MaPLAZA(
    ncodplaza       DECIMAL(10, 0)    NOT NULL,
    ncodempresa     DECIMAL(10, 0)    NOT NULL,
    ctipo           CHAR(10),
    cdescripcion    CHAR(10),
    csueldomin      CHAR(10),
    csueldomax      CHAR(10),
    chorario        CHAR(10),
    PRIMARY KEY (ncodplaza, ncodempresa)
)ENGINE=MYISAM
;



-- 
-- TABLE: MaPROVEEDOR 
--

CREATE TABLE MaPROVEEDOR(
    ncodproveedor        DECIMAL(10, 0)    NOT NULL,
    cnombre              CHAR(10),
    cdireccion           CHAR(10),
    ncodtipoarticulo     DECIMAL(10, 0)    NOT NULL,
    ncodarticulo         DECIMAL(10, 0)    NOT NULL,
    ncodlineaarticulo    DECIMAL(10, 0)    NOT NULL,
    PRIMARY KEY (ncodproveedor)
)ENGINE=MYISAM
;



-- 
-- TABLE: MaRECETACAMA 
--

CREATE TABLE MaRECETACAMA(
    ncodproveedor        DECIMAL(10, 0)    NOT NULL,
    ncodtipoarticulo     DECIMAL(10, 0)    NOT NULL,
    ncodarticulo         DECIMAL(10, 0)    NOT NULL,
    ncodlineaarticulo    DECIMAL(10, 0)    NOT NULL,
    ncodmaterial         DECIMAL(10, 0)    NOT NULL,
    ncodreceta           DECIMAL(10, 0),
    PRIMARY KEY (ncodproveedor, ncodtipoarticulo, ncodarticulo, ncodlineaarticulo, ncodmaterial)
)ENGINE=MYISAM
;



-- 
-- TABLE: MaRECIBOPAGO 
--

CREATE TABLE MaRECIBOPAGO(
    ncodrecibopago    DECIMAL(10, 0)    NOT NULL,
    cnombre           CHAR(10),
    cfechapago        CHAR(10),
    ncantidadpago     DECIMAL(10, 0),
    PRIMARY KEY (ncodrecibopago)
)ENGINE=MYISAM
;



-- 
-- TABLE: MaTIPOARTICULO 
--

CREATE TABLE MaTIPOARTICULO(
    ncodtipoarticulo    DECIMAL(10, 0)    NOT NULL,
    cnombre             CHAR(10),
    cdescripcion        CHAR(10),
    PRIMARY KEY (ncodtipoarticulo)
)ENGINE=MYISAM
;



-- 
-- TABLE: MaTIPOCAMA 
--

CREATE TABLE MaTIPOCAMA(
    ncodcama       DECIMAL(10, 0)    NOT NULL,
    cnombrecama    CHAR(10),
    PRIMARY KEY (ncodcama)
)ENGINE=MYISAM
;



-- 
-- TABLE: MaTIPOCOLCHON 
--

CREATE TABLE MaTIPOCOLCHON(
    ncodcama          DECIMAL(10, 0)    NOT NULL,
    ncodcolchon       DECIMAL(10, 0)    NOT NULL,
    cnombrecolchon    CHAR(10),
    PRIMARY KEY (ncodcama, ncodcolchon)
)ENGINE=MYISAM
;



-- 
-- TABLE: MaTIPODOCUMENTO 
--

CREATE TABLE MaTIPODOCUMENTO(
    ncoddocumento            DECIMAL(10, 0)    NOT NULL,
    cdescripciondocumento    CHAR(10),
    ctipodocumento           CHAR(10),
    PRIMARY KEY (ncoddocumento)
)ENGINE=MYISAM
;



-- 
-- TABLE: MaTIPOMOVIMIENTO 
--

CREATE TABLE MaTIPOMOVIMIENTO(
    ncodmoviemiento    DECIMAL(10, 0)    NOT NULL,
    cdescripcion       CHAR(10),
    ctipomovimiento    CHAR(10),
    PRIMARY KEY (ncodmoviemiento)
)ENGINE=MYISAM
;



-- 
-- TABLE: MaTIPOTRANSACCION 
--

CREATE TABLE MaTIPOTRANSACCION(
    ncodtipotransaccion    DECIMAL(10, 0)    NOT NULL,
    nnumdocumento          DECIMAL(10, 0),
    bincdec                CHAR(10),
    cnombredocumento       CHAR(10),
    PRIMARY KEY (ncodtipotransaccion)
)ENGINE=MYISAM
;



-- 
-- TABLE: MaUSOARTICULO 
--

CREATE TABLE MaUSOARTICULO(
    ncodproveedor        DECIMAL(10, 0)    NOT NULL,
    ncodtipoarticulo     DECIMAL(10, 0)    NOT NULL,
    ncodarticulo         DECIMAL(10, 0)    NOT NULL,
    ncodlineaarticulo    DECIMAL(10, 0)    NOT NULL,
    ncoddepartamento     DECIMAL(10, 0)    NOT NULL,
    PRIMARY KEY (ncodproveedor, ncodtipoarticulo, ncodarticulo, ncodlineaarticulo, ncoddepartamento)
)ENGINE=MYISAM
;



-- 
-- TABLE: MaVENTAS 
--

CREATE TABLE MaVENTAS(
    ncodventas      DECIMAL(10, 0)    NOT NULL,
    cfechaventa     CHAR(10),
    nprecioventa    DECIMAL(10, 0),
    PRIMARY KEY (ncodventas)
)ENGINE=MYISAM
;



-- 
-- TABLE: TrACTIVIDADLUDICA 
--

CREATE TABLE TrACTIVIDADLUDICA(
    ncodempleado        DECIMAL(10, 0)    NOT NULL,
    ncodactividad       DECIMAL(10, 0)    NOT NULL,
    ncodhistoria        DECIMAL(10, 0)    NOT NULL,
    ncoddepartamento    DECIMAL(10, 0)    NOT NULL,
    ctipo               CHAR(10),
    cnombre             CHAR(10),
    cdescripcion        CHAR(10),
    PRIMARY KEY (ncodempleado, ncodactividad, ncodhistoria, ncoddepartamento)
)ENGINE=MYISAM
;



-- 
-- TABLE: TrCOBRO 
--

CREATE TABLE TrCOBRO(
    ncodbanco          DECIMAL(10, 0)    NOT NULL,
    ncodcobro          DECIMAL(10, 0)    NOT NULL,
    ncodcuenta         DECIMAL(10, 0)    NOT NULL,
    ncodcliente        DECIMAL(10, 0)    NOT NULL,
    ncodfactura        DECIMAL(10, 0)    NOT NULL,
    ncodmora           DECIMAL(10, 0)    NOT NULL,
    ncodtransaccion    DECIMAL(10, 0)    NOT NULL,
    ncodmoneda         DECIMAL(10, 0)    NOT NULL,
    npago              DECIMAL(10, 0),
    nsaldo             DECIMAL(10, 0),
    cfecha             CHAR(10),
    PRIMARY KEY (ncodbanco, ncodcobro, ncodcuenta, ncodcliente, ncodfactura, ncodmora, ncodtransaccion, ncodmoneda)
)ENGINE=MYISAM
;



-- 
-- TABLE: TrCOMPRA 
--

CREATE TABLE TrCOMPRA(
    ncodproveedor        DECIMAL(10, 0)    NOT NULL,
    ncodtipoarticulo     DECIMAL(10, 0)    NOT NULL,
    ncodarticulo         DECIMAL(10, 0)    NOT NULL,
    ncodlineaarticulo    DECIMAL(10, 0)    NOT NULL,
    PRIMARY KEY (ncodproveedor, ncodtipoarticulo, ncodarticulo, ncodlineaarticulo)
)ENGINE=MYISAM
;



-- 
-- TABLE: TrCONTRATO 
--

CREATE TABLE TrCONTRATO(
    ncodcontrato        DECIMAL(10, 0)    NOT NULL,
    ncodempleado        DECIMAL(10, 0)    NOT NULL,
    ncodempresa         DECIMAL(10, 0)    NOT NULL,
    ncodfamilia         DECIMAL(10, 0)    NOT NULL,
    ncodsolicitud       DECIMAL(10, 0)    NOT NULL,
    ncodescolaridad     DECIMAL(10, 0)    NOT NULL,
    ncodhistoria        DECIMAL(10, 0)    NOT NULL,
    ncoddepartamento    DECIMAL(10, 0)    NOT NULL,
    ctipocontrato       CHAR(10),
    cfechainicio        CHAR(10),
    cfechafin           CHAR(10),
    nsalario            DECIMAL(10, 0),
    PRIMARY KEY (ncodcontrato, ncodempleado, ncodempresa, ncodfamilia, ncodsolicitud, ncodescolaridad, ncodhistoria, ncoddepartamento)
)ENGINE=MYISAM
;



-- 
-- TABLE: TrDEPARTAMENTO 
--

CREATE TABLE TrDEPARTAMENTO(
    ncoddepartamento       DECIMAL(10, 0)    NOT NULL,
    cnombredepartamento    CHAR(10),
    ctipo                  CHAR(10),
    PRIMARY KEY (ncoddepartamento)
)ENGINE=MYISAM
;



-- 
-- TABLE: TrESCOLARIDAD 
--

CREATE TABLE TrESCOLARIDAD(
    ncodescolaridad    DECIMAL(10, 0)    NOT NULL,
    ctipo              CHAR(10),
    cdescripcion       CHAR(10),
    PRIMARY KEY (ncodescolaridad)
)ENGINE=MYISAM
;



-- 
-- TABLE: TrEXISTENCIA 
--

CREATE TABLE TrEXISTENCIA(
    ncodproveedor        DECIMAL(10, 0)    NOT NULL,
    ncodtipoarticulo     DECIMAL(10, 0)    NOT NULL,
    ncodarticulo         DECIMAL(10, 0)    NOT NULL,
    ncodbodega           DECIMAL(10, 0)    NOT NULL,
    ncodlineaarticulo    DECIMAL(10, 0)    NOT NULL,
    nexistencia          DECIMAL(10, 0),
    PRIMARY KEY (ncodproveedor, ncodtipoarticulo, ncodarticulo, ncodbodega, ncodlineaarticulo)
)ENGINE=MYISAM
;



-- 
-- TABLE: TrFAMILIA 
--

CREATE TABLE TrFAMILIA(
    ncodfamilia     DECIMAL(10, 0)    NOT NULL,
    ctipo           CHAR(10),
    cdescripcion    CHAR(10),
    PRIMARY KEY (ncodfamilia)
)ENGINE=MYISAM
;



-- 
-- TABLE: TrHISTORIAEMP 
--

CREATE TABLE TrHISTORIAEMP(
    ncodhistoria     DECIMAL(10, 0)    NOT NULL,
    cdescripcion     CHAR(10),
    cfechainicio     CHAR(10),
    cfechafin        CHAR(10),
    cdepartamento    CHAR(10),
    PRIMARY KEY (ncodhistoria)
)ENGINE=MYISAM
;



-- 
-- TABLE: TrMOVIMIENTO 
--

CREATE TABLE TrMOVIMIENTO(
    ncodproveedor        DECIMAL(10, 0)    NOT NULL,
    ncodmovimiento       DECIMAL(10, 0)    NOT NULL,
    ncodtipoarticulo     DECIMAL(10, 0)    NOT NULL,
    ncodmoviemiento      DECIMAL(10, 0)    NOT NULL,
    ncodarticulo         DECIMAL(10, 0)    NOT NULL,
    ncodlineaarticulo    DECIMAL(10, 0)    NOT NULL,
    cjustificacion       CHAR(10),
    cencargado           CHAR(10),
    cfechamovimiento     CHAR(10),
    choramovimiento      CHAR(10),
    creferenciafisica    CHAR(10),
    PRIMARY KEY (ncodproveedor, ncodmovimiento, ncodtipoarticulo, ncodmoviemiento, ncodarticulo, ncodlineaarticulo)
)ENGINE=MYISAM
;



-- 
-- TABLE: TrPAGOPROVEEDOR 
--

CREATE TABLE TrPAGOPROVEEDOR(
    ncodproveedor        DECIMAL(10, 0)    NOT NULL,
    ncodpagoproveedor    DECIMAL(10, 0)    NOT NULL,
    ncodbanco            DECIMAL(10, 0)    NOT NULL,
    ncodcuenta           DECIMAL(10, 0)    NOT NULL,
    ncodtransaccion      DECIMAL(10, 0)    NOT NULL,
    ncodmoneda           DECIMAL(10, 0)    NOT NULL,
    PRIMARY KEY (ncodproveedor, ncodpagoproveedor, ncodbanco, ncodcuenta, ncodtransaccion, ncodmoneda)
)ENGINE=MYISAM
;



-- 
-- TABLE: TrPAGOS 
--

CREATE TABLE TrPAGOS(
    ncodrecibopago    DECIMAL(10, 0)    NOT NULL,
    ncodpago          DECIMAL(10, 0)    NOT NULL,
    ncodbanco         DECIMAL(10, 0)    NOT NULL,
    ncodcuenta        DECIMAL(10, 0)    NOT NULL,
    ncodmoneda        DECIMAL(10, 0)    NOT NULL,
    cfechapago        CHAR(10),
    cdescripcion      CHAR(10),
    PRIMARY KEY (ncodrecibopago, ncodpago, ncodbanco, ncodcuenta, ncodmoneda)
)ENGINE=MYISAM
;



-- 
-- TABLE: TrPAGOSALARIO 
--

CREATE TABLE TrPAGOSALARIO(
    ncodbanco           DECIMAL(10, 0)    NOT NULL,
    ncodcuenta          DECIMAL(10, 0)    NOT NULL,
    ncodtransaccion     DECIMAL(10, 0)    NOT NULL,
    ncodmoneda          DECIMAL(10, 0)    NOT NULL,
    ncodpagosalario     DECIMAL(10, 0)    NOT NULL,
    ncodcontrato        DECIMAL(10, 0)    NOT NULL,
    ncodempleado        DECIMAL(10, 0)    NOT NULL,
    ncodempresa         DECIMAL(10, 0)    NOT NULL,
    ncodfamilia         DECIMAL(10, 0)    NOT NULL,
    ncodsolicitud       DECIMAL(10, 0)    NOT NULL,
    ncodescolaridad     DECIMAL(10, 0)    NOT NULL,
    ncodhistoria        DECIMAL(10, 0)    NOT NULL,
    ncoddepartamento    DECIMAL(10, 0)    NOT NULL,
    PRIMARY KEY (ncodbanco, ncodcuenta, ncodtransaccion, ncodmoneda, ncodpagosalario, ncodcontrato, ncodempleado, ncodempresa, ncodfamilia, ncodsolicitud, ncodescolaridad, ncodhistoria, ncoddepartamento)
)ENGINE=MYISAM
;



-- 
-- TABLE: TrPEDIDO 
--

CREATE TABLE TrPEDIDO(
    ncodproveedor        DECIMAL(10, 0)    NOT NULL,
    ncodpedido           DECIMAL(10, 0)    NOT NULL,
    ncodtipoarticulo     DECIMAL(10, 0)    NOT NULL,
    ncodarticulo         DECIMAL(10, 0)    NOT NULL,
    ncodlineaarticulo    DECIMAL(10, 0)    NOT NULL,
    ncodventas           DECIMAL(10, 0)    NOT NULL,
    cdescripcion         CHAR(10),
    cfechaentrega        CHAR(10),
    PRIMARY KEY (ncodproveedor, ncodpedido, ncodtipoarticulo, ncodarticulo, ncodlineaarticulo, ncodventas)
)ENGINE=MYISAM
;



-- 
-- TABLE: TrPLANILLA 
--

CREATE TABLE TrPLANILLA(
    cprestaciones       CHAR(10),
    chorasnormales      CHAR(10),
    chorasextra         CHAR(10),
    ncodempleado        DECIMAL(10, 0)    NOT NULL,
    ncodhistoria        DECIMAL(10, 0)    NOT NULL,
    ncoddepartamento    DECIMAL(10, 0)    NOT NULL,
    ncodempresa         DECIMAL(10, 0)    NOT NULL
)ENGINE=MYISAM
;



-- 
-- TABLE: TrPROCESOORDEN 
--

CREATE TABLE TrPROCESOORDEN(
    ncodprocesoorden    DECIMAL(10, 0)    NOT NULL,
    cnombreproceso      CHAR(10),
    PRIMARY KEY (ncodprocesoorden)
)ENGINE=MYISAM
;



-- 
-- TABLE: TrSOLICITUD 
--

CREATE TABLE TrSOLICITUD(
    ncodfamilia           DECIMAL(10, 0)    NOT NULL,
    ncodsolicitud         DECIMAL(10, 0)    NOT NULL,
    ncodescolaridad       DECIMAL(10, 0)    NOT NULL,
    cfecha                CHAR(10),
    cnacionalidad         CHAR(10),
    cnopasaporte          CHAR(10),
    chabitospersonales    CHAR(10),
    cpuestosolicitado     CHAR(10),
    csueldosolicitado     CHAR(10),
    cfechanacimiento      CHAR(10),
    PRIMARY KEY (ncodfamilia, ncodsolicitud, ncodescolaridad)
)ENGINE=MYISAM
;



-- 
-- TABLE: TrSTATUSORDEN 
--

CREATE TABLE TrSTATUSORDEN(
    ncodstatusorden    DECIMAL(10, 0)    NOT NULL,
    cestatus           CHAR(10),
    PRIMARY KEY (ncodstatusorden)
)ENGINE=MYISAM
;



-- 
-- TABLE: TrTRANSACCION 
--

CREATE TABLE TrTRANSACCION(
    ncodbanco              DECIMAL(10, 0)    NOT NULL,
    ncodtransaccion        DECIMAL(10, 0)    NOT NULL,
    ncodcuenta             DECIMAL(10, 0)    NOT NULL,
    ncodmoneda             DECIMAL(10, 0)    NOT NULL,
    cfecha                 CHAR(10),
    nmonto                 DECIMAL(10, 0),
    ncodtipotransaccion    DECIMAL(10, 0)    NOT NULL,
    PRIMARY KEY (ncodbanco, ncodtransaccion, ncodcuenta, ncodmoneda)
)ENGINE=MYISAM
;



-- 
-- INDEX: Ref3846 
--

CREATE INDEX Ref3846 ON MaARTICULO(ncodtipoarticulo)
;
-- 
-- INDEX: Ref747 
--

CREATE INDEX Ref747 ON MaARTICULO(ncodproveedor)
;
-- 
-- INDEX: Ref4354 
--

CREATE INDEX Ref4354 ON MaARTICULO(ncodlineaarticulo)
;
-- 
-- INDEX: Ref2280 
--

CREATE INDEX Ref2280 ON MaCAPACITACION(ncodhistoria, ncodempleado, ncoddepartamento)
;
-- 
-- INDEX: Ref2277 
--

CREATE INDEX Ref2277 ON MaCOGNITIVO(ncodhistoria, ncodempleado, ncoddepartamento)
;
-- 
-- INDEX: Ref61106 
--

CREATE INDEX Ref61106 ON MaCUENTA(ncodmoneda)
;
-- 
-- INDEX: Ref4960 
--

CREATE INDEX Ref4960 ON MaCUENTA(ncodbanco)
;
-- 
-- INDEX: Ref174 
--

CREATE INDEX Ref174 ON MaDETALLEFACTURA(ncodarticulo, ncodproveedor, ncodtipoarticulo, ncodlineaarticulo)
;
-- 
-- INDEX: Ref1175 
--

CREATE INDEX Ref1175 ON MaDETALLEFACTURA(ncodcliente, ncodfactura)
;
-- 
-- INDEX: Ref5162 
--

CREATE INDEX Ref5162 ON MaDOCUMENTO(ncoddocumento)
;
-- 
-- INDEX: Ref2596 
--

CREATE INDEX Ref2596 ON MaEMPLEADO(ncodhistoria)
;
-- 
-- INDEX: Ref897 
--

CREATE INDEX Ref897 ON MaEMPLEADO(ncoddepartamento)
;
-- 
-- INDEX: Ref1276 
--

CREATE INDEX Ref1276 ON MaFACTURA(ncodcliente)
;
-- 
-- INDEX: Ref2278 
--

CREATE INDEX Ref2278 ON MaLOCACION(ncodhistoria, ncodempleado, ncoddepartamento)
;
-- 
-- INDEX: Ref170 
--

CREATE INDEX Ref170 ON Mamaterial(ncodlineaarticulo, ncodarticulo, ncodproveedor, ncodtipoarticulo)
;
-- 
-- INDEX: Ref11110 
--

CREATE INDEX Ref11110 ON MaMORA(ncodfactura, ncodcliente)
;
-- 
-- INDEX: Ref1371 
--

CREATE INDEX Ref1371 ON MaORDEN(ncodcama, ncodcolchon)
;
-- 
-- INDEX: Ref1572 
--

CREATE INDEX Ref1572 ON MaORDEN(ncodstatusorden)
;
-- 
-- INDEX: Ref1673 
--

CREATE INDEX Ref1673 ON MaORDEN(ncodprocesoorden)
;
-- 
-- INDEX: Ref1104 
--

CREATE INDEX Ref1104 ON MaORDENCOMPRA(ncodlineaarticulo, ncodarticulo, ncodproveedor, ncodtipoarticulo)
;
-- 
-- INDEX: Ref7108 
--

CREATE INDEX Ref7108 ON MaORDENCOMPRA(ncodproveedor)
;
-- 
-- INDEX: Ref3398 
--

CREATE INDEX Ref3398 ON MaPLAZA(ncodempresa)
;
-- 
-- INDEX: Ref566 
--

CREATE INDEX Ref566 ON MaPROVEEDOR(ncodproveedor, ncodtipoarticulo, ncodlineaarticulo, ncodarticulo)
;
-- 
-- INDEX: Ref56101 
--

CREATE INDEX Ref56101 ON MaRECETACAMA(ncodproveedor, ncodmaterial, ncodtipoarticulo, ncodlineaarticulo, ncodarticulo)
;
-- 
-- INDEX: Ref6699 
--

CREATE INDEX Ref6699 ON MaTIPOCOLCHON(ncodcama)
;
-- 
-- INDEX: Ref167 
--

CREATE INDEX Ref167 ON MaUSOARTICULO(ncodproveedor, ncodtipoarticulo, ncodlineaarticulo, ncodarticulo)
;
-- 
-- INDEX: Ref2468 
--

CREATE INDEX Ref2468 ON MaUSOARTICULO(ncoddepartamento)
;
-- 
-- INDEX: Ref2285 
--

CREATE INDEX Ref2285 ON TrACTIVIDADLUDICA(ncodhistoria, ncodempleado, ncoddepartamento)
;
-- 
-- INDEX: Ref1193 
--

CREATE INDEX Ref1193 ON TrCOBRO(ncodcliente, ncodfactura)
;
-- 
-- INDEX: Ref6594 
--

CREATE INDEX Ref6594 ON TrCOBRO(ncodmora)
;
-- 
-- INDEX: Ref59105 
--

CREATE INDEX Ref59105 ON TrCOBRO(ncodtransaccion, ncodmoneda, ncodbanco, ncodcuenta)
;
-- 
-- INDEX: Ref164 
--

CREATE INDEX Ref164 ON TrCOMPRA(ncodtipoarticulo, ncodlineaarticulo, ncodarticulo, ncodproveedor)
;
-- 
-- INDEX: Ref2279 
--

CREATE INDEX Ref2279 ON TrCONTRATO(ncodhistoria, ncodempleado, ncoddepartamento)
;
-- 
-- INDEX: Ref3383 
--

CREATE INDEX Ref3383 ON TrCONTRATO(ncodempresa)
;
-- 
-- INDEX: Ref3584 
--

CREATE INDEX Ref3584 ON TrCONTRATO(ncodfamilia, ncodescolaridad, ncodsolicitud)
;
-- 
-- INDEX: Ref155 
--

CREATE INDEX Ref155 ON TrEXISTENCIA(ncodproveedor, ncodtipoarticulo, ncodlineaarticulo, ncodarticulo)
;
-- 
-- INDEX: Ref356 
--

CREATE INDEX Ref356 ON TrEXISTENCIA(ncodbodega)
;
-- 
-- INDEX: Ref148 
--

CREATE INDEX Ref148 ON TrMOVIMIENTO(ncodtipoarticulo, ncodlineaarticulo, ncodarticulo, ncodproveedor)
;
-- 
-- INDEX: Ref4049 
--

CREATE INDEX Ref4049 ON TrMOVIMIENTO(ncodmoviemiento)
;
-- 
-- INDEX: Ref5991 
--

CREATE INDEX Ref5991 ON TrPAGOPROVEEDOR(ncodtransaccion, ncodmoneda, ncodbanco, ncodcuenta)
;
-- 
-- INDEX: Ref7109 
--

CREATE INDEX Ref7109 ON TrPAGOPROVEEDOR(ncodproveedor)
;
-- 
-- INDEX: Ref4658 
--

CREATE INDEX Ref4658 ON TrPAGOS(ncodrecibopago)
;
-- 
-- INDEX: Ref4859 
--

CREATE INDEX Ref4859 ON TrPAGOS(ncodmoneda, ncodbanco, ncodcuenta)
;
-- 
-- INDEX: Ref2986 
--

CREATE INDEX Ref2986 ON TrPAGOSALARIO(ncodcontrato, ncodfamilia, ncodescolaridad, ncodhistoria, ncodempleado, ncodsolicitud, ncoddepartamento, ncodempresa)
;
-- 
-- INDEX: Ref5987 
--

CREATE INDEX Ref5987 ON TrPAGOSALARIO(ncodmoneda, ncodbanco, ncodcuenta, ncodtransaccion)
;
-- 
-- INDEX: Ref151 
--

CREATE INDEX Ref151 ON TrPEDIDO(ncodarticulo, ncodproveedor, ncodtipoarticulo, ncodlineaarticulo)
;
-- 
-- INDEX: Ref4253 
--

CREATE INDEX Ref4253 ON TrPEDIDO(ncodventas)
;
-- 
-- INDEX: Ref22112 
--

CREATE INDEX Ref22112 ON TrPLANILLA(ncodhistoria, ncodempleado, ncoddepartamento)
;
-- 
-- INDEX: Ref33113 
--

CREATE INDEX Ref33113 ON TrPLANILLA(ncodempresa)
;
-- 
-- INDEX: Ref3681 
--

CREATE INDEX Ref3681 ON TrSOLICITUD(ncodescolaridad)
;
-- 
-- INDEX: Ref3182 
--

CREATE INDEX Ref3182 ON TrSOLICITUD(ncodfamilia)
;
-- 
-- INDEX: Ref48107 
--

CREATE INDEX Ref48107 ON TrTRANSACCION(ncodmoneda, ncodbanco, ncodcuenta)
;
-- 
-- INDEX: Ref69111 
--

CREATE INDEX Ref69111 ON TrTRANSACCION(ncodtipotransaccion)
;
-- 
-- TABLE: MaARTICULO 
--

ALTER TABLE MaARTICULO ADD CONSTRAINT RefMaTIPOARTICULO46 
    FOREIGN KEY (ncodtipoarticulo)
    REFERENCES MaTIPOARTICULO(ncodtipoarticulo)
;

ALTER TABLE MaARTICULO ADD CONSTRAINT RefMaPROVEEDOR47 
    FOREIGN KEY (ncodproveedor)
    REFERENCES MaPROVEEDOR(ncodproveedor)
;

ALTER TABLE MaARTICULO ADD CONSTRAINT RefMaLINEAARTICULO54 
    FOREIGN KEY (ncodlineaarticulo)
    REFERENCES MaLINEAARTICULO(ncodlineaarticulo)
;


-- 
-- TABLE: MaCAPACITACION 
--

ALTER TABLE MaCAPACITACION ADD CONSTRAINT RefMaEMPLEADO80 
    FOREIGN KEY (ncodempleado, ncodhistoria, ncoddepartamento)
    REFERENCES MaEMPLEADO(ncodempleado, ncodhistoria, ncoddepartamento)
;


-- 
-- TABLE: MaCOGNITIVO 
--

ALTER TABLE MaCOGNITIVO ADD CONSTRAINT RefMaEMPLEADO77 
    FOREIGN KEY (ncodempleado, ncodhistoria, ncoddepartamento)
    REFERENCES MaEMPLEADO(ncodempleado, ncodhistoria, ncoddepartamento)
;


-- 
-- TABLE: MaCUENTA 
--

ALTER TABLE MaCUENTA ADD CONSTRAINT RefMaMONEDA106 
    FOREIGN KEY (ncodmoneda)
    REFERENCES MaMONEDA(ncodmoneda)
;

ALTER TABLE MaCUENTA ADD CONSTRAINT RefMaBANCO60 
    FOREIGN KEY (ncodbanco)
    REFERENCES MaBANCO(ncodbanco)
;


-- 
-- TABLE: MaDETALLEFACTURA 
--

ALTER TABLE MaDETALLEFACTURA ADD CONSTRAINT RefMaARTICULO74 
    FOREIGN KEY (ncodproveedor, ncodtipoarticulo, ncodarticulo, ncodlineaarticulo)
    REFERENCES MaARTICULO(ncodproveedor, ncodarticulo, ncodtipoarticulo, ncodlineaarticulo)
;

ALTER TABLE MaDETALLEFACTURA ADD CONSTRAINT RefMaFACTURA75 
    FOREIGN KEY (ncodcliente, ncodfactura)
    REFERENCES MaFACTURA(ncodcliente, ncodfactura)
;


-- 
-- TABLE: MaDOCUMENTO 
--

ALTER TABLE MaDOCUMENTO ADD CONSTRAINT RefMaTIPODOCUMENTO62 
    FOREIGN KEY (ncoddocumento)
    REFERENCES MaTIPODOCUMENTO(ncoddocumento)
;


-- 
-- TABLE: MaEMPLEADO 
--

ALTER TABLE MaEMPLEADO ADD CONSTRAINT RefTrHISTORIAEMP96 
    FOREIGN KEY (ncodhistoria)
    REFERENCES TrHISTORIAEMP(ncodhistoria)
;

ALTER TABLE MaEMPLEADO ADD CONSTRAINT RefTrDEPARTAMENTO97 
    FOREIGN KEY (ncoddepartamento)
    REFERENCES TrDEPARTAMENTO(ncoddepartamento)
;


-- 
-- TABLE: MaFACTURA 
--

ALTER TABLE MaFACTURA ADD CONSTRAINT RefMaCLIENTE76 
    FOREIGN KEY (ncodcliente)
    REFERENCES MaCLIENTE(ncodcliente)
;


-- 
-- TABLE: MaLOCACION 
--

ALTER TABLE MaLOCACION ADD CONSTRAINT RefMaEMPLEADO78 
    FOREIGN KEY (ncodempleado, ncodhistoria, ncoddepartamento)
    REFERENCES MaEMPLEADO(ncodempleado, ncodhistoria, ncoddepartamento)
;


-- 
-- TABLE: Mamaterial 
--

ALTER TABLE Mamaterial ADD CONSTRAINT RefMaARTICULO70 
    FOREIGN KEY (ncodproveedor, ncodtipoarticulo, ncodarticulo, ncodlineaarticulo)
    REFERENCES MaARTICULO(ncodproveedor, ncodarticulo, ncodtipoarticulo, ncodlineaarticulo)
;


-- 
-- TABLE: MaMORA 
--

ALTER TABLE MaMORA ADD CONSTRAINT RefMaFACTURA110 
    FOREIGN KEY (ncodcliente, ncodfactura)
    REFERENCES MaFACTURA(ncodcliente, ncodfactura)
;


-- 
-- TABLE: MaORDEN 
--

ALTER TABLE MaORDEN ADD CONSTRAINT RefMaTIPOCOLCHON71 
    FOREIGN KEY (ncodcama, ncodcolchon)
    REFERENCES MaTIPOCOLCHON(ncodcama, ncodcolchon)
;

ALTER TABLE MaORDEN ADD CONSTRAINT RefTrSTATUSORDEN72 
    FOREIGN KEY (ncodstatusorden)
    REFERENCES TrSTATUSORDEN(ncodstatusorden)
;

ALTER TABLE MaORDEN ADD CONSTRAINT RefTrPROCESOORDEN73 
    FOREIGN KEY (ncodprocesoorden)
    REFERENCES TrPROCESOORDEN(ncodprocesoorden)
;


-- 
-- TABLE: MaORDENCOMPRA 
--

ALTER TABLE MaORDENCOMPRA ADD CONSTRAINT RefMaARTICULO104 
    FOREIGN KEY (ncodproveedor, ncodtipoarticulo, ncodarticulo, ncodlineaarticulo)
    REFERENCES MaARTICULO(ncodproveedor, ncodarticulo, ncodtipoarticulo, ncodlineaarticulo)
;

ALTER TABLE MaORDENCOMPRA ADD CONSTRAINT RefMaPROVEEDOR108 
    FOREIGN KEY (ncodproveedor)
    REFERENCES MaPROVEEDOR(ncodproveedor)
;


-- 
-- TABLE: MaPLAZA 
--

ALTER TABLE MaPLAZA ADD CONSTRAINT RefMaEMPRESA98 
    FOREIGN KEY (ncodempresa)
    REFERENCES MaEMPRESA(ncodempresa)
;


-- 
-- TABLE: MaPROVEEDOR 
--

ALTER TABLE MaPROVEEDOR ADD CONSTRAINT RefTrCOMPRA66 
    FOREIGN KEY (ncodproveedor, ncodtipoarticulo, ncodarticulo, ncodlineaarticulo)
    REFERENCES TrCOMPRA(ncodproveedor, ncodtipoarticulo, ncodarticulo, ncodlineaarticulo)
;


-- 
-- TABLE: MaRECETACAMA 
--

ALTER TABLE MaRECETACAMA ADD CONSTRAINT RefMaRECETACAMA100 
    FOREIGN KEY (ncodproveedor, ncodtipoarticulo, ncodarticulo, ncodlineaarticulo, ncodmaterial)
    REFERENCES MaRECETACAMA(ncodproveedor, ncodtipoarticulo, ncodarticulo, ncodlineaarticulo, ncodmaterial)
;

ALTER TABLE MaRECETACAMA ADD CONSTRAINT RefMamaterial101 
    FOREIGN KEY (ncodproveedor, ncodtipoarticulo, ncodarticulo, ncodlineaarticulo, ncodmaterial)
    REFERENCES Mamaterial(ncodproveedor, ncodmaterial, ncodtipoarticulo, ncodarticulo, ncodlineaarticulo)
;


-- 
-- TABLE: MaTIPOCOLCHON 
--

ALTER TABLE MaTIPOCOLCHON ADD CONSTRAINT RefMaTIPOCAMA99 
    FOREIGN KEY (ncodcama)
    REFERENCES MaTIPOCAMA(ncodcama)
;


-- 
-- TABLE: MaUSOARTICULO 
--

ALTER TABLE MaUSOARTICULO ADD CONSTRAINT RefMaARTICULO67 
    FOREIGN KEY (ncodproveedor, ncodtipoarticulo, ncodarticulo, ncodlineaarticulo)
    REFERENCES MaARTICULO(ncodproveedor, ncodarticulo, ncodtipoarticulo, ncodlineaarticulo)
;

ALTER TABLE MaUSOARTICULO ADD CONSTRAINT RefMaDEPARTAMENTO68 
    FOREIGN KEY (ncoddepartamento)
    REFERENCES MaDEPARTAMENTO(ncoddepartamento)
;


-- 
-- TABLE: TrACTIVIDADLUDICA 
--

ALTER TABLE TrACTIVIDADLUDICA ADD CONSTRAINT RefMaEMPLEADO85 
    FOREIGN KEY (ncodempleado, ncodhistoria, ncoddepartamento)
    REFERENCES MaEMPLEADO(ncodempleado, ncodhistoria, ncoddepartamento)
;


-- 
-- TABLE: TrCOBRO 
--

ALTER TABLE TrCOBRO ADD CONSTRAINT RefMaFACTURA93 
    FOREIGN KEY (ncodcliente, ncodfactura)
    REFERENCES MaFACTURA(ncodcliente, ncodfactura)
;

ALTER TABLE TrCOBRO ADD CONSTRAINT RefMaMORA94 
    FOREIGN KEY (ncodmora)
    REFERENCES MaMORA(ncodmora)
;

ALTER TABLE TrCOBRO ADD CONSTRAINT RefTrTRANSACCION105 
    FOREIGN KEY (ncodbanco, ncodcuenta, ncodtransaccion, ncodmoneda)
    REFERENCES TrTRANSACCION(ncodbanco, ncodtransaccion, ncodcuenta, ncodmoneda)
;


-- 
-- TABLE: TrCOMPRA 
--

ALTER TABLE TrCOMPRA ADD CONSTRAINT RefMaARTICULO64 
    FOREIGN KEY (ncodproveedor, ncodtipoarticulo, ncodarticulo, ncodlineaarticulo)
    REFERENCES MaARTICULO(ncodproveedor, ncodarticulo, ncodtipoarticulo, ncodlineaarticulo)
;


-- 
-- TABLE: TrCONTRATO 
--

ALTER TABLE TrCONTRATO ADD CONSTRAINT RefMaEMPLEADO79 
    FOREIGN KEY (ncodempleado, ncodhistoria, ncoddepartamento)
    REFERENCES MaEMPLEADO(ncodempleado, ncodhistoria, ncoddepartamento)
;

ALTER TABLE TrCONTRATO ADD CONSTRAINT RefMaEMPRESA83 
    FOREIGN KEY (ncodempresa)
    REFERENCES MaEMPRESA(ncodempresa)
;

ALTER TABLE TrCONTRATO ADD CONSTRAINT RefTrSOLICITUD84 
    FOREIGN KEY (ncodfamilia, ncodsolicitud, ncodescolaridad)
    REFERENCES TrSOLICITUD(ncodfamilia, ncodsolicitud, ncodescolaridad)
;


-- 
-- TABLE: TrEXISTENCIA 
--

ALTER TABLE TrEXISTENCIA ADD CONSTRAINT RefMaARTICULO55 
    FOREIGN KEY (ncodproveedor, ncodtipoarticulo, ncodarticulo, ncodlineaarticulo)
    REFERENCES MaARTICULO(ncodproveedor, ncodarticulo, ncodtipoarticulo, ncodlineaarticulo)
;

ALTER TABLE TrEXISTENCIA ADD CONSTRAINT RefMaBODEGA56 
    FOREIGN KEY (ncodbodega)
    REFERENCES MaBODEGA(ncodbodega)
;


-- 
-- TABLE: TrMOVIMIENTO 
--

ALTER TABLE TrMOVIMIENTO ADD CONSTRAINT RefMaARTICULO48 
    FOREIGN KEY (ncodproveedor, ncodtipoarticulo, ncodarticulo, ncodlineaarticulo)
    REFERENCES MaARTICULO(ncodproveedor, ncodarticulo, ncodtipoarticulo, ncodlineaarticulo)
;

ALTER TABLE TrMOVIMIENTO ADD CONSTRAINT RefMaTIPOMOVIMIENTO49 
    FOREIGN KEY (ncodmoviemiento)
    REFERENCES MaTIPOMOVIMIENTO(ncodmoviemiento)
;


-- 
-- TABLE: TrPAGOPROVEEDOR 
--

ALTER TABLE TrPAGOPROVEEDOR ADD CONSTRAINT RefTrTRANSACCION91 
    FOREIGN KEY (ncodbanco, ncodcuenta, ncodtransaccion, ncodmoneda)
    REFERENCES TrTRANSACCION(ncodbanco, ncodtransaccion, ncodcuenta, ncodmoneda)
;

ALTER TABLE TrPAGOPROVEEDOR ADD CONSTRAINT RefMaPROVEEDOR109 
    FOREIGN KEY (ncodproveedor)
    REFERENCES MaPROVEEDOR(ncodproveedor)
;


-- 
-- TABLE: TrPAGOS 
--

ALTER TABLE TrPAGOS ADD CONSTRAINT RefMaRECIBOPAGO58 
    FOREIGN KEY (ncodrecibopago)
    REFERENCES MaRECIBOPAGO(ncodrecibopago)
;

ALTER TABLE TrPAGOS ADD CONSTRAINT RefMaCUENTA59 
    FOREIGN KEY (ncodbanco, ncodcuenta, ncodmoneda)
    REFERENCES MaCUENTA(ncodbanco, ncodcuenta, ncodmoneda)
;


-- 
-- TABLE: TrPAGOSALARIO 
--

ALTER TABLE TrPAGOSALARIO ADD CONSTRAINT RefTrCONTRATO86 
    FOREIGN KEY (ncodcontrato, ncodempleado, ncodempresa, ncodfamilia, ncodsolicitud, ncodescolaridad, ncodhistoria, ncoddepartamento)
    REFERENCES TrCONTRATO(ncodcontrato, ncodempleado, ncodempresa, ncodfamilia, ncodsolicitud, ncodescolaridad, ncodhistoria, ncoddepartamento)
;

ALTER TABLE TrPAGOSALARIO ADD CONSTRAINT RefTrTRANSACCION87 
    FOREIGN KEY (ncodbanco, ncodcuenta, ncodtransaccion, ncodmoneda)
    REFERENCES TrTRANSACCION(ncodbanco, ncodtransaccion, ncodcuenta, ncodmoneda)
;


-- 
-- TABLE: TrPEDIDO 
--

ALTER TABLE TrPEDIDO ADD CONSTRAINT RefMaARTICULO51 
    FOREIGN KEY (ncodproveedor, ncodtipoarticulo, ncodarticulo, ncodlineaarticulo)
    REFERENCES MaARTICULO(ncodproveedor, ncodarticulo, ncodtipoarticulo, ncodlineaarticulo)
;

ALTER TABLE TrPEDIDO ADD CONSTRAINT RefMaVENTAS53 
    FOREIGN KEY (ncodventas)
    REFERENCES MaVENTAS(ncodventas)
;


-- 
-- TABLE: TrPLANILLA 
--

ALTER TABLE TrPLANILLA ADD CONSTRAINT RefMaEMPLEADO112 
    FOREIGN KEY (ncodempleado, ncodhistoria, ncoddepartamento)
    REFERENCES MaEMPLEADO(ncodempleado, ncodhistoria, ncoddepartamento)
;

ALTER TABLE TrPLANILLA ADD CONSTRAINT RefMaEMPRESA113 
    FOREIGN KEY (ncodempresa)
    REFERENCES MaEMPRESA(ncodempresa)
;


-- 
-- TABLE: TrSOLICITUD 
--

ALTER TABLE TrSOLICITUD ADD CONSTRAINT RefTrESCOLARIDAD81 
    FOREIGN KEY (ncodescolaridad)
    REFERENCES TrESCOLARIDAD(ncodescolaridad)
;

ALTER TABLE TrSOLICITUD ADD CONSTRAINT RefTrFAMILIA82 
    FOREIGN KEY (ncodfamilia)
    REFERENCES TrFAMILIA(ncodfamilia)
;


-- 
-- TABLE: TrTRANSACCION 
--

ALTER TABLE TrTRANSACCION ADD CONSTRAINT RefMaCUENTA107 
    FOREIGN KEY (ncodbanco, ncodcuenta, ncodmoneda)
    REFERENCES MaCUENTA(ncodbanco, ncodcuenta, ncodmoneda)
;

ALTER TABLE TrTRANSACCION ADD CONSTRAINT RefMaTIPOTRANSACCION111 
    FOREIGN KEY (ncodtipotransaccion)
    REFERENCES MaTIPOTRANSACCION(ncodtipotransaccion)
;


