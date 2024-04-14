let functionAWithFruitError input = 
  input 
  |> functionA 
  |> Result.mapError AppleErrorCase 
