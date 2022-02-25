using System;

namespace interpretadordenumero
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string lernumeros = @"
                  __  __      __  __  __  __  __  __ 
                | __| __||__||__ |__    ||__||__||  |
                 ||__  __|   | __||__|   ||__| __||__|
    ";
            int numeros = 0;
            System.IO.StringReader LeitorNumeros = new System.IO.StringReader(lernumeros);
            string[] linha = new string[4];
            linha[0] = LeitorNumeros.ReadLine();

            linha[1] = LeitorNumeros.ReadLine();

            linha[2] = LeitorNumeros.ReadLine();

            linha[3] = LeitorNumeros.ReadLine();
            string linhaParaLer = "";

            Console.WriteLine(linha[1]);

            Console.WriteLine(linha[2]);

            Console.WriteLine(linha[3]);

            Console.WriteLine();
        volta:

            linhaParaLer = linha[1].Substring(numeros, 4) + linha[2].Substring(numeros, 4) + linha[3].Substring(numeros, 4);
           numeros += 4; 


            switch (linhaParaLer)
            {
                case "    " +
                     "   |" +
                     "   |":
                    Console.Write(1);
                    break;

                case " __ " +
                 " __|" +
                 "|__ ":
                    Console.Write(2);
                    break;

                case " __ " +
                     " __|" +
                     " __|":
                    Console.Write(3);
                    break;

                case "    " +
                     "|__|" +
                     "   |":
                    Console.Write(4);
                    break;

                case " __ " +
                     "|__ " +
                     " __|":
                    Console.Write(5);
                    break;
                case " __ " +
                     "|__ " +
                     "|__|":
                    Console.Write(6);
                    break;

                case " __ " +
                     "   |" +
                     "   |":
                    Console.Write(7);
                    break;

                case " __ " +
                     "|__|" +
                     "|__|":
                    Console.Write(8);
                    break;

                case " __ " +
                     "|__|" +
                     " __|":
                    Console.Write(9);
                    break;

                case " __ " +
                     "|  |" +
                     "|__|":
                    Console.Write(0);
                    break;
            }

            if ((numeros) < linha[1].Length)
                goto volta;


            Console.ReadLine();


        }
    }
}
