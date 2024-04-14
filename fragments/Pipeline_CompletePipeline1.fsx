module PlaceOrderWorkflow =

  // make the shared simple types (such as 
  // String50 and ProductCode) available.
  open SimpleTypes    

  // make the public types exposed to the
  // callers available
  open API 

  // ==============================
  // Part 1: Design
  // ==============================

  // NOTE: the public parts of the workflow -- the API -- 
  // such as the `PlaceOrderWorkflow` function and its
  // input `UnvalidatedOrder`, are defined elsewhere.
  // The types below are private to the workflow implementation.

  // ----- Validate Order ----- 

  type CheckProductCodeExists = 
    ProductCode -> bool
  type CheckedAddress = 
    CheckedAddress of UnvalidatedAddress
  type CheckAddressExists = 
    UnvalidatedAddress -> CheckedAddress
  type ValidateOrder = 
    CheckProductCodeExists    // dependency
      -> CheckAddressExists   // dependency
      -> UnvalidatedOrder     // input
      -> ValidatedOrder       // output


  // ----- Price order ----- 

  type GetProductPrice = ...
  type PriceOrder = ...
  // etc
