namespace StaticExercise
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello Peeps!");
            Console.WriteLine($"Please enter your Fahrenheit temperature.");
            var convToCelsius = double.Parse(Console.ReadLine());

            convToCelsius = TempConverter.FahrenheitToCelsius(convToCelsius);

            Console.WriteLine($"Temperature in Celsius: {convToCelsius}");

            Console.WriteLine("---------");

            Console.WriteLine($"Now enter a new temperature in Celsius.");
            var convToFahrenheit = double.Parse(Console.ReadLine());

            convToFahrenheit = TempConverter.CelsiusToFahrenheit(convToFahrenheit);
            Console.WriteLine($"Temperature in Fahrenheit: {convToFahrenheit}"); 

        }
    }
}
