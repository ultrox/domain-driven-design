/// Uses extended output
let twelveDividedBy n = 
  match n with
  | 6 -> Some 2 // valid
  | 5 -> Some 2 // valid
  | 4 -> Some 3 // valid
  ... 
  | 0 -> None   // undefined
