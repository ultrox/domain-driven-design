let acknowledgeOrder : AcknowledgeOrder = 
  fun createAcknowledgmentLetter sendAcknowledgment pricedOrder ->
    let letter = createAcknowledgmentLetter pricedOrder
    let acknowledgment = {
      EmailAddress = pricedOrder.CustomerInfo.EmailAddress
      Letter = letter 
      }

    // if the acknowledgment was successfully sent,
    // return the corresponding event, else return None
    match sendAcknowledgment acknowledgment with
    | Sent -> 
      let event = {
        OrderId = pricedOrder.OrderId
        EmailAddress = pricedOrder.CustomerInfo.EmailAddress
        } 
      Some event
    | NotSent ->
      None
