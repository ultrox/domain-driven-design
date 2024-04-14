let bindOption f xOpt =
  match xOpt with
  | Some x -> f x |> Result.map Some
  | None -> Ok None
