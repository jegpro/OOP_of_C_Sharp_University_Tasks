using System;
using System.Text;
using System.Collections;


namespace HW_4
{
    class Program 
    {
        static void Main(string[] args)
        {
            #region Русский язык
            Encoding.RegisterProvider(CodePagesEncodingProvider.Instance);
            Console.OutputEncoding = Encoding.UTF8;
            Console.InputEncoding = Encoding.GetEncoding(1251);
            #endregion

            Random random = new Random();
            TravelPackage[] travelPackages = new TravelPackage[]
            {
                new TravelPackage("Suusareis", 26, 15, 20),
                new TravelPackage("Saaremaareis", 49, 25, 25),
                new TravelPackage("Tallinnaekskursioon", 83, 21, 30),
                new TravelPackage("Taraeris", 12, 20, 18)
            };
            SpecialTravelPackage[] specialTravelPackages = new SpecialTravelPackage[]
            {
                new SpecialTravelPackage("Special Suusareis", 26, 15, 20, 5, 10),
                new SpecialTravelPackage("Special Saaremaareis", 49, 25, 25, 7, 12),
                new SpecialTravelPackage("Special Tallinnaekskursioon", 83, 21, 30, 7, 15),
                new SpecialTravelPackage("Special Taraeris", 12, 20, 18, 6, 10)
            };

            //************************************

            #region EXAM_22.04.2021

            #region Make a ArrayList
            ArrayList travelpckg = new ArrayList();
            travelpckg.Add(new TravelPackage("Suusareis", 26, 15, 20));
            travelpckg.Add(new TravelPackage("Saaremaareis", 49, 25, 25));
            travelpckg.Add(new TravelPackage("Tallinnaekskursioon", 83, 21, 30));
            travelpckg.Add(new TravelPackage("Taraeris", 12, 20, 18));

            travelpckg.Add(new SpecialTravelPackage("Special Suusareis", 26, 15, 20, 5, 10));
            travelpckg.Add(new SpecialTravelPackage("Special Saaremaareis", 49, 25, 25, 7, 12));
            travelpckg.Add(new SpecialTravelPackage("Special Tallinnaekskursioon", 83, 21, 30, 7, 15));
            travelpckg.Add(new SpecialTravelPackage("Special Taraeris", 12, 20, 18, 6, 10));
            #endregion

            #region Sort by cost and print arraylist
            travelpckg.Sort(); // sort by price low -> high

            foreach (TravelPackage pckg in travelpckg) // display ArrayList
            {
                Console.WriteLine(pckg);
            }
            #endregion

            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();

            #region Search by package name
            string result = ""; // search in ArrayList TravelPackage BY NAME
            foreach (TravelPackage tr in travelpckg)
            {
                if(tr.PackageType == "Suusareis")
                {
                    result += tr.ToString() + "\n";
                }
            }
            Console.WriteLine(result);
            #endregion

            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();

            #endregion

            //************************************
            #region Методы TravelPackage
            foreach (TravelPackage package in travelPackages)
            {
                Console.WriteLine($"Тип пакета: {package.GetPackageType()}");
                Console.WriteLine($"Длительность поездки: {package.GetDuration()}");
                Console.WriteLine($"Стоимость: {package.GetCost()} EUR");
                Console.WriteLine($"Макс количество людей в группе: {package.GetMaxPeopleInGroup()}");
                int randomNumber = random.Next(10, 40);
                Console.WriteLine($"Подходит ли пакет для группы из {randomNumber} чел.: {package.IsThisPackageSuitable(randomNumber)}");
                Console.WriteLine($"Общая стоимость для {randomNumber} чел.: {package.GetTotalTravelCost(randomNumber)} EUR");

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
                Console.WriteLine($"Стоимость: {package.GetCost()} EUR");
                Console.WriteLine($"Макс количество людей в группе: {package.GetMaxPeopleInGroup()}");
                int randomNumber = random.Next(10, 40);
                Console.WriteLine($"Подходит ли пакет для группы из {randomNumber} чел.: {package.IsThisPackageSuitable(randomNumber)}");
                Console.WriteLine($"Общая стоимость для {randomNumber} чел.: {package.GetTotalDiscountedCost(randomNumber)} EUR");

                Console.WriteLine("\nИнформация о спецпакете:");
                Console.Write(package.GetSpecialPackageInfo());
                Console.WriteLine();
            }
            #endregion

            Console.ReadKey();
        }
    }
}
