using TemplateMethod;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("El mismo código de cliente puede funcionar con diferentes subclases:");

        Client.ClientCode(new ConcreteClass1());

        Console.Write("\n");

        Console.WriteLine("El mismo código de cliente puede funcionar con diferentes subclases:");
        Client.ClientCode(new ConcreteClass2());
    }
}
