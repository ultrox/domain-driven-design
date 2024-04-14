type ValidatedOrder = {
  OrderId : OrderId
  CustomerInfo : CustomerInfo
  ShippingAddress : Address
  BillingAddress : Address
  OrderLines : ValidatedOrderLine list
  }
