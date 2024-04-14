module Dto = 

  module Person =
    let fromDomain (person:Domain.Person) :Dto.Person = 
      ...

    let toDomain (dto:Dto.Person) :Result<Domain.Person,string> =
      ...
