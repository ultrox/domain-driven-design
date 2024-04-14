let functionA : FunctionA = ...
let functionB : FunctionB = ...

// convert functionA to use "FruitError"
let functionAWithFruitError input = 
  input |> functionA |> Result.mapError AppleErrorCase

// convert functionB to use "FruitError"    
let functionBWithFruitError input = 
  input |> functionB |> Result.mapError BananaErrorCase

// and now we can compose the new versions with "bind"    
let functionAB input = 
  input 
  |> functionAWithFruitError
  |> Result.bind functionBWithFruitError
