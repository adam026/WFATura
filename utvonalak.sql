--Kezdés 16:35
--Vége 16:50

--CREATE DATABASE tura;
--USE tura;

--CREATE TABLE turazo(
--id INT PRIMARY KEY IDENTITY,
--vezeteknev VARCHAR(30),
--keresztnev VARCHAR(30),
--varos VARCHAR(50),
--telefonszam VARCHAR(11));

--CREATE TABLE utvonal(
--id INT PRIMARY KEY IDENTITY,
--turazoID INT FOREIGN KEY REFERENCES turazo(id),
--honnan VARCHAR(50),
--hova VARCHAR (50),
--km INT);

--INSERT INTO turazo VALUES
--('Kiss','Manyi','Velence','06701234567'),
--('Nagy','Imre','Budapest','06703216547'),
--('Tompa','Mihály','Budapest','06207854563');

--INSERT INTO utvonal VALUES
--(2,'Budapest','Monor',38),
--(3,'Budapest','Esztergom',54);