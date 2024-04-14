let toDomain (dbRecord:ReadOneContact.Record) : Result<Contact,_> =
  result {
    let! contactId =
      dbRecord.ContactId
      |> ContactId.create

    let! contactInfo =
      if dbRecord.IsEmail then
        result {
          // get the primitive string which should not be NULL
          let! emailAddressString =
            dbRecord.EmailAddress
            |> Result.ofOption "Email expected to be non null"
          // create the EmailAddress simple type
          let! emailAddress =
            emailAddressString |> EmailAddress.create
          // lift to the Email case of Contact Info
          return (Email emailAddress)
          }
      else
        result {
          // get the primitive string which should not be NULL
          let! phoneNumberString =
            dbRecord.PhoneNumber
            |> Result.ofOption "PhoneNumber expected to be non null"
          // create the PhoneNumber simple type
          let! phoneNumber =
            phoneNumberString |> PhoneNumber.create
          // lift to the PhoneNumber case of Contact Info
          return (Phone phoneNumber)
          }

    let contact = {
      ContactId = contactId
      Info = contactInfo
      }
    return contact
    }
