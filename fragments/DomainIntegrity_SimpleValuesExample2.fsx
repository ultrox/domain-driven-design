let unitQtyResult = UnitQuantity.create 1

match unitQtyResult with
| Error msg -> 
  printfn "Failure, Message is %s" msg
| Ok uQty -> 
  printfn "Success. Value is %A" uQty
  let innerValue = UnitQuantity.value uQty
  printfn "innerValue is %i" innerValue 
