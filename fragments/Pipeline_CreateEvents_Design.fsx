/// Event to send to shipping context
type OrderPlaced = PricedOrder

/// Event to send to billing context
/// Will only be created if the AmountToBill is not zero
type BillableOrderPlaced = {
    OrderId : OrderId
    BillingAddress: Address
    AmountToBill : BillingAmount
    }

type PlaceOrderEvent = 
    | OrderPlaced of OrderPlaced
    | BillableOrderPlaced of BillableOrderPlaced 
    | AcknowledgmentSent  of OrderAcknowledgmentSent

type CreateEvents = 
  PricedOrder                            // input
    -> OrderAcknowledgmentSent option    // input (event from previous step)
    -> PlaceOrderEvent list              // output
