type ValidateOrder = 
  UnvalidatedOrder                                       // input
    -> AsyncResult<ValidatedOrder,ValidationError list>  // output

type PriceOrder = 
  ValidatedOrder                            // input
    -> Result<PricedOrder,PricingError>     // output

type AcknowledgeOrder = 
  PricedOrder                                // input
    -> Async<OrderAcknowledgmentSent option> // output

type CreateEvents = 
    PricedOrder               // input
      -> PlaceOrderEvent list // output
