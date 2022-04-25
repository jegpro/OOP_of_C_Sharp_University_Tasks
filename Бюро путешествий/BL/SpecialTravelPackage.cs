namespace BL
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

        /// <summary>
        /// Получает общую стоимость путешествия с учетом скидки (если соблюдено условие по кол-ву людей)
        /// </summary>
        /// <param name="numberOfPeople"></param>
        /// <returns></returns>
        public decimal GetTotalDiscountedCost(int numberOfPeople)
        {
            if (!IsThisPackageSuitable(numberOfPeople))
                return -1;
            else
            {
                return numberOfPeople >= NumberOfPeopleNeedForDiscount
                    ? (GetCost() - (GetCost() * (decimal)Discount / 100)) * numberOfPeople:
                    GetTotalTravelCost(numberOfPeople);
            }
        }

        /// <summary>
        /// Представляет информацию о спецпакете путешествия в текстовом виде
        /// </summary>
        /// <returns></returns>
        public string GetSpecialPackageInfo()
        {
            string info = GetPackageInfo();
            info += $"Скидка: {Discount}%";
            info += $"\nКоличество людей, необходимое для действия скидки: {NumberOfPeopleNeedForDiscount}\n";
            return info;
        }
    }
}
