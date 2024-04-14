let convertSingleDbRecord tableName idValue records toDomain =
  match records with
  // none found
  | [] -> 
    let msg = sprintf "Not found. Table=%s Id=%A" tableName idValue
    Error msg  // return a Result

  // exactly one found        
  | [dbRecord] ->
    dbRecord
    |> toDomain
    |> Ok   // return a Result

  // more than one found?        
  | _ ->
    let msg = sprintf "Multiple records found. Table=%s Id=%A" tableName idValue
    raise (DatabaseError msg)
