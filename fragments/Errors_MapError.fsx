let mapError f aResult = 
  match aResult with 
  | Ok success -> Ok success
  | Error failure -> Error (f failure)
