/// Update the shipping cost if customer is VIP
let freeVipShipping : FreeVipShipping =
  fun order -> 
    let updatedShippingInfo = 
      match order.VipStatus with
      | Normal -> 
        // untouched
        order.ShippingInfo
      | Vip -> 
        {order.ShippingInfo with 
          ShippingCost = 0.0
          ShippingMethod=Fedex24 }

    {order with ShippingInfo = updatedShippingInfo }
