using System;
using MyLibrary;

namespace OOP_4._2
{
   
    class Program
    {
        static void Main(string[] args)
        {
            MyConsole.StartCyrillic();

            Vehicle vehicle = new Vehicle(4, 10);
            vehicle.Showv();
            Console.WriteLine();

            Car car = new Car(5, 6, 12);
            car.Show();
            Console.WriteLine();

            Truck truck = new Truck(2500, 4, 15);
            truck.Show();
            Console.WriteLine();
        }
    }
    //2. Используя следующий фрагмент, создайте соответствующие конструкторы
    //Car() и Truck(). 

    class Vehicle
    {       // базовый класс автомобилей для разных типов 
        int num_wheels;
        int range;
        public Vehicle(int w, int r)
        {
            num_wheels = w;
            range = r;
        }

        public void Showv()
        {
            Console.WriteLine("Число колес: " + num_wheels);
            Console.WriteLine("Грузоподъемность: " + range);
        }
    }

    class Car : Vehicle
    {       //Легковушка
        int passengers;
        // Вставьте здесь конструктор car

        public Car(int passengers, int w, int r) : base (w, r)
        {
            this.passengers = passengers;
        }
        public void Show()
        {
            Showv();
            Console.WriteLine("Пассажироемкость: " + passengers);
        }
    }

    class Truck : Vehicle
    {               //Грузовик
        int loadlimit;
        // Вставьте здесь конструктор truck

        public Truck(int loadlimit, int w, int r) : base(w, r)
        {
            this.loadlimit = loadlimit;
        }
        public void Show()
        {
            Showv(); Console.WriteLine("Пробег: " + loadlimit);
        }
    }

}
