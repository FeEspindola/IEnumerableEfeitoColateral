using static System.Console;
using System.Collections.Generic;
using System.Linq;

namespace IEnumerableEfeitoColateral
{
    class Program
    {
        static void Main(string[] args)
        {

            // implementação com lista

            var list = GenerateList();


            WriteLine("");
            WriteLine("List has been created");

            foreach (var value in list)
            {
                WriteLine($"The value {value} has been found.");
            }

            WriteLine("");
            WriteLine($"Count: {list.Count}");

            WriteLine("");
            WriteLine($"Any: {list.Any()}");

            WriteLine("");



            // implementação com Ienumerable
            // ienumerable é uma estrutura lazy somente leitura , cria outra copia


            var ienumerable = GenerateIenumerable();


            WriteLine("");
            WriteLine("List has been created");

            foreach (var value in ienumerable)
            {
                WriteLine($"The value {value} has been found.");
            }

            WriteLine("");
            WriteLine($"Count: {ienumerable.Count()}");

            WriteLine("");
            WriteLine($"Any: {ienumerable.Any()}");

            WriteLine("");

            ReadKey();





            List<int> GenerateList()
            {
                List<int> lista = new List<int>();

                for (int index = 0; index < 10; index++)
                {
                    WriteLine("");
                    lista.Add(index);
                }

                return lista;

            }

            IEnumerable<int> GenerateIenumerable()
            {
                for (int index = 0; index < 10; index++)
                {
                    WriteLine($"The value {index} has been added.");
                    yield return index;
                }
            }

        }
    }
}
