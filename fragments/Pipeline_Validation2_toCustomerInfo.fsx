let toCustomerInfo (customer:UnvalidatedCustomerInfo) : CustomerInfo = 
  // create the various CustomerInfo properties
  // and throw exceptions if invalid
  let firstName = customer.FirstName |> String50.create 
  let lastName = customer.LastName |> String50.create 
  let emailAddress = customer.EmailAddress |> EmailAddress.create 

  // create a PersonalName 
  let name : PersonalName = {
    FirstName = firstName 
    LastName = lastName
    }

  // create a CustomerInfo
  let customerInfo : CustomerInfo = {
    Name = name 
    EmailAddress = emailAddress
    }
  // ... and return it
  customerInfo    
