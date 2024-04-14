let adderGenerator numberToAdd = 
  // define a nested inner function
  let innerFn x =
    numberToAdd + x 

  // return the inner function
  innerFn 
