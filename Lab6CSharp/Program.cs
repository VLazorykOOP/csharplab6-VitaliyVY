using System;

// Завдання 2
interface ITrans
{
    void ShowInfo();
    int GetLoadCapacity();
}

class Car : ITrans
{
    private string brand;
    private string number;
    private int speed;
    private int loadCapacity;

    public Car(string brand, string number, int speed, int loadCapacity)
    {
        this.brand = brand;
        this.number = number;
        this.speed = speed;
        this.loadCapacity = loadCapacity;
    }

    public void ShowInfo()
    {
        Console.WriteLine($"Car: Brand - {brand}, Number - {number}, Speed - {speed}, Load Capacity - {loadCapacity}");
    }

    public int GetLoadCapacity()
    {
        return loadCapacity;
    }
}

class Motorcycle : ITrans
{
    private string brand;
    private string number;
    private int speed;
    private int loadCapacity;
    private bool hasSidecar;

    public Motorcycle(string brand, string number, int speed, int loadCapacity, bool hasSidecar)
    {
        this.brand = brand;
        this.number = number;
        this.speed = speed;
        this.loadCapacity = hasSidecar ? loadCapacity : 0;
        this.hasSidecar = hasSidecar;
    }

    public void ShowInfo()
    {
        Console.WriteLine($"Motorcycle: Brand - {brand}, Number - {number}, Speed - {speed}, Load Capacity - {loadCapacity}");
    }

    public int GetLoadCapacity()
    {
        return loadCapacity;
    }
}

class Truck : ITrans
{
    private string brand;
    private string number;
    private int speed;
    private int loadCapacity;
    private bool hasTrailer;

    public Truck(string brand, string number, int speed, int loadCapacity, bool hasTrailer)
    {
        this.brand = brand;
        this.number = number;
        this.speed = speed;
        this.loadCapacity = hasTrailer ? loadCapacity * 2 : loadCapacity;
        this.hasTrailer = hasTrailer;
    }

    public void ShowInfo()
    {
        Console.WriteLine($"Truck: Brand - {brand}, Number - {number}, Speed - {speed}, Load Capacity - {loadCapacity}");
    }

    public int GetLoadCapacity()
    {
        return loadCapacity;
    }
}

// Завдання 1
interface IUserInterface
{
    void Display();
}

interface IDotNetInterface
{
    void Method();
}

class Detail : IUserInterface, IDotNetInterface
{
    public void Display()
    {
        Console.WriteLine("Displaying Detail");
    }

    public void Method()
    {
        Console.WriteLine("Executing Method");
    }
}

class Mechanism : IUserInterface, IDotNetInterface
{
    public void Display()
    {
        Console.WriteLine("Displaying Mechanism");
    }

    public void Method()
    {
        Console.WriteLine("Executing Method");
    }
}

class Product : IUserInterface, IDotNetInterface
{
    public void Display()
    {
        Console.WriteLine("Displaying Product");
    }

    public void Method()
    {
        Console.WriteLine("Executing Method");
    }
}

class Node : IUserInterface, IDotNetInterface
{
    public void Display()
    {
        Console.WriteLine("Displaying Node");
    }

    public void Method()
    {
        Console.WriteLine("Executing Method");
    }
}

// Завдання 3 (додавання стандартних інтерфейсів .NET перерахування)
enum Weekdays
{
    Monday,
    Tuesday,
    Wednesday,
    Thursday,
    Friday,
    Saturday,
    Sunday
}

class Program
{
    static void Main(string[] args)
    {
        // Завдання 2
        ITrans[] vehicles = new ITrans[] {
            new Car("Toyota", "ABC123", 120, 500),
            new Motorcycle("Honda", "DEF456", 150, 200, true),
            new Truck("Volvo", "GHI789", 80, 1000, false)
        };

        foreach (var vehicle in vehicles)
        {
            vehicle.ShowInfo();
        }

        // Завдання 1
        IUserInterface[] interfaces = new IUserInterface[] {
            new Detail(),
            new Mechanism(),
            new Product(),
            new Node()
        };

        foreach (var ui in interfaces)
        {
            ui.Display();
        }

        // Завдання 3
        foreach (Weekdays day in Enum.GetValues(typeof(Weekdays)))
        {
            Console.WriteLine(day);
        }
    }
}
