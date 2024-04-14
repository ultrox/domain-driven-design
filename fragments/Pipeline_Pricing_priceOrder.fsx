let priceOrder : PriceOrder = 
  fun getProductPrice validatedOrder -> 
    let lines = 
      validatedOrder.Lines 
      |> List.map (toPricedOrderLine getProductPrice) 
    let amountToBill = 
      lines 
      // get each line price
      |> List.map (fun line -> line.LinePrice)  
      // add them together as a BillingAmount
      |> BillingAmount.sumPrices  
    let pricedOrder : PricedOrder = {
      OrderId  = validatedOrder.OrderId 
      CustomerInfo = validatedOrder.CustomerInfo 
      ShippingAddress = validatedOrder.ShippingAddress 
      BillingAddress = validatedOrder.BillingAddress  
      Lines = lines 
      AmountToBill = amountToBill 
      }
    pricedOrder 
