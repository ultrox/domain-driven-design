[<CustomEquality; NoComparison>]
type Contact = {
  ContactId : ContactId 
  PhoneNumber : PhoneNumber
  EmailAddress: EmailAddress
  }
  with 
  override this.Equals(obj) =
    match obj with
    | :? Contact as c -> this.ContactId = c.ContactId 
    | _ -> false
  override this.GetHashCode() =
    hash this.ContactId
