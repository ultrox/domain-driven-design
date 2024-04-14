let placeOrder unvalidatedOrder =
  unvalidatedOrder
  |> validateOrder
  |> priceOrder
  |> acknowledgeOrder
  |> createEvents
