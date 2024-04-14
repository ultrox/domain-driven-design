let toDomain (dbRecord:ReadOneCustomer.Record) : Customer =

  let customerId = 
    dbRecord.CustomerId
    |> CustomerId.create
    |> panicOnError "CustomerId"

  let name = 
    dbRecord.Name
    |> String50.create "Name"
    |> panicOnError "Name"

  let birthdate = 
    dbRecord.Birthdate
    |> Result.bindOption Birthdate.create
    |> panicOnError "Birthdate"

  // return the customer
  {CustomerId = customerId; Name = name; Birthdate = birthdate}
