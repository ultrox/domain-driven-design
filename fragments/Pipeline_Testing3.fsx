[<Test>]
let ``If product doesn't exist, validation fails``() =
  // arrange: set up stub versions of service dependencies
  let checkAddressExists address = ...
  let checkProductCodeExists productCode = 
    false // fail

  // arrange: set up input       
  let unvalidatedOrder = ...

  // act: call validateOrder
  let result = validateOrder checkProductCodeExists checkAddressExists ...

  // assert: check that result is a failure
  ...
