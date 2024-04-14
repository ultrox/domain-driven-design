type DtoError =
  | ValidationError of string 
  | DeserializationException of exn

/// Deserialize a JSON string into a Person    
let jsonToDomain jsonString :Result<Domain.Person,DtoError> = 
  result {
    let! deserializedValue = 
      jsonString
      |> Json.deserialize 
      |> Result.mapError DeserializationException

    let! domainValue = 
      deserializedValue 
      |> Dto.Person.toDomain 
      |> Result.mapError ValidationError

    return domainValue
    }
