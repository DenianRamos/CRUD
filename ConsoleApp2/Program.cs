using System;
using System.Linq.Expressions;

namespace ConsoleApp2
{
    internal class Program
    {
        enum Cor { Azul, Verde, Amarelo, Vermelho}
        enum Opcao {Criar = 1,Deletar,Editar,Listar,Atualizar};
        

        static void Main(string[] args) 
        {
            Console.WriteLine("Selecione uma das opções abaixo: ");
            Console.WriteLine("1-Criar\n2-Deletar\n3-Editar\n4-Listar\n5-Atualizar");
            int index = int.Parse(Console.ReadLine()); 
            
            Opcao OpcaoSelecionada = (Opcao)index;
            Console.WriteLine(OpcaoSelecionada);
            Console.ReadLine();
            switch(OpcaoSelecionada)
            {
                case Opcao.Criar:
                    Console.WriteLine("Criar");
                    break;
                case Opcao.Deletar:
                    Console.WriteLine("Deletar");
                    break;
                case Opcao.Editar:
                    Console.WriteLine("Editar");
                    break;
                case Opcao.Listar:
                    Console.WriteLine("Listar");
                    break;
                case Opcao.Atualizar:
                    Console.WriteLine("Atualizar");
                    break;
                default:
                    Console.WriteLine("Opção inválida");
                    break;
            }
            {
            
            }

        }
        
       
    }

}
