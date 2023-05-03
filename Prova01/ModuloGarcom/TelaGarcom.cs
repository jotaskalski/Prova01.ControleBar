using ControleDeBar.ConsoleApp.Compartilhado;
using Prova01_ControleDeBar.Compartilhado;
using Prova01_ControleDeBar.ModuloCliente;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace Prova01_ControleDeBar.ModuloGarcom
{
    internal class TelaGarcom : TelaBase
    {

        public TelaGarcom(RepositorioGarcom repositorioGarcom)
        {
            repositorioBase = repositorioGarcom;
            nomeEntidade = "Garçom";
        }
        protected override void MostrarTabela(ArrayList registros)
        { 
            Console.WriteLine("{0,-10} |{1,-10} |{2,-10}", "ID", "Nome", "Telefone");
            foreach (EntidadeGarcom g in registros)
            {
                Console.WriteLine("{0,-10} |{1,-10} |{2,-10}", g.id, g.nome, g.telefone);
            }
            Console.ReadLine();

        }

        protected override EntidadeBase ObterRegistro()
        {            
            Console.WriteLine("Digite o nome do garçom:");
            string nome = Console.ReadLine();
            Console.WriteLine("Digite o telefone do garçom:");
            string telefone = Console.ReadLine();
            EntidadeGarcom garcom = new EntidadeGarcom(nome, telefone);
            return garcom;
        }
    }
}
