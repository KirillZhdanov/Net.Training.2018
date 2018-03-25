using System;
using Car;

class Program
{
    static void Main()
    {
        SportCar obj = new SportCar();
        obj.InfoSportCar(); 
        
        MiniCar obj2 = new MiniCar();
        obj2.MiniInfo();
        Auto obj1=new Auto();
        obj1.Info();

        
      
        Console.ReadLine();
    }
}