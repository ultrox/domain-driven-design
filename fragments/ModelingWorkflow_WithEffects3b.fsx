type AcknowledgeOrder = 
  CreateOrderAcknowledgmentLetter     // dependency
    -> SendOrderAcknowledgment        // Async dependency
    -> PricedOrder                    // input
    -> Async<OrderAcknowledgmentSent option> // Async output
