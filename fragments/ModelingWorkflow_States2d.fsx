type Order =
  | Unvalidated of UnvalidatedOrder
  | Validated of ValidatedOrder
  | Priced of PricedOrder
  // etc
