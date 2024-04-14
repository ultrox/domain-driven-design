let readOneContact (productionConnection:SqlConnection) (ContactId contactId) =
  use cmd = new ReadOneContact(productionConnection)
  let tableName = "ContactInfo" 

  let records = cmd.Execute(contactId = contactId) |> Seq.toList
  convertSingleDbRecord tableName contactId records toDomain
