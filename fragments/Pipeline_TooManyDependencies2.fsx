let toAddress checkAddressExists endPoint credentials unvalidatedAddress = 
//                           only ^ needed ^ for checkAddressExists

  // call the remote service
  let checkedAddress = checkAddressExists endPoint credentials unvalidatedAddress 
  //                     2 extra parameters ^ passed in ^
  ...
