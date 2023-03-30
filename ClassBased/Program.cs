using ClassBased;

internal class Program
{
    private static void Main(string[] args)
    {
        Car Ford = new Car("Mustang", "Red", 1969);
        Car Kia = new Car("Carrens", "White", 2020);


        Console.WriteLine(Ford.color + " " + Ford.year + " " + Ford.model);
        Console.WriteLine(Kia.color + " " + Kia.year + " " + Kia.model);

       
        Car.fullThrottle();


        
    }
}