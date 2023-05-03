using Prova01_ControleDeBar.Compartilhado;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prova01_ControleDeBar.ModuloCliente
{
    internal class EntidadeMesa : EntidadeBase
    {
        public int mesaNumero;

        public EntidadeMesa(int mesaNumero)
        {
            this.mesaNumero = mesaNumero;
        }

        public int MesaNumero { get; set; }


        public override void AtualizarInformacoes(EntidadeBase registroAtualizado)
        {
            EntidadeMesa mesa = (EntidadeMesa)registroAtualizado;
            this.mesaNumero = mesa.mesaNumero;
        }

        public override ArrayList ValidarErros()
        {
            ArrayList listaErros = new ArrayList();
            return listaErros;
        }
    }
}
