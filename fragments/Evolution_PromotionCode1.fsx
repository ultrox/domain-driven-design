type PromotionCode = PromotionCode of string

type ValidatedOrder = {
  ... 
  PromotionCode : PromotionCode option
  }
