type InsertContact = SqlCommandProvider<"""
  INSERT INTO ContactInfo
  VALUES (@ContactId,@IsEmail,@IsPhone,@EmailAddress,@PhoneNumber)
  """, CompileTimeConnectionString>
