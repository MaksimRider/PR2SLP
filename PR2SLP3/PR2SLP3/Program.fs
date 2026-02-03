let rec maxRecursive list =
    match list with
    | [] -> None
    | [x] -> Some x
    | head :: tail ->
        match maxRecursive tail with
        | Some maxTail -> Some (if head > maxTail then head else maxTail)
        | None -> Some head


let maxWithFold list =
    match list with
    | [] -> None
    | head :: tail ->
        Some (List.fold (fun acc x -> if x > acc then x else acc) head tail)


[<EntryPoint>]
let main _ =
    let testLists =
        [
            [5; 2; 9; -3; 7]
            [42]
            [-5; -10; -2; -100]
        ]

    testLists
    |> List.iter (fun lst ->
        let r1 = maxRecursive lst
        let r2 = maxWithFold lst

        printfn "Список: %A" lst
        printfn "Рекурсiя: %A" r1
        printfn "Fold: %A" r2
        printfn ""
    )

    0
