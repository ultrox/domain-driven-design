// ----------------------
// Public API
// ----------------------

/// Success output of PlaceOrder workflow
type OrderPlaced = ...
type BillableOrderPlaced = ...
type OrderAcknowledgmentSent = ...
type PlaceOrderEvent =
    | OrderPlaced of OrderPlaced
    | BillableOrderPlaced of BillableOrderPlaced 
    | AcknowledgmentSent  of OrderAcknowledgmentSent

/// Failure output of PlaceOrder workflow
type PlaceOrderError = ...

type PlaceOrderWorkflow = 
  PlaceOrderCommand                                      // input command
    -> AsyncResult<PlaceOrderEvent list,PlaceOrderError> // output events
