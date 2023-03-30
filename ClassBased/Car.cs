using System.Reflection.Metadata;
namespace ClassBased
{

   class Car
    {
        public Car(string modelName, string modelColor, int modelYear)
        {
            model = modelName;
            color = modelColor;
            year = modelYear;
        }


        public string model;
        public string color;
        public int year;
        public static void fullThrottle()
        {
            Console.WriteLine("The car is going as fast as it can!");
        }
    }
}
