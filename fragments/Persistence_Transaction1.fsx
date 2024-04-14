let connection = new SqlConnection()
let transaction = connection.BeginTransaction()

// do two separate calls to the database
// in the same transaction
markAsFullyPaid connection invoiceId
markPaymentCompleted connection paymentId 

// completed
transaction.Commit() 
