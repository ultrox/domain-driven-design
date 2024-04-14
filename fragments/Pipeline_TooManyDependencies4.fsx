let placeOrder : PlaceOrderWorkflow =

  // initialize information (e.g from configuration)
  let endPoint = ...
  let credentials = ...

  // make a new version of checkAddressExists
  // with the credentials baked in
  let checkAddressExists = checkAddressExists endPoint credentials
  // etc

  // set up the steps in the workflow
  let validateOrder = 
    validateOrder checkProductCodeExists checkAddressExists
    //               the new checkAddressExists ^ 
    //               is a one parameter function 
  // etc

  // return the workflow function
  fun unvalidatedOrder -> 
    // compose the pipeline from the steps
    ...
