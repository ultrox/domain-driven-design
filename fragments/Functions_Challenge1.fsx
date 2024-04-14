// a function that has an int as output
let add1 x = x + 1

// a function that has an Option<int> as input
let printOption x = 
  match x with
  | Some i -> printfn "The int is %i" i
  | None -> printfn "No value"
