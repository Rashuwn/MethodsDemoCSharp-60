namespace MethodsDemoCSharp_60;

public class Program
{
    public static void Madlib()
    {
        Console.WriteLine("What is your name?");
        string userName = Console.ReadLine();
        Console.WriteLine($"Hello, {userName}! What is your favorite color?");
        string favoriteColor = Console.ReadLine();
        Console.WriteLine("What is your favorite animal?");
        string favoriteAnimal = Console.ReadLine();
        Console.WriteLine("What is your favorite band?");
        string favoriteBand = Console.ReadLine();
        
        Console.WriteLine($"One day, {userName} was walking through the woods while wearing a {favoriteColor} t-shirt. {userName} saw a {favoriteAnimal} listening to {favoriteBand}.");
    }
 static void Main(string[] args)
    {
        Madlib();
    }
}
