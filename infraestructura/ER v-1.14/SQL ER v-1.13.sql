--
-- ER/Studio Data Architect 11.0 SQL Code Generation
-- Project :      ER (7 DE 8 modulos incluidos).dm1
--
-- Date Created : Tuesday, November 03, 2015 19:25:52
-- Target DBMS : MySQL 3.x
--

-- 
-- TABLE: MaEMPLEADO 
--

CREATE TABLE MaEMPLEADO(
    ncodempleado         INT               AUTO_INCREMENT,
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
    ncodusuario          INT,
    PRIMARY KEY (ncodempleado)
)TYPE=INNODB
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

ALTER TABLE MaEMPLEADO ADD CONSTRAINT RefMaUSUARIO281 
    FOREIGN KEY (ncodusuario)
    REFERENCES MaUSUARIO(ncodusuario)
;


