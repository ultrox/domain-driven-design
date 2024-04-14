exception DatabaseError of string

let panicOnError columnName result =
  match result with
  | Ok x -> x
  | Error err -> 
    let msg = sprintf "%s: %A" columnName err
    raise (DatabaseError msg)
