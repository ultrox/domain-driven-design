type PriceOrder = 
  ValidatedOrder                          // input
    -> Result<PricedOrder, PricingError>  // output
