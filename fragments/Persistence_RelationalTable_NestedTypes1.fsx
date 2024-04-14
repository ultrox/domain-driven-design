CREATE TABLE Order (
  OrderId int NOT NULL, 
  -- and other columns
)

CREATE TABLE OrderLine (
  OrderLineId int NOT NULL, 
  OrderId int NOT NULL, 
  -- and other columns
)
