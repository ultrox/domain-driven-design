let getValue key (dict:IDictionary<string,obj>) :Result<'a,string> =
  match dict.TryGetValue key with
  | (true,value) ->  // key found!
    try
      // downcast to the type 'a and return Ok
      (value :?> 'a) |> Ok
    with
    | :? InvalidCastException ->
      // the cast failed
      let typeName = typeof<'a>.Name
      let msg = sprintf "Value could not be cast to %s" typeName
      Error msg
  | (false,_) ->     // key not found
    let msg = sprintf "Key '%s' not found" key
    Error msg
