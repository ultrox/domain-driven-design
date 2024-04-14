/// Components of tuple
type Suit = Heart | Spade | Diamond | Club
type Rank = Ace | Two | Queen | King // incomplete for clarity

// Tuple
type Card = Suit * Rank

/// Corresponding DTO types
type SuitDto = Heart = 1 | Spade = 2 | Diamond = 3 | Club = 4 
type RankDto = Ace = 1 | Two = 2 | Queen = 12 | King = 13
type CardDto = {
  Suit : SuitDto
  Rank : RankDto
  }
