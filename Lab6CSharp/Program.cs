﻿using System;
using System.Collections;
using System.Collections.Generic;

// Завдання 1
interface IDetail
{
    void ShowDetail();
}

interface IMechanism
{
    void ShowMechanism();
}

interface IProduct
{
    void ShowProduct();
}

interface INode
{
    void ShowNode();
}

class Detail : IDetail
{
    public void ShowDetail()
    {
        Console.WriteLine("Detail");
    }
}

class Mechanism : IMechanism
{
    public void ShowMechanism()
    {
        Console.WriteLine("Mechanism");
    }
}

class Product : IProduct
{
    public void ShowProduct()
    {
        Console.WriteLine("Product");
    }
}

class Node : INode
{
    public void ShowNode()
    {
        Console.WriteLine("Node");
    }
}

// Завдання 2
interface ITrans
{
    void ShowInfo();
    int GetLoadCapacity();
}

enum VehicleType
{
    Car,
    Motorcycle,
    Truck
}

class VehicleBase
{
    protected string brand;
    protected string number;
    protected int speed;
    protected int loadCapacity;

    public VehicleBase(string brand, string number, int speed, int loadCapacity)
    {
        this.brand = brand;
        this.number = number;
        this.speed = speed;
        this.loadCapacity = loadCapacity;
    }
}

class Car : VehicleBase, ITrans
{
    public Car(string brand, string number, int speed, int loadCapacity)
        : base(brand, number, speed, loadCapacity) { }

    public void ShowInfo()
    {
        Console.WriteLine($"Car: Brand - {brand}, Number - {number}, Speed - {speed}, Load Capacity - {loadCapacity}");
    }

    public int GetLoadCapacity()
    {
        return loadCapacity;
    }
}

class Motorcycle : VehicleBase, ITrans
{
    private bool sidecar;

    public Motorcycle(string brand, string number, int speed, int loadCapacity, bool sidecar)
        : base(brand, number, speed, loadCapacity)
    {
        this.sidecar = sidecar;
        if (!sidecar) this.loadCapacity = 0;
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

class Truck : VehicleBase, ITrans
{
    private bool trailer;

    public Truck(string brand, string number, int speed, int loadCapacity, bool trailer)
        : base(brand, number, speed, loadCapacity)
    {
        this.trailer = trailer;
        if (trailer) this.loadCapacity *= 2;
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

// Завдання 3
enum ShapeType
{
    Rectangle,
    Circle
}

interface IShape
{
    double Area();
}

class Rectangle : IShape
{
    private double length;
    private double width;

    public Rectangle(double length, double width)
    {
        this.length = length;
        this.width = width;
    }

    public double Area()
    {
        return length * width;
    }
}

class Circle : IShape
{
    private double radius;

    public Circle(double radius)
    {
        this.radius = radius;
    }

    public double Area()
    {
        return Math.PI * radius * radius;
    }
}

class Program
{
    static void Main(string[] args)
    {
        // Завдання 1
        Detail detail = new Detail();
        Mechanism mechanism = new Mechanism();
        Product product = new Product();
        Node node = new Node();

        detail.ShowDetail();
        mechanism.ShowMechanism();
        product.ShowProduct();
        node.ShowNode();

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

        // Завдання 3
        IShape[] shapes = {
            new Rectangle(5, 6),
            new Circle(3)
        };

        foreach (var shape in shapes)
        {
            Console.WriteLine($"Area of shape: {shape.Area()}");
        }
    }
}
