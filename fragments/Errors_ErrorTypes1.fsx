type PlaceOrderError =
  | ValidationError of string
  | ProductOutOfStock of ProductCode
  | RemoteServiceError of RemoteServiceError
  ...
