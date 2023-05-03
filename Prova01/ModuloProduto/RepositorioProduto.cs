using Prova01_ControleDeBar.Compartilhado;
using System.Collections;


namespace Prova01_ControleDeBar.ModuloProduto
{
    public class RepositorioProduto : RepositorioBase
    {
        public RepositorioProduto(ArrayList listaProdutos)
        {
            registros = listaProdutos;
        }
        public override EntidadeBase SelecionarPorId(int id)
        {
            return (EntidadeProduto)base.SelecionarPorId(id);
        }
    }
}
