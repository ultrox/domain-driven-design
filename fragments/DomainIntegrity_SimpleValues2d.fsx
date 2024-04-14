/// An Active pattern to replace 
/// the constructor pattern matching
let (|UnitQuantity|) unitQuantity =
  // extract the quantity
  let (UnitQuantity qty) = unitQuantity 
  // and return it
  qty
