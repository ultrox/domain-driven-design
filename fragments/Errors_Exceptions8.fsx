let checkAddressExistsR address = 
  // adapt the service 
  let adaptedService =
    serviceExceptionAdapter serviceInfo checkAddressExists   
  // call the service
  address
  |> adaptedService 
  |> Result.mapError RemoteService // lift to PlaceOrderError
