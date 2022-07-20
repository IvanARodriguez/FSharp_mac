module Functions

let squarePlus3 side = side * side + 3

let box = squarePlus3 500

printfn $"The result of squaring 5 and adding 3 is: %d{box}"

let anotherMath (num:int) = 2*num*num - num/5 + 3

let numResult = anotherMath (7 + 30)

printfn $"The result of squaring 5 and adding 3 is: %d{numResult}"

let doMoreMath num = 
    if num < 100.0 then
        2.0 * num * num - num/5.0 + 3.0
    else
        2.0 * num * num + num/5.0 - 37.0

let doMoreResult = doMoreMath (4.7 + 2.9)

printfn $"The result of squaring 5 and adding 3 is: %f{doMoreResult}"