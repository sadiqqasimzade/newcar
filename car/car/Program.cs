using System;
using car.Model;
namespace car
{
    internal class Program
    {
        static void Main()
        {       
            Car car1 = new Car("Brand1", "Model1", 10, 1000, 2000,500);
            Car car2 = new Car("Brand2", "Model2", 10, 100, 2000);
            Car car3 = new Car("Brand3", "Model3", 10, 100, 2000,300,"black");
            Car car4 = new Car("Brand4", "Model4", 10, 100, 2000,"black");
             
          
            car1.ShowInfo();
            car2.ShowInfo();
            car3.ShowInfo();
            car4.ShowInfo();

            Console.WriteLine();

            
            car1.Drive(30);
            car2.Drive(30);
            car3.Drive(30);
            car4.Drive(30);



            Console.ReadLine();
        }
    }
}
