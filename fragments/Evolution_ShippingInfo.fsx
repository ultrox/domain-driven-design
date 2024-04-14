type ShippingMethod = 
  | PostalService 
  | Fedex24 
  | Fedex48 
  | Ups48

type ShippingInfo = {
  ShippingMethod : ShippingMethod
  ShippingCost : Price
  }

type PricedOrderWithShippingMethod = {
  ShippingInfo : ShippingInfo 
  PricedOrder : PricedOrder
  }
