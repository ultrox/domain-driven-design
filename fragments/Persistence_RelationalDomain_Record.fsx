type CustomerId = CustomerId of int
type String50 = String50 of string
type Birthdate = Birthdate of DateTime 


type Customer = {
  CustomerId : CustomerId
  Name : String50
  Birthdate : Birthdate option
  } 
