type ReadOneContact = SqlCommandProvider<"""
  SELECT ContactId,IsEmail,IsPhone,EmailAddress,PhoneNumber
  FROM ContactInfo
  WHERE ContactId = @contactId
  """, CompileTimeConnectionString>
