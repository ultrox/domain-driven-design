let writeContact (productionConnection:SqlConnection) (contact:Contact) =

  // extract the primitive data from the domain object
  let contactId = contact.ContactId |> ContactId.value
  let isEmail,isPhone,emailAddressOpt,phoneNumberOpt = 
    match contact.Info with
    | Email emailAddress->
      let emailAddressString = emailAddress |> EmailAddress.value
      true,false,Some emailAddressString,None
    | Phone phoneNumber ->
      let phoneNumberString = phoneNumber |> PhoneNumber.value
      false,true,None,Some phoneNumberString  

  // create a new row
  let contactInfoTable = new Db.dbo.Tables.ContactInfo()
  let newRow = contactInfoTable.NewRow() 
  newRow.ContactId <- contactId
  newRow.IsEmail <- isEmail
  newRow.IsPhone <- isPhone
  // use optional types to map to NULL in the database
  newRow.EmailAddress <- emailAddressOpt  
  newRow.PhoneNumber <- phoneNumberOpt

  // add to table
  contactInfoTable.Rows.Add newRow

  // push changes to the database
  let recordsAffected = contactInfoTable.Update(productionConnection)
  recordsAffected 
