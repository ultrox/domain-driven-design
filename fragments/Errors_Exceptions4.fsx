let serviceInfo = {
  Name = "AddressCheckingService"
  Endpoint = ...
  }

// exception-throwing service 
let checkAddressExists address = 
    ...

// Result-returning service 
let checkAddressExistsR address = 
    // adapt the service 
    let adaptedService =
      serviceExceptionAdapter serviceInfo checkAddressExists
    // call the service
    adaptedService address
