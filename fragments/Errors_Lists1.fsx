let validateOrder unvalidatedOrder =
  ...

  // convert each line into an OrderLine domain type
  let lines = 
      unvalidatedOrder.Lines 
      |> List.map (toValidatedOrderLine checkProductCodeExists) 

  // create and return a ValidatedOrder
  let validatedOrder : ValidatedOrder = {
    ...
    Lines = lines
    // etc
    }
  validatedOrder 
