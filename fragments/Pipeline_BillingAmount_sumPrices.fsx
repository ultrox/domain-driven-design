/// Sum a list of prices to make a billing amount
/// Raise exception if total is out of bounds
let sumPrices prices =
  let total = prices |> List.map Price.value |> List.sum
  create total 
