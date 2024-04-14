type HtmlString = HtmlString of string
type CreateOrderAcknowledgmentLetter =
  PricedOrder -> HtmlString

type OrderAcknowledgment = {
  EmailAddress : EmailAddress
  Letter : HtmlString 
  }
type SendResult = Sent | NotSent
type SendOrderAcknowledgment =
  OrderAcknowledgment -> SendResult 

type AcknowledgeOrder = 
  CreateOrderAcknowledgmentLetter     // dependency
    -> SendOrderAcknowledgment        // dependency
    -> PricedOrder                    // input
    -> OrderAcknowledgmentSent option // output
