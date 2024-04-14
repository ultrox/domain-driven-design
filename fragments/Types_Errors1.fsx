type Result<'Success,'Failure> = 
  | Ok of 'Success 
  | Error of 'Failure
