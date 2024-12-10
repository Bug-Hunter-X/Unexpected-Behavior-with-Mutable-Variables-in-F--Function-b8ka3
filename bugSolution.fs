let mutable x = 10
let mutable y = 20

let swap (x,y) = 
    let temp = x
    x <- y
    y <- temp
    (x,y)

let (x,y) = swap (x,y) 
printfn "%d %d" x y // Output: 20 10

//More functional approach
let swap2 (x, y) = (y, x)
let (x2, y2) = swap2 (x, y)
printfn "%d %d" x2 y2