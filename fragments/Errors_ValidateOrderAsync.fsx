let validateOrder : ValidateOrder = 
  fun checkProductCodeExists checkAddressExists unvalidatedOrder ->
    asyncResult {
      let! orderId = 
        unvalidatedOrder.OrderId 
        |> OrderId.create
        |> Result.mapError ValidationError
        |> AsyncResult.ofResult   // lift a Result to AsyncResult
      let! customerInfo = 
        unvalidatedOrder.CustomerInfo 
        |> toCustomerInfo
        |> AsyncResult.ofResult
      let! checkedShippingAddress = // extract the checked address 
        unvalidatedOrder.ShippingAddress 
        |> toCheckedAddress checkAddressExists
      let! shippingAddress =        // process checked address  
        checkedShippingAddress 
        |> toAddress 
        |> AsyncResult.ofResult
      let! billingAddress = ...
      let! lines = 
        unvalidatedOrder.Lines 
        |> List.map (toValidatedOrderLine checkProductCodeExists) 
        |> Result.sequence // convert list of Results to a single Result
        |> AsyncResult.ofResult
      let validatedOrder : ValidatedOrder = {
        OrderId  = orderId 
        CustomerInfo = customerInfo 
        ShippingAddress = shippingAddress 
        BillingAddress = billingAddress  
        Lines = lines 
      }
      return validatedOrder 
    }
