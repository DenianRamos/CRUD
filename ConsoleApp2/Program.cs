using System;
using System.Collections.Generic;

namespace ConsoleApp2
{
    internal class Program
    {
        enum Opcao { Criar = 1, Deletar, Editar, Listar, Atualizar };

        static List<string> cores = new List<string>();

        static void Main(string[] args)
        {
            bool continuar = true;

            while (continuar)
            {
                Console.WriteLine("Selecione uma das opções abaixo: ");
                Console.WriteLine("1-Criar\n2-Deletar\n3-Editar\n4-Listar\n5-Atualizar\n6-Sair");
                int index = int.Parse(Console.ReadLine());

                Opcao opcaoSelecionada = (Opcao)index;

                switch (opcaoSelecionada)
                {
                    case Opcao.Criar:
                        CriarCor();
                        break;
                    case Opcao.Deletar:
                        DeletarCor();
                        break;
                    case Opcao.Editar:
                        EditarCor();
                        break;
                    case Opcao.Listar:
                        ListarCores();
                        break;
                    case Opcao.Atualizar:
                        AtualizarCor();
                        break;
                    default:
                        continuar = false;
                        break;
                }
            }
        }

        static void CriarCor()
        {
            Console.WriteLine("Digite o nome da cor:");
            string nome = Console.ReadLine();
            cores.Add(nome);
            Console.WriteLine("Cor criada com sucesso!");
        }

        static void DeletarCor()
        {
            ListarCores();
            Console.WriteLine("Digite o número da cor que deseja deletar:");
            int index = int.Parse(Console.ReadLine());
            if (index >= 0 && index < cores.Count)
            {
                cores.RemoveAt(index);
                Console.WriteLine("Cor deletada com sucesso!");
            }
            else
            {
                Console.WriteLine("Índice inválido!");
            }
        }

        static void EditarCor()
        {
            ListarCores();
            Console.WriteLine("Digite o número da cor que deseja editar:");
            int index = int.Parse(Console.ReadLine());
            if (index >= 0 && index < cores.Count)
            {
                Console.WriteLine("Digite o novo nome da cor:");
                string novoNome = Console.ReadLine();
                cores[index] = novoNome;
                Console.WriteLine("Cor editada com sucesso!");
            }
            else
            {
                Console.WriteLine("Índice inválido!");
            }
        }

        static void ListarCores()
        {
            Console.WriteLine("Cores disponíveis:");
            for (int i = 0; i < cores.Count; i++)
            {
                Console.WriteLine($"{i}: {cores[i]}");
            }
        }

        static void AtualizarCor()
        {
            ListarCores();
            Console.WriteLine("Digite o número da cor que deseja atualizar:");
            int index = int.Parse(Console.ReadLine());
            if (index >= 0 && index < cores.Count)
            {
                Console.WriteLine("Digite o novo nome da cor:");
                string novoNome = Console.ReadLine();
                cores[index] = novoNome;
                Console.WriteLine("Cor atualizada com sucesso!");
            }
            else
            {
                Console.WriteLine("Índice inválido!");
            }
        }
    }
}
