// define a function using a CustomerId
let processCustomerId (id:CustomerId) = ...

// call it with an OrderId -- compiler error!
processCustomerId orderId
//                ^ This expression was expected to 
//                have type 'CustomerId' but here has 
//                type 'OrderId'    
