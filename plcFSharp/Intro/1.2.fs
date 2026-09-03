
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

// III
let rec fmt a = 
    match a with 
    | CstI i -> string i
    | Var v -> v
    | Add (a1, a2) -> 
        " (" + fmt a1 + " + " + fmt a2 + ") " 
    | Sub (a1, a2) -> 
        " (" + fmt a1 + " - " + fmt a2 + ") " 
    | Mul (a1, a2) -> 
        " (" + fmt a1 + " * " + fmt a2 + ") " ;;

//IV
let rec simplify a =
    match a with
    | CstI i -> CstI i
    | Var v -> Var v
    | Add (CstI 0, a1) -> simplify a1
    | Add (a1, CstI 0) -> simplify a1
    | Sub (a1, CstI 0) -> simplify a1
    | Mul (CstI 1, a1) -> simplify a1
    | Mul (a1, CstI 1) -> simplify a1
    | Mul (CstI 0, a1) -> CstI 0
    | Mul ( a1, CstI 0) -> CstI 0
    | Sub (a1, a2) when a1 = a2 -> CstI 0
    | Add (a1, a2) -> 
        let a1s = simplify a1 
        let a2s = simplify a2
        if a1s = a1 && a2s = a2 
        then Add(a1s, a2s)
        else simplify (Add(a1s, a2s))
    | Mul (a1, a2) -> 
        let a1s = simplify a1 
        let a2s = simplify a2
        if a1s = a1 && a2s = a2 
        then Mul(a1s, a2s)
        else simplify (Mul(a1s, a2s))
    | Sub (a1, a2) -> 
        let a1s = simplify a1 
        let a2s = simplify a2
        if a1s = a1 && a2s = a2 
        then Sub(a1s, a2s)
        else simplify (Sub(a1s, a2s))

// V
// TODO 
let rec def exp var = 
    match exp with 
    | CstI i -> CstI i
    | Var v when v = var -> CstI 1
    | Var v -> Var v 
    | Add (CstI _, CstI _) -> Add(CstI 0, CstI 0)
    | Add (CstI _, a2) -> Add(CstI 0, def a2 var)
    | Add (a1, CstI _) -> Add(def a1 var , CstI 0) 
    | Add (a1, a2) -> Add(def a1 var , def a2 var) 
    | Sub (CstI _, CstI _) -> Sub(CstI 0, CstI 0)
    | Sub (CstI _, a2) -> Sub(CstI 0, def a2 var)
    | Sub (a1, CstI _) -> Sub(def a1 var , CstI 0) 
    | Sub (a1, a2) -> Sub(def a1 var , def a2 var) 
    | Mul (a1, a2) -> Mul(def a1 var , def a2 var) 

let test1 = Sub(Mul(CstI 2, Var "x"), Add(CstI 5, Var "x"))
let test2 = Sub(Mul(Var "x", Var "x"), Add(CstI 5, Var "x")) // This code does not work when x's are multiplied together
