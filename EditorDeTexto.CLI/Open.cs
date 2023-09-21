namespace EditorDeTexto.CLI;

public class Open
{
    public static void Opening()
    {
        Console.Clear();
        Console.WriteLine("Informe o caminho do arquivo: "); // ex: C:\teste\teste.txt
        string path = Console.ReadLine();

        using (var file = new StreamReader(path))
        {
            string text = file.ReadToEnd();
            Console.WriteLine(text);
        }

        Console.WriteLine("\nPressione qualquer tecla: ");
        Console.ReadKey();
        Menu.Show();
    }
}