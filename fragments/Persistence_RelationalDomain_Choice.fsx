type Contact = {
  ContactId : ContactId
  Info : ContactInfo 
  } 

and ContactInfo =
  | Email of EmailAddress
  | Phone of PhoneNumber

and EmailAddress = EmailAddress of string
and PhoneNumber = PhoneNumber of string
and ContactId = ContactId of int
