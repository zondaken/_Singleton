namespace _Singleton;

public class Singleton1
{
    public int Value { get; set; }
    
    #region Singleton
    protected Singleton1() {}

    private static Singleton1? s_Instance = null; 
    
    public static Singleton1 Create()
    {
        return s_Instance ??= new Singleton1();
    }
    #endregion
}