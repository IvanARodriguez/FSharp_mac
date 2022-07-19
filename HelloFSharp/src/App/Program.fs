open System
open Library

[<EntryPoint>]
let main args = 
    printfn "Nice Command-Line arguments! Here's what the system.Text.Jsoin has to say about them"

    let value, json = getJson {| args=args; year = DateTime.Now.Year |}

    printfn $"Input: %0A{value}"
    printfn $"Output: %s{json}"

    0 // return an integer exit code

