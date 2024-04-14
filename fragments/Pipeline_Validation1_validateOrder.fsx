let validateOrder : ValidateOrder = 
  fun checkProductCodeExists checkAddressExists unvalidatedOrder -> 

    let orderId = 
      unvalidatedOrder.OrderId 
      |> OrderId.create 

    let customerInfo = 
      unvalidatedOrder.CustomerInfo 
      |> toCustomerInfo   // helper function

    let shippingAddress = 
      unvalidatedOrder.ShippingAddress 
      |> toAddress        // helper function

    // and so on, for each property of the unvalidatedOrder

    // when all the fields are ready, use them to 
    // create and return a new "ValidatedOrder" record
    {
      OrderId = orderId
      CustomerInfo = customerInfo
      ShippingAddress = shippingAddress
      BillingAddress = ...
      Lines = ...
    }
