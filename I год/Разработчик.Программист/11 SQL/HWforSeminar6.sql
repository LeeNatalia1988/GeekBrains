/*
Создайте функцию, которая принимает кол-во сек и формат их в кол-во дней часов. Пример: 123456 ->'1 days 10 hours 17 minutes 36 seconds '
*/

DROP FUNCTION IF EXISTS my_convert;
DELIMITER \\
CREATE FUNCTION my_convert(seconds BIGINT) RETURNS VARCHAR(100) READS SQL DATA
BEGIN
	DECLARE days INT;
    DECLARE hours INT;
    DECLARE minutes INT;
    DECLARE result VARCHAR(100);
    SET days = seconds DIV 86400;
    SET hours = (seconds - (days * 86400)) DIV 3600;
	SET minutes = (seconds - (days * 86400) - (hours * 3600)) DIV 60;
	SET seconds = (seconds - (days * 86400) - (hours * 3600) - (minutes * 60));
    SET result = CONCAT(days, ' days ', hours, ' hours ', minutes, ' minutes ', seconds, ' seconds');
    RETURN result;
END \\
DELIMITER ; 

SELECT my_convert(123456);

/*
Выведите только четные числа от 1 до 10. Пример: 2,4,6,8,10
*/

DROP FUNCTION IF EXISTS numbers;
DELIMITER \\
CREATE FUNCTION numbers (my_number BIGINT) RETURNS VARCHAR(255) READS SQL DATA
BEGIN
	DECLARE i INT;
    DECLARE result VARCHAR(255);
    SET i = 2;
    SET result = '';
    WHILE i <= my_number DO
		IF i % 2 = 0 THEN SET result = CONCAT(result, i, '  ');
        END IF;
        SET i = i + 1; 
	END WHILE;
    RETURN result;
END \\
DELIMITER ; 

SELECT numbers(10);