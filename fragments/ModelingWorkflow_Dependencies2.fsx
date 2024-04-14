type ValidateOrder = 
  UnvalidatedOrder                                      // input
    -> AsyncResult<ValidatedOrder,ValidationError list> // output

type PriceOrder = 
  ValidatedOrder                        // input
    -> Result<PricedOrder,PricingError> // output
