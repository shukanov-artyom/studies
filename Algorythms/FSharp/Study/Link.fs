module Link

// быстрый поиск
let link1 a b (ids : int list) = 
    let t = ids.[a]
    let ib = ids.[b]
    if t <> b then 
        [
            for i in 0 .. ids.Length-1 do
            if ids.[i] = t then 
                yield ib
            else 
                yield ids.[i]
        ]
    else ids

let rec findRoot a (ids : int list) = 
    if ids.[a] = a then a
    else findRoot ids.[a] ids

// быстрое объединение
let link2 a b (ids: int list) = 
    let roota = findRoot a ids
    let rootb = findRoot b ids 
    if roota <> rootb then 
        [
            for i in 0 .. ids.Length-1 do
            if ids.[i] = roota then 
                yield rootb
            else 
                yield ids.[i]
        ]
    else ids
