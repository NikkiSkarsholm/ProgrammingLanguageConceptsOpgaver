(* Programming language concepts for software developers, 2010-08-28 *)

(* Evaluating simple expressions with variables *)

module Intro2

(* Association lists map object language variables to their values *)

let env = [("a", 3); ("c", 78); ("baf", 666); ("b", 111)];;

let emptyenv = []; (* the empty environment *)

let rec lookup env x =
    match env with 
    | []        -> failwith (x + " not found")
    | (y, v)::r -> if x=y then v else lookup r x;;

let cvalue = lookup env "c";;


(* Object language expressions with variables *)
// 1.1 IV
type expr = 
  | CstI of int
  | Var of string
  | Prim of string * expr * expr
  | If of expr * expr * expr;;

let e1 = CstI 17;;

let e2 = Prim("+", CstI 3, Var "a");;

let e3 = Prim("+", Prim("*", Var "b", CstI 9), Var "a");;

//example expression for exercise
let e4 = Prim("==", Prim("+", CstI 1, CstI 1), CstI 2);;

let evalE4 = eval2 e4 env;;

let e5 = Prim("==", Prim("+", CstI 1, CstI 1), CstI 3);;

let evalE5 = eval2 e5 env;;

let e6 = Prim("max", CstI 5, CstI 7);;

let evalE6 = eval2 e6 env ;;

let e7 = Prim("min", Var "a", CstI 7);;

let evalE7 = eval2 e7 env ;;

let eif = If (Var "a", CstI 11, CstI 22);;
let evaleif = eval2 eif env;;


(* Evaluation within an environment *)

// 1.1 I
(*
let rec eval e (env : (string * int) list) : int =
    match e with
    | CstI i            -> i
    | Var x             -> lookup env x 
    | Prim("+", e1, e2) -> eval e1 env + eval e2 env
    | Prim("*", e1, e2) -> eval e1 env * eval e2 env
    | Prim("-", e1, e2) -> eval e1 env - eval e2 env
    | Prim("max", e1, e2) -> if eval e1 env > eval e2 env 
                                then eval e1 env 
                                else eval e2 env
    | Prim("min", e1, e2) -> if eval e1 env < eval e2 env 
                                then eval e1 env 
                                else eval e2 env
    | Prim("==", e1, e2) -> if eval e1 env = eval e2 env
                                then 1
                                else 0
    | Prim _            -> failwith "unknown primitive";; *)

//1.1 III
let rec eval2 e (env : (string * int) list) : int =
    match e with
    | CstI i            -> i
    | Var x             -> lookup env x 
    | If (e1, e2, e3)   ->
        if eval2 e1 env <> 0 
        then eval2 e2 env 
        else eval2 e3 env 
    | Prim(ope, e1, e2) ->
        let i1 = eval2 e1 env 
        let i2 = eval2 e2 env
        match ope with 
        | "+" -> i1 + i2
        | "-" -> i1 - i2 
        | "*" -> i1 * i2 
        | "max" -> if i1 > i2 
                    then i1 
                    else i2
        | "min" -> if i1 < i2 
                    then i1 
                    else i2
        | "==" -> if i1 = i2 
                    then 1 
                    else 0
        | _ -> failwith "unknown primitive";;

let e1v  = eval e1 env;;
let e2v1 = eval e2 env;;
let e2v2 = eval e2 [("a", 314)];;
let e3v  = eval e3 env;;
