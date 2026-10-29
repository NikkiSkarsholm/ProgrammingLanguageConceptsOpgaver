let rec prod xs = 
    match xs with
    | [] -> 1
    | x :: xr -> x * prod xr

let rec prodc l c = 
    match l with 
    | [] -> c 1
    | head :: tail -> prodc tail (fun x -> c (x * head))