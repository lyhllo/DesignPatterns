using BridgeDesignPattern;

class Program
{
    static void Main(string[] args)
    {
        Client client = new Client();

        Abstraction abstraction;
        // O código do cliente deve estar apto a trabalhar com qualquer
        // combinação de Abstração - Implementação.
        abstraction = new Abstraction(new ConcreteImplementationA());
        client.ClientCode(abstraction);

        Console.WriteLine();

        abstraction = new ExtendedAbstraction(new ConcreteImplementationB());
        client.ClientCode(abstraction);
    }
}