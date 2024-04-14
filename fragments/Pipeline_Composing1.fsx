let placeOrder : PlaceOrderWorkflow =
  fun unvalidatedOrder ->
    unvalidatedOrder
    |> validateOrder
    |> priceOrder
    |> acknowledgeOrder
    |> createEvents
