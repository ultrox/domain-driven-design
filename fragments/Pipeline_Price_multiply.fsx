/// Multiply a Price by a decimal qty.
/// Raise exception if new price is out of bounds.
let multiply qty (Price p) = 
  create (qty * p)
