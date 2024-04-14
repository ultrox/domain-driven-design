type ValidateOrder = 
  // ignoring additional dependencies for now
  UnvalidatedOrder                             // input
    -> Result<ValidatedOrder, ValidationError> // output
