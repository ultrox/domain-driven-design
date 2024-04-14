let toPricedOrderLine orderLine = ...

let priceOrder : PriceOrder =
  fun getPricingFunction validatedOrder ->
    // get the pricing function from the getPricingFunction "factory"
    let getProductPrice = getPricingFunction validatedOrder.PricingMethod

    // set the price for each line
    let productOrderLines =
      validatedOrder.OrderLines
      |> List.map (toPricedOrderLine getProductPrice)

    // add the special comment line if needed
    let orderLines =
        match validatedOrder.PricingMethod with
        | Standard ->
          // unchanged
          productOrderLines
        | Promotion promotion ->
          let promoCode = promotion|> PromotionCode.value
          let commentLine = 
            sprintf "Applied promotion %s" promoCode
            |> CommentLine.create
            |> Comment // lift to PricedOrderLine
          List.append productOrderLines [commentLine]

    // return the new order
    {
        ...
        OrderLines = orderLines
    }
