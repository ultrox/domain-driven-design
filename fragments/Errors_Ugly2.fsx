let validateOrder unvalidatedOrder =
  let orderIdResult = ... create order id (or return Error)
  if orderIdResult is Error then
      return

  let customerInfoResult = ... create name (or return Error)
  if customerInfoResult is Error then
      return

  try    
      let shippingAddressResult = ... create valid address (or return Error)
      if shippingAddress is Error then
        return

      // ...

  with
    | ?: TimeoutException -> Error "service timed out"
    | ?: AuthenticationException -> Error "bad credentials"

  // etc
