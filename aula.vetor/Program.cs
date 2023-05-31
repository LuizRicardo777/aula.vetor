using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace aula.vetor
{
    internal class Program
    {
        public static void Vetor1()
        {
            int[] vet2;
            int t;
            float media = 0;
            Random rand = new Random();
            Console.WriteLine("entre com  o tamanho");
            t = int.Parse(Console.ReadLine());
            vet2 = new int[t];


            for (int i = 0; i < t; i++)
            {
                vet2[i] = rand.Next(10, 50);
                media = vet2[i] + media;

            }
            media = media / (float)t;
            Console.WriteLine("a media é " + media);


            for (int i = 0; i < t; i++)
            {
                Console.WriteLine(vet2[i]);

            }

            Console.ReadKey();

        }

        public static void Vetor2()
        {


            int[] vet3;
            int t;

            int somaPar = 0, somaImp = 0;
            Random rand = new Random();
            Console.WriteLine("entre com  o tamanho");
            t = int.Parse(Console.ReadLine());
            vet3 = new int[t];

            for (int i = 0; i < t; i++)
            {
                vet3[i] = rand.Next(10, 50);

                if (vet3[i] % 2 == 0)
                {
                    somaPar = vet3[i] + somaPar;
                }
                else
                {
                    somaImp = vet3[i] + somaImp;
                }

            }
            for (int i = 0; i < t; i++)
            {
                Console.WriteLine(vet3[i]);

            }
            Console.WriteLine(" a soma dos numeros pares é " + somaPar);
            Console.WriteLine(" a soma dos numeros impares é " + somaImp);

            Console.ReadKey();
        }
        public static void Vetor3()
        {

            int[] vet4;
            int t;
            Random rand = new Random();
            Console.WriteLine("entre com  o tamanho");
            t = int.Parse(Console.ReadLine());
            vet4 = new int[t];

            for (int i = 0; i < t; i++)
            {
                vet4[i] = rand.Next(10, 50);

            }
            for (int i = 0; i < t; i++)
            {
                Console.WriteLine("posição [{0}] = {1}", i, vet4[i]);



            }
            Console.WriteLine();
            for (int i = t - 1; i >= 0; i--)
            {

                Console.WriteLine("posição [{0}] = {1}", i, vet4[i]);


            }
        }

        public static void Vetor4()
        {
            float media = 0;
            int[] vet5;
            Console.WriteLine("entre com o tamanho");
            int t = int.Parse(Console.ReadLine());

            vet5 = new int[t];
            Random rand = new Random();

            for (int i = 0; i < t; i++)
            {
                vet5[i] = rand.Next(10, 50);


            }
            for (int i = 0; i < t; i++)
            {
                Console.WriteLine("posição [{0}] = {1}", i, vet5[i]);
                if (vet5[i] % 3 == 0 && vet5[i] % 5 == 0)
                {
                    media = vet5[i] + media;
                }


            }

            media = media / (float)t;
            Console.WriteLine("a media aridimentica é" + media);

            Console.ReadKey();
        }










        static void Main(string[] args)
        {

            int opcao;

            do
            {
                Console.WriteLine("=========MENU===========");
                Console.WriteLine("para SAIR DIGITE - 0 ");
                Console.WriteLine("EXERCICIO 1 ");
                Console.WriteLine("EXERCICIO 2 ");
                Console.WriteLine("EXERCICIO 3 ");
                Console.WriteLine("EXERCICIO 4 ");

                Console.WriteLine("===========================");

                opcao = int.Parse(Console.ReadLine());

                switch (opcao)
                {
                    case 0:
                        Console.WriteLine("obrigado por usar");
                        break;

                    case 1:
                        Vetor1();
                        break;
                    case 2:
                        Vetor2();
                        break;
                    case 3:
                        Vetor3();
                        break;
                    case 4:
                        Vetor4();
                        break;



                    default:
                        Console.WriteLine("essa opção não existe");
                        break;
                }
                Console.ReadKey();


                

            }while (opcao != 0);
    }
    }
}
