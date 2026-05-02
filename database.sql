CREATE DATABASE twowheelerdb;

USE twowheelerdb;

CREATE TABLE Vehicles (
    Id INT AUTO_INCREMENT PRIMARY KEY,
    ModelName VARCHAR(255) NOT NULL,
    Brand VARCHAR(255) NOT NULL,
    EngineCc INT,
    MaxPower VARCHAR(255),
    FuelType VARCHAR(255),
    ImageUrl VARCHAR(500)
);