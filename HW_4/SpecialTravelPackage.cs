using System;
using System.Collections.Generic;
using System.Text;

namespace HW_4
{
    public class SpecialTravelPackage : TravelPackage
    {
        private double Discount { get; set; }
        private int NumberOfPeopleNeedForDiscount { get; set; }

        public SpecialTravelPackage(string packageType, int duration, decimal cost, int maxPeopleInGroup, double discount, int numberOfPeopleNeedForDiscount) : base(packageType, duration, cost, maxPeopleInGroup)
        {
            Discount = discount > 99 ? 99 : discount;

            NumberOfPeopleNeedForDiscount = IsThisPackageSuitable(numberOfPeopleNeedForDiscount) ?
                numberOfPeopleNeedForDiscount :
                GetMaxPeopleInGroup();
        }

        public decimal GetTotalDiscountedCost(int numberOfPeople)
        {
            if (!IsThisPackageSuitable(numberOfPeople))
                return -1;
            else
            {
                return numberOfPeople >= NumberOfPeopleNeedForDiscount
                    ? (GetCost() - (GetCost() * (decimal)Discount / 100)) * numberOfPeople :
                    GetTotalTravelCost(numberOfPeople);
            }
        }

        public string GetSpecialPackageInfo()
        {
            string info = GetPackageInfo();
            info += $"Скидка: {Discount}%";
            info += $"\nКоличество людей, необходимое для действия скидки: {NumberOfPeopleNeedForDiscount}\n";
            return info;
        }

        public override string ToString()
        {
            return String.Format("Discount : {0}, NrOfPeopleForDiscount : {1}", Discount, NumberOfPeopleNeedForDiscount);
        }
    }
}
