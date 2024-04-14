// The "let" keyword also defines a named function.
let square x = x * x          // Note that no parens are used.

// In F# returns are implicit -- no "return" needed. A function always
// returns the result of the last expression.

let add x y = x + y           // don't use add (x,y)! It means something
    // completely different.

square 3                      // Run the function. No parens!
add 2 3                       // Run the function. No parens!

// to define a multiline function, just use indents. No semicolons needed.
let evens list =
  let isEven x = x%2 = 0     // Define "isEven" as an inner ("nested") function
  List.filter isEven list    // List.filter is a library function
    // with two parameters: a boolean function
    // and a list to work on

evens oneToFive               // Now run the function
