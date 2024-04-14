type PlaceOrderError = 
  | Validation of ValidationError
  | Pricing of PricingError
  | RemoteService of RemoteServiceError // new!
