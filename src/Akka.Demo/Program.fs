module AkkaConsoleApplication
open Akka
open Akka.Actor
 
type Greet(who) =
    member x.Who = who
 
type GreetingActor() as g =
    inherit ReceiveActor()
    do g.Receive<Greet>(fun (greet:Greet) -> printfn "Hello %s" greet.Who)
 
[<EntryPoint>]  
let main argv = 
    
    let system = ActorSystem.Create "MySystem"
    let greeter = system.ActorOf<GreetingActor> "greeter"
    "World" |> Greet |> greeter.Tell
    System.Console.ReadLine() |> ignore
    
    0
