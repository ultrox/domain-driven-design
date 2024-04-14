let validateOrder : ValidateOrder = 
  fun checkProductCodeExists checkAddressExists unvalidatedOrder -> 

    let orderId = ...
    let customerInfo = ...
    let shippingAddress = 
      unvalidatedOrder.ShippingAddress 
      |> toAddress checkAddressExists // new parameter

    ...
