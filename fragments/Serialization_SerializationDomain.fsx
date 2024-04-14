module Domain = // our domain-driven types

  /// constrained to be not null and at most 50 chars
  type String50 = String50 of string 

  /// constrained to be bigger than 1/1/1900 and less than today's date
  type Birthdate = Birthdate of DateTime 

  /// Domain type
  type Person = {
    First: String50
    Last: String50
    Birthdate : Birthdate
    }
