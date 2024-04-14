let toDomain (dto:IDictionary<string,obj>) : Result<Example,string> =
  if dto.ContainsKey "A" then
    Ok A    // no extra data needed
  elif dto.ContainsKey "B" then
    result {
      let! bData = dto |> getValue "B" // might fail
      return B bData 
      }
  elif dto.ContainsKey "C" then
    result {
      let! cData = dto |> getValue "C" // might fail 
      return cData |> Array.toList |> C 
      }
  elif dto.ContainsKey "D" then
    result {
      let! dData = dto |> getValue "D" // might fail 
      let! name = dData |> nameDtoToDomain  // might also fail
      return name |> D
      }
  else
    // all other cases
    let msg = sprintf "No union case recognized" 
    Error msg
