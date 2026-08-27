
let env = [("a", 3); ("c", 78); ("baf", 666); ("b", 111)];;

let emptyenv = []; (* the empty environment *)

// I
type aexpr = 
    | CstI of int
    | Var of string 
    | Add of aexpr * aexpr
    | Mul of aexpr * aexpr
    | Sub of aexpr * aexpr;;

// II
let e1 = Sub(Var "v", Add(Var "w", Var "z"));;
let e2 = Mul(CstI 2, Sub(Var "v", Add(Var "w", Var "z")));;
let e3 = Add(Var "x", Add(Var "y", Add(Var "z", Var "v")));;