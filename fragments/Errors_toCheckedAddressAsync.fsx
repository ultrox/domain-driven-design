/// Call the checkAddressExists and convert the error to a ValidationError
let toCheckedAddress (checkAddress:CheckAddressExists) address =
  address 
  |> checkAddress 
  |> AsyncResult.mapError (fun addrError -> 
    match addrError with
    | AddressNotFound -> ValidationError "Address not found"
    | InvalidFormat -> ValidationError "Address has bad format"
    )
