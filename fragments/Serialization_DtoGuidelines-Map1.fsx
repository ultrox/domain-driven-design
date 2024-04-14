/// Domain type
type Price = Price of decimal
type PriceLookup = Map<ProductCode,Price>

/// DTO type to represent a map
type PriceLookupPair = {
  Key : string
  Value : decimal
  }
type PriceLookupDto = {
  KVPairs : PriceLookupPair []
  }
