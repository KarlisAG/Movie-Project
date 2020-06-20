use movies;

CREATE TABLE watchList
(
movieTitle varchar(255) NOT NULL,
movieType varchar(255) NOT NULL,
movieYear varchar(255) NOT NULL,
movieLength varchar(255) NOT NULL,
movieRating varchar(255) NOT NULL,
movieRated varchar(255) NOT NULL,
movieGenre varchar(255) NOT NULL,
userID INT NOT NULL PRIMARY KEY
);

DROP TABLE watchList;

SELECT * FROM watchList;