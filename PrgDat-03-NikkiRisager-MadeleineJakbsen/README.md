**Exercise 3.5:**
We have tried the example expressions and here is a list af additional expression we also tried:
- fromString "let x = 10 in x + 2";; => led to a error becouse the expression lacked an end token.
- fromString "let x = 10 in x + 2 end";; => works
- fromString "2(3+2)";; => failed becouse it does not know the multipication shordhand 
