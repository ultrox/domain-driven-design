type PlaceOrderError = 
  | Validation of ValidationError 
  ...
  | OutsideBusinessHours  //new!
