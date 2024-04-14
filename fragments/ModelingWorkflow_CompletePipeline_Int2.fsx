// ----------------------
// Definitions of Internal Steps
// ----------------------

// ----- Validate order ----- 

// services used by ValidateOrder
type CheckProductCodeExists = 
  ProductCode -> bool

type AddressValidationError = ...
type CheckedAddress = ...
type CheckAddressExists = 
  UnvalidatedAddress 
    -> AsyncResult<CheckedAddress,AddressValidationError>

type ValidateOrder = 
  CheckProductCodeExists    // dependency
    -> CheckAddressExists   // dependency
    -> UnvalidatedOrder     // input
    -> AsyncResult<ValidatedOrder,ValidationError list>  // output
and ValidationError = ...

// ----- Price order ----- 

// services used by PriceOrder
type GetProductPrice = 
  ProductCode -> Price

type PricingError = ...

type PriceOrder = 
  GetProductPrice      // dependency
    -> ValidatedOrder  // input
    -> Result<PricedOrder,PricingError>  // output

// etc
