namespace StaticExercise
{
    public class Program
    {
        static void Main(string[] args)
        {
            var celsius = TempConverter.FahrenheitToCelsius(70);
            var fahrenheit = TempConverter.CelsiusToFahrenheit(25);

            Console.WriteLine("After temperature conversions: ");
            Console.WriteLine($"The temperature in celsius is: {celsius} C");
            Console.WriteLine($"The temperature in fahrenheit is: {fahrenheit} F");
        }
    }
}
