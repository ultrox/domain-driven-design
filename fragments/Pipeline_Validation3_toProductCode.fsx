let toProductCode (checkProductCodeExists:CheckProductCodeExists) productCode = 

  // create a local ProductCode -> ProductCode function 
  // suitable for using in a pipeline
  let checkProduct productCode = 
    let errorMsg = sprintf "Invalid: %A" productCode 
    predicateToPassthru errorMsg checkProductCodeExists productCode

  // assemble the pipeline        
  productCode
  |> ProductCode.create
  |> checkProduct 
