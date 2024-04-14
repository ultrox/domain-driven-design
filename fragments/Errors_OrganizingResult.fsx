/// Define the Result type
type Result<'Success,'Failure> = 
    | Ok of 'Success
    | Error of 'Failure

/// Functions that work with Result   
module Result = 

  let bind f aResult = ...

  let map f aResult = ...
