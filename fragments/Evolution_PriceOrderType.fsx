type PriceOrder = 
  GetPricingFunction  // new dependency 
    -> ValidatedOrder // input 
    -> PricedOrder    // output 
