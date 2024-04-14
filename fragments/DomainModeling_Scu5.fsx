// construct
let customerId = CustomerId 42

// deconstruct
let (CustomerId innerValue) = customerId
//              ^ innerValue is set to 42

printfn "%i" innerValue  // prints "42"
