let nameDtoToDomain (nameDto:IDictionary<string,obj>) :Result<Name,string> =
  result {
    let! firstStr = nameDto |> getValue "First"
    let! first = firstStr |> String50.create 
    let! lastStr = nameDto |> getValue "Last"
    let! last = lastStr |> String50.create 
    return {First=first; Last=last}
  }
