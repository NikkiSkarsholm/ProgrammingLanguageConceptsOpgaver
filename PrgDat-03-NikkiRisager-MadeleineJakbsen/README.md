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

