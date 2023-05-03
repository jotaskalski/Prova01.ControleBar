using ControleDeBar.ConsoleApp.Compartilhado;
using Prova01_ControleDeBar.Compartilhado;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prova01_ControleDeBar.ModuloCliente
{
    internal class TelaMesa : TelaBase
    {
        RepositorioMesa repositorioMesa;
        public TelaMesa(RepositorioMesa repositorioMesa)
        {
            repositorioBase = repositorioMesa;
            this.repositorioMesa = repositorioMesa;
            nomeEntidade = "Mesa";
            sufixo = "s";
        }
        protected override void MostrarTabela(ArrayList mesas)
        {       
            Console.WriteLine("{0,-10} |{1,-10}", "ID", "MESA");
            foreach (EntidadeMesa m in mesas)
            {
                Console.WriteLine("{0,-10} |{1,-10}", m.id, m.mesaNumero);
            }
            Console.ReadLine();

        }

        protected override EntidadeBase ObterRegistro()
        {
            Console.WriteLine("Digite o número da mesa:");
            int numero = Convert.ToInt32(Console.ReadLine());
            EntidadeMesa mesa = new EntidadeMesa(numero);
            return mesa;            
        }
    }
}
