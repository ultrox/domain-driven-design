let printList2 aList =
  // matching against "cons"
  match aList with
  | [] ->   
    printfn "list is empty"
  | first::rest ->  
    printfn "list is non-empty with the first element being: %A" first
