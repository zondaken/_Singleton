namespace _Singleton;

public class Program
{
    public static void Main(string[] args)
    {
        #region Singleton1
        Singleton1 obj1 =  Singleton1.Create();
        Console.WriteLine(obj1.Value);
        obj1.Value = 42;
        Console.WriteLine(obj1.Value);
        
        Singleton1 obj2 = Singleton1.Create();
        Console.WriteLine(obj2.Value);
        #endregion

        Console.WriteLine();
        
        #region Singleton2
        Singleton2 instance1 = new Singleton2();
        Console.WriteLine(instance1.Value);
        instance1.Value = 42;
        Console.WriteLine(instance1.Value);
        
        Singleton2 instance2 = new Singleton2();
        Console.WriteLine(instance2.Value);
        #endregion
    }
}