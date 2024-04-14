CREATE TABLE Order (
  OrderId int NOT NULL, 

  -- inline the shipping address Value Object
  ShippingAddress1 varchar(50)
  ShippingAddress2 varchar(50)
  ShippingAddressCity varchar(50)
  -- and so on

  -- inline the billing address Value Object
  BillingAddress1 varchar(50)
  BillingAddress2 varchar(50)
  BillingAddressCity varchar(50)
  -- and so on

  -- other columns
)
