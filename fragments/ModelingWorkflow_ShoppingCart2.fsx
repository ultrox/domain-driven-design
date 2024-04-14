let addItem cart item = 
  match cart with
  | EmptyCart -> 
    // create a new active cart with one item
    ActiveCart {UnpaidItems=[item]}

  | ActiveCart {UnpaidItems=existingItems} -> 
    // create a new ActiveCart with the item added
    ActiveCart {UnpaidItems = item :: existingItems}

  | PaidCart _ ->  
    // ignore
    cart
