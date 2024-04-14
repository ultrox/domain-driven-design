let validateOrder : ValidateOrder = 
  fun checkProductExists // dependency for toValidatedOrderLine
    checkAddressExists   // dependency for toAddress
    unvalidatedOrder ->

      // build the validated address using the dependency 
      let shippingAddress = 
        unvalidatedOrder.ShippingAddress 
        |> toAddress checkAddressExists

      ...

      // build the validated order lines using the dependency 
      let lines = 
        unvalidatedOrder.Lines 
        |> List.map (toValidatedOrderLine checkProductExists) 

      ...
