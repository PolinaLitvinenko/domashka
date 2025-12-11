using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lesson01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите название постройки");
            string name = StrInput();
            Console.WriteLine("Введите стоимость постройки");
            int Cost = IntInput();
            Console.WriteLine("Введите количество производства в минуту постройки");
            int Prod = IntInput();
            Building Building1 = new Building(name, Cost, Prod);
            Console.WriteLine("Введите название постройки");
            name = StrInput();
            Console.WriteLine("Введите стоимость постройки");
            Cost = IntInput();
            Console.WriteLine("Введите количество производства в минуту постройки");
            Prod = IntInput();
            Building Building2 = new Building(name, Cost, Prod);
            Building[] massiv = new Building[] { Building1, Building2 };
            for (int i = 0; i < massiv.Length; i++)
            {
                massiv[i].DisplayInfo();
            }
            Building[] buildings = new Building[5];
            Settlement settlement = new Settlement(buildings, 10000);
            settlement.AddBuilding(Building1);
            settlement.AddBuilding(Building2);
            int Production = settlement.GetTotalProduction();
            Console.WriteLine($"Суммарное производство: {Production}");
            Console.WriteLine("Введите название постройки");
            name = StrInput();
            Console.WriteLine("Введите стоимость постройки");
            Cost = IntInput();
            Console.WriteLine("Введите количество производства в минуту постройки");
            Prod = IntInput();
            Building Building3 = new Building(name, Cost, Prod);
            settlement.AddBuilding(Building3);
            GameManager gamemanager = new GameManager(settlement, 10);
            settlement.ShowBuildings();
            int Productioninmin = gamemanager.SimulateProduction();
            Console.WriteLine($"Суммарное производство за {gamemanager.GameTime} минут составляет {Productioninmin}");
        }
        static string StrInput()
        {
            while (true)
            {
                string str = Console.ReadLine().Trim();
                if (str.Length > 0)
                {
                    return str;
                }
                else
                {
                    Console.WriteLine("Введен неверный формат, введите строку");
                }
            }
        }
        static int IntInput()
        {
            while (true)
            {
                if (int.TryParse(Console.ReadLine(), out int IntNum))
                {
                    return IntNum;
                }
                else
                {
                    Console.WriteLine("Вы ввели неверный формат, введите число");
                }

            }
        }
    }
}
