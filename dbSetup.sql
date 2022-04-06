CREATE TABLE IF NOT EXISTS accounts(
  id VARCHAR(255) NOT NULL primary key COMMENT 'primary key',
  createdAt DATETIME DEFAULT CURRENT_TIMESTAMP COMMENT 'Time Created',
  updatedAt DATETIME DEFAULT CURRENT_TIMESTAMP ON UPDATE CURRENT_TIMESTAMP COMMENT 'Last Update',
  name varchar(255) COMMENT 'User Name',
  email varchar(255) COMMENT 'User Email',
  picture varchar(255) COMMENT 'User Picture'
) default charset utf8 COMMENT '';
CREATE TABLE IF NOT EXISTS car(
  id INT NOT NULL AUTO_INCREMENT PRIMARy KEY,
  createdAt DATETIME DEFAULT CURRENT_TIMESTAMP COMMENT 'Time Created',
  updatedAt DATETIME DEFAULT CURRENT_TIMESTAMP ON UPDATE CURRENT_TIMESTAMP COMMENT 'Last Update',
  name TEXT NOT NULL,
  color TEXT,
  year DECIMAL(4, 0)
) default charset utf8;
/*CRUD METHODS

GET 

SELECT * FROM modelname;


GET BY __

SELECT * FROM modelname WHERE id = 12345;


PUT

UPDATE modelname
SET
  description = "",
  name = ""
WHERE id = 1234;


POST

INSERT INTO modelname
(name, description, price)
VALUES
("Doobie", "long and green", 9.00);


DELETE

DELETE FROM modelname WHERE id = 1234 LIMIT 1;


DANGER ZONE

DELETE FROM modelname; - removes all data from table

DROP TABLE modelname; - deletes entire table

DROP DATABASE; - remove entire database
*/