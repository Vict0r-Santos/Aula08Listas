using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula08ListasRepeticao
{
    class Program
    {
        
        static List<string> nomes = new List<string>();
        static int posicao;
        static void Main(string[] args)
        {
            string option;
            

            Console.WriteLine("Cadastro de usuários:");
            Console.WriteLine("1- Cadastrar\n2- Buscar");
            Console.WriteLine("Escolha uma opção:");
            option = Console.ReadLine();

            if (option == "1") {

                Console.WriteLine("Qual nome deseja cadastrar?");
                nomes.Add(Console.ReadLine());
                Console.WriteLine("\n------------ Cadastro realizado com sucesso.\n\n");
                Main(null);
                
                return;

            }

            if (option == "2")
            {

                Console.WriteLine("Digite a posição que quer buscar");
                posicao = int.Parse(Console.ReadLine());
                Console.WriteLine($"Nome: {nomes[posicao]}");
                Console.ReadLine();
                Console.Clear();
                Main(null);
               
                return;

            }



            Console.ReadKey();
        }

        void Listas()
        {
            List<string> nomes = new List<string>();

            nomes.Add("Conrrrrrrrrrrrrrrado");
            nomes.Add("Metallica");
            nomes.Add("Iron Maiden");
            Console.WriteLine($"Nomes {nomes[0]} ");
            Console.WriteLine($"Nomes {nomes[1]} ");
            Console.WriteLine($"Nomes {nomes[2]} ");
            nomes.RemoveAt(0);

            int quantidades = nomes.Count;

            Console.WriteLine($"Existem {quantidades} itens na lista");

            Console.ReadKey();

        }
        void Arrays()
        {

            string[] nomes = new string[3];
            int[] idades = new int[3];

            nomes[0] = "";
            nomes[1] = "";
            nomes[2] = "";

            Console.WriteLine("Digite o primero nombre:");
            nomes[0] = Console.ReadLine();
            Console.WriteLine("Digite el nombre:");
            nomes[1] = Console.ReadLine();
            Console.WriteLine("Digite el nombre:");
            nomes[2] = Console.ReadLine();

            Console.WriteLine($"{ nomes[0]}, { nomes[1]} e { nomes[2]} são amigos do cartel");

            Console.ReadKey();

        }
    }
}

