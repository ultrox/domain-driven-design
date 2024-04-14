let validateOrder : ValidateOrder = 
  fun checkProductCodeExists checkAddressExists unvalidatedOrder ->
    let orderId = 
      unvalidatedOrder.OrderId 
      |> OrderId.create
    let customerInfo = 
      unvalidatedOrder.CustomerInfo 
      |> toCustomerInfo
    let shippingAddress = 
      unvalidatedOrder.ShippingAddress 
      |> toAddress checkAddressExists
    let billingAddress = ...
    let lines = ...

    let validatedOrder : ValidatedOrder = {
      OrderId  = orderId 
      CustomerInfo = customerInfo 
      ShippingAddress = shippingAddress 
      BillingAddress = billingAddress  
      Lines = lines 
    }
    validatedOrder 
