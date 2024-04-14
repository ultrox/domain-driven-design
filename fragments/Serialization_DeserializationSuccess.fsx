// JSON string to test with
let jsonPerson = """{
  "First": "Alex",
  "Last": "Adams",
  "Birthdate": "1980-01-01T00:00:00"
  }"""

// call the deserialization pipeline
jsonToDomain jsonPerson |> printfn "%A"

// The output is:
//  Ok {First = String50 "Alex";
//      Last = String50 "Adams";
//      Birthdate = Birthdate 01/01/1980 00:00:00;}
