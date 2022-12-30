using System;
namespace StaticExercise
{
	public static class TempConverter
	{
		//Method to convert Fahrenheit to Celsius
		public static double FahrenheitToCelsius(double fahrenheit)
		{
			return (fahrenheit - 32) / 1.8;
        }

		//Method to convert Celsius to Fahrenheit
		public static double CelsiusToFahrenheit(double celsius)
		{
			return (celsius * 9) / 5 + 32;
        }
    }
}

