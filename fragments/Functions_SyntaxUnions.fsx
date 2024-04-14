// Union types have choices. Vertical bars are separators.
type Temp = 
  | DegreesC of float
  | DegreesF of int

// To create a value of a union type, use the case tag as the constructor
let tempInC = DegreesC 37.1
let tempInF = DegreesF 98
