CREATE DATABASE practica_helpers;

USE practica_helpers;

CREATE TABLE cliente
(
 id int identity PRIMARY KEY,
 name varchar(30) not null,
 phone integer not null
);