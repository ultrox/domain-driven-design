type PlaceOrderEvent = 
  | ShippableOrderPlaced of ShippableOrderPlaced
  | BillableOrderPlaced of BillableOrderPlaced 
  | AcknowledgmentSent  of OrderAcknowledgmentSent
