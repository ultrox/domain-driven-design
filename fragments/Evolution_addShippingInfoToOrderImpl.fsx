let addShippingInfoToOrder calculateShippingCost : AddShippingInfoToOrder  =
  fun pricedOrder ->
    // create the shipping info
    let shippingInfo = {
      ShippingMethod = ...
      ShippingCost = calculateShippingCost pricedOrder 
      }

    // add it to the order
    {
    OrderId = pricedOrder.OrderId
    ...
    ShippingInfo = shippingInfo
    }
