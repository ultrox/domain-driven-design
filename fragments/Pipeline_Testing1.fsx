open NUnit.Framework

[<Test>]
let ``If product exists, validation succeeds``() =
  // arrange: set up stub versions of service dependencies
  let checkAddressExists address = 
    CheckedAddress address // succeed 
  let checkProductCodeExists productCode = 
    true                   // succeed

  // arrange: set up input       
  let unvalidatedOrder = ...

  // act: call validateOrder
  let result = validateOrder checkProductCodeExists checkAddressExists ...

  // assert: check that result is a ValidatedOrder, not an error
  ...
