using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dz01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("1 задание");
            Console.WriteLine("введите строку");
            string noString = Console.ReadLine();
            int a = 0;
            if (int.TryParse(noString, out int newNumber))
            {
                a = newNumber;
            }
            else
            {
                Console.WriteLine("ошибка ввода");
            }
            a = a + 100;
            Console.WriteLine(a);
            Console.WriteLine("2 задание");
            double b = 7;
            int c = 7;
            b = b / 2;
            c = c / 2;
            Console.WriteLine(b);
            Console.WriteLine(c);
            if (b == c)
            {
                Console.WriteLine("числа равны");
            }
            else
            {
                Console.WriteLine("числа не равны");
            }
            Console.WriteLine("3 задание");
            Console.WriteLine("Введите строку");
            string String1 = Console.ReadLine();
            if (int.TryParse(String1, out int newNumber1))
            {
                a = newNumber1;
                Console.WriteLine($"Квадрат числа равен {a * a}");
            }
            else
            {
                Console.WriteLine("ошибка ввода");
            }
            Console.WriteLine("4 задание");
            Console.WriteLine("Введите дробное число");
            double chislo = double.Parse(Console.ReadLine());
            double temp1 = chislo;
            chislo = (int)chislo;
            double temp2 = temp1 - chislo;
            Console.WriteLine(chislo);
            Console.WriteLine($"Величина изменилась на {temp2}");
            Console.WriteLine("5 задание");
            Console.WriteLine("Введите числа для маcсива(5)");
            int[] mass = new int[5];
            for (int i = 0; i < mass.Length; i++)
            {
                mass[i] = int.Parse(Console.ReadLine());
            }
            for (int i = 0; i < mass.Length; i++)
            {
                Console.Write(mass[i] + " ");
            }
            Console.Write($"\n");
            Console.WriteLine("6 задание");
            int k = 0;
            for (int i = 0; i < mass.Length; i++)
            {
                if (mass[i] % 2 == 0)
                    k++;
            }
            Console.WriteLine($"Количество чётных чисел равно {k}");
            Console.WriteLine("7 задание");
            int Sum = 0;
            float ar = 0;
            int n = 0;
            for (int i = 0; i < mass.Length; i++)
            {
                Sum = Sum + mass[i];
                n = n + 1;
            }
            Console.WriteLine($"Сумма равна {Sum}");
            ar = (float)Sum / n;
            Console.WriteLine($"Среднее арифметическое равно {ar}");
            Console.WriteLine("8 задание");
            for (int i = 0; i < mass.Length; i++)
            {
                Console.Write(mass[i] + " ");
            }
            Console.Write($"\n");
            int temp3 = mass[0];
            mass[0] = mass[mass.Length - 1];
            mass[mass.Length - 1] = temp3;
            for (int i = 0; i < mass.Length; i++)
            {
                Console.Write(mass[i] + " ");
            }
            Console.Write($"\n");
            Console.WriteLine("9 задание");
            int MaxV = mass[0];
            int MinV = mass[0];
            for (int i = 1; i < mass.Length; i++)
            {
                if (MaxV < mass[i])
                {
                    MaxV = mass[i];
                }
                if (MinV > mass[i])
                {
                    MinV = mass[i];
                }
            }
            int IndexMin = 0;
            int IndexMax = 0;
            for (int i = 1; i < mass.Length; i++)
            {
                if (mass[i] == MinV)
                {
                    IndexMin = i;
                }
                if (mass[i] == MaxV)
                {
                    IndexMax = i;
                }
            }

            Console.WriteLine($"Минимальное число = {MinV},индекс минимального числа = {IndexMin}, Максимальное число = {MaxV}, максимального числа = {IndexMax}");
            Console.WriteLine("10 задание");
            Console.WriteLine("Введите числа для массива(5)");
            int[] Mass = new int[10];
            int count = 5;

            for (int i = 0; i < 5; i++)
            {
                Mass[i] = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("Заполните массив");
            while (count < Mass.Length)
            {
                Mass[count] = int.Parse(Console.ReadLine());
                count++;
                Console.WriteLine($"количество элементов равно {count}");
                if (count >= Mass.Length)
                {
                    mass = new int[Mass.Length * 2];
                    for (int i = 0; i < mass.Length / 2; i++)
                    {
                        mass[i] = Mass[i];
                    }
                    mass[count] = int.Parse(Console.ReadLine());
                    for (int i = 0; i < mass.Length; i++)
                    {
                        Console.Write(mass[i] + " ");
                    }
                    Console.Write($"\n");
                }
            }

            Console.WriteLine("11 задание");
            int[] M = new int[5] { 1, 2, 3, 4, 5 };
            for (int i = 0; i < M.Length; i++)
            {
                Console.Write(M[i] + " ");
            }
            Console.Write($"\n");
            count = M.Length;
            Console.WriteLine("Введите индекс,который хотите удалить");
            int Index = int.Parse(Console.ReadLine());
            int currentIndex = 0;
            for (int i = Index; i < M.Length; i++)
            {
                if (i != M.Length - 1)
                {
                    M[i] = M[i + 1];
                }
                else
                {
                    M[i] = 0;
                }
            }

            for (int i = 0; i < M.Length; i++)
            {
                Console.Write(M[i] + " ");
            }
            Console.Write($"\n");
            Console.WriteLine("12 задание");
            int[] M1 = new int[5] { 1, 2, 3, 4, 5 };
            count = M1.Length;
            for (int i = 0; i < M1.Length; i++)
            {
                Console.Write(M1[i] + " ");
            }
            Console.Write($"\n");
            Console.WriteLine("Введите индекс,который хотите удалить");
            Index = int.Parse(Console.ReadLine());
            M1[Index] = M1[M1.Length - 1];
            M1[M1.Length - 1] = 0;
            for (int i = 0; i < M1.Length; i++)
            {
                Console.Write(M1[i] + " ");
            }
            Console.Write($"\n");
            Console.WriteLine("13 задание");
            Console.WriteLine("Введите числа для массива(5)");
            Mass = new int[5];
            for (int i = 0; i < 5; i++)
            {
                Mass[i] = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("Введите число, которое хотите удалить");
            int X = int.Parse(Console.ReadLine());
            M = new int[Mass.Length];
            int j = 0;
            for (int i = 0; i < Mass.Length; i++)
            {
                if (Mass[i] != X)
                {
                    M[j] = Mass[i];
                    j++;
                }
            }
            count = 0;
            for (int i = 0; i < M.Length; i++)
            {
                if (M[i] != 0)
                {
                    count++;
                }
            }
            int[] Mass2 = new int[count];
            for (int i = 0; i < count; i++)
            {
                Mass2[i] = M[i];
            }
            M = Mass2;
            for (int i = 0; i < M.Length; i++)
            {
                Console.Write(M[i] + " ");
            }
            Console.Write($"\n");
            Console.WriteLine("14 задание");
            Console.WriteLine("Введите числа для массива(5)");
            Mass = new int[5];
            for (int i = 0; i < 5; i++)
            {
                Mass[i] = int.Parse(Console.ReadLine());
            }
            M = new int[5];
            j = 0;
            for (int i = Mass.Length - 1; i >= 0; i--)
            {
                M[j] = Mass[i];
                j++;
            }
            for (int i = 0; i < M.Length; i++)
            {
                Console.Write(M[i] + " ");
            }
            Console.Write($"\n");
            Console.WriteLine("15 задание");
            Console.WriteLine("Введите количество элементов в массиве");
            int N = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите числа для массива");
            Mass = new int[N];
            j = 0;
            for (int i = 0; i < N; i++)
            {
                Mass[i] = int.Parse(Console.ReadLine());
            }
            k = N - 1;
            if (N % 2 == 0)
            {
                for (int i = 0; i < N; i++)
                {
                    if (Mass[i] == Mass[k])
                    {
                        j++;
                    }
                    k--;
                }
                if (j == N)
                {
                    Console.WriteLine("Является палиндромом");
                }
                else
                {
                    Console.WriteLine("Не является палиндромом");
                }
            }
            else
            {
                for (int i = 0; i < N / 2; i++)
                {
                    if (Mass[i] == Mass[k])
                    {
                        j++;
                    }
                    k--;
                }
                if (j == N / 2)
                {
                    Console.WriteLine("Является палиндромом");
                }
                else
                {
                    Console.WriteLine("Не является палиндромом");
                }
            }
            Console.WriteLine("16 задание");
            Console.WriteLine("Введите количество элементов в массиве");
            N = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите числа для массива");
            Mass = new int[N];
            j = 0;
            for (int i = 0; i < N; i++)
            {
                Mass[i] = int.Parse(Console.ReadLine());
            }
            M = new int[N + 1];
            int[] Massiv = new int[N + 1];
            for (int i = 0; i < N; i++)
            {
                Massiv[i] = Mass[i];
            }
            Mass = Massiv;
            for (int i = 0; i < N; i++)
            {
                if (Mass[i] != Mass[i + 1])
                {
                    M[j] = Mass[i];
                    j++;
                }
            }
            count = 0;
            for (int i = 0; i < M.Length; i++)
            {
                if (M[i] != 0)
                {
                    count++;
                }
            }
            Mass2 = new int[count];
            for (int i = 0; i < count; i++)
            {
                Mass2[i] = M[i];
            }
            M = Mass2;
            for (int i = 0; i < M.Length; i++)
            {
                Console.Write(M[i] + " ");
            }
            Console.Write($"\n");
            Console.ReadKey();
        }
    }
}
