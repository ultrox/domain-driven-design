type NonZeroInteger = 
  // Defined to be constrained to non-zero ints.
  // Add smart constructor, etc
  private NonZeroInteger of int

/// Uses restricted input
let twelveDividedBy (NonZeroInteger n) = 
  match n with
  | 6 -> 2
  ...
  // 0 can't be in the input
  // so doesn't need to be handled
