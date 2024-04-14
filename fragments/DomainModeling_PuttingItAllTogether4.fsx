type CustomerInfo = Undefined
type ShippingAddress = Undefined
type BillingAddress = Undefined
type Price = Undefined
type BillingAmount = Undefined

type Order = {
  Id : OrderId             // id for entity
  CustomerId : CustomerId  // customer reference
  ShippingAddress : ShippingAddress 
  BillingAddress : BillingAddress 
  OrderLines : OrderLine list
  AmountToBill : BillingAmount
  }

and OrderLine = {
  Id : OrderLineId  // id for entity
  OrderId : OrderId
  ProductCode : ProductCode 
  OrderQuantity : OrderQuantity 
  Price : Price
  }
