class HaloGeneric
{
    public void SapaUser<X>(X user)
    {
        Console.WriteLine("Halo User " + user);

    }
}

﻿class DataGeneric<T>
{
    private T Data {get; set;}

    public DataGeneric(T data)
    {
        Data = data;
    }

    public void PrintData()
    {
        Console.WriteLine("Data yang tersimpan adalah " + Data);
    }
}

class Program
{
    static void Main(string[] args)
    {
        HaloGeneric halo = new HaloGeneric();

        halo.SapaUser<string>("Genta");

        DataGeneric<string> data = new DataGeneric<string>("103022400067");
        data.PrintData();
        Console.ReadLine();
    }
}