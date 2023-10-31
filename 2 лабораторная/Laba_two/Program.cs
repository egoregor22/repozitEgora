using System;
using System.IO;

namespace Laba_two
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Программа, которая позволяет найти корни квадратного уравнения.");
            bool success = true;
            double a, b, c;
            try
            {
                StreamReader str = new StreamReader("Data.txt");
                if (!double.TryParse(str.ReadLine(), out a) || !double.TryParse(str.ReadLine(), out b) || !double.TryParse(str.ReadLine(), out c))
                    throw new IncorrectDataException();
                double D = b * b - 4 * a * c;
                if (D < 0)
                    throw new NegativeDiscriminantException();
                switch (D)
                {
                    case 0:
                        Console.WriteLine("Корень:");
                        Console.WriteLine("X = " + (-b / (2 * a)));
                        break;
                    default:
                        Console.WriteLine("Корни:");
                        Console.WriteLine("X1 = " + ((-b - Math.Sqrt(D)) / (2 * a)));
                        Console.WriteLine("X2 = " + ((-b + Math.Sqrt(D)) / (2 * a)));
                        break;
                }
            }
            catch (ZeroDenominatorException ex)
            {
                Console.WriteLine(ex.Message);
                success = false;
            }
            catch (NegativeDiscriminantException ex)
            {
                Console.WriteLine(ex.Message);
                success = false;
            }
            catch (FileNotFoundException ex)
            {
                Console.WriteLine(ex.Message);
                success = false;
            }
            catch (IncorrectDataException ex)
            {
                Console.WriteLine(ex.Message);
                success = false;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                success = false;
            }
            finally
            {
                if (success)
                    Console.WriteLine("Всё завершилось успешно!");
                else
                    Console.WriteLine("Произошла ошибка!");
                Console.ReadLine();
            }
        }
    }
}