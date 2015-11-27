
let rec lnk1 (map : (int * int) list) (ids : int list) = 
    let m = List.head map
    Link.link2 (fst m) (snd m) ids |> lnk1 (List.tail map)

let testArrays = 
    let array1 = [| 1; 2; 3; 4; 56|]
    let element = array1.[3]
    let producedArray = [| for i in 1 .. 10 -> i*i|] 
    0

[<EntryPoint>]
let main argv = 
    let N = 1000000
    let M = 100000
    let rnd = new System.Random()
    let data = 
        [
            for i in 0 .. N-1 do
                yield i
        ]
    let map = 
        [
            for i in 0 .. M-1 do
                yield rnd.Next(N), rnd.Next(N)
        ]
    let res = lnk1 map data

    let ta = testArrays

    0