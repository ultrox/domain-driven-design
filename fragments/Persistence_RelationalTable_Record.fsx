CREATE TABLE Customer (
  CustomerId int NOT NULL, 
  Name NVARCHAR(50) NOT NULL, 
  Birthdate DATETIME NULL,
  CONSTRAINT PK_Customer PRIMARY KEY (CustomerId)
)
