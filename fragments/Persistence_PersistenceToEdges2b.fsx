type PayInvoiceCommand = {
  InvoiceId : ...
  Payment : ...
  }

// command handler at the edge of the bounded context
let payInvoice payInvoiceCommand =
  // load from DB
  let invoiceId = payInvoiceCommand.InvoiceId           
  let unpaidInvoice = 
    loadInvoiceFromDatabase invoiceId  // I/O

  // call into pure domain
  let payment = 
    payInvoiceCommand.Payment          // pure
  let paymentResult = 
    applyPayment unpaidInvoice payment // pure

  // handle result
  match paymentResult with
  | FullyPaid ->
    markAsFullyPaidInDb invoiceId      // I/O
    postInvoicePaidEvent invoiceId     // I/O  
  | PartiallyPaid updatedInvoice ->
    updateInvoiceInDb updatedInvoice   // I/O 
