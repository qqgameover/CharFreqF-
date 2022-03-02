open System

let letterFreq (text : string) =
    text.ToUpper().ToCharArray()
    |> Array.filter (fun x -> (['A'..'Z']|>Set.ofList).Contains(x))
    |> Seq.countBy (fun x -> x)
    |> Seq.sortByDescending (fun (_, x) -> x)

[<EntryPoint>]
let main argv =
    let res = letterFreq "Hello this is pretty neat"
    for (letter, freq) in res do
        printfn "Letter: %c frequency: %d" letter freq
    0