let placeOrder unvalidatedOrder = 
  unvalidatedOrder 
  |> validateOrderAdapted
  |> Result.bind priceOrderAdapted
  |> Result.map acknowledgeOrder   // use map to convert to two-track
  |> Result.map createEvents       // convert to two-track
