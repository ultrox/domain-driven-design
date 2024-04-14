let nameDtoToDomain (nameDto:NameDto) :Result<Name,string> =
    result {
      let! first = nameDto.First |> String50.create 
      let! last = nameDto.Last |> String50.create  
      return {First=first; Last=last}
    }

let toDomain dto : Result<Example,string> =
  match dto.Tag with
    | "A" -> 
      Ok A 
    | "B" -> 
      if dto.BData.HasValue then
        dto.BData.Value |> B |> Ok
      else
        Error "B data not expected to be null"
    | "C" -> 
      match dto.CData with
      | null -> 
        Error "C data not expected to be null"
      | _ -> 
        dto.CData |> Array.toList |> C |> Ok 
    | "D" -> 
      match box dto.DData with
      | null -> 
        Error "D data not expected to be null"
      | _ -> 
        dto.DData 
        |> nameDtoToDomain  // returns Result...
        |> Result.map D     // ...so must use "map"
    | _ ->
      // all other cases
      let msg = sprintf "Tag '%s' not recognized" dto.Tag 
      Error msg
