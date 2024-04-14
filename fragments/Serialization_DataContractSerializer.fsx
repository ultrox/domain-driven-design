module Dto = 
  [<DataContract>]
  type Person = {
    [<field: DataMember>]
    First: string
    [<field: DataMember>]
    Last: string
    [<field: DataMember>]
    Birthdate : DateTime
    } 
