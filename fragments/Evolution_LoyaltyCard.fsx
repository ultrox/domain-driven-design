type LoyaltyCardId = ...
type LoyaltyCardStatus =
  | None
  | LoyaltyCard of LoyaltyCardId

type CustomerInfo = {
  ...
  VipStatus : VipStatus
  LoyaltyCardStatus : LoyaltyCardStatus
  ...
  }
