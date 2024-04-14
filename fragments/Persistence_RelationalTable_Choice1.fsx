CREATE TABLE ContactInfo (
  -- shared data
  ContactId int NOT NULL, 
  -- case flags
  IsEmail bit NOT NULL,
  IsPhone bit NOT NULL,
  -- data for the "Email" case
  EmailAddress NVARCHAR(100), -- Nullable
  -- data for the "Phone" case
  PhoneNumber NVARCHAR(25), -- Nullable
  -- primary key constraint
  CONSTRAINT PK_ContactInfo PRIMARY KEY (ContactId)
)
