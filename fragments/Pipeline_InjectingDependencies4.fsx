let placeOrder 
  checkProductExists               // dependency
  checkAddressExists               // dependency
  getProductPrice                  // dependency
  createOrderAcknowledgmentLetter  // dependency
  sendOrderAcknowledgment          // dependency
  : PlaceOrderWorkflow =           // function definition 

    fun unvalidatedOrder -> 
      ...

