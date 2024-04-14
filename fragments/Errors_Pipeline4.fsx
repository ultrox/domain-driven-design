type PlaceOrderError = 
  | Validation of ValidationError
  | Pricing of PricingError 
