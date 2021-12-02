open System
open System.IO

let linesFromFile filename =
    seq {
        use reader = File.OpenText filename
        while not reader.EndOfStream do
            yield reader.ReadLine()
    }

let parseInt (str: string) =
    str
    |> System.Int32.TryParse
    |> snd
// let readLines = ["199"; "200"; "208"; "210"; "200"; "207"; "240"; "269"; "260"; "263"]
let readLines = linesFromFile "../input/01_input.txt"
let values = readLines
            |> Seq.map (fun element -> parseInt element)
            |> Seq.pairwise
            |> Seq.filter (fun (a, b)  -> a < b )
            |> Seq.length
            

printf $"Day01-A: {values}"
