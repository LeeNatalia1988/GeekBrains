-- create
CREATE TABLE groupmate (
  id INTEGER PRIMARY KEY AUTO_INCREMENT,
  name TEXT NOT NULL,
  age INTEGER NOT NULL,
  adress TEXT NOT NULL
);

-- insert
INSERT INTO groupmate(name, age, adress) VALUES ('Ivan', 18, 'Moscow');
INSERT INTO groupmate(name, age, adress) VALUES ('Peter', 19, 'Voronej');
INSERT INTO groupmate(name, age, adress) VALUES ('Maksim', 30, 'Moscow');
INSERT INTO groupmate(name, age, adress) VALUES ('Pavel', 23, 'Moscow');
INSERT INTO groupmate(name, age, adress) VALUES ('Igor', 21, 'Novosibirsk');
INSERT INTO groupmate(name, age, adress) VALUES ('Oleg', 17, 'Moscow');
INSERT INTO groupmate(name, age, adress) VALUES ('Sveta', 18, 'Kemerovo');
INSERT INTO groupmate(name, age, adress) VALUES ('Natalia', 20, 'Novokuznetsk');

-- fetch 
SELECT name AS Имя FROM groupmate WHERE adress = 'Moscow' AND age >= 18 AND age < 30 ;