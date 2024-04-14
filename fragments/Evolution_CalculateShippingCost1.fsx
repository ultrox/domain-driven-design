/// Calculate the shipping cost for an order
let calculateShippingCost validatedOrder = 
  let shippingAddress = validatedOrder.ShippingAddress 
  if shippingAddress.Country = "US" then
    // shipping inside USA
    match shippingAddress.State with
    | "CA" | "OR" | "AZ" | "NV" -> 
      5.0 //local
    | _ -> 
      10.0 //remote
  else
    // shipping outside USA
    20.0
