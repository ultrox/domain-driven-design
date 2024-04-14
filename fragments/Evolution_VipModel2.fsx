type CustomerStatus =
  | Normal of CustomerInfo
  | Vip of CustomerInfo

type Order = {
  ...
  CustomerStatus : CustomerStatus
  ...
  }
