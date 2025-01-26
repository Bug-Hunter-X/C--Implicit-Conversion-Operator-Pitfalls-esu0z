public class MyClass
{
    public int MyProperty { get; set; }

    public MyClass(int value)
    {
        MyProperty = value;
    }

    public static explicit operator int(MyClass obj)
    {
        return obj.MyProperty;
    }

    public static explicit operator MyClass(int value)
    {
        return new MyClass(value);
    }
}

public class Program
{
    public static void Main(string[] args)
    {
        MyClass obj1 = 10; // Implicit conversion from int to MyClass
        int value = (int)obj1;  // Explicit conversion from MyClass to int

        Console.WriteLine(value); // Output: 10

        MyClass obj2 = new MyClass(20);
        int value2 = (int)obj2 + 5; // Explicit conversion, addition

        Console.WriteLine(value2); // Output: 25

        MyClass obj3 = (MyClass)((int)obj2 + 5); // Explicit conversion in both operands, then explicit conversion in result
        Console.WriteLine((int)obj3); // Output: 25
    }
}