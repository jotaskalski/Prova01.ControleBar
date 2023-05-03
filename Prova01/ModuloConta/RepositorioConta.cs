using Prova01_ControleDeBar.Compartilhado;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prova01_ControleDeBar.ModuloConta
{
    internal class RepositorioConta : RepositorioBase
    {
        private ArrayList arrayList;

        public RepositorioConta(ArrayList arrayList)
        {
            this.arrayList = arrayList;
        }
    }
}
