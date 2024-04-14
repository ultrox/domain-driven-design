type HtmlString = 
  HtmlString of string

type OrderAcknowledgment = {
  EmailAddress : EmailAddress
  Letter : HtmlString 
  }
