-- Main table
CREATE TABLE ContactInfo (
  -- shared data
  ContactId int NOT NULL, 
  -- case flags
  IsEmail bit NOT NULL,
  IsPhone bit NOT NULL,
  CONSTRAINT PK_ContactInfo PRIMARY KEY (ContactId)
)

-- Child table for "Email" case
CREATE TABLE ContactEmail (
  ContactId int NOT NULL, 
  -- case-specific data
  EmailAddress NVARCHAR(100) NOT NULL,
  CONSTRAINT PK_ContactEmail PRIMARY KEY (ContactId)
)

-- Child table for "Phone" case
CREATE TABLE ContactPhone (
  ContactId int NOT NULL, 
  -- case-specific data
  PhoneNumber NVARCHAR(25) NOT NULL,
  CONSTRAINT PK_ContactPhone PRIMARY KEY (ContactId)
)
