// workflow mixes domain logic and I/O
let payInvoice invoiceId payment =
  // load from DB
  let invoice = loadInvoiceFromDatabase(invoiceId)

  // apply payment
  invoice.ApplyPayment(payment)

  // handle different outcomes
  if invoice.IsFullyPaid then
    markAsFullyPaidInDb(invoiceId)
    postInvoicePaidEvent(invoiceId)
  else
    markAsPartiallyPaidInDb(invoiceId)
