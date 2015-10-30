--

-- ER/Studio 8.0 SQL Code Generation

-- Company :      a

-- Project :      DATA MODEL

-- Author :       Windows User

--

-- Date Created : Wednesday, September 30, 2015 21:45:47

-- Target DBMS : MySQL 5.x

--



-- 

-- TABLE: MaPunto 

--



CREATE TABLE MaPunto(

    ncodigopunto    INT(10)    NOT NULL AUTO_INCREMENT,

    cx              CHAR(10),

    cy              CHAR(10),

    ncodgrafica     INT(10)    NOT NULL,

    PRIMARY KEY (ncodigopunto)

)ENGINE=MYISAM

;







-- 

-- TABLE: TrGRAFICA 

--



CREATE TABLE TrGRAFICA(

    ncodgrafica       INT(10)    NOT NULL AUTO_INCREMENT,

    dfecha            DATE,

    ctipo             CHAR(20),

    ctitulografica    CHAR(100)         NOT NULL,

    cejex             CHAR(100)         NOT NULL,

    cejey             CHAR(100)         NOT NULL,

    PRIMARY KEY (ncodgrafica)

)ENGINE=MYISAM

;







-- 

-- TABLE: MaPunto 

--



ALTER TABLE MaPunto ADD CONSTRAINT RefTrGRAFICA1 

    FOREIGN KEY (ncodgrafica)

    REFERENCES TrGRAFICA(ncodgrafica)

;





