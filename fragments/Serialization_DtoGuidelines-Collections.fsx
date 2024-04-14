/// Domain type
type Order = {
  ...
  Lines : OrderLine list
  }

/// Corresponding DTO type
type OrderDto = {
  ...
  Lines : OrderLineDto[] 
  }
