type CheckAddressExists = 
    UnvalidatedAddress -> Result<CheckedAddress,AddressValidationError>

and AddressValidationError = 
  | InvalidFormat of string
  | AddressNotFound of string
