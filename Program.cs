using System;

class TemperatureConverter
{
    // Phương thức chuyển từ độ C sang độ F
    public static double CelsiusToFahrenheit(double celsius)
    {
        double fahrenheit = (9.0 / 5) * celsius + 32;
        return fahrenheit;
    }

    // Phương thức chuyển từ độ F sang độ C
    public static double FahrenheitToCelsius(double fahrenheit)
    {
        double celsius = (5.0 / 9) * (fahrenheit - 32);
        return celsius;
    }

    public static void Main(string[] args)
    {
        double fahrenheit;
        double celsius;
        int choice;

        do
        {
            // Hiển thị menu cho người dùng
            Console.WriteLine("Menu.");
            Console.WriteLine("1. Fahrenheit to Celsius");
            Console.WriteLine("2. Celsius to Fahrenheit");
            Console.WriteLine("0. Exit");
            Console.Write("Enter your choice: ");
            
            // Nhập lựa chọn của người dùng và kiểm tra đầu vào
            if (!Int32.TryParse(Console.ReadLine(), out choice))
            {
                Console.WriteLine("Invalid input. Please enter an integer.");
                continue;
            }

            switch (choice)
            {
                case 1:
                    // Chuyển từ Fahrenheit sang Celsius
                    Console.Write("Enter Fahrenheit: ");
                    if (Double.TryParse(Console.ReadLine(), out fahrenheit))
                    {
                        Console.WriteLine("Fahrenheit to Celsius: " + FahrenheitToCelsius(fahrenheit));
                    }
                    else
                    {
                        Console.WriteLine("Invalid input. Please enter a valid number.");
                    }
                    break;

                case 2:
                    // Chuyển từ Celsius sang Fahrenheit
                    Console.Write("Enter Celsius: ");
                    if (Double.TryParse(Console.ReadLine(), out celsius))
                    {
                        Console.WriteLine("Celsius to Fahrenheit: " + CelsiusToFahrenheit(celsius));
                    }
                    else
                    {
                        Console.WriteLine("Invalid input. Please enter a valid number.");
                    }
                    break;

                case 0:
                    // Thoát chương trình
                    Console.WriteLine("Exiting...");
                    break;

                default:
                    Console.WriteLine("Invalid choice. Please enter 1, 2, or 0.");
                    break;
            }

        } while (choice != 0);
    }
}
