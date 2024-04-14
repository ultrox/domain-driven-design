let fromDomain (domainObj:Example) :IDictionary<string,obj> =
  match domainObj with
  | A -> 
    [ ("A",null) ] |> dict
  | B i ->
    let bdata = Nullable i :> obj
    [ ("B",bdata) ] |> dict
  | C strList -> 
    let cdata = strList |> List.toArray :> obj
    [ ("C",cdata) ] |> dict
  | D name -> 
    let ddata = name |> nameDtoFromDomain :> obj
    [ ("D",ddata) ] |> dict
