use movies;

CREATE TABLE user
(
userID INT NOT NULL AUTO_INCREMENT,
username varchar(255) NOT NULL,
password varchar(255) NOT NULL,
userName varchar(255),
userSurname varchar(255),
userAge INT,
userSex varchar(255),
userCountry varchar(255),
FOREIGN KEY (userID) REFERENCES watchList(userID) 
);

INSERT INTO user (username, password)
VALUES ("Karlis", "Gribulis");

DROP TABLE user;

SELECT * FROM user;