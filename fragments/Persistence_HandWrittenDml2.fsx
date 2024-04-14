let writeContact (productionConnection:SqlConnection) (contact:Contact) =

  // extract the primitive data from the domain object
  let contactId = contact.ContactId |> ContactId.value
  let isEmail,isPhone,emailAddress,phoneNumber = 
    match contact.Info with
    | Email emailAddress->
      let emailAddressString = emailAddress |> EmailAddress.value
      true,false,emailAddressString,null 
    | Phone phoneNumber ->
      let phoneNumberString = phoneNumber |> PhoneNumber.value
      false,true,null,phoneNumberString 

  // write to the DB
  use cmd = new InsertContact(productionConnection)
  cmd.Execute(contactId,isEmail,isPhone,emailAddress,phoneNumber)
