using System;

// Lớp cơ sở
public class Animal
{
    // Phương thức ảo (virtual method)
    public virtual void MakeSound()
    {
        Console.WriteLine("Animal makes a sound.");
    }
}

// Lớp kế thừa
public class Dog : Animal
{
    // Ghi đè phương thức từ lớp cơ sở
    public override void MakeSound()
    {
        Console.WriteLine("Dog barks.");
    }
}

// Lớp kế thừa khác
public class Cat : Animal
{
    // Ghi đè phương thức từ lớp cơ sở
    public override void MakeSound()
    {
        Console.WriteLine("Cat meows.");
    }
}

class Program
{
    static void Main(string[] args)
    {
        // Tạo một đối tượng của lớp cơ sở
        Animal animal;

        // Tạo đối tượng của lớp kế thừa Dog
        animal = new Dog();
        animal.MakeSound(); // Phương thức gọi từ đối tượng của lớp con

        // Tạo đối tượng của lớp kế thừa Cat
        animal = new Cat();
        animal.MakeSound(); // Phương thức gọi từ đối tượng của lớp con
    }
}
