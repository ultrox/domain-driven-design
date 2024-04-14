type AddressValidationError = AddressValidationError of string

type CheckAddressExists = 
  UnvalidatedAddress -> Result<CheckedAddress,AddressValidationError>
  // ^input                    ^output
