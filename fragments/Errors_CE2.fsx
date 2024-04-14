let placeOrder unvalidatedOrder = 
  result {
    let! validatedOrder = 
      validateOrder unvalidatedOrder 
      |> Result.mapError PlaceOrderError.Validation
    let! pricedOrder = 
      priceOrder validatedOrder 
      |> Result.mapError PlaceOrderError.Pricing
    let acknowledgmentOption = 
      acknowledgeOrder pricedOrder 
    let events = 
      createEvents pricedOrder acknowledgmentOption 
    return events
  }
