type EnvelopeContents = EnvelopeContents of string
type CategorizedMail = 
  | Quote of QuoteForm
  | Order of OrderForm
  // etc

type CategorizeInboundMail = EnvelopeContents -> CategorizedMail
