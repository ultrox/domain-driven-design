let predicateToPassthru f x =
  if f x then  
    x
  else  
    failwith "Invalid Product Code"
