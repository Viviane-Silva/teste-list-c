// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");

class Program
{
    static void Main(string[] args)
    {
        List<int> MinhaLista = new List<int>();


        Console.WriteLine("Digite um número: ");
        //adicionar números a lista
        int i = 0;
        while ( i  < 5)
        {
            MinhaLista.Add(int.Parse(Console.ReadLine()));
            i++;
        }
        //MinhaLista.Add(int.Parse(Console.ReadLine()));

        Console.WriteLine("Você digitou esse números: " + String.Join(",",MinhaLista));
    }
}