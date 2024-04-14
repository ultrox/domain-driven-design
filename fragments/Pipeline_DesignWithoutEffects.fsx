type CheckAddressExists = 
  UnvalidatedAddress -> CheckedAddress

type ValidateOrder = 
  CheckProductCodeExists    // dependency
    -> CheckAddressExists   // dependency
    -> UnvalidatedOrder     // input
    -> ValidatedOrder       // output
