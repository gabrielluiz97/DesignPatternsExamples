using DesignPatterns._01_Creational._1._1___AbstractFactory;
using DesignPatterns._01_Creational._1._2___FactoryMethod;
using DesignPatterns._02_Structural._2._1_Adapter;
using DesignPatterns._02_Structural._2._2_Facade;
using DesignPatterns._02_Structural._2._3_Composite;
using DesignPatterns._03_Behavoral._3._1_Command;
using DesignPatterns._03_Behavoral._3._2_Strategy;
using DesignPatterns._03_Behavoral._3._3_Observable;

public static class Program
{
    private static void Main()
    {
        Console.WriteLine("Escolha a operação:");
        Console.WriteLine("----------------------------------------------------");
        Console.WriteLine("Creational Patterns");
        Console.WriteLine("----------------------------------------------------");
        Console.WriteLine("1 - Abstract Factory");
        Console.WriteLine("2 - Method Factory");
        Console.WriteLine("----------------------------------------------------");
        Console.WriteLine("Structural Patterns");
        Console.WriteLine("----------------------------------------------------");
        Console.WriteLine("3 - Adapter");
        Console.WriteLine("4 - Facade");
        Console.WriteLine("5 - Composite");
        Console.WriteLine("----------------------------------------------------");
        Console.WriteLine("Behavioral Patterns");
        Console.WriteLine("----------------------------------------------------");
        Console.WriteLine("6 - Command");
        Console.WriteLine("7 - Strategy");
        Console.WriteLine("8 - Observer");


        var opcao = Console.ReadKey();
        Console.WriteLine("");

        switch (opcao.KeyChar)
        {
            case '1':
                ExecucaoAbstractFactory.Executar();
                break;           
            case '2':
                ExecucaoFactoryMethod.Executar();
                break;
            case '3':
                ExecucaoAdapter.Executar();
                break;           
            case '4':
                ExecucaoFacade.Executar();
                break;          
            case '5':
                ExecucaoComposite.Executar();
                break;            
            case '6':
                ExecucaoCommand.Executar();
                break;         
            case '7':
                ExecucaoStrategy.Executar();
                break;          
            case '8':
                ExecucaoObserver.Executar();
                break;         
            default:
            {
                Console.WriteLine("Opção escolhida é inválida.");
                Main();
                break;
            }

        }

    }
}
