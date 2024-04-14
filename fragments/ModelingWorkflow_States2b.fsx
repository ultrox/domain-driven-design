type PricedOrder = {
  OrderId : ...
  CustomerInfo : CustomerInfo
  ShippingAddress : Address
  BillingAddress : Address
  // different from ValidatedOrder
  OrderLines : PricedOrderLine list 
  AmountToBill : BillingAmount      
  }
