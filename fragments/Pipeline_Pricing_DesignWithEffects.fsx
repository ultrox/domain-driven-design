type PriceOrder = 
  GetProductPrice      // dependency
    -> ValidatedOrder  // input
    -> Result<PricedOrder, PlaceOrderError>  // output
