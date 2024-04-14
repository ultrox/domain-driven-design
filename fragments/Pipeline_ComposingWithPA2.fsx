let placeOrder : PlaceOrderWorkflow =       
  // return the workflow function
  fun unvalidatedOrder -> 
    let validatedOrder = 
      unvalidatedOrder 
      |> validateOrder checkProductCodeExists checkAddressExists 
    let pricedOrder = 
      validatedOrder 
      |> priceOrder getProductPrice 
    let acknowledgmentOption = 
      pricedOrder 
      |> acknowledgeOrder createAcknowledgmentLetter sendAcknowledgment 
    let events = 
      createEvents pricedOrder acknowledgmentOption 
    events
