type InvoicePaymentResult = 
  | FullyPaid 
  | PartiallyPaid of ...

// domain workflow: pure function
let applyPayment unpaidInvoice payment :InvoicePaymentResult =
  // apply payment
  let updatedInvoice = unpaidInvoice |> applyPayment payment

  // handle different outcomes
  if isFullyPaid updatedInvoice then
    FullyPaid 
  else
    PartiallyPaid updatedInvoice 
  // return PartiallyPaid or FullyPaid
