Console.WriteLine("Hello");
Console.WriteLine("\nStart? PRESS ENTER TO START");
string line;


//Dispatcher dispatcher = new Dispatcher(1, "Test");
/*
while((line = Console.ReadLine()) != "stop")
{
    Console.WriteLine("Starting");
    System.Threading.Thread.Sleep(2000);


    Console.WriteLine("\nYou are a Dispatcher. Look a call");
    
} */

Dispatcher dispatcher = new Dispatcher(1,"Test");