/// "Adapter block" that converts exception-throwing services
/// into Result-returning services.
let serviceExceptionAdapter serviceInfo serviceFn x =
  try 
    // call the service and return success
    Ok (serviceFn x)
  with
  | :? TimeoutException as ex ->
    Error {Service=serviceInfo; Exception=ex} 
  | :? AuthorizationException as ex ->
    Error {Service=serviceInfo; Exception=ex} 
