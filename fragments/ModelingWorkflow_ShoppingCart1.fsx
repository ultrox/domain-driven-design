type Item = ...
type ActiveCartData = { UnpaidItems: Item list }
type PaidCartData = { PaidItems: Item list; Payment: float }

type ShoppingCart = 
  | EmptyCart  // no data
  | ActiveCart of ActiveCartData
  | PaidCart of PaidCartData
