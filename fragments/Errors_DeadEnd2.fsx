// ('a -> unit) -> ('a -> 'a)
let tee f x = 
  f x 
  x
