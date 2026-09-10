(* File Fun/ParseAndRun.fs *)

module ParseAndRun

open Fun

let fromString = Parse.fromString;;

let eval = Fun.eval;;

let run e = eval e [];;

let stringExp1 = "
let sum n =
  if n > 0
  then n + sum (n-1)
  else 0
in sum 1000 "
