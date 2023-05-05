using System;
using System.IO;

namespace editortexto
{
    class program 
    {

        static void Main(string[] args)
        {
            Menu();
        }
        static void Menu()
        {
            Console.Clear();
            Console.WriteLine("Oque você deseja fazer?");
            Console.WriteLine("1 - Abrir um arquivo");
            Console.WriteLine("2 - Criar um novo arquivo");
            Console.WriteLine("0 - Sair");
            short opçao = short.Parse(Console.ReadLine());

            switch (opçao)
            {
                case 0: System.Environment.Exit(0); break;
                case 1: Abrir(); break;
                case 2: Editar(); break;
                default: Menu(); break;
            }


        }
        static void Abrir()
        {
            Console.Clear();
            Console.WriteLine("-Qual o caminho do arquivo?");
            string Caminho = Console.ReadLine();

            using (var Arquivo = new StreamReader(Caminho))
            {

                string Texto = Arquivo.ReadToEnd();
                Console.WriteLine(Texto);

            }
            Console.WriteLine("");
            Console.ReadLine();
            Menu();

        }
        static void Editar()

        {
            Console.Clear();
            Console.WriteLine("digite seu texto abaixo:  " + "(ESC para SAIR)");
            Console.WriteLine("--------------------");
            string Texto = " ";

            do
            {
                Texto += Console.ReadLine();
                Texto += Environment.NewLine;
            }

            while (Console.ReadKey().Key != ConsoleKey.Escape);

            Salvar(Texto);

        }

        static void Salvar(string Texto)
        {
            Console.Clear();
            Console.WriteLine("-Qual caminho para salvar o arquivo?");
            var Caminho = Console.ReadLine();

            using (var Arquivo = new StreamWriter(Caminho))
            {
                Arquivo.Write(Texto);

            }

            Console.WriteLine($"Arquivo {Caminho} salvo com secesso!");
            Console.ReadLine();
            Menu();


        }
    }


}
