/// We pass in three parameters: 
/// * the top-level order
/// * the id of the order line we want to change
/// * the new price
let changeOrderLinePrice order orderLineId newPrice =

  // 1. find the line to change using the orderLineId   
  let orderLine = order.OrderLines |> findOrderLine orderLineId 

  // 2. make a new version of the OrderLine with the new price
  let newOrderLine = {orderLine with Price = newPrice}                  

  // 3. create a new list of lines, replacing 
  //    the old line with the new line   
  let newOrderLines = 
    order.OrderLines |> replaceOrderLine orderLineId newOrderLine

  // 4. make a new version of the entire order, replacing
  //    all the old lines with the new lines
  let newOrder = {order with OrderLines = newOrderLines}                  

  // 5. return the new order
  newOrder
