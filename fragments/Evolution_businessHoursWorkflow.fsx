let placeOrder unvalidatedOrder = 
    ...

let placeOrderInBusinessHours unvalidatedOrder = 
  let onError() = 
    Error OutsideBusinessHours
  let onSuccess() = 
    placeOrder unvalidatedOrder 
  let getHour() = DateTime.Now.Hour
  businessHoursOnly getHour onError onSuccess
