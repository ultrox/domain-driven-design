/// Prepend a Result<item> to a Result<list>
let prepend firstR restR = 
  match firstR, restR with
  | Ok first, Ok rest -> Ok (first::rest)
  | Error err1, Ok _ -> Error err1
  | Ok _, Error err2 -> Error err2
  | Error err1, Error _ -> Error err1 
