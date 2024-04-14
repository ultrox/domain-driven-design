// compiler error 
fiveKilos = fiveMeters   
//          ^ Expecting a float<kg> but given a float<m> 

let listOfWeights = [
  fiveKilos
  fiveMeters  // <-- compiler error
  //             The unit of measure 'kg' 
  //             does not match the unit of measure 'm'
  ]
