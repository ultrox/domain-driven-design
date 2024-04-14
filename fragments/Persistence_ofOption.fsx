module Result =
  /// Convert an Option into a Result
  let ofOption errorValue opt = 
    match opt with
    | Some v -> Ok v
    | None -> Error errorValue
