let nameDtoFromDomain (name:Name) :NameDto =
    let first = name.First |> String50.value
    let last = name.Last |> String50.value
    {First=first; Last=last}

let fromDomain (domainObj:Example) :ExampleDto =
  let nullBData = Nullable()
  let nullCData = null
  let nullDData = Unchecked.defaultof<NameDto>
  match domainObj with
  | A -> 
      {Tag="A"; BData=nullBData; CData=nullCData; DData=nullDData}
  | B i ->
      let bdata = Nullable i
      {Tag="B"; BData=bdata; CData=nullCData; DData=nullDData}
  | C strList -> 
      let cdata = strList |> List.toArray
      {Tag="C"; BData=nullBData; CData=cdata; DData=nullDData}
  | D name -> 
      let ddata = name |> nameDtoFromDomain
      {Tag="D"; BData=nullBData; CData=nullCData; DData=ddata}
