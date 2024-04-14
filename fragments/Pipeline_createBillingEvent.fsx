// PricedOrder -> BillableOrderPlaced option 
let createBillingEvent (placedOrder:PricedOrder) : BillableOrderPlaced option =
  let billingAmount = placedOrder.AmountToBill |> BillingAmount.value
  if billingAmount > 0M then
    let order = {
      OrderId = placedOrder.OrderId
      BillingAddress = placedOrder.BillingAddress
      AmountToBill = placedOrder.AmountToBill 
    }
    Some order 
  else
    None
