let toOrderQuantity productCode quantity = 
  match productCode with
  | Widget _ -> 
    quantity
    |> int                  // convert decimal to int 
    |> UnitQuantity.create  // to UnitQuantity
    |> OrderQuantity.Unit   // lift to OrderQuantity type
  | Gizmo _ -> 
    quantity 
    |> KilogramQuantity.create  // to KilogramQuantity
    |> OrderQuantity.Kilogram   // lift to OrderQuantity type
