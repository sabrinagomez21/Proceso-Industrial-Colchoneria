--
-- ER/Studio Data Architect 11.0 SQL Code Generation
-- Project :      ER (7 DE 8 modulos incluidos).dm1
--
-- Date Created : Thursday, October 22, 2015 18:38:13
-- Target DBMS : MySQL 3.x
--

-- 
-- TABLE: MaARTICULO 
--

CREATE TABLE MaARTICULO(
    ncodarticulo         DECIMAL(10, 0)    NOT NULL,
    ncantidad            DECIMAL(10, 0),
    nprecio              DECIMAL(10, 0),
    cmarca               CHAR(10),
    cestado              CHAR(10),
    cnombre              CHAR(10),
    cdescripcion         CHAR(10),
    cfotoarticulo        CHAR(10),
    cfechaingreso        CHAR(10),
    ncodlineaarticulo    DECIMAL(10, 0)    NOT NULL,
    ncodtipoarticulo     DECIMAL(10, 0)    NOT NULL,
    ncodproveedor        DECIMAL(10, 0)    NOT NULL,
    PRIMARY KEY (ncodarticulo)
)TYPE=MYISAM
;



-- 
-- TABLE: MaBANCO 
--

CREATE TABLE MaBANCO(
    ncodbanco       DECIMAL(10, 0)    NOT NULL,
    cnombrebanco    CHAR(10),
    cdireccion      CHAR(10),
    PRIMARY KEY (ncodbanco)
)TYPE=MYISAM
;



-- 
-- TABLE: MaBODEGA 
--

CREATE TABLE MaBODEGA(
    ncodbodega          DECIMAL(10, 0)    NOT NULL,
    cnombrebodega       CHAR(10),
    cdireccionbodega    CHAR(10),
    PRIMARY KEY (ncodbodega)
)TYPE=MYISAM
;



-- 
-- TABLE: MaCAPACITACION 
--

CREATE TABLE MaCAPACITACION(
    ncodcapacitacion       DECIMAL(10, 0)    NOT NULL,
    vnecesidad             VARCHAR(20),
    vobjetivo              VARCHAR(20),
    resultadosesperados    VARCHAR(30),
    vresponsable           VARCHAR(30),
    vdetalle               VARCHAR(60),
    iparticipantes         INT,
    vtiempo                VARCHAR(10),
    cnombrecapacitacion    CHAR(10),
    ctipo                  CHAR(10),
    ncodempleado           DECIMAL(10, 0)    NOT NULL,
    PRIMARY KEY (ncodcapacitacion)
)TYPE=MYISAM
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
)TYPE=MYISAM
;



-- 
-- TABLE: MaCOGNITIVO 
--

CREATE TABLE MaCOGNITIVO(
    ctipo           CHAR(10),
    cdescripcion    CHAR(10),
    cestado         CHAR(10),
    ncodempleado    DECIMAL(10, 0)    NOT NULL
)TYPE=MYISAM
;



-- 
-- TABLE: MaCOTIZACION 
--

CREATE TABLE MaCOTIZACION(
    ncodcotizacion       DECIMAL(10, 0)    NOT NULL,
    vserie               VARCHAR(10),
    vnombre              VARCHAR(10),
    vdireccion           VARCHAR(25),
    vfechacotizacion     DATE,
    dfechavencimiento    DATE,
    ntotal               DECIMAL(10, 0),
    vestadocotizacion    VARCHAR(10),
    ncodcliente          DECIMAL(10, 0)    NOT NULL,
    vnombrevendedor      VARCHAR(25),
    PRIMARY KEY (ncodcotizacion)
)TYPE=MYISAM
;



-- 
-- TABLE: MaCUENTA 
--

CREATE TABLE MaCUENTA(
    ncodcuenta       DECIMAL(10, 0)    NOT NULL,
    nmontocuenta     DECIMAL(10, 0),
    cfecha           CHAR(10),
    ncodbanco        DECIMAL(10, 0)    NOT NULL,
    ncoddocumento    DECIMAL(10, 0)    NOT NULL,
    PRIMARY KEY (ncodcuenta)
)TYPE=MYISAM
;



-- 
-- TABLE: MaDEPARTAMENTO 
--

CREATE TABLE MaDEPARTAMENTO(
    ncoddepartamento    DECIMAL(10, 0)    NOT NULL,
    cresponsable        CHAR(10),
    cextension          CHAR(10),
    PRIMARY KEY (ncoddepartamento)
)TYPE=MYISAM
;



-- 
-- TABLE: MaDETALLECOTIZACION 
--

CREATE TABLE MaDETALLECOTIZACION(
    ncodcotizacion       DECIMAL(10, 0)    NOT NULL,
    ncodproducto         DECIMAL(10, 0),
    ncantidadcotizada    DECIMAL(10, 0),
    npreciocotizado      DECIMAL(10, 0),
    ncodarticulo         DECIMAL(10, 0)    NOT NULL
)TYPE=MYISAM
;



-- 
-- TABLE: MaDETALLEFACTURA 
--

CREATE TABLE MaDETALLEFACTURA(
    ncodarticulo      DECIMAL(10, 0)    NOT NULL,
    ncantidadventa    DECIMAL(10, 0)    NOT NULL,
    nprecioventa      DECIMAL(10, 0),
    ncodfactura       DECIMAL(10, 0)    NOT NULL
)TYPE=MYISAM
;



-- 
-- TABLE: MaDETALLEPEDIDO 
--

CREATE TABLE MaDETALLEPEDIDO(
    ncodpedido         DECIMAL(10, 0)    NOT NULL,
    ncodproducto       DECIMAL(10, 0),
    ncantidadpedido    DECIMAL(10, 0),
    npreciopedido      DECIMAL(10, 0),
    ncodarticulo       DECIMAL(10, 0)    NOT NULL
)TYPE=MYISAM
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
    ncodproveedor        DECIMAL(10, 0)    NOT NULL
)TYPE=MYISAM
;



-- 
-- TABLE: MaEMPLEADO 
--

CREATE TABLE MaEMPLEADO(
    ncodempleado         DECIMAL(10, 0)    NOT NULL,
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
    ncodhistoria         DECIMAL(10, 0)    NOT NULL,
    ncoddepartamento     DECIMAL(10, 0)    NOT NULL,
    PRIMARY KEY (ncodempleado)
)TYPE=MYISAM
;



-- 
-- TABLE: MaEMPRESA 
--

CREATE TABLE MaEMPRESA(
    ncodempresa       DECIMAL(10, 0)    NOT NULL,
    vpuestovacante    VARCHAR(20),
    nomempresa        VARCHAR(20),
    vdescripcion      VARCHAR(20),
    ctipoempresa      CHAR(10),
    cnombreempresa    CHAR(10),
    cdireccion        CHAR(10),
    ntelefono         DECIMAL(10, 0),
    cdescripcion      CHAR(10),
    PRIMARY KEY (ncodempresa)
)TYPE=MYISAM
;



-- 
-- TABLE: MaFACTURA 
--

CREATE TABLE MaFACTURA(
    ncodfactura          DECIMAL(10, 0)    NOT NULL,
    cserie               CHAR(10),
    cnombrefactura       CHAR(10),
    cnit                 CHAR(10),
    cdireccion           CHAR(10),
    cestado              CHAR(10),
    cfechavencimiento    CHAR(10),
    ntotal               DECIMAL(10, 0),
    cfecha               CHAR(10),
    ncodcliente          DECIMAL(10, 0)    NOT NULL,
    PRIMARY KEY (ncodfactura)
)TYPE=MYISAM
;



-- 
-- TABLE: MaLINEAARTICULO 
--

CREATE TABLE MaLINEAARTICULO(
    ncodlineaarticulo    DECIMAL(10, 0)    NOT NULL,
    cnombre              CHAR(10),
    cdescripcion         CHAR(10),
    PRIMARY KEY (ncodlineaarticulo)
)TYPE=MYISAM
;



-- 
-- TABLE: MaLOCACION 
--

CREATE TABLE MaLOCACION(
    ncodlocacion    DECIMAL(10, 0)    NOT NULL,
    cdireccion      CHAR(10),
    ncodpostal      CHAR(10),
    cciudad         CHAR(10),
    cprovincia      CHAR(10),
    ncodempleado    DECIMAL(10, 0)    NOT NULL,
    PRIMARY KEY (ncodlocacion)
)TYPE=MYISAM
;



-- 
-- TABLE: Mamaterial 
--

CREATE TABLE Mamaterial(
    ncodmaterial    DECIMAL(10, 0)    NOT NULL,
    cnombre         CHAR(10),
    ncantidad       DECIMAL(10, 0),
    cestatus        CHAR(10),
    ncodarticulo    DECIMAL(10, 0)    NOT NULL,
    PRIMARY KEY (ncodmaterial)
)TYPE=MYISAM
;



-- 
-- TABLE: MaMONEDA 
--

CREATE TABLE MaMONEDA(
    ncodmoneda      DECIMAL(10, 0)    NOT NULL,
    ndescripcion    DECIMAL(10, 0),
    ncodbanco       DECIMAL(10, 0)    NOT NULL,
    PRIMARY KEY (ncodmoneda)
)TYPE=MYISAM
;



-- 
-- TABLE: MaMORA 
--

CREATE TABLE MaMORA(
    ncodmora       DECIMAL(10, 0)    NOT NULL,
    ncantidad      DECIMAL(10, 0),
    ncodfactura    DECIMAL(10, 0)    NOT NULL,
    PRIMARY KEY (ncodmora)
)TYPE=MYISAM
;



-- 
-- TABLE: MaORDEN 
--

CREATE TABLE MaORDEN(
    ncodordenes             DECIMAL(10, 0)    NOT NULL,
    creferenciaproducto     CHAR(10),
    cinicioproducto         CHAR(10),
    centregaproducto        CHAR(10),
    cultimomovimiento       CHAR(10),
    nnodocumento            DECIMAL(10, 0),
    nnoproductoafabricar    DECIMAL(10, 0),
    nnoproductoterminado    DECIMAL(10, 0),
    nnoproductofaltante     CHAR(10),
    ncodcolchon             DECIMAL(10, 0)    NOT NULL,
    ncodstatusorden         DECIMAL(10, 0)    NOT NULL,
    ncodprocesoorden        DECIMAL(10, 0)    NOT NULL,
    ncodcama                DECIMAL(10, 0)    NOT NULL,
    PRIMARY KEY (ncodordenes)
)TYPE=MYISAM
;



-- 
-- TABLE: MaORDENCOMPRA 
--

CREATE TABLE MaORDENCOMPRA(
    ncodordencompra       DECIMAL(10, 0)    NOT NULL,
    ncodproveedor         DECIMAL(10, 0)    NOT NULL,
    cdescripcioncompra    CHAR(10),
    ncantidad             DECIMAL(10, 0),
    ncostototal           DECIMAL(10, 0),
    ncodarticulo          DECIMAL(10, 0)    NOT NULL,
    PRIMARY KEY (ncodordencompra)
)TYPE=MYISAM
;



-- 
-- TABLE: MaPLAZA 
--

CREATE TABLE MaPLAZA(
    ncodplaza                 DECIMAL(10, 0)    NOT NULL,
    vdepartamento             VARCHAR(30),
    vcausasolicitud           VARCHAR(10),
    vtipoempleado             VARCHAR(20),
    vcapacidadesrequeridas    VARCHAR(30),
    vhorario                  VARCHAR(20),
    ctipo                     CHAR(10),
    cdescripcion              CHAR(10),
    csueldomin                CHAR(10),
    csueldomax                CHAR(10),
    chorario                  CHAR(10),
    ncodempresa               DECIMAL(10, 0)    NOT NULL,
    PRIMARY KEY (ncodplaza)
)TYPE=MYISAM
;



-- 
-- TABLE: MaPROVEEDOR 
--

CREATE TABLE MaPROVEEDOR(
    ncodproveedor    DECIMAL(10, 0)    NOT NULL,
    cnombre          CHAR(10),
    cdireccion       CHAR(10),
    PRIMARY KEY (ncodproveedor)
)TYPE=MYISAM
;



-- 
-- TABLE: MaRecetaCama 
--

CREATE TABLE MaRecetaCama(
    nrecetacama          DECIMAL(10, 0)    NOT NULL,
    ncantidadmaterial    DECIMAL(10, 0),
    ncodcama             DECIMAL(10, 0)    NOT NULL,
    ncodmaterial         DECIMAL(10, 0)    NOT NULL,
    PRIMARY KEY (nrecetacama)
)TYPE=MYISAM
;



-- 
-- TABLE: MaRecetaColchon 
--

CREATE TABLE MaRecetaColchon(
    nrecetacolchon       CHAR(10)          NOT NULL,
    ncantidadmaterial    CHAR(10),
    ncodcolchon          DECIMAL(10, 0)    NOT NULL,
    ncodmaterial         DECIMAL(10, 0)    NOT NULL,
    PRIMARY KEY (nrecetacolchon)
)TYPE=MYISAM
;



-- 
-- TABLE: MaRECIBOPAGO 
--

CREATE TABLE MaRECIBOPAGO(
    ncodrecibopago    DECIMAL(10, 0)    NOT NULL,
    cnombre           CHAR(10),
    cfechapago        CHAR(10),
    ncantidadpago     DECIMAL(10, 0),
    ncodproveedor     DECIMAL(10, 0)    NOT NULL,
    PRIMARY KEY (ncodrecibopago)
)TYPE=MYISAM
;



-- 
-- TABLE: MaTIPOARTICULO 
--

CREATE TABLE MaTIPOARTICULO(
    ncodtipoarticulo    DECIMAL(10, 0)    NOT NULL,
    cnombre             CHAR(10),
    cdescripcion        CHAR(10),
    PRIMARY KEY (ncodtipoarticulo)
)TYPE=MYISAM
;



-- 
-- TABLE: MaTIPOCAMA 
--

CREATE TABLE MaTIPOCAMA(
    ncodcama       DECIMAL(10, 0)    NOT NULL,
    cnombrecama    CHAR(10),
    PRIMARY KEY (ncodcama)
)TYPE=MYISAM
;



-- 
-- TABLE: MaTIPOCOLCHON 
--

CREATE TABLE MaTIPOCOLCHON(
    ncodcolchon       DECIMAL(10, 0)    NOT NULL,
    cnombrecolchon    CHAR(10),
    PRIMARY KEY (ncodcolchon)
)TYPE=MYISAM
;



-- 
-- TABLE: MaTIPODOCUMENTO 
--

CREATE TABLE MaTIPODOCUMENTO(
    ncoddocumento            DECIMAL(10, 0)    NOT NULL,
    cdescripciondocumento    CHAR(10),
    ctipodocumento           CHAR(10),
    PRIMARY KEY (ncoddocumento)
)TYPE=MYISAM
;



-- 
-- TABLE: MaTIPOMOVIMIENTO 
--

CREATE TABLE MaTIPOMOVIMIENTO(
    ncodmoviemiento    DECIMAL(10, 0)    NOT NULL,
    cdescripcion       CHAR(10),
    ctipomovimiento    CHAR(10),
    PRIMARY KEY (ncodmoviemiento)
)TYPE=MYISAM
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
)TYPE=MYISAM
;



-- 
-- TABLE: MaUSOARTICULO 
--

CREATE TABLE MaUSOARTICULO(
    ncodarticulo        DECIMAL(10, 0)    NOT NULL,
    ncoddepartamento    DECIMAL(10, 0)    NOT NULL
)TYPE=MYISAM
;



-- 
-- TABLE: MaVENTAS 
--

CREATE TABLE MaVENTAS(
    ncodventas      DECIMAL(10, 0)    NOT NULL,
    cfechaventa     CHAR(10),
    nprecioventa    DECIMAL(10, 0),
    PRIMARY KEY (ncodventas)
)TYPE=MYISAM
;



-- 
-- TABLE: TrACTIVIDADLUDICA 
--

CREATE TABLE TrACTIVIDADLUDICA(
    ncodactividad    DECIMAL(10, 0)    NOT NULL,
    ctipo            CHAR(10),
    cnombre          CHAR(10),
    cdescripcion     CHAR(10),
    ncodempleado     DECIMAL(10, 0)    NOT NULL,
    PRIMARY KEY (ncodactividad)
)TYPE=MYISAM
;



-- 
-- TABLE: TrCOBRO 
--

CREATE TABLE TrCOBRO(
    ncodcobro          DECIMAL(10, 0)    NOT NULL,
    npago              DECIMAL(10, 0),
    nsaldo             DECIMAL(10, 0),
    cfecha             CHAR(10),
    ncodmora           DECIMAL(10, 0)    NOT NULL,
    ncodfactura        DECIMAL(10, 0)    NOT NULL,
    ncodtransaccion    DECIMAL(10, 0)    NOT NULL,
    PRIMARY KEY (ncodcobro)
)TYPE=MYISAM
;



-- 
-- TABLE: TrCOMPRA 
--

CREATE TABLE TrCOMPRA(
    ncodarticulo    DECIMAL(10, 0)    NOT NULL
)TYPE=MYISAM
;



-- 
-- TABLE: TrCONTRATO 
--

CREATE TABLE TrCONTRATO(
    ncodcontrato       DECIMAL(10, 0)    NOT NULL,
    vhorariotrabajo    VARCHAR(30),
    vdetalle           VARCHAR(20),
    vpuestoreporta     VARCHAR(20),
    vzonaresidencia    VARCHAR(30),
    ctipocontrato      CHAR(10),
    cfechainicio       CHAR(10),
    cfechafin          CHAR(10),
    nsalario           DECIMAL(10, 0),
    ncodempleado       DECIMAL(10, 0)    NOT NULL,
    ncodempresa        DECIMAL(10, 0)    NOT NULL,
    ncodsolicitud      DECIMAL(10, 0)    NOT NULL,
    PRIMARY KEY (ncodcontrato)
)TYPE=MYISAM
;



-- 
-- TABLE: TrDEPARTAMENTO 
--

CREATE TABLE TrDEPARTAMENTO(
    ncoddepartamento       DECIMAL(10, 0)    NOT NULL,
    cnombredepartamento    CHAR(10),
    ctipo                  CHAR(10),
    PRIMARY KEY (ncoddepartamento)
)TYPE=MYISAM
;



-- 
-- TABLE: TrDESEMPENIO 
--

CREATE TABLE TrDESEMPENIO(
    vcargo              VARCHAR(10)       NOT NULL,
    vcalidadtrabajo     VARCHAR(10),
    vcantidadtrabajo    VARCHAR(10),
    ncodempleado        DECIMAL(10, 0)    NOT NULL,
    PRIMARY KEY (vcargo)
)TYPE=MYISAM
;



-- 
-- TABLE: TrESCOLARIDAD 
--

CREATE TABLE TrESCOLARIDAD(
    ncodescolaridad    DECIMAL(10, 0)    NOT NULL,
    ctipo              CHAR(10),
    cdescripcion       CHAR(10),
    PRIMARY KEY (ncodescolaridad)
)TYPE=MYISAM
;



-- 
-- TABLE: TrEXISTENCIA 
--

CREATE TABLE TrEXISTENCIA(
    nexistencia     DECIMAL(10, 0),
    ncodbodega      DECIMAL(10, 0)    NOT NULL,
    ncodarticulo    DECIMAL(10, 0)    NOT NULL
)TYPE=MYISAM
;



-- 
-- TABLE: TrFAMILIA 
--

CREATE TABLE TrFAMILIA(
    ncodfamilia     DECIMAL(10, 0)    NOT NULL,
    ctipo           CHAR(10),
    cdescripcion    CHAR(10),
    PRIMARY KEY (ncodfamilia)
)TYPE=MYISAM
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
)TYPE=MYISAM
;



-- 
-- TABLE: TrMOVIMIENTO 
--

CREATE TABLE TrMOVIMIENTO(
    ncodmovimiento       DECIMAL(10, 0)    NOT NULL,
    cjustificacion       CHAR(10),
    cencargado           CHAR(10),
    cfechamovimiento     CHAR(10),
    choramovimiento      CHAR(10),
    creferenciafisica    CHAR(10),
    ncodmoviemiento      DECIMAL(10, 0)    NOT NULL,
    ncodarticulo         DECIMAL(10, 0)    NOT NULL,
    PRIMARY KEY (ncodmovimiento)
)TYPE=MYISAM
;



-- 
-- TABLE: TrPAGOPROVEEDOR 
--

CREATE TABLE TrPAGOPROVEEDOR(
    ncodpagoproveedor    DECIMAL(10, 0)    NOT NULL,
    ncodproveedor        DECIMAL(10, 0)    NOT NULL,
    ncodtransaccion      DECIMAL(10, 0)    NOT NULL,
    PRIMARY KEY (ncodpagoproveedor)
)TYPE=MYISAM
;



-- 
-- TABLE: TrPAGOS 
--

CREATE TABLE TrPAGOS(
    ncodpago          DECIMAL(10, 0)    NOT NULL,
    cfechapago        CHAR(10),
    cdescripcion      CHAR(10),
    ncodcuenta        DECIMAL(10, 0)    NOT NULL,
    ncodrecibopago    DECIMAL(10, 0)    NOT NULL,
    PRIMARY KEY (ncodpago)
)TYPE=MYISAM
;



-- 
-- TABLE: TrPAGOSALARIO 
--

CREATE TABLE TrPAGOSALARIO(
    ncodpagosalario    DECIMAL(10, 0)    NOT NULL,
    ncodcontrato       DECIMAL(10, 0)    NOT NULL,
    ncodtransaccion    DECIMAL(10, 0)    NOT NULL,
    PRIMARY KEY (ncodpagosalario)
)TYPE=MYISAM
;



-- 
-- TABLE: TrPEDIDO 
--

CREATE TABLE TrPEDIDO(
    ncodpedido           DECIMAL(10, 0)    NOT NULL,
    vserie               VARCHAR(10),
    vnombrepedido        VARCHAR(10),
    vnit                 VARCHAR(10),
    vdireccion           VARCHAR(25),
    dfechapedido         DATE,
    dfechavencimiento    DATE,
    ntotal               DECIMAL(10, 0),
    vestadopedido        VARCHAR(10),
    vnombrevendedor      VARCHAR(20),
    cdescripcion         CHAR(10),
    cfechaentrega        CHAR(10),
    ncodventas           DECIMAL(10, 0)    NOT NULL,
    ncodarticulo         DECIMAL(10, 0)    NOT NULL,
    ncodcliente          DECIMAL(10, 0)    NOT NULL,
    PRIMARY KEY (ncodpedido)
)TYPE=MYISAM
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
    ncodempleado      DECIMAL(10, 0)    NOT NULL,
    ncodempresa       DECIMAL(10, 0)    NOT NULL
)TYPE=MYISAM
;



-- 
-- TABLE: TrPROCESOORDEN 
--

CREATE TABLE TrPROCESOORDEN(
    ncodprocesoorden    DECIMAL(10, 0)    NOT NULL,
    cnombreproceso      CHAR(10),
    PRIMARY KEY (ncodprocesoorden)
)TYPE=MYISAM
;



-- 
-- TABLE: TrSOLICITUD 
--

CREATE TABLE TrSOLICITUD(
    ncodsolicitud                   DECIMAL(10, 0)    NOT NULL,
    vcaracteristicaspsicofisicas    VARCHAR(100),
    vdetalleestudios                VARCHAR(30),
    vpretencionsalarial             VARCHAR(20),
    cfecha                          CHAR(10),
    cnacionalidad                   CHAR(10),
    cnopasaporte                    CHAR(10),
    chabitospersonales              CHAR(10),
    cpuestosolicitado               CHAR(10),
    csueldosolicitado               CHAR(10),
    cfechanacimiento                CHAR(10),
    ncodescolaridad                 DECIMAL(10, 0)    NOT NULL,
    ncodfamilia                     DECIMAL(10, 0)    NOT NULL,
    PRIMARY KEY (ncodsolicitud)
)TYPE=MYISAM
;



-- 
-- TABLE: TrSTATUSORDEN 
--

CREATE TABLE TrSTATUSORDEN(
    ncodstatusorden    DECIMAL(10, 0)    NOT NULL,
    cestatus           CHAR(10),
    PRIMARY KEY (ncodstatusorden)
)TYPE=MYISAM
;



-- 
-- TABLE: TrTRANSACCION 
--

CREATE TABLE TrTRANSACCION(
    ncodtransaccion        DECIMAL(10, 0)    NOT NULL,
    cfecha                 CHAR(10),
    nmonto                 DECIMAL(10, 0),
    ncodtipotransaccion    DECIMAL(10, 0)    NOT NULL,
    ncodcuenta             DECIMAL(10, 0)    NOT NULL,
    PRIMARY KEY (ncodtransaccion)
)TYPE=MYISAM
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


-- 
-- TABLE: MaCUENTA 
--

ALTER TABLE MaCUENTA ADD CONSTRAINT RefMaBANCO128 
    FOREIGN KEY (ncodbanco)
    REFERENCES MaBANCO(ncodbanco)
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


-- 
-- TABLE: MaDOCUMENTO 
--

ALTER TABLE MaDOCUMENTO ADD CONSTRAINT RefMaTIPODOCUMENTO159 
    FOREIGN KEY (ncoddocumento)
    REFERENCES MaTIPODOCUMENTO(ncoddocumento)
;

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
-- TABLE: MaFACTURA 
--

ALTER TABLE MaFACTURA ADD CONSTRAINT RefMaCLIENTE124 
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
-- TABLE: Mamaterial 
--

ALTER TABLE Mamaterial ADD CONSTRAINT RefMaARTICULO117 
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
-- TABLE: MaORDEN 
--

ALTER TABLE MaORDEN ADD CONSTRAINT RefTrSTATUSORDEN142 
    FOREIGN KEY (ncodstatusorden)
    REFERENCES TrSTATUSORDEN(ncodstatusorden)
;

ALTER TABLE MaORDEN ADD CONSTRAINT RefTrPROCESOORDEN143 
    FOREIGN KEY (ncodprocesoorden)
    REFERENCES TrPROCESOORDEN(ncodprocesoorden)
;

ALTER TABLE MaORDEN ADD CONSTRAINT RefMaTIPOCAMA178 
    FOREIGN KEY (ncodcama)
    REFERENCES MaTIPOCAMA(ncodcama)
;

ALTER TABLE MaORDEN ADD CONSTRAINT RefMaTIPOCOLCHON116 
    FOREIGN KEY (ncodcolchon)
    REFERENCES MaTIPOCOLCHON(ncodcolchon)
;


-- 
-- TABLE: MaORDENCOMPRA 
--

ALTER TABLE MaORDENCOMPRA ADD CONSTRAINT RefMaARTICULO163 
    FOREIGN KEY (ncodarticulo)
    REFERENCES MaARTICULO(ncodarticulo)
;

ALTER TABLE MaORDENCOMPRA ADD CONSTRAINT RefMaPROVEEDOR118 
    FOREIGN KEY (ncodproveedor)
    REFERENCES MaPROVEEDOR(ncodproveedor)
;


-- 
-- TABLE: MaPLAZA 
--

ALTER TABLE MaPLAZA ADD CONSTRAINT RefMaEMPRESA149 
    FOREIGN KEY (ncodempresa)
    REFERENCES MaEMPRESA(ncodempresa)
;


-- 
-- TABLE: MaRecetaCama 
--

ALTER TABLE MaRecetaCama ADD CONSTRAINT RefMaTIPOCAMA181 
    FOREIGN KEY (ncodcama)
    REFERENCES MaTIPOCAMA(ncodcama)
;

ALTER TABLE MaRecetaCama ADD CONSTRAINT RefMamaterial186 
    FOREIGN KEY (ncodmaterial)
    REFERENCES Mamaterial(ncodmaterial)
;


-- 
-- TABLE: MaRecetaColchon 
--

ALTER TABLE MaRecetaColchon ADD CONSTRAINT RefMaTIPOCOLCHON182 
    FOREIGN KEY (ncodcolchon)
    REFERENCES MaTIPOCOLCHON(ncodcolchon)
;

ALTER TABLE MaRecetaColchon ADD CONSTRAINT RefMamaterial185 
    FOREIGN KEY (ncodmaterial)
    REFERENCES Mamaterial(ncodmaterial)
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
-- TABLE: TrACTIVIDADLUDICA 
--

ALTER TABLE TrACTIVIDADLUDICA ADD CONSTRAINT RefMaEMPLEADO129 
    FOREIGN KEY (ncodempleado)
    REFERENCES MaEMPLEADO(ncodempleado)
;


-- 
-- TABLE: TrCOBRO 
--

ALTER TABLE TrCOBRO ADD CONSTRAINT RefTrTRANSACCION139 
    FOREIGN KEY (ncodtransaccion)
    REFERENCES TrTRANSACCION(ncodtransaccion)
;

ALTER TABLE TrCOBRO ADD CONSTRAINT RefMaMORA122 
    FOREIGN KEY (ncodmora)
    REFERENCES MaMORA(ncodmora)
;

ALTER TABLE TrCOBRO ADD CONSTRAINT RefMaFACTURA123 
    FOREIGN KEY (ncodfactura)
    REFERENCES MaFACTURA(ncodfactura)
;


-- 
-- TABLE: TrCOMPRA 
--

ALTER TABLE TrCOMPRA ADD CONSTRAINT RefMaARTICULO138 
    FOREIGN KEY (ncodarticulo)
    REFERENCES MaARTICULO(ncodarticulo)
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

ALTER TABLE TrPEDIDO ADD CONSTRAINT RefMaARTICULO146 
    FOREIGN KEY (ncodarticulo)
    REFERENCES MaARTICULO(ncodarticulo)
;

ALTER TABLE TrPEDIDO ADD CONSTRAINT RefMaCLIENTE167 
    FOREIGN KEY (ncodcliente)
    REFERENCES MaCLIENTE(ncodcliente)
;

ALTER TABLE TrPEDIDO ADD CONSTRAINT RefMaVENTAS119 
    FOREIGN KEY (ncodventas)
    REFERENCES MaVENTAS(ncodventas)
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

ALTER TABLE TrTRANSACCION ADD CONSTRAINT RefMaCUENTA158 
    FOREIGN KEY (ncodcuenta)
    REFERENCES MaCUENTA(ncodcuenta)
;

ALTER TABLE TrTRANSACCION ADD CONSTRAINT RefMaTIPOTRANSACCION111 
    FOREIGN KEY (ncodtipotransaccion)
    REFERENCES MaTIPOTRANSACCION(ncodtipotransaccion)
;


