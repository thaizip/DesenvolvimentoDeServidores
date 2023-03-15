using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.PortableExecutable;
using System.Text;
using System.Threading.Tasks;

namespace _08_03
{
    public class Veiculos
    {
        public int NumeroPortas;
        public int NumeroRodas;
        public string Cor;
        public int QuantidadeAcentos;
        public bool PagaImposto;


        public string ExibirDados()
        {
            return "Nº Portas: " + NumeroPortas + "  Cor:  " + Cor;
        }
    }

}
