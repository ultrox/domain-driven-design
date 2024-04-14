/// Serialize a Person into a JSON string
let jsonFromDomain (person:Domain.Person) = 
  person
  |> Dto.Person.fromDomain
  |> Json.serialize
