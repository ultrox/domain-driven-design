let readOneCustomer (productionConnection:SqlConnection) (CustomerId customerId) =
  use cmd = new ReadOneCustomer(productionConnection)
  let tableName = "Customer" 

  let records = cmd.Execute(customerId = customerId) |> Seq.toList
  convertSingleDbRecord tableName customerId records toDomain
