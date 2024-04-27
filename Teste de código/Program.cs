
void show_options()
{
    Console.WriteLine("Escolha:");
    Console.WriteLine("1 - verificar se o número é par");
    Console.WriteLine("2 - adicionar item na lista");
    Console.WriteLine("3 - Mostrar lista");
    Console.WriteLine("4 - Pesquisar na lista");
    Console.WriteLine("5 - Remover item da lista");
    Console.WriteLine("6 - Sair");
}

bool is_par(int number)
{
    return (number % 2 == 0);
}

List<int> lista = new List<int>();

while(true)
{
    show_options();

    bool is_choice_valid = int.TryParse(Console.ReadLine(), out int choice);
    bool is_number_valid = int.TryParse(Console.ReadLine(), out int number);

    if(!is_choice_valid || !is_number_valid)
    {
        Console.Clear();
        Console.WriteLine("Você digitou uma letra ao invés de números");
    }

    switch (choice)
    {
        case 1:
            if(is_par(number))
            {
                Console.WriteLine("{0} é par", number);
            }
            else
            {
                Console.WriteLine("{0} não é par", number);
            }
        break;

        case 2:
            Console.WriteLine("Adicionando item a lista");

            lista.Add(number);
        break;

        case 3:
            for (int i = 0; i < lista.Count; i++)
            {
                Console.WriteLine("{0} - {1}", i + 1, lista[i]);
            }
        break;

        case 4:
            Console.Write("Digite o indice do item: ");

            int index = int.Parse(Console.ReadLine());
            int removido = lista[index - 1];

            Console.WriteLine("Removendo {0}...", removido);
            lista.RemoveAt(index - 1);
            break;

        case 5:
            Console.WriteLine("Saindo...");
        break;

        default:
            Console.WriteLine("Opção desconhecida");
        break;
    }

}