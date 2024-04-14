type ReadOneCustomer = SqlCommandProvider<"""
  SELECT CustomerId, Name, Birthdate
  FROM Customer
  WHERE CustomerId = @customerId
  """, CompileTimeConnectionString>
