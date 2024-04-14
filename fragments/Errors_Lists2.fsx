let validateOrder unvalidatedOrder =
  ...

  let lines = // lines is a "list of Result"   
      unvalidatedOrder.Lines 
      |> List.map (toValidatedOrderLine checkProductCodeExists) 

  let validatedOrder : ValidatedOrder = {
    ...
    Lines = lines  // compiler error 
    //       ^ expecting a "Result of list" here
    }
  ...
