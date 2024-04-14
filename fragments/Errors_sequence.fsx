let sequence aListOfResults = 
  let initialValue = Ok [] // empty list inside Result

  // loop through the list in reverse order,
  // prepending each element to the initial value
  List.foldBack prepend aListOfResults initialValue
