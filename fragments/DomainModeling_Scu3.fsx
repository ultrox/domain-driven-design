// define some types
type CustomerId = CustomerId of int
type OrderId = OrderId of int

// define some values
let customerId = CustomerId 42
let orderId = OrderId 42

// try to compare them -- compiler error!
printfn "%b" (orderId = customerId) 
//                      ^ This expression was expected to 
//                      have type 'OrderId'
