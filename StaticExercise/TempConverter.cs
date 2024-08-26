namespace StaticExercise;


public class TempConverter
{
    public static double FahrenheitToCelsius(int fahrenheit)
    {
        
        var answer = (fahrenheit - 32) * 5 / 9;
        return answer;
    }

    public static double CelsiusToFahrenheit(int celsius)
    {
        var answer = (celsius * 9) / 5 + 32;
        return answer;
    }
}