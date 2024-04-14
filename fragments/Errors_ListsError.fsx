let listOfErrors : IntOrError list = [ Error "bad"; Error "terrible" ]

let errorResult = 
  Result.sequence listOfErrors  // Error "bad"
