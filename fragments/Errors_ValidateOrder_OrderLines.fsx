let validateOrder : ValidateOrder =
  fun checkProductCodeExists checkAddressExists unvalidatedOrder ->
    result {
      let! orderId = ...
      let! customerInfo = ...
      let! shippingAddress = ...
      let! billingAddress  = ...
      let! lines =
        unvalidatedOrder.Lines
        |> List.map (toValidatedOrderLine checkProductCodeExists)
        |> Result.sequence // convert list of Results to a single Result

      let validatedOrder : ValidatedOrder = {
        OrderId  = orderId
        CustomerInfo = customerInfo
        ShippingAddress = shippingAddress
        BillingAddress = billingAddress
        Lines = lines
      }
      return validatedOrder
    }
