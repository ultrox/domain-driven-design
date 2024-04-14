type VipStatus =
  | Normal 
  | Vip 

type CustomerInfo = {
  ...
  VipStatus : VipStatus
  ...
  }
