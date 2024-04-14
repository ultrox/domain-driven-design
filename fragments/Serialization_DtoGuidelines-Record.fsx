/// Domain types
type OrderLineId = OrderLineId of int
type OrderLineQty = OrderLineQty of int
type OrderLine = {
  OrderLineId : OrderLineId
  ProductCode : ProductCode
  Quantity : OrderLineQty option
  Description : string option
  }

/// Corresponding DTO type 
type OrderLineDto = {
  OrderLineId : int
  ProductCode : string
  Quantity : Nullable<int>
  Description : string 
  }
