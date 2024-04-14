// do first call
markAsFullyPaid connection invoiceId
// do second call
let result = markPaymentCompleted connection paymentId 

// if second call fails, do compensating transaction
match result with
| Error err -> 
  // compensate for error
  unmarkAsFullyPaid connection invoiceId
| Ok _ -> ...
