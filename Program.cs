class HaloGeneric
{
    public void SapaUser<X>(X user)
    {
        Console.WriteLine("Halo User " + user);
    }
}

class Program
{
    static void Main(string[] args)
    {
        HaloGeneric halo = new HaloGeneric();

        halo.SapaUser<string>("Genta");

        Console.ReadLine();
    }
}