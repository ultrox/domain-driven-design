let invoice = Paid {InvoiceId = ...}

match invoice with
  | Unpaid unpaidInvoice ->
    printfn "The unpaid invoiceId is %A" unpaidInvoice.InvoiceId
  | Paid paidInvoice ->
    printfn "The paid invoiceId is %A" paidInvoice.InvoiceId
