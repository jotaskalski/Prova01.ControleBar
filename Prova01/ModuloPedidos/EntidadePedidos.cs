using Prova01_ControleDeBar.Compartilhado;
using Prova01_ControleDeBar.ModuloCliente;
using Prova01_ControleDeBar.ModuloGarcom;
using Prova01_ControleDeBar.ModuloProduto;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prova01_ControleDeBar.ModuloPedidos
{
    internal class EntidadePedidos : EntidadeBase
    {
        private object garcom1;
        private object mesa1;

        public EntidadeProduto produto { get; set; }
        public EntidadeMesa mesa { get; set; }
        public EntidadeGarcom garcom { get; set; }
        public int quantidade { get; set; }
        public EntidadePedidos(EntidadeProduto produto, EntidadeMesa mesa, EntidadeGarcom garcom, int quantidade)
        {
            this.produto = produto;
            this.mesa = mesa;
            this.garcom = garcom;
            this.quantidade = quantidade;
        }

        public EntidadePedidos(EntidadeProduto produto, int quantidade, object garcom1, object mesa1)
        {
            this.produto = produto;
            this.quantidade = quantidade;
            this.garcom1 = garcom1;
            this.mesa1 = mesa1;
        }

        public override void AtualizarInformacoes(EntidadeBase registroAtualizado)
        {
            EntidadePedidos pedidoAtualizado = (EntidadePedidos)registroAtualizado;
            mesa = pedidoAtualizado.mesa;
            produto = pedidoAtualizado.produto;
            garcom = pedidoAtualizado.garcom;          
        }

        public override ArrayList ValidarErros()
        {
            throw new NotImplementedException();
        }
    }
}
