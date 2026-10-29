let rec rev xs = 
    match xs with 
    | [] -> [] 
    | x::xr -> rev xr @ [x]

let rec revc l c =
    match l with 
    | [] -> c []
    | head :: tail -> revc tail (fun x -> c (x @ [head] )) 
    
let rec revi l acc =
    match l with 
    | [] -> acc 
    | head :: tail -> revi tail (head::acc)