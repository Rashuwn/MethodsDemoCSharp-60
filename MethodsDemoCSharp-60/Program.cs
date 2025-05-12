namespace MethodsDemoCSharp_60;

class Program
{
    //Create custom methods here
    
    static void Main(string[] args)
    {
        //Console.WriteLine("Hello, World!");
        //string response = Console.ReadLine();
        
        //calling a method (using a method)
        GreetUserByName("Seth");
        GreetUserByName("Michael");

        double result = DoubleAddition(2.5, 2.5);
        Console.WriteLine(result);
        
        Hello();
    }
    
    //Or create custom methods here
    
    //method definition (creating a method)
    //Pascal case (LikeThis
    //access modifier - return type - method name - parameter list - scope/body
    public static void GreetUserByName(string name)
    {
        Console.WriteLine($"Hello, {name}!");
    }

    public static double DoubleAddition(double numOne, double numTwo)
    {
        //double sum = numOne + numTwo;
        return numOne + numTwo;
    }

    public static void Hello()
    {
        Console.WriteLine("Hello!");
    }
}
