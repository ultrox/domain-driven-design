let workflowWithSerialization jsonString = 
  jsonString
  |> deserializeInputDto   // JSON to DTO
  |> inputDtoToDomain      // DTO to domain object
  |> workflow              // the core workflow in the domain
  |> outputDtoFromDomain   // Domain object to DTO
  |> serializeOutputDto    // DTO to JSON
  // final output is another JsonString
