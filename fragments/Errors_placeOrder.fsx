let placeOrder : PlaceOrder =       // definition of function
  fun unvalidatedOrder -> 
    result {
      let! validatedOrder = 
        validateOrder checkProductExists checkAddressExists unvalidatedOrder 
        |> Result.mapError PlaceOrderError.Validation
      let! pricedOrder = 
        priceOrder getProductPrice validatedOrder 
        |> Result.mapError PlaceOrderError.Pricing
      let acknowledgmentOption = ...
      let events = ...
      return events
    }
