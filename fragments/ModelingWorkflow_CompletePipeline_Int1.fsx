
// bring in the types from the domain API module
open DomainApi

// ----------------------
// Order life cycle
// ----------------------

// validated state        
type ValidatedOrderLine =  ...
type ValidatedOrder = {
  OrderId : OrderId
  CustomerInfo : CustomerInfo
  ShippingAddress : Address
  BillingAddress : Address
  OrderLines : ValidatedOrderLine list
  }
and OrderId = Undefined
and CustomerInfo = ...
and Address = ...

// priced state            
type PricedOrderLine = ...
type PricedOrder = ...

// all states combined
type Order =
  | Unvalidated of UnvalidatedOrder
  | Validated of ValidatedOrder
  | Priced of PricedOrder
  // etc
