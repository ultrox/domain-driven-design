let add1 x = x + 1     // an int -> int function
let square x = x * x   // an int -> int function

let add1ThenSquare x =   
  x |> add1 |> square 

// test
add1ThenSquare 5       // result is 36
