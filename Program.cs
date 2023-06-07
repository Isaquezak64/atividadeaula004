using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atividadeaula004
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string nome;
            string produto1;
            int quantidade;
            string produto2;
            int quantidade2;
            
            Console.WriteLine("Bem-vindo ao sistema de estoque do ZAK");
            Console.WriteLine("Digite o nome do funcionário responsável:");
            nome = Console.ReadLine();
            Console.WriteLine("\n\n");
            Console.WriteLine($"O cadastro de estoque será feito no nome de {nome}");
            Console.WriteLine("\n\n");
            Console.WriteLine("----- CADASTRO DE PRODUTOS");
            Console.WriteLine("Digite o nome do produto 1:");
            produto1 = Console.ReadLine();
            Console.WriteLine($"Digite a quantidade em estoque de {produto1}");
            quantidade = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Digite o nome do Produto 2:");
            produto2 = Console.ReadLine();
            Console.WriteLine($"Digite a quantidade em estoque de {produto2}");
            quantidade2 = Int32.Parse(Console.ReadLine());
            Console.WriteLine("\n\n");
            Console.WriteLine("- Os produtos foram cadastrados com sucesso!");
            Console.WriteLine("\n");
            Console.WriteLine($"----- LISTA DE PRODUTOS CADASTRADOS POR {nome} :");
            Console.WriteLine($"- {produto1} contém {quantidade} itens em estoque");
            Console.WriteLine($"- {produto2} contém {quantidade2}");
            Console.WriteLine($"Total de itens no estoque : {quantidade+quantidade2}");
            Console.WriteLine("\n\n");
            Console.WriteLine("vlw! FIM DO SISTEMA");
            Console.ReadKey();









        }
    }
}
