using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace enumSwitch
{
    internal class Program
    {
        enum Cor { Azul, Verde, Amarelo, Vermelho }

        enum Opcao { Criar = 1, Deletar, Editar, Listar, Atualizar }

        static void Main(string[] args)
        {
            Console.WriteLine("Selecione uma das opções: ");
            Console.WriteLine("1-Criar\n2-Deletar\n3-Editar\n4-Listar\n5-Atualizar");
            int index = int.Parse(Console.ReadLine());
            Opcao opcaoSelecionada = (Opcao)index;

            switch (opcaoSelecionada)
            {
                case Opcao.Criar:
                    Console.WriteLine("Vamos criar!");
                    break;
                case Opcao.Deletar:
                    Console.WriteLine("DELETANDO");
                    break;
                case Opcao.Editar:
                    Console.WriteLine("Vamos editar!");
                    break;
                case Opcao.Listar:
                    Console.WriteLine("Listagem completa");
                    break;
                case Opcao.Atualizar:
                    Console.WriteLine("Atualizando!");
                    break;
                default:
                    Console.WriteLine("Opção não encontrada!");
                    break;
            }
            

            Console.ReadLine();
        }
    }
}
