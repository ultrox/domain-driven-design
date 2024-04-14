type OrderTakingCommand = 
  | Place of PlaceOrder
  | Change of ChangeOrder 
  | Cancel of CancelOrder
