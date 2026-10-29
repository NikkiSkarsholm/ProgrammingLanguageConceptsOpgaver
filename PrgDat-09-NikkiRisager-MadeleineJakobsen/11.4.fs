let rec prodc l c = 
    match l with 
    | [] -> c 1
    | 0 :: _ -> 0
    | head :: tail -> prodc tail (fun x -> c (x * head))

let rec prodi l acc =
    match l with 
    | [] -> acc
    | 0 :: _ -> 0
    | head :: tail -> prodi tail (head * acc)