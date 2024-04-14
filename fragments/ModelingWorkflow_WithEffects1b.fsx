type CheckAddressExists = 
  UnvalidatedAddress -> AsyncResult<CheckedAddress,AddressValidationError>
