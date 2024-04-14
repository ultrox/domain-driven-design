let validateOrder unvalidatedOrder =
  let orderId = ... create order id (or throw exception)
  let customerInfo = ... create info (or throw exception) 
  let shippingAddress = ... create and validate shippingAddress...
  // etc
