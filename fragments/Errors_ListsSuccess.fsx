type IntOrError = Result<int,string>

let listOfSuccesses : IntOrError list = [Ok 1; Ok 2]
let successResult = 
  Result.sequence listOfSuccesses   // Ok [1; 2]
