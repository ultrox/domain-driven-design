type PlaceOrderError =
  | ValidationError of ValidationError list
  | ...  // other errors

and ValidationError = { 
    FieldName : string
    ErrorDescription : string
    }
