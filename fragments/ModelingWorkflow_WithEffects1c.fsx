type ValidateOrder = 
  CheckProductCodeExists    // dependency
    -> CheckAddressExists   // AsyncResult dependency
    -> UnvalidatedOrder     // input
    -> AsyncResult<ValidatedOrder,ValidationError list>  // output
