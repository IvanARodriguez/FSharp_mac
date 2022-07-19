printfnp "Hello, from FSharp"

printfn "Hello again, from FSharp"

//Values

//String value
let mutable bestCity : string = "Tampa, FL"

// Boolean value
let isInUSA = true

//Integer Value
let myAge = 31

// Tuple
let rectangle = (1.0, 3.0)

//List value
let goals = ["Learning F#"; "Build a cool app"; "Profit from it!!!!"]

let divideByThree input =  input / 3

(*Explicit Type Annotations*)
let (theWinningNumber:string) = "13"

bestCity <- "Boston, MA"

//Lambda expression
fun x y z -> x + y + z

(** DEFINING NAMED FUNCTIONS **)
let addTwo yourNum = yourNum + 2

addTwo 3
