let predicateToPassthru errorMsg f x =
  if f x then  
    x
  else  
    failwith errorMsg 
