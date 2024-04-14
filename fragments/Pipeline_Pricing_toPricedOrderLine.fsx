/// Transform a ValidatedOrderLine to a PricedOrderLine
let toPricedOrderLine getProductPrice (line:ValidatedOrderLine) : PricedOrderLine =
  let qty = line.Quantity |> OrderQuantity.value 
  let price = line.ProductCode |> getProductPrice 
  let linePrice = price |> Price.multiply qty 
  {
    OrderLineId = line.OrderLineId 
    ProductCode = line.ProductCode
    Quantity = line.Quantity
    LinePrice = linePrice 
  }
