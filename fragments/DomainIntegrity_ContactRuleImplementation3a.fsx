type BothContactMethods = {
  Email: EmailContactInfo
  Address : PostalContactInfo
  }

type ContactInfo = 
    | EmailOnly of EmailContactInfo
    | AddrOnly of PostalContactInfo
    | EmailAndAddr of BothContactMethods
