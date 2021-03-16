using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharpWasher
{
    class Program
    {
        delegate void Wa(Car car);
        static void Main(string[] args)
        {
            Console.WriteLine("Look at a dirty car. If a car is clean you will see 'True'");
            Garage garage = new Garage();
            Car car1 = new Car("mazda");
            Car car2 = new Car("BMW");
            Car car3 = new Car("Toyota");
            garage.Add(car1);
            garage.Add(car2);
            garage.Add(car3);
            foreach (var car in garage)
            {
                Console.WriteLine(car.name + " " + car.clean);

            }
            Console.WriteLine("Lets wash all our cars. If car is clean you will see 'True'");
            foreach (var car in garage)
            {
                Washer washer = new Washer();
                Wa del = washer.Wash;
                del(car);
                Console.WriteLine(car.name + " " + car.clean);

            }
            Console.ReadKey();
        }
    }
}
