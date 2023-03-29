using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista4PR2
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //Exercício 1.

            //Console.WriteLine("Essa afirmativa é falsa, pois uma variável float não cabe numa variável int.");
            //Console.WriteLine("Um possível jeito para resolvermos isso seria ultilizando o comando Math.Round.");
            //Console.WriteLine("");
            //Console.WriteLine("Exemplo: ");
            //Console.WriteLine("");
            //Console.WriteLine("float f = 10.2f");
            //Console.WriteLine("int i = (int)Math.Round(f);");
            //Console.WriteLine("Console.ReadLine();");
            //float f = 10.2f;
            //int i = (int)Math.Round(f);
            //Console.WriteLine("Console.WriteLine(" + i + ");");
            //Console.ReadLine();
            //Console.ReadKey();


            //Exercício 2.

            //Console.WriteLine("A diferença é que o Console.Read() lê apenas um caracter, já o Console.ReadLine() lê a linha inteira");
            //Console.ReadLine();
            //Console.ReadKey();


            //Exercício 3.

            //Console.WriteLine("Quando é necessário realizar a leitura de um valor, precisamos tomar cuidado para não colocar o valor do tipo errado. Além disso, precisamos tomar cuidado quando formos converter do tipo string para o tipo que utilizamos, pois pode acontecer de colocarmos um tipo que não colocamos no programa.");
            //Console.ReadLine();
            //Console.ReadKey();


            //Exercício 4.

            //Console.WriteLine("O objetivo desse programa é ver se o valor digitado corresponde com a mensagem 1 ou coma mensagem 2.");
            //Console.WriteLine("O programa está incorreto, pois faltam as chaves e o Console.ReadKey().");
            //Console.WriteLine("Com os erros concertados, se colocar o valor 8 aparecerá a mensagem 2, se colocar o nvalor 27 aparecerá a mensagem 27 e se colocar o valor 28 aparecerá a mensagem 1");
            //Console.ReadLine();
            //Console.ReadKey();


            //Exercício 5.


            //Exercício 6.

            //Random nAle = new Random();
            //int n = nAle.Next();

            //if (n % 3 == 0 && n % 5 == 0 && n % 10 == 0)
            //{
            //    Console.WriteLine("O número: " + n + " é divisível por 3, 5 e 10");
            //}
            //else
            //{
            //    if(n %3 == 0 && n %5 == 0)
            //    {
            //        Console.WriteLine("O número: " + n + " é divisível por 3 e por 5");
            //    }
            //    else
            //    {
            //        if(n %3 == 0)
            //        {
            //            Console.WriteLine("O número: " + n + " é divisível por 3");
            //        }
            //        else
            //        {
            //            if(n %5 == 0)
            //            {
            //                Console.WriteLine("O valor: " + n + " é divisível por 5");
            //            }
            //            else
            //            {
            //                Console.WriteLine("O valor: " + n + " não é divisível por 3,5 e por 10");
            //            }
            //        }
            //    }
            //}
            //Console.ReadKey();


            //Exercício 7.


            //Exercício 8.

            int q;
            float p, c, imp, vTotal, lLiq;
            string m;

            Console.WriteLine("=====MENU=====");
            Console.WriteLine("1- ROYAL");
            Console.WriteLine("2- WISKAS");
            Console.WriteLine("3- GOLDEN");
            Console.WriteLine("4- NUTRIEN");
            Console.WriteLine("5- SPECIALCAT");
            Console.WriteLine("6- MARBA");
            Console.WriteLine("7- GATUS");
            Console.WriteLine("Escolha a opção desejada: ");
            m = Console.ReadLine();
            Console.WriteLine("Digite a quantidade: ");
            q = int.Parse(Console.ReadLine());

            switch (m)
            {
                case "ROYAL":
                    lLiq = ((129.50f - 0.775f) - 0.33f);
                    break;
                
                case "WISKAS":

                    break;
                
                case "GOLDEN":

                    break;
                
                case "NUTRIEN":

                    break;
                
                case "SPECIALCAT":

                    break;
                
                case "MARBA":

                    break;
                
                case "GATUS":

                    break;
            }
        }
    }
}
