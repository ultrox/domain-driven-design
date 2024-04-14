let createEvents : CreateEvents = 
  fun pricedOrder acknowledgmentEventOpt ->
    let events1 = 
      pricedOrder
      // convert to common choice type
      |> PlaceOrderEvent.OrderPlaced
      // convert to list
      |> List.singleton
    let events2 =
      acknowledgmentEventOpt 
      // convert to common choice type
      |> Option.map PlaceOrderEvent.AcknowledgmentSent
      // convert to list
      |> listOfOption
    let events3 = 
      pricedOrder
      |> createBillingEvent 
      // convert to common choice type
      |> Option.map PlaceOrderEvent.BillableOrderPlaced
      // convert to list
      |> listOfOption

    // return all the events
    [
    yield! events1
    yield! events2
    yield! events3
    ]            
