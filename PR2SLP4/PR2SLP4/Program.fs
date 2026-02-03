let squares list =
    list |> List.map (fun x -> x * x)

let evenNumbers list =
    list |> List.filter (fun x -> x % 2 = 0)

let sumOfList list =
    list |> List.fold (+) 0

let sumOfSquaresOfEven list =
    list
    |> List.filter (fun x -> x % 2 = 0)
    |> List.map (fun x -> x * x)
    |> List.sum


[<EntryPoint>]
let main _ =
    let testLists =
        [
            [1; 2; 3; 4; 5; 6]
            [0; -1; -2; 10]
            [5; 5; 5]
        ]

    testLists
    |> List.iter (fun lst ->
        printfn "Список: %A" lst
        printfn "Квадрати: %A" (squares lst)
        printfn "Парнi числа: %A" (evenNumbers lst)
        printfn "Сума всiх чисел: %d" (sumOfList lst)
        printfn "Сума квадратiв парних чисел: %d" (sumOfSquaresOfEven lst)
        printfn ""
    )

    0
