/// We pass in three parameters: 
/// * the top-level order
/// * the id of the order line we want to change
/// * the new price
let changeOrderLinePrice order orderLineId newPrice =

  // find orderLine in order.OrderLines using orderLineId   
  let orderLine = order.OrderLines |> findOrderLine orderLineId 

  // make a new version of the OrderLine with new price
  let newOrderLine = {orderLine with Price = newPrice}                  

  // create new list of lines, replacing old line with new line   
  let newOrderLines = 
    order.OrderLines |> replaceOrderLine orderLineId newOrderLine

  // make a new AmountToBill
  let newAmountToBill = newOrderLines |> List.sumBy (fun line -> line.Price)

  // make a new version of the order with the new lines
  let newOrder = {
      order with 
        OrderLines = newOrderLines
        AmountToBill = newAmountToBill
      }

  // return the new order
  newOrder
