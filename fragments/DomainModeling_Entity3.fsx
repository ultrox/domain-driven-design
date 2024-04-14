type UnpaidInvoice = {
  InvoiceId : InvoiceId // id stored "inside" 
  // and other info for the unpaid case
  }

type PaidInvoice = {
  InvoiceId : InvoiceId // id stored "inside" 
  // and other info for the paid case
  }

// top level invoice type      
type Invoice = 
  | Unpaid of UnpaidInvoice
  | Paid of PaidInvoice
