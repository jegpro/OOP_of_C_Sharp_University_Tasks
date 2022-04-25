using System;
using System.Collections.Generic;
using System.Text;

namespace HW_4
{
    public class TravelPackage : IComparable
    {
        public string PackageType { get; set; }
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

        public bool IsThisPackageSuitable(int numberOfPeople)
        {
            return numberOfPeople <= MaxPeopleInGroup;
        }

        public decimal GetTotalTravelCost(int numberOfPeople)
        {
            return IsThisPackageSuitable(numberOfPeople) ?
                Cost * numberOfPeople : -1;
        }

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
            info += $"\nСтоимость для одного клиента: {Cost} EUR";
            info += $"\nМаксимальное количество людей в группе: {MaxPeopleInGroup}\n";

            return info;
        }

        public override string ToString()
        {
            return String.Format("TravelPckg name : {0}, Durtaion : {1}, Price : {2}, Grup size : {3}", PackageType, Duration, Cost, MaxPeopleInGroup);
        }

        #region Equals
        //public override bool Equals(object obj)
        //{
        //    TravelPackage temp = (TravelPackage)obj;
        //    return PackageType == temp.PackageType && Duration == temp.Duration && Cost == temp.Cost && MaxPeopleInGroup == temp.MaxPeopleInGroup;
        //}
        #endregion

        public int CompareTo(object obj)
        {
            TravelPackage temp = (TravelPackage)obj;
            return Cost.CompareTo(temp.Cost);
        }
    }
}
