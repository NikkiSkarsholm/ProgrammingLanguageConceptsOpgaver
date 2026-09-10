**Exercise 3.5:**
We have tried the example expressions and here is a list af additional expression we also tried:
- fromString "let x = 10 in x + 2";; => led to a error becouse the expression lacked an end token.
- fromString "let x = 10 in x + 2 end";; => works
- fromString "2(3+2)";; => failed becouse it does not know the multipication shordhand 
- fromString "2*(3+2)";; => works

**Exercise 3.6**
Added the function in parse.fs.
When loading the lexer and parser into F# interactive. Remember to include Expr.fs 
Example:  dotnet fsi -r bin/Debug/net10.0/FsLexYacc.Runtime.dll  Absyn.fs ExprPar.fs ExprLex.fs Expr.fs Parse.fs


**Exercise 4.1** 
We generated the lexer and parser and ran these examples:
- run (fromString "5+7");; => 12
- run (fromString "let y = 7 in y + 2 end");; => 9
- run (fromString "let f x = x + 7 in f 2 end");; => 9 

**Excercise 4.2**
We have written the followign tests and here is the results:
- run (fromString "let sum n = if 0 < n then n + sum (n-1) else 0 in sum 1000 end") => 500500
- run (fromString "let pow exp = if exp = 0 then 1 else 3 * pow (exp-1) in pow 8 end") => 6561
- ```
  run (fromString "let pow exp =
  if exp = 0
  then 1
  else 3 * pow (exp-1)
  in
  let sumPow xp =
  if xp < 0
  then 0
  else pow xp + sumPow (xp-1)
  in sumPow 11 end end");; 
  ```
  => 265720 (We had to format it on one line for the terminal to accept it. You might have to do the same :D)
- ``` 
  run (fromString "let powSum bas =
    let pow exp =
      if exp = 0
      then 1
      else bas * pow (exp - 1)
    in 
      if bas = 0
      then 0
      else pow 8 + powSum (bas - 1)
    end
  in
    powSum 10
  end");;
  ``` 
  => 167731333 


