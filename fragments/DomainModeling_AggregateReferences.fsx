type Order = {
  OrderId : OrderId
  CustomerId : CustomerId  // reference to associated customer
  OrderLines : OrderLine list
  // etc
  }
