type PlaceOrderWorkflow = 
  PlaceOrder                                             // input 
    -> AsyncResult<PlaceOrderEvent list,PlaceOrderError> // output
