using System;
namespace SOLID_Pattern
{
    public class Fogao : Produto
    {
        public Fogao(string nomeProduto, decimal precoProduto) : base(nomeProduto, precoProduto)
        {

        }

        public override void AplicarDesconto()
        {
            this.preco = this.preco * .75M;
        }

        public override string ObterCaracteristica()
        {
            return "Fogão 4 bocas";
        }
    }
}