using System;
// 1️⃣ SINGLE INHERITANCE
class Vehicle
{
    public void Start()
    {
        Console.WriteLine("Vehicle started");
    }
}
class Car : Vehicle // Single Inheritance
{
    public void Drive()
    {
        Console.WriteLine("Car is driving");
    }
}
// 2️⃣ MULTILEVEL INHERITANCE
class SportsCar : Car // Car → SportsCar
{
    public void TurboBoost()
    {
        Console.WriteLine("SportsCar has turbo boost");
    }
}
// 3️⃣ HIERARCHICAL INHERITANCE
class Bike : Vehicle // Vehicle → Bike
{
    public void Pedal()
    {
        Console.WriteLine("Bike is pedaling");
    }
}
// 4️⃣ MULTIPLE INHERITANCE (Interfaces Only)
interface IMovable
{
    void Move();
}
interface ISpeakable
{
    void Speak();
}
class Robot : IMovable, ISpeakable // Pure Multiple Inheritance via interfaces
{
    public void Move()
    {
        Console.WriteLine("Robot is moving");
    }
    public void Speak()
    {
        Console.WriteLine("Robot is speaking");
    }
}
// 5️⃣ HYBRID INHERITANCE (Class + Interfaces)
interface IAmphibious
{
    void Swim();
}
interface IHoverable
{
    void Hover();
}
class HybridVehicle : Car, IAmphibious, IHoverable // Car inherits Vehicle
{
    public void Swim()
    {
        Console.WriteLine("HybridVehicle is swimming");
    }
    public void Hover()
    {
        Console.WriteLine("HybridVehicle is hovering");
    }
    public void HybridFeature()
    {
        Console.WriteLine("HybridVehicle has multiple capabilities");
    }
}
class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("1. Single Inheritance");
        Car car = new Car();
        car.Start();   // from Vehicle
        car.Drive();   // from Car

        Console.WriteLine("\n2. Multilevel Inheritance");
        SportsCar sport = new SportsCar();
        sport.Start();        // from Vehicle
        sport.Drive();        // from Car
        sport.TurboBoost();   // from SportsCar

        Console.WriteLine("\n3. Hierarchical Inheritance");
        Bike bike = new Bike();
        bike.Start();   // from Vehicle
        bike.Pedal();   // from Bike

        Console.WriteLine("\n4. Multiple Inheritance (Interfaces Only)");
        Robot robot = new Robot();
        robot.Move();    // from IMovable
        robot.Speak();   // from ISpeakable

        Console.WriteLine("\n5. Hybrid Inheritance");
        HybridVehicle hv = new HybridVehicle();
        hv.Start();           // from Vehicle
        hv.Drive();           // from Car
        hv.Swim();            // from IAmphibious
        hv.Hover();           // from IHoverable
        hv.HybridFeature();   // own method
    }
}