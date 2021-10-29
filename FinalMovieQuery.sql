use MoviesDatabase

CREATE TABLE FinalMovie(
ID int PRIMARY KEY NOT NULL,
Title varchar(20) NOT NULL,
Director varchar(50) NOT NULL,
Year INT,
Rating FLOAT
);

INSERT INTO FinalMovie VALUES (1, 'CoCo', 'Lee Unkrich', 2017, 8.4)
INSERT INTO FinalMovie VALUES (2, 'The Dark Knight', 'Christopher Nolan', 2008, 9.0)
INSERT INTO FinalMovie VALUES (3, 'Pulp Fiction', 'Quentin Tarantino', 1994, 8.9)
INSERT INTO FinalMovie VALUES (4, 'Fight Club', 'David Fincher', 1999, 8.8)
INSERT INTO FinalMovie VALUES (5, 'Forrest Gump', 'Robert Zemeckis', 1994, 8.8)
INSERT INTO FinalMovie VALUES (6, 'The Matrix', 'Lana Wachowski', 1999, 8.7)
INSERT INTO FinalMovie VALUES (7, 'Se7en', 'David Fincher', 1995, 8.6)
INSERT INTO FinalMovie VALUES (8, 'Saving Private Ryan', 'Steven Spielberg', 1998, 8.6)

Select * from FinalMovie;