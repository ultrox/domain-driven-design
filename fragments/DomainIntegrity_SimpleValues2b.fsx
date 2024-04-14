// define a module with the same name as the type 
module UnitQuantity =

  /// Define a "smart constructor" for UnitQuantity	
  /// int -> Result<UnitQuantity,string>
  let create qty =
    if qty < 1 then
      // failure
      Error "UnitQuantity can not be negative" 
    else if qty > 1000 then
      // failure
      Error "UnitQuantity can not be more than 1000" 
    else
      // success -- construct the return value
      Ok (UnitQuantity qty)
