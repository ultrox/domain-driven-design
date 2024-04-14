let map f aResult = 
  match aResult with 
  | Ok success -> Ok (f success)
  | Error failure -> Error failure
