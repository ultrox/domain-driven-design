module rec Payments = 
  type Payment = {
    Amount: ...
    Currency: ...
    Method: PaymentMethod  // defined BELOW
    }

  type PaymentMethod = 
    | Cash
    | Check of CheckNumber // defined BELOW
    | Card of ...

  type CheckNumber = CheckNumber of int
