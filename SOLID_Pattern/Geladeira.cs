using System;
namespace SOLID_Pattern
{
    public class Geladeira : Produto
    {
        public Geladeira(string nomeProduto, decimal precoProduto) : base(nomeProduto, precoProduto)
        {

        }

        public override void AplicarDesconto()
        {
            this.preco = this.preco * 0.8M;
        }

        public override string ObterCaracteristica()
        {
            return "Geladeira Frost Free";
        }
    }
}