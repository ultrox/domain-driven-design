// Info for the unpaid case (without id)
type UnpaidInvoiceInfo = ...  

// Info for the paid case (without id)
type PaidInvoiceInfo = ... 

// Combined information (without id)
type InvoiceInfo = 
  | Unpaid of UnpaidInvoiceInfo
  | Paid of PaidInvoiceInfo

// Id for invoice
type InvoiceId = ...  

// Top level invoice type   
type Invoice = {
  InvoiceId : InvoiceId // "outside" the two child cases
  InvoiceInfo : InvoiceInfo
  }
