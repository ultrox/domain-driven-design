type CustomerEmail = 
  | Unverified of EmailAddress 
  | Verified of VerifiedEmailAddress // different from normal EmailAddress
