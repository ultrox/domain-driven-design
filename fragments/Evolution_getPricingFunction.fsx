type GetStandardPriceTable = 
  // no input -> return standard prices
  unit -> IDictionary<ProductCode,Price>

type GetPromotionPriceTable = 
  // promo input -> return prices for promo
  PromotionCode -> IDictionary<ProductCode,Price>

let getPricingFunction 
  (standardPrices:GetStandardPriceTable) 
  (promoPrices:GetPromotionPriceTable)  
  : GetPricingFunction = 


  // the original pricing function
  let getStandardPrice : GetProductPrice =
    // cache the standard prices		
    let standardPrices = standardPrices()
    // return the lookup function
    fun productCode -> standardPrices.[productCode] 

  // the promotional pricing function
  let getPromotionPrice promotionCode : GetProductPrice =
    // cache the promotional prices
    let promotionPrices = promoPrices promotionCode
    // return the lookup function
    fun productCode ->
      match promotionPrices.TryGetValue productCode with
      // found in promotional prices
      | true,price -> price 
      // not found in promotional prices
      // so use standard price
      | false, _ -> getStandardPrice productCode

  // return a function that conforms to GetPricingFunction
  fun pricingMethod ->
    match pricingMethod with
    | Standard -> 
      getStandardPrice
    | Promotion promotionCode -> 
      getPromotionPrice promotionCode 
