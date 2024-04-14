type ValidateOrder = 
  CheckProductCodeExists    // explicit dependency
    -> CheckAddressExists   // explicit dependency
    -> UnvalidatedOrder     // input
    -> AsyncResult<ValidatedOrder,ValidationError list>  // output

type PriceOrder =  
  GetProductPrice                        // explicit dependency
    -> ValidatedOrder                    // input
    -> Result<PricedOrder,PricingError>  // output
