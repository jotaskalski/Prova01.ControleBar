using ControleDeBar.ConsoleApp.Compartilhado;
using Prova01_ControleDeBar.Compartilhado;
using Prova01_ControleDeBar.ModuloCliente;
using Prova01_ControleDeBar.ModuloGarcom;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace Prova01_ControleDeBar.ModuloProduto
{
    internal class TelaProduto : TelaBase
    {
        public TelaProduto(RepositorioProduto repositorioProduto)
        {
            repositorioBase = repositorioProduto;
            nomeEntidade = "Produto";
            sufixo = "s";
        }
        protected override void MostrarTabela(ArrayList produtos)
        {
            Console.WriteLine("{0,-10} |{1,-10} |{2,-10}", "ID", "Produto", "Preço");
            foreach (EntidadeProduto p in produtos)
            {
                Console.WriteLine("{0,-10} |{1,-10} |{2,-10}", p.id, p.nome, p.valor);
            }
            Console.ReadLine();

        }
        protected override EntidadeBase ObterRegistro()
        {
            Console.WriteLine("Digite o nome produto:");
            string nome = Console.ReadLine();
            Console.WriteLine("Digite o valor do produto:");
            int valor = int.Parse(Console.ReadLine());
            EntidadeProduto produto = new EntidadeProduto(nome, valor);            
            return new EntidadeProduto(nome, valor);
        }
    }
}
