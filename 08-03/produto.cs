using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08_03
{
    public class produto
    {
        private int Id;
        private string Descricao;
        private decimal Valor;
    
        public produto(int id,string descricao, decimal valor)
        {
            Id = id;
            Descricao = descricao;
            Valor = valor;
        }
    }

}
