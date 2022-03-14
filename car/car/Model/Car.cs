using System;
using System.Collections.Generic;
using System.Text;


namespace car.Model
{
    internal class Car:Vehicle
    {
        public string Brand;                  //ozum arasdirdim private yazmaq lazimdi ki deyisenlere ancaq konstruktorda qiymet vere bilek ancaq kecmemisik =(
        public string Model;                  //
        public double FuelFor1Km;             //
        public double FuelCapacity;           //
        public double CurrentFuel;            //
                                              


        public Car(string Brand,string Model, double FuelFor1Km, double FuelCapacity,int year):base(year)
        {
            this.Brand = Brand;
            this.Model = Model;
            this.FuelFor1Km = FuelFor1Km;
            this.FuelCapacity = FuelCapacity;
        }
        public Car(string Brand, string Model, double FuelFor1Km, double FuelCapacity, int year,string color) : base(year,color)
        {
            this.Brand = Brand;
            this.Model = Model;
            this.FuelFor1Km = FuelFor1Km;
            this.FuelCapacity = FuelCapacity;
        }
        public Car(string Brand, string Model, double FuelFor1km, double FuelCapacity, int year, double CurrentFuel):this(Brand,Model,FuelFor1km,FuelCapacity,year)
        {
            this.CurrentFuel = CurrentFuel;
            if (CurrentFuel > FuelCapacity) Console.WriteLine($"WARNING {Model}:Current fuel cant be greater than Fuelcapacity");
        }

        public Car(string Brand, string Model, double FuelFor1km, double FuelCapacity, int year, double CurrentFuel, string color) : this(Brand, Model, FuelFor1km, FuelCapacity, year,color)
        {
            this.CurrentFuel = CurrentFuel;
            if (CurrentFuel > FuelCapacity) Console.WriteLine($"WARNING {Model}:Current fuel cant be greater than Fuelcapacity");
        }





        public void ShowInfo()
        {
            Console.WriteLine($@"
Brand:       {Brand}
Model:       {Model}
Fuel for KM: {FuelFor1Km}
Fuel cap:    {FuelCapacity}
Current Fuel:{CurrentFuel}
Year:        {year}
Corlor:      {color}"
);
        }
        public void Drive(double PathLength)
        {
            double result=CalculateForDrive(PathLength);

            if (result >= 0) Console.WriteLine($"After {PathLength}km {Model} will be with {result}L of fuel");
            else Console.WriteLine($"{Model}:Need {-result}L more fuel");
        }
        public double CalculateForDrive(double PathLength)
        {
            return ((CurrentFuel / FuelFor1Km) - PathLength) * FuelFor1Km;
        }
        

        
    }
}
