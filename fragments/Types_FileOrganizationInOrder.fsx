module Payments = 
  // simple types at the top of the file
  type CheckNumber = CheckNumber of int

  // domain types in the middle of the file
  type PaymentMethod =
    | Cash
    | Check of CheckNumber // defined above
    | Card of ...

  // top-level types at the bottom of the file
  type Payment = {
    Amount: ...
    Currency: ...
    Method: PaymentMethod  // defined above
    }
