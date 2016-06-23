DROP TABLE BootType CASCADE CONSTRAINTS;
DROP TABLE Boot CASCADE CONSTRAINTS;
DROP TABLE BootHuurcontract CASCADE CONSTRAINTS;
DROP TABLE Huurcontract CASCADE CONSTRAINTS;
DROP TABLE Persoon CASCADE CONSTRAINTS;
DROP TABLE HuurProduct CASCADE CONSTRAINTS;
DROP TABLE BijkomendProduct CASCADE CONSTRAINTS;
DROP TABLE "Admin" CASCADE CONSTRAINTS;
DROP TABLE Zee CASCADE CONSTRAINTS;
DROP TABLE HuurZee CASCADE CONSTRAINTS;

CREATE TABLE BootType(
  ID number PRIMARY KEY,
  Naam varchar2(100) NOT NULL
);

INSERT INTO BootType VALUES (1, 'Kano');
INSERT INTO BootType VALUES (2, 'Valk');
INSERT INTO BootType VALUES (3, 'Laser');
INSERT INTO BootType VALUES (4, 'Cruiser');

CREATE TABLE Boot(
  ID number PRIMARY KEY,
  BootTypeID number NOT NULL,
  FOREIGN KEY (BootTypeID) REFERENCES BootType,
  Naam varchar2(100) NOT NULL,
  CONSTRAINT UniqueName UNIQUE(Naam),
  TankInhoud number
);

INSERT INTO Boot VALUES (1, 1, 'De Kameroen', null);
INSERT INTO Boot VALUES (2, 2, 'De Adelaar', null);
INSERT INTO Boot VALUES (3, 3, 'De Vliegende Hollander', null);
INSERT INTO Boot VALUES (4, 4, 'De Kameleon', 10);

CREATE TABLE Persoon(
  ID number PRIMARY KEY,
  Naam varchar2(100) NOT NULL,
  Email varchar2(100) NOT NULL
);

INSERT INTO Persoon VALUES (1, 'Leif Erikson', 'Jan@Jansen.com');

CREATE TABLE Huurcontract(
  ID number PRIMARY KEY,
  PersoonID number NOT NULL,
  FOREIGN KEY(PersoonID) REFERENCES Persoon,
  Van Date NOT NULL,
  Tot date NOT NULL,
  MeerNr number NOT NULL
);

INSERT INTO Huurcontract VALUES (1, 1, '01-DEC-2001', '02-DEC-2001', 5);

CREATE TABLE BootHuurcontract(
  HuurcontractID number NOT NULL,
  FOREIGN KEY(HuurcontractID) REFERENCES Huurcontract,
  BootID number NOT NULL,
  FOREIGN KEY(BootID) REFERENCES Boot,
  CONSTRAINT PrimaryKey1 PRIMARY KEY (HuurcontractID, BootID)
);

INSERT INTO BootHuurcontract VALUES (1, 4);

CREATE TABLE BijkomendProduct(
  ID number PRIMARY KEY,
  Naam varchar2(100) NOT NULL
);

INSERT INTO BijkomendProduct VALUES (1, 'Reddingsvest');
INSERT INTO BijkomendProduct VALUES (2, 'Zwemvlies');
INSERT INTO BijkomendProduct VALUES (3, 'Zeil');
INSERT INTO BijkomendProduct VALUES (4, 'BBQ');

CREATE TABLE HuurProduct(
  HuurcontractID number NOT NULL,
  FOREIGN KEY(HuurcontractID) REFERENCES Huurcontract,
  BijkomendProductID number NOT NULL,
  FOREIGN KEY(BijkomendProductID) REFERENCES BijkomendProduct,
  Aantal number NOT NULL,
  CONSTRAINT PrimaryKey2 PRIMARY KEY (HuurcontractID, BijkomendProductID)
);

INSERT INTO HuurProduct VALUES (1, 1, 4);

CREATE TABLE "Admin"(
  ID number Primary Key,
  Username varchar2(100) NOT NULL,
  Password varchar2(100) NOT NULL
);

INSERT INTO "Admin" VALUES (1, 'tobi', 'wachtwoord');

CREATE TABLE Zee(
  ID number PRIMARY KEY,
  naam varchar2(100) NOT NULL
);

INSERT INTO Zee VALUES (1, 'Waddenzee');
INSERT INTO Zee VALUES (2, 'Ijsselmeer');
INSERT INTO Zee VALUES (3, 'Noordzee');

CREATE TABLE HuurZee(
  HuurcontractID number NOT NULL,
  FOREIGN KEY(HuurcontractID) REFERENCES Huurcontract,
  ZeeID number NOT NULL,
  FOREIGN KEY(ZeeID) REFERENCES Zee,
  CONSTRAINT PrimaryKey3 PRIMARY KEY (HuurcontractID, ZeeID)
);

INSERT INTO HuurZee VALUES (1, 1);
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