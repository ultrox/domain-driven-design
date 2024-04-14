let toDomain dto : Result<Color,_> =
  match dto with
  | ColorDto.Red -> Ok Color.Red
  | ColorDto.Green -> Ok Color.Green
  | ColorDto.Blue -> Ok Color.Blue
  | _ -> Error (sprintf "Color %O is not one of Red,Green,Blue" dto)
