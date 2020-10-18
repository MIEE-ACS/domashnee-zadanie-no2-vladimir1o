using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main()
        {
            try
            {
                Console.Write("Введите R: ");
                double R = float.Parse(Console.ReadLine());
                double segment0 = 3;
                if (R <= 0)
                {
                    Console.WriteLine("Введены неправельные данные!");
                    Console.ReadKey();
                }
                else
                {
                    Console.WriteLine("\n\tТаблица значений y\n");
                    for (double x = -7; x <= 11; x += 0.2)
                    {

                        if (x < -7 || x > 11)
                        {
                            Console.WriteLine($"\ty({x:0.00}) - Функция не определена");
                        }
                        else if (Math.Round(x, 2) <= -3)
                        {
                            Console.WriteLine($"\ty({x:0.00}) = {segment0:0.000}");
                        }
                        else if (x < 3)
                        {
                            if ((R < 3) && (Math.Abs(x) > R))
                            {
                                Console.WriteLine($"\ty({x:0.00}) - Функция не определена");
                            }
                            else
                            {
                                Console.WriteLine($"\ty({x:0.00}) = {segment1(x, R):0.000}");
                            }
                        }
                        else if (x < 6)
                        {
                            Console.WriteLine($"\ty({x:0.00}) = {segment2(x):0.000}");
                        }
                        else if (x <= 11)
                        {
                            Console.WriteLine($"\ty({x:0.00}) = {segment3(x):0.000}");
                        }
                        x = Math.Round(x, 2);

                    }
                    Console.ReadKey();
                }
                
            }
            catch
            {
                Console.WriteLine("Wrong data!");
                Console.ReadKey();
            }
        }

        static double segment1(double x, double r)
        {
            return (-Math.Sqrt(Math.Abs(r * r - x * x)) + 3);
        }

        static double segment2(double x)
        {
            return -2 * x + 9;
        }

        static double segment3(double x)
        {
            return x - 9;
        }


    }
}
