**Exercise 6.5**
I
- let f x = 1 in f f end

This has the type : int

- let f g = g g in f end

This fails with a circularity error, because we cannot have a function parameterer call itself with itself.

- let f x =
  let g y = y
  in g false end
  in f 42 end

This has the type : bool

- let f x =
let g y = if true then y else x
in g false end
in f 42 end

This fails, as the functions type cannot determine the return type of g, this is because the type checking does not evaluate the condition in the if statement, and therefore thinks that g can either return y or x, which have different types. This leads to an error as the function needs to o nly return one type.

- let f x =
  let g y = if true then y else x
  in g false end
  in f true end

This has the type : bool

II

bool -> bool :  
    let f x = x = false in f end

int -> int :     
    let f x = x + 1 in f end

int -> int -> int : 
    let f x = let g y = y + x in g end in f end





