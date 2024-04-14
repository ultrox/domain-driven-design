/// The "Place Order" process
type PlaceOrder = 
  UnvalidatedOrder -> Result<PlaceOrderEvents,PlaceOrderError>
