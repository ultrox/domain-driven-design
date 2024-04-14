type SendResult = Sent | NotSent

type SendOrderAcknowledgment =
  OrderAcknowledgment -> SendResult 
