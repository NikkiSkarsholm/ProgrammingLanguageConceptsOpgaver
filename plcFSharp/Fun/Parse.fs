(* Lexing and parsing of micro-ML programs using fslex and fsyacc *)

module Parse

open System
open System.IO
open System.Text
open FSharp.Text.Lexing
open Absyn

(* Plain parsing from a string, with poor error reporting *)

let fromString (str : string) : expr =
    let lexbuf = LexBuffer<char>.FromString(str)
    try 
      FunPar.Main FunLex.Token lexbuf
    with 
      | exn -> let pos = lexbuf.EndPos 
               failwithf "%s near line %d, column %d\n" 
                  (exn.Message) (pos.Line+1) pos.Column
             
(* Parsing from a file *)

let fromFile (filename : string) =
    use reader = new StreamReader(filename)
    let lexbuf = LexBuffer<char>.FromTextReader reader
    try 
      FunPar.Main FunLex.Token lexbuf
    with 
      | exn -> let pos = lexbuf.EndPos 
               failwithf "%s in file %s near line %d, column %d\n" 
                  (exn.Message) filename (pos.Line+1) pos.Column

(* Exercise it *)

let e1 = fromString "5+7";;
let e2 = fromString "let f x = x + 7 in f 2 end";;

(* Examples in concrete syntax *)

let ex1 = fromString 
            @"let f1 x = x + 1 in f1 12 end";;

(* Example: factorial *)

let ex2 = fromString 
            @"let fac x = if x=0 then 1 else x * fac(x - 1)
              in fac n end";;

(* Example: deep recursion to check for constant-space tail recursion *)

let ex3 = fromString 
            @"let deep x = if x=0 then 1 else deep(x-1) 
              in deep count end";;
    
(* Example: static scope (result 14) or dynamic scope (result 25) *)

let ex4 = fromString 
            @"let y = 11
              in let f x = x + y
                 in let y = 22 in f 3 end 
                 end
              end";;

(* Example: two function definitions: a comparison and Fibonacci *)

let ex5 = fromString
            @"let ge2 x = 1 < x
              in let fib n = if ge2(n) then fib(n-1) + fib(n-2) else 1
                 in fib 25 
                 end
              end";;
            




(*
run (fromString "let sum n = if n > 0 then n + sum (n-1) else 0 in sum 1000 end")


"let pow exp =
  if exp = 0
  then 1
  else 3 * pow (exp-1)
  in pow 8 end"
  
  run (fromString "let pow exp = if exp = 0 then 1 else 3 * pow (exp-1) in pow 8 end")
  
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
  
  run (fromString "let pow exp = if exp = 0 then 1 else 3 * pow (exp-1) in let sumPow xp = if exp < 0 then 0 else pow xp + sumPow (xp-1)  in sumPow 11 end end");;
  
  
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
*)

let rec pow exp =
  if exp = 0
  then 1
  else 3 * pow (exp-1)
  
let rec sumPow exp =
  if exp < 0  
  then 0
  else pow exp + sumPow (exp-1)
  
let rec powSum bas =
  let rec pow exp =
    if exp = 0
    then 1
    else bas * pow (exp-1)
  
  if bas <= 0
  then 0
  else pow (8) + powSum (bas - 1)
  
(*
run (fromString "let powSum bas = let pow exp = if exp = 0 then 1 else bas * pow (exp - 1) in  if bas <= 0 then 0 else pow 8 + powSum (bas - 1) end in powSum 10 end");;

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


*)

(*
let rec sum n =
  if n > 0
  then n+sum(n-1)
  else 0
sum 1000

*)

let rec Sum n =
  n-1