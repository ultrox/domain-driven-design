type CommentLine = CommentLine of string

type PricedOrderLine = 
  | Product of PricedOrderProductLine
  | Comment of CommentLine
