using System;

// 1 - Você precisa usar o namespace para usar a classe em outros arquivos
namespace AulaCsharp;

public class Teste
{
    public Teste()
    {
        //
        // TODO: Add constructor logic here
        //
    }

    public bool is_par(int num)
    {
        return (num % 2 == 0);
    }

    public void show_int_list(List<int> list)
    {
        for (int i = 0; i < list.Count; i++)
        {
            Console.WriteLine(list[i]);
        }
    }

    public void show_str_list(List<string> list)
    {
        for (int i = 0; i < list.Count; i++)
        {
            Console.WriteLine(list[i]);
        }
    }

}
