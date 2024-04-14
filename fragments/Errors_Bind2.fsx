let bind switchFn twoTrackInput = 
  match twoTrackInput with 
  | Ok success -> switchFn success
  | Error failure -> Error failure
