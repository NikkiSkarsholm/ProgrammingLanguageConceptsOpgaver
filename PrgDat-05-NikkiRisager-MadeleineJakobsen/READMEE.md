**Exercise 6.5**

**I**
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

**II**

`bool -> bool` :  
``` javascript
let f x = 
    x = false 
in f end
```

`int -> int` :   
``` javascript
let f x = 
    x + 1 
in f end
```

`int -> int -> int` :     
``` javascript
let f x = 
    let g y = 
        y + x 
    in g end 
in f end
``` 
`'a -> 'b -> 'a` : 
``` javascript
let f a =
    let g b =
        let x = b
        in a end
    in g end
in f end
```
`'a -> 'b -> 'b` : 
``` javascript
let f a =
    let g b =
        let x = a
        in b end
    in g end
in f end
```

`('a -> 'b) -> ('b -> 'c) -> ('a -> 'c)` :    

``` javascript
let f a =
    let g b =
        let h x =
            b (a x)
        in h end
    in g end
in f end
```

`'a -> 'b` : 
    not done yet

`'a` : 
    not done yet


**7.1**
``` fsharp
Prog
    [Fundec
        (None, "main", [(TypI, "n")],
            Block
                [Stmt
                    (While
                        (Prim2 (">", Access (AccVar "n"), CstI 0),
                            Block
                                [Stmt (Expr (Prim1 ("printi", Access (AccVar "n"))));
                                    Stmt
                                        (Expr
                                            (Assign
                                                (AccVar "n",
                                                    Prim2 ("-", Access (AccVar "n"), CstI 1))))]));
                                Stmt (Expr (Prim1 ("println", CstI 10)))])]
```
A main that take an argument n
A while loop for which the condition is that n is bigger than 0.
In the while loop, we print n and decrement n by one.
Last, we print a new line.
