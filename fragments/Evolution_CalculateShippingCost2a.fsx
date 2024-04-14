let (|UsLocalState|UsRemoteState|International|) address = 
  if address.Country = "US" then
    match address.State with
    | "CA" | "OR" | "AZ" | "NV" -> 
      UsLocalState
    | _ -> 
      UsRemoteState
  else
    International
