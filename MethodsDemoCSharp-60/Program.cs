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

    public static int Add(int numOne, int numTwo)
    {
        return numOne + numTwo;
    }

    public static int Substract(int numOne, int numTwo)
    {
        return numOne - numTwo;
    }

    public static int Multiply(int numOne, int numTwo)
    {
        return numOne * numTwo;
    }

    public static int Divide(int numOne, int numTwo)
    {
        return numOne / numTwo;
    }

    public static int Sum(params int[] nums)
    {
        int sum = 0;
        
        foreach(int num in nums)
            sum += num;
        
        return sum;
    }
    
    
    
 static void Main(string[] args)
 
    {
        //Madlib();
        Console.WriteLine(Add(numOne:4, numTwo:8));
        int addedNums = Add(numOne: 4, numTwo: 8);
        Console.WriteLine(addedNums);
        Console.WriteLine(Substract(4, 4));
        Console.WriteLine(Multiply(numOne: 4, numTwo: 8));
        Console.WriteLine(Divide(4, 8));
        Console.WriteLine(Sum(4, 8, 7));
    }
}
