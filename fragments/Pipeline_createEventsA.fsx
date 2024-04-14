let createEvents : CreateEvents = 
  fun pricedOrder acknowledgmentEventOpt ->
    let event1 = 
      pricedOrder
      // convert to common choice type
      |> PlaceOrderEvent.OrderPlaced
    let event2Opt =
      acknowledgmentEventOpt 
      // convert to common choice type
      |> Option.map PlaceOrderEvent.AcknowledgmentSent
    let event3Opt = 
      pricedOrder
      |> createBillingEvent 
      // convert to common choice type
      |> Option.map PlaceOrderEvent.BillableOrderPlaced

    // return all the events how?
    ...
