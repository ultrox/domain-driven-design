type PayInvoice = 
  UnpaidInvoice -> Payment -> Result<PaidInvoice,PaymentError>
