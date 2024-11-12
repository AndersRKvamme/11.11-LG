Console.WriteLine("Please enter something!");
string userInput = Console.ReadLine();


switch (userInput){
    case "a":
    {
        Console.WriteLine("Running command A");
        break;
    }
    case "b":{
        Console.WriteLine("Running command B");
    }
    default:{
        Console.WriteLine("Not recognised");
        break;
    }
}