// input to test with
let person : Domain.Person = {
  First = String50 "Alex"
  Last = String50 "Adams" 
  Birthdate = Birthdate (DateTime(1980,1,1))
  }

// use the serialization pipeline
jsonFromDomain person 

// The output is
// "{"First":"Alex","Last":"Adams","Birthdate":"1980-01-01T00:00:00"}"
