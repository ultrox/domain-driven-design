let calculateShippingCost validatedOrder = 
  match validatedOrder.ShippingAddress with
  | UsLocalState -> 5.0
  | UsRemoteState -> 10.0
  | International -> 20.0
