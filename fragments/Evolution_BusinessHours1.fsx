/// Determine the business hours
let isBusinessHour hour = 
  hour >= 9 && hour <= 17 

/// tranformer
let businessHoursOnly getHour onError onSuccess = 
  let hour = getHour()
  if isBusinessHour hour then
    onSuccess()
  else
    onError()
