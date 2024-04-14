let fromDomain (person:Domain.Person) :Dto.Person =
  // get the primitive values from the domain object
  let first = person.First |> String50.value
  let last = person.Last |> String50.value
  let birthdate = person.Birthdate |> Birthdate.value 

  // combine the components to create the DTO
  {First = first; Last = last; Birthdate = birthdate}
