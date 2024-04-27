// 2 - É assim que se importa um namespace
// Você sempre vai querer
using AulaCsharp;

// "List" é como se fosse um genérico de Java 
// mude o "int" para qualquer tipo nos dois "<>" para alterar o tipo da lista
// para adicionar coisa use ".Add(<alguma coisa>)" ou inicie a "List" com os "{}"
List<int> lista_num = new List<int> { 413, 612, 111111 };
List<string> lista_str = new List<string> { "Hello", "World", "Banana" };

Teste teste = new Teste();

teste.show_int_list(lista_num);
teste.show_str_list(lista_str);

int numero1 = 2;
int numero2 = 7;
int soma = numero1 + numero2;

bool soma_maior_dez = (soma > 10);
bool e_multiplo = (numero2 % numero1 == 0);

