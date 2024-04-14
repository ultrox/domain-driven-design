module Domain = 
  type OrderId = private OrderId of string

  module OrderId =
    /// Define a "Smart constructor" for OrderId 
    /// string -> OrderId 
    let create str = 
        if String.IsNullOrEmpty(str) then
          // use exceptions rather than Result for now
          failwith "OrderId must not be null or empty" 
        elif str.Length > 50 then
          failwith "OrderId must not be more than 50 chars" 
        else
          OrderId str

    /// Extract the inner value from an OrderId
    /// OrderId -> string
    let value (OrderId str) = // unwrap in the parameter!
      str                     // return the inner value
