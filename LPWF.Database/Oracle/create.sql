DROP TABLE BootType CASCADE CONSTRAINTS;
DROP TABLE Boot CASCADE CONSTRAINTS;
DROP TABLE BootHuurcontract CASCADE CONSTRAINTS;
DROP TABLE Huurcontract CASCADE CONSTRAINTS;
DROP TABLE Persoon CASCADE CONSTRAINTS;
DROP TABLE HuurProduct CASCADE CONSTRAINTS;
DROP TABLE BijkomendProduct CASCADE CONSTRAINTS;
DROP TABLE "Admin" CASCADE CONSTRAINTS;

CREATE TABLE BootType(
  ID number PRIMARY KEY,
  Naam varchar2(100) NOT NULL
);

CREATE TABLE Boot(
  ID number PRIMARY KEY,
  BootTypeID number NOT NULL,
  FOREIGN KEY (BootTypeID) REFERENCES BootType,
  Naam varchar2(100) NOT NULL,
  Beschikbaar number(1) NOT NULL,
  TankInhoud number
);

CREATE TABLE Persoon(
  ID number PRIMARY KEY,
  Naam varchar2(100) NOT NULL,
  Email varchar2(100) NOT NULL
);

CREATE TABLE Huurcontract(
  ID number PRIMARY KEY,
  PersoonID number NOT NULL,
  FOREIGN KEY(PersoonID) REFERENCES Persoon,
  Van Date NOT NULL,
  Tot date NOT NULL,
  ZeeNr number NOT NULL,
  MeerNr number NOT NULL
);

CREATE TABLE BootHuurcontract(
  HuurcontractID number NOT NULL,
  FOREIGN KEY(HuurcontractID) REFERENCES Huurcontract,
  BootID number NOT NULL,
  FOREIGN KEY(BootID) REFERENCES Boot,
  CONSTRAINT PrimaryKey1 PRIMARY KEY (HuurcontractID, BootID)
);

CREATE TABLE BijkomendProduct(
  ID number PRIMARY KEY,
  Naam varchar2(100) NOT NULL
);

CREATE TABLE HuurProduct(
  HuurcontractID number NOT NULL,
  FOREIGN KEY(HuurcontractID) REFERENCES Huurcontract,
  BijkomendProductID number NOT NULL,
  FOREIGN KEY(BijkomendProductID) REFERENCES BijkomendProduct,
  CONSTRAINT PrimaryKey2 PRIMARY KEY (HuurcontractID, BijkomendProductID)
);

CREATE TABLE "Admin"(
  ID number Primary Key,
  Username varchar2(100) NOT NULL,
  Password varchar2(100) NOT NULL
);
  
/*
CREATE OR REPLACE TRIGGER BootAvailability
BEFORE INSERT OR UPDATE 
ON HuurProduct
FOR EACH ROW
DECLARE
  TimeNow Date := SYSDATE;
  
  CURSOR Boten
  IS 
    SELECT B.ID
    FROM Boot B
    INNER JOIN BootHuurcontract BH
    ON BH.BootID = B.ID
    INNER JOIN Huurcontract H
    ON BH.HuurcontractID = H.ID
    WHERE H.ID = :new.id;
    
  BootID number := 0;
BEGIN
  OPEN Boten;
  LOOP
    FETCH Boten INTO BootID;
    EXIT WHEN Boten%notfound;
    UPDATE Boot SET Beschikbaar = 0 WHERE ID = BootID;
  END LOOP;
END;
/  */