let printList1 aList =
  // matching against list literals
  match aList with
  | [] ->   
    printfn "list is empty"
  | [x] -> 
    printfn "list has one element: %A" x
  | [x;y] ->       // match using list literal
    printfn "list has two elements: %A and %A" x y
  | longerList ->  // match anything else
    printfn "list has more than two elements" 
