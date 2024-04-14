let placeOrder unvalidatedOrder = 
  unvalidatedOrder
  |> validateOrderAdapted             // adapted version 
  |> Result.bind priceOrderAdapted // adapted version 
