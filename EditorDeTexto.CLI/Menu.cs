namespace EditorDeTexto.CLI;

public static class Menu
{
    public static void Show()
    {
        Console.Clear();
        Console.WriteLine("Modos de uso:\n1 - Abrir arquivo\n2 - Criar novo arquivo\n0 - Encerrar programa");
        short option = short.Parse(Console.ReadLine());

        switch (option)
        {
            case 0:
            {
                Console.WriteLine("\nObrigado por utilizar o programa - encerrando...");
                System.Environment.Exit(0);
                break;
            }

            case 1:
                Open.Opening();
                break; // Abrir projeto txt
            case 2:
                Edit.Changing();
                break; // Criar um projeto txt
            default:
                Menu.Show();
                break;
        }
    }
}