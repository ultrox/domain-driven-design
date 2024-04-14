type ValidateOrder = 
  CheckProductCodeExists    // dependency
    -> CheckAddressExists   // dependency
    -> UnvalidatedOrder     // input
    -> Result<ValidatedOrder,ValidationError>  // output
