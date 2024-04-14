type PricedOrderLine = 
  | Product of PricedOrderProductLine
  | ShippingInfo of ShippingInfo
