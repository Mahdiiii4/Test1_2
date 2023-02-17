using System;
using System.Runtime.ConstrainedExecution;

namespace Test1_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Vill du omvandla från Celsius till Fahrenheit eller tvärtom?");
            Console.WriteLine("1. Från Celsius till Fahrenheit");
            Console.WriteLine("2. från Fahrenheit till celsius");
            int svar = int.Parse(Console.ReadLine());
            switch(svar)
            {
                case 1:
                    {
                        Console.WriteLine("Mätta in den temprature");
                        float cel = float.Parse(Console.ReadLine());
                        Console.Write(+cel+ " celsius i fahrenheit är");
                        Fahrenheit(cel);
                        break;
                    }
                case 2:
                    {
                        Console.WriteLine("Mätta in den temprature");
                        float fah = float.Parse(Console.ReadLine());
                        Console.Write(+fah + " fharenheit i celsius är");
                        Celsius(fah);
                        break;
                    }
            }
        }
        static void Fahrenheit(float tal1)
        {
            double summa = tal1 * 1.8 + 32;
            Console.Write(" " +summa+ ".");
        }
        static void Celsius(float tal2)
        {
            double summa = (tal2 - 32) / 1.8;
            Console.Write(" " + summa + ".");
        }
    }
}