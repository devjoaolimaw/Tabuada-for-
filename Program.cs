using System;

namespace Tabuada
{
    class Program
    {
        static void Main(string[] args)
        {
            Menu();
        }
        static void Menu()
        { 
            Console.Clear();
            Console.WriteLine("Qual tabuada deseja ver? ");
            Console.WriteLine();
            Console.WriteLine("1: Tabuada de + \n2: Tabuada de - \n3: Tabuada de x \n4: Tabuada de / \n0: Sair");

            Console.WriteLine();
            int opcao = Convert.ToInt32(Console.ReadLine());

            switch (opcao)
            {
                case 1: Soma(); break;
                case 2: Subtracao(); break;
                case 3: Multiplicacao(); break;
                case 4: Divisao(); break;
                default: Environment.Exit(0); break;
            }
        }

        static void Soma()
        { 
            Console.Clear();
            Console.Write("Deseja ver a tabuada de qual numero? ");
            int numero = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine();
            for(int contador = 0; contador <= 10; contador++)
            {
                 Console.WriteLine($"{numero} + {contador} = {numero + contador}");
            }
            Console.WriteLine();
            Console.WriteLine("Pressione qualquer tecla para voltar ao menu");
            Console.ReadKey();
            Menu();
        }


        static void Subtracao()
        { 
            Console.Clear();
            Console.Write("Deseja ver a tabuada de qual numero? ");
            int numero = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine();
            for(int contador = 0; contador <= 10; contador++)
            {
               Console.WriteLine($"{numero} - {contador} = {numero - contador}");
            }
            Console.WriteLine();
            Console.WriteLine("Pressione qualquer tecla para voltar ao menu");
            Console.ReadKey();
            Menu();
        }


        static void Multiplicacao()
        { 
            Console.Clear();
            Console.Write("Deseja ver a tabuada de qual numero? ");
            int numero = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine();
            for(int contador = 0; contador <= 10; contador++)
            {
               Console.WriteLine($"{numero} x {contador} = {numero * contador}");
            }
            Console.WriteLine();
            Console.WriteLine("Pressione qualquer tecla para voltar ao menu");
            Console.ReadKey();
            Menu();
        }


        static void Divisao()
        { 
            Console.Clear();
            Console.Write("Deseja ver a tabuada de qual numero? ");
            int numero = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine();
            for(int contador = 0; contador <= 10; contador++)
            {
                if (contador != 0)
                {
                    Console.WriteLine($"{numero} / {contador} = {numero / contador}");
                }
                else
                {
                    Console.WriteLine($"{numero} / {contador} = Indefinido");
                }
            }
            Console.WriteLine();
            Console.WriteLine("Pressione qualquer tecla para voltar ao menu");
            Console.ReadKey();
            Menu();
        }

    }
}