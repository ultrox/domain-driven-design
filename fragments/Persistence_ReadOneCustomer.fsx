type DbReadError =
  | InvalidRecord of string
  | MissingRecord of string

let readOneCustomer (productionConnection:SqlConnection) (CustomerId customerId) =
  // create the command by instantiating the type we defined earlier
  use cmd = new ReadOneCustomer(productionConnection)

  // execute the command
  let records = cmd.Execute(customerId = customerId) |> Seq.toList

  // handle the possible cases
  match records with
  // none found
  | [] ->
    let msg = sprintf "Not found. CustomerId=%A" customerId
    Error (MissingRecord msg)  // return a Result

  // exactly one found
  | [dbCustomer] ->
    dbCustomer
    |> toDomain
    |> Result.mapError InvalidRecord

  // more than one found?
  | _ ->
    let msg = sprintf "Multiple records found for CustomerId=%A" customerId
    raise (DatabaseError msg)
