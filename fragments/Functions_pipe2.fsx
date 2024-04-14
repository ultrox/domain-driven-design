let isEven x = 
  (x % 2) = 0              // an int -> bool function

let printBool x = 
  sprintf "value is %b" x  // a bool -> string function

let isEvenThenPrint x =  
  x |> isEven |> printBool 

// test
isEvenThenPrint 2          // result is "value is true"
