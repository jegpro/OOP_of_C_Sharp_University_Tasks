using System;
using BL;

namespace TestProject
{
    class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            TravelPackage[] travelPackages = new TravelPackage[]
            {
                new TravelPackage("Suusareis", 26, 1190, 20),
                new TravelPackage("Saaremaareis", 49, 2190, 25),
                new TravelPackage("Tallinnaekskursioon", 83, 3490, 30),
                new TravelPackage("Taraeris", 12, 1290, 18)
            };
            SpecialTravelPackage[] specialTravelPackages = new SpecialTravelPackage[]
            {
                new SpecialTravelPackage("Special Suusareis", 26, 1190, 20, 5, 10),
                new SpecialTravelPackage("Special Saaremaareis", 49, 2190, 25, 7, 12),
                new SpecialTravelPackage("Special Tallinnaekskursioon", 83, 3490, 30, 7, 15),
                new SpecialTravelPackage("Special Taraeris", 12, 1290, 18, 6, 10)
            };

            #region Методы TravelPackage
            foreach (TravelPackage package in travelPackages)
            {
                Console.WriteLine($"Тип пакета: {package.GetPackageType()}");
                Console.WriteLine($"Длительность поездки: {package.GetDuration()}");
                Console.WriteLine($"Стоимость: {package.GetCost()}");
                Console.WriteLine($"Макс количество людей в группе: {package.GetMaxPeopleInGroup()}");
                int randomNumber = random.Next(10, 40);
                Console.WriteLine($"Подходит ли пакет для группы из {randomNumber} чел.: {package.IsThisPackageSuitable(randomNumber)}");
                Console.WriteLine($"Общая стоимость для {randomNumber} чел.: {package.GetTotalTravelCost(randomNumber)}");

                Console.WriteLine("\nИнформация о пакете:");
                Console.Write(package.GetPackageInfo());
                Console.WriteLine();
            }
            #endregion

            #region Методы SpecialTravelPackage
            foreach (SpecialTravelPackage package in specialTravelPackages)
            {
                Console.WriteLine($"Тип пакета: {package.GetPackageType()}");
                Console.WriteLine($"Длительность поездки: {package.GetDuration()}");
                Console.WriteLine($"Стоимость: {package.GetCost()}");
                Console.WriteLine($"Макс количество людей в группе: {package.GetMaxPeopleInGroup()}");
                int randomNumber = random.Next(10, 40);
                Console.WriteLine($"Подходит ли пакет для группы из {randomNumber} чел.: {package.IsThisPackageSuitable(randomNumber)}");
                Console.WriteLine($"Общая стоимость для {randomNumber} чел.: {package.GetTotalDiscountedCost(randomNumber)}");

                Console.WriteLine("\nИнформация о спецпакете:");
                Console.Write(package.GetSpecialPackageInfo());
                Console.WriteLine();
            }
            #endregion

            Console.ReadKey();
        }
    }
}
