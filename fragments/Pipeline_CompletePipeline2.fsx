// ==============================
// Part 2: Implementation 
// ==============================

// ------------------------------
// ValidateOrder implementation
// ------------------------------

let toCustomerInfo (unvalidatedCustomerInfo: UnvalidatedCustomerInfo) = 
  ...

let toAddress (checkAddressExists:CheckAddressExists) unvalidatedAddress =
  ...

let predicateToPassthru = ...

let toProductCode (checkProductCodeExists:CheckProductCodeExists) productCode = 
  ...

let toOrderQuantity productCode quantity = 
  ...

let toValidatedOrderLine checkProductExists (unvalidatedOrderLine:UnvalidatedOrderLine) = 
  ...

/// Implementation of ValidateOrder step
let validateOrder : ValidateOrder = 
  fun checkProductCodeExists checkAddressExists unvalidatedOrder ->
    let orderId = 
      unvalidatedOrder.OrderId 
      |> OrderId.create
    let customerInfo = ...
    let shippingAddress = ...
    let billingAddress = ...
    let lines = 
      unvalidatedOrder.Lines 
      |> List.map (toValidatedOrderLine checkProductCodeExists) 
    let validatedOrder : ValidatedOrder = {
      OrderId  = orderId 
      CustomerInfo = customerInfo 
      ShippingAddress = shippingAddress 
      BillingAddress = billingAddress  
      Lines = lines 
    }
    validatedOrder 
