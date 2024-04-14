type PaymentMethod = 
  | Cash
  | Check of CheckNumber
  | Card of CreditCardInfo
