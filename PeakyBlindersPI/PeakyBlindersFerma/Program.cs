using System;

public class Program
{
    public static void Main()
    {
        Console.WriteLine(GetFermatMessage());
    }

    public static string GetFermatMessage()
    {
        return "Великая теорема Ферма: доказательство оставлено для потомков!";
    }

    // Определяем метод ProveFermat
    public static void ProveFermat()
    {
        throw new NotImplementedException("Proof is impossible.");
    }
}