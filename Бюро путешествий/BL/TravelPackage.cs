using System;

namespace BL
{
    public class TravelPackage
    {
        private string PackageType { get; set; }
        private int Duration { get; set; }
        private decimal Cost { get; set; }
        private int MaxPeopleInGroup { get; set; }

        public TravelPackage(string packageType, int duration, decimal cost, int maxPeopleInGroup)
        {
            PackageType = packageType;
            Duration = duration < 1 ? 1 : duration;
            Cost = cost < 1 ? 1 : cost;
            MaxPeopleInGroup = maxPeopleInGroup < 1 ? 1 : maxPeopleInGroup;
        }

        public string GetPackageType()
        {
            return PackageType;
        }

        public int GetDuration()
        {
            return Duration;
        }

        public decimal GetCost()
        {
            return Cost;
        }

        public int GetMaxPeopleInGroup()
        {
            return MaxPeopleInGroup;
        }

        /// <summary>
        /// Определяет, подходит ли данный пакет для группы
        /// </summary>
        /// <param name="numberOfPeople">Количество людей</param>
        /// <returns></returns>
        public bool IsThisPackageSuitable(int numberOfPeople)
        {
            return numberOfPeople <= MaxPeopleInGroup;
        }

        /// <summary>
        /// Получает общую стоимость путешествия
        /// </summary>
        /// <param name="numberOfPeople">Количество людей</param>
        /// <returns></returns>
        public decimal GetTotalTravelCost(int numberOfPeople)
        {
            return IsThisPackageSuitable(numberOfPeople) ?
                Cost * numberOfPeople : -1;
        }

        /// <summary>
        /// Представляет информацию о пакете путешествия в текстовом виде
        /// </summary>
        /// <returns></returns>
        public string GetPackageInfo()
        {
            string info = string.Empty;
            info += $"Тип пакета: {PackageType}\n";
            if (Duration > 24)
            {
                int days = Duration / 24;
                int hours = Duration - 24 * days;
                info += $"Длительность поездки: {days} д.";
                if (hours > 0)
                    info += $" и {hours} ч.";
            }
            else
                info += $"Длительность поездки: {Duration} ч.";
            info += $"\nСтоимость для одного клиента: {Cost} руб.";
            info += $"\nМаксимальное количество людей в группе: {MaxPeopleInGroup}\n";

            return info;
        }
    }
}
