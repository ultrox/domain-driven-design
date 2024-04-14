// ------------------------------
// The complete workflow
// ------------------------------
let placeOrder 
  checkProductExists              // dependency
  checkAddressExists              // dependency
  getProductPrice                 // dependency
  createOrderAcknowledgmentLetter // dependency
  sendOrderAcknowledgment         // dependency
  : PlaceOrderWorkflow =          // definition of function

  fun unvalidatedOrder -> 
    let validatedOrder = 
      unvalidatedOrder 
      |> validateOrder checkProductExists checkAddressExists 
    let pricedOrder = 
      validatedOrder 
      |> priceOrder getProductPrice 
    let acknowledgmentOption = 
      pricedOrder 
      |> acknowledgeOrder createOrderAcknowledgmentLetter sendOrderAcknowledgment 
    let events = 
      createEvents pricedOrder acknowledgmentOption 
    events
