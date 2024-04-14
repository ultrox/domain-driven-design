let toDomain (dto:Dto.Person) :Result<Domain.Person,string> =
  result {
    // get each (validated) simple type from the DTO as a success or failure 
    let! first = dto.First |> String50.create "First"
    let! last = dto.Last |> String50.create "Last"
    let! birthdate = dto.Birthdate |> Birthdate.create

    // combine the components to create the domain object
    return {
      First = first
      Last = last
      Birthdate = birthdate
    }
  }

