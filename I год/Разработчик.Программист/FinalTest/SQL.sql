CREATE DATABASE HumanFriends;
USE HumanFriends;

CREATE TABLE Animals
	(ID INT PRIMARY KEY AUTO_INCREMENT,
	Name VARCHAR(20) NOT NULL,
	FromTable VARCHAR(20) NOT NULL,
	BirthDate DATE,
	Commands VARCHAR(50));

CREATE TABLE Pets
(ID INT PRIMARY KEY AUTO_INCREMENT,
Name VARCHAR(20) NOT NULL,
Type VARCHAR(20) NOT NULL,
BirthDate DATE,
Commands VARCHAR(50));

CREATE TABLE PackAnimals
(ID INT PRIMARY KEY AUTO_INCREMENT,
Name VARCHAR(20) NOT NULL,
Type VARCHAR(20) NOT NULL,
BirthDate DATE,
Commands VARCHAR(50));

CREATE TABLE Cat
(ID INT PRIMARY KEY AUTO_INCREMENT,
Name VARCHAR(20) NOT NULL,
Type VARCHAR(20) NOT NULL,
BirthDate DATE,
Commands VARCHAR(50));
	
INSERT INTO Cat(Name, Type, Birthdate, Commands) VALUES
	('Барсик','Кот', '2022-01-01','Мяукает'),
	('Ковальски','Кот','2017-01-09','Царапается');
    
CREATE TABLE Dog
(ID INT PRIMARY KEY AUTO_INCREMENT,
Name VARCHAR(20) NOT NULL,
Type VARCHAR(20) NOT NULL,
BirthDate DATE,
Commands VARCHAR(50));
	
INSERT INTO Dog(Name, Type, Birthdate, Commands) VALUES
	('Шарик','Собака', '2021-12-25','Лает'),
	('Бобик','Собака','2023-02-15','Приносит мячик');
    
CREATE TABLE Hamster
(ID INT PRIMARY KEY AUTO_INCREMENT,
Name VARCHAR(20) NOT NULL,
Type VARCHAR(20) NOT NULL,
BirthDate DATE,
Commands VARCHAR(50));
	
INSERT INTO Hamster(Name, Type, Birthdate, Commands) VALUES
	('Пушистик','Хомяк', '2022-01-01','Фыркает'),
	('Хома','Хомяк','2018-06-20','Крутит колесо');
    
CREATE TABLE Horse
(ID INT PRIMARY KEY AUTO_INCREMENT,
Name VARCHAR(20) NOT NULL,
Type VARCHAR(20) NOT NULL,
BirthDate DATE,
Commands VARCHAR(50));
	
INSERT INTO Horse(Name, Type, Birthdate, Commands) VALUES
	('Спирит','Лошадь', '2014-06-14','Скачет'),
	('Максимус','Лошадь','2022-04-12','Гарцует');   
    
CREATE TABLE Camel
(ID INT PRIMARY KEY AUTO_INCREMENT,
Name VARCHAR(20) NOT NULL,
Type VARCHAR(20) NOT NULL,
BirthDate DATE,
Commands VARCHAR(50));
	
INSERT INTO Camel(Name, Type, Birthdate, Commands) VALUES
	('Стив','Верблюд', '2023-01-03','Гуляет'),
	('Бо','Верблюд','2021-10-10','Плюется');
    
CREATE TABLE Donkey
(ID INT PRIMARY KEY AUTO_INCREMENT,
Name VARCHAR(20) NOT NULL,
Type VARCHAR(20) NOT NULL,
BirthDate DATE,
Commands VARCHAR(50));
	
INSERT INTO Donkey(Name, Type, Birthdate, Commands) VALUES
	('Иа','Осел', '2022-05-21','Везет воду'),
	('Эд','Осел','2023-12-24','Упрямится');    


DELETE FROM Camel;

SELECT * FROM Camel;

CREATE TABLE HorseAndDonkey
	(ID INT PRIMARY KEY AUTO_INCREMENT,
	Name VARCHAR(20) NOT NULL,
	Type VARCHAR(20) NOT NULL,
	BirthDate DATE,
	Commands VARCHAR(50));
    
INSERT INTO HorseAndDonkey(Name,Type,BirthDate,Commands) 
	SELECT Name,Type,BirthDate,Commands FROM Horse 
    UNION ALL
    SELECT Name,Type,BirthDate,Commands FROM Donkey;
    
SELECT * FROM HorseAndDonkey;

INSERT INTO Animals(Name,FromTable,BirthDate,Commands)
SELECT Name,Type,BirthDate,Commands FROM Cat
UNION ALL
SELECT Name,Type,BirthDate,Commands FROM Dog
UNION ALL
SELECT Name,Type,BirthDate,Commands FROM Hamster
UNION ALL
SELECT Name,Type,BirthDate,Commands FROM Horse
UNION ALL
SELECT Name,Type,BirthDate,Commands FROM Camel
UNION ALL
SELECT Name,Type,BirthDate,Commands FROM Donkey;

SELECT * FROM Animals;
    
CREATE TABLE YoungAnimal
(ID INT PRIMARY KEY AUTO_INCREMENT,
Name VARCHAR(20) NOT NULL,
Type VARCHAR(20) NOT NULL,
BirthDate DATE, 
AgeYear INT,
AgeMonth INT);

INSERT INTO YoungAnimal(Name,Type,BirthDate,AgeYear,AgeMonth) 
SELECT Name,FromTable,BirthDate, YEAR(current_date()) - YEAR(BirthDate) - 
  (CASE WHEN
    MONTH(BirthDate) > MONTH(current_date()) OR 
    (MONTH(BirthDate) = MONTH(current_date()) AND DAY(BirthDate) > DAY(current_date())) 
      THEN 1 
      ELSE 0  
      END) AS AgeYear,
12 -      
   (CASE 
	WHEN MONTH(BirthDate) < MONTH(current_date()) AND DAY(BirthDate) > DAY(current_date())
    THEN MONTH(BirthDate) + 1
    WHEN MONTH(BirthDate) < MONTH(current_date()) AND DAY(BirthDate) <= DAY(current_date())
    THEN MONTH(BirthDate)
    WHEN MONTH(BirthDate) > MONTH(current_date()) AND DAY(BirthDate) > DAY(current_date())
    THEN MONTH(BirthDate) 
    WHEN MONTH(BirthDate) > MONTH(current_date()) AND DAY(BirthDate) <= DAY(current_date())
    THEN MONTH(BirthDate) - 1
	WHEN MONTH(BirthDate) = MONTH(current_date()) AND DAY(BirthDate) >= DAY(current_date())
    THEN 12
    WHEN MONTH(BirthDate) = MONTH(current_date()) AND DAY(BirthDate) < DAY(current_date())
    THEN 1
    END) AS AgeMonth
FROM Animals;

DELETE FROM YoungAnimal WHERE AgeYear < 1 OR (AgeYear = 3 AND AgeMonth > 0) OR AgeYear > 3
LIMIT 100;

SELECT * FROM YoungAnimal;





