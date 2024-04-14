// helper function
let toValidatedOrderLine checkProductExists unvalidatedOrderLine = 
//                       ^ needed for toProductCode, below

  // create the components of the line
  let orderLineId = ...
  let productCode = 
    unvalidatedOrderLine.ProductCode 
    |> toProductCode checkProductExists //use service

  ...
