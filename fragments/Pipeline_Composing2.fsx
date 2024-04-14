let validateOrderWithDependenciesBakedIn = 
  validateOrder checkProductCodeExists checkAddressExists

// new function signature after partial application:    
// UnvalidatedOrder -> ValidatedOrder       
