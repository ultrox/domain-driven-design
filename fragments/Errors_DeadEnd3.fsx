// ('a -> unit) -> (Result<'a,'error> -> Result<'a,'error>)
let adaptDeadEnd f = 
  Result.map (tee f)
