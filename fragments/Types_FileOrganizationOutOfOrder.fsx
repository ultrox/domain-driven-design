type Payment = {
    Amount: ...
    Currency:  ...
    Method:  PaymentMethod // defined BELOW
    }

and PaymentMethod = 
  | Cash
  | Check of CheckNumber   // defined BELOW
  | Card of ...

and CheckNumber = CheckNumber of int
