let functionA : FunctionA = ...

let functionAWithFruitError input = 
  input 
  |> functionA 
  |> Result.mapError (fun appleError -> AppleErrorCase appleError)
