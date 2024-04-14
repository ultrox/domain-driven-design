let makePayment cart payment = 
  match cart with
  | EmptyCart -> 
    // ignore
    cart

  | ActiveCart {UnpaidItems=existingItems} -> 
    // create a new PaidCart with the payment
    PaidCart {PaidItems = existingItems; Payment=payment}

  | PaidCart _ ->  
    // ignore
    cart
