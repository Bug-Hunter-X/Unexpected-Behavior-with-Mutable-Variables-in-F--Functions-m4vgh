let mutable x = 10
let mutable y = 20

let swap x y = 
    let temp = x
    x <- y
    y <- temp
    (x,y) //return values as tuple to reflect the changes properly

let a,b = swap &x &y // Pass the mutable variables by reference
printf "%d %d" a b //This will print 20 10 as expected

//Alternatively, if you want to avoid modifying original variables, you can create new mutable variables inside the swap function
let swap2 x y = 
    let mutable x2 = x
    let mutable y2 = y
    let temp = x2
    x2 <- y2
    y2 <- temp
    (x2,y2)

let c,d = swap2 x y //Pass values and the function returns new values
printf "%d %d" c d //This will print 20 10 and original x and y will remain unchanged.