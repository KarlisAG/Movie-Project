use movies;

CREATE TABLE users
(
userID INT NOT NULL AUTO_INCREMENT,
login varchar(255) NOT NULL,
password varchar(255) NOT NULL,
userName varchar(255),
userSurname varchar(255),
userAge varchar(255),
userSex varchar(255),
userCountry varchar(255),
PRIMARY KEY (userID)
);


CREATE TABLE watchList
(
movieTitle varchar(255) NOT NULL,
movieType varchar(255) NOT NULL,
movieYear varchar(255) NOT NULL,
movieLength varchar(255) NOT NULL,
movieRating varchar(255) NOT NULL,
movieRated varchar(255) NOT NULL,
movieGenre varchar(255) NOT NULL,
userID INT NOT NULL,
FOREIGN KEY(userID) REFERENCES users(userID)
);

INSERT INTO users (login, password)
VALUES ("admin", "admin123");

DROP TABLE users;

SELECT * FROM watchList;

SELECT * FROM users;

DELETE FROM watchList
WHERE movieTitle = 'Vikings';

ALTER TABLE watchList
ADD movieImdbID varchar(255);

SELECT * FROM watchList
WHERE movieImdbID = "tt046536";

ALTER TABLE users
MODIFY COLUMN userAge varchar(255); 

INSERT INTO watchList (movieTitle, movieType, movieYear, movieLength, movieRating, movieRated, movieGenre, movieImdbID, userID)
VALUES("Elizabeth I", "series", "2005", "223 min", "N/A", "TV-MA", "Biography, Drama, History, Romance", "tt0465326", 4);

SELECT * FROM users 
WHERE login = "Marija";