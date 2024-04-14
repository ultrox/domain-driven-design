type AcknowledgeOrder = 
  CreateOrderAcknowledgmentLetter     // dependency
    -> SendOrderAcknowledgment        // dependency
    -> PricedOrder                    // input
    -> OrderAcknowledgmentSent option // output
