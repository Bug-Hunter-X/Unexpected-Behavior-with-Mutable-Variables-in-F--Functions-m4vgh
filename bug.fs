let mutable x = 10
let mutable y = 20

let swap x y = 
    let temp = x
    x <- y
    y <- temp

swap x y
printf "%d %d" x y //This will print 20 20 as expected

//However, if we change the code to:
let mutable x = 10
let mutable y = 20

let swap x y = 
    let temp = x
    x <- y
    y <- temp
    (x,y)

let a,b = swap x y
printf "%d %d" a b //This will print 20 10 as expected

//The problem lies in the fact that mutable variables are passed by reference. Therefore, when you modify them inside a function, the changes are reflected in the caller's scope.
//However, when you return a tuple from the swap function and assign it to a and b, you are creating new values which are copies. This means the modifications inside the function do not affect the original variables x and y.

//Therefore, the expected output is 20 10, not 20 20.