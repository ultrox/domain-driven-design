/// Corresponding DTO types
type NameDto = {
  First : string
  Last : string
  }

type ExampleDto = {
  Tag : string // one of "A","B", "C", "D" 
  // no data for A case
  BData : Nullable<int>  // data for B case
  CData : string[]       // data for C case
  DData : NameDto        // data for D case 
  }
