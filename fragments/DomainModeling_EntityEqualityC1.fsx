[<NoEquality;NoComparison>]
type OrderLine = {
  OrderId : OrderId
  ProductId : ProductId
  Qty : int
  }
  with 
  member this.Key = 
    (this.OrderId,this.ProductId)
