// ----------------------
// Input data
// ----------------------

type UnvalidatedOrder = {
  OrderId : string
  CustomerInfo : UnvalidatedCustomer
  ShippingAddress : UnvalidatedAddress
  }
and UnvalidatedCustomer = {
  Name : string
  Email : string
  }
and UnvalidatedAddress = ...

// ----------------------
// Input Command
// ----------------------

type Command<'data> = {
  Data : 'data
  Timestamp: DateTime
  UserId: string
  // etc
  }

type PlaceOrderCommand = Command<UnvalidatedOrder>  
