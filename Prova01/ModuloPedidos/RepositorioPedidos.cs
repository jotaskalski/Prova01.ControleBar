using Prova01_ControleDeBar.Compartilhado;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prova01_ControleDeBar.ModuloPedidos
{
    internal class RepositorioPedidos : RepositorioBase
    {
        public RepositorioPedidos(ArrayList listaPedidos)
        {
            this.registros = listaPedidos;
        }
        public override EntidadeBase SelecionarPorId(int id)
        {
            return (EntidadePedidos)base.SelecionarPorId(id);
        }
    }
}
