let create fieldName str : Result<String50,string> = 
  if String.IsNullOrEmpty(str) then
    Error (fieldName + " must be non-empty")
  elif str.Length > 50 then
    Error (fieldName + " must be less that 50 chars")
  else
    Ok (String50 str)
