module Variables

//immutable variable
let number = 9

//muttable variable
let mutable moreNumber = 3

printfn $"moreNumber is {moreNumber}" 

moreNumber <- moreNumber + 2

printfn $"moreNumber changed to be {moreNumber}" 