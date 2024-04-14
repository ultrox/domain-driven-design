let placeOrder unvalidatedOrder = 
  unvalidatedOrder 
  |> validateOrderAdapted
  |> Result.bind priceOrderAdapted
  |> Result.map acknowledgeOrder   
  |> Result.map createEvents       
