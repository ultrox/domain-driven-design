let validateOrder : ValidateOrder = 
  fun checkProductCodeExists checkAddressExists unvalidatedOrder ->
    result {
      let! orderId = 
        unvalidatedOrder.OrderId 
        |> OrderId.create
        |> Result.mapError ValidationError
      let! customerInfo = 
        unvalidatedOrder.CustomerInfo 
        |> toCustomerInfo
      let! shippingAddress = ...
      let! billingAddress  = ...
      let! lines = ...

      let validatedOrder : ValidatedOrder = {
        OrderId  = orderId 
        CustomerInfo = customerInfo 
        ShippingAddress = shippingAddress 
        BillingAddress = billingAddress  
        Lines = lines 
      }
      return validatedOrder 
    }
