        // Const example

using System;

class Vehicle
{
    public const int wheels = 4;
}

class Program
{
    public static void Main()
    {
        Console.WriteLine("ഒരു വാഹനത്തിന്  " + Vehicle.wheels + " ചക്രങ്ങൾ ഉണ്ട്.");
    }
}


        // readonly example

using System;

class Car
{
    public readonly string model;

    public Car(string carModel)
    {
        model = carModel; // Constructor-ൽ assign ചെയ്യുന്നു
    }
}

class Program
{
    public static void Main()
    {
        Car c = new Car("Toyota");
        Console.WriteLine("കാറിന്റെ മോഡൽ: " + c.model);
    }
}