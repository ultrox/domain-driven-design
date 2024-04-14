let printQuantity aOrderQty =
  match aOrderQty with
  | UnitQuantity uQty -> 
    printfn "%i units" uQty 
  | KilogramQuantity kgQty -> 
    printfn "%g kg" kgQty
