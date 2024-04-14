type PricingError = PricingError of string

type PriceOrder = 
  GetProductPrice                       // dependency
    -> ValidatedOrder                   // input
    -> Result<PricedOrder,PricingError> // output
