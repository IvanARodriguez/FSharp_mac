open Library
open System

module basicFunctions =

    let squarePlus3 side = side * side + 3

    let box = squarePlus3 500

    printfn $"The result of squaring 5 and adding 3 is: %d{box}"


[<EntryPoint>]
let main args = 
    printfn "Nice Command-Line arguments! Here's what the system.Text.Json has to say about them"

    let value, json = getJson {| args=args; year = DateTime.Now.Year |}

    printfn $"Input: %0A{value}"
    printfn $"Output: %s{json}"

    0 // return an integer exit code

