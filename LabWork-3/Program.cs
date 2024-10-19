//Использование методов для устранения дублирования кода
public class OrderService
{
    public double CalculateTotalPrice(int quantity, double price)
    {
        return quantity * price;
    }
    public void CreateOrder(string productName, int quantity, double price)
    {
        Console.WriteLine($"Order for {productName} created. Total: {CalculateTotalPrice(quantity, price)}");
    }
    public void UpdateOrder(string productName, int quantity, double price)
    {
        Console.WriteLine($"Order for {productName} updated. New total: {CalculateTotalPrice(quantity, price)}");
    }
}

//Использование общих базовых классов
public abstract class Vehicle
{
    public void Start()
    {
        Console.WriteLine($"{GetType().Name} is starting");
    }
    public void Stop()
    {
        Console.WriteLine($"{GetType().Name} is stopping");
    }
}

public class Car : Vehicle { }

public class Truck : Vehicle { }

//Произведите корректную(правильную) по вашему мнению реализацию с применением принципа KISS:
//Избегание чрезмерного использования абстракций

public class Calculator
{
    public int Add(int a, int b)
    {
        return a + b;
    }
}

//Избегание избыточного использования шаблонов проектирования
public class Do
{
    public void DoSomething()
    {
        Console.WriteLine("Doing something...");
    }
}

public class Client
{
    public void Execute()
    {
        Do doo = new Do();
        doo.DoSomething();
    }
}

//Произведите корректную(правильную) по вашему мнению реализацию с применением принципа YAGNI:

//Избыточное создание абстракций
public class Circle
{
    private double _radius;

    public Circle(double radius)
    {
        _radius = radius;
    }

    public double CalculateArea()
    {
        return Math.PI * _radius * _radius;
    }
}

public class Square
{
    private double _side;

    public Square(double side)
    {
        _side = side;
    }

    public double CalculateArea()
    {
        return _side * _side;
    }
}


//Излишняя параметризация методов
public class MathOperations
{
    public int Add(int a, int b)
    {
        return a + b;
    }
}


class Program
{
    static void Main(string[] args)
    {
    }
}
