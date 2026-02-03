let rec arithmeticProgression a0 d n =
    if n <= 0 then []
    else a0 :: arithmeticProgression (a0 + d) d (n - 1)

let sumOfList list =
    List.sum list


[<EntryPoint>]
let main _ =
    let a0 = 3
    let d = 2
    let n = 8

    let progression = arithmeticProgression a0 d n
    let sum = sumOfList progression

    printfn "Арифметична прогресiя: %A" progression
    printfn "Сума елементiв: %d" sum

    0
