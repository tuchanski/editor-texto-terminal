namespace EditorDeTexto.CLI;

public class Edit
{
    public static void Changing() // Funcao para editar texto
    {
        Console.Clear();
        Console.WriteLine("[Right Arrow (->) - Sair] Digite seu texto abaixo: ");
        Console.WriteLine("--------------------------------------");
        string text = "";

        do
        {
            text += Console.ReadLine();
            text += Environment.NewLine;
        } while (Console.ReadKey().Key != ConsoleKey.RightArrow);

        Save(text);
    }

    public static void Save(string text) // Funcao para salvar texto
    {
        Console.Clear();
        Console.WriteLine("Informe o destino do arquivo: "); // Ex: C:\teste\teste.txt
        var path = Console.ReadLine();

        using (var file = new StreamWriter(path))
        {
            file.Write(text);
        }

        Console.WriteLine($"Arquivo {path} salvo com sucesso!\nPressione qualquer tecla: ");
        Console.ReadKey();
        Menu.Show();
    }
}