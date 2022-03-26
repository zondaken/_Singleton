namespace _Singleton;

public class SingletonData
{
    public int Value = 0;
}

public class Singleton2
{
    private static SingletonData? s_Data;

    private SingletonData _data;

    public int Value
    {
        get => _data.Value;
        set => _data.Value = value;
    }
    
    public Singleton2()
    {
        _data = s_Data ??= new SingletonData();
    }
}
