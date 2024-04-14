/// convert an Option into a List
let listOfOption opt =
  match opt with 
  | Some x -> [x]
  | None -> []
