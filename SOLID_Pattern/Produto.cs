using System;
using System.Data;

namespace SOLID_Pattern
{
    public abstract class Produto
    {
        public String nome { get; set; }
        public Decimal preco { get; set; }

        private const decimal DESCONTO_PADRAO = .3M;

        public Produto(string nomeProduto, decimal precoProduto)
        {
            this.nome = nomeProduto ?? throw new ArgumentNullException();
            this.preco = precoProduto;
        }

        public virtual void AplicarDesconto()
        {
            this.preco = this.preco * DESCONTO_PADRAO;
        }

        public abstract string ObterCaracteristica();
    }
}