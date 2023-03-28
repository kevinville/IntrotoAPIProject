DROP DATABASE IF EXISTS TestJobCensus;
CREATE DATABASE TestJobCensus;
USE TestJobCensus;

CREATE TABLE Worker(
	WorkerId INT NOT NULL auto_increment,
    WorkerName VARCHAR(255) NOT NULL UNIQUE, 
    Age INT NOT NULL,
    JobTitle varchar(255) NOT NULL,
    CurrentPay FLOAT NOT NULL,
    PRIMARY KEY (WorkerId)
    );
    
CREATE TABLE PublicInfo(
	PersonId INT NOT NULL auto_increment,
    PhoneNumber VARCHAR(255) NOT NULL,
    Address VARCHAR(255) NOT NULL,
    WorkerId INT NOT NULL,
    PRIMARY KEY (PersonId),
    FOREIGN KEY (WorkerId) REFERENCES Worker(WorkerId)
    );

INSERT INTO Worker (WorkerName, Age, JobTitle, CurrentPay) VALUES
	("Larry Lobster", "25", "Professional Lifter", "0"),
    ("Spongebob Squarepants", "50", "Fry Cook", "0.62"),
    ("Squidward Tentacles", "44", "Cashier", "42500"),
    ("Eugene Krabs", "80", "Restaurant Owner", "999999"),
    ("Sandy Cheeks", "36", "Scientist", "94250"),
    ("Sheldon J. Plankton", "59", "Restaurant Owner", "8500"),
    ("Mrs Oh Neptune Puff", "64", "Boating School Instructor", "63900");
    
INSERT INTO PublicInfo(PhoneNumber, Address, WorkerId) VALUES
	("123-456-7890", "123 The Sea", "1"),
    ("098-765-4321", "124 Conch St", "2"),
    ("135-151-3515", "the nose house thing", "3"),
    ("985-135-9931", "123 anchor lane", "4"),
    ("963-852-7410", "big glass done", "5"),
    ("545-654-5462", "the chum bucket", "6"),
    ("366-386-3833", "i have no idea", "7");