let convertToPassthru checkProductCodeExists productCode =
  if checkProductCodeExists productCode then  
    productCode
  else  
    failwith "Invalid Product Code"
