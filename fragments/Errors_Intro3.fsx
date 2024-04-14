/// A workflow that panics if it gets bad input
let workflowPart2 input =
  if input = 0 then 
    raise (DivideByZeroException())
  ...

/// Top level function for the application
/// which traps all exceptions from workflows.
let main() =

  // wrap all workflows in a try/with block
  try
    let result1 = workflowPart1()
    let result2 = workflowPart2 result1
    printfn "the result is %A" result2

  // top level exception handling
  with
  | :? OutOfMemoryException ->
    printfn "exited with OutOfMemoryException"
  | :? DivideByZeroException ->
    printfn "exited with DivideByZeroException"
  | ex ->
    printfn "exited with %s" ex.Message
