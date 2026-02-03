let normalizeGrades grades =
    match grades with
    | [] -> []
    | _ ->
        let maxGrade = List.max grades |> float
        grades
        |> List.map (fun g -> (float g / maxGrade) * 100.0)

let filterByThreshold threshold grades =
    grades |> List.filter (fun g -> g >= threshold)

let average grades =
    match grades with
    | [] -> 0.0
    | _ ->
        let sum = grades |> List.fold (+) 0.0
        sum / float grades.Length


[<EntryPoint>]
let main _ =
    let grades = [60; 75; 90; 100; 45; 82; 73]
    let threshold = 70.0

    let normalized = normalizeGrades grades
    let filtered = filterByThreshold threshold normalized

    let avgBefore = average normalized
    let avgAfter = average filtered

    printfn "Вихiдний список: %A" grades
    printfn "Нормалiзований список: %A" normalized
    printfn "Пiсля фiльтрацiї (>= %.1f): %A" threshold filtered
    printfn "Середнє до фiльтрацiї: %.2f" avgBefore
    printfn "Середнє пiсля фiльтрацiї: %.2f" avgAfter

    0
