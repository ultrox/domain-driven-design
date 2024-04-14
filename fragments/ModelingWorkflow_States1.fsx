type Order = {
  OrderId : OrderId
  ...
  IsValidated : bool  // set when validated
  IsPriced : bool     // set when priced
  AmountToBill : decimal option // also set when priced
  }
