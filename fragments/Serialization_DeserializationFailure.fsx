let jsonPersonWithErrors = """{
  "First": "",
  "Last": "Adams",
  "Birthdate": "1776-01-01T00:00:00"
  }"""

// call the deserialization pipeline
jsonToDomain jsonPersonWithErrors |> printfn "%A"

// The output is:
//  Error (ValidationError [
//        "First must be non-empty"
//        ])
