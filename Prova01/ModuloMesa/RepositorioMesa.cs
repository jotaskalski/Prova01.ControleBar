using Prova01_ControleDeBar.Compartilhado;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prova01_ControleDeBar.ModuloCliente
{
    internal class RepositorioMesa : RepositorioBase
    {
        public RepositorioMesa(ArrayList listaMesa)
        {
            registros = listaMesa;
        }
        public override EntidadeBase SelecionarPorId(int id)
        {
            return (EntidadeMesa)base.SelecionarPorId(id);
        }
    }
}
