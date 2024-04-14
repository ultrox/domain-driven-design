// Adapted to return a PlaceOrderError
let validateOrderAdapted input = 
  input 
  |> validateOrder // the original function
  |> Result.mapError PlaceOrderError.Validation

// Adapted to return a PlaceOrderError
let priceOrderAdapted input = 
  input 
  |> priceOrder // the original function
  |> Result.mapError PlaceOrderError.Pricing
