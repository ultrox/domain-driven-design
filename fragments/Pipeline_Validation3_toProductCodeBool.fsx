let toProductCode (checkProductCodeExists:CheckProductCodeExists) productCode = 
  productCode
  |> ProductCode.create
  |> checkProductCodeExists 
  // returns a bool :(
