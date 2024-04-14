let toAddress (checkAddressExists:CheckAddressExists) unvalidatedAddress =
  // call the remote service
  let checkedAddress = checkAddressExists unvalidatedAddress 
  // extract the inner value using pattern matching
  let (CheckedAddress checkedAddress) = checkedAddress 

  let addressLine1 = 
    checkedAddress.AddressLine1 |> String50.create
  let addressLine2 = 
    checkedAddress.AddressLine2 |> String50.createOption
  let addressLine3 = 
    checkedAddress.AddressLine3 |> String50.createOption
  let addressLine4 = 
    checkedAddress.AddressLine4 |> String50.createOption
  let city = 
    checkedAddress.City |> String50.create
  let zipCode = 
    checkedAddress.ZipCode |> ZipCode.create
  // create the address
  let address : Address = {
    AddressLine1 = addressLine1
    AddressLine2 = addressLine2
    AddressLine3 = addressLine3
    AddressLine4 = addressLine4
    City = city
    ZipCode = zipCode
    }
  // return the address
  address
