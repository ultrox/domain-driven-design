type AcknowledgeOrder = 
  PricedOrder                         // input
    -> OrderAcknowledgmentSent option // output

type CreateEvents = 
  PricedOrder                            // input
    -> OrderAcknowledgmentSent option    // input (event from previous step)
    -> PlaceOrderEvent list              // output
