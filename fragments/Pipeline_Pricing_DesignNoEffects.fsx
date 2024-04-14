type GetProductPrice = ProductCode -> Price
type PriceOrder = 
  GetProductPrice      // dependency
    -> ValidatedOrder  // input
    -> PricedOrder     // output
