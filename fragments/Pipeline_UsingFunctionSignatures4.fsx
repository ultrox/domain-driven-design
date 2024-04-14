let validateOrder : ValidateOrder = 
  fun checkProductCodeExists checkAddressExists unvalidatedOrder -> 
    if checkProductCodeExists 42 then
      //       compiler error ^ 
      // This expression was expected to have type ProductCode
      // but here has type int    
      ...
    ...
