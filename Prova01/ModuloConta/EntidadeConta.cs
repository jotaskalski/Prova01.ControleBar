using Prova01_ControleDeBar.Compartilhado;
using Prova01_ControleDeBar.ModuloCliente;
using Prova01_ControleDeBar.ModuloGarcom;
using Prova01_ControleDeBar.ModuloPedidos;
using Prova01_ControleDeBar.ModuloProduto;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prova01_ControleDeBar.ModuloConta
{
    internal class EntidadeConta : EntidadeBase
    {
        public RepositorioMesa mesa;
        public EntidadeGarcom garcom;
        public ArrayList pedidos;
        public bool contaAberta;

        public EntidadeConta(RepositorioMesa mesa, EntidadeGarcom garcom, ArrayList pedidos, bool contaAberta)
        {
            this.mesa = mesa;
            this.garcom = garcom;
            this.pedidos = pedidos;
            this.contaAberta = contaAberta;
        }

        public override void AtualizarInformacoes(EntidadeBase registroAtualizado)
        {
            EntidadeConta registroConta = (EntidadeConta)registroAtualizado;
            contaAberta = registroConta.contaAberta;
            mesa = registroConta.mesa;
        }

        public override ArrayList ValidarErros()
        {
            ArrayList listaErros = new ArrayList();
            if (mesa == null)
                listaErros.Add("Mesa não cadastrada");
           
            return listaErros;
        }
        public void EncerrarConta(bool situacao)
        {
            contaAberta = situacao;
        }
        public void AnotarPedido(EntidadePedidos pedido)
        {
            pedidos.Add(pedido);
        }
    }
}
