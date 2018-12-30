using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpProgrammingLanguageBasics
{
    class Program
    {
        static void Main(string[] args)
        {
            // 1 
            //int firstNumber;
            //int secondNumber;
            //int thirdNumber;

            //Console.Write("Введите три любых числа: ");
            //firstNumber = int.Parse(Console.ReadLine());
            //secondNumber = int.Parse(Console.ReadLine());
            //thirdNumber = int.Parse(Console.ReadLine());

            //Console.WriteLine(firstNumber + "  " + secondNumber + "  " + thirdNumber);

            // 2
            //int firstNumber = 5;
            //int secondNumber = 10;
            //int thirdNumber = 21;

            //Console.WriteLine("Числа:");
            //Console.WriteLine(firstNumber);
            //Console.WriteLine(secondNumber);
            //Console.WriteLine(thirdNumber);


            // 3
            //int santimeters;
            //int meters;

            //Console.Write("Введите количество сантиметров: ");
            //santimeters = int.Parse(Console.ReadLine());

            //int santimetersInMeters = 100;
            //meters = santimeters / santimetersInMeters;
            //Console.Write("Количество полных метров в них: " + meters);


            // 4
            //int pastDays = 234;
            //int pastWeeks;
            //int daysInWeek = 7;

            //pastWeeks = pastDays / daysInWeek;
            //Console.Write("За " + pastDays + " дня прошло " + pastWeeks + " недели");


            // 5
            //int twosignedNumber;
            //Console.Write("Введите двузначное число: ");
            //twosignedNumber = int.Parse(Console.ReadLine());

            //int unitsInTen = 10;

            //int tens = twosignedNumber / unitsInTen;
            //Console.WriteLine("Количество десятков: " + tens);

            //int units = twosignedNumber % unitsInTen;
            //Console.WriteLine("Количество единиц: " + units);

            //int sum = tens + units;
            //Console.WriteLine("Сумма цифр в числе: " + sum);

            //int composition = tens * units;
            //Console.WriteLine("Произведение цифр в числе: " + composition);

            // 6
            //bool a = true;
            //bool b = false;
            //bool c = false;

            //Console.WriteLine("А или В = " + (a || b));
            //Console.WriteLine("A и B = " + (a && b));
            //Console.Write("B или C = " + (b || c));

            // 7
            //int circleRadius;
            //int squareSide;

            //Console.Write("Введите радиус круга: ");
            //circleRadius = int.Parse(Console.ReadLine());
            //Console.Write("Введите сторону квадрата: ");
            //squareSide = int.Parse(Console.ReadLine());

            //double circleSpace = Math.PI * (circleRadius * circleRadius);
            //int squareSpace = squareSide * squareSide;

            //if (squareSpace > circleSpace)
            //    Console.Write("Площадь квадрата больше площади круга");
            //else if (squareSpace < circleSpace)
            //    Console.Write("Площади круга больше площади квадрата");
            //else
            //    Console.Write("Площадь круга равна площади квадрата");

            // 8
            //int firstVolume;
            //int firstMass;
            //int secondVolume;
            //int secondMass;

            //Console.Write("Введите объем и массу первого материала: ");
            //firstVolume = int.Parse(Console.ReadLine());
            //firstMass = int.Parse(Console.ReadLine());

            //Console.Write("Введите объем и массу второго материала: ");
            //secondVolume = int.Parse(Console.ReadLine());
            //secondMass = int.Parse(Console.ReadLine());

            //double firstDensity = firstMass / firstVolume;
            //double secondDensity = secondMass / secondVolume;

            //if (firstDensity > secondDensity)
            //    Console.Write("Первый материал имеет большую плотность, чем второй");
            //else if (firstDensity < secondDensity)
            //    Console.Write("Второй материал имеет большую плотность, чем первый");
            //else
            //    Console.Write("Плотности двух материалов равны");

            // 9
            //int firstResistance;
            //int firstVoltage;
            //int secondResistance;
            //int secondVoltage;

            //Console.WriteLine("Введите сопротивление и напряжение первого участка цепи:");
            //firstResistance = int.Parse(Console.ReadLine());
            //firstVoltage = int.Parse(Console.ReadLine());

            //Console.WriteLine("Введите сопротивление и напряжение второго участка цепи:");
            //secondResistance = int.Parse(Console.ReadLine());
            //secondVoltage = int.Parse(Console.ReadLine());

            //double firstAmperage = (double)firstVoltage / firstResistance;
            //double secondAmperage = (double)secondVoltage / secondResistance;

            //if (firstAmperage > secondAmperage)
            //{
            //    Console.Write("Сила тока на втором участке электрической цепи меньше силы тока на первом участке");
            //}
            //else if (firstAmperage < secondAmperage)
            //{
            //    Console.Write("Сила тока на первом участке электрической цепи меньше силы тока на втором участке");
            //}
            //else
            //{
            //    Console.Write("Силы тока на обоих участках цепи равна");
            //}

            // 10
            int lowerBoard = 20;
            int upperBoard = 35;

            Console.WriteLine("Числа от 25 до 35:");
            for (int i = lowerBoard; i <= upperBoard; i++)
            {
                Console.WriteLine(i);
            }

            Console.Write("До какого числа выводить квадраты чисел (больше 10): ");
            int squaresLowerBound = 10;
            int squaresUpperBound = int.Parse(Console.ReadLine());
            Console.WriteLine($"Квадраты чисел от 10 до {squaresUpperBound}:");
            for (int i = squaresLowerBound; i <= squaresUpperBound; i++)
            {
                Console.WriteLine(i * i);
            }

            Console.Write("С какого числа выводить кубы чисел (меньше 50): ");
            int cubesLowerBound = int.Parse(Console.ReadLine());
            int cubesUpperBound = 50;
            Console.WriteLine($"Кубы чисел от {cubesLowerBound} до 50:");
            for (int i = cubesLowerBound; i <= cubesUpperBound; i++)
            {
                Console.WriteLine(i * i * i);
            }

            Console.WriteLine("Введите диапазон числел для вывода: ");
            int customLowerBound = int.Parse(Console.ReadLine());
            int customUpperBound = int.Parse(Console.ReadLine());
            Console.WriteLine($"Числа от {customLowerBound} до {customUpperBound}:");
            for (int i = customLowerBound; i <= customUpperBound; i++)
            {
                Console.WriteLine(i);
            }

            Console.ReadLine();
        }
    }
}
