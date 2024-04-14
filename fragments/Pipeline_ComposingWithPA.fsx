let placeOrder : PlaceOrderWorkflow =

  // set up local versions of the pipeline stages
  // using partial application to bake in the dependencies
  let validateOrder = 
    validateOrder checkProductCodeExists checkAddressExists
  let priceOrder = 
    priceOrder getProductPrice 
  let acknowledgeOrder = 
    acknowledgeOrder createAcknowledgmentLetter sendAcknowledgment 

  // return the workflow function
  fun unvalidatedOrder ->

    // compose the pipeline from the new one-parameter functions
    unvalidatedOrder 
    |> validateOrder
    |> priceOrder
    |> acknowledgeOrder 
    |> createEvents
