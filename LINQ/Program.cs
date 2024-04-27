// LINQ Significa: language integrated query

List<string> list = new List<string> { "banana", "maça", "Feijoada" };

string user_input = Console.ReadLine();

// isso é um lambda function
var lambda = () => Console.WriteLine("hello from lambda");

List<string> result = list.Where(what_to_search => 
    what_to_search.Contains(user_input))
    .ToList();

var result2 = from x in list
              where x.Contains(user_input)
              orderby x ascending
              select x;

Console.WriteLine(result2);