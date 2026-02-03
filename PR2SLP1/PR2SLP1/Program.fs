let rec factorial n =
    if n = 0 || n = 1 then 1
    else n * factorial (n - 1)


[<EntryPoint>]
let main _ =
    let tests = [0; 1; 5; 7; 10]

    tests
    |> List.map (fun x -> x, factorial x)
    |> List.iter (fun (x, result) ->
        printfn "factorial %d = %d" x result
    )

    0
