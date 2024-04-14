type PlaceOrderEvent = 
  | OrderPlaced of OrderPlaced
  | BillableOrderPlaced of BillableOrderPlaced 
  | AcknowledgmentSent  of OrderAcknowledgmentSent
