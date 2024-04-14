let placeOrder : PlaceOrder =       
  fun unvalidatedOrder -> 
    asyncResult {
      let! validatedOrder = 
        validateOrder checkProductExists checkAddressExists unvalidatedOrder 
        |> AsyncResult.mapError PlaceOrderError.Validation
      let! pricedOrder = 
        priceOrder getProductPrice validatedOrder 
        |> AsyncResult.ofResult
        |> AsyncResult.mapError PlaceOrderError.Pricing
      let acknowledgmentOption = ...
      let events = ... 
      return events
    }
