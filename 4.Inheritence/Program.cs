using System;

// Lớp cơ sở
public class Animal
{
    public void Eat()
    {
        Console.WriteLine("Animal is eating.");
    }

    public void Sleep()
    {
        Console.WriteLine("Animal is sleeping.");
    }
}

public interface Smart
{
    public void AnimalSmart();
}

// Lớp kế thừa
public class Dog : Animal, Smart
{
    public void AnimalSmart()
    {
        Console.WriteLine("Dog was implement form interface");
    }

    public void Bark()
    {
        Console.WriteLine("Dog is barking.");
    }
}

// Lớp kế thừa khác
public class Cat : Animal
{
    public void Meow()
    {
        Console.WriteLine("Cat is meowing.");
    }
}

class Program
{
    static void Main(string[] args)
    {
        // Tạo một đối tượng của lớp kế thừa Dog
        Dog dog = new Dog();
        dog.Eat();  // Gọi phương thức từ lớp cơ sở
        dog.Sleep(); // Gọi phương thức từ lớp cơ sở
        dog.Bark(); // Gọi phương thức từ lớp con
        dog.AnimalSmart();

        // Tạo một đối tượng của lớp kế thừa Cat
        Cat cat = new Cat();
        cat.Eat();  // Gọi phương thức từ lớp cơ sở
        cat.Sleep(); // Gọi phương thức từ lớp cơ sở
        cat.Meow(); // Gọi phương thức từ lớp con
    }
}
