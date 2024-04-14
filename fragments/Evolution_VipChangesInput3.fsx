let validateCustomerInfo unvalidatedCustomerInfo = 
  result {
    ...

    // new field
    let! vipStatus = 
      VipStatus.create unvalidatedCustomerInfo.VipStatus 

    let customerInfo : CustomerInfo = {
      ...
      VipStatus = vipStatus
      }
    return customerInfo
  }
