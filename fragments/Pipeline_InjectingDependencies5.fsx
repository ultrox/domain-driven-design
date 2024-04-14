let app : WebPart =

  // set up the services used by the workflow
  let checkProductExists = ...
  let checkAddressExists = ...
  let getProductPrice = ...
  let createOrderAcknowledgmentLetter = ...
  let sendOrderAcknowledgment = ...
  let toHttpResponse = ...

  // set up the "placeOrder" workflow
  // by partially applying the services to it
  let placeOrder = 
    placeOrder 
      checkProductExists 
      checkAddressExists 
      getProductPrice 
      createOrderAcknowledgmentLetter 
      sendOrderAcknowledgment 

  // set up the other workflows
  let changeOrder = ...
  let cancelOrder = ...

  // set up the routing
  choose 
    [ POST >=> choose
      [ path "/placeOrder" 
          >=> deserializeOrder // convert JSON to UnvalidatedOrder
          >=> placeOrder       // do the workflow
          >=> postEvents       // post the events onto queues
          >=> toHttpResponse   // return 200/400/etc based on the output
        path "/changeOrder"
          >=> ...
        path "/cancelOrder"
          >=> ...
      ]
    ]
