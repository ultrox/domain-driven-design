// command handler at the edge of the bounded context
let payInvoice 
  loadUnpaidInvoiceFromDatabase // dependency
  markAsFullyPaidInDb           // dependency
  updateInvoiceInDb             // dependency
  payInvoiceCommand =

  // load from DB
  let invoiceId = payInvoiceCommand.InvoiceId
  let unpaidInvoice = 
    loadUnpaidInvoiceFromDatabase invoiceId 

  // call into pure domain
  let payment = 
    payInvoiceCommand.Payment
  let paymentResult = 
    applyPayment unpaidInvoice payment

  // handle result
  match paymentResult with
  | FullyPaid ->
    markAsFullyPaidInDb(invoiceId)
    postInvoicePaidEvent(invoiceId)
  | PartiallyPaid updatedInvoice ->
    updateInvoiceInDb updatedInvoice   
