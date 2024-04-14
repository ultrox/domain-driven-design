type ValidateOrder = 
  UnvalidatedOrder -> Result<ValidatedOrder,ValidationError list>

and ValidationError = { 
  FieldName : string
  ErrorDescription : string
  }
