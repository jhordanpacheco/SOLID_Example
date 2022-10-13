using System;
using System.Data;

namespace SOLID_Pattern
{
    public class ProdutoRepository
    {
        private IDbConnection Connection { get; set; }

        public ProdutoRepository(IDbConnection connection)
        {
            Connection = connection;
        }

        public void Save()
        {
            //TO DO
        }
    }
}