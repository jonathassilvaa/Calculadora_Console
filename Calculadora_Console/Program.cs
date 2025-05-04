using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculadora_Console
{
    class Program
    {
        enum Menu { Soma = 1,Subtracao,Divisao,Multiplicacao,Potencia,Raiz,Sair}
        static void Main(string[] args)
        {
            bool escolheuSair = false;
            while (!escolheuSair)
            {
                //exiba o menu
                Console.WriteLine("SELECIONE UMA DAS OPCOES:");
                Console.WriteLine("1-SOMA\n2-SUBTRACAO\n3-DIVISAO\n4-MULTIPLICACAO\n5-POTENCIACAO\n6-RAIZ\n7-SAIR");
                Menu opcao = (Menu)int.Parse(Console.ReadLine());

                switch (opcao)
                {
                    case Menu.Soma:
                        Soma();
                        break;
                    case Menu.Subtracao:
                        Subtracao();
                        break;
                    case Menu.Divisao:
                        Divisao();
                        break;
                    case Menu.Multiplicacao:
                        Multiplicacao();
                        break;

                    case Menu.Potencia:
                        Potenciacao();
                        break;

                    case Menu.Raiz:
                        Raiz();
                        break;
                    case Menu.Sair:
                        escolheuSair = true;
                        break;
                    
                }
                Console.Clear();
            }





        }
        static void Soma()
        {
            Console.WriteLine("Soma de dois numeros");
            Console.Write("Digite o primeiro número:");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o segundo numero");
            int b = int.Parse(Console.ReadLine());
            int result = a + b;
            Console.WriteLine($"O resultado é {result}");
            Console.WriteLine("Aperte ENTER para voltar ao menu");
            Console.ReadLine();
        }

        static void Subtracao()
        {
            Console.WriteLine("Subtracao de dois numeros");
            Console.Write("Digite o primeiro número:");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o segundo numero");
            int b = int.Parse(Console.ReadLine());
            int result = a - b;
            Console.WriteLine($"O resultado é {result}");
            Console.WriteLine("Aperte ENTER para voltar ao menu");
            Console.ReadLine();
        }

        static void Divisao()
        {
            Console.WriteLine("Divisao de dois numeros");
            Console.Write("Digite o primeiro número:");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o segundo numero");
            int b = int.Parse(Console.ReadLine());
            float result = (float)a / (float)b;
            Console.WriteLine($"O resultado é {result}");
            Console.WriteLine("Aperte ENTER para voltar ao menu");
            Console.ReadLine();
        }

        static void Multiplicacao()
        {
            Console.WriteLine("Multiplicacao de dois numeros");
            Console.Write("Digite o primeiro número:");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o segundo numero");
            int b = int.Parse(Console.ReadLine());
            float result = (float)a * (float)b;
            Console.WriteLine($"O resultado é {result}");
            Console.WriteLine("Aperte ENTER para voltar ao menu");
            Console.ReadLine();
        }

        static void Potenciacao()
        {
            Console.WriteLine("Potencia de um numero");
            Console.Write("Digite o valor da base:");
            float baseNum = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o valor do expoente:");
            float expo = int.Parse(Console.ReadLine());
            float result = (int)Math.Pow(baseNum,expo);
            Console.WriteLine($"O resultado é {result}");
            Console.WriteLine("Aperte ENTER para voltar ao menu");
            Console.ReadLine();
        }

        static void Raiz()
        {
            Console.WriteLine("Raiz de um numero");
            Console.Write("Digite o numero:");
            float a = int.Parse(Console.ReadLine());
            double result = Math.Sqrt(a);
            Console.WriteLine($"O resultado é {result}");
            Console.WriteLine("Aperte ENTER para voltar ao menu");
            Console.ReadLine();
        }


    }
}
