let nameDtoFromDomain (name:Name) :IDictionary<string,obj> =
  let first = name.First |> String50.value :> obj
  let last = name.Last |> String50.value :> obj
  [
    ("First",first)
    ("Last",last)
  ] |> dict
