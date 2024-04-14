let toValidatedOrderLine checkProductCodeExists
(unvalidatedOrderLine:UnvalidatedOrderLine) = 
  let orderLineId =
    unvalidatedOrderLine.OrderLineId
    |> OrderLineId.create
  let productCode =
    unvalidatedOrderLine.ProductCode
    |> toProductCode checkProductCodeExists // helper function
  let quantity =
    unvalidatedOrderLine.Quantity
    |> toOrderQuantity productCode  // helper function
  let validatedOrderLine = {
    OrderLineId = orderLineId
    ProductCode = productCode
    Quantity = quantity
    }
  validatedOrderLine
