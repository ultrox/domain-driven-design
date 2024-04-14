type OrderPlaced = PricedOrder
type BillableOrderPlaced = {
  OrderId : OrderId
  BillingAddress: Address
  AmountToBill : BillingAmount
  }
