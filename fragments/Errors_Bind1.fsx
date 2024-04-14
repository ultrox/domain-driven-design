let bind switchFn  = 
  fun twoTrackInput -> 
    match twoTrackInput with 
    | Ok success -> switchFn success
    | Error failure -> Error failure
