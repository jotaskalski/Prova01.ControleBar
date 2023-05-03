using Prova01_ControleDeBar.Compartilhado;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prova01_ControleDeBar.ModuloGarcom
{
    internal class RepositorioGarcom : RepositorioBase
    {
        public RepositorioGarcom(ArrayList arrayList)
        {
            registros = arrayList;
        }
        public override EntidadeGarcom SelecionarPorId(int id)
        {
            return (EntidadeGarcom)base.SelecionarPorId(id);
        }
    }
}
