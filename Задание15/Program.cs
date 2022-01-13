using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задание15
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ArithProgression arithProgression = new ArithProgression();
            arithProgression.setStart(1);
            arithProgression.Const(2);
            Console.WriteLine("Вывод первого числа:");
            Console.WriteLine(arithProgression.getNext());
            Console.WriteLine("Вывод второго числа:");
            Console.WriteLine(arithProgression.getNext());
            arithProgression.reset();
            Console.WriteLine("Вывод числа после сброса:");
            Console.WriteLine(arithProgression.getNext());
            GeomProgression geomProgression = new GeomProgression();
            geomProgression.setStart(5);
            geomProgression.Const(2);
            Console.WriteLine("Вывод первого числа:");
            Console.WriteLine(geomProgression.getNext());
            Console.WriteLine("Вывод второго числа:");
            Console.WriteLine(geomProgression.getNext());
            geomProgression.reset();
            Console.WriteLine("Вывод числа после сброса:");
            Console.WriteLine(geomProgression.getNext());
            Console.ReadKey();
        }
        interface ISeries
        {
            void setStart(int x);
            int getNext();
            void reset();
        }
        class ArithProgression : ISeries
        {
            int X;
            int Y;
            int N;
            public void setStart(int x)
            {
                X = x;
                Y = X;
                Console.WriteLine($"Установка значения арифметической прогрессии: {X}");
            }
            public int getNext()
            {
                Y += N;
                return Y;
            }

            public void reset()
            {
                Y = X;
            }
            public void Const(int n)
            {
                N = n;
                Console.WriteLine($"Общий член арифметической прогрессии : {N}");
            }
        }
        class GeomProgression : ISeries
        {
            int X;
            int Y;
            int N;
            public void setStart(int x)
            {
                X = x;
                Y = X;
                Console.WriteLine($"Установка значения геометрической прогрессии: {X}");
            }
            public int getNext()
            {
                Y *= N;
                return Y;
            }

            public void reset()
            {
                Y = X;
            }
            public void Const(int n)
            {
                N = n;
                Console.WriteLine($"Общий член геометрической прогрессии : {N}");
            }
        }
    }
}
