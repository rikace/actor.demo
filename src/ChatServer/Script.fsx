
let start (filePath:string) =
    System.Diagnostics.Process.Start(filePath) |> ignore

let chatServer = $"dotnet exec {__SOURCE_DIRECTORY__}/../ChatServer/bin/Debug/netcoreapp3.1/ChatServer.dll"
let chatClient = $"dotnet exec {__SOURCE_DIRECTORY__}/../ChatClient/bin/Debug/netcoreapp3.1/ChatClient.dll"

chatServer |> start
[0..2] |> Seq.iter (fun _ -> chatClient |> start)

System.Diagnostics.Process.Start($"dotnet exec {__SOURCE_DIRECTORY__}/../ChatServer/bin/Debug/netcoreapp3.1/ChatServer.dll");

