let toDomain (dbRecord:ReadOneCustomer.Record) : Result<Customer,_> =
  result {
    let! customerId = 
      dbRecord.CustomerId
      |> CustomerId.create
    let! name = 
      dbRecord.Name
      |> String50.create "Name"
    let! birthdate = 
      dbRecord.Birthdate
      |> Result.bindOption Birthdate.create
    let customer = {
      CustomerId = customerId
      Name = name
      Birthdate = birthdate
      }
    return customer
    }
