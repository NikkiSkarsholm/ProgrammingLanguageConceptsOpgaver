let rec len xs = 
    match xs with 
    | [] -> 0
    | x :: xr -> 1 + len xr

let rec lenc l c =
    match l with
    | [] -> c 0
    | head :: tail -> lenc tail (fun x -> c (x + 1)) 

let rec leni l acc =
    match l with 
    | [] -> acc
    | _ :: tail -> leni tail (acc + 1) 


