type CardType = 
  Visa | Mastercard        // 'OR' type

type CreditCardInfo = {    // 'AND' type (record)
  CardType : CardType 
  CardNumber : CardNumber  
  }
