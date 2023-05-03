using ControleDeBar.ConsoleApp.Compartilhado;
using Prova01_ControleDeBar.Compartilhado;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prova01_ControleDeBar.ModuloPedidos
{
    internal class TelaPedidos : TelaBase
    {
        private RepositorioPedidos repositorioPedidos;

        public TelaPedidos(RepositorioPedidos repositorioPedidos)
        {
            this.repositorioPedidos = repositorioPedidos;
        }

        protected override void MostrarTabela(ArrayList registros)
        {
            throw new NotImplementedException();
        }

        protected override EntidadeBase ObterRegistro()
        {
            throw new NotImplementedException();
        }
    }
}
