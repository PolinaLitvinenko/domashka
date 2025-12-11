using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lesson01
{
    internal class Settlement
    {
        private Building[] buildings = new Building[5];
        private int budget;
        public Settlement(Building[] buildings, int budget)
        {
            this.buildings = buildings;
            this.budget = budget;
        }
        public void AddBuilding(Building building)
        {
            for (int i = 0; i < buildings.Length; i++)
            {
                if (buildings[i] == null)
                {
                    if (budget >= building.BuildCost)
                    {
                        buildings[i] = building;
                        budget -= building.BuildCost;
                        Console.WriteLine($"{building.Name} добавлен");
                        return;
                    }
                    else
                    {
                        Console.WriteLine("Недостаточно средств");
                        Console.WriteLine($"{building.Name} не добавлен");
                        return;
                    }
                }
            }
            Console.WriteLine("Нет свободных слотов");
            Console.WriteLine($"{building.Name} не добавлен");
        }
        public int GetTotalProduction()
        {
            int Sum = 0;
            for(int i = 0;i < buildings.Length;i++)
            {
                if (buildings[i] != null)
                {
                    Sum += buildings[i].Production;
                }
            }
            return Sum;
        }
        public void ShowBuildings()
        {
            for(int i = 0; i < buildings.Length; i++)
            {
                if (buildings[i] != null)
                {
                    buildings[i].DisplayInfo();
                }
            }
            int Prod = GetTotalProduction();
            Console.WriteLine($"Суммарное производство: {Prod}");
        }
    }
}
