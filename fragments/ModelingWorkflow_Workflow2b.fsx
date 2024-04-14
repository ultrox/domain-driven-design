type PriceOrder = 
  GetProductPrice      // dependency
    -> ValidatedOrder  // input
    -> PricedOrder     // output
